using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
{
    public partial class FormAdmin : Form
    {
        private MySqlConnection conn = null;
        private CtrlAddStaff ctrlAddStaff = null;
        private CtrlRemoveStaff ctrlRemoveStaff = null;
        private CtrlDeletePatient ctrlDeletePatient = null;

        private string lastName = "";
        private string firstName = "";
        private string userType = "";
        private string userID = "";

        private enum ButtonCount
        {
            Patient,
            Staff,
            Meta
        };
        private ButtonCount buttonCount;

        public FormAdmin(MySqlConnection conn, string userID, string firstName, string lastName, string userType)
        {
            InitializeComponent();

            this.conn = conn;
            this.userID = userID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userType = userType;

            this.lblFirstName.Text = firstName;
            this.lblLastName.Text = lastName;
            this.lblUserID.Text = userID;
            this.lblUserType.Text = userType;

            this.ctrlAddStaff = new CtrlAddStaff(conn, userID);
            this.ctrlRemoveStaff = new CtrlRemoveStaff(conn, userID);
            this.ctrlDeletePatient = new CtrlDeletePatient(conn, userID);

            this.pnlControl.Controls.Clear();
            this.pnlControl.Controls.Add(ctrlDeletePatient);
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            lblAction.Text = "PATIENT";
            buttonCount = ButtonCount.Patient;

            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(ctrlDeletePatient);
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            lblAction.Text = "ADD STAFF";
            buttonCount = ButtonCount.Patient;

            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(ctrlAddStaff);
        }

        private void btnMeta_Click(object sender, EventArgs e)
        {
            buttonCount = ButtonCount.Meta;
        }

        private void SwapControls()
        {
            if (buttonCount == ButtonCount.Patient)
            {

            }
            else if (buttonCount == ButtonCount.Staff)
            {

            }
            else
            {

            }
        }

        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            lblAction.Text = "REMOVE STAFF";

            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(ctrlRemoveStaff);
        }

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
                             "SET strDoctStatus = 'OFF' " +
                             "WHERE strStaffID = '" + userID + "' AND " +
                             "dtmDateTimeLogOut IS NULL;";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    sql = "UPDATE tblLogIn " +
                                    "SET dtmDateTimeLogOut = NOW(), " +
                                        "strDoctStatus = 'OFF' " +
                                    "WHERE strLogInCode = @userID;";
                    cmd = new MySqlCommand(sql, conn);
                    /* Prepare SQL Statements */
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Prepare();

                    /* Execute Prepared Query */
                    cmd.ExecuteNonQuery();

                    /* Close Connection */
                    conn.Close();

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

    }
}
