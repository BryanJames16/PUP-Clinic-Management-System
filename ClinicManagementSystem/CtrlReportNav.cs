using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class CtrlReportNav : UserControl
    {
        public CtrlReportNav()
        {
            InitializeComponent();
        }

        private void tileRegiPats_Click(object sender, EventArgs e)
        {
            CtrlRegistReport registReport = new CtrlRegistReport();
            this.Controls.Clear();
            this.Controls.Add(registReport);
        }

        private void tilePatHisto_Click(object sender, EventArgs e)
        {
            CtrlLogReports logReports = new CtrlLogReports();

            this.Controls.Clear();
            this.Controls.Add(logReports);
            logReports.Dock = DockStyle.Fill;
        }

        private void tilePatMedHist_Click(object sender, EventArgs e)
        {
            CtrlPatHisReport patHistReports = new CtrlPatHisReport();
            this.Controls.Clear();
            this.Controls.Add(patHistReports);
            patHistReports.Dock = DockStyle.Fill;
        }
    }
}
