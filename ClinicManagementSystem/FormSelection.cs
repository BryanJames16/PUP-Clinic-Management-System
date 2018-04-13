using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using MetroFramework;

namespace ClinicManagementSystem
{
    public partial class FormSelection : Form
    {
        private MySqlConnection conn = null;

        private string lastName = "";
        private string firstName = "";
        private string userType = "";
        private string userID = "";

        public FormSelection(MySqlConnection conn, string userID, string firstName, string lastName, string userType)
        {
            InitializeComponent();

            this.conn = conn;
            this.userID = userID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userType = userType;
        }

        private void btnFrontDesk_Click(object sender, EventArgs e)
        {
            FormStaff formStaff = new FormStaff(conn, userID, firstName, lastName, userType);
            formStaff.Show();
            this.Close();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            FormDoctor formDoctor = new FormDoctor(conn, userID, firstName, lastName, userType);
            formDoctor.Show();
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin(conn, userID, firstName, lastName, userType);
            formAdmin.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void FormSelection_Shown(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Access Granted!\n" +
                    "Welcome " + firstName + "!",
                    "Access Granted!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
        }

    }
}
