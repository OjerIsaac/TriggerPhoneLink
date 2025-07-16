using System;
using System.Windows.Forms;

namespace TriggerPhoneLink
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DimBackgroundForm dimBackground = new DimBackgroundForm();
            dimBackground.Show(); // Show the dimmer, non-modal

            Form1 mainForm = new Form1(dimBackground); // Pass dimBackground to Form1

            mainForm.ShowDialog(); // This locks the focus to Form1

            // After Form1 is closed, close the background
            dimBackground.Close();
        }
    }
}
