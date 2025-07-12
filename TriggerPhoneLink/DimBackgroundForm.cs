using System.Windows.Forms;
using System.Drawing;

namespace TriggerPhoneLink
{
    public class DimBackgroundForm : Form
    {
        public DimBackgroundForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.Opacity = 0.8; // you can adjust this to be lighter or darker
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = false; // ensure it's behind the modal
        }
    }
}
