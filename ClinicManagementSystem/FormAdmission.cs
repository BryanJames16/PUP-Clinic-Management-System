using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
{
    public partial class FormAdmission : Form
    {
        private MySqlConnection conn = null;
        private string userID = "";
        private CtrlMedicalProcess medProc = null;

        /// <summary>
        /// Draggable window elements
        /// </summary>
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public FormAdmission(MySqlConnection conn, string userID, string patientID)
        {
            InitializeComponent();

            this.conn = conn;
            this.userID = userID;
            this.medProc = new CtrlMedicalProcess(this, conn, userID, patientID);

            this.UpdateHeader();
            this.pnlCatcher.Controls.Clear();
            this.pnlCatcher.Controls.Add(medProc);
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
