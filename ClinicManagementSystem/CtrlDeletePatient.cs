using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
{
    public partial class CtrlDeletePatient : UserControl
    {
        private MySqlConnection conn = null;
        private string userID = "";
        private List<string>[] patientList;

        public CtrlDeletePatient(MySqlConnection conn, string userID)
        {
            InitializeComponent();

            this.conn = conn;
            this.userID = userID;
            this.patientList = new List<string>[6];

            for (int count = 0; count < patientList.GetLength(0); count++)
            {
                patientList[count] = new List<string>();
            }

            this.Dock = DockStyle.Top;
        }

        private void ClearPatientList()
        {
            dgvPatient.Rows.Clear();
            for (int count = 0; count < patientList.GetLength(0); count++)
            {
                patientList[count].Clear();
            }
        }

        private void btnAdvSearchPat_Click(object sender, EventArgs e)
        {
            FormAdvancedSearch advSearch = new FormAdvancedSearch(this, conn, userID);
            advSearch.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvPatient.Rows.Count <= 0)
            {
                MessageBox.Show("Please select a valid patient first!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to remove this patient?\n" + 
                                                    "This is undoable, do you want to continue?",
                                                    "CONFIRMATION WARNING",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        string sql = "UPDATE tblPatient " + 
                                     "SET boolIsActive = false " + 
                                     "WHERE strPatientID = '" + patientList[dgvPatient.CurrentRow.Index][0] + "';";
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
            }
        }

        public void UpdatePatient(string sql)
        {
            dgvPatient.Rows.Clear();
            ClearPatientList();

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            int resultCount = 0;

            while (reader.Read())
            {
                patientList[0].Add(reader.GetString("strPatientID"));
                patientList[1].Add(reader.GetString("strIDNumber"));
                patientList[2].Add(reader.GetString("strPatientLastName"));
                patientList[3].Add(reader.GetString("strPatientFirstName"));
                patientList[4].Add(reader.GetString("strGender"));
                patientList[5].Add(reader.GetString("strPatientContactNumber"));

                dgvPatient.Rows.Add(reader.GetString("strPatientLastName"),
                                   reader.GetString("strPatientFirstName"),
                                   reader.GetString("strPatientContactNumber"),
                                   reader.GetString("strGender"));
                resultCount++;
            }

            reader.Close();

            if (resultCount > 0)
            {
                MessageBox.Show("Search Done!\nFound " + resultCount + " matches!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Search Done! No matching record found!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnPatClear_Click(object sender, EventArgs e)
        {
            ClearPatientList();

            try
            {
                string sql = "SELECT strPatientID, strIDNumber, strPatientFirstName, strPatientLastName, strPatientContactNumber, strGender " +
                     "FROM tblPatient " +
                     "WHERE boolIsActive;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int resultCount = 0;

                while (reader.Read())
                {
                    patientList[0].Add(reader.GetString("strPatientID"));
                    patientList[1].Add(reader.GetString("strIDNumber"));
                    patientList[2].Add(reader.GetString("strPatientLastName"));
                    patientList[3].Add(reader.GetString("strPatientFirstName"));
                    patientList[4].Add(reader.GetString("strGender"));
                    patientList[5].Add(reader.GetString("strPatientContactNumber"));

                    dgvPatient.Rows.Add(reader.GetString("strPatientLastName"),
                                       reader.GetString("strPatientFirstName"),
                                       reader.GetString("strPatientContactNumber"),
                                       reader.GetString("strGender"));
                    resultCount++;
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

        private void btnPatSearch_Click(object sender, EventArgs e)
        {
            if (textName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter a valid search key!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClearPatientList();

                try
                {
                    string sql = "SELECT strPatientID, strIDNumber, strPatientFirstName, strPatientLastName, strPatientContactNumber, strGender " +
                         "FROM tblPatient " +
                         "WHERE boolIsActive AND (strPatientFirstName LIKE '%" + textName.Text.Trim() + "%' OR " +
                        "strPatientLastName LIKE '%" + textName.Text.Trim() + "%');";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    int resultCount = 0;

                    while (reader.Read())
                    {
                        patientList[0].Add(reader.GetString("strPatientID"));
                        patientList[1].Add(reader.GetString("strIDNumber"));
                        patientList[2].Add(reader.GetString("strPatientLastName"));
                        patientList[3].Add(reader.GetString("strPatientFirstName"));
                        patientList[4].Add(reader.GetString("strGender"));
                        patientList[5].Add(reader.GetString("strPatientContactNumber"));

                        dgvPatient.Rows.Add(reader.GetString("strPatientLastName"),
                                           reader.GetString("strPatientFirstName"),
                                           reader.GetString("strPatientContactNumber"),
                                           reader.GetString("strGender"));
                        resultCount++;
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

        }
    }
}
