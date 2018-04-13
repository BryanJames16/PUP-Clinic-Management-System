using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
{
    public partial class CtrlPat : UserControl
    {
        private MySqlConnection conn;
        private FormStaff form;
        private string userID = "";
        private List<string>[] patientList;

        public CtrlPat(FormStaff form, MySqlConnection conn, string userID)
        {
            InitializeComponent();

            this.conn = conn;
            this.form = form;
            this.userID = userID;
            this.patientList = new List<string>[6];

            for (int count = 0; count < patientList.GetLength(0); count++)
            {
                patientList[count] = new List<string>();
            }

            this.Dock = DockStyle.Top;

            FillDGV();
            dgvSearch.CellDoubleClick += new DataGridViewCellEventHandler(dgvSearch_CellDoubleClick);
        }

        private void dgvSearch_CellDoubleClick(object sender, EventArgs e)
        {
            if (dgvSearch.Rows.Count >= 1)
            {
                FormViewPat viewPat = new FormViewPat(conn, patientList[0][dgvSearch.CurrentRow.Index], userID);
                viewPat.ShowDialog();
            }
        }

        private void ClearPatientList()
        {
            for (int count = 0; count < patientList.GetLength(0); count++)
            {
                patientList[count].Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnClear_Click(null, null);
            dgvSearch.Rows.Clear();
            FillDGV();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textName.Clear();
        }

        private void FillDGV()
        {
            try
            {
                dgvSearch.Rows.Clear();
                this.ClearPatientList();

                string sql = "SELECT strPatientID, strIDNumber, strPatientLastName, strPatientFirstName, strGender, strPatientContactNumber " +
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

                    dgvSearch.Rows.Add(reader.GetString("strPatientLastName"),
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

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            
            if (textName.Text.Trim().Equals(""))
            {
                Integrity.ShowNoKeywordDialog();
            }
            else
            {
                dgvSearch.Rows.Clear();

                string sql = "SELECT strPatientID, strIDNumber, strPatientLastName, strPatientFirstName, strGender, strPatientContactNumber " +
                             "FROM tblPatient " + 
                             "WHERE boolIsActive AND " +
                                  "(strPatientLastName LIKE '%" + textName.Text.Trim() + "%' OR " +
                                   "strPatientFirstName LIKE '%" + textName.Text.Trim() + "%');";

                int resultCounter = 0;

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        patientList[0].Add(reader.GetString("strPatientID"));
                        patientList[1].Add(reader.GetString("strIDNumber"));
                        patientList[2].Add(reader.GetString("strPatientLastName"));
                        patientList[3].Add(reader.GetString("strPatientFirstName"));
                        patientList[4].Add(reader.GetString("strGender"));
                        patientList[5].Add(reader.GetString("strPatientContactNumber"));

                        dgvSearch.Rows.Add(reader.GetString("strPatientLastName"),
                                           reader.GetString("strPatientFirstName"),
                                           reader.GetString("strPatientContactNumber"),
                                           reader.GetString("strGender"));

                        resultCounter++;
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

                if (resultCounter < 1)
                {
                    MessageBox.Show("Search Done!\nNo matching results found!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Search Done!\n" + resultCounter + " matching results found!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnAdvSearch_Click(object sender, EventArgs e)
        {
            FormAdvancedSearch search = new FormAdvancedSearch(form, this, conn, userID);
            search.Show();
            //form.Visible = false;
        }

        public void UpdateView(string sql)
        {
            dgvSearch.Rows.Clear();
            
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

                dgvSearch.Rows.Add(reader.GetString("strPatientLastName"),
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
    }
}
