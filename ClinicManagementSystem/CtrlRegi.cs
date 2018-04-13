/* Primary Reference(s) */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

/* Database Reference(s) */
using MySql.Data.MySqlClient;

/* QR Code Reference(s) */
using QRCoder;
using System.Drawing.Printing;

namespace ClinicManagementSystem
{
    public partial class CtrlRegi : UserControl
    {
        private MySqlConnection conn = null;
        private FormStaff form = null;
        private string userID = "";
        private bool isDelete = false;
        private bool isPrime = true;
        private string genderCode = "";

        public CtrlRegi(FormStaff form, MySqlConnection conn, string userID)
        {
            InitializeComponent();

            this.conn = conn;
            this.userID = userID;

            this.UpdatePatientID();
            this.cboPatType.SelectedIndex = 0;

            this.form = form;

            this.pnlViewPatient.Controls.Clear();
            this.pnlViewPatient.Controls.Add(new CtrlPat(form, conn, userID));

            this.cboGender.SelectedIndex = 0;
            this.cboRegion.SelectedIndex = 0;
            dtpBirthday.MaxDate = DateTime.Now.AddYears(-4);

            this.pnlToPrint.Location = new Point(-1000, -1000);
        } // Class Constructor

        private void CtrlRegi_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
        } // Action[Load]: CtrlRegi

        private void btnClear_Click(object sender, EventArgs e)
        {
            /* General Information */
            cboPatType.SelectedIndex = 0;
            textPatID.Clear();
            textPatNumber.Clear();

            /* Personal Information */
            textLastName.Clear();
            textFirstName.Clear();
            textMiddleName.Clear();
            dtpBirthday.MaxDate = DateTime.Now.AddYears(-4);
            textHomeAddress.Clear();
            textCity.Clear();
            textProvince.Clear();
            cboRegion.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            textContactNumber.Clear();
            cboCollege.Visible = true;
            cboCourse.Visible = true;
            cboCollege.SelectedIndex = 0;
            cboCourse.SelectedIndex = 0;

            /* Guardian Informtion */
            textGuardLastName.Clear();
            textGuardFirstName.Clear();
            textGuardMiddleName.Clear();
            textGuardContactNumber.Clear();
            textRelation.Clear();

            this.UpdatePatientID();
        } // Action[Click]: btnClear

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to register this patient?", 
                                              "Confirm", 
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (dr.Equals(DialogResult.Yes))
            {
                if (this.CheckEntries())
                {
                    try
                    {
                        string sql = "SELECT * " + 
                                     "FROM tblPatient " + 
                                     "WHERE boolIsActive AND ((strIDNumber = @strIDNumber) OR " + 
                                            "(strPatientLastName = @strPatLastName AND " + 
                                             "strPatientFirstName = @strPatFirstName AND " + 
                                             "strPatientMiddleName = @strPatMiddleName));";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@strIDNumber", textPatID.Text.Trim());
                        cmd.Parameters.AddWithValue("@strPatLastName", textLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@strPatFirstName", textFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@strPatMiddleName", textMiddleName.Text.Trim());
                        MySqlDataReader readerCheck = cmd.ExecuteReader();
                        int readCount = 0;

                        while (readerCheck.Read())
                        {
                            readCount++;
                        }

                        readerCheck.Close();

                        if (readCount >= 1)
                        {
                            Integrity.ShowDuplicateDialog();
                        }
                        else
                        {
                            sql = "INSERT INTO tblGuardian(strGuardianID, strLastName, strFirstName, strMiddleName, " +
                                                          "strContact, strRelation) " +
                                  "VALUES(@strGuardID, @strLastName, @strFirstName, " +
                                         "@strMiddleName, @strContactNumber, @strRelation);";
                            cmd = new MySqlCommand(sql, conn);

                            if (isPrime)
                            {
                                cmd.Parameters.AddWithValue("@strGuardID", textPatID.Text.Trim() + "-GUARD");
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@strGuardID", lblPatIDVal.Text.Trim() + "-GUARD");
                            }

                            cmd.Parameters.AddWithValue("@strLastName", textGuardLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@strFirstName", textGuardFirstName.Text.Trim());
                            cmd.Parameters.AddWithValue("@strMiddleName", textGuardMiddleName.Text.Trim());
                            cmd.Parameters.AddWithValue("@strContactNumber", "+639" + textGuardContactNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@strRelation", textRelation.Text.Trim());
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();

                            /* Insert values to tblPatient */
                            sql = "INSERT INTO tblPatient(strPatientID, strIDNumber, strPatientLastName, strPatientFirstName, " +
                                                         "strPatientMiddleName, strPatientContactNumber, dtmDateOfBirth, strGender, " +
                                                         "strGuardianID, boolIsActive) " +
                                     "VALUES(@strPatientID, @strIDNumber, @strLastName, " +
                                            "@strFirstName, @strMiddleName, @strPatientContactNumber, " +
                                            "@dtmDateOfBirth, @strGender, " +
                                            "@strGuardianID, true);";
                            cmd = new MySqlCommand(sql, conn);

                            if (isPrime)
                            {
                                cmd.Parameters.AddWithValue("@strPatientID", textPatID.Text.Trim());
                                cmd.Parameters.AddWithValue("@strGuardianID", textPatID.Text.Trim() + "-GUARD");
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@strPatientID", lblPatIDVal.Text.Trim());
                                cmd.Parameters.AddWithValue("@strGuardianID", lblPatIDVal.Text.Trim() + "-GUARD");
                            }

                            cmd.Parameters.AddWithValue("@strIDNumber", textPatNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@strLastName", textLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@strFirstName", textFirstName.Text.Trim());
                            cmd.Parameters.AddWithValue("@strMiddleName", textMiddleName.Text.Trim());
                            cmd.Parameters.AddWithValue("@strPatientContactNumber", "+639" + textContactNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@dtmDateOfBirth", dtpBirthday.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@strGender", genderCode);
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();

                            sql = "INSERT INTO tblHomeAddress(strPatientID, strHomeAddress, strRegion, strProvince, strCity) " + 
                                  "VALUES(@strPatientID, @strHomeAddress, @regionCode, @provCode, @cityCode);";
                            cmd = new MySqlCommand(sql, conn);

                            if (isPrime)
                            {
                                cmd.Parameters.AddWithValue("@strPatientID", textPatID.Text.Trim());
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@strPatientID", lblPatIDVal.Text.Trim());
                            }

                            cmd.Parameters.AddWithValue("@strHomeAddress", textHomeAddress.Text.Trim());
                            cmd.Parameters.AddWithValue("@regionCode", cboRegion.GetItemText(cboRegion.SelectedItem).Trim());
                            cmd.Parameters.AddWithValue("@provCode", textProvince.Text.Trim());
                            cmd.Parameters.AddWithValue("@cityCode", textCity.Text.Trim());
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();

                            if (isPrime)
                            {
                                sql = "INSERT INTO tblRegistration " +
                                    "VALUES('" + TimeHandler.GetCurrentDateTime() + "-REG" + "', '" + userID + "', " +
                                            "'" + textPatID.Text.Trim() + "', NOW());";
                            }
                            else
                            {
                                sql = "INSERT INTO tblRegistration " +
                                    "VALUES('" + TimeHandler.GetCurrentDateTime() + "-REG" + "', '" + userID + "', " +
                                            "'" + lblPatIDVal.Text.Trim() + "', NOW());";
                            }

                            try
                            {
                                cmd = new MySqlCommand(sql, conn);
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


                            string collegeCode = "";
                            string courseCode = "";
                            string profDCode = "";
                            string deptCode = "";
                            string typeCode = "";
                            string typeDesc = "";

                            if (cboPatType.SelectedIndex == 0)
                            {
                                /* Get College Code */
                                sql = "SELECT strCollegeCode " +
                                      "FROM tblCollege " +
                                      "WHERE strCollegeDesc = @strCollegeDescription " +
                                      "LIMIT 1;";
                                cmd = new MySqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@strCollegeDescription", cboCollege.GetItemText(cboCollege.SelectedItem));
                                cmd.Prepare();
                                MySqlDataReader reader = cmd.ExecuteReader();

                                while (reader.Read())
                                {
                                    collegeCode = reader.GetString("strCollegeCode");
                                }

                                reader.Close();

                                /* Get Course Code */
                                sql = "SELECT strCourseCode " +
                                      "FROM tblCourse " +
                                      "WHERE strCourseDesc = @strCourseDescription " +
                                      "LIMIT 1;";
                                cmd = new MySqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@strCourseDescription", cboCourse.GetItemText(cboCourse.SelectedItem));
                                cmd.Prepare();
                                reader = cmd.ExecuteReader();

                                while (reader.Read())
                                {
                                    courseCode = reader.GetString("strCourseCode");
                                }

                                reader.Close();

                                profDCode = "NA";
                                deptCode = "NA";
                                typeCode = "STUD";
                                typeDesc = "Student";
                            }
                            else if (cboPatType.SelectedIndex == 1)
                            {
                                /* Get College Code */
                                sql = "SELECT strCollegeCode " +
                                      "FROM tblCollege " +
                                      "WHERE strCollegeDesc = @strCollegeDescription " +
                                      "LIMIT 1;";
                                cmd = new MySqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@strCollegeDescription", cboCollege.GetItemText(cboCollege.SelectedItem));
                                cmd.Prepare();
                                MySqlDataReader reader = cmd.ExecuteReader();

                                while (reader.Read())
                                {
                                    collegeCode = reader.GetString("strCollegeCode");
                                }

                                reader.Close();

                                /* Get Course Code */
                                sql = "SELECT strDeptCode " +
                                      "FROM tblDepartment " +
                                      "WHERE strDeptDesc = @strDeptDescription " +
                                      "LIMIT 1;";
                                cmd = new MySqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@strDeptDescription", cboCourse.GetItemText(cboCourse.SelectedItem));
                                cmd.Prepare();
                                reader = cmd.ExecuteReader();

                                while (reader.Read())
                                {
                                    profDCode = reader.GetString("strDeptCode");
                                }

                                reader.Close();

                                courseCode = "NA";
                                deptCode = "NA";
                                typeCode = "PROF";
                                typeDesc = "Professor";
                            }
                            else
                            {
                                sql = "SELECT strStaffDeptCode " + 
                                      "FROM tblStaffDepartment " + 
                                      "WHERE strDesc = @desc " + 
                                      "LIMIT 1;";
                                cmd = new MySqlCommand(sql,  conn);
                                cmd.Parameters.AddWithValue("@desc", cboCourse.GetItemText(cboCourse.SelectedItem));
                                cmd.Prepare();
                                MySqlDataReader reader = cmd.ExecuteReader();

                                while (reader.Read())
                                {
                                    deptCode = reader.GetString("strStaffDeptCode");
                                }

                                reader.Close();

                                courseCode = "NA";
                                collegeCode = "NA";
                                profDCode = "NA";
                                typeCode = "STAFF";
                                typeDesc = "Staff";
                            }

                            sql = "INSERT INTO tblPatientType(strPatientID, strTypeCode, strTypeDesc, " + 
                                                             "strCollegeCode, strCourseCode, strDeptCode, " + 
                                                             "strStaffDeptCode) " + 
                                                      "VALUES(@patientID, @typeCode, @typeDesc, " + 
                                                             "@college, @course, @profD, " + 
                                                             "@staffD);";
                            cmd = new MySqlCommand(sql, conn);
                            if (isPrime)
                            {
                                cmd.Parameters.AddWithValue("@patientID", textPatID.Text.Trim());
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@patientID", lblPatIDVal.Text.Trim());
                            }
                            cmd.Parameters.AddWithValue("@typeCode", typeCode);
                            cmd.Parameters.AddWithValue("@typeDesc", typeDesc);
                            cmd.Parameters.AddWithValue("@college", collegeCode);
                            cmd.Parameters.AddWithValue("@course", courseCode);
                            cmd.Parameters.AddWithValue("@profD", profDCode);
                            cmd.Parameters.AddWithValue("@staffD", deptCode);
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();

                            PrintDocument printDocument = new PrintDocument();
                            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                            printDocument.DocumentName = "Patient ID";

                            printDialog.Document = printDocument;
                            if (printDialog.ShowDialog() == DialogResult.OK)
                            {
                                printDocument.Print();
                            }

                            MessageBox.Show("Patient Successfully Registered!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear_Click(null, null);
                            UpdatePatientID();
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
            }
        } // Action[Click]: btnSubmit

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            pboPrintQR.Image = pboQR.Image;
            lblPrintName.Text = textLastName.Text.Trim() + ", \n" + textFirstName.Text.Trim() + " " + textMiddleName.Text.Trim();
            lblPrintID.Text = textIDNumber.Text.Trim();
            if (this.isPrime)
            {
                lblPrintPatID.Text = textPatID.Text.Trim();
            }
            else
            {
                lblPrintPatID.Text = lblPatID.Text.Trim();
            }

            Bitmap btmPanel = new Bitmap(pnlToPrint.Width, pnlToPrint.Height);
            pnlToPrint.DrawToBitmap(btmPanel, new Rectangle(0, 0, pnlToPrint.Width, pnlToPrint.Height));
            e.Graphics.DrawImage(btmPanel, 0, 0);
            btmPanel.Dispose();
        }

        private void UpdatePatientID()
        {
            /* SQL Query Variable(s) */
            string sql = "SELECT strPatientID " + 
                            "FROM tblPatient " + 
                            "ORDER BY strPatientID DESC " + 
                            "LIMIT 1;";
            bool first = true;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            
            /* Function Member Variable(s) */
            string lastID = "";

            try
            {
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lastID = reader.GetString("strPatientID");
                    first = false;
                }

                reader.Close();

                if (first)
                {
                    this.isPrime = true;
                    lblPatIDVal.Visible = false;
                }
                else
                {
                    this.isPrime = false;
                    textPatID.Visible = false;
                    lblPatIDVal.Visible = true;

                    lblPatIDVal.Text = SmartCounter.NextInt(lastID);

                    pboQR.BackgroundImage = QuickRead.GenerateQR(lblPatIDVal.Text.Trim());
                    pboQR.Visible = true;
                }
            }
            catch (MySqlException me)
            {
                Integrity.GetExceptionDetails(me);
            }
            catch (Exception me)
            {
                Integrity.GetExceptionDetails(me);
            }

        } // private void UpdatePatientID()

        private void CtrlRegi_Validated(object sender, EventArgs e)
        {
            this.UpdatePatientID();
        } // Action[Validate]: CtrlRegi

        private void textPatID_Leave(object sender, EventArgs e)
        {
            if (!textPatID.Text.Trim().Equals(""))
            {
                if (isPrime)
                {
                    pboQR.BackgroundImage = QuickRead.GenerateQR(textPatID.Text.Trim());
                    pboQR.Visible = true;
                }
                else
                {
                    pboQR.BackgroundImage = QuickRead.GenerateQR(lblPatID.Text.Trim());
                    pboQR.Visible = true;
                }
            }
        } // Action[Leave] : textPatID

        private void cboPatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cboPatType.SelectedIndex == 0 || this.cboPatType.SelectedIndex == 1)
                {
                    lblCourse.Visible = true;
                    lblCollege.Visible = true;
                    cboCourse.Visible = true;
                    cboCollege.Visible = true;

                    cboCourse.Items.Clear();
                    cboCollege.Items.Clear();

                    string sql = "SELECT strCollegeDesc " +
                                    "FROM tblCollege;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string type = reader.GetString("strCollegeDesc");
                        if (!type.ToLower().Equals("Not Applicable".ToLower()))
                        {
                            cboCollege.Items.Add(type);
                        }
                    }

                    reader.Close();

                    cboCollege.SelectedIndex = 0;

                    if (this.cboPatType.SelectedIndex == 0)
                    {
                        cboPatType.MaxLength = 15;
                    }
                    else
                    {
                        cboPatType.MaxLength = 12;
                    }
                }
                else if (this.cboPatType.SelectedIndex == 2)
                {
                    lblCollege.Visible = false;
                    cboCollege.Visible = false;
                    lblCourse.Visible = true;
                    cboCourse.Visible = true;
                    cboCourse.Items.Clear();

                    lblCourse.Text = "DEPARTMENT:";
                    string sql = "SELECT strDesc " +
                                    "FROM tblStaffDepartment;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string type = reader.GetString("strDesc");
                        if (!type.ToLower().Equals("Not Applicable".ToLower()))
                        {
                            cboCourse.Items.Add(type);
                        }
                    }

                    reader.Close();

                    cboCourse.SelectedIndex = 0;
                    cboPatType.MaxLength = 15;
                }
                else
                {
                    Integrity.ShowInvalidTypeDialog();
                }
            }
            catch (IndexOutOfRangeException iore)
            {
                Integrity.GetExceptionDetails(iore);
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

        private void cboCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cboCourse.Items.Clear();
                string sql = "";
                MySqlCommand cmd = null;
                MySqlDataReader reader = null;
                bool staff = true;

                if (this.cboPatType.SelectedIndex == 0)
                {
                    this.lblCourse.Text = "COURSE:";

                    sql = "SELECT a.strCourseDesc " +
                            "FROM tblCourse a, tblCollege b " + 
                            "WHERE a.strCollegeCode = b.strCollegeCode AND " + 
                            "b.strCollegeDesc = @collegeDesc;";
                    staff = false;
                }
                else if (this.cboPatType.SelectedIndex == 1)
                {
                    this.lblCourse.Text = "DEPARTMENT:";

                    sql = "SELECT a.strDeptDesc " +
                            "FROM tblDepartment a, tblCollege b " +
                            "WHERE a.strCollegeCode = b.strCollegeCode AND " +
                            "b.strCollegeDesc = @collegeDesc;";
                    staff = false;
                }
                else
                {
                    this.lblCourse.Text = "DEPARTMENT:";

                    sql = "SELECT strDesc " +
                          "FROM tblStaffDepartment " + 
                          "ORDER BY strDesc ASC;";
                }

                if (staff)
                {
                    cmd = new MySqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string type = reader.GetString("strDesc");
                        if (!type.ToLower().Equals("Not Applicable".ToLower()))
                        {
                            cboCourse.Items.Add(type);
                        }
                    }

                    reader.Close();
                }
                else
                {
                    cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@collegeDesc", cboCollege.GetItemText(cboCollege.SelectedItem));
                    cmd.Prepare();

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (this.cboPatType.SelectedIndex == 0)
                        {
                            string type = reader.GetString("strCourseDesc");
                            if (!type.ToLower().Equals("Not Applicable".ToLower()))
                            {
                                cboCourse.Items.Add(type);
                            }
                        }
                        else
                        {
                            string type = reader.GetString("strDeptDesc");
                            if (!type.ToLower().Equals("Not Applicable".ToLower()))
                            {
                                cboCourse.Items.Add(type);
                            }
                        }
                    }

                    reader.Close();
                }

                cboCourse.SelectedIndex = 0;
            }
            catch (IndexOutOfRangeException iore)
            {
                Integrity.GetExceptionDetails(iore);
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

        private void textPatNumber_TextChanged(object sender, EventArgs e)
        {
            if (cboPatType.SelectedIndex == 0)
            {
                if ((textPatNumber.Text.Trim().Length <= 4 && textPatNumber.Text.Trim().Length > 0) || 
                    (textPatNumber.Text.Trim().Length >= 6 && textPatNumber.Text.Trim().Length <= 10) ||
                    (textPatNumber.Text.Trim().Length == 15))
                {
                    if (!Integrity.NumberOnly(textPatNumber.Text.Trim()))
                    {
                        textPatNumber.Text = textPatNumber.Text.Substring(0, textPatNumber.Text.Trim().Length - 1);
                        textPatNumber.Select(textPatNumber.Text.Trim().Length, 1);
                    }
                }
                else if (textPatNumber.Text.Trim().Length >= 12 && textPatNumber.Text.Trim().Length <= 13)
                {
                    if (!Integrity.LetterOnly(textPatNumber.Text))
                    {
                        textPatNumber.Text = textPatNumber.Text.Substring(0, textPatNumber.Text.Trim().Length - 1);
                        textPatNumber.Select(textPatNumber.Text.Trim().Length, 1);
                    }
                }
                else
                {

                }

                if (textPatNumber.Text.Trim().Length == 4 ||
                    textPatNumber.Text.Trim().Length == 10 ||
                    textPatNumber.Text.Trim().Length == 13)
                {
                    if (!isDelete)
                    {
                        textPatNumber.Text = textPatNumber.Text.Trim() + "-";
                        textPatNumber.SelectionStart = textPatNumber.Text.Trim().Length;
                        textPatNumber.SelectionLength = 0;
                    }
                }
            }
            else if (cboPatType.SelectedIndex == 1)
            {
                if ((textPatNumber.Text.Trim().Length <= 2 && textPatNumber.Text.Trim().Length > 0) ||
                    (textPatNumber.Text.Trim().Length >= 7 && textPatNumber.Text.Trim().Length <= 8))
                {
                    if (!Integrity.LetterOnly(textPatNumber.Text.Trim()))
                    {
                        textPatNumber.Text = textPatNumber.Text.Substring(0, textPatNumber.Text.Trim().Length - 1);
                        textPatNumber.Select(textPatNumber.Text.Trim().Length, 1);
                    }
                }
                else if ((textPatNumber.Text.Trim().Length >= 3 && textPatNumber.Text.Trim().Length <= 6) ||
                         (textPatNumber.Text.Trim().Length >= 9 && textPatNumber.Text.Trim().Length <= 12))
                {
                    if (!Integrity.NumberOnly(textPatNumber.Text.Trim()))
                    {
                        textPatNumber.Text = textPatNumber.Text.Substring(0, textPatNumber.Text.Trim().Length - 1);
                        textPatNumber.Select(textPatNumber.Text.Trim().Length, 1);
                    }
                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void textPatNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                isDelete = true;
            }
            else
            {
                isDelete = false;
            }
        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {
            if (textLastName.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textLastName.Text.Trim()))
                {
                    textLastName.Text = textLastName.Text.Substring(0, textLastName.Text.Trim().Length - 1);
                    textLastName.Select(textLastName.Text.Trim().Length, 1);
                }
            }
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {
            if (textFirstName.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textFirstName.Text.Trim()))
                {
                    textFirstName.Text = textFirstName.Text.Substring(0, textFirstName.Text.Trim().Length - 1);
                    textFirstName.Select(textFirstName.Text.Trim().Length, 1);
                }
            }
        }

        private void textMiddleName_TextChanged(object sender, EventArgs e)
        {
            if (textMiddleName.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textMiddleName.Text.Trim()))
                {
                    textMiddleName.Text = textMiddleName.Text.Substring(0, textMiddleName.Text.Trim().Length - 1);
                    textMiddleName.Select(textMiddleName.Text.Trim().Length, 1);
                }
            }
        }

        private void textContactNumber_TextChanged(object sender, EventArgs e)
        {
            if (textContactNumber.Text.Trim().Length > 0)
            {
                if (!Integrity.NumberOnly(textContactNumber.Text.Trim()))
                {
                    textContactNumber.Text = textContactNumber.Text.Substring(0, textContactNumber.Text.Trim().Length - 1);
                    textContactNumber.Select(textContactNumber.Text.Trim().Length, 1);
                }
            }
        }

        private void textGuardLastName_TextChanged(object sender, EventArgs e)
        {
            if (textGuardLastName.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textGuardLastName.Text.Trim()))
                {
                    textGuardLastName.Text = textGuardLastName.Text.Substring(0, textGuardLastName.Text.Trim().Length - 1);
                    textGuardLastName.Select(textGuardLastName.Text.Trim().Length, 1);
                }
            }
        }

        private void textGuardFirstName_TextChanged(object sender, EventArgs e)
        {
            if (textGuardFirstName.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textGuardFirstName.Text.Trim()))
                {
                    textGuardFirstName.Text = textGuardFirstName.Text.Substring(0, textGuardFirstName.Text.Trim().Length - 1);
                    textGuardFirstName.Select(textGuardFirstName.Text.Trim().Length, 1);
                }
            }
        }

        private void textGuardMiddleName_TextChanged(object sender, EventArgs e)
        {
            if (textGuardMiddleName.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textGuardMiddleName.Text.Trim()))
                {
                    textGuardMiddleName.Text = textGuardMiddleName.Text.Substring(0, textGuardMiddleName.Text.Trim().Length - 1);
                    textGuardMiddleName.Select(textGuardMiddleName.Text.Trim().Length, 1);
                }
            }
        }

        private void textGuardContactNumber_TextChanged(object sender, EventArgs e)
        {
            if (textGuardContactNumber.Text.Trim().Length > 0)
            {
                if (!Integrity.NumberOnly(textGuardContactNumber.Text.Trim()))
                {
                    textGuardContactNumber.Text = textGuardContactNumber.Text.Substring(0, textGuardContactNumber.Text.Trim().Length - 1);
                    textGuardContactNumber.Select(textGuardContactNumber.Text.Trim().Length, 1);
                }
            }
        }

        private bool CheckEntries()
        {
            bool complete = true;
            string report = "Please enter a valid ";

            if (isPrime && (textPatID.Text.Trim().Equals("")))
            {
                report += "Patient ID!";
                complete = false;
            }
            else if (textPatNumber.Text.Trim().Equals(""))
            {
                report += "Patient Number!";
                complete = false;
            }
            else if (textLastName.Text.Trim().Equals(""))
            {
                report += "Last Name!";
                complete = false;
            }
            else if (textFirstName.Text.Trim().Equals(""))
            {
                report += "First Name!";
                complete = false;
            }
            else if (textMiddleName.Text.Trim().Equals(""))
            {
                report += "Middle Name!";
                complete = false;
            }
            else if (textHomeAddress.Text.Trim().Equals(""))
            {
                report += "Home Address!";
                complete = false;
            }
            else if (textCity.Text.Trim().Equals(""))
            {
                report += "City!";
                complete = false;
            }
            else if (textProvince.Text.Trim().Equals(""))
            {
                report += "Province!";
                complete = false;
            }
            else if (textContactNumber.Text.Trim().Equals("") || 
                     textContactNumber.Text.Trim().Length != 9)
            {
                report += "Contact Number!";
                complete = false;
            }
            else if (textGuardLastName.Text.Trim().Equals(""))
            {
                report += "Guardian Last Name!";
                complete = false;
            }
            else if (textGuardFirstName.Text.Trim().Equals(""))
            {
                report += "Guardian First Name!";
                complete = false;
            }
            else if (textGuardMiddleName.Text.Trim().Equals(""))
            {
                report += "Guardian Middle Name!";
                complete = false;
            }
            else if (textRelation.Text.Trim().Equals(""))
            {
                report += "Relation!";
                complete = false;
            }
            else if (textGuardContactNumber.Text.Trim().Equals("") ||
                     textGuardContactNumber.Text.Trim().Length != 9)
            {
                report += "Guardian Contact Number!";
                complete = false;
            }
            
            if (complete)
            {
                if ((textLastName.Text.Trim().Equals(textGuardLastName.Text.Trim())) &&
                    (textFirstName.Text.Trim().Equals(textGuardFirstName.Text.Trim())) &&
                    (textMiddleName.Text.Trim().Equals(textGuardMiddleName.Text.Trim())))
                {
                    report = "Patient name is the same as the patient's guardian name!";
                    complete = false;
                }
                else if (textContactNumber.Text.Trim().Equals(textGuardContactNumber.Text.Trim()))
                {
                    report = "Patient's contact number is the same as the patient's guardian contact number!";
                    complete = false;
                }
                else
                {
                    if (cboGender.SelectedIndex == 0)
                    {
                        genderCode = "M";
                    }
                    else
                    {
                        genderCode = "F";
                    }
                }
            }

            if (!complete)
            {
                Integrity.CustomErrorMessage(report);
            }

            return (complete);
        }

        private void textRelation_TextChanged(object sender, EventArgs e)
        {
            if (textRelation.Text.Trim().Length > 0)
            {
                if (!Integrity.LetterOnly(textRelation.Text.Trim()))
                {
                    textRelation.Text = textRelation.Text.Substring(0, textRelation.Text.Trim().Length - 1);
                    textRelation.Select(textRelation.Text.Trim().Length, 1);
                }
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pboQR.Image, 0, 0);
        }

        public void SetWindowVisible(int choice)
        {
            if (choice == 1)
            {
                pnlViewPatient.Visible = true;
                pnlRegistration.Visible = false;
            }
            else
            {
                pnlViewPatient.Visible = false;
                pnlRegistration.Visible = true;
            }
        }
    } // class Program
} // namespace ClinicManagementSystem
