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

namespace TestResultsDashboard.Code.Forms
{
    public partial class ShowTestResultsFrm : Form
    {
        private DataSet _searchResultsDataSet;
        private DataTable _testDetailsTable;
        
        public ShowTestResultsFrm()
        {
            InitializeComponent();
            InitialiseProjectsCombobox();
            this.Text = $"{CompanyName} - {this.Text}";
            testsRanAfterDateTimePicker.Format = DateTimePickerFormat.Custom;
            testsRanAfterDateTimePicker.CustomFormat = "ddd dd MMM yyyy HH:mm";
            testsRanAfterDateTimePicker.Value = DateTime.Now.Subtract(TimeSpan.FromDays(1));
        }

        private void InitialiseProjectsCombobox()
        {
            var items = new DbQueries().QueryProjects().Rows.Cast<DataRow>().Select(r => r[0]).ToArray();

            if (items.Length == 0)
            {
                var noProjectsFound = "No projects found";
                projectsDropdown.Items.Clear();
                projectsDropdown.Items.Add(noProjectsFound);
                projectsDropdown.Text = noProjectsFound;

                projectsDropdownOnHistoryTab.Items.Clear();
                projectsDropdownOnHistoryTab.Items.Add(noProjectsFound);
                projectsDropdownOnHistoryTab.Text = noProjectsFound;
                return;
            }

            projectsDropdown.Items.Clear();
            projectsDropdown.Items.AddRange(items);
            projectsDropdown.Text = items[0].ToString();

            projectsDropdownOnHistoryTab.Items.Clear();
            projectsDropdownOnHistoryTab.Items.AddRange(items);
            projectsDropdownOnHistoryTab.Text = items[0].ToString();
        }

        private void SearchResultsButton_Click(object sender, EventArgs e)
        {
            DisplayTestResultsSummary();
        }

        internal void DisplayTestResultsSummary()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                var project = projectsDropdown.Text;
                var testEnvironment = environmentsDropdown.Text;
                var testDate = DateTime.Parse(testsRanAfterDateTimePicker.Text).ToString("MM-dd-yyyy hh:mm");

                _searchResultsDataSet = new DbQueries().QueryTestResultsSummary(project, testEnvironment, testDate);

                var testSummaryTable = _searchResultsDataSet.Tables[0];
                _testDetailsTable = _searchResultsDataSet.Tables[1];

                if (_testDetailsTable.Rows.Count == 0)
                {
                    MessageBox.Show("No test results are found. Try other search criteria.");

                    summaryGrid.DataSource = null;
                    summaryGrid.Refresh();

                    detailsGrid.DataSource = null;
                    summaryGrid.Refresh();

                    return;
                }

                summaryGrid.DataSource = testSummaryTable;
                summaryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
               
                detailsGrid.DataSource = _testDetailsTable;
                detailsGrid.Columns["TestSummary"].Width = 300;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                summaryGrid.Refresh();
                detailsGrid.Refresh();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterTestResultsSummary();
        }

        private void FilterTestResultsSummary()
        {
            if (string.IsNullOrWhiteSpace(txtAnyText.Text))
            {
                detailsGrid.DataSource = _testDetailsTable;
                detailsGrid.Refresh();
                return;
            }

            string keyword = txtAnyText.Text;
            string sqlWhere =
                $"Feature like '%{keyword}%' OR TestSummary like '%{keyword}%' OR TestSteps like '%{keyword}%' OR Error like '%{keyword}%'";
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

        private void DisplayTestHistory(string project, string testId)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                var testHistoryDataSet = new DbQueries().QueryTestHistoryFromDb(project, testId);

                var testHistoryTable = testHistoryDataSet.Tables[0];

                testHistoryGrid.DataSource = testHistoryTable;
                testHistoryGrid.Columns["TestSummary"].Width = 300;

                if (testHistoryTable.Rows.Count == 0)
                {
                    testHistoryGrid.DataSource = null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                testHistoryGrid.Refresh();
            }
        }

        private void searchForHistoryOfTestBtn_Click(object sender, EventArgs e)
        {
            DisplayTestHistory(projectsDropdownOnHistoryTab.Text, testIdTextBoxOnHistoryTab.Text);
        }

        private void detailsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var testId = ((DataTable) ((DataGridView) sender).DataSource)
                .Rows[e.RowIndex]["TestId"].ToString();

            Tabs.SelectTab(historyOfTestTab);

            testIdTextBoxOnHistoryTab.Text = testId;
            projectsDropdownOnHistoryTab.Text = projectsDropdown.Text;
            
            DisplayTestHistory(projectsDropdown.Text, testId);
        }

        private void ExportToExcelBtn_Click(object sender, EventArgs e)
        {
            ExportToExcel(_searchResultsDataSet);
        }

        private void ExportToExcel(DataSet resultsDataSet)
        {
            var tempFolder = Environment.GetEnvironmentVariable("TEMP");
            var fileFullPath = Path.Combine(tempFolder ?? throw new InvalidOperationException(), $@"TestResults_{DateTime.Now:yyyyMMdd-HHmm}.xlsx");

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
                var testDateTimeColumnIndex = columnNames.IndexOf("TestDateTime") + 1; // 1-based column names in Excel
                detailsWorksheet.Column(testDateTimeColumnIndex).Style.Numberformat.Format =
                    DateTimeFormatInfo.CurrentInfo?.ShortDatePattern;
                detailsWorksheet.Column(testDateTimeColumnIndex).Style.HorizontalAlignment =
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
        }

        private void projectsDropdown_TextChanged(object sender, EventArgs e)
        {
            var project = ((ComboBox) sender).Text;

            var items = new DbQueries().QueryTestEnvironments(project).Rows.Cast<DataRow>().Select(r => r[0]).ToArray();

            if (items.Length == 0) return;

            environmentsDropdown.Items.Clear();
            environmentsDropdown.Items.AddRange(items);
            environmentsDropdown.Text = items[0].ToString();
        }
    }
}
