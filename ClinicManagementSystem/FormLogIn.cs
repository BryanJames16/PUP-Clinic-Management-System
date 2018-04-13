/* Primary Reference(s) */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

/* Database Reference(s) */
using MySql.Data.MySqlClient;

/* Framework UI */
using MetroFramework;
using System.Drawing;

namespace ClinicManagementSystem
{
    public partial class FormLogIn : Form
    {
        /// <summary>
        ///  Objects used for the database
        /// </summary>
        private MySqlConnection conn;
        private MySqlDataReader reader;

        /// <summary>
        /// Connection String
        /// </summary>

        private TextBox textUsername2;
        private TextBox textPassword2;

        /*
        // Local Database Connection
        private string dbConnectionInfo = "server=127.0.0.1;" +
                                          "database=dtbClinic;" +
                                          "uid=root;" +
                                          "pwd=admin;";
        
        // Local Report Connection
        public static string ServerName = "MySql";
        public static string DatabaseName = "dtbClinic";
        public static string UserID = "root";
        public static string Password = "admin";
        */
        
        // Networked Database Connection
        private string dbConnectionInfo = "server=Earl;" +
                                          "database=dtbClinic;" +
                                          "uid=FrontDesk;" +
                                          "pwd=frontdesk;";
        
        // Networked Report Connection
        public static string ServerName = "Earl";
        public static string DatabaseName = "dtbClinic";
        public static string UserID = "FrontDesk";
        public static string Password = "frontdesk";
        

        private string firstName = "";
        private string lastName = "";
        private string userType = "";
        private string userID = "";
        private string userPosition = "";

        /// <summary>
        /// Draggable window elements
        /// </summary>
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        /// <summary>
        /// Default constructor
        /// </summary>
        public FormLogIn()
        {
            InitializeComponent();
            PrepareText();

            /**
             * Open a connection
             */
            dbConnectionInfo = "server=127.0.0.1;" +
                                          "database=dtbClinic;" +
                                          "uid=" + textUsername2.Text + ";" +
                                          "pwd=" + textPassword2.Text + ";";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = dbConnectionInfo;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error! Cannot connect to the database!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                this.Close();
            }

            //conn.Close();

            /**
            *   ZXING
             */
            /*
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = dbConnectionInfo;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error! Cannot connect to the database!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                this.Close();
            }
             * */
        } // Class Constructor

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            TimeHandler.SilentSynchronizeTime();
        } // Action[Load]: FormLogIn

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        } // Action[Click]: btnExit;

        private void btnClear_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textPassword.Clear();
        } // Action[Click]: btnClear

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (textUsername.Text.Trim().Equals(""))
            {
                MetroMessageBox.Show(this, "Please enter a valid username!");
                isValid = false;
            }
            else if (textPassword.Text.Trim().Equals(""))
            {
                MetroMessageBox.Show(this, "Please enter a valid password!");
                isValid = false;
            }

            if (isValid)
            {
                string sql = "SELECT strLastName, strFirstName, strStaffID, strPositionCode " + 
                            "FROM tblStaff " + 
                            "WHERE strUserName = @userName AND strPassword = @password AND boolIsActive;";

                try
                {
                    int resultCount = 0;

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    /* Prepare statements */
                    cmd.Parameters.AddWithValue("@userName", textUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", textPassword.Text.Trim());
                    cmd.Prepare();

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        firstName = reader.GetString("strFirstName");
                        lastName = reader.GetString("strLastName");
                        userID = reader.GetString("strStaffID");
                        userPosition = reader.GetString("strPositionCode");

                        resultCount++;
                    }

                    reader.Close();

                    if (resultCount == 1)
                    {
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

                        if (userPosition.Equals("FRONTDESK") || userPosition.Equals("DOCT") || userPosition.Equals("ADMIN"))
                        {
                            string loginID = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() +
                                DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + "";

                            sql = "INSERT INTO tblLogIn(strLogInCode, strStaffID, dtmDateTimeLogged, strDoctStatus) ";

                            if (userPosition.Equals("DOCT"))
                            {
                                sql += "VALUES(@loginID, @userID, NOW(), 'ON');";
                            }
                            else
                            {
                                sql += "VALUES(@loginID, @userID, NOW(), 'OFF');";
                            }

                            cmd = new MySqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = sql;

                            /* Prepare statements */
                            cmd.Parameters.AddWithValue("@loginID", loginID);
                            cmd.Parameters.AddWithValue("@userID", userID);
                            cmd.Prepare();

                            /* Update time in and time out */
                            cmd.ExecuteNonQuery();

                            if (userPosition.Equals("FRONTDESK"))
                            {
                                FormStaff formStaff = new FormStaff(conn, userID, firstName, lastName, userType);
                                formStaff.Show();
                                this.Close();
                            }
                            else if (userPosition.Equals("DOCT"))
                            {
                                FormDoctor formDoctor = new FormDoctor(conn, userID, firstName, lastName, userType);
                                formDoctor.Show();
                                this.Close();
                            }
                            else 
                            {
                                FormSelection formSelect = new FormSelection(conn, userID, firstName, lastName, userType);
                                formSelect.Show();
                                this.Close();
                            }
                        }
                        else
                        {
                            Integrity.ShowInvalidTypeDialog();
                        }
                    }
                    else if (resultCount >= 2)
                    {
                        Integrity.ShowDuplicateDialog();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, 
                                            "Invalid Username / Password!", 
                                            "Access Denied", 
                                            MessageBoxButtons.OK, 
                                            MessageBoxIcon.Error);
                    }
                }
                catch(MySqlException me)
                {
                    Integrity.GetExceptionDetails(me);
                }
            }

        } // Action[Click]: btnLogIn

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!Integrity.NoSpaceOnly(textUsername.Text.Trim()))
                {
                    textUsername.Text = textUsername.Text.Substring(0, textUsername.Text.Trim().Length - 1);
                    textUsername.Select(textUsername.Text.Trim().Length, 1);
                }

                TextBox t = sender as TextBox;
                if (t != null)
                {
                    try
                    {
                        int resultCount = 0;
                        string sql = "SELECT strUsername " +
                                     "FROM tblStaff " +
                                     "WHERE strUsername LIKE '%" + textUsername.Text.Trim() + "%';";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        List<string> listCollect = new List<string>();
                        AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                        while (reader.Read())
                        {
                            //listCollect.Add(reader.GetString("strUsername"));
                            collection.Add(reader.GetString("strUsername"));
                            resultCount++;
                        }

                        reader.Close();

                        collection.AddRange(listCollect.ToArray());

                        textUsername.AutoCompleteCustomSource = collection;
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
            catch (Exception)
            {

            }
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

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void PrepareText()
        {
            textPassword2 = new TextBox();
            textUsername2 = new TextBox();

            textPassword2.Text = "admin";
            textUsername2.Text = "root";
        }
    } // class Program
} // namespace ClinicManagementSystem
