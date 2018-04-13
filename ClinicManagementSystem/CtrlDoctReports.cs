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
    public partial class CtrlDoctReports : UserControl
    {
        public CtrlDoctReports()
        {
            InitializeComponent();
        }

        private void tileAppointRec_Click(object sender, EventArgs e)
        {
            CtrlAppointmentReport appointmentReport = new CtrlAppointmentReport();
            this.Controls.Clear();
            this.Controls.Add(appointmentReport);
        }

        private void tileTagHist_Click(object sender, EventArgs e)
        {
            CtrlTagReports tagReports = new CtrlTagReports();
            this.Controls.Clear();
            this.Controls.Add(tagReports);
        }
    }
}
