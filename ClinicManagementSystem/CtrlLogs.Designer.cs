namespace ClinicManagementSystem
{
    partial class CtrlLogs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlLogs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLogInput = new MetroFramework.Controls.MetroPanel();
            this.btnClear = new MetroFramework.Controls.MetroTile();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.dgvSearch = new MetroFramework.Controls.MetroGrid();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textName = new MetroFramework.Controls.MetroTextBox();
            this.lblSearchName = new MetroFramework.Controls.MetroLabel();
            this.btnAdvSearch = new MetroFramework.Controls.MetroTile();
            this.lblSearch = new MetroFramework.Controls.MetroLabel();
            this.pnlQR = new MetroFramework.Controls.MetroPanel();
            this.gboQR = new System.Windows.Forms.GroupBox();
            this.lblPatID = new MetroFramework.Controls.MetroLabel();
            this.lblPatientID = new MetroFramework.Controls.MetroLabel();
            this.btnCloseCamera = new System.Windows.Forms.Button();
            this.btnStartCam = new System.Windows.Forms.Button();
            this.cboCapture = new MetroFramework.Controls.MetroComboBox();
            this.lblScanFeed = new MetroFramework.Controls.MetroLabel();
            this.pboReader = new System.Windows.Forms.PictureBox();
            this.lblSearchQR = new MetroFramework.Controls.MetroLabel();
            this.videoTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlLogInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.pnlQR.SuspendLayout();
            this.gboQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboReader)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogInput
            // 
            this.pnlLogInput.Controls.Add(this.btnClear);
            this.pnlLogInput.Controls.Add(this.btnSearch);
            this.pnlLogInput.Controls.Add(this.btnReset);
            this.pnlLogInput.Controls.Add(this.btnLog);
            this.pnlLogInput.Controls.Add(this.dgvSearch);
            this.pnlLogInput.Controls.Add(this.textName);
            this.pnlLogInput.Controls.Add(this.lblSearchName);
            this.pnlLogInput.Controls.Add(this.btnAdvSearch);
            this.pnlLogInput.Controls.Add(this.lblSearch);
            this.pnlLogInput.HorizontalScrollbarBarColor = true;
            this.pnlLogInput.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlLogInput.HorizontalScrollbarSize = 10;
            this.pnlLogInput.Location = new System.Drawing.Point(13, 16);
            this.pnlLogInput.Name = "pnlLogInput";
            this.pnlLogInput.Size = new System.Drawing.Size(648, 410);
            this.pnlLogInput.TabIndex = 2;
            this.pnlLogInput.UseCustomBackColor = true;
            this.pnlLogInput.UseCustomForeColor = true;
            this.pnlLogInput.VerticalScrollbarBarColor = true;
            this.pnlLogInput.VerticalScrollbarHighlightOnWheel = false;
            this.pnlLogInput.VerticalScrollbarSize = 10;
            // 
            // btnClear
            // 
            this.btnClear.ActiveControl = null;
            this.btnClear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(80, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 37);
            this.btnClear.TabIndex = 15;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.TileImage = ((System.Drawing.Image)(resources.GetObject("btnClear.TileImage")));
            this.btnClear.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.UseCustomBackColor = true;
            this.btnClear.UseCustomForeColor = true;
            this.btnClear.UseSelectable = true;
            this.btnClear.UseTileImage = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveControl = null;
            this.btnSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(259, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 37);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.TileImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.TileImage")));
            this.btnSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseCustomForeColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseTileImage = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(106, 345);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 37);
            this.btnReset.TabIndex = 11;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLog.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.Location = new System.Drawing.Point(434, 345);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(86, 37);
            this.btnLog.TabIndex = 13;
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.AllowUserToResizeRows = false;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLastName,
            this.colFirstName,
            this.colGender,
            this.colContactNumber});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSearch.EnableHeadersVisualStyles = false;
            this.dgvSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSearch.Location = new System.Drawing.Point(37, 178);
            this.dgvSearch.MultiSelect = false;
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(561, 161);
            this.dgvSearch.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvSearch.TabIndex = 12;
            this.dgvSearch.UseStyleColors = true;
            this.dgvSearch.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentDoubleClick);
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.Width = 150;
            // 
            // colFirstName
            // 
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.Width = 150;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.Width = 150;
            // 
            // colContactNumber
            // 
            this.colContactNumber.HeaderText = "Contact Number";
            this.colContactNumber.Name = "colContactNumber";
            this.colContactNumber.ReadOnly = true;
            this.colContactNumber.Width = 150;
            // 
            // textName
            // 
            this.textName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.textName.CustomButton.Image = null;
            this.textName.CustomButton.Location = new System.Drawing.Point(277, 2);
            this.textName.CustomButton.Name = "";
            this.textName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textName.CustomButton.TabIndex = 1;
            this.textName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textName.CustomButton.UseSelectable = true;
            this.textName.CustomButton.Visible = false;
            this.textName.Lines = new string[0];
            this.textName.Location = new System.Drawing.Point(200, 76);
            this.textName.MaxLength = 32767;
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.PromptText = "Anderson";
            this.textName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textName.SelectedText = "";
            this.textName.SelectionLength = 0;
            this.textName.SelectionStart = 0;
            this.textName.ShortcutsEnabled = true;
            this.textName.Size = new System.Drawing.Size(303, 28);
            this.textName.Style = MetroFramework.MetroColorStyle.Lime;
            this.textName.TabIndex = 10;
            this.textName.UseSelectable = true;
            this.textName.UseStyleColors = true;
            this.textName.WaterMark = "Anderson";
            this.textName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(101, 76);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(91, 19);
            this.lblSearchName.TabIndex = 9;
            this.lblSearchName.Text = "Search Name:";
            this.lblSearchName.UseCustomBackColor = true;
            this.lblSearchName.UseCustomForeColor = true;
            // 
            // btnAdvSearch
            // 
            this.btnAdvSearch.ActiveControl = null;
            this.btnAdvSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdvSearch.Location = new System.Drawing.Point(434, 120);
            this.btnAdvSearch.Name = "btnAdvSearch";
            this.btnAdvSearch.Size = new System.Drawing.Size(142, 40);
            this.btnAdvSearch.TabIndex = 4;
            this.btnAdvSearch.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAdvSearch.TileImage")));
            this.btnAdvSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdvSearch.UseCustomBackColor = true;
            this.btnAdvSearch.UseCustomForeColor = true;
            this.btnAdvSearch.UseSelectable = true;
            this.btnAdvSearch.UseTileImage = true;
            this.btnAdvSearch.Click += new System.EventHandler(this.btnAdvSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSearch.Location = new System.Drawing.Point(16, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(141, 25);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "SEARCH DETAILS";
            this.lblSearch.UseCustomBackColor = true;
            this.lblSearch.UseCustomForeColor = true;
            // 
            // pnlQR
            // 
            this.pnlQR.Controls.Add(this.gboQR);
            this.pnlQR.Controls.Add(this.lblSearchQR);
            this.pnlQR.HorizontalScrollbarBarColor = true;
            this.pnlQR.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlQR.HorizontalScrollbarSize = 10;
            this.pnlQR.Location = new System.Drawing.Point(7, 9);
            this.pnlQR.Name = "pnlQR";
            this.pnlQR.Size = new System.Drawing.Size(648, 410);
            this.pnlQR.TabIndex = 4;
            this.pnlQR.UseCustomBackColor = true;
            this.pnlQR.UseCustomForeColor = true;
            this.pnlQR.VerticalScrollbarBarColor = true;
            this.pnlQR.VerticalScrollbarHighlightOnWheel = false;
            this.pnlQR.VerticalScrollbarSize = 10;
            this.pnlQR.Visible = false;
            // 
            // gboQR
            // 
            this.gboQR.Controls.Add(this.lblPatID);
            this.gboQR.Controls.Add(this.lblPatientID);
            this.gboQR.Controls.Add(this.btnCloseCamera);
            this.gboQR.Controls.Add(this.btnStartCam);
            this.gboQR.Controls.Add(this.cboCapture);
            this.gboQR.Controls.Add(this.lblScanFeed);
            this.gboQR.Controls.Add(this.pboReader);
            this.gboQR.Location = new System.Drawing.Point(16, 51);
            this.gboQR.Name = "gboQR";
            this.gboQR.Size = new System.Drawing.Size(610, 295);
            this.gboQR.TabIndex = 3;
            this.gboQR.TabStop = false;
            // 
            // lblPatID
            // 
            this.lblPatID.AutoSize = true;
            this.lblPatID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPatID.Location = new System.Drawing.Point(337, 197);
            this.lblPatID.Name = "lblPatID";
            this.lblPatID.Size = new System.Drawing.Size(82, 25);
            this.lblPatID.TabIndex = 6;
            this.lblPatID.Text = "Scanning";
            this.lblPatID.UseCustomBackColor = true;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPatientID.Location = new System.Drawing.Point(234, 197);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(89, 25);
            this.lblPatientID.TabIndex = 5;
            this.lblPatientID.Text = "Patient ID:";
            this.lblPatientID.UseCustomBackColor = true;
            // 
            // btnCloseCamera
            // 
            this.btnCloseCamera.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCloseCamera.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCloseCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseCamera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseCamera.Location = new System.Drawing.Point(377, 105);
            this.btnCloseCamera.Name = "btnCloseCamera";
            this.btnCloseCamera.Size = new System.Drawing.Size(104, 58);
            this.btnCloseCamera.TabIndex = 4;
            this.btnCloseCamera.Text = "CLOSE SCANNER";
            this.btnCloseCamera.UseVisualStyleBackColor = false;
            this.btnCloseCamera.Click += new System.EventHandler(this.btnCloseCamera_Click);
            // 
            // btnStartCam
            // 
            this.btnStartCam.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnStartCam.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStartCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartCam.Location = new System.Drawing.Point(234, 105);
            this.btnStartCam.Name = "btnStartCam";
            this.btnStartCam.Size = new System.Drawing.Size(104, 58);
            this.btnStartCam.TabIndex = 3;
            this.btnStartCam.Text = "START SCANNER";
            this.btnStartCam.UseVisualStyleBackColor = false;
            this.btnStartCam.Click += new System.EventHandler(this.btnStartCam_Click);
            // 
            // cboCapture
            // 
            this.cboCapture.FormattingEnabled = true;
            this.cboCapture.ItemHeight = 23;
            this.cboCapture.Location = new System.Drawing.Point(234, 56);
            this.cboCapture.Name = "cboCapture";
            this.cboCapture.Size = new System.Drawing.Size(247, 29);
            this.cboCapture.Style = MetroFramework.MetroColorStyle.Lime;
            this.cboCapture.TabIndex = 2;
            this.cboCapture.UseSelectable = true;
            this.cboCapture.UseStyleColors = true;
            // 
            // lblScanFeed
            // 
            this.lblScanFeed.AutoSize = true;
            this.lblScanFeed.Location = new System.Drawing.Point(73, 197);
            this.lblScanFeed.Name = "lblScanFeed";
            this.lblScanFeed.Size = new System.Drawing.Size(78, 19);
            this.lblScanFeed.TabIndex = 1;
            this.lblScanFeed.Text = "SCAN FEED";
            this.lblScanFeed.UseCustomBackColor = true;
            // 
            // pboReader
            // 
            this.pboReader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboReader.Location = new System.Drawing.Point(30, 41);
            this.pboReader.Name = "pboReader";
            this.pboReader.Size = new System.Drawing.Size(153, 153);
            this.pboReader.TabIndex = 0;
            this.pboReader.TabStop = false;
            // 
            // lblSearchQR
            // 
            this.lblSearchQR.AutoSize = true;
            this.lblSearchQR.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSearchQR.Location = new System.Drawing.Point(16, 16);
            this.lblSearchQR.Name = "lblSearchQR";
            this.lblSearchQR.Size = new System.Drawing.Size(107, 25);
            this.lblSearchQR.TabIndex = 2;
            this.lblSearchQR.Text = "SCAN CODE";
            this.lblSearchQR.UseCustomBackColor = true;
            this.lblSearchQR.UseCustomForeColor = true;
            // 
            // videoTimer
            // 
            this.videoTimer.Tick += new System.EventHandler(this.videoTimer_Tick);
            // 
            // CtrlLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.pnlLogInput);
            this.Controls.Add(this.pnlQR);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CtrlLogs";
            this.Size = new System.Drawing.Size(670, 440);
            this.Load += new System.EventHandler(this.CtrlLogs_Load);
            this.Validated += new System.EventHandler(this.CtrlLogs_Validated);
            this.pnlLogInput.ResumeLayout(false);
            this.pnlLogInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.pnlQR.ResumeLayout(false);
            this.pnlQR.PerformLayout();
            this.gboQR.ResumeLayout(false);
            this.gboQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboReader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlLogInput;
        private MetroFramework.Controls.MetroLabel lblSearch;
        private MetroFramework.Controls.MetroPanel pnlQR;
        private System.Windows.Forms.GroupBox gboQR;
        private MetroFramework.Controls.MetroLabel lblSearchQR;
        private MetroFramework.Controls.MetroLabel lblScanFeed;
        private System.Windows.Forms.PictureBox pboReader;
        private MetroFramework.Controls.MetroComboBox cboCapture;
        private System.Windows.Forms.Button btnCloseCamera;
        private System.Windows.Forms.Button btnStartCam;
        private MetroFramework.Controls.MetroLabel lblPatientID;
        private MetroFramework.Controls.MetroLabel lblPatID;
        private System.Windows.Forms.Timer videoTimer;
        private MetroFramework.Controls.MetroTile btnAdvSearch;
        private MetroFramework.Controls.MetroTile btnClear;
        private MetroFramework.Controls.MetroTile btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLog;
        private MetroFramework.Controls.MetroGrid dgvSearch;
        private MetroFramework.Controls.MetroTextBox textName;
        private MetroFramework.Controls.MetroLabel lblSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactNumber;
    }
}
