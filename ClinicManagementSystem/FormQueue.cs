using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace ClinicManagementSystem
{
    public partial class FormQueue : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        Queue<string> patientID = new Queue<string>();
        private System.Windows.Forms.Timer updateQueue = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer updateTagged = new System.Windows.Forms.Timer();

        private MySqlConnection conn = null;

        private long _RunningAlertId = 0;

        public FormQueue(MySqlConnection conn)
        {
            InitializeComponent();

            this.conn = conn;

            this.updateQueue.Interval = 10000;
            this.updateQueue.Tick += new EventHandler(UpdateQueueThread);
            this.updateQueue.Enabled = true;

            this.updateTagged.Interval = 10000;
            this.updateTagged.Tick += new EventHandler(UpdateTaggedThread);
            this.updateTagged.Enabled = true;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UpdateQueueThread(object sender, EventArgs e)
        {
            dgvQueue.Rows.Clear();
            patientID.Clear();

            try
            {
                string sql = "SELECT b.strQueueNumber, a.strPatientID, a.strIDNumber, a.strPatientLastName, " +
                                    "a.strPatientFirstName, b.strPriority " +
                             "FROM tblPatient a, tblQueue b " +
                             "WHERE b.strPatientID = a.strPatientID AND " +
                                    "b.strQueueStatus = 'WAITING' " +
                             "ORDER BY b.strPriority ASC;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    patientID.Enqueue(reader.GetString("strPatientID"));
                    dgvQueue.Rows.Add(reader.GetString("strQueueNumber"),
                                      reader.GetString("strPatientID"),
                                      reader.GetString("strIDNumber"),
                                      reader.GetString("strPatientLastName"),
                                      reader.GetString("strPatientFirstName"),
                                      reader.GetString("strPriority"));
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

        private void UpdateTaggedThread(object sender, EventArgs e)
        {
            dgvTagged.Rows.Clear();

            Queue<string> doctorString = new Queue<string>();
            int resultCount = 0;

            if (dgvQueue.Rows.Count > 0)
            {
                try
                {
                    string sql = "SELECT DISTINCT strStaffID " +
                                 "FROM tblLogIn " +
                                 "WHERE strDoctStatus = 'ON' AND " +
                                    "strStaffID NOT IN(SELECT strStaffID " +
                                                "FROM tblTag " +
                                                "WHERE strStatus = 'PENDING');";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        doctorString.Enqueue(reader.GetString("strStaffID"));
                        resultCount++;
                    }

                    reader.Close();

                    //MessageBox.Show("BEfore if");
                    if (resultCount != 0 && patientID.Count != 0)
                    {
                        string patientDequeued = patientID.Dequeue();
                        string doctorDequeued = doctorString.Dequeue();

                        string staffID = "";
                        string staffLastName = "";
                        string extPat = "";
                        string patNo = "";
                        string patientLastName = "";
                        string patientFirstName = "";

                        //MessageBox.Show("Entered if");
                        sql = "INSERT INTO tblTag " +
                                "VALUES ('" + patientDequeued + "', '" + doctorDequeued + "', NOW(), 'PENDING');";

                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        sql = "UPDATE tblQueue " +
                                "SET strQueueStatus = 'TAGGED' " +
                                "WHERE strPatientID = '" + patientDequeued + "';";

                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        sql = "UPDATE tblLogIn " +
                                "SET strDoctStatus = 'OFF' " +
                                "WHERE strStaffID = '" + doctorDequeued + "';";

                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        UpdateQueueThread(sender, e);

                        string report = "Patient # <b>";

                        sql = "SELECT strPatientID, strIDNumber, strPatientLastName, strPatientFirstName, strPatientMiddleName " +
                                "FROM tblPatient " +
                                "WHERE strPatientID = '" + patientDequeued + "';";
                        cmd = new MySqlCommand(sql, conn);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            report += reader.GetString("strPatientID");
                            report += "</b><br />";
                            report += reader.GetString("strPatientLastName");
                            report += ", ";
                            report += reader.GetString("strPatientFirstName");
                            report += " ";
                            report += reader.GetString("strPatientMiddleName");

                            extPat = reader.GetString("strPatientID");
                            patNo = reader.GetString("strIDNumber");
                            patientLastName = reader.GetString("strPatientLastName");
                            patientFirstName = reader.GetString("strPatientFirstName");
                        }

                        reader.Close();

                        report += "<br />TAGGED TO<br />";

                        sql = "SELECT strStaffID, strLastName " +
                                "FROM tblStaff " +
                                "WHERE strStaffID = '" + doctorDequeued + "';";
                        cmd = new MySqlCommand(sql, conn);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            report += "DR. <b>" + reader.GetString("strLastName") + "</b>";

                            staffID = reader.GetString("strStaffID");
                            staffLastName = reader.GetString("strLastName");
                        }

                        reader.Close();

                        dgvTagged.Rows.Add(staffID, staffLastName, extPat, patNo, patientLastName, patientFirstName);

                        eDesktopAlertColor color = eDesktopAlertColor.Green;
                        eAlertPosition position = eAlertPosition.BottomRight;
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
                catch (MySqlException me)
                {
                    Integrity.GetExceptionDetails(me);
                }
                catch (Exception ex)
                {
                    Integrity.GetExceptionDetails(ex);
                }

                if (resultCount > 0)
                {

                }
            }
        }

        private void AlertClicked(long alertID)
        {

        }

        private void FormQueue_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateQueue.Stop();
            updateQueue.Enabled = false;

            updateTagged.Stop();
            updateTagged.Enabled = false;
        }

        public void AddQueue(string patientID, int level)
        {
            if (level < 3)
            {
                try
                {
                    string key = TimeHandler.GetCurrentDateTime();
                    string sql = "INSERT INTO tblQueue(strPatientID, strQueueNumber, strQueueStatus, strPriority) " +
                                 "VALUES('" + patientID + "', '" + key + "', 'WAITING', ";

                    if (level == 2)
                    {
                        sql += "'HIGH');";
                    }
                    else
                    {
                        sql += "'NORMAL');";
                    }

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
}
