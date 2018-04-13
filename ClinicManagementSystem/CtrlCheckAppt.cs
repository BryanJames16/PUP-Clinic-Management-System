using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using MetroFramework;

namespace ClinicManagementSystem
{
    public partial class CtrlCheckAppt : UserControl
    {
        private MySqlConnection conn = null;
        private FormStaff form = null;
        private string userID = "";
        private List<string>[] appointmentList = null;

        public CtrlCheckAppt(FormStaff form, MySqlConnection conn, string userID)
        {
            InitializeComponent();

            this.conn = conn;
            this.userID = userID;
            this.form = form;

            this.appointmentList = new List<string>[13];
            for (int count = 0; count < appointmentList.GetLength(0); count++)
            {
                appointmentList[count] = new List<string>();
            }

            this.btnReset_Click(null, null);
        }

        private void ClearList()
        {
            dgvResults.Rows.Clear();
            for (int count = 0; count < appointmentList.GetLength(0); count++)
            {
                appointmentList[count].Clear();
            }
        }

        private void CtrlCheckAppt_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ClearList();

            string sql = "SELECT a.strStaffID, a.strLastName, a.strFirstName, a.strContactNumber, a.strGender, " +
                                        "b.strAppointmentCode, c.dtmDateTimeStart, " +
                                        "d.strPatientID, d.strIDNumber, d.strPatientLastName, d.strPatientFirstName, d.strPatientContactNumber, " +
                                        "d.strGender AS 'strPatGender' " +
                                 "FROM tblStaff a, tblAppointment b, tblAppointmentDetails c, tblPatient d " +
                                 "WHERE a.strPositionCode = 'DOCT' AND " +
                                       "b.strAppointmentCode = c.strAppointmentCode AND " +
                                       "b.strStaffID = a.strStaffID AND " +
                                       "b.strPatientID = d.strPatientID AND " +
                                       "c.strAppointmentStatus = 'APPR' AND " + 
                                       "a.boolIsActive AND d.boolIsActive;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    appointmentList[0].Add(reader.GetString("strAppointmentCode"));
                    appointmentList[1].Add(reader.GetDateTime("dtmDateTimeStart").ToString());
                    appointmentList[2].Add(reader.GetString("strStaffID"));
                    appointmentList[3].Add(reader.GetString("strLastName"));
                    appointmentList[4].Add(reader.GetString("strFirstName"));
                    appointmentList[5].Add(reader.GetString("strContactNumber"));
                    appointmentList[6].Add(reader.GetString("strGender"));
                    appointmentList[7].Add(reader.GetString("strPatientID"));
                    appointmentList[8].Add(reader.GetString("strIDNumber"));
                    appointmentList[9].Add(reader.GetString("strPatientLastName"));
                    appointmentList[10].Add(reader.GetString("strPatientFirstName"));
                    appointmentList[11].Add(reader.GetString("strPatientContactNumber"));
                    appointmentList[12].Add(reader.GetString("strPatGender"));

                    dgvResults.Rows.Add(reader.GetDateTime("dtmDateTimeStart").ToString(),
                                        reader.GetString("strLastName"),
                                        reader.GetString("strFirstName"),
                                        reader.GetString("strPatientLastName"),
                                        reader.GetString("strPatientFirstName"));
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvResults.SelectedRows.Count > 0)
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to cancel this appointment?", 
                                                      "Confirm",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        string appointmentID = appointmentList[0][dgvResults.CurrentRow.Index];
                        string sql = "UPDATE tblAppointmentDetails " +
                                     "SET strAppointmentStatus = 'CANC' " +
                                     "WHERE strAppointmentCode = '" + appointmentID + "';";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        dgvResults.Rows.Remove(dgvResults.CurrentRow);

                        MessageBox.Show("Appointment Successfully Cancelled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.ClearList();
                        this.btnReset_Click(null, null);
                    }
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
            else
            {
                MessageBox.Show("Please select a valid entry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAdvSearch_Click(object sender, EventArgs e)
        {
            FormAdvancedSearch search = new FormAdvancedSearch(form, this, conn, userID);
            search.Show();
        }

        public void UpdateList(string sql)
        {
            this.ClearList();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int resultCount = 0;

                while (reader.Read())
                {
                    appointmentList[0].Add(reader.GetString("strAppointmentCode"));
                    appointmentList[1].Add(reader.GetDateTime("dtmDateTimeStart").ToString());
                    appointmentList[2].Add(reader.GetString("strStaffID"));
                    appointmentList[3].Add(reader.GetString("strLastName"));
                    appointmentList[4].Add(reader.GetString("strFirstName"));
                    appointmentList[5].Add(reader.GetString("strContactNumber"));
                    appointmentList[6].Add(reader.GetString("strGender"));
                    appointmentList[7].Add(reader.GetString("strPatientID"));
                    appointmentList[8].Add(reader.GetString("strIDNumber"));
                    appointmentList[9].Add(reader.GetString("strPatientLastName"));
                    appointmentList[10].Add(reader.GetString("strPatientFirstName"));
                    appointmentList[11].Add(reader.GetString("strPatientContactNumber"));
                    appointmentList[12].Add(reader.GetString("strPatGender"));

                    dgvResults.Rows.Add(reader.GetDateTime("dtmDateTimeStart").ToString(),
                                        reader.GetString("strLastName"),
                                        reader.GetString("strFirstName"),
                                        reader.GetString("strPatientLastName"),
                                        reader.GetString("strPatientFirstName"));

                    resultCount++;
                }

                reader.Close();

                if (resultCount > 0)
                {
                    MessageBox.Show("Search Done!\nFound " + resultCount + " matches!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Search Done! No found matches!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textName.Text.Trim().Equals(""))
            {
                Integrity.ShowNoKeywordDialog();
            }
            else
            {
                this.ClearList();

                string sql = "SELECT a.strStaffID, a.strLastName, a.strFirstName, a.strContactNumber, a.strGender, " +
                                            "b.strAppointmentCode, c.dtmDateTimeStart, " +
                                            "d.strPatientID, d.strIDNumber, d.strPatientLastName, d.strPatientFirstName, d.strPatientContactNumber, " +
                                            "d.strGender AS 'strPatGender' " +
                                     "FROM tblStaff a, tblAppointment b, tblAppointmentDetails c, tblPatient d " +
                                     "WHERE a.strPositionCode = 'DOCT' AND " +
                                           "b.strAppointmentCode = c.strAppointmentCode AND " +
                                           "b.strStaffID = a.strStaffID AND " +
                                           "b.strPatientID = d.strPatientID AND " +
                                           "c.strAppointmentStatus = 'APPR' AND " +
                                           "a.boolIsActive AND d.boolIsActive AND " + 
                                           "(d.strPatientFirstName LIKE '%" + textName.Text.Trim() + "%' OR " +
                                            "d.strPatientLastName LIKE '%" + textName.Text.Trim() + "%' OR " +
                                            "a.strLastName LIKE '%" + textName.Text.Trim() + "%' OR " +
                                            "a.strFirstName LIKE '%" + textName.Text.Trim() + "%');";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        appointmentList[0].Add(reader.GetString("strAppointmentCode"));
                        appointmentList[1].Add(reader.GetDateTime("dtmDateTimeStart").ToString());
                        appointmentList[2].Add(reader.GetString("strStaffID"));
                        appointmentList[3].Add(reader.GetString("strLastName"));
                        appointmentList[4].Add(reader.GetString("strFirstName"));
                        appointmentList[5].Add(reader.GetString("strContactNumber"));
                        appointmentList[6].Add(reader.GetString("strGender"));
                        appointmentList[7].Add(reader.GetString("strPatientID"));
                        appointmentList[8].Add(reader.GetString("strIDNumber"));
                        appointmentList[9].Add(reader.GetString("strPatientLastName"));
                        appointmentList[10].Add(reader.GetString("strPatientFirstName"));
                        appointmentList[11].Add(reader.GetString("strPatientContactNumber"));
                        appointmentList[12].Add(reader.GetString("strPatGender"));

                        dgvResults.Rows.Add(reader.GetDateTime("dtmDateTimeStart").ToString(),
                                        reader.GetString("strLastName"),
                                        reader.GetString("strFirstName"),
                                        reader.GetString("strPatientLastName"),
                                        reader.GetString("strPatientFirstName"));
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
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.ClearList();

            string sql = "SELECT a.strStaffID, a.strLastName, a.strFirstName, a.strContactNumber, a.strGender, " +
                                        "b.strAppointmentCode, c.dtmDateTimeStart, " +
                                        "d.strPatientID, d.strIDNumber, d.strPatientLastName, d.strPatientFirstName, d.strPatientContactNumber, " +
                                        "d.strGender AS 'strPatGender' " +
                                 "FROM tblStaff a, tblAppointment b, tblAppointmentDetails c, tblPatient d " +
                                 "WHERE a.strPositionCode = 'DOCT' AND " +
                                       "b.strAppointmentCode = c.strAppointmentCode AND " +
                                       "b.strStaffID = a.strStaffID AND " +
                                       "b.strPatientID = d.strPatientID AND " +
                                       "c.strAppointmentStatus = 'APPR' AND " +
                                       "a.boolIsActive AND d.boolIsActive AND " +
                                       "MONTH(c.dtmDateTimeStart) = " + calendar.SelectionEnd.ToString("MM") + " AND " + 
                                       "DAY(c.dtmDateTimeStart) = " + calendar.SelectionEnd.ToString("dd") + " AND " +
                                       "YEAR(c.dtmDateTimeStart) = " + calendar.SelectionEnd.ToString("yyy") + ";";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    appointmentList[0].Add(reader.GetString("strAppointmentCode"));
                    appointmentList[1].Add(reader.GetDateTime("dtmDateTimeStart").ToString());
                    appointmentList[2].Add(reader.GetString("strStaffID"));
                    appointmentList[3].Add(reader.GetString("strLastName"));
                    appointmentList[4].Add(reader.GetString("strFirstName"));
                    appointmentList[5].Add(reader.GetString("strContactNumber"));
                    appointmentList[6].Add(reader.GetString("strGender"));
                    appointmentList[7].Add(reader.GetString("strPatientID"));
                    appointmentList[8].Add(reader.GetString("strIDNumber"));
                    appointmentList[9].Add(reader.GetString("strPatientLastName"));
                    appointmentList[10].Add(reader.GetString("strPatientFirstName"));
                    appointmentList[11].Add(reader.GetString("strPatientContactNumber"));
                    appointmentList[12].Add(reader.GetString("strPatGender"));

                    dgvResults.Rows.Add(reader.GetDateTime("dtmDateTimeStart").ToString(),
                                    reader.GetString("strLastName"),
                                    reader.GetString("strFirstName"),
                                    reader.GetString("strPatientLastName"),
                                    reader.GetString("strPatientFirstName"));
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

        private void textName_TextChanged(object sender, EventArgs e)
        {
            Integrity.TextChange_Name(sender);
        }

    }
}
