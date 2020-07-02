using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace ShowTestResults
{
    public partial class ShowTestResultsFrm : Form
    {
        private readonly Results _results;
        private readonly HistoryOfTest _historyOfTest;
        private DataSet _searchResultsDataSet;
        private DataTable _testDetailsTable;

        public ShowTestResultsFrm()
        {
            InitializeComponent();
            _results = new Results();
            _historyOfTest = new HistoryOfTest();

            InitialiseProjectsCombobox();
            InitialiseEnvironmentsCombobox();

            testsRanAfterDateTimePicker.Format = DateTimePickerFormat.Custom;
            testsRanAfterDateTimePicker.CustomFormat = "ddd dd MMM yyyy HH:mm";
        }

        private void InitialiseEnvironmentsCombobox()
        {
            var items = ReadListFromFile(@".\Config\Environments.txt");
            environmentsDropdown.Items.Clear();
            environmentsDropdown.Items.AddRange(items);
            environmentsDropdown.Text = items[0];
        }

        private void InitialiseProjectsCombobox()
        {
            var items = ReadListFromFile(@".\Config\Projects.txt");
            projectsDropdown.Items.Clear();
            projectsDropdown.Items.AddRange(items);
            projectsDropdown.Text = items[0];

            projectsDropdownOnHistoryTab.Items.Clear();
            projectsDropdownOnHistoryTab.Items.AddRange(items);
            projectsDropdownOnHistoryTab.Text = items[0];
        }

        private string[] ReadListFromFile(string fileName)
        {
            var allLinesText = File.ReadAllLines(fileName).ToArray();
            return allLinesText;
        }

        private void SearchResultsButton_Click(object sender, EventArgs e)
        {
            _searchResultsDataSet = FetchResults();

            var testSummaryTable = _searchResultsDataSet.Tables[0];
            _testDetailsTable = _searchResultsDataSet.Tables[1];

            if (_testDetailsTable.Rows.Count == 0)
            {
                MessageBox.Show("No test results are found. Try other search criteria.");
                return;
            }

            summaryGrid.DataSource = testSummaryTable;
            summaryGrid.Refresh();
            summaryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (_testDetailsTable.Rows.Count == 0)
            {
                detailsGrid.DataSource = null;
                detailsGrid.Refresh();
                return;
            }

            detailsGrid.DataSource = _testDetailsTable;
            detailsGrid.Columns["TestSummary"].Width = 300;
            detailsGrid.Refresh();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnyText.Text))
            {
                detailsGrid.DataSource = _testDetailsTable;
                detailsGrid.Refresh();
                return;
            }
            
            string keyword = txtAnyText.Text;
            string sqlWhere = $"Feature like '%{keyword}%' OR TestSummary like '%{keyword}%' OR TestSteps like '%{keyword}%' OR Error like '%{keyword}%'";
            var selectedRows = _searchResultsDataSet.Tables[1].Select(sqlWhere);
            if (selectedRows.Length > 0)
            {
                var testDetailsTableFiltered = selectedRows.CopyToDataTable();
                detailsGrid.DataSource = testDetailsTableFiltered;
                detailsGrid.Refresh();
            }
            else
            {
                detailsGrid.DataSource = null;
                detailsGrid.Refresh();
                MessageBox.Show("No test results are found. Try other search criteria.");
            }
        }

        private DataSet FetchResults()
        {
            _results.Project = projectsDropdown.Text;
            _results.TestEnvironment = environmentsDropdown.Text;
            _results.TestDate = DateTime.Parse(testsRanAfterDateTimePicker.Text).ToString("MM-dd-yyyy hh:mm");

            return _results.Get();
           
        }

        private void FetchHistoryOfTestResults(string testId = "")
        {
            if (!string.IsNullOrEmpty(testId))
            {
                testIdTextBox.Text = testId;
            }

            _historyOfTest.Project = projectsDropdownOnHistoryTab.Text;
            _historyOfTest.TestId = testIdTextBox.Text;

            var testHistoryDataSet = _historyOfTest.Get();

            var testHistoryTable = testHistoryDataSet.Tables[0];

            testHistoryGrid.DataSource = testHistoryTable;
            testHistoryGrid.Columns["TestSummary"].Width = 300;
            testHistoryGrid.Refresh();

            if (testHistoryTable.Rows.Count == 0)
            {
                testHistoryGrid.DataSource = null;
                testHistoryGrid.Refresh();
            }
        }

        private void searchForHistoryOfTestBtn_Click(object sender, EventArgs e)
        {
            FetchHistoryOfTestResults();
        }

        private void detailsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var testId =
                ((DataTable) ((DataGridView) sender).DataSource).Rows[e.RowIndex]["TestId"].ToString();
            Tabs.SelectTab(historyOfTestTab);
            testIdTextBox.Text = testId;
            FetchHistoryOfTestResults(testId);
        }

        private void ExportToExcelBtn_Click(object sender, EventArgs e)
        {
            ExportToExcel(_searchResultsDataSet);
        }

        private void ExportToExcel(DataSet resultsDataSet)
        {
            var tempFolder = Environment.GetEnvironmentVariable("TEMP");
            var fileFullPath = Path.Combine(tempFolder, $@"TestResults_{DateTime.Now.ToString("yyyyMMdd-HHmm")}.xlsx");

            using (var excelPackage = new ExcelPackage())
            {
                var summaryWorksheet = excelPackage.Workbook.Worksheets.Add("Summary");

                summaryWorksheet.Cells["A1"].LoadFromDataTable(resultsDataSet.Tables[0], true);

                var detailsWorksheet = excelPackage.Workbook.Worksheets.Add("Details");

                detailsWorksheet.Cells["A1"].LoadFromDataTable(resultsDataSet.Tables[1], true);


                var columnNames = detailsWorksheet
                    .Cells[
                        detailsWorksheet.Dimension.Start.Row, detailsWorksheet.Dimension.Start.Column,
                        detailsWorksheet.Dimension.Start.Row, detailsWorksheet.Dimension.End.Column]
                    .Select(firstRowCell => firstRowCell.Text).ToList();

                // For each TestCaseId, add link opening in the browser the related ticket from ticket management system, e.g. Jira or TFS
                var testIdTimeColumnIndex = columnNames.IndexOf("TestId") + 1; // 1-based column names in Excel

                for (var r = 2; r <= detailsWorksheet.Dimension.End.Row; r++)
                {
                    var value = detailsWorksheet.Cells[r, testIdTimeColumnIndex].Value;
                    detailsWorksheet.Cells[r, testIdTimeColumnIndex].Hyperlink =
                        new Uri(string.Concat("https://standprof.atlassian.net/browse/", value));
                    detailsWorksheet.Cells[r, testIdTimeColumnIndex].Value = value;
                    detailsWorksheet.Cells[r, testIdTimeColumnIndex].Style.Font.UnderLine = true;
                    detailsWorksheet.Cells[r, testIdTimeColumnIndex].Style.Font.Color.SetColor(Color.Blue);
                }

                //Set DateTime format for cells in column TestDateTime
                var testDateTiemColumnIndex = columnNames.IndexOf("TestDateTime") + 1; // 1-based column names in Excel
                detailsWorksheet.Column(testDateTiemColumnIndex).Style.Numberformat.Format =
                    DateTimeFormatInfo.CurrentInfo.ShortDatePattern;
                detailsWorksheet.Column(testDateTiemColumnIndex).Style.HorizontalAlignment =
                    ExcelHorizontalAlignment.Center;

                detailsWorksheet.Cells[detailsWorksheet.Dimension.Address].AutoFitColumns(25, 60);

                var bin = excelPackage.GetAsByteArray();
                File.WriteAllBytes(fileFullPath, bin);
            }

            Process.Start(fileFullPath);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
            //MessageBox.Show("Automated Test Results Dashboard\r\n" +
            //                "shows the results of executed automated tests\r\n" + 
            //                "© Standrof LTD", "About");

        }
    }
}
