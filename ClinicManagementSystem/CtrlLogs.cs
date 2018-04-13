using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using ZXing;
using ZXing.Common;
using ZXing.QrCode;

using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace ClinicManagementSystem
{
    public partial class CtrlLogs : UserControl
    {
        private FilterInfoCollection captureDevice = null;
        private VideoCaptureDevice finalFrame = null;
        private MySqlConnection conn = null;
        private FormStaff formStaff = null;
        private FormQueue formQueue = null;
        private string userID = "";
        private List<string>[] patientList;
        private int windowVisible = 1;

        private long _RunningAlertId = 0;

        public CtrlLogs(FormStaff formStaff, FormQueue formQueue, MySqlConnection conn, string userID)
        {
            InitializeComponent();

            this.conn = conn;
            this.userID = userID;
            this.formStaff = formStaff;
            this.formQueue = formQueue;
            this.patientList = new List<string>[6];

            for (int count = 0; count < patientList.GetLength(0); count++)
            {
                patientList[count] = new List<string>();
            }

            try
            {
                captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo device in captureDevice)
                {
                    cboCapture.Items.Add(device.Name);
                }
                cboCapture.SelectedIndex = 0;
                finalFrame = new VideoCaptureDevice();
            }
            catch (Exception ex)
            {
                Integrity.GetExceptionDetails(ex);
            }

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
                                       reader.GetString("strGender"),
                                       reader.GetString("strPatientContactNumber"));

                    resultCount++;
                }

                reader.Close();
            }
            catch (MySqlException me)
            {
                Integrity.GetExceptionDetails(me);
            }
        }

        private void ClearList()
        {
            for (int count = 0; count < patientList.GetLength(0); count++)
            {
                patientList[count].Clear();
            }
        }

        private void ClearPatientList()
        {
            for (int count = 0; count < patientList.GetLength(0); count++)
            {
                patientList[count].Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvSearch.Rows.Clear();
            ClearPatientList();

            string sql = "SELECT strPatientID, strIDNumber, strPatientLastName, strPatientFirstName, strGender, strPatientContactNumber " +
                         "FROM tblPatient " +
                         "WHERE boolIsActive AND ";
            bool correct = true;

            if (!textName.Text.Trim().Equals(""))
            {
                sql += "(strPatientLastName LIKE '%" + textName.Text.Trim() + "%' OR " +
                       "strPatientFirstName LIKE '%" + textName.Text.Trim() + "%') ";

            }
            else
            {
                MessageBox.Show("Please enter any valid credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correct = false;
            }

            if (correct)
            {
                try
                {
                    sql += ";";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    int resultCount = 0;
                    string patID = "";
                    string patNumber = "";
                    string lastName = "";
                    string firstName = "";
                    string gender = "";
                    string contactNumber = "";

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
                                           reader.GetString("strGender"),
                                           reader.GetString("strPatientContactNumber"));

                        resultCount++;
                    }

                    if (resultCount == 0)
                    {
                        MessageBox.Show("Search done. No results have been found!", "Alert",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Search done. \n" + resultCount + " matching results found!",
                                            "Search", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    }

                    reader.Close();
                }
                catch (MySqlException me)
                {
                    MessageBox.Show(me.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textName.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textName.Clear();
            dgvSearch.Rows.Clear();

            try
            {
                dgvSearch.Rows.Clear();
                ClearPatientList();

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
                                       reader.GetString("strGender"),
                                       reader.GetString("strPatientContactNumber"));

                    resultCount++;
                }

                reader.Close();
            }
            catch (MySqlException me)
            {
                Integrity.GetExceptionDetails(me);
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string logType = "";
            bool valid = true;

            if (valid)
            {
                try
                {
                    string sql = "SELECT * " +
                                "FROM tblPatient " +
                                "WHERE strPatientID = '" + patientList[0][dgvSearch.CurrentRow.Index] + "' AND " +
                                "boolIsActive;";
                    int resultCounter = 0;
                    //MessageBox.Show(sql);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //MessageBox.Show("Matching patient foud");
                        resultCounter++;
                    }

                    reader.Close();

                    if (resultCounter > 0)
                    {
                        string logID = "";

                        resultCounter = 0;
                        sql = "SELECT a.strLogID " +
                                "FROM tblPatientLogs a, tblPatientLogDetails b " +
                                "WHERE a.strPatientID = '" + patientList[0][dgvSearch.CurrentRow.Index] + "' AND a.strLogID = b.strLogID AND " +
                                "b.dtmDateTimeOut IS NULL ORDER BY b.dtmDateTimeLog ASC LIMIT 1;";
                        
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Prepare();
                        try
                        {
                            reader = cmd.ExecuteReader();
                        }
                        catch (MySqlException me)
                        {
                            MessageBox.Show("Exception Caught! \n" + me.Message);
                        }

                        while (reader.Read())
                        {
                            logID = reader.GetString("strLogID");
                            resultCounter++;
                        }

                        reader.Close();

                        if (resultCounter == 1)
                        {
                            sql = "UPDATE tblPatientLogDetails " +
                                    "SET dtmDateTimeOut = NOW(), " +
                                        "strLogType = 'OUT' " +
                                    "WHERE strLogID = @logID;";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@logID", logID);
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();

                            sql = "SELECT strQueueNumber " +
                                  "FROM tblQueue " +
                                  "WHERE strPatientID = '" + patientList[0][dgvSearch.CurrentRow.Index] + "' AND " +
                                        "strQueueStatus = 'WAITING';";
                            cmd = new MySqlCommand(sql, conn);
                            reader = cmd.ExecuteReader();
                            int resCount = 0;
                            string queueNumber = "";

                            while (reader.Read())
                            {
                                queueNumber = reader.GetString("strQueueNumber");
                                resCount++;
                            }

                            reader.Close();

                            if (resCount > 0)
                            {
                                sql = "UPDATE tblQueue " +
                                      "SET strQueueStatus = 'CANCELLED' " +
                                      "WHERE strQueueNumber = '" + queueNumber + "';";
                                cmd = new MySqlCommand(sql, conn);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Successfully logged out!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            int cboIndex = 0;
                            logType = "";
                            DialogResult dr = ExternalForm.InputComboBox(ref cboIndex, ref logType);

                            if (dr == DialogResult.OK)
                            {
                                if (cboIndex <= 0)
                                {
                                    MessageBox.Show("Please select a valid log type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    valid = false;
                                }
                                else
                                {
                                    switch (cboIndex)
                                    {
                                        case 1:
                                            logType = "APPT";
                                            break;
                                        case 2:
                                            logType = "WALK";
                                            break;
                                        case 3:
                                            logType = "EMER";
                                            break;
                                        case 4:
                                            logType = "OTHERS";
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                valid = false;
                            }

                            if (valid)
                            {
                                string dateToday = TimeHandler.GetCurrentDateTime() + "-LOGS";
                                sql = "INSERT INTO tblPatientLogs(strLogID, strPatientID, strStaffID) " +
                                      "VALUES('" + dateToday + "', '" + patientList[0][dgvSearch.CurrentRow.Index] + "', " +
                                      "'" + userID + "');";
                                cmd = new MySqlCommand(sql, conn);
                                cmd.ExecuteNonQuery();

                                sql = "INSERT INTO tblPatientLogDetails(strLogID, dtmDateTimeLog, strLogPurposeCode, strLogType) " +
                                        "VALUES('" + dateToday + "', NOW(), '" + logType + "', 'IN');";
                                cmd = new MySqlCommand(sql, conn);
                                cmd.ExecuteNonQuery();

                                switch (cboIndex)
                                {
                                    case 1:
                                        formQueue.AddQueue(patientList[0][dgvSearch.CurrentRow.Index], 1);
                                        break;
                                    case 2:
                                        formQueue.AddQueue(patientList[0][dgvSearch.CurrentRow.Index], 1);
                                        break;
                                }

                                MessageBox.Show("Successfully logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                lblPatientID.Text = "Scanning";

                                eDesktopAlertColor color = eDesktopAlertColor.Green;
                                eAlertPosition position = eAlertPosition.BottomRight;
                                string report = "Patient # <b>" + patientList[0][dgvSearch.CurrentRow.Index] + "</b><br />" +
                                                "has logged!";
                                DesktopAlert.Show(report,
                                            "\uf005",
                                            eSymbolSet.Awesome,
                                            Color.Blue,
                                            color,
                                            position,
                                            6,
                                            _RunningAlertId,
                                            AlertClicked);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No matching data found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException me)
                {
                    Integrity.GetExceptionDetails(me);
                    videoTimer.Start();
                    videoTimer.Enabled = true;
                }
            }
        }

        private void AlertClicked(long alertID)
        {

        }

        private void btnCloseCamera_Click(object sender, EventArgs e)
        {
            CloseCam();
        }

        private void btnStartCam_Click(object sender, EventArgs e)
        {
            finalFrame.Stop();
            videoTimer.Enabled = false;
            videoTimer.Stop();

            finalFrame = new VideoCaptureDevice(captureDevice[cboCapture.SelectedIndex].MonikerString);
            finalFrame.NewFrame += new NewFrameEventHandler(finalFrameEvent);
            finalFrame.Start();

            videoTimer.Enabled = true;
            videoTimer.Start();
        }

        private void finalFrameEvent(Object sender, NewFrameEventArgs nfea)
        {
            try
            {
                ResizeBicubic filter = new ResizeBicubic(pboReader.Width, pboReader.Height);
                pboReader.Image = filter.Apply((Bitmap)nfea.Frame.Clone());
            }
            catch (Exception ex)
            {
                Integrity.GetExceptionDetails(ex);
                this.CloseCam();
            }
        }

        private void CtrlLogs_Load(object sender, EventArgs e)
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in captureDevice)
            {
                cboCapture.Items.Add(device.Name);
            }
            cboCapture.SelectedIndex = 0;
            finalFrame = new VideoCaptureDevice();
        }

        private void CtrlLogs_Validated(object sender, EventArgs e)
        {

        }

        private void videoTimer_Tick(object sender, EventArgs e)
        {
            BarcodeReader bReader = new BarcodeReader();
            Result result = null;

            try
            {

                if (pboReader.Image == null)
                {

                }
                else
                {
                    result = bReader.Decode(new Bitmap(pboReader.Image));
                    string decoded = result.ToString().Trim();

                    if (decoded == string.Empty)
                    {
                        MessageBox.Show("Empty String");
                    }
                    else
                    {
                        videoTimer.Stop();
                        videoTimer.Enabled = false;

                        // proceed to log in
                        try
                        {
                            string sql = "SELECT * " +
                                        "FROM tblPatient " +
                                        "WHERE strPatientID = '" + decoded + "' AND " +
                                        "boolIsActive;";
                            int resultCounter = 0;
                            MessageBox.Show(sql);
                            MySqlCommand cmd = new MySqlCommand(sql, conn);
                            MySqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                resultCounter++;
                            }

                            reader.Close();

                            if (resultCounter >= 1)
                            {
                                string logID = "";
                                lblPatID.Text = decoded;

                                resultCounter = 0;
                                sql = "SELECT a.strLogID " +
                                        "FROM tblPatientLogs a, tblPatientLogDetails b " +
                                        "WHERE a.strPatientID = '" + decoded + "' AND a.strLogID = b.strLogID AND " +
                                        "b.dtmDateTimeOut IS NULL ORDER BY b.dtmDateTimeLog ASC LIMIT 1;";
                                cmd = new MySqlCommand(sql, conn);
                                cmd.Prepare();
                                try
                                {
                                    reader = cmd.ExecuteReader();
                                }
                                catch (MySqlException me)
                                {
                                    Integrity.GetExceptionDetails(me);
                                }

                                while (reader.Read())
                                {
                                    logID = reader.GetString("strLogID");
                                    resultCounter++;
                                }

                                reader.Close();

                                if (resultCounter == 1)
                                {
                                    sql = "UPDATE tblPatientLogDetails " +
                                            "SET dtmDateTimeOut = NOW(), " +
                                                "strLogType = 'OUT' " +
                                            "WHERE strLogID = '" + logID + "';";
                                    cmd = new MySqlCommand(sql, conn);
                                    cmd.ExecuteNonQuery();

                                    sql = "SELECT strQueueNumber " +
                                          "FROM tblQueue " +
                                          "WHERE strPatientID = '" + decoded + "' AND " +
                                                "strQueueStatus = 'WAITING';";
                                    cmd = new MySqlCommand(sql, conn);
                                    reader = cmd.ExecuteReader();
                                    int resCount = 0;
                                    string queueNumber = "";

                                    while (reader.Read())
                                    {
                                        queueNumber = reader.GetString("strQueueNumber");
                                        resCount++;
                                    }

                                    reader.Close();

                                    if (resCount > 0)
                                    {
                                        sql = "UPDATE tblQueue " +
                                              "SET strQueueStatus = 'CANCELLED' " +
                                              "WHERE strQueueNumber = '" + queueNumber + "';";
                                        cmd = new MySqlCommand(sql, conn);
                                        cmd.ExecuteNonQuery();
                                    }

                                    MessageBox.Show("Successfully logged out!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                    videoTimer.Start();
                                    videoTimer.Enabled = true;
                                }
                                else
                                {
                                    bool valid = true;
                                    int cboIndex = 0;
                                    string logType = "";
                                    DialogResult dr = ExternalForm.InputComboBox(ref cboIndex, ref logType);

                                    if (dr == DialogResult.OK)
                                    {
                                        if (cboIndex >= 5)
                                        {
                                            MessageBox.Show("Please select a valid log type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            valid = false;

                                            videoTimer.Start();
                                            videoTimer.Enabled = true;
                                        }
                                        else
                                        {
                                            switch (cboIndex)
                                            {
                                                case 1:
                                                    logType = "APPT";
                                                    break;
                                                case 2:
                                                    logType = "WALK";
                                                    break;
                                                case 3:
                                                    logType = "EMER";
                                                    break;
                                                case 4:
                                                    logType = "OTHER";
                                                    break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        valid = false;
                                    }

                                    if (valid)
                                    {
                                        string dateToday = TimeHandler.GetCurrentDateTime() + "-LOGS";
                                        sql = "INSERT INTO tblPatientLogs(strLogID, strPatientID, strStaffID) " +
                                                            "VALUES('" + dateToday + "', '" + decoded + "', '" + userID + "');";
                                        cmd = new MySqlCommand(sql, conn);
                                        cmd.ExecuteNonQuery();

                                        sql = "INSERT INTO tblPatientLogDetails(strLogID, dtmDateTimeLog, strLogPurposeCode, strLogType) " +
                                                "VALUES('" + dateToday + "', NOW(), '" + logType + "', 'IN');";
                                        cmd = new MySqlCommand(sql, conn);
                                        cmd.ExecuteNonQuery();

                                        switch (cboIndex)
                                        {
                                            case 1:
                                                formQueue.AddQueue(patientList[dgvSearch.CurrentRow.Index][0], 1);
                                                break;
                                            case 2:
                                                formQueue.AddQueue(patientList[dgvSearch.CurrentRow.Index][0], 1);
                                                break;
                                        }

                                        MessageBox.Show("Successfully logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        lblPatID.Text = "Scanning";
                                        videoTimer.Start();
                                        videoTimer.Enabled = true;

                                        eDesktopAlertColor color = eDesktopAlertColor.Green;
                                        eAlertPosition position = eAlertPosition.BottomRight;
                                        string report = "Patient # <b>" + decoded + "</b><br />" +
                                                        "has logged!";
                                        DesktopAlert.Show(report,
                                                    "\uf005",
                                                    eSymbolSet.Awesome,
                                                    Color.Blue,
                                                    color,
                                                    position,
                                                    6,
                                                    _RunningAlertId,
                                                    AlertClicked);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("QR Code not recognized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                videoTimer.Start();
                                videoTimer.Enabled = true;
                            }
                        }
                        catch (MySqlException me)
                        {
                            MessageBox.Show("Exception Caught!\n" + me.Message);
                            videoTimer.Start();
                            videoTimer.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //vdeoTimer.Stop();
            }
        }

        public void CloseCam()
        {
            finalFrame.Stop();
            pboReader.Image = null;
            videoTimer.Enabled = false;
        }

        private void btnAdvSearch_Click(object sender, EventArgs e)
        {
            FormAdvancedSearch search = new FormAdvancedSearch(formStaff, this, conn, userID);
            search.ShowDialog();
            //formStaff.Visible = false;
        }

        public void UpdateListSearch(string sql)
        {
            dgvSearch.Rows.Clear();
            this.ClearPatientList();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            int resultCounter = 0;

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
                                   reader.GetString("strGender"),
                                   reader.GetString("strPatientContactNumber"));

                resultCounter++;
            }

            reader.Close();

            if (resultCounter == 0)
            {
                MessageBox.Show("Search done! No Results Found!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Search done! \n There are " + resultCounter + "matches!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dgvSearch_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearch.Rows.Count >= 1)
            {
                FormViewPat viewPat = new FormViewPat(conn, patientList[0][dgvSearch.CurrentRow.Index], userID);
                viewPat.Show();
            }
        }

        public void SetWindowVisible(int changer)
        {
            this.windowVisible = changer;

            if (changer == 1)
            {
                pnlLogInput.Visible = true;
                pnlQR.Visible = false;
            }
            else
            {
                pnlLogInput.Visible = false;
                pnlQR.Visible = true;
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            Integrity.TextChange_Name(sender);
        }

    }
}
