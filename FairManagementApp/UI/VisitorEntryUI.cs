using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.BLL;
using FairManagementApp.Model;
namespace FairManagementApp.UI
{
    public partial class VisitorEntryUI : Form
    {
       
        ZoneManager aZoneManager = new ZoneManager();
        VisitorManager aVisitorManager = new VisitorManager();
        VisitorZoneManager aVisitorZoneManager = new VisitorZoneManager();
        public VisitorEntryUI()
        {
            InitializeComponent();
            LoadAllZone();
        }

        private void LoadAllZone()
        {
            List<Zone> zoneList = aZoneManager.GetAllZone();
            zoneCheckedListBox.DataSource = null;
            zoneCheckedListBox.DataSource = zoneList;
            zoneCheckedListBox.ValueMember = "Id";
            zoneCheckedListBox.DisplayMember = "ZoneName";
        }

        private void VisitorEntryUI_Load(object sender, EventArgs e)
        {

        }

        private void saveVisitorInfoButton_Click(object sender, EventArgs e)
        {
            Visitor aVisitor = new Visitor();
            aVisitor.Name = nameTextBox.Text;
            aVisitor.Email = emailTextBox.Text;
            aVisitor.ContactNumber = contactNumberTextBox.Text;
            if (aVisitor.Name == "" || aVisitor.Email == "" || aVisitor.ContactNumber == "" ||
                zoneCheckedListBox.CheckedItems.Count < 1)
            {
                MessageBox.Show("Name, Email or Contact Number cannot be empty and\n" +
                                "You must select at least one zone");
            }
            else
            {
                int id = aVisitorManager.SaveVisitor(aVisitor);
                if (id>0)
                {
                    foreach (var index in zoneCheckedListBox.CheckedItems)
                    {
                        Zone zone = (Zone) index;
                        VisitorZone aVisitorZone = new VisitorZone();
                        aVisitorZone.Visitor_Id = id;
                        aVisitorZone.Zone_Id = zone.Id;
                        aVisitorZoneManager.SaveVisitorZone(aVisitorZone);

                    }
                    MessageBox.Show("A visitor has been successfully added");
                }
                else
                {
                    MessageBox.Show("An error occured");
                }
            }
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            contactNumberTextBox.Text = "";
            zoneCheckedListBox.SelectedItem = "";
            zoneCheckedListBox.SelectedValue = "";
        }
    }
}
