namespace ClinicManagementSystem
{
    partial class CtrlAddAppt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlAddAppt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPatient = new MetroFramework.Controls.MetroGrid();
            this.colPatLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPatient = new MetroFramework.Controls.MetroPanel();
            this.btnAdvSearchPat = new MetroFramework.Controls.MetroTile();
            this.lblPatient = new MetroFramework.Controls.MetroLabel();
            this.gboPatient = new System.Windows.Forms.GroupBox();
            this.btnPatClear = new System.Windows.Forms.Button();
            this.btnPatSearch = new System.Windows.Forms.Button();
            this.textName = new MetroFramework.Controls.MetroTextBox();
            this.lblPatName = new MetroFramework.Controls.MetroLabel();
            this.pnlDoctor = new MetroFramework.Controls.MetroPanel();
            this.btnAdvSearchDoc = new MetroFramework.Controls.MetroTile();
            this.gboDoctor = new System.Windows.Forms.GroupBox();
            this.btnDocClear = new System.Windows.Forms.Button();
            this.btnDocSearch = new System.Windows.Forms.Button();
            this.textDocName = new MetroFramework.Controls.MetroTextBox();
            this.lblDocName = new MetroFramework.Controls.MetroLabel();
            this.dgvDoctor = new MetroFramework.Controls.MetroGrid();
            this.colDoctorLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchDoctor = new MetroFramework.Controls.MetroLabel();
            this.lblDateTime = new MetroFramework.Controls.MetroLabel();
            this.datSchedule = new System.Windows.Forms.DateTimePicker();
            this.btnSetAppointment = new MetroFramework.Controls.MetroTile();
            this.tmAppointment = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.pnlPatient.SuspendLayout();
            this.gboPatient.SuspendLayout();
            this.pnlDoctor.SuspendLayout();
            this.gboDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.AllowUserToResizeRows = false;
            this.dgvPatient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPatLastName,
            this.colPatFname,
            this.colPatContactNo,
            this.colGender});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatient.EnableHeadersVisualStyles = false;
            this.dgvPatient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPatient.Location = new System.Drawing.Point(80, 112);
            this.dgvPatient.MultiSelect = false;
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatient.RowHeadersWidth = 50;
            this.dgvPatient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatient.Size = new System.Drawing.Size(442, 131);
            this.dgvPatient.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvPatient.TabIndex = 0;
            this.dgvPatient.UseStyleColors = true;
            // 
            // colPatLastName
            // 
            this.colPatLastName.HeaderText = "Last Name";
            this.colPatLastName.Name = "colPatLastName";
            this.colPatLastName.ReadOnly = true;
            // 
            // colPatFname
            // 
            this.colPatFname.HeaderText = "First Name";
            this.colPatFname.Name = "colPatFname";
            this.colPatFname.ReadOnly = true;
            // 
            // colPatContactNo
            // 
            this.colPatContactNo.HeaderText = "Contact Number";
            this.colPatContactNo.Name = "colPatContactNo";
            this.colPatContactNo.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // pnlPatient
            // 
            this.pnlPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPatient.Controls.Add(this.btnAdvSearchPat);
            this.pnlPatient.Controls.Add(this.lblPatient);
            this.pnlPatient.Controls.Add(this.gboPatient);
            this.pnlPatient.HorizontalScrollbarBarColor = true;
            this.pnlPatient.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPatient.HorizontalScrollbarSize = 10;
            this.pnlPatient.Location = new System.Drawing.Point(14, 34);
            this.pnlPatient.Name = "pnlPatient";
            this.pnlPatient.Size = new System.Drawing.Size(637, 294);
            this.pnlPatient.TabIndex = 1;
            this.pnlPatient.UseCustomBackColor = true;
            this.pnlPatient.VerticalScrollbarBarColor = true;
            this.pnlPatient.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPatient.VerticalScrollbarSize = 10;
            // 
            // btnAdvSearchPat
            // 
            this.btnAdvSearchPat.ActiveControl = null;
            this.btnAdvSearchPat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdvSearchPat.Location = new System.Drawing.Point(461, 6);
            this.btnAdvSearchPat.Name = "btnAdvSearchPat";
            this.btnAdvSearchPat.Size = new System.Drawing.Size(142, 40);
            this.btnAdvSearchPat.TabIndex = 4;
            this.btnAdvSearchPat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdvSearchPat.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAdvSearchPat.TileImage")));
            this.btnAdvSearchPat.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdvSearchPat.UseCustomBackColor = true;
            this.btnAdvSearchPat.UseCustomForeColor = true;
            this.btnAdvSearchPat.UseSelectable = true;
            this.btnAdvSearchPat.UseTileImage = true;
            this.btnAdvSearchPat.Click += new System.EventHandler(this.btnAdvSearchPat_Click);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPatient.Location = new System.Drawing.Point(17, 9);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(144, 25);
            this.lblPatient.TabIndex = 3;
            this.lblPatient.Text = "SEARCH PATIENT";
            this.lblPatient.UseCustomBackColor = true;
            // 
            // gboPatient
            // 
            this.gboPatient.Controls.Add(this.btnPatClear);
            this.gboPatient.Controls.Add(this.btnPatSearch);
            this.gboPatient.Controls.Add(this.textName);
            this.gboPatient.Controls.Add(this.lblPatName);
            this.gboPatient.Controls.Add(this.dgvPatient);
            this.gboPatient.Location = new System.Drawing.Point(3, 40);
            this.gboPatient.Name = "gboPatient";
            this.gboPatient.Size = new System.Drawing.Size(631, 249);
            this.gboPatient.TabIndex = 2;
            this.gboPatient.TabStop = false;
            // 
            // btnPatClear
            // 
            this.btnPatClear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPatClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPatClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPatClear.Image = ((System.Drawing.Image)(resources.GetObject("btnPatClear.Image")));
            this.btnPatClear.Location = new System.Drawing.Point(171, 58);
            this.btnPatClear.Name = "btnPatClear";
            this.btnPatClear.Size = new System.Drawing.Size(86, 37);
            this.btnPatClear.TabIndex = 6;
            this.btnPatClear.UseVisualStyleBackColor = false;
            this.btnPatClear.Click += new System.EventHandler(this.btnPatClear_Click);
            // 
            // btnPatSearch
            // 
            this.btnPatSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPatSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPatSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPatSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnPatSearch.Image")));
            this.btnPatSearch.Location = new System.Drawing.Point(372, 58);
            this.btnPatSearch.Name = "btnPatSearch";
            this.btnPatSearch.Size = new System.Drawing.Size(86, 37);
            this.btnPatSearch.TabIndex = 5;
            this.btnPatSearch.UseVisualStyleBackColor = false;
            this.btnPatSearch.Click += new System.EventHandler(this.btnPatSearch_Click);
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
            this.textName.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.textName.CustomButton.Name = "";
            this.textName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textName.CustomButton.TabIndex = 1;
            this.textName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textName.CustomButton.UseSelectable = true;
            this.textName.CustomButton.Visible = false;
            this.textName.Lines = new string[0];
            this.textName.Location = new System.Drawing.Point(214, 23);
            this.textName.MaxLength = 32;
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.PromptText = "DELA CRUZ";
            this.textName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textName.SelectedText = "";
            this.textName.SelectionLength = 0;
            this.textName.SelectionStart = 0;
            this.textName.ShortcutsEnabled = true;
            this.textName.Size = new System.Drawing.Size(229, 29);
            this.textName.Style = MetroFramework.MetroColorStyle.Lime;
            this.textName.TabIndex = 4;
            this.textName.UseSelectable = true;
            this.textName.UseStyleColors = true;
            this.textName.WaterMark = "DELA CRUZ";
            this.textName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // lblPatName
            // 
            this.lblPatName.AutoSize = true;
            this.lblPatName.Location = new System.Drawing.Point(107, 23);
            this.lblPatName.Name = "lblPatName";
            this.lblPatName.Size = new System.Drawing.Size(92, 19);
            this.lblPatName.TabIndex = 3;
            this.lblPatName.Text = "Patient Name:";
            this.lblPatName.UseCustomBackColor = true;
            // 
            // pnlDoctor
            // 
            this.pnlDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDoctor.Controls.Add(this.btnAdvSearchDoc);
            this.pnlDoctor.Controls.Add(this.gboDoctor);
            this.pnlDoctor.Controls.Add(this.lblSearchDoctor);
            this.pnlDoctor.HorizontalScrollbarBarColor = true;
            this.pnlDoctor.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDoctor.HorizontalScrollbarSize = 10;
            this.pnlDoctor.Location = new System.Drawing.Point(15, 344);
            this.pnlDoctor.Name = "pnlDoctor";
            this.pnlDoctor.Size = new System.Drawing.Size(636, 291);
            this.pnlDoctor.TabIndex = 2;
            this.pnlDoctor.UseCustomBackColor = true;
            this.pnlDoctor.VerticalScrollbarBarColor = true;
            this.pnlDoctor.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDoctor.VerticalScrollbarSize = 10;
            // 
            // btnAdvSearchDoc
            // 
            this.btnAdvSearchDoc.ActiveControl = null;
            this.btnAdvSearchDoc.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdvSearchDoc.Location = new System.Drawing.Point(463, 10);
            this.btnAdvSearchDoc.Name = "btnAdvSearchDoc";
            this.btnAdvSearchDoc.Size = new System.Drawing.Size(144, 42);
            this.btnAdvSearchDoc.TabIndex = 5;
            this.btnAdvSearchDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdvSearchDoc.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAdvSearchDoc.TileImage")));
            this.btnAdvSearchDoc.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdvSearchDoc.UseCustomBackColor = true;
            this.btnAdvSearchDoc.UseCustomForeColor = true;
            this.btnAdvSearchDoc.UseSelectable = true;
            this.btnAdvSearchDoc.UseTileImage = true;
            this.btnAdvSearchDoc.Click += new System.EventHandler(this.btnAdvSearchDoc_Click);
            // 
            // gboDoctor
            // 
            this.gboDoctor.Controls.Add(this.btnDocClear);
            this.gboDoctor.Controls.Add(this.btnDocSearch);
            this.gboDoctor.Controls.Add(this.textDocName);
            this.gboDoctor.Controls.Add(this.lblDocName);
            this.gboDoctor.Controls.Add(this.dgvDoctor);
            this.gboDoctor.Location = new System.Drawing.Point(3, 50);
            this.gboDoctor.Name = "gboDoctor";
            this.gboDoctor.Size = new System.Drawing.Size(621, 238);
            this.gboDoctor.TabIndex = 3;
            this.gboDoctor.TabStop = false;
            // 
            // btnDocClear
            // 
            this.btnDocClear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnDocClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDocClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDocClear.Image = ((System.Drawing.Image)(resources.GetObject("btnDocClear.Image")));
            this.btnDocClear.Location = new System.Drawing.Point(170, 58);
            this.btnDocClear.Name = "btnDocClear";
            this.btnDocClear.Size = new System.Drawing.Size(86, 37);
            this.btnDocClear.TabIndex = 10;
            this.btnDocClear.UseVisualStyleBackColor = false;
            this.btnDocClear.Click += new System.EventHandler(this.btnDocClear_Click);
            // 
            // btnDocSearch
            // 
            this.btnDocSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnDocSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDocSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDocSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnDocSearch.Image")));
            this.btnDocSearch.Location = new System.Drawing.Point(384, 58);
            this.btnDocSearch.Name = "btnDocSearch";
            this.btnDocSearch.Size = new System.Drawing.Size(86, 37);
            this.btnDocSearch.TabIndex = 9;
            this.btnDocSearch.UseVisualStyleBackColor = false;
            this.btnDocSearch.Click += new System.EventHandler(this.btnDocSearch_Click);
            // 
            // textDocName
            // 
            this.textDocName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textDocName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textDocName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.textDocName.CustomButton.Image = null;
            this.textDocName.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.textDocName.CustomButton.Name = "";
            this.textDocName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textDocName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textDocName.CustomButton.TabIndex = 1;
            this.textDocName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textDocName.CustomButton.UseSelectable = true;
            this.textDocName.CustomButton.Visible = false;
            this.textDocName.Lines = new string[0];
            this.textDocName.Location = new System.Drawing.Point(238, 28);
            this.textDocName.MaxLength = 32;
            this.textDocName.Name = "textDocName";
            this.textDocName.PasswordChar = '\0';
            this.textDocName.PromptText = "YNARES";
            this.textDocName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textDocName.SelectedText = "";
            this.textDocName.SelectionLength = 0;
            this.textDocName.SelectionStart = 0;
            this.textDocName.ShortcutsEnabled = true;
            this.textDocName.Size = new System.Drawing.Size(219, 29);
            this.textDocName.Style = MetroFramework.MetroColorStyle.Lime;
            this.textDocName.TabIndex = 8;
            this.textDocName.UseSelectable = true;
            this.textDocName.UseStyleColors = true;
            this.textDocName.WaterMark = "YNARES";
            this.textDocName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textDocName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textDocName.TextChanged += new System.EventHandler(this.textDocName_TextChanged);
            // 
            // lblDocName
            // 
            this.lblDocName.AutoSize = true;
            this.lblDocName.Location = new System.Drawing.Point(126, 28);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(100, 19);
            this.lblDocName.TabIndex = 2;
            this.lblDocName.Text = "Doctor\'s Name:";
            this.lblDocName.UseCustomBackColor = true;
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.AllowUserToAddRows = false;
            this.dgvDoctor.AllowUserToDeleteRows = false;
            this.dgvDoctor.AllowUserToResizeRows = false;
            this.dgvDoctor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDoctor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDoctorLastName,
            this.colDocFirstName,
            this.colDocContactNo,
            this.colDocGender});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoctor.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDoctor.EnableHeadersVisualStyles = false;
            this.dgvDoctor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDoctor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDoctor.Location = new System.Drawing.Point(80, 112);
            this.dgvDoctor.MultiSelect = false;
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.ReadOnly = true;
            this.dgvDoctor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctor.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDoctor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctor.Size = new System.Drawing.Size(441, 120);
            this.dgvDoctor.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvDoctor.TabIndex = 0;
            this.dgvDoctor.UseStyleColors = true;
            this.dgvDoctor.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctor_CellContentDoubleClick);
            // 
            // colDoctorLastName
            // 
            this.colDoctorLastName.HeaderText = "Last Name";
            this.colDoctorLastName.Name = "colDoctorLastName";
            this.colDoctorLastName.ReadOnly = true;
            // 
            // colDocFirstName
            // 
            this.colDocFirstName.HeaderText = "First Name";
            this.colDocFirstName.Name = "colDocFirstName";
            this.colDocFirstName.ReadOnly = true;
            // 
            // colDocContactNo
            // 
            this.colDocContactNo.HeaderText = "Contact Number";
            this.colDocContactNo.Name = "colDocContactNo";
            this.colDocContactNo.ReadOnly = true;
            // 
            // colDocGender
            // 
            this.colDocGender.HeaderText = "Gender";
            this.colDocGender.Name = "colDocGender";
            this.colDocGender.ReadOnly = true;
            // 
            // lblSearchDoctor
            // 
            this.lblSearchDoctor.AutoSize = true;
            this.lblSearchDoctor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSearchDoctor.Location = new System.Drawing.Point(16, 21);
            this.lblSearchDoctor.Name = "lblSearchDoctor";
            this.lblSearchDoctor.Size = new System.Drawing.Size(149, 25);
            this.lblSearchDoctor.TabIndex = 2;
            this.lblSearchDoctor.Text = "SEARCH DOCTOR";
            this.lblSearchDoctor.UseCustomBackColor = true;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDateTime.Location = new System.Drawing.Point(18, 666);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(140, 25);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "DATE AND TIME:";
            this.lblDateTime.UseCustomBackColor = true;
            // 
            // datSchedule
            // 
            this.datSchedule.Location = new System.Drawing.Point(164, 666);
            this.datSchedule.MaxDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.datSchedule.MinDate = new System.DateTime(2016, 9, 3, 0, 0, 0, 0);
            this.datSchedule.Name = "datSchedule";
            this.datSchedule.Size = new System.Drawing.Size(250, 27);
            this.datSchedule.TabIndex = 4;
            // 
            // btnSetAppointment
            // 
            this.btnSetAppointment.ActiveControl = null;
            this.btnSetAppointment.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSetAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetAppointment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetAppointment.Location = new System.Drawing.Point(286, 717);
            this.btnSetAppointment.Name = "btnSetAppointment";
            this.btnSetAppointment.Size = new System.Drawing.Size(145, 40);
            this.btnSetAppointment.TabIndex = 5;
            this.btnSetAppointment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetAppointment.TileImage = ((System.Drawing.Image)(resources.GetObject("btnSetAppointment.TileImage")));
            this.btnSetAppointment.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSetAppointment.UseCustomBackColor = true;
            this.btnSetAppointment.UseCustomForeColor = true;
            this.btnSetAppointment.UseSelectable = true;
            this.btnSetAppointment.UseTileImage = true;
            this.btnSetAppointment.Click += new System.EventHandler(this.btnSetAppointment_Click);
            // 
            // tmAppointment
            // 
            this.tmAppointment.CustomFormat = "";
            this.tmAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tmAppointment.Location = new System.Drawing.Point(430, 666);
            this.tmAppointment.Name = "tmAppointment";
            this.tmAppointment.ShowUpDown = true;
            this.tmAppointment.Size = new System.Drawing.Size(200, 27);
            this.tmAppointment.TabIndex = 6;
            // 
            // CtrlAddAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.tmAppointment);
            this.Controls.Add(this.btnSetAppointment);
            this.Controls.Add(this.datSchedule);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.pnlDoctor);
            this.Controls.Add(this.pnlPatient);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CtrlAddAppt";
            this.Size = new System.Drawing.Size(674, 774);
            this.Load += new System.EventHandler(this.CtrlAddAppointment_Load);
            this.Validated += new System.EventHandler(this.CtrlAddAppt_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.pnlPatient.ResumeLayout(false);
            this.pnlPatient.PerformLayout();
            this.gboPatient.ResumeLayout(false);
            this.gboPatient.PerformLayout();
            this.pnlDoctor.ResumeLayout(false);
            this.pnlDoctor.PerformLayout();
            this.gboDoctor.ResumeLayout(false);
            this.gboDoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvPatient;
        private MetroFramework.Controls.MetroPanel pnlPatient;
        private MetroFramework.Controls.MetroLabel lblPatient;
        private System.Windows.Forms.GroupBox gboPatient;
        private MetroFramework.Controls.MetroPanel pnlDoctor;
        private MetroFramework.Controls.MetroTextBox textName;
        private MetroFramework.Controls.MetroLabel lblPatName;
        private System.Windows.Forms.Button btnPatSearch;
        private System.Windows.Forms.Button btnPatClear;
        private MetroFramework.Controls.MetroLabel lblSearchDoctor;
        private System.Windows.Forms.GroupBox gboDoctor;
        private MetroFramework.Controls.MetroGrid dgvDoctor;
        private MetroFramework.Controls.MetroLabel lblDocName;
        private System.Windows.Forms.Button btnDocClear;
        private System.Windows.Forms.Button btnDocSearch;
        private MetroFramework.Controls.MetroTextBox textDocName;
        private MetroFramework.Controls.MetroLabel lblDateTime;
        private System.Windows.Forms.DateTimePicker datSchedule;
        private MetroFramework.Controls.MetroTile btnSetAppointment;
        private System.Windows.Forms.DateTimePicker tmAppointment;
        private MetroFramework.Controls.MetroTile btnAdvSearchPat;
        private MetroFramework.Controls.MetroTile btnAdvSearchDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctorLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocGender;
    }
}
