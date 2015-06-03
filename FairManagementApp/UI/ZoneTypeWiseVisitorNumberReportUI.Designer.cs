namespace FairManagementApp.UI
{
    partial class ZoneTypeWiseVisitorNumberReportUI
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
            this.zoneTypeWiseVisitorListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zoneTypeWiseVisitorListView
            // 
            this.zoneTypeWiseVisitorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.zoneTypeWiseVisitorListView.GridLines = true;
            this.zoneTypeWiseVisitorListView.Location = new System.Drawing.Point(23, 48);
            this.zoneTypeWiseVisitorListView.Name = "zoneTypeWiseVisitorListView";
            this.zoneTypeWiseVisitorListView.Size = new System.Drawing.Size(337, 181);
            this.zoneTypeWiseVisitorListView.TabIndex = 0;
            this.zoneTypeWiseVisitorListView.UseCompatibleStateImageBehavior = false;
            this.zoneTypeWiseVisitorListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zone";
            this.columnHeader1.Width = 215;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Number of Visitors";
            this.columnHeader2.Width = 178;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total :";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(257, 236);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 2;
            // 
            // ZoneTypeWiseVisitorNumberReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 286);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoneTypeWiseVisitorListView);
            this.Name = "ZoneTypeWiseVisitorNumberReportUI";
            this.Text = "Zone Type Wise Visitor Number Report";
            this.Load += new System.EventHandler(this.ZoneTypeWiseVisitorNumberReportUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView zoneTypeWiseVisitorListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalTextBox;
    }
}