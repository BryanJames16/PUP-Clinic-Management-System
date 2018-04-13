using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

/* Framework UI */
using MetroFramework;

namespace ClinicManagementSystem
{
    class Integrity
    {
        public static void GetExceptionDetails(Exception ex)
        {
            string report = "Exception:\n" + 
                            ex.Message + "\n" + 
                            ex.StackTrace;
            MessageBox.Show(report, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void TextChange_Name(object reciever)
        {
            try
            {
                MetroFramework.Controls.MetroTextBox sender = (MetroFramework.Controls.MetroTextBox)reciever;
                if (System.Text.RegularExpressions.Regex.IsMatch(sender.Text, "[^A-Za-z]"))
                {
                    sender.Text = sender.Text.Substring(0, sender.Text.Trim().Length - 1);
                    sender.Select(sender.Text.Trim().Length, 1);
                }
            }
            catch (Exception ex)
            {
                TextBox sender = (TextBox)reciever;
                if (System.Text.RegularExpressions.Regex.IsMatch(sender.Text, "[^A-Za-z]"))
                {
                    sender.Text = sender.Text.Substring(0, sender.Text.Trim().Length - 1);
                    sender.Select(sender.Text.Trim().Length, 1);
                }
            }
        }

        public static void TextChange_Number(object reciever)
        {
            try
            {
                MetroFramework.Controls.MetroTextBox sender = (MetroFramework.Controls.MetroTextBox)reciever;
                if (System.Text.RegularExpressions.Regex.IsMatch(sender.Text, "[^0-9]"))
                {
                    sender.Text = sender.Text.Substring(0, sender.Text.Trim().Length - 1);
                    sender.Select(sender.Text.Trim().Length, 1);
                }
            }
            catch (Exception ex)
            {
                TextBox sender = (TextBox)reciever;
                if (System.Text.RegularExpressions.Regex.IsMatch(sender.Text, "[^0-9]"))
                {
                    sender.Text = sender.Text.Substring(0, sender.Text.Trim().Length - 1);
                    sender.Select(sender.Text.Trim().Length, 1);
                }
            }
        }

        public static void ShowDuplicateDialog()
        {
            MessageBox.Show("Duplicate entries found! Please contact the administrator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInvalidTypeDialog()
        {
            MessageBox.Show("Invalid type! Please contact the administrator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowNoKeywordDialog()
        {
            MessageBox.Show("Please enter a valid search keyword!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static void CustomErrorMessage(string report)
        {
            MessageBox.Show(report, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool NumberOnly(string currentString)
        {
            bool isNumber = true;

            if (Char.IsLetter(currentString.Trim()[currentString.Trim().Length - 1]) ||
                Char.IsSymbol(currentString.Trim()[currentString.Trim().Length - 1]) ||
                Char.IsPunctuation(currentString.Trim()[currentString.Trim().Length - 1]))
            {
                isNumber = false;
            }

            return (isNumber);
        }

        public static bool LetterOnly(string currentString)
        {
            bool isLetter = true;

            if (Char.IsDigit(currentString.Trim()[currentString.Trim().Length - 1]) ||
                Char.IsSymbol(currentString.Trim()[currentString.Trim().Length - 1]) ||
                Char.IsPunctuation(currentString.Trim()[currentString.Trim().Length - 1]))
            {
                isLetter = false;
            }

            return (isLetter);
        }

        public static bool AlphaNumericOnly(string currentString)
        {
            bool isAlNum = true;

            if (Char.IsSymbol(currentString.Trim()[currentString.Trim().Length - 1]) ||
                Char.IsPunctuation(currentString.Trim()[currentString.Trim().Length - 1]))
            {
                isAlNum = false;
            }

            return (isAlNum);
        }

        public static bool NoSpaceOnly(string currentString)
        {
            bool space = false;

            if (Char.IsWhiteSpace(currentString.Trim()[currentString.Trim().Length - 1]))
            {
                space = true;
            }

            return (!space);
        }
    }
}
