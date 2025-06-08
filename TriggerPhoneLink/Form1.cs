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
                // Launch Phone Link
                System.Diagnostics.Process.Start("ms-phone:");

                // Close the modal
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
