/* Primary Reference(s) */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/* Database Reference(s) */
using MySql.Data.MySqlClient;

/* UI Framework */
using MetroFramework;

/* Slide animation */
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ClinicManagementSystem
{
    public partial class FormStaff : Form
    {
        private MySqlConnection conn = null;
        private System.Windows.Forms.Timer sysTimer = new System.Windows.Forms.Timer();

        private string lastName = "";
        private string firstName = "";
        private string userType = "";
        private string userID = "";

        /* Original Window */
        private CtrlLogs ctrlLogs = null;
        private CtrlRegi ctrlRegi = null;
        private CtrlAddAppt ctrlAdd = null;
        private CtrlCheckAppt ctrlCheck = null;

        /* Cached Window */
        private CtrlLogs cache_ctrLogs = null;
        private CtrlRegi cache_ctrlRegi = null;
        private CtrlAddAppt cache_ctrlAdd = null;
        private CtrlCheckAppt cache_ctrlCheck = null;

        /* Handled Windows */
        private FormQueue formQueue = null;

        /// <summary>
        /// Draggable window elements
        /// </summary>
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private int currentWindow = 0;
        private enum ButtonCount
        {
            LOGS,
            REGISTRATION,
            CHECK_APPOINTMENT,
            ADD_APPOINTMENT,
            REPORTS
        };

        /* Form Registration */
        private bool first = true;
        private bool inPanel = false;

        public FormStaff(MySqlConnection conn, string userID, string firstName, string lastName, string userType)
        {
            InitializeComponent();

            this.conn = conn;
            this.userID = userID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userType = userType;

            formQueue = new FormQueue(conn);
            formQueue.Show();
            formQueue.WindowState = FormWindowState.Minimized;

            this.ctrlLogs = new CtrlLogs(this, formQueue, conn, userID);
            this.ctrlRegi = new CtrlRegi(this, conn, userID);
            this.ctrlCheck = new CtrlCheckAppt(this, conn, userID);
            this.ctrlAdd = new CtrlAddAppt(this, conn, userID);

            pnlControl.SuspendLayout();
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(ctrlLogs);
            pnlControl.ResumeLayout();

            lblLastName.Text = lastName;
            lblFirstName.Text = firstName;
            lblUserID.Text = userID;
            lblUserType.Text = userType;

            sysTimer.Interval = 100;
            sysTimer.Tick += new EventHandler(UpdateSystemTime);
            sysTimer.Enabled = true;

            lblAction.Text = "LOG PATIENT";

            pnlControl.HorizontalScroll.Enabled = false;
            pnlControl.HorizontalScroll.Visible = false;
        } // Class Constructor()

        private void UpdateSystemTime(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MM / dd / yyyy");
            lblTime.Text = DateTime.Now.ToString("hh : mm : ss tt");
        } // private void UpdateSystemTime()

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to log out the current account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    string sql = "UPDATE tblLogIn " +
                                    "SET dtmDateTimeLogOut = NOW() " +
                                    "WHERE strLogInCode = @userID;";
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;

                    /* Prepare SQL Statements */
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Prepare();

                    /* Execute Prepared Query */
                    cmd.ExecuteNonQuery();

                    /* Close Connection */
                    conn.Close();

                    /* Close Scanner */
                    ctrlLogs.CloseCam();

                    FormLogIn fli = new FormLogIn();
                    fli.Show();
                    formQueue.Close();
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
        } // Action[Click]: btnLogOut

        private void btnLog_Click(object sender, EventArgs e)
        {
            lblAction.Text = "LOG PATIENT";
            this.ResetPanels();
            pnlLogs.BringToFront();
            Util.Animate(pnlLogs, Util.Effect.Slide, 100, 0);
        } // Action[Click]: btnLog

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblAction.Text = "REGISTER PATIENT";
            this.ResetPanels();
            pnlRegistration.BringToFront();
            Util.Animate(pnlRegistration, Util.Effect.Slide, 100, 0);
        } // Action[Click]: btnRegister

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblAction.Text = "CHECK APPOINTMENT";
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(ctrlCheck);
            Util.Animate(pnlAppt, Util.Effect.Slide, 100, 0);
        } // Action[Click]: btnCheck

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblAction.Text = "ADD APPOINTMENT";
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(ctrlAdd);
            Util.Animate(pnlAppt, Util.Effect.Slide, 100, 0);
        } // Action[Click]: btnAdd

        private void SuspendCurrentLayout()
        {
            //pnlControl.Invalidate();
            pnlControl.Controls.Clear();
            pnlControl.AutoScroll = true;
            ValidateAllControls();
        } // private void SuspendCurrentLayout

        private void SwapControls()
        {
            if (currentWindow == (int)ButtonCount.LOGS)
            {
                cache_ctrLogs = ctrlLogs;
            }
            else if (currentWindow == (int)ButtonCount.REGISTRATION)
            {
                cache_ctrlRegi = ctrlRegi;
            }
            else if (currentWindow == (int)ButtonCount.CHECK_APPOINTMENT)
            {
                cache_ctrlCheck = ctrlCheck;
            }
            else if (currentWindow == (int)ButtonCount.ADD_APPOINTMENT)
            {
                cache_ctrlAdd = ctrlAdd;
            }
            else
            {

            }
        } // private void SwapControls()

        private void ValidateAllControls()
        {
            //ctrlLogs.Validate();
            ctrlRegi.Validate();
            ctrlAdd.Validate();
            ctrlCheck.Validate();
        }

        private void FormStaff_Shown(object sender, EventArgs e)
        {
            if (first)
            {
                MetroMessageBox.Show(this, "Access Granted!\n" +
                    "Welcome " + firstName + "!",
                    "Access Granted!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

                first = false;
            }
        }

        private void FormStaff_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void FormStaff_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void FormStaff_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void ResetPanels()
        {
            if (pnlLogs.Visible)
            {
                Util.Animate(pnlLogs, Util.Effect.Slide, 100, 0);
            }

           if (pnlRegistration.Visible)
           {
               Util.Animate(pnlRegistration, Util.Effect.Slide, 100, 0);
           }

           if (pnlAppt.Visible)
           {
               Util.Animate(pnlAppt, Util.Effect.Slide, 100, 0);
           }
        }

        private void btnLogInput_Click(object sender, EventArgs e)
        {
            pnlControl.Controls.Clear();
            ctrlLogs.SetWindowVisible(1);
            pnlControl.Controls.Add(ctrlLogs);
            Util.Animate(pnlLogs, Util.Effect.Slide, 100, 0);
        }

        private void btnLogQR_Click(object sender, EventArgs e)
        {
            pnlControl.Controls.Clear();
            ctrlLogs.SetWindowVisible(2);
            pnlControl.Controls.Add(ctrlLogs);
            Util.Animate(pnlLogs, Util.Effect.Slide, 100, 0);
        }

        private void btnLog_MouseEnter(object sender, EventArgs e)
        {
            this.ResetPanels();
            pnlLogs.BringToFront();
            Util.Animate(pnlLogs, Util.Effect.Slide, 100, 0);
        }

        private void btnViewPat_Click(object sender, EventArgs e)
        {
            pnlControl.Controls.Clear();
            ctrlRegi.SetWindowVisible(1);
            pnlControl.Controls.Add(ctrlRegi);
            Util.Animate(pnlRegistration, Util.Effect.Slide, 100, 0);
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            pnlControl.Controls.Clear();
            ctrlRegi.SetWindowVisible(2);
            pnlControl.Controls.Add(ctrlRegi);
            Util.Animate(pnlRegistration, Util.Effect.Slide, 100, 0);
        }

        private void pnlButtons_Click(object sender, EventArgs e)
        {
            this.ResetPanels();
        }

        private void btnPatient_MouseEnter(object sender, EventArgs e)
        {
            this.ResetPanels();
            pnlRegistration.BringToFront();
            Util.Animate(pnlRegistration, Util.Effect.Slide, 100, 0);
        }

        private void pnlTitle_Click(object sender, EventArgs e)
        {
            this.ResetPanels();
        }

        private void pnlControl_Click(object sender, EventArgs e)
        {
            this.ResetPanels();
        }

        private void pnlHeader_Click(object sender, EventArgs e)
        {
            this.ResetPanels();
        }

        private void btnLogOut_MouseHover(object sender, EventArgs e)
        {
            this.ResetPanels();
        }

        private void btnAppt_Click(object sender, EventArgs e)
        {
            this.ResetPanels();
            pnlAppt.BringToFront();
            Util.Animate(pnlAppt, Util.Effect.Slide, 100, 0);
        }

        private void btnAppt_MouseEnter(object sender, EventArgs e)
        {
            this.ResetPanels();
            pnlAppt.BringToFront();
            Util.Animate(pnlAppt, Util.Effect.Slide, 100, 0);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            CtrlReportNav reportNav = new CtrlReportNav();
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(reportNav);

            lblAction.Text = "GENERATE REPORTS";
        }

        private void pnlButtons_MouseHover(object sender, EventArgs e)
        {
            this.ResetPanels();
        }

        private void pnlTitle_MouseHover(object sender, EventArgs e)
        {
            this.ResetPanels();
        }

        private void btnReports_MouseHover(object sender, EventArgs e)
        {
            this.ResetPanels();
        }

    } // class Program
} // namespace ClinicManagementSystem
