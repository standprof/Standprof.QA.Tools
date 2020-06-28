namespace ShowTestResults
{
    partial class ShowTestResultsFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tabs = new System.Windows.Forms.TabControl();
            this.LatestTestResultsTab = new System.Windows.Forms.TabPage();
            this.SearchResultsPanel = new System.Windows.Forms.Panel();
            this.summaryGrid = new System.Windows.Forms.DataGridView();
            this.detailsGrid = new System.Windows.Forms.DataGridView();
            this.SearchCriteriaPanel = new System.Windows.Forms.Panel();
            this.ExportToExcelBtn = new System.Windows.Forms.Button();
            this.SearchResultsButton = new System.Windows.Forms.Button();
            this.testRunAfterDateTimeLbl = new System.Windows.Forms.Label();
            this.testsRanAfterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.environmentLbl = new System.Windows.Forms.Label();
            this.environmentsDropdown = new System.Windows.Forms.ComboBox();
            this.projectLbl = new System.Windows.Forms.Label();
            this.projectsDropdown = new System.Windows.Forms.ComboBox();
            this.historyOfTestTab = new System.Windows.Forms.TabPage();
            this.testHistoryPanel = new System.Windows.Forms.Panel();
            this.testHistoryGrid = new System.Windows.Forms.DataGridView();
            this.filterHistroySearchPanel = new System.Windows.Forms.Panel();
            this.searchForHistoryOfTestBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.projectsDropdownOnHistoryTab = new System.Windows.Forms.ComboBox();
            this.testIdTextBox = new System.Windows.Forms.TextBox();
            this.testIdLbl = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.LatestTestResultsTab.SuspendLayout();
            this.SearchResultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).BeginInit();
            this.SearchCriteriaPanel.SuspendLayout();
            this.historyOfTestTab.SuspendLayout();
            this.testHistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testHistoryGrid)).BeginInit();
            this.filterHistroySearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.LatestTestResultsTab);
            this.Tabs.Controls.Add(this.historyOfTestTab);
            this.Tabs.Location = new System.Drawing.Point(29, 15);
            this.Tabs.Margin = new System.Windows.Forms.Padding(4);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1205, 715);
            this.Tabs.TabIndex = 5;
            // 
            // LatestTestResultsTab
            // 
            this.LatestTestResultsTab.Controls.Add(this.SearchResultsPanel);
            this.LatestTestResultsTab.Controls.Add(this.SearchCriteriaPanel);
            this.LatestTestResultsTab.Location = new System.Drawing.Point(4, 25);
            this.LatestTestResultsTab.Margin = new System.Windows.Forms.Padding(4);
            this.LatestTestResultsTab.Name = "LatestTestResultsTab";
            this.LatestTestResultsTab.Padding = new System.Windows.Forms.Padding(4);
            this.LatestTestResultsTab.Size = new System.Drawing.Size(1197, 686);
            this.LatestTestResultsTab.TabIndex = 0;
            this.LatestTestResultsTab.Text = "Latest Test Results";
            this.LatestTestResultsTab.UseVisualStyleBackColor = true;
            // 
            // SearchResultsPanel
            // 
            this.SearchResultsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResultsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchResultsPanel.Controls.Add(this.summaryGrid);
            this.SearchResultsPanel.Controls.Add(this.detailsGrid);
            this.SearchResultsPanel.Location = new System.Drawing.Point(15, 110);
            this.SearchResultsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SearchResultsPanel.Name = "SearchResultsPanel";
            this.SearchResultsPanel.Size = new System.Drawing.Size(1161, 555);
            this.SearchResultsPanel.TabIndex = 1;
            // 
            // summaryGrid
            // 
            this.summaryGrid.AllowUserToDeleteRows = false;
            this.summaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summaryGrid.Location = new System.Drawing.Point(-1, -1);
            this.summaryGrid.Margin = new System.Windows.Forms.Padding(4);
            this.summaryGrid.Name = "summaryGrid";
            this.summaryGrid.ReadOnly = true;
            this.summaryGrid.RowHeadersWidth = 51;
            this.summaryGrid.Size = new System.Drawing.Size(397, 130);
            this.summaryGrid.TabIndex = 4;
            // 
            // detailsGrid
            // 
            this.detailsGrid.AllowUserToAddRows = false;
            this.detailsGrid.AllowUserToDeleteRows = false;
            this.detailsGrid.AllowUserToOrderColumns = true;
            this.detailsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsGrid.Location = new System.Drawing.Point(-1, 137);
            this.detailsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.detailsGrid.Name = "detailsGrid";
            this.detailsGrid.ReadOnly = true;
            this.detailsGrid.RowHeadersWidth = 51;
            this.detailsGrid.Size = new System.Drawing.Size(1156, 412);
            this.detailsGrid.TabIndex = 4;
            this.detailsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detailsGrid_CellDoubleClick);
            // 
            // SearchCriteriaPanel
            // 
            this.SearchCriteriaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchCriteriaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchCriteriaPanel.Controls.Add(this.ExportToExcelBtn);
            this.SearchCriteriaPanel.Controls.Add(this.SearchResultsButton);
            this.SearchCriteriaPanel.Controls.Add(this.testRunAfterDateTimeLbl);
            this.SearchCriteriaPanel.Controls.Add(this.testsRanAfterDateTimePicker);
            this.SearchCriteriaPanel.Controls.Add(this.environmentLbl);
            this.SearchCriteriaPanel.Controls.Add(this.environmentsDropdown);
            this.SearchCriteriaPanel.Controls.Add(this.projectLbl);
            this.SearchCriteriaPanel.Controls.Add(this.projectsDropdown);
            this.SearchCriteriaPanel.Location = new System.Drawing.Point(15, 16);
            this.SearchCriteriaPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SearchCriteriaPanel.Name = "SearchCriteriaPanel";
            this.SearchCriteriaPanel.Size = new System.Drawing.Size(1161, 86);
            this.SearchCriteriaPanel.TabIndex = 0;
            // 
            // ExportToExcelBtn
            // 
            this.ExportToExcelBtn.Location = new System.Drawing.Point(825, 32);
            this.ExportToExcelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExportToExcelBtn.Name = "ExportToExcelBtn";
            this.ExportToExcelBtn.Size = new System.Drawing.Size(145, 28);
            this.ExportToExcelBtn.TabIndex = 6;
            this.ExportToExcelBtn.Text = "Export To Excel";
            this.ExportToExcelBtn.UseVisualStyleBackColor = true;
            this.ExportToExcelBtn.Click += new System.EventHandler(this.ExportToExcelBtn_Click);
            // 
            // SearchResultsButton
            // 
            this.SearchResultsButton.Location = new System.Drawing.Point(704, 32);
            this.SearchResultsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchResultsButton.Name = "SearchResultsButton";
            this.SearchResultsButton.Size = new System.Drawing.Size(100, 28);
            this.SearchResultsButton.TabIndex = 3;
            this.SearchResultsButton.Text = "Search";
            this.SearchResultsButton.UseVisualStyleBackColor = true;
            this.SearchResultsButton.Click += new System.EventHandler(this.SearchResultsButton_Click);
            // 
            // testRunAfterDateTimeLbl
            // 
            this.testRunAfterDateTimeLbl.AutoSize = true;
            this.testRunAfterDateTimeLbl.Location = new System.Drawing.Point(413, 15);
            this.testRunAfterDateTimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testRunAfterDateTimeLbl.Name = "testRunAfterDateTimeLbl";
            this.testRunAfterDateTimeLbl.Size = new System.Drawing.Size(146, 17);
            this.testRunAfterDateTimeLbl.TabIndex = 5;
            this.testRunAfterDateTimeLbl.Text = "Tests ran on or after: ";
            // 
            // testsRanAfterDateTimePicker
            // 
            this.testsRanAfterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.testsRanAfterDateTimePicker.Location = new System.Drawing.Point(417, 36);
            this.testsRanAfterDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.testsRanAfterDateTimePicker.Name = "testsRanAfterDateTimePicker";
            this.testsRanAfterDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.testsRanAfterDateTimePicker.TabIndex = 2;
            // 
            // environmentLbl
            // 
            this.environmentLbl.AutoSize = true;
            this.environmentLbl.Location = new System.Drawing.Point(216, 15);
            this.environmentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.environmentLbl.Name = "environmentLbl";
            this.environmentLbl.Size = new System.Drawing.Size(95, 17);
            this.environmentLbl.TabIndex = 3;
            this.environmentLbl.Text = "Environment: ";
            // 
            // environmentsDropdown
            // 
            this.environmentsDropdown.FormattingEnabled = true;
            this.environmentsDropdown.Items.AddRange(new object[] {
            "develop"});
            this.environmentsDropdown.Location = new System.Drawing.Point(220, 34);
            this.environmentsDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.environmentsDropdown.Name = "environmentsDropdown";
            this.environmentsDropdown.Size = new System.Drawing.Size(175, 24);
            this.environmentsDropdown.TabIndex = 1;
            // 
            // projectLbl
            // 
            this.projectLbl.AutoSize = true;
            this.projectLbl.Location = new System.Drawing.Point(17, 15);
            this.projectLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectLbl.Name = "projectLbl";
            this.projectLbl.Size = new System.Drawing.Size(60, 17);
            this.projectLbl.TabIndex = 1;
            this.projectLbl.Text = "Project: ";
            // 
            // projectsDropdown
            // 
            this.projectsDropdown.FormattingEnabled = true;
            this.projectsDropdown.Items.AddRange(new object[] {
            "TableRes"});
            this.projectsDropdown.Location = new System.Drawing.Point(21, 34);
            this.projectsDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.projectsDropdown.Name = "projectsDropdown";
            this.projectsDropdown.Size = new System.Drawing.Size(175, 24);
            this.projectsDropdown.TabIndex = 0;
            // 
            // historyOfTestTab
            // 
            this.historyOfTestTab.Controls.Add(this.testHistoryPanel);
            this.historyOfTestTab.Controls.Add(this.filterHistroySearchPanel);
            this.historyOfTestTab.Location = new System.Drawing.Point(4, 25);
            this.historyOfTestTab.Margin = new System.Windows.Forms.Padding(4);
            this.historyOfTestTab.Name = "historyOfTestTab";
            this.historyOfTestTab.Padding = new System.Windows.Forms.Padding(4);
            this.historyOfTestTab.Size = new System.Drawing.Size(1197, 686);
            this.historyOfTestTab.TabIndex = 1;
            this.historyOfTestTab.Text = "History of Test";
            this.historyOfTestTab.UseVisualStyleBackColor = true;
            // 
            // testHistoryPanel
            // 
            this.testHistoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testHistoryPanel.Controls.Add(this.testHistoryGrid);
            this.testHistoryPanel.Location = new System.Drawing.Point(8, 106);
            this.testHistoryPanel.Margin = new System.Windows.Forms.Padding(4);
            this.testHistoryPanel.Name = "testHistoryPanel";
            this.testHistoryPanel.Size = new System.Drawing.Size(1179, 570);
            this.testHistoryPanel.TabIndex = 1;
            // 
            // testHistoryGrid
            // 
            this.testHistoryGrid.AllowUserToAddRows = false;
            this.testHistoryGrid.AllowUserToDeleteRows = false;
            this.testHistoryGrid.AllowUserToOrderColumns = true;
            this.testHistoryGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testHistoryGrid.Location = new System.Drawing.Point(4, 4);
            this.testHistoryGrid.Margin = new System.Windows.Forms.Padding(4);
            this.testHistoryGrid.Name = "testHistoryGrid";
            this.testHistoryGrid.ReadOnly = true;
            this.testHistoryGrid.RowHeadersWidth = 51;
            this.testHistoryGrid.Size = new System.Drawing.Size(1171, 562);
            this.testHistoryGrid.TabIndex = 0;
            // 
            // filterHistroySearchPanel
            // 
            this.filterHistroySearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterHistroySearchPanel.Controls.Add(this.searchForHistoryOfTestBtn);
            this.filterHistroySearchPanel.Controls.Add(this.label1);
            this.filterHistroySearchPanel.Controls.Add(this.projectsDropdownOnHistoryTab);
            this.filterHistroySearchPanel.Controls.Add(this.testIdTextBox);
            this.filterHistroySearchPanel.Controls.Add(this.testIdLbl);
            this.filterHistroySearchPanel.Location = new System.Drawing.Point(8, 7);
            this.filterHistroySearchPanel.Margin = new System.Windows.Forms.Padding(4);
            this.filterHistroySearchPanel.Name = "filterHistroySearchPanel";
            this.filterHistroySearchPanel.Size = new System.Drawing.Size(1179, 91);
            this.filterHistroySearchPanel.TabIndex = 0;
            // 
            // searchForHistoryOfTestBtn
            // 
            this.searchForHistoryOfTestBtn.Location = new System.Drawing.Point(403, 44);
            this.searchForHistoryOfTestBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchForHistoryOfTestBtn.Name = "searchForHistoryOfTestBtn";
            this.searchForHistoryOfTestBtn.Size = new System.Drawing.Size(100, 28);
            this.searchForHistoryOfTestBtn.TabIndex = 2;
            this.searchForHistoryOfTestBtn.Text = "Search";
            this.searchForHistoryOfTestBtn.UseVisualStyleBackColor = true;
            this.searchForHistoryOfTestBtn.Click += new System.EventHandler(this.searchForHistoryOfTestBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project:";
            // 
            // projectsDropdownOnHistoryTab
            // 
            this.projectsDropdownOnHistoryTab.FormattingEnabled = true;
            this.projectsDropdownOnHistoryTab.Location = new System.Drawing.Point(23, 43);
            this.projectsDropdownOnHistoryTab.Margin = new System.Windows.Forms.Padding(4);
            this.projectsDropdownOnHistoryTab.Name = "projectsDropdownOnHistoryTab";
            this.projectsDropdownOnHistoryTab.Size = new System.Drawing.Size(175, 24);
            this.projectsDropdownOnHistoryTab.TabIndex = 0;
            // 
            // testIdTextBox
            // 
            this.testIdTextBox.Location = new System.Drawing.Point(225, 44);
            this.testIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.testIdTextBox.Name = "testIdTextBox";
            this.testIdTextBox.Size = new System.Drawing.Size(152, 22);
            this.testIdTextBox.TabIndex = 1;
            // 
            // testIdLbl
            // 
            this.testIdLbl.AutoSize = true;
            this.testIdLbl.Location = new System.Drawing.Point(221, 23);
            this.testIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testIdLbl.Name = "testIdLbl";
            this.testIdLbl.Size = new System.Drawing.Size(57, 17);
            this.testIdLbl.TabIndex = 0;
            this.testIdLbl.Text = "Test ID:";
            // 
            // ShowTestResultsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1265, 761);
            this.Controls.Add(this.Tabs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowTestResultsFrm";
            this.Text = "Automated Test Results Dashboard";
            this.Tabs.ResumeLayout(false);
            this.LatestTestResultsTab.ResumeLayout(false);
            this.SearchResultsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.summaryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).EndInit();
            this.SearchCriteriaPanel.ResumeLayout(false);
            this.SearchCriteriaPanel.PerformLayout();
            this.historyOfTestTab.ResumeLayout(false);
            this.testHistoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testHistoryGrid)).EndInit();
            this.filterHistroySearchPanel.ResumeLayout(false);
            this.filterHistroySearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage LatestTestResultsTab;
        private System.Windows.Forms.TabPage historyOfTestTab;
        private System.Windows.Forms.Panel SearchResultsPanel;
        private System.Windows.Forms.Panel SearchCriteriaPanel;
        private System.Windows.Forms.Label projectLbl;
        private System.Windows.Forms.ComboBox projectsDropdown;
        private System.Windows.Forms.Button SearchResultsButton;
        private System.Windows.Forms.Label testRunAfterDateTimeLbl;
        private System.Windows.Forms.DateTimePicker testsRanAfterDateTimePicker;
        private System.Windows.Forms.Label environmentLbl;
        private System.Windows.Forms.ComboBox environmentsDropdown;
        private System.Windows.Forms.DataGridView detailsGrid;
        private System.Windows.Forms.DataGridView summaryGrid;
        private System.Windows.Forms.Panel filterHistroySearchPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox projectsDropdownOnHistoryTab;
        private System.Windows.Forms.TextBox testIdTextBox;
        private System.Windows.Forms.Label testIdLbl;
        private System.Windows.Forms.Button searchForHistoryOfTestBtn;
        private System.Windows.Forms.Panel testHistoryPanel;
        private System.Windows.Forms.DataGridView testHistoryGrid;
        private System.Windows.Forms.Button ExportToExcelBtn;
    }
}

