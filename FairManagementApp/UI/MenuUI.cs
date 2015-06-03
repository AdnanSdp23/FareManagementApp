using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.UI;

namespace FairManagementApp
{
    public partial class MenuUI : Form
    {
        public MenuUI()
        {
            InitializeComponent();
        }

        private void MenuUI_Load(object sender, EventArgs e)
        {

        }

        private void zonetypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeEntryUI aZoneTypeEntryUi = new ZoneTypeEntryUI();
            aZoneTypeEntryUi.Show();
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntryUI aVisitorEntryUi = new VisitorEntryUI();
            aVisitorEntryUi.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zoneSpecificVisitorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneSpecificVisitorInformationReportUI aZoneSpecificVisitorInformationReportUi = new ZoneSpecificVisitorInformationReportUI();
            aZoneSpecificVisitorInformationReportUi.Show();
        }

        private void zoneWiseVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeWiseVisitorNumberReportUI aZoneTypeWiseVisitorNumberReportUi = new ZoneTypeWiseVisitorNumberReportUI();
            aZoneTypeWiseVisitorNumberReportUi.Show();
        }
    }
}
