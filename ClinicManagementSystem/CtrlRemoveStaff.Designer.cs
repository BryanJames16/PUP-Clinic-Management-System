namespace ClinicManagementSystem
{
    partial class CtrlRemoveStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlRemoveStaff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStaffID = new MetroFramework.Controls.MetroLabel();
            this.textStaffID = new MetroFramework.Controls.MetroTextBox();
            this.lblStaffLastName = new MetroFramework.Controls.MetroLabel();
            this.textStaffLastName = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            this.btnClear = new MetroFramework.Controls.MetroTile();
            this.dgvList = new MetroFramework.Controls.MetroGrid();
            this.colStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new MetroFramework.Controls.MetroTile();
            this.btnRemove = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(39, 29);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(54, 19);
            this.lblStaffID.TabIndex = 0;
            this.lblStaffID.Text = "Staff ID:";
            this.lblStaffID.UseCustomBackColor = true;
            this.lblStaffID.UseCustomForeColor = true;
            // 
            // textStaffID
            // 
            this.textStaffID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.textStaffID.CustomButton.Image = null;
            this.textStaffID.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.textStaffID.CustomButton.Name = "";
            this.textStaffID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textStaffID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textStaffID.CustomButton.TabIndex = 1;
            this.textStaffID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textStaffID.CustomButton.UseSelectable = true;
            this.textStaffID.CustomButton.Visible = false;
            this.textStaffID.Lines = new string[0];
            this.textStaffID.Location = new System.Drawing.Point(157, 29);
            this.textStaffID.MaxLength = 32767;
            this.textStaffID.Name = "textStaffID";
            this.textStaffID.PasswordChar = '\0';
            this.textStaffID.PromptText = "2014-DOCT-MN-0";
            this.textStaffID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textStaffID.SelectedText = "";
            this.textStaffID.SelectionLength = 0;
            this.textStaffID.SelectionStart = 0;
            this.textStaffID.ShortcutsEnabled = true;
            this.textStaffID.Size = new System.Drawing.Size(250, 23);
            this.textStaffID.TabIndex = 1;
            this.textStaffID.UseSelectable = true;
            this.textStaffID.WaterMark = "2014-DOCT-MN-0";
            this.textStaffID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textStaffID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblStaffLastName
            // 
            this.lblStaffLastName.AutoSize = true;
            this.lblStaffLastName.Location = new System.Drawing.Point(39, 72);
            this.lblStaffLastName.Name = "lblStaffLastName";
            this.lblStaffLastName.Size = new System.Drawing.Size(78, 19);
            this.lblStaffLastName.TabIndex = 2;
            this.lblStaffLastName.Text = "Staff Name:";
            this.lblStaffLastName.UseCustomBackColor = true;
            // 
            // textStaffLastName
            // 
            this.textStaffLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.textStaffLastName.CustomButton.Image = null;
            this.textStaffLastName.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.textStaffLastName.CustomButton.Name = "";
            this.textStaffLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textStaffLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textStaffLastName.CustomButton.TabIndex = 1;
            this.textStaffLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textStaffLastName.CustomButton.UseSelectable = true;
            this.textStaffLastName.CustomButton.Visible = false;
            this.textStaffLastName.Lines = new string[0];
            this.textStaffLastName.Location = new System.Drawing.Point(157, 72);
            this.textStaffLastName.MaxLength = 32767;
            this.textStaffLastName.Name = "textStaffLastName";
            this.textStaffLastName.PasswordChar = '\0';
            this.textStaffLastName.PromptText = "DE VERA";
            this.textStaffLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textStaffLastName.SelectedText = "";
            this.textStaffLastName.SelectionLength = 0;
            this.textStaffLastName.SelectionStart = 0;
            this.textStaffLastName.ShortcutsEnabled = true;
            this.textStaffLastName.Size = new System.Drawing.Size(250, 23);
            this.textStaffLastName.TabIndex = 3;
            this.textStaffLastName.UseSelectable = true;
            this.textStaffLastName.WaterMark = "DE VERA";
            this.textStaffLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textStaffLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveControl = null;
            this.btnSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSearch.Location = new System.Drawing.Point(321, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 37);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.TileImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.TileImage")));
            this.btnSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseCustomForeColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseTileImage = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.ActiveControl = null;
            this.btnClear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnClear.Location = new System.Drawing.Point(148, 111);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 37);
            this.btnClear.TabIndex = 5;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.TileImage = ((System.Drawing.Image)(resources.GetObject("btnClear.TileImage")));
            this.btnClear.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.UseCustomBackColor = true;
            this.btnClear.UseCustomForeColor = true;
            this.btnClear.UseSelectable = true;
            this.btnClear.UseTileImage = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaffID,
            this.colStaffLast,
            this.colFirst,
            this.colGender,
            this.colContact,
            this.colUsername,
            this.colPassword,
            this.colPosition});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvList.Location = new System.Drawing.Point(39, 184);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(490, 150);
            this.dgvList.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvList.TabIndex = 6;
            this.dgvList.UseStyleColors = true;
            // 
            // colStaffID
            // 
            this.colStaffID.HeaderText = "Staff ID";
            this.colStaffID.Name = "colStaffID";
            this.colStaffID.ReadOnly = true;
            // 
            // colStaffLast
            // 
            this.colStaffLast.HeaderText = "Last Name";
            this.colStaffLast.Name = "colStaffLast";
            this.colStaffLast.ReadOnly = true;
            // 
            // colFirst
            // 
            this.colFirst.HeaderText = "First Name";
            this.colFirst.Name = "colFirst";
            this.colFirst.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // colContact
            // 
            this.colContact.HeaderText = "Contact Number";
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            // 
            // colPassword
            // 
            this.colPassword.HeaderText = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            // 
            // colPosition
            // 
            this.colPosition.HeaderText = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            // 
            // btnReset
            // 
            this.btnReset.ActiveControl = null;
            this.btnReset.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReset.Location = new System.Drawing.Point(157, 358);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 37);
            this.btnReset.TabIndex = 7;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.TileImage = ((System.Drawing.Image)(resources.GetObject("btnReset.TileImage")));
            this.btnReset.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.UseCustomBackColor = true;
            this.btnReset.UseCustomForeColor = true;
            this.btnReset.UseSelectable = true;
            this.btnReset.UseTileImage = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ActiveControl = null;
            this.btnRemove.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRemove.Location = new System.Drawing.Point(333, 358);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 37);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.TileImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.TileImage")));
            this.btnRemove.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.UseCustomBackColor = true;
            this.btnRemove.UseCustomForeColor = true;
            this.btnRemove.UseSelectable = true;
            this.btnRemove.UseTileImage = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // CtrlRemoveStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textStaffLastName);
            this.Controls.Add(this.lblStaffLastName);
            this.Controls.Add(this.textStaffID);
            this.Controls.Add(this.lblStaffID);
            this.Name = "CtrlRemoveStaff";
            this.Size = new System.Drawing.Size(576, 430);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblStaffID;
        private MetroFramework.Controls.MetroTextBox textStaffID;
        private MetroFramework.Controls.MetroLabel lblStaffLastName;
        private MetroFramework.Controls.MetroTextBox textStaffLastName;
        private MetroFramework.Controls.MetroTile btnSearch;
        private MetroFramework.Controls.MetroTile btnClear;
        private MetroFramework.Controls.MetroGrid dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private MetroFramework.Controls.MetroTile btnReset;
        private MetroFramework.Controls.MetroTile btnRemove;

    }
}
