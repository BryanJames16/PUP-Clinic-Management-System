using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
{
    public partial class FormViewDoct : Form
    {
        private MySqlConnection conn;
        private string doctorID = "";
        private string userID = "";
        private bool isEdit = false;

        /// <summary>
        /// Draggable window elements
        /// </summary>
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public FormViewDoct(MySqlConnection conn, string doctorID, string userID)
        {
            InitializeComponent();

            this.conn = conn;
            this.doctorID = doctorID;
            this.userID = userID;

            UpdateHeader();
            UpdateDoctorInfo();
        }

        private void UpdateHeader()
        {
            string lastName = "";
            string firstName = "";
            string userType = "";
            string sql = "SELECT strLastName, strFirstName, strPositionCode " +
                         "FROM tblStaff " +
                         "WHERE strStaffID = @staffID " +
                         "LIMIT 1;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@staffID", this.userID);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lastName = reader.GetString("strLastName");
                    firstName = reader.GetString("strFirstName");
                    userType = reader.GetString("strPositionCode");
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

            try
            {
                lblLastName.Text = lastName;
                lblFirstName.Text = firstName;
                lblUserID.Text = userID;
                lblUserType.Text = userType;
            }
            catch (Exception ex)
            {
                Integrity.GetExceptionDetails(ex);
            }
        }

        private void UpdateDoctorInfo()
        {
            string position = "";
            string sql = "SELECT a.strStaffID, a.strFirstName, a.strMiddleName, a.strLastName, " +
                                     "a.strGender, a.strContactNumber, a.strUsername, " +
                                     "b.strPositionCode, b.strPositionDescription " +
                              "FROM tblStaff a, tblPositionDetails b " +
                              "WHERE a.strPositionCode = b.strPositionCode AND " +
                                    "a.strStaffID = '" + this.doctorID + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lblIDVal.Text = reader.GetString("strStaffID");
                    lblNameVal.Text = reader.GetString("strFirstName") + " " + reader.GetString("strMiddleName") +
                                        " " + reader.GetString("strLastName");
                    lblGenderVal.Text = reader.GetString("strGender");
                    lblContactVal.Text = reader.GetString("strContactNumber");
                    lblUsernameVal.Text = reader.GetString("strUsername");
                    lblPositionVal.Text = reader.GetString("strPositionDescription");

                    position = reader.GetString("strPositionCode");
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

            if (position.Equals("DOCT"))
            {
                string doctorName = lblNameVal.Text.Trim();
                lblNameVal.Text = "Dr. " + doctorName;
            }
            else if (position.Equals("ADMIN"))
            {
                lblDocID.Text = "Admin ID:";
                lblDrName.Text = "Admin Name:";
            }
            else
            {
                lblDocID.Text = "Staff ID:";
                lblDrName.Text = "Staff Name:";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormViewDoct_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void FormViewDoct_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void FormViewDoct_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}
