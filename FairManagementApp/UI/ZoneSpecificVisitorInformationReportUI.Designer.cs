namespace FairManagementApp.UI
{
    partial class ZoneSpecificVisitorInformationReportUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.zoneComboBox = new System.Windows.Forms.ComboBox();
            this.showZoneButton = new System.Windows.Forms.Button();
            this.visitorListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.exportToExcelButton = new System.Windows.Forms.Button();
            this.totalNumberTextBox = new System.Windows.Forms.TextBox();
            this.saveExcelFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Zone :";
            // 
            // zoneComboBox
            // 
            this.zoneComboBox.FormattingEnabled = true;
            this.zoneComboBox.Location = new System.Drawing.Point(155, 44);
            this.zoneComboBox.Name = "zoneComboBox";
            this.zoneComboBox.Size = new System.Drawing.Size(185, 21);
            this.zoneComboBox.TabIndex = 1;
            // 
            // showZoneButton
            // 
            this.showZoneButton.Location = new System.Drawing.Point(346, 41);
            this.showZoneButton.Name = "showZoneButton";
            this.showZoneButton.Size = new System.Drawing.Size(75, 23);
            this.showZoneButton.TabIndex = 2;
            this.showZoneButton.Text = "Show";
            this.showZoneButton.UseVisualStyleBackColor = true;
            this.showZoneButton.Click += new System.EventHandler(this.showZoneButton_Click);
            // 
            // visitorListView
            // 
            this.visitorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.visitorListView.GridLines = true;
            this.visitorListView.Location = new System.Drawing.Point(42, 91);
            this.visitorListView.Name = "visitorListView";
            this.visitorListView.Size = new System.Drawing.Size(444, 181);
            this.visitorListView.TabIndex = 3;
            this.visitorListView.UseCompatibleStateImageBehavior = false;
            this.visitorListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 162;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Contact Number";
            this.columnHeader3.Width = 152;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total :";
            // 
            // exportToExcelButton
            // 
            this.exportToExcelButton.Location = new System.Drawing.Point(345, 334);
            this.exportToExcelButton.Name = "exportToExcelButton";
            this.exportToExcelButton.Size = new System.Drawing.Size(141, 23);
            this.exportToExcelButton.TabIndex = 5;
            this.exportToExcelButton.Text = "Export to Excel";
            this.exportToExcelButton.UseVisualStyleBackColor = true;
            this.exportToExcelButton.Click += new System.EventHandler(this.exportToExcelButton_Click_1);
            // 
            // totalNumberTextBox
            // 
            this.totalNumberTextBox.Location = new System.Drawing.Point(386, 276);
            this.totalNumberTextBox.Name = "totalNumberTextBox";
            this.totalNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalNumberTextBox.TabIndex = 6;
            // 
            // saveExcelFileDialog
            // 
            this.saveExcelFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveExcelFileDialog_FileOk_1);
            // 
            // ZoneSpecificVisitorInformationReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 369);
            this.Controls.Add(this.totalNumberTextBox);
            this.Controls.Add(this.exportToExcelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visitorListView);
            this.Controls.Add(this.showZoneButton);
            this.Controls.Add(this.zoneComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ZoneSpecificVisitorInformationReportUI";
            this.Text = "Zone Specific Visitor Information Report";
            this.Load += new System.EventHandler(this.ZoneSpecificVisitorInformationReportUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox zoneComboBox;
        private System.Windows.Forms.Button showZoneButton;
        private System.Windows.Forms.ListView visitorListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exportToExcelButton;
        private System.Windows.Forms.TextBox totalNumberTextBox;
        private System.Windows.Forms.SaveFileDialog saveExcelFileDialog;
    }
}