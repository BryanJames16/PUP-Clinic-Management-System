using System;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                FormLogIn start = new FormLogIn();
                start.FormClosed += new FormClosedEventHandler(FormClosed);
                start.Show();

                Application.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknown exception was caught!\n" + ex.Message + "\nPlease contact the administrator!", 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // Main()

        static void FormClosed(object sender, FormClosedEventArgs evt)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        } // FormClosed()
    }
}
