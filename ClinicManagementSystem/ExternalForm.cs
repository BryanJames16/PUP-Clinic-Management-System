using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace ClinicManagementSystem
{
    class ExternalForm
    {
        public static DialogResult InputComboBox(ref int index, ref string value)
        {
            Form form = new Form();
            ComboBox cboChoice = new ComboBox();
            Label lblText = new Label();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            cboChoice.Items.Add("<Select one>");
            cboChoice.Items.Add("APPOINTMENT");
            cboChoice.Items.Add("WALK-IN");
            cboChoice.Items.Add("EMERGENCY");
            cboChoice.Items.Add("OTHERS");

            cboChoice.SelectedIndex = 0;
            cboChoice.DropDownStyle = ComboBoxStyle.DropDownList;

            form.Text = "Choose an option";
            lblText.Text = "Select a log type:";

            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            lblText.SetBounds(9, 20, 372, 13);
            cboChoice.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            lblText.AutoSize = true;
            cboChoice.Anchor = cboChoice.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { lblText, cboChoice, buttonOk, buttonCancel });
            form.ClientSize = new Size(Convert.ToInt32(Math.Max(300, lblText.Right + 10)), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = cboChoice.GetItemText(cboChoice.SelectedItem);
            index = cboChoice.SelectedIndex;
            return (dialogResult);
        }
    }
}
