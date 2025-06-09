using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TriggerPhoneLink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool launched = false;

                // Try the URI method first
                try
                {
                    Process.Start("ms-phone:");
                    launched = true;
                }
                catch
                {
                    // URI might not be registered on all systems
                }

                // Fallback: Launch via shell:appsFolder
                if (!launched)
                {
                    Process.Start("explorer.exe", "shell:appsFolder\\Microsoft.YourPhone_8wekyb3d8bbwe!App");
                }

                // Close the modal either way
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch Phone Link. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelHeaderTitle_Click(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click_1(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click_2(object sender, EventArgs e)
        {

        }

        private void labelFeaturesHeader_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFeaturesIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
