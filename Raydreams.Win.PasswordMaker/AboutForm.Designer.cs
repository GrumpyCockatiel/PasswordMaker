namespace Raydreams.Win.PasswordMaker
{
	partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.titleLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.copyrightLabel = new System.Windows.Forms.Label();
			this.infoTextbox = new System.Windows.Forms.TextBox();
			this.companyLabel = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(12, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(100, 13);
			this.titleLabel.TabIndex = 1;
			this.titleLabel.Text = "Password Maker";
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.Location = new System.Drawing.Point(12, 69);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(45, 13);
			this.versionLabel.TabIndex = 4;
			this.versionLabel.Text = "Version:";
			// 
			// copyrightLabel
			// 
			this.copyrightLabel.AutoSize = true;
			this.copyrightLabel.Location = new System.Drawing.Point(12, 49);
			this.copyrightLabel.Name = "copyrightLabel";
			this.copyrightLabel.Size = new System.Drawing.Size(37, 13);
			this.copyrightLabel.TabIndex = 3;
			this.copyrightLabel.Text = "c2012";
			// 
			// infoTextbox
			// 
			this.infoTextbox.BackColor = System.Drawing.Color.White;
			this.infoTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.infoTextbox.Location = new System.Drawing.Point(12, 85);
			this.infoTextbox.Multiline = true;
			this.infoTextbox.Name = "infoTextbox";
			this.infoTextbox.ReadOnly = true;
			this.infoTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.infoTextbox.Size = new System.Drawing.Size(233, 86);
			this.infoTextbox.TabIndex = 7;
			this.infoTextbox.TabStop = false;
			this.infoTextbox.Text = "info";
			// 
			// companyLabel
			// 
			this.companyLabel.AutoSize = true;
			this.companyLabel.Location = new System.Drawing.Point(12, 29);
			this.companyLabel.Name = "companyLabel";
			this.companyLabel.Size = new System.Drawing.Size(99, 13);
			this.companyLabel.TabIndex = 8;
			this.companyLabel.TabStop = true;
			this.companyLabel.Text = "TAG Digital Studios";
			this.companyLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DoLaunchLink);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 186);
			this.Controls.Add(this.companyLabel);
			this.Controls.Add(this.infoTextbox);
			this.Controls.Add(this.copyrightLabel);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.titleLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About Password Maker";
			this.Load += new System.EventHandler(this.DoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Label copyrightLabel;
		private System.Windows.Forms.TextBox infoTextbox;
		private System.Windows.Forms.LinkLabel companyLabel;

    }
}