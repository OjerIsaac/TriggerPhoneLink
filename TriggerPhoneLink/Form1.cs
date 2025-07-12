using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TriggerPhoneLink
{
    public partial class Form1 : Form
    {
        private Form dimBackground;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dimBackground = new DimBackgroundForm();
            dimBackground.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Legacy-compatible launch of Phone Link
                Process.Start("explorer.exe", "shell:appsFolder\\Microsoft.YourPhone_8wekyb3d8bbwe!App");

                // Close the modal immediately
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

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxShieldIcon_Click(object sender, EventArgs e)
        {

        }

        private void labelFeatures_Click(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click_3(object sender, EventArgs e)
        {

        }
    }
}
