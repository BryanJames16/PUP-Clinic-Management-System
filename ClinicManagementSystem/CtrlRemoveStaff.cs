using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
{
    public partial class CtrlRemoveStaff : UserControl
    {
        private string userID = "";
        private MySqlConnection conn = null;

        public CtrlRemoveStaff(MySqlConnection conn, string userID)
        {
            InitializeComponent();

            this.conn = conn;
            this.userID = userID;

            btnReset_Click(null, null);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string sql = "SELECT a.strStaffID, a.strLastName, a.strFirstName, " +
                                    "a.strGender, a.strContactNumber, a.strUserName, " +
                                    "a.strUsername, a.strPassword, b.strPositionDescription " +
                             "FROM tblStaff a, tblPositionDetails b " +
                             "WHERE a.strPositionCode = b.strPositionCode AND " +
                                   "b.strPositionCode <> 'NULL';";
            dgvList.Rows.Clear();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvList.Rows.Add(reader.GetString("strStaffID"),
                                     reader.GetString("strLastName"),
                                     reader.GetString("strFirstName"),
                                     reader.GetString("strGender"),
                                     reader.GetString("strContactNumber"),
                                     reader.GetString("strUsername"),
                                     reader.GetString("strPassword"),
                                     reader.GetString("strPositionDescription"));
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to remove this staff?", 
                                              "Confirm",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = "UPDATE tblStaff " +
                             "SET strPositionCode = 'NULL' " +
                             "WHERE strStaffID = '" + dgvList.SelectedCells[0].Value.ToString() + "';";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Staff has successfully been removed!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Asterisk);

                    btnReset_Click(null, null);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!textStaffID.Text.Trim().Equals("") && !textStaffLastName.Text.Trim().Equals(""))
            {
                string sql = "SELECT a.strStaffID, a.strLastName, a.strFirstName, " + 
                                    "a.strGender, a.strContactNumber, a.strUserName, " + 
                                    "a.strUsername, a.strPassword, b.strPositionDescription " + 
                             "FROM tblStaff a, tblPositionDetails b " + 
                             "WHERE a.strPositionCode = b.strPositionCode AND " + 
                                   "b.strPositionCode <> 'NULL' ";

                if (!textStaffID.Text.Trim().Equals(""))
                {
                    sql += " AND ";
                    sql += "a.strStaffID LIKE '%" + textStaffID.Text.Trim() + "%' ";
                }

                if (!textStaffLastName.Text.Trim().Equals(""))
                {
                    sql += " AND ";
                    sql += "(a.strLastName LIKE '%" + textStaffLastName.Text.Trim() + "%' OR " + 
                            "a.strFirstName LIKE '%" + textStaffLastName.Text.Trim() + "%')";
                }

                sql += ";";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dgvList.Rows.Add(reader.GetString("strStaffID"), 
                                         reader.GetString("strLastName"),
                                         reader.GetString("strFirstName"), 
                                         reader.GetString("strGender"),
                                         reader.GetString("strContactNumber"),
                                         reader.GetString("strUsername"),
                                         reader.GetString("strPassword"),
                                         reader.GetString("strPositionDescription"));
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
            else
            {
                MessageBox.Show("Please enter a valid search keyword!", 
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textStaffID.Clear();
            textStaffLastName.Clear();
        }
    }
}
