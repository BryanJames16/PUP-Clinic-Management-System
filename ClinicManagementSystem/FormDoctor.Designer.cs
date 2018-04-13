namespace ClinicManagementSystem
{
    partial class FormDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctor));
            this.pnlHeader = new MetroFramework.Controls.MetroPanel();
            this.toggleStatus = new MetroFramework.Controls.MetroToggle();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.pnlProfile = new MetroFramework.Controls.MetroPanel();
            this.lblFirstName = new MetroFramework.Controls.MetroLabel();
            this.pboImage = new System.Windows.Forms.PictureBox();
            this.lblUserType = new MetroFramework.Controls.MetroLabel();
            this.lblUserID = new MetroFramework.Controls.MetroLabel();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.pnlNavBar = new MetroFramework.Controls.MetroPanel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.btnViewTags = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlTitle = new MetroFramework.Controls.MetroPanel();
            this.lblStat = new MetroFramework.Controls.MetroLabel();
            this.pnlCatcher = new MetroFramework.Controls.MetroPanel();
            this.pnlHeader.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.pnlNavBar.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.Controls.Add(this.toggleStatus);
            this.pnlHeader.Controls.Add(this.lblStatus);
            this.pnlHeader.Controls.Add(this.pnlProfile);
            this.pnlHeader.Controls.Add(this.pboLogo);
            this.pnlHeader.HorizontalScrollbarBarColor = true;
            this.pnlHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlHeader.HorizontalScrollbarSize = 10;
            this.pnlHeader.Location = new System.Drawing.Point(4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(866, 125);
            this.pnlHeader.TabIndex = 5;
            this.pnlHeader.UseCustomBackColor = true;
            this.pnlHeader.VerticalScrollbarBarColor = true;
            this.pnlHeader.VerticalScrollbarHighlightOnWheel = false;
            this.pnlHeader.VerticalScrollbarSize = 10;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseUp);
            // 
            // toggleStatus
            // 
            this.toggleStatus.AutoSize = true;
            this.toggleStatus.Location = new System.Drawing.Point(683, 98);
            this.toggleStatus.Name = "toggleStatus";
            this.toggleStatus.Size = new System.Drawing.Size(80, 17);
            this.toggleStatus.TabIndex = 0;
            this.toggleStatus.Text = "Off";
            this.toggleStatus.UseSelectable = true;
            this.toggleStatus.CheckedChanged += new System.EventHandler(this.toggleStatus_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(606, 98);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 25);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "STATUS";
            this.lblStatus.UseCustomBackColor = true;
            this.lblStatus.UseCustomForeColor = true;
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlProfile.Controls.Add(this.lblFirstName);
            this.pnlProfile.Controls.Add(this.pboImage);
            this.pnlProfile.Controls.Add(this.lblUserType);
            this.pnlProfile.Controls.Add(this.lblUserID);
            this.pnlProfile.Controls.Add(this.lblLastName);
            this.pnlProfile.HorizontalScrollbarBarColor = true;
            this.pnlProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProfile.HorizontalScrollbarSize = 10;
            this.pnlProfile.Location = new System.Drawing.Point(565, 0);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(259, 96);
            this.pnlProfile.TabIndex = 3;
            this.pnlProfile.UseCustomBackColor = true;
            this.pnlProfile.VerticalScrollbarBarColor = true;
            this.pnlProfile.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProfile.VerticalScrollbarSize = 10;
            this.pnlProfile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseDown);
            this.pnlProfile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseMove);
            this.pnlProfile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseUp);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(10, 34);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 19);
            this.lblFirstName.Style = MetroFramework.MetroColorStyle.White;
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.UseCustomBackColor = true;
            this.lblFirstName.UseCustomForeColor = true;
            this.lblFirstName.UseStyleColors = true;
            // 
            // pboImage
            // 
            this.pboImage.Image = ((System.Drawing.Image)(resources.GetObject("pboImage.Image")));
            this.pboImage.Location = new System.Drawing.Point(161, 0);
            this.pboImage.Name = "pboImage";
            this.pboImage.Size = new System.Drawing.Size(98, 96);
            this.pboImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboImage.TabIndex = 5;
            this.pboImage.TabStop = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.ForeColor = System.Drawing.Color.White;
            this.lblUserType.Location = new System.Drawing.Point(10, 72);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(67, 19);
            this.lblUserType.Style = MetroFramework.MetroColorStyle.White;
            this.lblUserType.TabIndex = 4;
            this.lblUserType.Text = "User Type";
            this.lblUserType.UseCustomBackColor = true;
            this.lblUserType.UseCustomForeColor = true;
            this.lblUserType.UseStyleColors = true;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(10, 53);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(51, 19);
            this.lblUserID.Style = MetroFramework.MetroColorStyle.White;
            this.lblUserID.TabIndex = 3;
            this.lblUserID.Text = "User ID";
            this.lblUserID.UseCustomBackColor = true;
            this.lblUserID.UseCustomForeColor = true;
            this.lblUserID.UseStyleColors = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(10, 9);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(92, 25);
            this.lblLastName.Style = MetroFramework.MetroColorStyle.White;
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.UseCustomBackColor = true;
            this.lblLastName.UseCustomForeColor = true;
            this.lblLastName.UseStyleColors = true;
            // 
            // pboLogo
            // 
            this.pboLogo.BackColor = System.Drawing.Color.Transparent;
            this.pboLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboLogo.BackgroundImage")));
            this.pboLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboLogo.Location = new System.Drawing.Point(3, 3);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(153, 114);
            this.pboLogo.TabIndex = 2;
            this.pboLogo.TabStop = false;
            this.pboLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseDown);
            this.pboLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseMove);
            this.pboLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseUp);
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlNavBar.Controls.Add(this.lblTime);
            this.pnlNavBar.Controls.Add(this.lblDate);
            this.pnlNavBar.Controls.Add(this.btnViewTags);
            this.pnlNavBar.Controls.Add(this.btnView);
            this.pnlNavBar.Controls.Add(this.btnLogOut);
            this.pnlNavBar.Controls.Add(this.btnReports);
            this.pnlNavBar.HorizontalScrollbarBarColor = true;
            this.pnlNavBar.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlNavBar.HorizontalScrollbarSize = 10;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 124);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(200, 502);
            this.pnlNavBar.TabIndex = 6;
            this.pnlNavBar.UseCustomBackColor = true;
            this.pnlNavBar.VerticalScrollbarBarColor = true;
            this.pnlNavBar.VerticalScrollbarHighlightOnWheel = false;
            this.pnlNavBar.VerticalScrollbarSize = 10;
            this.pnlNavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseDown);
            this.pnlNavBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseMove);
            this.pnlNavBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseUp);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(37, 459);
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
            this.lblDate.Location = new System.Drawing.Point(37, 431);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(109, 19);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "MM / DD / YYYY";
            this.lblDate.UseCustomBackColor = true;
            this.lblDate.UseCustomForeColor = true;
            // 
            // btnViewTags
            // 
            this.btnViewTags.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnViewTags.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewTags.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTags.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTags.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewTags.Image = ((System.Drawing.Image)(resources.GetObject("btnViewTags.Image")));
            this.btnViewTags.Location = new System.Drawing.Point(8, 166);
            this.btnViewTags.Name = "btnViewTags";
            this.btnViewTags.Size = new System.Drawing.Size(181, 61);
            this.btnViewTags.TabIndex = 14;
            this.btnViewTags.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewTags.UseVisualStyleBackColor = false;
            this.btnViewTags.Click += new System.EventHandler(this.btnViewTags_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.Control;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(8, 99);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(181, 61);
            this.btnView.TabIndex = 11;
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(8, 303);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(181, 61);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.Location = new System.Drawing.Point(8, 233);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(181, 61);
            this.btnReports.TabIndex = 12;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlTitle.Controls.Add(this.lblStat);
            this.pnlTitle.HorizontalScrollbarBarColor = true;
            this.pnlTitle.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTitle.HorizontalScrollbarSize = 10;
            this.pnlTitle.Location = new System.Drawing.Point(199, 124);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(671, 54);
            this.pnlTitle.TabIndex = 7;
            this.pnlTitle.UseCustomBackColor = true;
            this.pnlTitle.VerticalScrollbarBarColor = true;
            this.pnlTitle.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTitle.VerticalScrollbarSize = 10;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseDown);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseMove);
            this.pnlTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseUp);
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblStat.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStat.ForeColor = System.Drawing.Color.White;
            this.lblStat.Location = new System.Drawing.Point(405, 14);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(80, 25);
            this.lblStat.TabIndex = 2;
            this.lblStat.Text = "STATUS";
            this.lblStat.UseCustomBackColor = true;
            this.lblStat.UseCustomForeColor = true;
            // 
            // pnlCatcher
            // 
            this.pnlCatcher.BackColor = System.Drawing.Color.Lavender;
            this.pnlCatcher.HorizontalScrollbarBarColor = true;
            this.pnlCatcher.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCatcher.HorizontalScrollbarSize = 10;
            this.pnlCatcher.Location = new System.Drawing.Point(199, 176);
            this.pnlCatcher.Name = "pnlCatcher";
            this.pnlCatcher.Size = new System.Drawing.Size(671, 447);
            this.pnlCatcher.TabIndex = 8;
            this.pnlCatcher.UseCustomBackColor = true;
            this.pnlCatcher.VerticalScrollbarBarColor = true;
            this.pnlCatcher.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCatcher.VerticalScrollbarSize = 10;
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(874, 626);
            this.Controls.Add(this.pnlCatcher);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlNavBar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoctor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDoctor_FormClosing);
            this.Shown += new System.EventHandler(this.FormDoctor_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormDoctor_MouseUp);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlHeader;
        private MetroFramework.Controls.MetroToggle toggleStatus;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroPanel pnlProfile;
        private MetroFramework.Controls.MetroLabel lblFirstName;
        private System.Windows.Forms.PictureBox pboImage;
        private MetroFramework.Controls.MetroLabel lblUserType;
        private MetroFramework.Controls.MetroLabel lblUserID;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private System.Windows.Forms.PictureBox pboLogo;
        private MetroFramework.Controls.MetroPanel pnlNavBar;
        private System.Windows.Forms.Button btnViewTags;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnReports;
        private MetroFramework.Controls.MetroLabel lblTime;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroPanel pnlTitle;
        private MetroFramework.Controls.MetroLabel lblStat;
        private MetroFramework.Controls.MetroPanel pnlCatcher;
    }
}