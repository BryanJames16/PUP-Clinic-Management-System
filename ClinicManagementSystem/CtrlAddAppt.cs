using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
{
    public partial class CtrlAddAppt : UserControl
    {
        private string userID = "";
        private MySqlConnection conn = null;
        private FormStaff form = null;
        private List<string>[] patientList;
        private List<string>[] doctorList;

        public CtrlAddAppt(FormStaff form, MySqlConnection conn, string userID)
        {
            InitializeComponent();

            this.conn = conn;
            this.userID = userID;
            this.patientList = new List<string>[6];
            this.doctorList = new List<string>[5];
            this.form = form;

            for (int count = 0; count < patientList.GetLength(0); count++)
            {
                patientList[count] = new List<string>();
            }

            for (int count = 0; count < doctorList.GetLength(0); count++)
            {
                doctorList[count] = new List<string>();
            }

            datSchedule.MinDate = DateTime.Now.AddDays(4);
            tmAppointment.Value.AddSeconds(tmAppointment.Value.Second);
            this.CtrlAddAppointment_Load(null, null);
            this.Dock = DockStyle.Top;

            dgvPatient.CellDoubleClick += new DataGridViewCellEventHandler(dgvPatient_CellDoubleClick);
            dgvDoctor.CellDoubleClick += new DataGridViewCellEventHandler(dgvDoctor_CellDoubleClick);
        }

        private void dgvPatient_CellDoubleClick(object sender, EventArgs e)
        {
            if (dgvPatient.Rows.Count >= 1)
            {
                FormViewPat viewPat = new FormViewPat(conn, patientList[dgvPatient.CurrentRow.Index][0], userID);
                viewPat.ShowDialog();
            }
        }

        private void dgvDoctor_CellDoubleClick(object sender, EventArgs e)
        {
            if (dgvDoctor.Rows.Count >= 1)
            {
                //FormViewPat viewPat = new FormViewPat(conn, doctorList[dgvDoctor.CurrentRow.Index][0], userID);
                //viewPat.ShowDialog();
            }
        }

        private void CtrlAddAppointment_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
            UpdateList();
            btnDocClear_Click(null, null);
        }

        private void btnPatClear_Click(object sender, EventArgs e)
        {
            textName.Clear();
            dgvPatient.Rows.Clear();
            UpdatePatient();
        }

        private void btnDocClear_Click(object sender, EventArgs e)
        {
            textDocName.Clear();
            dgvDoctor.Rows.Clear();
            UpdateDoctor();
        }

        private void btnPatSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT strPatientID, strIDNumber, strPatientFirstName, strPatientLastName, strPatientContactNumber, strGender " +
                         "FROM tblPatient " + 
                         "WHERE boolIsActive AND ";

            if (textName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter a valid search key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql += "(strPatientFirstName LIKE '%" + textName.Text.Trim() + "%' OR " + 
                        "strPatientLastName LIKE '%" + textName.Text.Trim() + "%');";

                int resultCounter = 0;

                try
                {
                    dgvPatient.Rows.Clear();
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

                        dgvPatient.Rows.Add(reader.GetString("strPatientLastName"),
                                           reader.GetString("strPatientFirstName"),
                                           reader.GetString("strGender"),
                                           reader.GetString("strPatientContactNumber"));

                        resultCounter++;
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

                if (resultCounter < 1)
                {
                    MessageBox.Show("Search Done!\nNo matching results found!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Search Done!\n" + resultCounter + " matching results found!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnDocSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT a.strStaffID, a.strFirstName, a.strLastName, a.strContactNumber, a.strGender " +
                             "FROM tblStaff a, tblPositionDetails b " +
                             "WHERE a.strPositionCode = b.strPositionCode AND " +
                                   "b.strPositionCode = 'DOCT'  AND " +
                                   "a.boolIsActive AND ";

            if (textDocName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter a valid search key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql += "(strFirstName LIKE '%" + textName.Text.Trim() + "%' OR " + 
                        "strLastName LIKE '%" + textName.Text.Trim() + "%');";
                int resultCounter = 0;

                try
                {
                    dgvDoctor.Rows.Clear();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        doctorList[0].Add(reader.GetString("strStaffID"));
                        doctorList[1].Add(reader.GetString("strLastName"));
                        doctorList[2].Add(reader.GetString("strFirstName"));
                        doctorList[3].Add(reader.GetString("strContactNumber"));
                        doctorList[4].Add(reader.GetString("strGender"));

                        dgvDoctor.Rows.Add(reader.GetString("strLastName"), 
                                            reader.GetString("strFirstName"), 
                                            reader.GetString("strContactNumber"), 
                                            reader.GetString("strGender"));

                        resultCounter++;
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

                if (resultCounter < 1)
                {
                    MessageBox.Show("Search Done!\nNo matching results found!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Search Done!\n" + resultCounter + " matching results found!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnSetAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                string report = "";
                bool isValid = true;

                if (dgvPatient.SelectedRows.Count == 0)
                {
                    report = "Please select a patient!";
                    isValid = false;
                }
                else if (dgvDoctor.SelectedRows.Count == 0)
                {
                    report = "Please select a doctor!";
                    isValid = false;
                }
                else if (datSchedule.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    report = "Please select an appointment date other than Sundays!";
                    isValid = false;
                }
                else if (tmAppointment.Value.Hour < 8 || tmAppointment.Value.Hour > 17)
                {
                    report = "Please select an appropriate appointment time!\nFrom 8:00 AM to 4:00 PM";
                    isValid = false;
                }

                if (!isValid)
                {
                    MessageBox.Show(report, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    /* Check if the user already been appointed at the same day */
                    int resultCounter = 0;
                    bool valid = true;
                    string sql = "SELECT b.dtmDateTimeStart " +
                                 "FROM tblAppointment a, tblAppointmentDetails b " +
                                 "WHERE a.strStaffID = @staffID AND " +
                                       "a.strPatientID = @patientID AND " +
                                       "a.strAppointmentCode = b.strAppointmentCode AND " +
                                       "DATE(b.dtmDateTimeStart) = @dateTimeAppoint AND " +
                                       "b.strAppointmentStatus = 'APPR';";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@staffID", doctorList[0]);
                    cmd.Parameters.AddWithValue("@patientID", patientList[0]);
                    cmd.Parameters.AddWithValue("@dateTimeAppoint", datSchedule.Value.ToString("yyyy-MM-dd"));
                    cmd.Prepare();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        resultCounter++;
                    }

                    reader.Close();

                    if (resultCounter >= 1)
                    {
                        MessageBox.Show("You already have appointment set on this date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        valid = false;
                    }
                    else
                    {
                        resultCounter = 0;
                        int numberOfCurrentAppt = 0;
                        sql = "SELECT COUNT(*) AS CURRENT_APPTS " +
                              "FROM tblAppointment a, tblAppointmentDetails b " +
                              "WHERE a.strStaffID = @staffID AND " +
                                    "a.strPatientID = @patientID AND " +
                                    "a.strAppointmentCode = b.strAppointmentCode AND " +
                                    "DATE(b.dtmDateTimeStart) = @dateAppointment;";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@staffID", doctorList[0][dgvDoctor.CurrentRow.Index]);
                        cmd.Parameters.AddWithValue("@patientID", patientList[0][dgvPatient.CurrentRow.Index]);
                        cmd.Parameters.AddWithValue("@dateAppointment", datSchedule.Value.ToString("yyyy-MM-dd"));
                        cmd.Prepare();
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            numberOfCurrentAppt = reader.GetInt16("CURRENT_APPTS");
                        }

                        reader.Close();

                        if (numberOfCurrentAppt >= 5)
                        {
                            MessageBox.Show("This doctor has already reached the maximum number of appointments per day!",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            valid = false;
                        }
                        else
                        {
                            sql = "SELECT b.dtmDateTimeStart " +
                                  "FROM tblAppointment a, tblAppointmentDetails b " +
                                  "WHERE a.strStaffID = @staffID AND " +
                                        "a.strAppointmentCode = b.strAppointmentCode AND " +
                                        "DATE(b.dtmDateTimeStart) = @dateAppointment;";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@staffID", doctorList[0][dgvDoctor.CurrentRow.Index]);
                            cmd.Parameters.AddWithValue("@dateAppointment", datSchedule.Value.ToString("yyyy-MM-dd"));
                            cmd.Prepare();
                            reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                DateTime startTime = reader.GetDateTime("dtmDateTimeStart");
                                tmAppointment.Value = new DateTime(datSchedule.Value.Year, datSchedule.Value.Month,
                                                                 datSchedule.Value.Day, DateTime.Now.Hour, DateTime.Now.Minute,
                                                                 DateTime.Now.Second);
                                TimeSpan span = startTime.Subtract(tmAppointment.Value);

                                /*
                                MessageBox.Show("Span is:" + Math.Abs(span.Hours) + "\nStartTime is: " + startTime.Hour + "\n" + 
                                                "tmAppointment is: " + tmAppointment.Value.Hour);
                                */

                                if (Math.Abs(span.Hours) < 2)
                                {
                                    MessageBox.Show("Time entered should be 2 hours after / before the previous appointment!",
                                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    valid = false;
                                    break;
                                }
                            }

                            reader.Close();

                            if (valid)
                            {
                                string currentCode = TimeHandler.GetCurrentDateTime() + "-APPT";
                                DateTime apptDate = new DateTime(datSchedule.Value.Year, datSchedule.Value.Month, 
                                                                 datSchedule.Value.Day, tmAppointment.Value.Hour, 
                                                                 tmAppointment.Value.Minute,
                                                                 tmAppointment.Value.AddSeconds(-tmAppointment.Value.Second).Second);
                                sql = "INSERT INTO tblAppointment(strAppointmentCode, strStaffID, strPatientID) " + 
                                      "VALUES (@apptCode, @staffID, @patID);";
                                cmd = new MySqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@apptCode", currentCode);
                                cmd.Parameters.AddWithValue("@staffID", doctorList[0][dgvDoctor.CurrentRow.Index]);
                                cmd.Parameters.AddWithValue("@patID", patientList[0][dgvPatient.CurrentRow.Index]);
                                cmd.Prepare();
                                cmd.ExecuteNonQuery();

                                sql = "INSERT INTO tblAppointmentDetails(strAppointmentCode, " + 
                                                                        "dtmDateTimeStart, strAppointmentStatus) " +
                                      "VALUES (@apptCode, @dtmApptDate, @statusCode);";
                                cmd = new MySqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@apptCode", currentCode);
                                cmd.Parameters.AddWithValue("@dtmApptDate", apptDate);
                                cmd.Parameters.AddWithValue("@statusCode", "APPR");
                                cmd.Prepare();
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Patient has been successfully appointed to the doctor!", "Success",
                                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                    }
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

        private void CtrlAddAppt_Validated(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
            UpdateList();
        }

        private void UpdateList()
        {
            dgvDoctor.Rows.Clear();
            dgvPatient.Rows.Clear();

            datSchedule.MinDate = DateTime.Now.AddDays(3);

            try
            {
                datSchedule.MinDate = DateTime.Now.AddDays(4);
                this.Dock = DockStyle.Fill;

                UpdateDoctor();
                UpdatePatient();
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

        private void btnAdvSearchPat_Click(object sender, EventArgs e)
        {
            FormAdvancedSearch search = new FormAdvancedSearch(form, this, conn, 1, userID);
            search.Show();
            //form.Visible = false;
        }

        private void ClearPatientList()
        {
            for (int count = 0; count < patientList.GetLength(0); count++)
            {
                patientList[count].Clear();
            }
        }

        private void ClearDoctorList()
        {
            for (int count = 0; count < doctorList.GetLength(0); count++)
            {
                doctorList[count].Clear();
            }
        }

        private void UpdatePatient()
        {
            dgvPatient.Rows.Clear();

            try
            {
                dgvPatient.Rows.Clear();
                this.ClearPatientList();

                string sql = "SELECT strPatientID, strIDNumber, strPatientLastName, strPatientFirstName, strGender, strPatientContactNumber " +
                             "FROM tblPatient " +
                             "WHERE boolIsActive;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int resultCount = 0;

                while (reader.Read())
                {
                    patientList[0].Add(reader.GetString("strPatientID"));
                    patientList[1].Add(reader.GetString("strIDNumber"));
                    patientList[2].Add(reader.GetString("strPatientLastName"));
                    patientList[3].Add(reader.GetString("strPatientFirstName"));
                    patientList[4].Add(reader.GetString("strGender"));
                    patientList[5].Add(reader.GetString("strPatientContactNumber"));

                    dgvPatient.Rows.Add(reader.GetString("strPatientLastName"),
                                       reader.GetString("strPatientFirstName"),
                                       reader.GetString("strGender"),
                                       reader.GetString("strPatientContactNumber"));

                    resultCount++;
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

        private void UpdateDoctor()
        {
            try
            {
                dgvDoctor.Rows.Clear();
                this.ClearDoctorList();

                string sql = "SELECT a.strStaffID, a.strFirstName, a.strLastName, a.strContactNumber, a.strGender " +
                             "FROM tblStaff a, tblPositionDetails b " +
                             "WHERE a.strPositionCode = b.strPositionCode AND " +
                                   "b.strPositionCode = 'DOCT'  AND " + 
                                   "a.boolIsActive;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int resultCount = 0;

                while (reader.Read())
                {
                    doctorList[0].Add(reader.GetString("strStaffID"));
                    doctorList[1].Add(reader.GetString("strFirstName"));
                    doctorList[2].Add(reader.GetString("strLastName"));
                    doctorList[3].Add(reader.GetString("strGender"));
                    doctorList[4].Add(reader.GetString("strContactNumber"));

                    dgvDoctor.Rows.Add(reader.GetString("strLastName"),
                                       reader.GetString("strFirstName"),
                                       reader.GetString("strContactNumber"),
                                       reader.GetString("strGender"));

                    resultCount++;
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

        public void UpdatePatient(string sql)
        {
            dgvPatient.Rows.Clear();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            int resultCount = 0;

            while (reader.Read())
            {
                dgvPatient.Rows.Add(reader.GetString("strPatientID"),
                                   reader.GetString("strIDNumber"),
                                   reader.GetString("strPatientLastName"),
                                   reader.GetString("strPatientFirstName"),
                                   reader.GetString("strPatientContactNumber"),
                                   reader.GetString("strGender"));
                resultCount++;
            }

            reader.Close();

            if (resultCount > 0)
            {
                MessageBox.Show("Search Done!\nFound " + resultCount + " matches!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Search Done! No matching record found!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAdvSearchDoc_Click(object sender, EventArgs e)
        {
            FormAdvancedSearch search = new FormAdvancedSearch(form, this, conn, 2, userID);
            search.Show();
            //form.Visible = false;
        }

        public void UpdateDoctor(string sql)
        {
            dgvDoctor.Rows.Clear();
            ClearDoctorList();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int resultCount = 0;

                while (reader.Read())
                {
                    doctorList[0].Add(reader.GetString("strStaffID"));
                    doctorList[1].Add(reader.GetString("strLastName"));
                    doctorList[2].Add(reader.GetString("strFirstName"));
                    doctorList[3].Add(reader.GetString("strGender"));
                    doctorList[4].Add(reader.GetString("strContactNumber"));

                    dgvDoctor.Rows.Add(reader.GetString("strLastName"),
                                       reader.GetString("strFirstName"),
                                       reader.GetString("strContactNumber"),
                                       reader.GetString("strGender"));
                    resultCount++;
                }

                reader.Close();

                if (resultCount > 0)
                {
                    MessageBox.Show("Search Done!\nFound " + resultCount + " matches!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Search Done! No matching record found!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                Integrity.GetExceptionDetails(ex);
            }
        }

        private void dgvDoctor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormViewDoct viewDoct = new FormViewDoct(conn, doctorList[0][dgvDoctor.CurrentRow.Index], userID);
            viewDoct.ShowDialog();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            Integrity.TextChange_Name(sender);
        }

        private void textDocName_TextChanged(object sender, EventArgs e)
        {
            Integrity.TextChange_Name(sender);
        }
    }
}
