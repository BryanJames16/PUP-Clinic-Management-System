using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using MetroFramework;

namespace ClinicManagementSystem
{
    public partial class FormDoctor : Form
    {
        private MySqlConnection conn = null;
        private string userID = "";
        private string firstName = "";
        private string lastName = "";
        private string userType = "";

        private System.Windows.Forms.Timer sysTimer = new System.Windows.Forms.Timer();
        private bool isFirst = true;

        private CtrlViewAppt ctrlViewAppt = null;
        private CtrlViewTags ctrlViewTags = null;
        private CtrlMedicalProcess ctrlMedicalProcess = null;

        /// <summary>
        /// Draggable window elements
        /// </summary>
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public FormDoctor(MySqlConnection conn, string userID, string firstName, string lastName, string userType) 
        {
            InitializeComponent();

            this.conn = conn;
            this.userID = userID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userType = userType;

            this.sysTimer.Interval = 100;
            this.sysTimer.Tick += new EventHandler(UpdateSystemTime);
            this.sysTimer.Enabled = true;

            this.lblLastName.Text = lastName;
            this.lblFirstName.Text = firstName;
            this.lblUserID.Text = userID;
            this.lblUserType.Text = userType;

            this.toggleStatus.Checked = true;

            this.ctrlViewAppt = new CtrlViewAppt(conn, userID);
            this.ctrlViewTags = new CtrlViewTags(conn, userID);
            this.btnView_Click(null, null);
        }

        private void UpdateSystemTime(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MM / dd / yyyy");
            lblTime.Text = DateTime.Now.ToString("hh : mm : ss tt");
        } // private void UpdateSystemTime()

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to log out the current account?", 
                                                "Confirmation", 
                                                MessageBoxButtons.YesNo, 
                                                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    string sql = "UPDATE tblLogIn " +
                             "SET strDoctStatus = 'OFF', " +
                                "dtmDateTimeLogOut = NOW() " +
                             "WHERE strStaffID = '" + userID + "' AND " +
                             "dtmDateTimeLogOut IS NULL;";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    /* Close Connection */
                    conn.Close();

                    /* Close Threads */
                    ctrlViewAppt.CloseThreads();

                    FormLogIn fli = new FormLogIn();
                    fli.Show();
                    this.Close();
                }
                catch (MySqlException me)
                {
                    MessageBox.Show(me.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lblStat.Text = "VIEW APPOINTMENTS";
            pnlCatcher.Controls.Clear();
            pnlCatcher.Controls.Add(ctrlViewAppt);
        }

        private void btnViewTags_Click(object sender, EventArgs e)
        {
            lblStat.Text = "VIEW TAGGED PATIENTS";
            pnlCatcher.Controls.Clear();
            pnlCatcher.Controls.Add(ctrlViewTags);
        }

        private void btnMedProcs_Click(object sender, EventArgs e)
        {
            lblStat.Text = "MEDICAL PROCESS";
            pnlCatcher.Controls.Clear();
            //this.ctrlMedicalProcess = new CtrlMedicalProcess(this, conn, userID, patientID);
            //pnlCatcher.Controls.Add(ctrlMedicalProcess);
        }

        private void toggleStatus_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE tblLogIn " + 
                             "SET strDoctStatus = ";

                if (toggleStatus.Checked)
                {
                    sql += "'ON' ";
                }
                else
                {
                    sql += "'OFF' ";
                }

                sql += "WHERE strStaffID = '" + userID + "' AND " + 
                             "dtmDateTimeLogOut IS NULL;";

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
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "REPORTS";
            CtrlDoctReports doctReports = new CtrlDoctReports();
            pnlCatcher.Controls.Clear();
            pnlCatcher.Controls.Add(doctReports);
        }

        private void FormDoctor_Shown(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Access Granted!\n" +
                    "Welcome " + firstName + "!",
                    "Access Granted!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
        }

        private void FormDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctrlViewAppt.CloseThreads();
            ctrlViewTags.CloseThreads();
        }

        private void FormDoctor_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void FormDoctor_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void FormDoctor_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}
