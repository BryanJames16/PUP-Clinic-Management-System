using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
{
    public partial class CtrlViewAppt : UserControl
    {
        private MySqlConnection conn = null;
        private string userID = "";
        private System.Windows.Forms.Timer threadTimer = new System.Windows.Forms.Timer();
        private List<string>[] patientList;

        public CtrlViewAppt(MySqlConnection conn, string userID)
        {
            InitializeComponent();

            this.conn = conn;
            this.userID = userID;
            this.patientList = new List<string>[7];

            for (int count = 0; count < patientList.GetLength(0); count++)
            {
                patientList[count] = new List<string>();
            }

            UpdateAppt(null, null);

            this.threadTimer.Interval = 10000;
            this.threadTimer.Tick += new EventHandler(UpdateAppt);
            this.threadTimer.Enabled = true;
        }

        private void ClearPatientList()
        {
            for (int count = 0; count < patientList.GetLength(0); count++)
            {
                patientList[count].Clear();
            }
        }

        private void UpdateAppt(object sender, EventArgs e)
        {
            ClearPatientList();
            dgvAppointment.Rows.Clear();
            string sql = "SELECT a.strPatientID, a.strIDNumber, a.strPatientLastName, a.strPatientFirstName, a.strGender, " + 
                                "a.strPatientContactNumber, b.strAppointmentCode, c.dtmDateTimeStart " + 
                         "FROM tblPatient a, tblAppointment b, tblAppointmentDetails c " + 
                         "WHERE a.strPatientID = b.strPatientID AND " + 
                               "b.strStaffID = '" + userID + "' AND " + 
                               "b.strAppointmentCode = c.strAppointmentCode AND " + 
                               "c.strAppointmentStatus = 'APPR';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    patientList[0].Add(reader.GetString("strPatientID"));
                    patientList[1].Add(reader.GetString("strIDNumber"));
                    patientList[2].Add(reader.GetString("strPatientLastName"));
                    patientList[3].Add(reader.GetString("strPatientFirstName"));
                    patientList[4].Add(reader.GetString("strGender"));
                    patientList[5].Add(reader.GetString("strPatientContactNumber"));
                    patientList[6].Add(reader.GetString("strAppointmentCode"));

                    dgvAppointment.Rows.Add(reader.GetString("strPatientLastName"),
                                       reader.GetString("strPatientFirstName"),
                                       reader.GetString("strPatientContactNumber"),
                                       reader.GetString("strGender"),
                                       reader.GetString("dtmDateTimeSTart"));
                }

                reader.Close();
            }
            catch (MySqlException me)
            {
                Integrity.GetExceptionDetails(me);
            }
            catch (Exception ex)
            {
                Integrity.GetExceptionDetails(ex);
            }
        }

        public void CloseThreads()
        {
            threadTimer.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE tblAppointmentDetails " + 
                        "SET strAppointmentStatusCode = 'CANCELLED' " + 
                        "WHERE tblAppointment.strPatientID = '" + patientList[0][dgvAppointment.CurrentRow.Index] + "' AND " + 
                              "tblAppointment.strAppointmentCode = tblAppointmentDetails.strAppointmentCode AND " + 
                              "tblAppointment.AppointmentCode = '" + patientList[7][dgvAppointment.CurrentRow.Index] + "';";
        }

        private void dgvAppointment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAppointment.Rows.Count >= 1)
            {
                FormViewPat viewPat = new FormViewPat(conn, patientList[dgvAppointment.CurrentRow.Index][0], userID);
                viewPat.ShowDialog();
            }
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            if (dgvAppointment.Rows.Count >= 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to admit this patient?", 
                                              "Confirmation", 
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        string sql = "UPDATE tblAppointmentDetails " + 
                                    "SET strAppointmentStatus = 'DONE' " +
                                    "WHERE tblAppointmentDetails.strAppointmentCode = '" + patientList[6][dgvAppointment.CurrentRow.Index] + "';";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException me)
                    {
                        Integrity.GetExceptionDetails(me);
                    }
                    catch (Exception ex)
                    {
                        Integrity.GetExceptionDetails(ex);
                    }

                    FormAdmission admission = new FormAdmission(conn, userID, patientList[0][dgvAppointment.CurrentRow.Index]);
                    admission.ShowDialog();
                }
            }
        }
    }
}
