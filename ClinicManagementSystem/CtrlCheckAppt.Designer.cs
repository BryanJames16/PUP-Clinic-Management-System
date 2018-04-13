namespace ClinicManagementSystem
{
    partial class CtrlCheckAppt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlCheckAppt));
            this.dgvResults = new MetroFramework.Controls.MetroGrid();
            this.colApptTimeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApptDoctorLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApptDoctFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApptPatLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApptPatFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new MetroFramework.Controls.MetroTile();
            this.btnCancel = new MetroFramework.Controls.MetroTile();
            this.btnAdvSearch = new MetroFramework.Controls.MetroTile();
            this.lblSearchName = new MetroFramework.Controls.MetroLabel();
            this.textName = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToResizeRows = false;
            this.dgvResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colApptTimeDate,
            this.colApptDoctorLastName,
            this.colApptDoctFirstName,
            this.colApptPatLast,
            this.colApptPatFirst});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvResults.Location = new System.Drawing.Point(14, 190);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(641, 282);
            this.dgvResults.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvResults.TabIndex = 2;
            this.dgvResults.UseStyleColors = true;
            // 
            // colApptTimeDate
            // 
            this.colApptTimeDate.HeaderText = "Appointment Date & Time";
            this.colApptTimeDate.Name = "colApptTimeDate";
            this.colApptTimeDate.ReadOnly = true;
            this.colApptTimeDate.Width = 150;
            // 
            // colApptDoctorLastName
            // 
            this.colApptDoctorLastName.HeaderText = "Doctor\'s Last Name";
            this.colApptDoctorLastName.Name = "colApptDoctorLastName";
            this.colApptDoctorLastName.ReadOnly = true;
            this.colApptDoctorLastName.Width = 150;
            // 
            // colApptDoctFirstName
            // 
            this.colApptDoctFirstName.HeaderText = "Doctor\'s First Name";
            this.colApptDoctFirstName.Name = "colApptDoctFirstName";
            this.colApptDoctFirstName.ReadOnly = true;
            this.colApptDoctFirstName.Width = 150;
            // 
            // colApptPatLast
            // 
            this.colApptPatLast.HeaderText = "Patient\'s Last Name";
            this.colApptPatLast.Name = "colApptPatLast";
            this.colApptPatLast.ReadOnly = true;
            this.colApptPatLast.Width = 150;
            // 
            // colApptPatFirst
            // 
            this.colApptPatFirst.HeaderText = "Patient\'s First Name";
            this.colApptPatFirst.Name = "colApptPatFirst";
            this.colApptPatFirst.ReadOnly = true;
            this.colApptPatFirst.Width = 150;
            // 
            // btnReset
            // 
            this.btnReset.ActiveControl = null;
            this.btnReset.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReset.Location = new System.Drawing.Point(172, 485);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 37);
            this.btnReset.TabIndex = 3;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReset.TileImage = ((System.Drawing.Image)(resources.GetObject("btnReset.TileImage")));
            this.btnReset.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.UseCustomBackColor = true;
            this.btnReset.UseCustomForeColor = true;
            this.btnReset.UseSelectable = true;
            this.btnReset.UseTileImage = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveControl = null;
            this.btnCancel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCancel.Location = new System.Drawing.Point(377, 484);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.TileImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.TileImage")));
            this.btnCancel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseTileImage = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdvSearch
            // 
            this.btnAdvSearch.ActiveControl = null;
            this.btnAdvSearch.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdvSearch.Location = new System.Drawing.Point(227, 16);
            this.btnAdvSearch.Name = "btnAdvSearch";
            this.btnAdvSearch.Size = new System.Drawing.Size(142, 40);
            this.btnAdvSearch.TabIndex = 12;
            this.btnAdvSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdvSearch.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAdvSearch.TileImage")));
            this.btnAdvSearch.UseCustomBackColor = true;
            this.btnAdvSearch.UseCustomForeColor = true;
            this.btnAdvSearch.UseSelectable = true;
            this.btnAdvSearch.UseTileImage = true;
            this.btnAdvSearch.Click += new System.EventHandler(this.btnAdvSearch_Click);
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(33, 80);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(50, 19);
            this.lblSearchName.TabIndex = 13;
            this.lblSearchName.Text = "NAME:";
            this.lblSearchName.UseCustomBackColor = true;
            this.lblSearchName.UseCustomForeColor = true;
            // 
            // textName
            // 
            this.textName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.textName.CustomButton.Image = null;
            this.textName.CustomButton.Location = new System.Drawing.Point(247, 1);
            this.textName.CustomButton.Name = "";
            this.textName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textName.CustomButton.TabIndex = 1;
            this.textName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textName.CustomButton.UseSelectable = true;
            this.textName.CustomButton.Visible = false;
            this.textName.Lines = new string[0];
            this.textName.Location = new System.Drawing.Point(100, 81);
            this.textName.MaxLength = 32;
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.PromptText = "DELA CRUZ";
            this.textName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textName.SelectedText = "";
            this.textName.SelectionLength = 0;
            this.textName.SelectionStart = 0;
            this.textName.ShortcutsEnabled = true;
            this.textName.Size = new System.Drawing.Size(269, 23);
            this.textName.TabIndex = 14;
            this.textName.UseSelectable = true;
            this.textName.WaterMark = "DELA CRUZ";
            this.textName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveControl = null;
            this.btnSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSearch.Location = new System.Drawing.Point(172, 122);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 37);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.TileImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.TileImage")));
            this.btnSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseCustomForeColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseTileImage = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(404, 16);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.MinDate = new System.DateTime(2016, 10, 1, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 16;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            // 
            // CtrlCheckAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.btnAdvSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvResults);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CtrlCheckAppt";
            this.Size = new System.Drawing.Size(674, 536);
            this.Load += new System.EventHandler(this.CtrlCheckAppt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvResults;
        private MetroFramework.Controls.MetroTile btnReset;
        private MetroFramework.Controls.MetroTile btnCancel;
        private MetroFramework.Controls.MetroTile btnAdvSearch;
        private MetroFramework.Controls.MetroLabel lblSearchName;
        private MetroFramework.Controls.MetroTextBox textName;
        private MetroFramework.Controls.MetroTile btnSearch;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApptTimeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApptDoctorLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApptDoctFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApptPatLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApptPatFirst;
    }
}
