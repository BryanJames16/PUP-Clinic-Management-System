namespace ClinicManagementSystem
{
    partial class FormViewDoct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewDoct));
            this.pnlHeader = new MetroFramework.Controls.MetroPanel();
            this.pnlProfile = new MetroFramework.Controls.MetroPanel();
            this.lblFirstName = new MetroFramework.Controls.MetroLabel();
            this.pboIcon = new System.Windows.Forms.PictureBox();
            this.lblUserType = new MetroFramework.Controls.MetroLabel();
            this.lblUserID = new MetroFramework.Controls.MetroLabel();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.lblDrName = new MetroFramework.Controls.MetroLabel();
            this.pnlInfo = new MetroFramework.Controls.MetroPanel();
            this.lblPositionVal = new MetroFramework.Controls.MetroLabel();
            this.lblPosition = new MetroFramework.Controls.MetroLabel();
            this.lblUsernameVal = new MetroFramework.Controls.MetroLabel();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblContactVal = new MetroFramework.Controls.MetroLabel();
            this.lblContact = new MetroFramework.Controls.MetroLabel();
            this.lblGenderVal = new MetroFramework.Controls.MetroLabel();
            this.lblGender = new MetroFramework.Controls.MetroLabel();
            this.lblIDVal = new MetroFramework.Controls.MetroLabel();
            this.lblDocID = new MetroFramework.Controls.MetroLabel();
            this.lblNameVal = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroTile();
            this.pnlHeader.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.pnlInfo.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(637, 120);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.UseCustomBackColor = true;
            this.pnlHeader.VerticalScrollbarBarColor = true;
            this.pnlHeader.VerticalScrollbarHighlightOnWheel = false;
            this.pnlHeader.VerticalScrollbarSize = 10;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseUp);
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlProfile.Controls.Add(this.lblFirstName);
            this.pnlProfile.Controls.Add(this.pboIcon);
            this.pnlProfile.Controls.Add(this.lblUserType);
            this.pnlProfile.Controls.Add(this.lblUserID);
            this.pnlProfile.Controls.Add(this.lblLastName);
            this.pnlProfile.HorizontalScrollbarBarColor = true;
            this.pnlProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProfile.HorizontalScrollbarSize = 10;
            this.pnlProfile.Location = new System.Drawing.Point(336, 0);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(282, 108);
            this.pnlProfile.TabIndex = 3;
            this.pnlProfile.UseCustomBackColor = true;
            this.pnlProfile.VerticalScrollbarBarColor = true;
            this.pnlProfile.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProfile.VerticalScrollbarSize = 10;
            this.pnlProfile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseDown);
            this.pnlProfile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseMove);
            this.pnlProfile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseUp);
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
            // pboIcon
            // 
            this.pboIcon.Image = ((System.Drawing.Image)(resources.GetObject("pboIcon.Image")));
            this.pboIcon.Location = new System.Drawing.Point(162, 0);
            this.pboIcon.Name = "pboIcon";
            this.pboIcon.Size = new System.Drawing.Size(94, 91);
            this.pboIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboIcon.TabIndex = 5;
            this.pboIcon.TabStop = false;
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
            this.pboLogo.Location = new System.Drawing.Point(5, 5);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(168, 108);
            this.pboLogo.TabIndex = 2;
            this.pboLogo.TabStop = false;
            this.pboLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseDown);
            this.pboLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseMove);
            this.pboLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseUp);
            // 
            // lblDrName
            // 
            this.lblDrName.AutoSize = true;
            this.lblDrName.Location = new System.Drawing.Point(62, 85);
            this.lblDrName.Name = "lblDrName";
            this.lblDrName.Size = new System.Drawing.Size(100, 19);
            this.lblDrName.TabIndex = 3;
            this.lblDrName.Text = "Doctor\'s Name:";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblPositionVal);
            this.pnlInfo.Controls.Add(this.lblPosition);
            this.pnlInfo.Controls.Add(this.lblUsernameVal);
            this.pnlInfo.Controls.Add(this.lblUsername);
            this.pnlInfo.Controls.Add(this.lblContactVal);
            this.pnlInfo.Controls.Add(this.lblContact);
            this.pnlInfo.Controls.Add(this.lblGenderVal);
            this.pnlInfo.Controls.Add(this.lblGender);
            this.pnlInfo.Controls.Add(this.lblIDVal);
            this.pnlInfo.Controls.Add(this.lblDocID);
            this.pnlInfo.Controls.Add(this.lblNameVal);
            this.pnlInfo.Controls.Add(this.lblDrName);
            this.pnlInfo.HorizontalScrollbarBarColor = true;
            this.pnlInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlInfo.HorizontalScrollbarSize = 10;
            this.pnlInfo.Location = new System.Drawing.Point(25, 144);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(593, 322);
            this.pnlInfo.TabIndex = 4;
            this.pnlInfo.VerticalScrollbarBarColor = true;
            this.pnlInfo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlInfo.VerticalScrollbarSize = 10;
            this.pnlInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseDown);
            this.pnlInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseMove);
            this.pnlInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseUp);
            // 
            // lblPositionVal
            // 
            this.lblPositionVal.AutoSize = true;
            this.lblPositionVal.Location = new System.Drawing.Point(210, 259);
            this.lblPositionVal.Name = "lblPositionVal";
            this.lblPositionVal.Size = new System.Drawing.Size(40, 19);
            this.lblPositionVal.TabIndex = 14;
            this.lblPositionVal.Text = "NULL";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(62, 260);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 19);
            this.lblPosition.TabIndex = 13;
            this.lblPosition.Text = "Position:";
            // 
            // lblUsernameVal
            // 
            this.lblUsernameVal.AutoSize = true;
            this.lblUsernameVal.Location = new System.Drawing.Point(210, 216);
            this.lblUsernameVal.Name = "lblUsernameVal";
            this.lblUsernameVal.Size = new System.Drawing.Size(40, 19);
            this.lblUsernameVal.TabIndex = 12;
            this.lblUsernameVal.Text = "NULL";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(62, 217);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 19);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username:";
            // 
            // lblContactVal
            // 
            this.lblContactVal.AutoSize = true;
            this.lblContactVal.Location = new System.Drawing.Point(210, 169);
            this.lblContactVal.Name = "lblContactVal";
            this.lblContactVal.Size = new System.Drawing.Size(39, 19);
            this.lblContactVal.TabIndex = 10;
            this.lblContactVal.Text = "+639";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(62, 170);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(82, 19);
            this.lblContact.TabIndex = 9;
            this.lblContact.Text = "Contact No.:";
            // 
            // lblGenderVal
            // 
            this.lblGenderVal.AutoSize = true;
            this.lblGenderVal.Location = new System.Drawing.Point(210, 123);
            this.lblGenderVal.Name = "lblGenderVal";
            this.lblGenderVal.Size = new System.Drawing.Size(40, 19);
            this.lblGenderVal.TabIndex = 8;
            this.lblGenderVal.Text = "NULL";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(62, 124);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(55, 19);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender:";
            // 
            // lblIDVal
            // 
            this.lblIDVal.AutoSize = true;
            this.lblIDVal.Location = new System.Drawing.Point(210, 41);
            this.lblIDVal.Name = "lblIDVal";
            this.lblIDVal.Size = new System.Drawing.Size(40, 19);
            this.lblIDVal.TabIndex = 6;
            this.lblIDVal.Text = "NULL";
            // 
            // lblDocID
            // 
            this.lblDocID.AutoSize = true;
            this.lblDocID.Location = new System.Drawing.Point(62, 41);
            this.lblDocID.Name = "lblDocID";
            this.lblDocID.Size = new System.Drawing.Size(76, 19);
            this.lblDocID.TabIndex = 5;
            this.lblDocID.Text = "Doctor\'s ID:";
            // 
            // lblNameVal
            // 
            this.lblNameVal.AutoSize = true;
            this.lblNameVal.Location = new System.Drawing.Point(210, 84);
            this.lblNameVal.Name = "lblNameVal";
            this.lblNameVal.Size = new System.Drawing.Size(40, 19);
            this.lblNameVal.TabIndex = 4;
            this.lblNameVal.Text = "NULL";
            // 
            // btnBack
            // 
            this.btnBack.ActiveControl = null;
            this.btnBack.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBack.Location = new System.Drawing.Point(271, 482);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 37);
            this.btnBack.TabIndex = 5;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.TileImage = ((System.Drawing.Image)(resources.GetObject("btnBack.TileImage")));
            this.btnBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.UseTileImage = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormViewDoct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(646, 531);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewDoct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUP CMS";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormViewDoct_MouseUp);
            this.pnlHeader.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlHeader;
        private MetroFramework.Controls.MetroPanel pnlProfile;
        private MetroFramework.Controls.MetroLabel lblFirstName;
        private System.Windows.Forms.PictureBox pboIcon;
        private MetroFramework.Controls.MetroLabel lblUserType;
        private MetroFramework.Controls.MetroLabel lblUserID;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private System.Windows.Forms.PictureBox pboLogo;
        private MetroFramework.Controls.MetroLabel lblDrName;
        private MetroFramework.Controls.MetroPanel pnlInfo;
        private MetroFramework.Controls.MetroLabel lblNameVal;
        private MetroFramework.Controls.MetroLabel lblDocID;
        private MetroFramework.Controls.MetroLabel lblIDVal;
        private MetroFramework.Controls.MetroLabel lblContactVal;
        private MetroFramework.Controls.MetroLabel lblContact;
        private MetroFramework.Controls.MetroLabel lblGenderVal;
        private MetroFramework.Controls.MetroLabel lblGender;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblUsernameVal;
        private MetroFramework.Controls.MetroLabel lblPositionVal;
        private MetroFramework.Controls.MetroLabel lblPosition;
        private MetroFramework.Controls.MetroTile btnBack;
    }
}