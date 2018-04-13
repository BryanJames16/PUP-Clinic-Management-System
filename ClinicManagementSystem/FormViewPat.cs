using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace ClinicManagementSystem
{
    public partial class FormViewPat : Form
    {
        private Form form;
        private MySqlConnection conn;
        private string patientID = "";
        private string userID = "";
        private bool isEdit = false;

        /// <summary>
        /// Draggable window elements
        /// </summary>
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public FormViewPat(Form form, MySqlConnection conn, string patientID, string userID)
        {
            InitializeComponent();

            this.form = form;
            this.conn = conn;
            this.patientID = patientID;
            this.userID = userID;

            UpdateHeader();
            UpdatePatientInfo();
            UpdateEdits();

            this.pnlToPrint.Location = new Point(-1000, -1000);
        }

        public FormViewPat(MySqlConnection conn, string patientID, string userID)
        {
            InitializeComponent();

            this.conn = conn;
            this.patientID = patientID;
            this.userID = userID;

            UpdateHeader();
            UpdatePatientInfo();

            this.pnlToPrint.Location = new Point(-1000, -1000);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                cboType.Visible = false;
                textPatNo.Visible = false;
                textPatFirstName.Visible = false;
                textPatLastName.Visible = false;
                textPatMiddleName.Visible = false;
                datBirthdate.Visible = false;
                textHomeAddress.Visible = false;
                textCity.Visible = false;
                textProvince.Visible = false;
                textRegion.Visible = false;
                cboGender.Visible = false;
                textPatCont.Visible = false;
                cboCollege.Visible = false;
                cboCourse.Visible = false;
                textGuardFirst.Visible = false;
                textGuardLast.Visible = false;
                textGuardMiddle.Visible = false;
                textGuardCont.Visible = false;
                textRelation.Visible = false;
            }
            else
            {
                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to save changes?",
                                                  "Confirm",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Asterisk);
                if (dr == DialogResult.Yes)
                {
                    this.isEdit = !this.isEdit;

                    cboType.Visible = false;
                    textPatNo.Visible = false;
                    textPatFirstName.Visible = false;
                    textPatLastName.Visible = false;
                    textPatMiddleName.Visible = false;
                    datBirthdate.Visible = false;
                    textHomeAddress.Visible = false;
                    textCity.Visible = false;
                    textProvince.Visible = false;
                    textRegion.Visible = false;
                    cboGender.Visible = false;
                    textPatCont.Visible = false;
                    cboCollege.Visible = false;
                    cboCourse.Visible = false;
                    textGuardFirst.Visible = false;
                    textGuardLast.Visible = false;
                    textGuardMiddle.Visible = false;
                    textGuardCont.Visible = false;
                    textRelation.Visible = false;

                    btnEdit.Text = "EDIT";
                    btnBack.Text = "BACK";
                }
            }
            else
            {
                this.isEdit = !this.isEdit;

                cboType.Visible = true;
                textPatNo.Visible = true;
                textPatFirstName.Visible = true;
                textPatLastName.Visible = true;
                textPatMiddleName.Visible = true;
                datBirthdate.Visible = true;
                textHomeAddress.Visible = true;
                textCity.Visible = true;
                textProvince.Visible = true;
                textRegion.Visible = true;
                cboGender.Visible = true;
                textPatCont.Visible = true;
                cboCollege.Visible = true;
                cboCourse.Visible = true;
                textGuardFirst.Visible = true;
                textGuardLast.Visible = true;
                textGuardMiddle.Visible = true;
                textGuardCont.Visible = true;
                textRelation.Visible = true;

                btnEdit.Text = "SAVE";
                btnBack.Text = "CANCEL";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            PrintDialog printDialog = new PrintDialog();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printDocument.DocumentName = "QR Code";

            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap btmPanel = new Bitmap(pnlToPrint.Width, pnlToPrint.Height);
            pnlToPrint.DrawToBitmap(btmPanel, new Rectangle(0, 0, pnlToPrint.Width, pnlToPrint.Height));
            e.Graphics.DrawImage(btmPanel, 0, 0);
            btmPanel.Dispose();
        }

        private void UpdateHeader()
        {
            string lastName = "";
            string firstName = "";
            string userType = "";
            string sql = "SELECT strLastName, strFirstName, strPositionCode " + 
                         "FROM tblStaff " + 
                         "WHERE strStaffID = @staffID " + 
                         "LIMIT 1;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@staffID", this.userID);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lastName = reader.GetString("strLastName");
                    firstName = reader.GetString("strFirstName");
                    userType = reader.GetString("strPositionCode");
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

            try
            {
                lblLastName.Text = lastName;
                lblFirstName.Text = firstName;
                lblUserID.Text = userID;
                lblUserType.Text = userType;
            }
            catch (Exception ex)
            {
                Integrity.GetExceptionDetails(ex);
            }
        }

        public void UpdatePatientInfo()
        {
            string patientType = "";
            string guardID = "";

            string sql = "SELECT * FROM tblPatient WHERE strPatientID = '" + patientID + "';";
            try
            {
                /* Patient Main Info */
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lblPatIDVal.Text = reader.GetString("strPatientID");
                    lblIDNoVal.Text = reader.GetString("strIDNumber");
                    lblPatNameVal.Text = reader.GetString("strPatientLastName") + ", " +
                                      reader.GetString("strPatientFirstName") + " " +
                                      reader.GetString("strPatientMiddleName");
                    lblBirthdateVal.Text = reader.GetDateTime("dtmDateOfBirth").ToString("MM / dd / yyyy");
                    lblGenderVal.Text = reader.GetString("strGender");
                    lblContactNoVal.Text = reader.GetString("strPatientContactNumber");

                    guardID = reader.GetString("strGuardianID");

                    textPatNo.Text = reader.GetString("strIDNumber");
                    textPatFirstName.Text = reader.GetString("strPatientFirstName");
                    textPatLastName.Text = reader.GetString("strPatientLastName");
                    textPatMiddleName.Text = reader.GetString("strPatientMiddleName");
                    datBirthdate.Value = reader.GetDateTime("dtmDateOfBirth");
                    cboGender.SelectedText = reader.GetString("strGender");
                    textPatCont.Text = reader.GetString("strPatientContactNumber");

                    cboGender.SelectedIndex = 0;
                }

                reader.Close();

                /* Patient Address Info */
                sql = "SELECT * FROM tblHomeAddress WHERE strPatientID = '" + patientID + "';";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lblAddressVal.Text = reader.GetString("strHomeAddress") + ", " + 
                                           reader.GetString("strCity") + ", " + 
                                           reader.GetString("strProvince") + ", " +
                                           reader.GetString("strRegion");

                    textHomeAddress.Text = reader.GetString("strHomeAddress");
                    textCity.Text = reader.GetString("strCity");
                    textProvince.Text = reader.GetString("strProvince");
                    textRegion.Text = reader.GetString("strRegion");
                }

                reader.Close();

                /* Guardian Info */
                sql = "SELECT * FROM tblGuardian WHERE strGuardianID = '" + guardID + "';";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lblGuardNameVal.Text = reader.GetString("strLastName") + ", " + 
                                           reader.GetString("strFirstName") + " " + 
                                           reader.GetString("strMiddleName");
                    lblGuardContactNoVal.Text = reader.GetString("strContact");
                    lblRelationVal.Text = reader.GetString("strRelation");

                    textGuardFirst.Text = reader.GetString("strFirstName");
                    textGuardMiddle.Text = reader.GetString("strMiddleName");
                    textGuardLast.Text = reader.GetString("strLastName");
                    textGuardCont.Text = reader.GetString("strContact");
                    textRelation.Text = reader.GetString("strRelation");
                }

                reader.Close();

                /* Get Patient Sub Info */
                sql = "SELECT * FROM tblPatientType WHERE strPatientID = '" + patientID + "';";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    patientType = reader.GetString("strTypeDesc");
                    lblPatientTypeVal.Text = reader.GetString("strTypeDesc");
                }

                reader.Close();

                if (patientType.ToUpper().Equals("STUDENT"))
                {
                    lblCourse.Text = "Course:";

                    sql = "SELECT a.strCollegeDesc, b.strCourseDesc " + 
                          "FROM tblCollege a, tblCourse b, tblPatientType c " + 
                          "WHERE a.strCollegeCode = c.strCollegeCode AND " + 
                                "b.strCourseCode = c.strCourseCode AND " + 
                                "c.strPatientID = '" + patientID + "';";
                    cmd = new MySqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lblCollegeVal.Text = reader.GetString("strCollegeDesc");
                        lblCourseVal.Text = reader.GetString("strCourseDesc");

                        //cboCollege.SelectedText = reader.GetString("strCollegeDesc");
                        //cboCourse.SelectedText = reader.GetString("strCourseDesc");
                    }

                    reader.Close();
                }
                else if (patientType.ToUpper().Equals("PROFESSOR"))
                {
                    lblCourse.Text = "Department:";

                    sql = "SELECT a.strCollegeDesc, b.strDeptDesc " +
                          "FROM tblCollege a, tblDepartment b, tblPatientType c " +
                          "WHERE a.strCollegeCode = c.strCollegeCode AND " +
                                "b.strDeptCode = c.strDeptCode AND " +
                                "c.strPatientID = '" + patientID + "';";
                    cmd = new MySqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lblCollegeVal.Text = reader.GetString("strCollegeDesc");
                        lblCourseVal.Text = reader.GetString("strDeptDesc");

                        //cboCollege.SelectedText = reader.GetString("strCollegeDesc");
                        //cboCourse.SelectedText = reader.GetString("strDeptDesc");
                    }

                    reader.Close();
                }
                else
                {
                    lblCollege.Visible = false;
                    lblCollegeVal.Visible = false;

                    lblCourse.Text = "Department:";

                    sql = "SELECT a.strDesc " + 
                          "FROM tblStaffDepartment a, tblPatientType b " + 
                          "WHERE a.strStaffDeptCode = b.strStaffDeptCode AND " + 
                                "b.strPatientID = '" + patientID + "';";
                    cmd = new MySqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lblCourseVal.Text = reader.GetString("strDesc");

                        //cboCourse.SelectedText(reader.GetString("strDesc"));
                    }

                    reader.Close();

                    lblCourse.Text = "Department:";
                }

                pboQR.BackgroundImage = QuickRead.GenerateQR(patientID.Trim());
                pboPrintQR.BackgroundImage = QuickRead.GenerateQR(patientID.Trim());
            }
            catch (MySqlException me)
            {
                Integrity.GetExceptionDetails(me);
            }
            catch (Exception ex)
            {
                Integrity.GetExceptionDetails(ex);
            }

            lblPrintName.Text = textPatLastName.Text + "\n" + textPatFirstName.Text + " " + textPatMiddleName.Text;
            lblPrintID.Text = lblIDNoVal.Text;
            lblPrintPatID.Text = lblPatIDVal.Text;
        }

        private void UpdateEdits()
        {
            
        }

        private void FormViewPat_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void FormViewPat_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void FormViewPat_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

    }
}
