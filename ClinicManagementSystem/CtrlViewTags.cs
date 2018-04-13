using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
{
    public partial class CtrlViewTags : UserControl
    {
        private MySqlConnection conn = null;
        private string userID = "";
        private System.Windows.Forms.Timer threadTimer = new System.Windows.Forms.Timer();
        private List<string>[] patientList;

        public CtrlViewTags(MySqlConnection conn, string userID)
        {
            InitializeComponent();

            this.conn = conn;
            this.userID = userID;
            this.patientList = new List<string>[6];

            for (int count = 0; count < patientList.GetLength(0); count++)
            {
                patientList[count] = new List<string>();
            }

            this.threadTimer.Interval = 10000;
            this.threadTimer.Tick += new EventHandler(UpdateTag);
            this.threadTimer.Enabled = true;

            ClearPatientList();
            dgvTagged.Rows.Clear();

            try
            {
                string sql = "SELECT a.strPatientID, a.strIDNumber, a.strPatientLastName, a.strPatientFirstName, a.strGender, " +
                                "a.strPatientContactNumber " + 
                             "FROM tblPatient a, tblStaff b, tblTag c " + 
                             "WHERE a.strPatientID = c.strPatientID AND " + 
                                   "c.strStaffID = '" + userID + "' AND " + 
                                   "c.strStatus = 'PENDING';";
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

                    dgvTagged.Rows.Add(reader.GetString("strPatientLastName"),
                                       reader.GetString("strPatientFirstName"),
                                       reader.GetString("strPatientContactNumber"),
                                       reader.GetString("strGender"));
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

        private void ClearPatientList()
        {
            for (int count = 0; count < patientList.GetLength(0); count++)
            {
                patientList[count].Clear();
            }
        }

        private void UpdateTag(object sender, EventArgs e)
        {
            ClearPatientList();
            dgvTagged.Rows.Clear();

            try
            {
                string sql = "SELECT DISTINCT a.strPatientID, a.strIDNumber, a.strPatientLastName, a.strPatientFirstName, a.strGender, " +
                                "a.strPatientContactNumber " +
                             "FROM tblPatient a, tblStaff b, tblTag c " +
                             "WHERE a.strPatientID = c.strPatientID AND " +
                                   "c.strStaffID = '" + userID + "' AND " +
                                   "c.strStatus = 'PENDING';";
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
                    //patientList[7].Add(reader.GetString("strAppointmentCode"));

                    dgvTagged.Rows.Add(reader.GetString("strPatientLastName"),
                                       reader.GetString("strPatientFirstName"),
                                       reader.GetString("strPatientContactNumber"),
                                       reader.GetString("strGender"));
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

        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            if (dgvTagged.Rows.Count > 0)
            {
                try
                {
                    string sql = "UPDATE tblTag " +
                            "SET strStatus = 'APPROVED' " +
                            "WHERE strStatus = 'PENDING' AND " +
                                    "strStaffID = '" + userID + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    sql = "UPDATE tblLogIn " +
                          "SET  strDoctStatus = 'OFF'" +
                          "WHERE strStaffID = '" + userID + "';";
                    cmd = new MySqlCommand(sql, conn);
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

                FormAdmission admission = new FormAdmission(conn, userID, patientList[0][dgvTagged.CurrentRow.Index]);
                admission.ShowDialog();
                dgvTagged.Rows.Clear();
            }
        }

        private void dgvTagged_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTagged.Rows.Count >= 1)
            {
                FormViewPat viewPat = new FormViewPat(conn, patientList[dgvTagged.CurrentRow.Index][0], userID);
                viewPat.ShowDialog();
            }
        }
    }
}
