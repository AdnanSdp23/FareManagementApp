using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.BLL;
using FairManagementApp.Model;
using Microsoft.Office.Interop.Excel;

namespace FairManagementApp.UI
{
    public partial class ZoneSpecificVisitorInformationReportUI : Form
    {
        ZoneManager aZoneManager = new ZoneManager();
        VisitorZoneManager aVisitorZoneManager = new VisitorZoneManager();
        private string fieldFilename;
        public ZoneSpecificVisitorInformationReportUI()
      
        {
            InitializeComponent();
            LoadZoneType();
        }

        private void LoadZoneType()
        {
            List<Zone> zoneList = aZoneManager.GetAllZone();
            zoneComboBox.DataSource = null;
            zoneComboBox.DataSource = zoneList;
            zoneComboBox.ValueMember = "Id";
            zoneComboBox.DisplayMember = "ZoneName";

        }

        private void ZoneSpecificVisitorInformationReportUI_Load(object sender, EventArgs e)
        {

        }

        private void showZoneButton_Click(object sender, EventArgs e)
        {
            visitorListView.Items.Clear();
            totalNumberTextBox.Text = "";
            int zoneId = int.Parse(zoneComboBox.SelectedValue.ToString());
            List<VisitorZone> vistorZoneList = aVisitorZoneManager.SaveVisitorByZoneId(zoneId);
            int total = 0;
            foreach (var index in vistorZoneList)
            {
                ListViewItem list = new ListViewItem(index.VisitorName);
                //listViewItem.SubItems.Add(index.VisitorEmail);
                list.SubItems.Add(index.VisitorEmail);
                list.SubItems.Add(index.VisitorContactNumber);
                visitorListView.Items.Add(list);
                total ++;

            }
            totalNumberTextBox.Text = total.ToString();
        }

        //private void exportToExcelButton_Click(object sender, EventArgs e)
        //{
        //    saveExcelFileDialog.DefaultExt = "xlsx";
        //    saveExcelFileDialog.Filter = "Excel Files | *.xlsx";
        //    saveExcelFileDialog.ShowDialog();
        //    int zoneId = int.Parse(zoneComboBox.SelectedValue.ToString());
        //    string zoneName = zoneComboBox.Text;
        //    List<VisitorZone> vistorZoneList = aVisitorZoneManager.SaveVisitorByZoneId(zoneId);
        //    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        //    excel.Workbooks.Add();
        //    Microsoft.Office.Interop.Excel.Worksheet workSheet = excel.ActiveSheet;
        //    workSheet.Cells[1, "A"] = zoneName;
        //    workSheet.Cells[2, "A"] = "";
        //    workSheet.Cells[3, "A"] = "Name";
        //    workSheet.Cells[3, "B"] = "Email";
        //    workSheet.Cells[3, "C"] = "Contact Number";
        //    int index1 = 4;
        //    foreach (var visitor in vistorZoneList)
        //    {
        //        for (int index2 = 1; index2 <= 3; index2++)
        //        {
        //            workSheet.Cells[index1, "A"] = visitor.VisitorName;
        //            workSheet.Cells[index1, "B"] = visitor.VisitorEmail;
        //            workSheet.Cells[index1, "C"] = "\t" + visitor.VisitorContactNumber;
        //        }
        //        index1++;
        //    }
        //    workSheet.Columns.AutoFit();
        //    string fileName = fieldFilename;
        //    if (File.Exists(fileName))
        //    {
        //        File.Delete(fileName);
        //    }
        //    workSheet.SaveAs(fileName);
        //    MessageBox.Show("Data has been successfully exported to the Excel file");
        //    excel.Quit();
        //    System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
        //    System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);
        //    excel = null;
        //    workSheet = null;
        //    GC.Collect();

        //}

        private void saveExcelFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string filename = saveExcelFileDialog.FileName;
            fieldFilename = filename;
          
           
        }

        public IEnumerable<object> visitorZoneList { get; set; }

        private void exportToExcelButton_Click_1(object sender, EventArgs e)
        {
            saveExcelFileDialog.DefaultExt = "xlsx";
            saveExcelFileDialog.Filter = "Excel Files | *.xlsx";
            saveExcelFileDialog.ShowDialog();
            int zoneId = int.Parse(zoneComboBox.SelectedValue.ToString());
            string zoneName = zoneComboBox.Text;
            List<VisitorZone> vistorZoneList = aVisitorZoneManager.SaveVisitorByZoneId(zoneId);
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet workSheet = excel.ActiveSheet;
            workSheet.Cells[1, "A"] = zoneName;
            workSheet.Cells[2, "A"] = "";
            workSheet.Cells[3, "A"] = "Name";
            workSheet.Cells[3, "B"] = "Email";
            workSheet.Cells[3, "C"] = "Contact Number";
            int index1 = 4;
            foreach (var visitor in vistorZoneList)
            {
                for (int index2 = 1; index2 <= 3; index2++)
                {
                    workSheet.Cells[index1, "A"] = visitor.VisitorName;
                    workSheet.Cells[index1, "B"] = visitor.VisitorEmail;
                    workSheet.Cells[index1, "C"] = "\t" + visitor.VisitorContactNumber;
                }
                index1++;
            }
            workSheet.Columns.AutoFit();
            string fileName = fieldFilename;
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            workSheet.SaveAs(fileName);
            MessageBox.Show("Data has been successfully exported to the Excel file");
            excel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);
            excel = null;
            workSheet = null;
            GC.Collect();
        }

        private void saveExcelFileDialog_FileOk_1(object sender, CancelEventArgs e)
        {
            string filename = saveExcelFileDialog.FileName;
            fieldFilename = filename;
        }
    }
}
