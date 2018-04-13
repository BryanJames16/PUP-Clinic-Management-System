namespace ClinicManagementSystem
{
    partial class CtrlPat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlPat));
            this.lblSearchPatient = new MetroFramework.Controls.MetroLabel();
            this.lblPatientName = new MetroFramework.Controls.MetroLabel();
            this.textName = new MetroFramework.Controls.MetroTextBox();
            this.dgvSearch = new MetroFramework.Controls.MetroGrid();
            this.colPatLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchPatient = new MetroFramework.Controls.MetroTile();
            this.btnClear = new MetroFramework.Controls.MetroTile();
            this.btnReset = new MetroFramework.Controls.MetroTile();
            this.btnAdvSearch = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchPatient
            // 
            this.lblSearchPatient.AutoSize = true;
            this.lblSearchPatient.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSearchPatient.Location = new System.Drawing.Point(24, 25);
            this.lblSearchPatient.Name = "lblSearchPatient";
            this.lblSearchPatient.Size = new System.Drawing.Size(140, 25);
            this.lblSearchPatient.TabIndex = 0;
            this.lblSearchPatient.Text = "SEARCH PATIENT";
            this.lblSearchPatient.UseCustomBackColor = true;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(103, 77);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(91, 19);
            this.lblPatientName.TabIndex = 5;
            this.lblPatientName.Text = "Patient Name:";
            this.lblPatientName.UseCustomBackColor = true;
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
            this.textName.Location = new System.Drawing.Point(226, 73);
            this.textName.MaxLength = 45;
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.PromptText = "DELA CRUZ";
            this.textName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textName.SelectedText = "";
            this.textName.SelectionLength = 0;
            this.textName.SelectionStart = 0;
            this.textName.ShortcutsEnabled = true;
            this.textName.Size = new System.Drawing.Size(269, 23);
            this.textName.Style = MetroFramework.MetroColorStyle.Lime;
            this.textName.TabIndex = 6;
            this.textName.UseSelectable = true;
            this.textName.UseStyleColors = true;
            this.textName.WaterMark = "DELA CRUZ";
            this.textName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPatLastName,
            this.colPatFirstName,
            this.colContactNo,
            this.colGender});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearch.EnableHeadersVisualStyles = false;
            this.dgvSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSearch.Location = new System.Drawing.Point(103, 186);
            this.dgvSearch.MultiSelect = false;
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(443, 173);
            this.dgvSearch.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvSearch.TabIndex = 7;
            this.dgvSearch.UseStyleColors = true;
            // 
            // colPatLastName
            // 
            this.colPatLastName.HeaderText = "Last Name";
            this.colPatLastName.Name = "colPatLastName";
            this.colPatLastName.ReadOnly = true;
            // 
            // colPatFirstName
            // 
            this.colPatFirstName.HeaderText = "First Name";
            this.colPatFirstName.Name = "colPatFirstName";
            this.colPatFirstName.ReadOnly = true;
            // 
            // colContactNo
            // 
            this.colContactNo.HeaderText = "Contact Number";
            this.colContactNo.Name = "colContactNo";
            this.colContactNo.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.ActiveControl = null;
            this.btnSearchPatient.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSearchPatient.Location = new System.Drawing.Point(421, 123);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(86, 37);
            this.btnSearchPatient.TabIndex = 8;
            this.btnSearchPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchPatient.TileImage = ((System.Drawing.Image)(resources.GetObject("btnSearchPatient.TileImage")));
            this.btnSearchPatient.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchPatient.UseCustomBackColor = true;
            this.btnSearchPatient.UseCustomForeColor = true;
            this.btnSearchPatient.UseSelectable = true;
            this.btnSearchPatient.UseTileImage = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // btnClear
            // 
            this.btnClear.ActiveControl = null;
            this.btnClear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnClear.Location = new System.Drawing.Point(194, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 37);
            this.btnClear.TabIndex = 9;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.TileImage = ((System.Drawing.Image)(resources.GetObject("btnClear.TileImage")));
            this.btnClear.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.UseCustomBackColor = true;
            this.btnClear.UseCustomForeColor = true;
            this.btnClear.UseSelectable = true;
            this.btnClear.UseTileImage = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReset
            // 
            this.btnReset.ActiveControl = null;
            this.btnReset.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReset.Location = new System.Drawing.Point(271, 375);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 37);
            this.btnReset.TabIndex = 10;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.TileImage = ((System.Drawing.Image)(resources.GetObject("btnReset.TileImage")));
            this.btnReset.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.UseCustomBackColor = true;
            this.btnReset.UseCustomForeColor = true;
            this.btnReset.UseSelectable = true;
            this.btnReset.UseTileImage = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdvSearch
            // 
            this.btnAdvSearch.ActiveControl = null;
            this.btnAdvSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdvSearch.Location = new System.Drawing.Point(501, 14);
            this.btnAdvSearch.Name = "btnAdvSearch";
            this.btnAdvSearch.Size = new System.Drawing.Size(142, 40);
            this.btnAdvSearch.TabIndex = 12;
            this.btnAdvSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdvSearch.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAdvSearch.TileImage")));
            this.btnAdvSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdvSearch.UseCustomBackColor = true;
            this.btnAdvSearch.UseCustomForeColor = true;
            this.btnAdvSearch.UseSelectable = true;
            this.btnAdvSearch.UseTileImage = true;
            this.btnAdvSearch.Click += new System.EventHandler(this.btnAdvSearch_Click);
            // 
            // CtrlPat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnAdvSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblSearchPatient);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CtrlPat";
            this.Size = new System.Drawing.Size(674, 433);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblSearchPatient;
        private MetroFramework.Controls.MetroLabel lblPatientName;
        private MetroFramework.Controls.MetroTextBox textName;
        private MetroFramework.Controls.MetroGrid dgvSearch;
        private MetroFramework.Controls.MetroTile btnSearchPatient;
        private MetroFramework.Controls.MetroTile btnClear;
        private MetroFramework.Controls.MetroTile btnReset;
        private MetroFramework.Controls.MetroTile btnAdvSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
    }
}
