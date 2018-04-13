/**
 *  .NET Namespaces 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

/**
 *  MySQL namespaces
 */
using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
{
    public partial class CtrlMedicalProcess : UserControl
    {
        private Form handle = null;
        private MySqlConnection conn = null;
        private string userID = "";
        private string patientID = "";
        private string strConsultation = "";
        private string currentKey = "";

        private string consultationCollate = "";
        private string diagnosisCollate = "";
        private string recommendationCollate = "";
        private string treatmentCollate = "";
        private string limitCollate = "";
        private string addtlCollate = "";
        private string prescriptionCollate = "";
        private string refRemarksCollate = "";

        public CtrlMedicalProcess(Form handle, MySqlConnection conn, string userID, string patientID)
        {
            InitializeComponent();

            this.handle = handle;
            this.conn = conn;
            this.userID = userID;
            this.patientID = patientID;

            currentKey = TimeHandler.GetCurrentDateTime();
            this.lblConsID.Text = currentKey + "-CONS";
            this.lblTADID.Text = currentKey + "-TAD";
            this.lblRefCode.Text = currentKey + "-REF";
            this.lblPrescriptionCode.Text = currentKey + "-PRESC";

            pnlConsultation.Visible = true;
            pnlDiagnosis.Visible = false;
            pnlPrescription.Visible = false;
            pnlReferral.Visible = false;

            this.Dock = DockStyle.Fill;

            this.pnlPrescPrint.Location = new Point(-1000, -1000);
        }

        private void btnConsNext_Click(object sender, EventArgs e)
        {
            string totalString = "";
            foreach (string line in textConsultation.Lines)
            {
                totalString += line + "\\n";
            }

            if (totalString.Trim().Equals(""))
            {
                MessageBox.Show("Please enter something!", 
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                strConsultation = totalString;

                pnlConsultation.Visible = false;
                pnlDiagnosis.Visible = true;
                pnlPrescription.Visible = false;
                pnlReferral.Visible = false;
            }
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            if (textDiagnosis.Text.Trim().Equals("") &&
                textRecommendation.Text.Trim().Equals("") &&
                textActLimit.Text.Trim().Equals("") &&
                textAddtlInfo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter something!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                pnlConsultation.Visible = false;
                pnlDiagnosis.Visible = false;
                pnlPrescription.Visible = true;
                pnlReferral.Visible = false;
            }
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            pnlConsultation.Visible = true;
            pnlDiagnosis.Visible = false;
            pnlPrescription.Visible = false;
            pnlReferral.Visible = false;
        }

        private void btnBackDiag_Click(object sender, EventArgs e)
        {
            pnlConsultation.Visible = false;
            pnlDiagnosis.Visible = true;
            pnlPrescription.Visible = false;
            pnlReferral.Visible = false;
        }

        private void btnReferral_Click(object sender, EventArgs e)
        {
            if (textPrescription.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter something!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                pnlConsultation.Visible = false;
                pnlDiagnosis.Visible = false;
                pnlPrescription.Visible = false;
                pnlReferral.Visible = true;
            }
        }

        private void btnRefBackPres_Click(object sender, EventArgs e)
        {
            pnlConsultation.Visible = false;
            pnlDiagnosis.Visible = false;
            pnlPrescription.Visible = true;
            pnlReferral.Visible = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            bool isCorrect = true;

            if ((!textHospital.Text.Trim().Equals("") || !textDoctor.Text.Trim().Equals("") || !textRefRemarks.Text.Trim().Equals("")) &&
                (textHospital.Text.Trim().Equals("") || textDoctor.Text.Trim().Equals("") || textRefRemarks.Text.Trim().Equals("")))
            {
                MessageBox.Show("Please complete the form!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                isCorrect = false;
            }

            if (isCorrect)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to end this transaction?",
                                                "Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Asterisk);
                if (dr == DialogResult.Yes)
                {
                    this.CheckTextFields();
                    this.CollateFields();
                    try
                    {
                        
                        string query1 = "INSERT INTO tblConsultation " +
                                        "VALUES ('" + lblConsID.Text.Trim() + "', '" + patientID + "', " + 
                                                "'" + userID + "', '" + consultationCollate + "');";
                        MySqlCommand cmd = new MySqlCommand(query1,conn);
                        cmd.ExecuteNonQuery();

                        string query2 = "INSERT INTO tblTreatmentDiagnosisDetails " +
                                        "VALUES ('" + lblTADID.Text + "', '" + lblConsID.Text + "', " + 
                                                "'" + diagnosisCollate + "', '" + recommendationCollate + "', " + 
                                                "'" + treatmentCollate + "', '" + limitCollate + "', '" + addtlCollate + "');";
                       // MessageBox.Show(query2);
                        cmd = new MySqlCommand(query2,conn);
                        cmd.ExecuteNonQuery();

                        string query3 = "INSERT INTO tblPrescription " +
                                        "VALUES ('" + lblPrescriptionCode.Text.Trim() + "','" + prescriptionCollate + "', " + 
                                                "'" + lblTADID.Text.Trim() + "');";
                        cmd = new MySqlCommand(query3, conn);
                        cmd.ExecuteNonQuery();

                        /*
                        string query4 = "INSERT INTO tblPrescriptionDetails " +
                                        "VALUES ('','','');";
                        cmd = new MySqlCommand(query4, conn);
                        cmd.ExecuteNonQuery();
                        */

                        if (!textRefRemarks.Text.Equals("N/A"))
                        {
                            string query6 = "INSERT INTO tblReferalDetails " +
                                        "VALUES ('" + lblRefCode.Text.Trim() + "', " + 
                                                "'" + textDoctor.Text.Trim() + "', '" + textHospital.Text.Trim() + "', " + 
                                                "NOW(), '" + textRefRemarks.Text.Trim() + "');";
                            cmd = new MySqlCommand(query6, conn);
                            cmd.ExecuteNonQuery();

                            string query5 = "INSERT INTO tblReferals " +
                                        "VALUES ('" + lblRefCode.Text.Trim() + "','" + patientID + "','" + userID + "');";
                            cmd = new MySqlCommand(query5, conn);
                            cmd.ExecuteNonQuery();
                        }

                        string sql = "UPDATE tblLogIn " +
                          "SET  strDoctStatus = 'ON'" +
                          "WHERE strStaffID = '" + userID + "';";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("Patient Successfully released!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.ClearAllFields();
                    }
                    catch(MySqlException me)
                    {
                        Integrity.GetExceptionDetails(me);
                    }
                    catch (Exception ex)
                    {
                        Integrity.GetExceptionDetails(ex);
                    }

                    handle.Close();
                }
            }
        }

        private void ClearAllFields()
        {
            this.textConsultation.Text = "";
            this.textDiagnosis.Text = "";
            this.textRecommendation.Text = "";
            this.textActLimit.Text = "";
            this.textAddtlInfo.Text = "";
            this.textPrescription.Text = "";
            this.textRefRemarks.Text = "";

            this.textHospital.Text = "";
            this.textDoctor.Text = "";
        }

        private void CheckTextFields()
        {
            string totalString = "";
            foreach (string line in textConsultation.Lines)
            {
                totalString += line + "\\n";
            }

            if (totalString.Equals(""))
            {
                textConsultation.Text = "N/A";
            }

            totalString = "";
            foreach (string line in textDiagnosis.Lines)
            {
                totalString += line + "\\n";
            }

            if (totalString.Equals(""))
            {
                textDiagnosis.Text = "N/A";
            }

            totalString = "";
            foreach (string line in textRecommendation.Lines)
            {
                totalString += line + "\\n";
            }

            if (totalString.Equals(""))
            {
                textRecommendation.Text = "N/A";
            }

            totalString = "";
            foreach (string line in textTreatment.Lines)
            {
                totalString += line + "\\n";
            }

            if (totalString.Equals(""))
            {
                textTreatment.Text = "N/A";
            }

            totalString = "";
            foreach (string line in textActLimit.Lines)
            {
                totalString += line + "\\n";
            }

            if (totalString.Equals(""))
            {
                textActLimit.Text = "N/A";
            }

            totalString = "";
            foreach (string line in textAddtlInfo.Lines)
            {
                totalString += line + "\\n";
            }

            if (totalString.Equals(""))
            {
                textAddtlInfo.Text = "N/A";
            }

            totalString = "";
            foreach (string line in textPrescription.Lines)
            {
                totalString += line + "\\n";
            }

            if (totalString.Equals(""))
            {
                textPrescription.Text = "N/A";
            }

            totalString = "";
            foreach (string line in textHospital.Lines)
            {
                totalString += line + "\\n";
            }

            if (totalString.Equals(""))
            {
                textHospital.Text = "N/A";
            }

            totalString = "";
            foreach (string line in textDoctor.Lines)
            {
                totalString += line + "\\n";
            }

            if (totalString.Equals(""))
            {
                textDoctor.Text = "N/A";
            }

            totalString = "";
            foreach (string line in textRefRemarks.Lines)
            {
                totalString += line + "\\n";
            }

            if (totalString.Equals(""))
            {
                textRefRemarks.Text = "N/A";
            }
        }

        private void CollateFields()
        {
            foreach(string line in textConsultation.Lines)
            {
                consultationCollate += line + "\\\\n";
            }

            foreach (string line in textDiagnosis.Lines)
            {
                diagnosisCollate += line + "\\\\n";
            }

            foreach (string line in textRecommendation.Lines)
            {
                recommendationCollate += line + "\\\\n";
            }

            foreach (string line in textTreatment.Lines)
            {
                treatmentCollate += line + "\\\\n";
            }

            foreach (string line in textActLimit.Lines)
            {
                limitCollate += line + "\\\\n";
            }

            foreach (string line in textAddtlInfo.Lines)
            {
                addtlCollate += line + "\\\\n";
            }

            foreach (string line in textPrescription.Lines)
            {
                prescriptionCollate += line + "\\\\n";
            }

            foreach (string line in textRefRemarks.Lines)
            {
                refRemarksCollate += line + "\\\\n";
            }
        }

    }
}
