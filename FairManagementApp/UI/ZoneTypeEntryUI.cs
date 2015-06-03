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
    public partial class ZoneTypeEntryUI : Form
    {
        ZoneManager aZoneManager = new ZoneManager();
        public ZoneTypeEntryUI()
        {
            InitializeComponent();
            LoadAllZone();
        }

        private void zoneSaveButton_Click(object sender, EventArgs e)
        {
            Zone aZone = new Zone();
            aZone.ZoneName = zoneTypeNameTextBox.Text;
            if (aZone.ZoneName == "")
            {
                
                MessageBox.Show("Zone Name can not be empty!");
            }
            else
            {
                if (aZoneManager.SaveAllZone(aZone))
                {
                    LoadAllZone();
                    MessageBox.Show("Zone Type has been successfully added");
                }
                else
                {
                    Close();
                    MessageBox.Show("An error occured");
                }
            }
        }

        void LoadAllZone()
        {
            List<Zone> zoneList = aZoneManager.GetAllZone();
            zoneTypeListView.Items.Clear();
            foreach (var zone in zoneList)
            {
                ListViewItem item = new ListViewItem(zone.ZoneName);
                zoneTypeListView.Items.Add(item);
            }
        }

    

        private void zoneTypeListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ZoneTypeEntryUI_Load(object sender, EventArgs e)
        {

        }
    }
}
