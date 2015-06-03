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
    public partial class ZoneTypeWiseVisitorNumberReportUI : Form
    {
       ZoneManager aZoneManager = new ZoneManager();
        public ZoneTypeWiseVisitorNumberReportUI()
        {
            InitializeComponent();
            LoadListBox();
        }

        private void LoadListBox()
        {
            zoneTypeWiseVisitorListView.Items.Clear();
            List<Zone> zoneList = aZoneManager.GetAllZone();
            int total = 0;
            foreach (var zone in zoneList)
            {
                VisitorZoneManager aVisitorZoneManager = new VisitorZoneManager();
                List<VisitorZone> visitorZoneList = aVisitorZoneManager.SaveVisitorByZoneId(zone.Id);
                int count = 0;

                foreach (var visitorZone in visitorZoneList)
                {
                    count ++;
                }
                ListViewItem item = new ListViewItem(zone.ZoneName);
                item.SubItems.Add(count.ToString());
                zoneTypeWiseVisitorListView.Items.Add(item);
                total += count;
            }

            totalTextBox.Text = total.ToString();
        }

        private void ZoneTypeWiseVisitorNumberReportUI_Load(object sender, EventArgs e)
        {

        }
    }
}
