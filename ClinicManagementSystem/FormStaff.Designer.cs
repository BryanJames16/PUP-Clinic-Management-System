namespace ClinicManagementSystem
{
    partial class FormStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaff));
            this.pnlHeader = new MetroFramework.Controls.MetroPanel();
            this.pnlProfile = new MetroFramework.Controls.MetroPanel();
            this.lblFirstName = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserType = new MetroFramework.Controls.MetroLabel();
            this.lblUserID = new MetroFramework.Controls.MetroLabel();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.pnlButtons = new MetroFramework.Controls.MetroPanel();
            this.btnAppt = new MetroFramework.Controls.MetroTile();
            this.pnlTitle = new MetroFramework.Controls.MetroPanel();
            this.lblAction = new MetroFramework.Controls.MetroLabel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.btnLogOut = new MetroFramework.Controls.MetroTile();
            this.btnReports = new MetroFramework.Controls.MetroTile();
            this.btnPatient = new MetroFramework.Controls.MetroTile();
            this.btnLog = new MetroFramework.Controls.MetroTile();
            this.pnlAppt = new MetroFramework.Controls.MetroPanel();
            this.btnAdd = new MetroFramework.Controls.MetroTile();
            this.btnCheck = new MetroFramework.Controls.MetroTile();
            this.pnlRegistration = new MetroFramework.Controls.MetroPanel();
            this.btnRegistration = new MetroFramework.Controls.MetroTile();
            this.btnViewPat = new MetroFramework.Controls.MetroTile();
            this.pnlLogs = new MetroFramework.Controls.MetroPanel();
            this.btnLogQR = new MetroFramework.Controls.MetroTile();
            this.btnLogInput = new MetroFramework.Controls.MetroTile();
            this.pnlHeader.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlAppt.SuspendLayout();
            this.pnlRegistration.SuspendLayout();
            this.pnlLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.Controls.Add(this.pnlProfile);
            this.pnlHeader.Controls.Add(this.pboLogo);
            this.pnlHeader.HorizontalScrollbarBarColor = true;
            this.pnlHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlHeader.HorizontalScrollbarSize = 10;
            this.pnlHeader.Location = new System.Drawing.Point(4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(866, 136);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.UseCustomBackColor = true;
            this.pnlHeader.VerticalScrollbarBarColor = true;
            this.pnlHeader.VerticalScrollbarHighlightOnWheel = false;
            this.pnlHeader.VerticalScrollbarSize = 10;
            this.pnlHeader.Click += new System.EventHandler(this.pnlHeader_Click);
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseUp);
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlProfile.Controls.Add(this.lblFirstName);
            this.pnlProfile.Controls.Add(this.pictureBox1);
            this.pnlProfile.Controls.Add(this.lblUserType);
            this.pnlProfile.Controls.Add(this.lblUserID);
            this.pnlProfile.Controls.Add(this.lblLastName);
            this.pnlProfile.HorizontalScrollbarBarColor = true;
            this.pnlProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProfile.HorizontalScrollbarSize = 10;
            this.pnlProfile.Location = new System.Drawing.Point(569, 0);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(271, 110);
            this.pnlProfile.TabIndex = 3;
            this.pnlProfile.UseCustomBackColor = true;
            this.pnlProfile.VerticalScrollbarBarColor = true;
            this.pnlProfile.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProfile.VerticalScrollbarSize = 10;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFirstName.Location = new System.Drawing.Point(10, 34);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 19);
            this.lblFirstName.Style = MetroFramework.MetroColorStyle.White;
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.UseCustomBackColor = true;
            this.lblFirstName.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserType.Location = new System.Drawing.Point(10, 72);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(67, 19);
            this.lblUserType.Style = MetroFramework.MetroColorStyle.White;
            this.lblUserType.TabIndex = 4;
            this.lblUserType.Text = "User Type";
            this.lblUserType.UseCustomBackColor = true;
            this.lblUserType.UseStyleColors = true;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserID.Location = new System.Drawing.Point(10, 53);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(51, 19);
            this.lblUserID.Style = MetroFramework.MetroColorStyle.White;
            this.lblUserID.TabIndex = 3;
            this.lblUserID.Text = "User ID";
            this.lblUserID.UseCustomBackColor = true;
            this.lblUserID.UseStyleColors = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLastName.Location = new System.Drawing.Point(9, 9);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(92, 25);
            this.lblLastName.Style = MetroFramework.MetroColorStyle.White;
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.UseCustomBackColor = true;
            this.lblLastName.UseStyleColors = true;
            // 
            // pboLogo
            // 
            this.pboLogo.BackColor = System.Drawing.Color.Transparent;
            this.pboLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboLogo.BackgroundImage")));
            this.pboLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboLogo.Location = new System.Drawing.Point(7, 0);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(167, 119);
            this.pboLogo.TabIndex = 2;
            this.pboLogo.TabStop = false;
            this.pboLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseDown);
            this.pboLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseMove);
            this.pboLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseUp);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlButtons.Controls.Add(this.btnAppt);
            this.pnlButtons.Controls.Add(this.pnlTitle);
            this.pnlButtons.Controls.Add(this.pnlControl);
            this.pnlButtons.Controls.Add(this.lblTime);
            this.pnlButtons.Controls.Add(this.lblDate);
            this.pnlButtons.Controls.Add(this.btnLogOut);
            this.pnlButtons.Controls.Add(this.btnReports);
            this.pnlButtons.Controls.Add(this.btnPatient);
            this.pnlButtons.Controls.Add(this.btnLog);
            this.pnlButtons.Controls.Add(this.pnlAppt);
            this.pnlButtons.Controls.Add(this.pnlRegistration);
            this.pnlButtons.Controls.Add(this.pnlLogs);
            this.pnlButtons.HorizontalScrollbarBarColor = true;
            this.pnlButtons.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlButtons.HorizontalScrollbarSize = 10;
            this.pnlButtons.Location = new System.Drawing.Point(4, 124);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(866, 498);
            this.pnlButtons.TabIndex = 1;
            this.pnlButtons.UseCustomBackColor = true;
            this.pnlButtons.VerticalScrollbarBarColor = true;
            this.pnlButtons.VerticalScrollbarHighlightOnWheel = false;
            this.pnlButtons.VerticalScrollbarSize = 10;
            this.pnlButtons.Click += new System.EventHandler(this.pnlButtons_Click);
            this.pnlButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseDown);
            this.pnlButtons.MouseHover += new System.EventHandler(this.pnlButtons_MouseHover);
            this.pnlButtons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseMove);
            this.pnlButtons.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseUp);
            // 
            // btnAppt
            // 
            this.btnAppt.ActiveControl = null;
            this.btnAppt.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAppt.Location = new System.Drawing.Point(3, 195);
            this.btnAppt.Name = "btnAppt";
            this.btnAppt.Size = new System.Drawing.Size(179, 57);
            this.btnAppt.TabIndex = 5;
            this.btnAppt.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAppt.TileImage")));
            this.btnAppt.UseCustomBackColor = true;
            this.btnAppt.UseSelectable = true;
            this.btnAppt.UseTileImage = true;
            this.btnAppt.Click += new System.EventHandler(this.btnAppt_Click);
            this.btnAppt.MouseEnter += new System.EventHandler(this.btnAppt_MouseEnter);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlTitle.Controls.Add(this.lblAction);
            this.pnlTitle.HorizontalScrollbarBarColor = true;
            this.pnlTitle.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTitle.HorizontalScrollbarSize = 10;
            this.pnlTitle.Location = new System.Drawing.Point(196, 1);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(670, 57);
            this.pnlTitle.TabIndex = 2;
            this.pnlTitle.UseCustomBackColor = true;
            this.pnlTitle.VerticalScrollbarBarColor = true;
            this.pnlTitle.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTitle.VerticalScrollbarSize = 10;
            this.pnlTitle.Click += new System.EventHandler(this.pnlTitle_Click);
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseDown);
            this.pnlTitle.MouseHover += new System.EventHandler(this.pnlTitle_MouseHover);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseMove);
            this.pnlTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseUp);
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAction.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAction.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAction.Location = new System.Drawing.Point(434, 19);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(68, 25);
            this.lblAction.TabIndex = 2;
            this.lblAction.Text = "Action";
            this.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAction.UseCustomBackColor = true;
            this.lblAction.UseCustomForeColor = true;
            // 
            // pnlControl
            // 
            this.pnlControl.AutoScroll = true;
            this.pnlControl.BackColor = System.Drawing.Color.Lavender;
            this.pnlControl.Location = new System.Drawing.Point(196, 58);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(670, 440);
            this.pnlControl.TabIndex = 3;
            this.pnlControl.Click += new System.EventHandler(this.pnlControl_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(37, 461);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(112, 19);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "HH : MM : SS AM";
            this.lblTime.UseCustomBackColor = true;
            this.lblTime.UseCustomForeColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDate.Location = new System.Drawing.Point(37, 433);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(109, 19);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "MM / DD / YYYY";
            this.lblDate.UseCustomBackColor = true;
            this.lblDate.UseCustomForeColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ActiveControl = null;
            this.btnLogOut.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLogOut.Location = new System.Drawing.Point(3, 321);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(179, 57);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.TileImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.TileImage")));
            this.btnLogOut.UseCustomBackColor = true;
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.UseTileImage = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btnLogOut_MouseHover);
            this.btnLogOut.MouseHover += new System.EventHandler(this.btnLogOut_MouseHover);
            // 
            // btnReports
            // 
            this.btnReports.ActiveControl = null;
            this.btnReports.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReports.Location = new System.Drawing.Point(3, 258);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(179, 57);
            this.btnReports.TabIndex = 0;
            this.btnReports.TileImage = ((System.Drawing.Image)(resources.GetObject("btnReports.TileImage")));
            this.btnReports.UseCustomBackColor = true;
            this.btnReports.UseSelectable = true;
            this.btnReports.UseTileImage = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            this.btnReports.MouseHover += new System.EventHandler(this.btnReports_MouseHover);
            // 
            // btnPatient
            // 
            this.btnPatient.ActiveControl = null;
            this.btnPatient.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPatient.Location = new System.Drawing.Point(3, 132);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(179, 57);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.TileImage = ((System.Drawing.Image)(resources.GetObject("btnPatient.TileImage")));
            this.btnPatient.UseCustomBackColor = true;
            this.btnPatient.UseSelectable = true;
            this.btnPatient.UseTileImage = true;
            this.btnPatient.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnPatient.MouseEnter += new System.EventHandler(this.btnPatient_MouseEnter);
            // 
            // btnLog
            // 
            this.btnLog.ActiveControl = null;
            this.btnLog.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLog.Location = new System.Drawing.Point(3, 69);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(179, 57);
            this.btnLog.TabIndex = 0;
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLog.TileImage = ((System.Drawing.Image)(resources.GetObject("btnLog.TileImage")));
            this.btnLog.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.UseCustomBackColor = true;
            this.btnLog.UseSelectable = true;
            this.btnLog.UseTileImage = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            this.btnLog.MouseEnter += new System.EventHandler(this.btnLog_MouseEnter);
            // 
            // pnlAppt
            // 
            this.pnlAppt.BackColor = System.Drawing.Color.DimGray;
            this.pnlAppt.Controls.Add(this.btnAdd);
            this.pnlAppt.Controls.Add(this.btnCheck);
            this.pnlAppt.HorizontalScrollbarBarColor = true;
            this.pnlAppt.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAppt.HorizontalScrollbarSize = 10;
            this.pnlAppt.Location = new System.Drawing.Point(188, 159);
            this.pnlAppt.Name = "pnlAppt";
            this.pnlAppt.Size = new System.Drawing.Size(208, 145);
            this.pnlAppt.TabIndex = 5;
            this.pnlAppt.UseCustomBackColor = true;
            this.pnlAppt.VerticalScrollbarBarColor = true;
            this.pnlAppt.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAppt.VerticalScrollbarSize = 10;
            this.pnlAppt.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveControl = null;
            this.btnAdd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdd.Location = new System.Drawing.Point(15, 75);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 57);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.TileImage")));
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseTileImage = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.ActiveControl = null;
            this.btnCheck.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCheck.Location = new System.Drawing.Point(15, 12);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(179, 57);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.TileImage = ((System.Drawing.Image)(resources.GetObject("btnCheck.TileImage")));
            this.btnCheck.UseCustomBackColor = true;
            this.btnCheck.UseSelectable = true;
            this.btnCheck.UseTileImage = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.BackColor = System.Drawing.Color.DimGray;
            this.pnlRegistration.Controls.Add(this.btnRegistration);
            this.pnlRegistration.Controls.Add(this.btnViewPat);
            this.pnlRegistration.HorizontalScrollbarBarColor = true;
            this.pnlRegistration.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlRegistration.HorizontalScrollbarSize = 10;
            this.pnlRegistration.Location = new System.Drawing.Point(188, 69);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(208, 145);
            this.pnlRegistration.TabIndex = 4;
            this.pnlRegistration.UseCustomBackColor = true;
            this.pnlRegistration.VerticalScrollbarBarColor = true;
            this.pnlRegistration.VerticalScrollbarHighlightOnWheel = false;
            this.pnlRegistration.VerticalScrollbarSize = 10;
            this.pnlRegistration.Visible = false;
            // 
            // btnRegistration
            // 
            this.btnRegistration.ActiveControl = null;
            this.btnRegistration.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRegistration.Location = new System.Drawing.Point(15, 76);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(179, 57);
            this.btnRegistration.TabIndex = 3;
            this.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistration.TileImage = ((System.Drawing.Image)(resources.GetObject("btnRegistration.TileImage")));
            this.btnRegistration.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistration.UseCustomBackColor = true;
            this.btnRegistration.UseSelectable = true;
            this.btnRegistration.UseTileImage = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnViewPat
            // 
            this.btnViewPat.ActiveControl = null;
            this.btnViewPat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnViewPat.Location = new System.Drawing.Point(15, 13);
            this.btnViewPat.Name = "btnViewPat";
            this.btnViewPat.Size = new System.Drawing.Size(179, 57);
            this.btnViewPat.TabIndex = 2;
            this.btnViewPat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewPat.TileImage = ((System.Drawing.Image)(resources.GetObject("btnViewPat.TileImage")));
            this.btnViewPat.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewPat.UseCustomBackColor = true;
            this.btnViewPat.UseSelectable = true;
            this.btnViewPat.UseTileImage = true;
            this.btnViewPat.Click += new System.EventHandler(this.btnViewPat_Click);
            // 
            // pnlLogs
            // 
            this.pnlLogs.BackColor = System.Drawing.Color.DimGray;
            this.pnlLogs.Controls.Add(this.btnLogQR);
            this.pnlLogs.Controls.Add(this.btnLogInput);
            this.pnlLogs.HorizontalScrollbarBarColor = true;
            this.pnlLogs.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlLogs.HorizontalScrollbarSize = 10;
            this.pnlLogs.Location = new System.Drawing.Point(188, 20);
            this.pnlLogs.Name = "pnlLogs";
            this.pnlLogs.Size = new System.Drawing.Size(208, 145);
            this.pnlLogs.TabIndex = 2;
            this.pnlLogs.UseCustomBackColor = true;
            this.pnlLogs.VerticalScrollbarBarColor = true;
            this.pnlLogs.VerticalScrollbarHighlightOnWheel = false;
            this.pnlLogs.VerticalScrollbarSize = 10;
            this.pnlLogs.Visible = false;
            // 
            // btnLogQR
            // 
            this.btnLogQR.ActiveControl = null;
            this.btnLogQR.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLogQR.Location = new System.Drawing.Point(15, 76);
            this.btnLogQR.Name = "btnLogQR";
            this.btnLogQR.Size = new System.Drawing.Size(179, 57);
            this.btnLogQR.TabIndex = 3;
            this.btnLogQR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogQR.TileImage = ((System.Drawing.Image)(resources.GetObject("btnLogQR.TileImage")));
            this.btnLogQR.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogQR.UseCustomBackColor = true;
            this.btnLogQR.UseSelectable = true;
            this.btnLogQR.UseTileImage = true;
            this.btnLogQR.Click += new System.EventHandler(this.btnLogQR_Click);
            // 
            // btnLogInput
            // 
            this.btnLogInput.ActiveControl = null;
            this.btnLogInput.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLogInput.Location = new System.Drawing.Point(15, 13);
            this.btnLogInput.Name = "btnLogInput";
            this.btnLogInput.Size = new System.Drawing.Size(179, 57);
            this.btnLogInput.TabIndex = 2;
            this.btnLogInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogInput.TileImage = ((System.Drawing.Image)(resources.GetObject("btnLogInput.TileImage")));
            this.btnLogInput.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogInput.UseCustomBackColor = true;
            this.btnLogInput.UseSelectable = true;
            this.btnLogInput.UseTileImage = true;
            this.btnLogInput.Click += new System.EventHandler(this.btnLogInput_Click);
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(874, 626);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStaff";
            this.Shown += new System.EventHandler(this.FormStaff_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormStaff_MouseUp);
            this.pnlHeader.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlAppt.ResumeLayout(false);
            this.pnlRegistration.ResumeLayout(false);
            this.pnlLogs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlHeader;
        private System.Windows.Forms.PictureBox pboLogo;
        private MetroFramework.Controls.MetroPanel pnlProfile;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private MetroFramework.Controls.MetroLabel lblUserID;
        private MetroFramework.Controls.MetroLabel lblUserType;
        private MetroFramework.Controls.MetroPanel pnlButtons;
        private MetroFramework.Controls.MetroPanel pnlTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblFirstName;
        private MetroFramework.Controls.MetroLabel lblAction;
        private MetroFramework.Controls.MetroLabel lblTime;
        private MetroFramework.Controls.MetroLabel lblDate;
        private System.Windows.Forms.Panel pnlControl;
        private MetroFramework.Controls.MetroTile btnLog;
        private MetroFramework.Controls.MetroTile btnPatient;
        private MetroFramework.Controls.MetroTile btnLogOut;
        private MetroFramework.Controls.MetroTile btnReports;
        private MetroFramework.Controls.MetroPanel pnlLogs;
        private MetroFramework.Controls.MetroTile btnLogQR;
        private MetroFramework.Controls.MetroTile btnLogInput;
        private MetroFramework.Controls.MetroPanel pnlRegistration;
        private MetroFramework.Controls.MetroTile btnRegistration;
        private MetroFramework.Controls.MetroTile btnViewPat;
        private MetroFramework.Controls.MetroPanel pnlAppt;
        private MetroFramework.Controls.MetroTile btnAppt;
        private MetroFramework.Controls.MetroTile btnAdd;
        private MetroFramework.Controls.MetroTile btnCheck;
    }
}