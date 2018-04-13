using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ClinicManagementSystem
{
    public partial class CtrlRegistReport : UserControl
    {
        CtrlReportNav reportNav;
        public CtrlRegistReport()
        {
            InitializeComponent();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory + @"\RptRegist.rpt"); //pangalan nung report mo

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = dateTimePicker1.Text; //pangalan nung datetime picker mo tas .Text
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["FROM"]; //pangalan nung parameter mo
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = dateTimePicker2.Text; //pangalan nung datetime picker mo tas .Text
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["TO"];  //pangalan nung parameter mo
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crConnectionInfo.ServerName = FormLogIn.ServerName;
            crConnectionInfo.DatabaseName = FormLogIn.DatabaseName;
            crConnectionInfo.UserID = FormLogIn.UserID;
            crConnectionInfo.Password = FormLogIn.Password;

            crystalReportViewer1.ReportSource = cryRpt; //yung crystalreportviewer4 yan yung pangalan nung reportviewer mo
            crystalReportViewer1.Refresh();  //yung crystalreportviewer4 yan yung pangalan nung reportviewer mo
        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            reportNav = new CtrlReportNav();
            this.Controls.Clear();
            this.Controls.Add(reportNav);
        }

       
    }
}
