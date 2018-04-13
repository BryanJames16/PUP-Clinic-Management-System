using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
{
    public partial class CtrlAddStaff : UserControl
    {
        private bool isFirst = true;
        private MySqlConnection conn;
        private string userID = "";

        public CtrlAddStaff(MySqlConnection conn, string userID)
        {
            InitializeComponent();

            this.cboGender.SelectedIndex = 0;
            this.cboUserType.SelectedIndex = 0;

            this.conn = conn;
            this.userID = userID;

            try
            {
                string sql = "SELECT strStaffID " +
                             "FROM tblStaff " +
                             "ORDER BY strStaffID DESC " +
                             "LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    textDocID.Text = SmartCounter.NextInt(reader.GetString("strStaffID"));
                    textDocID.ReadOnly = true;
                    isFirst = false;
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

        private void textContact_TextChanged(object sender, EventArgs e)
        {
            Integrity.TextChange_Number(sender);
            /*
            if (textContact.Text.Trim().Length > 0)
            {
                if (!Integrity.NumberOnly(textContact.Text.Trim()))
                {
                    textContact.Text = textContact.Text.Substring(0, textContact.Text.Trim().Length - 1);
                    textContact.Select(textContact.Text.Trim().Length, 1);
                }
            }
            */
        }

        private void textStaffName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textDocFirst.Clear();
            textDocMiddle.Clear();
            textStaffLast.Clear();
            cboGender.SelectedIndex = 0;
            textContact.Clear();
            textUsername.Clear();
            textPassword.Clear();
            cboUserType.SelectedIndex = 0;

            try
            {
                string sql = "SELECT strStaffID "  + 
                             "FROM tblStaff " + 
                             "ORDER BY strStaffID DESC " + 
                             "LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    textDocID.Text = SmartCounter.NextInt(reader.GetString("strStaffID"));
                    textDocID.ReadOnly = true;
                    isFirst = false;
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

            if (isFirst)
            {
                textDocID.Clear();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string report = "Please enter a valid ";
            string userType = "";
            bool isCorrect = true;

            if (isFirst && textDocID.Text.Trim().Equals(""))
            {
                report += "User ID!";
                isCorrect = false;
            }
            else if (textStaffLast.Text.Trim().Equals(""))
            {
                report += "Last Name!";
                isCorrect = false;
            }
            else if (textDocFirst.Text.Trim().Equals(""))
            {
                report += "First Name!";
                isCorrect = false;
            }
            else if (textDocMiddle.Text.Trim().Equals(""))
            {
                report += "Middle Name!";
                isCorrect = false;
            }
            else if (textContact.Text.Trim().Equals("") || textContact.Text.Trim().Length < 9)
            {
                report += "Contact Number!";
                isCorrect = false;
            }
            else if (textUsername.Text.Trim().Equals(""))
            {
                report += "Username!";
                isCorrect = false;
            }
            else if (textPassword.Text.Trim().Equals(""))
            {
                report += "Password!";
                isCorrect = false;
            }

            if (isCorrect)
            {
                if (cboUserType.SelectedIndex == 0)
                {
                    userType = "FRONTDESK";
                }
                else if (cboUserType.SelectedIndex == 1)
                {
                    userType = "DOCT";
                }
                else
                {
                    userType = "ADMIN";
                }

                try
                {
                    int resultCounter = 0;
                    string sql = "SELECT * " +
                                 "FROM tblStaff " +
                                 "WHERE (strStaffID = '" + textDocID.Text.Trim() + "') OR " +
                                       "(strFirstName = '" + textDocFirst.Text.Trim() + "' AND " +
                                        "strLastName = '" + textStaffLast.Text.Trim() + "' AND " +
                                        "strMiddleName = '" + textDocMiddle.Text.Trim() + "');";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        resultCounter++;
                    }

                    reader.Close();

                    if (resultCounter == 0)
                    {
                        sql = "INSERT INTO tblStaff(strStaffID, strLastName, strFirstName, strMiddleName, " +
                                                   "strGender, strContactNumber, strUsername, strPassword, strPositionCode) " +
                              "VALUES ('" + textDocID.Text.Trim() + "', " +
                                      "'" + textStaffLast.Text.Trim() + "', " +
                                      "'" + textDocFirst.Text.Trim() + "', " +
                                      "'" + textDocMiddle.Text.Trim() + "', " +
                                      "'" + cboGender.GetItemText(cboGender.SelectedItem) + "', " +
                                      "'+639" + textContact.Text.Trim() + "', " +
                                      "'" + textUsername.Text.Trim() + "', " +
                                      "'" + textPassword.Text.Trim() +"', " + 
                                      "'" + userType + "');";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Staff successfully registered!", "Success", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        btnClear_Click(null, null);
                    }
                    else
                    {
                        Integrity.ShowDuplicateDialog();
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
                MessageBox.Show(report, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
