using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
{
    public partial class FormAdvancedSearch : Form
    {
        private MySqlConnection conn = null;

        private FormStaff formStaff = null;
        private CtrlLogs logs = null;
        private CtrlPat patient = null;
        private CtrlAddAppt addAppt = null;
        private CtrlCheckAppt checkAppt = null;
        private CtrlDeletePatient delPatient = null;

        private string lastName = "";
        private string firstName = "";
        private string userType = "";
        private string userID = "";

        private int search = 0;

        /// <summary>
        /// Draggable window elements
        /// </summary>
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private enum WindowList
        {
            Staff
        };

        private enum ControlsList
        {
            Logs,
            Patient,
            Add_Appt,
            Check_Appt, 
            Del_Pat
        };

        private WindowList windows;
        private ControlsList controls;

        public FormAdvancedSearch(FormStaff formStaff, 
                                  CtrlLogs logs, 
                                  MySqlConnection conn, 
                                  string userID)
        {
            InitializeComponent();

            this.formStaff = formStaff;
            this.windows = WindowList.Staff;
            this.logs = logs;
            this.controls = ControlsList.Logs;

            this.pnlSearchPat.Visible = true;
            this.pnlSearchDoc.Visible = false;
            this.pnlPatDoc.Visible = false;

            this.conn = conn;
            this.userID = userID;

            this.UpdateHeader();
        }

        public FormAdvancedSearch(FormStaff formStaff,
                                  CtrlPat patient,
                                  MySqlConnection conn,
                                  string userID)
        {
            InitializeComponent();

            this.formStaff = formStaff;
            this.windows = WindowList.Staff;
            this.patient = patient;
            this.controls = ControlsList.Patient;

            this.pnlSearchPat.Visible = true;
            this.pnlSearchDoc.Visible = false;
            this.pnlPatDoc.Visible = false;

            this.conn = conn;
            this.userID = userID;

            this.UpdateHeader();
        }

        public FormAdvancedSearch(CtrlDeletePatient delPatient,
                                  MySqlConnection conn,
                                  string userID)
        {
            InitializeComponent();

            this.formStaff = formStaff;
            this.windows = WindowList.Staff;
            this.delPatient = delPatient;
            this.controls = ControlsList.Del_Pat;

            this.pnlSearchPat.Visible = true;
            this.pnlSearchDoc.Visible = false;
            this.pnlPatDoc.Visible = false;

            this.conn = conn;
            this.userID = userID;

            this.UpdateHeader();
        }

        public FormAdvancedSearch(FormStaff formStaff,
                                  CtrlAddAppt addAppt,
                                  MySqlConnection conn,
                                  int search, 
                                  string userID)
        {
            InitializeComponent();

            this.formStaff = formStaff;
            this.windows = WindowList.Staff;
            this.addAppt = addAppt;
            this.controls = ControlsList.Add_Appt;
            this.search = search;


            if (search == 1)
            {
                this.pnlSearchPat.Visible = true;
                this.pnlSearchDoc.Visible = false;
            }
            else
            {
                this.pnlSearchPat.Visible = false;
                this.pnlSearchDoc.Visible = true;
            }

            this.pnlPatDoc.Visible = false;

            this.conn = conn;
            this.userID = userID;

            this.UpdateHeader();
        }

        public FormAdvancedSearch(FormStaff formStaff,
                                  CtrlCheckAppt checkAppt,
                                  MySqlConnection conn,
                                  string userID)
        {
            InitializeComponent();

            this.formStaff = formStaff;
            this.windows = WindowList.Staff;
            this.checkAppt = checkAppt;
            this.controls = ControlsList.Check_Appt;

            this.pnlSearchPat.Visible = false;
            this.pnlSearchDoc.Visible = false;
            this.pnlPatDoc.Visible = true;

            this.conn = conn;
            this.userID = userID;

            this.UpdateHeader();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (windows == WindowList.Staff)
            {
                formStaff.Visible = true;
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "";

            if (controls == ControlsList.Logs || controls == ControlsList.Patient || (controls == ControlsList.Add_Appt && search == 1) || 
                controls == ControlsList.Del_Pat)
            {
                if (!textPatID.Text.Trim().Equals("") || !textPatNo.Text.Trim().Equals("") ||
                    !textLastName.Text.Trim().Equals("") || !textFirstName.Text.Trim().Equals("") ||
                    !textContact.Text.Trim().Equals("") || !textGender.Text.Trim().Equals(""))
                {
                    sql += "SELECT strPatientID, strIDNumber, strPatientLastName, strPatientFirstName, strPatientContactNumber, strGender " +
                       "FROM tblPatient " +
                       "WHERE boolIsActive ";

                    if (!textPatID.Text.Trim().Equals(""))
                    {
                        sql += "AND  strPatientID = '%" + textPatID.Text.Trim() + "%' ";
                    }

                    if (!textPatNo.Text.Trim().Equals(""))
                    {
                        sql += "AND strIDNumber LIKE '%" + textPatNo.Text.Trim() + "%' ";
                    }

                    if (!textLastName.Text.Trim().Equals(""))
                    {
                        sql += "AND strPatientLastName LIKE '%" + textLastName.Text.Trim() + "%' ";
                    }

                    if (!textFirstName.Text.Trim().Equals(""))
                    {
                        sql += "AND strPatientFirstName LIKE '%" + textFirstName.Text.Trim() + "%' ";
                    }

                    if (!textContact.Text.Trim().Equals(""))
                    {
                        sql += "AND strPatientContactNumber LIKE '+639" + textContact.Text.Trim() + "%' ";
                    }

                    if (!textGender.Text.Trim().Equals(""))
                    {
                        sql += "AND strGender = '" + textGender.Text.Trim() + "' ";
                    }

                    sql += ";";

                    if (controls == ControlsList.Logs)
                    {
                        logs.UpdateListSearch(sql);
                        formStaff.Visible = true;
                        this.Close();
                    }
                    else if (controls == ControlsList.Patient)
                    {
                        patient.UpdateView(sql);
                        formStaff.Visible = true;
                        this.Close();
                    }
                    else if (controls == ControlsList.Add_Appt)
                    {
                        addAppt.UpdatePatient(sql);
                        formStaff.Visible = true;
                        this.Close();
                    }
                    else if (controls == ControlsList.Del_Pat)
                    {
                        delPatient.UpdatePatient(sql);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an invalid search key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (controls == ControlsList.Add_Appt && search == 2)
            {
                if (!textDocID.Text.Trim().Equals("") || !textDocLast.Text.Trim().Equals("") ||
                    !textDocFirst.Text.Trim().Equals("") || !textDocContact.Text.Trim().Equals("") ||
                    !textDocGender.Text.Trim().Equals(""))
                {
                    sql += "SELECT a.strStaffID, a.strFirstName, a.strLastName, a.strContactNumber, a.strGender " +
                            "FROM tblStaff a, tblPositionDetails b " +
                            "WHERE a.strPositionCode = b.strPositionCode AND " +
                                  "b.strPositionCode = 'DOCT'  AND " +
                                  "a.boolIsActive ";

                    if (!textDocID.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += " a.strStaffID = '%" + textDocID.Text.Trim() + "%' ";
                    }

                    if (!textDocLast.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += "a.strLastName LIKE '%" + textDocLast.Text.Trim() + "%' ";
                    }

                    if (!textDocFirst.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += "a.strFirstName LIKE '%" + textDocFirst.Text.Trim() + "%' ";
                    }

                    if (!textDocContact.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += "a.strContactNumber LIKE '+639" + textDocContact.Text.Trim() + "%' ";
                    }

                    if (!textDocGender.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += "a.strGender = '" + textDocGender.Text.Trim() + "' ";
                    }

                    sql += ";";

                    if (controls == ControlsList.Add_Appt)
                    {
                        addAppt.UpdateDoctor(sql);
                        formStaff.Visible = true;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an invalid search key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (controls == ControlsList.Check_Appt)
            {
                if (!chboUnknown.Checked || !textAppID.Text.Trim().Equals("") || !textAppDocID.Text.Trim().Equals("") ||
                    !textAppDocCont.Text.Trim().Equals("") || !textAppDocGender.Text.Trim().Equals("") ||
                    !textAppPatID.Text.Trim().Equals("") || !textAppPatNo.Text.Trim().Equals("") ||
                    !textAppPatLast.Text.Trim().Equals("") || !textAppPatFirst.Text.Trim().Equals("") ||
                    !textAppPatCont.Text.Trim().Equals("") || !textAppPatGender.Text.Trim().Equals(""))
                {
                    sql += "SELECT a.strStaffID, a.strLastName, a.strFirstName, a.strContactNumber, a.strGender, " +
                               "b.strAppointmentCode, c.dtmDateTimeStart, " +
                               "d.strPatientID, d.strIDNumber, d.strPatientLastName, d.strPatientFirstName, d.strPatientContactNumber, " +
                               "d.strGender AS 'strPatGender' " +
                       "FROM tblStaff a, tblAppointment b, tblAppointmentDetails c, tblPatient d " +
                       "WHERE a.strPositionCode = 'DOCT' AND " +
                             "b.strAppointmentCode = c.strAppointmentCode AND " +
                             "b.strStaffID = a.strStaffID AND " +
                             "b.strPatientID = d.strPatientID AND " +
                             "c.strAppointmentStatusCode = 'APPR' AND " + 
                             "a.boolIsActive AND d.boolIsActive ";
                    DateTime schedApp = new DateTime();

                    if (!textAppID.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += " b.strAppointmentCode LIKE '%" + textAppPatID.Text.Trim() + "%' ";
                    }

                    if (!chboUnknown.Checked)
                    {
                        schedApp = new DateTime(datSchedule.Value.Year, datSchedule.Value.Month,
                                                datSchedule.Value.Day, tmAppointment.Value.Hour,
                                                tmAppointment.Value.Minute,
                                                tmAppointment.Value.Second);
                        sql += " AND ";
                        sql += " c.dtmDateTimeStart = '" + schedApp.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
                    }

                    if (!textAppDocID.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += " a.strStaffID LIKE '%" + textAppDocID.Text.Trim() + "%' ";
                    }

                    if (!textAppDocLast.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += " a.strLastName LIKE '%" + textAppDocLast.Text.Trim() + "%' ";
                    }

                    if (!textAppDocFirst.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += " a.strFirstName LIKE '%" + textAppDocFirst.Text.Trim() + "%' ";
                    }

                    if (!textAppDocCont.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += " a.strAppDocCont LIKE '+639" + textAppDocCont.Text.Trim() + "%' ";
                    }

                    if (!textAppDocGender.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += " a.strGender = '" + textAppDocGender.Text.Trim() + "' ";
                    }

                    if (!textAppPatID.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += " d.strPatientID LIKE '%" + textAppPatID.Text.Trim() + "%' ";
                    }

                    if (!textAppPatNo.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += " d.strIDNumber LIKE '%" + textAppPatNo.Text.Trim() + "%' ";
                    }

                    if (!textAppPatLast.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += " d.strPatientLastName LIKE '%" + textAppPatLast.Text.Trim() + "%' ";
                    }

                    if (!textAppPatFirst.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += " d.strPatientFirstName LIKE '%" + textAppPatFirst.Text.Trim() + "%' ";
                    }

                    if (!textAppPatCont.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += " d.strPatientContactNumber LIKE '%" + textAppPatCont.Text.Trim() + "%' ";
                    }

                    if (!textAppPatGender.Text.Trim().Equals(""))
                    {
                        sql += " AND ";
                        sql += " d.strGender = '" + textAppPatGender.Text.Trim() + "' ";
                    }

                    sql += ";";

                    checkAppt.UpdateList(sql);
                    formStaff.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No valid search key!");
                    MessageBox.Show("Please enter an invalid search key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }

        private void UpdateHeader()
        {
            string sql = "SELECT strLastName, strFirstName, strStaffID, strPositionCode " +
                            "FROM tblStaff " +
                            "WHERE strStaffID = @staffID;";

            string userPosition = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@staffID", userID);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    firstName = reader.GetString("strFirstName");
                    lastName = reader.GetString("strLastName");
                    userPosition = reader.GetString("strPositionCode");
                }

                reader.Close();

                sql = "SELECT strPositionDescription " +
                              "FROM tblPositionDetails " +
                              "WHERE strPositionCode = @posCode;";

                cmd = new MySqlCommand(sql, conn);

                /* Prepare statements */
                cmd.Parameters.AddWithValue("@posCode", userPosition);
                cmd.Prepare();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    userType = reader.GetString("strPositionDescription");
                }

                reader.Close();

                this.lblLastName.Text = lastName;
                this.lblFirstName.Text = firstName;
                this.lblUserID.Text = userID;
                this.lblUserType.Text = userType;
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

        private void textGender_TextChanged(object sender, EventArgs e)
        {
            if (!textGender.Text.Trim().Equals(""))
            {
                if (textGender.Text.Trim().Equals("M") || textGender.Text.Trim().Equals("F") ||
                    textGender.Text.Trim().Equals("m") || textGender.Text.Trim().Equals("f"))
                {
                    
                }
                else
                {
                    textGender.Text = textGender.Text.Substring(0, textGender.Text.Trim().Length - 1);
                    textGender.Select(textGender.Text.Trim().Length, 1);
                }
            }
        }

        private void textContact_TextChanged(object sender, EventArgs e)
        {
            if (textContact.Text.Trim().Length > 0)
            {
                if (!Integrity.NumberOnly(textContact.Text.Trim()))
                {
                    textContact.Text = textContact.Text.Substring(0, textContact.Text.Trim().Length - 1);
                    textContact.Select(textContact.Text.Trim().Length, 1);
                }
            }
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {
            if (textFirstName.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textFirstName.Text.Trim()))
                {
                    textFirstName.Text = textFirstName.Text.Substring(0, textFirstName.Text.Trim().Length - 1);
                    textFirstName.Select(textFirstName.Text.Trim().Length, 1);
                }
            }
        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {
            if (textLastName.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textLastName.Text.Trim()))
                {
                    textLastName.Text = textLastName.Text.Substring(0, textLastName.Text.Trim().Length - 1);
                    textLastName.Select(textLastName.Text.Trim().Length, 1);
                }
            }
        }

        private void textDocGender_TextChanged(object sender, EventArgs e)
        {
            if (!textDocGender.Text.Trim().Equals(""))
            {
                if (textDocGender.Text.Trim().Equals("M") || textDocGender.Text.Trim().Equals("F") ||
                    textDocGender.Text.Trim().Equals("m") || textDocGender.Text.Trim().Equals("f"))
                {

                }
                else
                {
                    textDocGender.Text = textDocGender.Text.Substring(0, textDocGender.Text.Trim().Length - 1);
                    textDocGender.Select(textDocGender.Text.Trim().Length, 1);
                }
            }
        }

        private void textDocContact_TextChanged(object sender, EventArgs e)
        {
            if (textDocContact.Text.Trim().Length > 0)
            {
                if (!Integrity.NumberOnly(textDocContact.Text.Trim()))
                {
                    textDocContact.Text = textDocContact.Text.Substring(0, textDocContact.Text.Trim().Length - 1);
                    textDocContact.Select(textDocContact.Text.Trim().Length, 1);
                }
            }
        }

        private void textDocFirst_TextChanged(object sender, EventArgs e)
        {
            if (textDocFirst.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textDocFirst.Text.Trim()))
                {
                    textDocFirst.Text = textDocFirst.Text.Substring(0, textDocFirst.Text.Trim().Length - 1);
                    textDocFirst.Select(textDocFirst.Text.Trim().Length, 1);
                }
            }
        }

        private void textDocLast_TextChanged(object sender, EventArgs e)
        {
            if (textDocLast.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textDocLast.Text.Trim()))
                {
                    textDocLast.Text = textDocLast.Text.Substring(0, textDocLast.Text.Trim().Length - 1);
                    textDocLast.Select(textDocLast.Text.Trim().Length, 1);
                }
            }
        }

        private void textAppDocGender_TextChanged(object sender, EventArgs e)
        {
            if (!textAppDocGender.Text.Trim().Equals(""))
            {
                if (textAppDocGender.Text.Trim().Equals("M") || textAppDocGender.Text.Trim().Equals("F") ||
                    textAppDocGender.Text.Trim().Equals("m") || textAppDocGender.Text.Trim().Equals("f"))
                {

                }
                else
                {
                    textAppDocGender.Text = textAppDocGender.Text.Substring(0, textAppDocGender.Text.Trim().Length - 1);
                    textAppDocGender.Select(textAppDocGender.Text.Trim().Length, 1);
                }
            }
        }

        private void textAppPatGender_TextChanged(object sender, EventArgs e)
        {
            if (!textAppDocGender.Text.Trim().Equals(""))
            {
                if (textAppPatGender.Text.Trim().Equals("M") || textAppPatGender.Text.Trim().Equals("F") ||
                    textAppPatGender.Text.Trim().Equals("m") || textAppPatGender.Text.Trim().Equals("f"))
                {

                }
                else
                {
                    textAppPatGender.Text = textAppPatGender.Text.Substring(0, textAppPatGender.Text.Trim().Length - 1);
                    textAppPatGender.Select(textAppPatGender.Text.Trim().Length, 1);
                }
            }
        }

        private void textAppPatCont_TextChanged(object sender, EventArgs e)
        {
            if (textAppPatCont.Text.Trim().Length > 0)
            {
                if (!Integrity.NumberOnly(textAppPatCont.Text.Trim()))
                {
                    textAppPatCont.Text = textAppPatCont.Text.Substring(0, textAppPatCont.Text.Trim().Length - 1);
                    textAppPatCont.Select(textAppPatCont.Text.Trim().Length, 1);
                }
            }
        }

        private void textAppDocCont_TextChanged(object sender, EventArgs e)
        {
            if (textAppDocCont.Text.Trim().Length > 0)
            {
                if (!Integrity.NumberOnly(textAppDocCont.Text.Trim()))
                {
                    textAppDocCont.Text = textAppDocCont.Text.Substring(0, textAppDocCont.Text.Trim().Length - 1);
                    textAppDocCont.Select(textAppDocCont.Text.Trim().Length, 1);
                }
            }
        }

        private void textAppPatFirst_TextChanged(object sender, EventArgs e)
        {
            if (textAppPatFirst.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textAppPatFirst.Text.Trim()))
                {
                    textAppPatFirst.Text = textAppPatFirst.Text.Substring(0, textAppPatFirst.Text.Trim().Length - 1);
                    textAppPatFirst.Select(textAppPatFirst.Text.Trim().Length, 1);
                }
            }
        }

        private void textAppPatLast_TextChanged(object sender, EventArgs e)
        {
            if (textAppPatFirst.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textAppPatFirst.Text.Trim()))
                {
                    textAppPatFirst.Text = textAppPatFirst.Text.Substring(0, textAppPatFirst.Text.Trim().Length - 1);
                    textAppPatFirst.Select(textAppPatFirst.Text.Trim().Length, 1);
                }
            }
        }

        private void textAppDocFirst_TextChanged(object sender, EventArgs e)
        {
            if (textAppDocFirst.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textAppDocFirst.Text.Trim()))
                {
                    textAppDocFirst.Text = textAppDocFirst.Text.Substring(0, textAppDocFirst.Text.Trim().Length - 1);
                    textAppDocFirst.Select(textAppDocFirst.Text.Trim().Length, 1);
                }
            }
        }

        private void textAppDocLast_TextChanged(object sender, EventArgs e)
        {
            if (textAppDocLast.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textAppDocLast.Text.Trim()))
                {
                    textAppDocLast.Text = textAppDocLast.Text.Substring(0, textAppDocLast.Text.Trim().Length - 1);
                    textAppDocLast.Select(textAppDocLast.Text.Trim().Length, 1);
                }
            }
        }

        private void chboUnknown_CheckedChanged(object sender, EventArgs e)
        {
            if (chboUnknown.Checked)
            {
                datSchedule.Enabled = false;
                tmAppointment.Enabled = false;
            }
            else
            {
                datSchedule.Enabled = true;
                tmAppointment.Enabled = true;
            }
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}
