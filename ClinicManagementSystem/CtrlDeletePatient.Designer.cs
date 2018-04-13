namespace ClinicManagementSystem
{
    partial class CtrlDeletePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlDeletePatient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdvSearchPat = new MetroFramework.Controls.MetroTile();
            this.lblPatient = new MetroFramework.Controls.MetroLabel();
            this.gboPatient = new System.Windows.Forms.GroupBox();
            this.btnPatClear = new System.Windows.Forms.Button();
            this.btnPatSearch = new System.Windows.Forms.Button();
            this.textName = new MetroFramework.Controls.MetroTextBox();
            this.lblPatName = new MetroFramework.Controls.MetroLabel();
            this.dgvPatient = new MetroFramework.Controls.MetroGrid();
            this.colPatLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new MetroFramework.Controls.MetroTile();
            this.gboPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdvSearchPat
            // 
            this.btnAdvSearchPat.ActiveControl = null;
            this.btnAdvSearchPat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdvSearchPat.Location = new System.Drawing.Point(414, 31);
            this.btnAdvSearchPat.Name = "btnAdvSearchPat";
            this.btnAdvSearchPat.Size = new System.Drawing.Size(142, 40);
            this.btnAdvSearchPat.TabIndex = 7;
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
            this.lblPatient.Location = new System.Drawing.Point(29, 37);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(144, 25);
            this.lblPatient.TabIndex = 6;
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
            this.gboPatient.Location = new System.Drawing.Point(15, 68);
            this.gboPatient.Name = "gboPatient";
            this.gboPatient.Size = new System.Drawing.Size(578, 249);
            this.gboPatient.TabIndex = 5;
            this.gboPatient.TabStop = false;
            // 
            // btnPatClear
            // 
            this.btnPatClear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPatClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPatClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPatClear.Image = ((System.Drawing.Image)(resources.GetObject("btnPatClear.Image")));
            this.btnPatClear.Location = new System.Drawing.Point(153, 58);
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
            this.btnPatSearch.Location = new System.Drawing.Point(354, 58);
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
            this.textName.MaxLength = 32767;
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
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.AllowUserToResizeRows = false;
            this.dgvPatient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPatLastName,
            this.colPatFname,
            this.colPatContactNo,
            this.colGender});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatient.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPatient.EnableHeadersVisualStyles = false;
            this.dgvPatient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPatient.Location = new System.Drawing.Point(35, 112);
            this.dgvPatient.MultiSelect = false;
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPatient.RowHeadersWidth = 50;
            this.dgvPatient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatient.Size = new System.Drawing.Size(506, 131);
            this.dgvPatient.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvPatient.TabIndex = 0;
            this.dgvPatient.UseStyleColors = true;
            // 
            // colPatLastName
            // 
            this.colPatLastName.HeaderText = "Last Name";
            this.colPatLastName.Name = "colPatLastName";
            this.colPatLastName.ReadOnly = true;
            this.colPatLastName.Width = 150;
            // 
            // colPatFname
            // 
            this.colPatFname.HeaderText = "First Name";
            this.colPatFname.Name = "colPatFname";
            this.colPatFname.ReadOnly = true;
            this.colPatFname.Width = 150;
            // 
            // colPatContactNo
            // 
            this.colPatContactNo.HeaderText = "Contact Number";
            this.colPatContactNo.Name = "colPatContactNo";
            this.colPatContactNo.ReadOnly = true;
            this.colPatContactNo.Width = 150;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.Width = 150;
            // 
            // btnRemove
            // 
            this.btnRemove.ActiveControl = null;
            this.btnRemove.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRemove.Location = new System.Drawing.Point(242, 332);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 39);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.UseCustomBackColor = true;
            this.btnRemove.UseCustomForeColor = true;
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // CtrlDeletePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdvSearchPat);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.gboPatient);
            this.Name = "CtrlDeletePatient";
            this.Size = new System.Drawing.Size(609, 391);
            this.gboPatient.ResumeLayout(false);
            this.gboPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnAdvSearchPat;
        private MetroFramework.Controls.MetroLabel lblPatient;
        private System.Windows.Forms.GroupBox gboPatient;
        private System.Windows.Forms.Button btnPatClear;
        private System.Windows.Forms.Button btnPatSearch;
        private MetroFramework.Controls.MetroTextBox textName;
        private MetroFramework.Controls.MetroLabel lblPatName;
        private MetroFramework.Controls.MetroGrid dgvPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private MetroFramework.Controls.MetroTile btnRemove;
    }
}
