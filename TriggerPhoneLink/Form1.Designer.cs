namespace TriggerPhoneLink
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Header elements
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox pictureBoxAppIcon;
        private System.Windows.Forms.Label labelHeaderTitle;
        private System.Windows.Forms.PictureBox pictureBoxShieldIcon;
        private System.Windows.Forms.PictureBox pictureBoxWindowsLogo;
        private System.Windows.Forms.Label labelSubtitle;

        // Main content
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelTitle2;
        private System.Windows.Forms.Label labelFeaturesHeader;
        private System.Windows.Forms.Label labelFeatures;
        private System.Windows.Forms.Button connectButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.labelHeaderTitle = new System.Windows.Forms.Label();
            this.pictureBoxWindowsLogo = new System.Windows.Forms.PictureBox();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.pictureBoxAppIcon = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelFeatures = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.labelFeaturesHeader = new System.Windows.Forms.Label();
            this.pictureBoxShieldIcon = new System.Windows.Forms.PictureBox();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWindowsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAppIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShieldIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.headerPanel.Controls.Add(this.labelHeaderTitle);
            this.headerPanel.Controls.Add(this.pictureBoxWindowsLogo);
            this.headerPanel.Controls.Add(this.labelSubtitle);
            this.headerPanel.Controls.Add(this.pictureBoxAppIcon);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(500, 88);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
            // 
            // labelHeaderTitle
            // 
            this.labelHeaderTitle.AutoSize = true;
            this.labelHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.labelHeaderTitle.Location = new System.Drawing.Point(47, 9);
            this.labelHeaderTitle.Name = "labelHeaderTitle";
            this.labelHeaderTitle.Size = new System.Drawing.Size(140, 32);
            this.labelHeaderTitle.TabIndex = 1;
            this.labelHeaderTitle.Text = "Phone Link";
            // 
            // pictureBoxWindowsLogo
            // 
            this.pictureBoxWindowsLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWindowsLogo.Image")));
            this.pictureBoxWindowsLogo.Location = new System.Drawing.Point(3, 43);
            this.pictureBoxWindowsLogo.Name = "pictureBoxWindowsLogo";
            this.pictureBoxWindowsLogo.Size = new System.Drawing.Size(42, 40);
            this.pictureBoxWindowsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWindowsLogo.TabIndex = 2;
            this.pictureBoxWindowsLogo.TabStop = false;
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelSubtitle.ForeColor = System.Drawing.Color.White;
            this.labelSubtitle.Location = new System.Drawing.Point(48, 53);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(117, 19);
            this.labelSubtitle.TabIndex = 3;
            this.labelSubtitle.Text = "Windows Security";
            // 
            // pictureBoxAppIcon
            // 
            this.pictureBoxAppIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAppIcon.Image")));
            this.pictureBoxAppIcon.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxAppIcon.Name = "pictureBoxAppIcon";
            this.pictureBoxAppIcon.Size = new System.Drawing.Size(42, 40);
            this.pictureBoxAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAppIcon.TabIndex = 0;
            this.pictureBoxAppIcon.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(48, 113);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(292, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Enhance Your Device Security";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDescription.Location = new System.Drawing.Point(20, 152);
            this.labelDescription.MaximumSize = new System.Drawing.Size(480, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(478, 40);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Link your phone to enable advanced security features and protect your digital ide" +
    "ntity across devices.";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click_2);
            // 
            // labelFeatures
            // 
            this.labelFeatures.AutoSize = true;
            this.labelFeatures.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelFeatures.Location = new System.Drawing.Point(20, 235);
            this.labelFeatures.MaximumSize = new System.Drawing.Size(480, 0);
            this.labelFeatures.Name = "labelFeatures";
            this.labelFeatures.Size = new System.Drawing.Size(280, 80);
            this.labelFeatures.TabIndex = 2;
            this.labelFeatures.Text = "✓ Cross-device authentication protection\n✓ Suspicious activity alerts in real-tim" +
    "e\n✓ Secure file sharing between devices\n✓ Enhanced network threat detection";
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.connectButton.FlatAppearance.BorderSize = 0;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.connectButton.ForeColor = System.Drawing.Color.White;
            this.connectButton.Location = new System.Drawing.Point(329, 380);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(150, 35);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect Phone";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // labelFeaturesHeader
            // 
            this.labelFeaturesHeader.AutoSize = true;
            this.labelFeaturesHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelFeaturesHeader.Location = new System.Drawing.Point(20, 208);
            this.labelFeaturesHeader.Name = "labelFeaturesHeader";
            this.labelFeaturesHeader.Size = new System.Drawing.Size(145, 23);
            this.labelFeaturesHeader.TabIndex = 2;
            this.labelFeaturesHeader.Text = "Security Benefits";
            this.labelFeaturesHeader.Click += new System.EventHandler(this.labelFeaturesHeader_Click);
            // 
            // pictureBoxShieldIcon
            // 
            this.pictureBoxShieldIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShieldIcon.Image")));
            this.pictureBoxShieldIcon.Location = new System.Drawing.Point(12, 107);
            this.pictureBoxShieldIcon.Name = "pictureBoxShieldIcon";
            this.pictureBoxShieldIcon.Size = new System.Drawing.Size(42, 42);
            this.pictureBoxShieldIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShieldIcon.TabIndex = 10;
            this.pictureBoxShieldIcon.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(501, 439);
            this.ControlBox = false;
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelFeaturesHeader);
            this.Controls.Add(this.labelFeatures);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.pictureBoxShieldIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Link";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWindowsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAppIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShieldIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
