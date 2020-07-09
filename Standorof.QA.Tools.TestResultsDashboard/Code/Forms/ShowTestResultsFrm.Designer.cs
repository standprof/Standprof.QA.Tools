namespace TestResultsDashboard.Code.Forms
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
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtAnyText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.testIdTextBoxOnHistoryTab = new System.Windows.Forms.TextBox();
            this.testIdLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.LatestTestResultsTab);
            this.Tabs.Controls.Add(this.historyOfTestTab);
            this.Tabs.Location = new System.Drawing.Point(22, 43);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1037, 702);
            this.Tabs.TabIndex = 5;
            // 
            // LatestTestResultsTab
            // 
            this.LatestTestResultsTab.Controls.Add(this.SearchResultsPanel);
            this.LatestTestResultsTab.Controls.Add(this.SearchCriteriaPanel);
            this.LatestTestResultsTab.Location = new System.Drawing.Point(4, 22);
            this.LatestTestResultsTab.Name = "LatestTestResultsTab";
            this.LatestTestResultsTab.Padding = new System.Windows.Forms.Padding(3);
            this.LatestTestResultsTab.Size = new System.Drawing.Size(1029, 676);
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
            this.SearchResultsPanel.Controls.Add(this.btnFilter);
            this.SearchResultsPanel.Controls.Add(this.txtAnyText);
            this.SearchResultsPanel.Controls.Add(this.label2);
            this.SearchResultsPanel.Controls.Add(this.summaryGrid);
            this.SearchResultsPanel.Controls.Add(this.detailsGrid);
            this.SearchResultsPanel.Location = new System.Drawing.Point(11, 88);
            this.SearchResultsPanel.Name = "SearchResultsPanel";
            this.SearchResultsPanel.Size = new System.Drawing.Size(1004, 573);
            this.SearchResultsPanel.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(538, 135);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtAnyText
            // 
            this.txtAnyText.Location = new System.Drawing.Point(16, 137);
            this.txtAnyText.Name = "txtAnyText";
            this.txtAnyText.Size = new System.Drawing.Size(494, 20);
            this.txtAnyText.TabIndex = 8;
            this.txtAnyText.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Any text:";
            // 
            // summaryGrid
            // 
            this.summaryGrid.AllowUserToDeleteRows = false;
            this.summaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summaryGrid.Location = new System.Drawing.Point(-1, -1);
            this.summaryGrid.Name = "summaryGrid";
            this.summaryGrid.ReadOnly = true;
            this.summaryGrid.RowHeadersWidth = 51;
            this.summaryGrid.Size = new System.Drawing.Size(298, 106);
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
            this.detailsGrid.Location = new System.Drawing.Point(-1, 189);
            this.detailsGrid.Name = "detailsGrid";
            this.detailsGrid.ReadOnly = true;
            this.detailsGrid.RowHeadersWidth = 51;
            this.detailsGrid.Size = new System.Drawing.Size(1000, 379);
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
            this.SearchCriteriaPanel.Location = new System.Drawing.Point(11, 13);
            this.SearchCriteriaPanel.Name = "SearchCriteriaPanel";
            this.SearchCriteriaPanel.Size = new System.Drawing.Size(1004, 191);
            this.SearchCriteriaPanel.TabIndex = 0;
            // 
            // ExportToExcelBtn
            // 
            this.ExportToExcelBtn.Location = new System.Drawing.Point(628, 28);
            this.ExportToExcelBtn.Name = "ExportToExcelBtn";
            this.ExportToExcelBtn.Size = new System.Drawing.Size(109, 23);
            this.ExportToExcelBtn.TabIndex = 6;
            this.ExportToExcelBtn.Text = "Export To Excel";
            this.ExportToExcelBtn.UseVisualStyleBackColor = true;
            this.ExportToExcelBtn.Click += new System.EventHandler(this.ExportToExcelBtn_Click);
            // 
            // SearchResultsButton
            // 
            this.SearchResultsButton.Location = new System.Drawing.Point(538, 28);
            this.SearchResultsButton.Name = "SearchResultsButton";
            this.SearchResultsButton.Size = new System.Drawing.Size(75, 23);
            this.SearchResultsButton.TabIndex = 3;
            this.SearchResultsButton.Text = "Search";
            this.SearchResultsButton.UseVisualStyleBackColor = true;
            this.SearchResultsButton.Click += new System.EventHandler(this.SearchResultsButton_Click);
            // 
            // testRunAfterDateTimeLbl
            // 
            this.testRunAfterDateTimeLbl.AutoSize = true;
            this.testRunAfterDateTimeLbl.Location = new System.Drawing.Point(310, 12);
            this.testRunAfterDateTimeLbl.Name = "testRunAfterDateTimeLbl";
            this.testRunAfterDateTimeLbl.Size = new System.Drawing.Size(108, 13);
            this.testRunAfterDateTimeLbl.TabIndex = 5;
            this.testRunAfterDateTimeLbl.Text = "Tests ran on or after: ";
            // 
            // testsRanAfterDateTimePicker
            // 
            this.testsRanAfterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.testsRanAfterDateTimePicker.Location = new System.Drawing.Point(313, 29);
            this.testsRanAfterDateTimePicker.Name = "testsRanAfterDateTimePicker";
            this.testsRanAfterDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.testsRanAfterDateTimePicker.TabIndex = 2;
            // 
            // environmentLbl
            // 
            this.environmentLbl.AutoSize = true;
            this.environmentLbl.Location = new System.Drawing.Point(162, 12);
            this.environmentLbl.Name = "environmentLbl";
            this.environmentLbl.Size = new System.Drawing.Size(72, 13);
            this.environmentLbl.TabIndex = 3;
            this.environmentLbl.Text = "Environment: ";
            // 
            // environmentsDropdown
            // 
            this.environmentsDropdown.FormattingEnabled = true;
            this.environmentsDropdown.Items.AddRange(new object[] {
            "develop"});
            this.environmentsDropdown.Location = new System.Drawing.Point(165, 28);
            this.environmentsDropdown.Name = "environmentsDropdown";
            this.environmentsDropdown.Size = new System.Drawing.Size(132, 21);
            this.environmentsDropdown.TabIndex = 1;
            // 
            // projectLbl
            // 
            this.projectLbl.AutoSize = true;
            this.projectLbl.Location = new System.Drawing.Point(13, 12);
            this.projectLbl.Name = "projectLbl";
            this.projectLbl.Size = new System.Drawing.Size(46, 13);
            this.projectLbl.TabIndex = 1;
            this.projectLbl.Text = "Project: ";
            // 
            // projectsDropdown
            // 
            this.projectsDropdown.FormattingEnabled = true;
            this.projectsDropdown.Items.AddRange(new object[] {
            "TableRes"});
            this.projectsDropdown.Location = new System.Drawing.Point(16, 28);
            this.projectsDropdown.Name = "projectsDropdown";
            this.projectsDropdown.Size = new System.Drawing.Size(132, 21);
            this.projectsDropdown.TabIndex = 0;
            this.projectsDropdown.TextChanged += new System.EventHandler(this.projectsDropdown_TextChanged);
            // 
            // historyOfTestTab
            // 
            this.historyOfTestTab.Controls.Add(this.testHistoryPanel);
            this.historyOfTestTab.Controls.Add(this.filterHistroySearchPanel);
            this.historyOfTestTab.Location = new System.Drawing.Point(4, 22);
            this.historyOfTestTab.Name = "historyOfTestTab";
            this.historyOfTestTab.Padding = new System.Windows.Forms.Padding(3);
            this.historyOfTestTab.Size = new System.Drawing.Size(1029, 676);
            this.historyOfTestTab.TabIndex = 1;
            this.historyOfTestTab.Text = "History of Test";
            this.historyOfTestTab.UseVisualStyleBackColor = true;
            // 
            // testHistoryPanel
            // 
            this.testHistoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testHistoryPanel.AutoSize = true;
            this.testHistoryPanel.Controls.Add(this.testHistoryGrid);
            this.testHistoryPanel.Location = new System.Drawing.Point(6, 86);
            this.testHistoryPanel.Name = "testHistoryPanel";
            this.testHistoryPanel.Size = new System.Drawing.Size(1017, 584);
            this.testHistoryPanel.TabIndex = 1;
            // 
            // testHistoryGrid
            // 
            this.testHistoryGrid.AllowUserToAddRows = false;
            this.testHistoryGrid.AllowUserToDeleteRows = false;
            this.testHistoryGrid.AllowUserToOrderColumns = true;
            this.testHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testHistoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testHistoryGrid.Location = new System.Drawing.Point(0, 0);
            this.testHistoryGrid.Name = "testHistoryGrid";
            this.testHistoryGrid.ReadOnly = true;
            this.testHistoryGrid.RowHeadersWidth = 51;
            this.testHistoryGrid.Size = new System.Drawing.Size(1017, 584);
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
            this.filterHistroySearchPanel.Controls.Add(this.testIdTextBoxOnHistoryTab);
            this.filterHistroySearchPanel.Controls.Add(this.testIdLbl);
            this.filterHistroySearchPanel.Location = new System.Drawing.Point(6, 6);
            this.filterHistroySearchPanel.Name = "filterHistroySearchPanel";
            this.filterHistroySearchPanel.Size = new System.Drawing.Size(1017, 74);
            this.filterHistroySearchPanel.TabIndex = 0;
            // 
            // searchForHistoryOfTestBtn
            // 
            this.searchForHistoryOfTestBtn.Location = new System.Drawing.Point(302, 36);
            this.searchForHistoryOfTestBtn.Name = "searchForHistoryOfTestBtn";
            this.searchForHistoryOfTestBtn.Size = new System.Drawing.Size(75, 23);
            this.searchForHistoryOfTestBtn.TabIndex = 2;
            this.searchForHistoryOfTestBtn.Text = "Search";
            this.searchForHistoryOfTestBtn.UseVisualStyleBackColor = true;
            this.searchForHistoryOfTestBtn.Click += new System.EventHandler(this.searchForHistoryOfTestBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project:";
            // 
            // projectsDropdownOnHistoryTab
            // 
            this.projectsDropdownOnHistoryTab.FormattingEnabled = true;
            this.projectsDropdownOnHistoryTab.Location = new System.Drawing.Point(17, 35);
            this.projectsDropdownOnHistoryTab.Name = "projectsDropdownOnHistoryTab";
            this.projectsDropdownOnHistoryTab.Size = new System.Drawing.Size(132, 21);
            this.projectsDropdownOnHistoryTab.TabIndex = 0;
            // 
            // testIdTextBoxOnHistoryTab
            // 
            this.testIdTextBoxOnHistoryTab.Location = new System.Drawing.Point(169, 36);
            this.testIdTextBoxOnHistoryTab.Name = "testIdTextBoxOnHistoryTab";
            this.testIdTextBoxOnHistoryTab.Size = new System.Drawing.Size(115, 20);
            this.testIdTextBoxOnHistoryTab.TabIndex = 1;
            // 
            // testIdLbl
            // 
            this.testIdLbl.AutoSize = true;
            this.testIdLbl.Location = new System.Drawing.Point(166, 19);
            this.testIdLbl.Name = "testIdLbl";
            this.testIdLbl.Size = new System.Drawing.Size(45, 13);
            this.testIdLbl.TabIndex = 0;
            this.testIdLbl.Text = "Test ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ShowTestResultsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1082, 770);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShowTestResultsFrm";
            this.Text = "Automated Test Results Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Tabs.ResumeLayout(false);
            this.LatestTestResultsTab.ResumeLayout(false);
            this.SearchResultsPanel.ResumeLayout(false);
            this.SearchResultsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).EndInit();
            this.SearchCriteriaPanel.ResumeLayout(false);
            this.SearchCriteriaPanel.PerformLayout();
            this.historyOfTestTab.ResumeLayout(false);
            this.historyOfTestTab.PerformLayout();
            this.testHistoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testHistoryGrid)).EndInit();
            this.filterHistroySearchPanel.ResumeLayout(false);
            this.filterHistroySearchPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox testIdTextBoxOnHistoryTab;
        private System.Windows.Forms.Label testIdLbl;
        private System.Windows.Forms.Button searchForHistoryOfTestBtn;
        private System.Windows.Forms.Panel testHistoryPanel;
        private System.Windows.Forms.DataGridView testHistoryGrid;
        private System.Windows.Forms.Button ExportToExcelBtn;
        private System.Windows.Forms.TextBox txtAnyText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

