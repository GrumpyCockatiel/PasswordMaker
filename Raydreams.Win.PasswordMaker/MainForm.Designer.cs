namespace Raydreams.Win.PasswordMaker
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pwField = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cipherField = new System.Windows.Forms.TextBox();
			this.keyField = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ivField = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.displayPanel = new System.Windows.Forms.GroupBox();
			this.baseRadiobutton = new System.Windows.Forms.RadioButton();
			this.hexRadiobutton = new System.Windows.Forms.RadioButton();
			this.decRadiobutton = new System.Windows.Forms.RadioButton();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.copyMenuitem = new System.Windows.Forms.ToolStripMenuItem();
			this.algoMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.aesMenuitem = new System.Windows.Forms.ToolStripMenuItem();
			this.tripleDesMenuitem = new System.Windows.Forms.ToolStripMenuItem();
			this.desMenuitem = new System.Windows.Forms.ToolStripMenuItem();
			this.rc2Menuitem = new System.Windows.Forms.ToolStripMenuItem();
			this.keyMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.delimitorMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.spaceMenuitem = new System.Windows.Forms.ToolStripMenuItem();
			this.commaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.upperMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.digitsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.specialMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.similarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutPasswordMakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.randomButton = new System.Windows.Forms.Button();
			this.pwLengthField = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.randomPanel = new System.Windows.Forms.GroupBox();
			this.displayPanel.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.randomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// pwField
			// 
			this.pwField.Font = new System.Drawing.Font( "Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			this.pwField.Location = new System.Drawing.Point( 12, 43 );
			this.pwField.MaxLength = 255;
			this.pwField.Name = "pwField";
			this.pwField.Size = new System.Drawing.Size( 377, 21 );
			this.pwField.TabIndex = 0;
			this.pwField.Text = "password";
			this.pwField.Enter += new System.EventHandler( this.OnSelectField );
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 9, 27 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 53, 13 );
			this.label1.TabIndex = 1;
			this.label1.Text = "Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 9, 129 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 61, 13 );
			this.label2.TabIndex = 4;
			this.label2.Text = "Cipher Text";
			// 
			// cipherField
			// 
			this.cipherField.Location = new System.Drawing.Point( 12, 145 );
			this.cipherField.Name = "cipherField";
			this.cipherField.ReadOnly = true;
			this.cipherField.Size = new System.Drawing.Size( 377, 20 );
			this.cipherField.TabIndex = 3;
			this.cipherField.Enter += new System.EventHandler( this.OnSelectField );
			// 
			// keyField
			// 
			this.keyField.Location = new System.Drawing.Point( 12, 184 );
			this.keyField.Multiline = true;
			this.keyField.Name = "keyField";
			this.keyField.ReadOnly = true;
			this.keyField.Size = new System.Drawing.Size( 377, 32 );
			this.keyField.TabIndex = 5;
			this.keyField.Enter += new System.EventHandler( this.OnSelectField );
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point( 9, 168 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size( 61, 13 );
			this.label3.TabIndex = 6;
			this.label3.Text = "Private Key";
			// 
			// ivField
			// 
			this.ivField.Location = new System.Drawing.Point( 12, 235 );
			this.ivField.Name = "ivField";
			this.ivField.ReadOnly = true;
			this.ivField.Size = new System.Drawing.Size( 377, 20 );
			this.ivField.TabIndex = 7;
			this.ivField.Enter += new System.EventHandler( this.OnSelectField );
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point( 9, 219 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size( 55, 13 );
			this.label4.TabIndex = 8;
			this.label4.Text = "Init Vector";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point( 314, 261 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size( 75, 23 );
			this.button1.TabIndex = 9;
			this.button1.Text = "Encrypt";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler( this.DoEncrypt );
			// 
			// displayPanel
			// 
			this.displayPanel.Controls.Add( this.baseRadiobutton );
			this.displayPanel.Controls.Add( this.hexRadiobutton );
			this.displayPanel.Controls.Add( this.decRadiobutton );
			this.displayPanel.Location = new System.Drawing.Point( 12, 69 );
			this.displayPanel.Name = "displayPanel";
			this.displayPanel.Size = new System.Drawing.Size( 230, 57 );
			this.displayPanel.TabIndex = 2;
			this.displayPanel.TabStop = false;
			this.displayPanel.Text = "Representation";
			// 
			// baseRadiobutton
			// 
			this.baseRadiobutton.AutoSize = true;
			this.baseRadiobutton.Location = new System.Drawing.Point( 121, 24 );
			this.baseRadiobutton.Name = "baseRadiobutton";
			this.baseRadiobutton.Size = new System.Drawing.Size( 61, 17 );
			this.baseRadiobutton.TabIndex = 2;
			this.baseRadiobutton.Text = "Base64";
			this.baseRadiobutton.UseVisualStyleBackColor = true;
			this.baseRadiobutton.Click += new System.EventHandler( this.DoChangeFormat );
			// 
			// hexRadiobutton
			// 
			this.hexRadiobutton.AutoSize = true;
			this.hexRadiobutton.Location = new System.Drawing.Point( 73, 24 );
			this.hexRadiobutton.Name = "hexRadiobutton";
			this.hexRadiobutton.Size = new System.Drawing.Size( 44, 17 );
			this.hexRadiobutton.TabIndex = 1;
			this.hexRadiobutton.Text = "Hex";
			this.hexRadiobutton.UseVisualStyleBackColor = true;
			this.hexRadiobutton.Click += new System.EventHandler( this.DoChangeFormat );
			// 
			// decRadiobutton
			// 
			this.decRadiobutton.AutoSize = true;
			this.decRadiobutton.Checked = true;
			this.decRadiobutton.Location = new System.Drawing.Point( 6, 24 );
			this.decRadiobutton.Name = "decRadiobutton";
			this.decRadiobutton.Size = new System.Drawing.Size( 63, 17 );
			this.decRadiobutton.TabIndex = 0;
			this.decRadiobutton.TabStop = true;
			this.decRadiobutton.Text = "Decimal";
			this.decRadiobutton.UseVisualStyleBackColor = true;
			this.decRadiobutton.Click += new System.EventHandler( this.DoChangeFormat );
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.editMenu,
            this.algoMenu,
            this.keyMenu,
            this.delimitorMenu,
            this.randomToolStripMenuItem,
            this.helpToolStripMenuItem} );
			this.menuStrip1.Location = new System.Drawing.Point( 0, 0 );
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size( 401, 24 );
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// editMenu
			// 
			this.editMenu.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.copyMenuitem} );
			this.editMenu.Name = "editMenu";
			this.editMenu.Size = new System.Drawing.Size( 37, 20 );
			this.editMenu.Text = "Edit";
			// 
			// copyMenuitem
			// 
			this.copyMenuitem.Name = "copyMenuitem";
			this.copyMenuitem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C ) ) );
			this.copyMenuitem.Size = new System.Drawing.Size( 149, 22 );
			this.copyMenuitem.Text = "Copy";
			this.copyMenuitem.Click += new System.EventHandler( this.DoCopy );
			// 
			// algoMenu
			// 
			this.algoMenu.CheckOnClick = true;
			this.algoMenu.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.aesMenuitem,
            this.tripleDesMenuitem,
            this.desMenuitem,
            this.rc2Menuitem} );
			this.algoMenu.Name = "algoMenu";
			this.algoMenu.Size = new System.Drawing.Size( 64, 20 );
			this.algoMenu.Text = "Algorithm";
			// 
			// aesMenuitem
			// 
			this.aesMenuitem.Checked = true;
			this.aesMenuitem.CheckOnClick = true;
			this.aesMenuitem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.aesMenuitem.Name = "aesMenuitem";
			this.aesMenuitem.Size = new System.Drawing.Size( 146, 22 );
			this.aesMenuitem.Tag = "AES";
			this.aesMenuitem.Text = "AES/Rijndael";
			this.aesMenuitem.Click += new System.EventHandler( this.DoChangeAlgo );
			// 
			// tripleDesMenuitem
			// 
			this.tripleDesMenuitem.Name = "tripleDesMenuitem";
			this.tripleDesMenuitem.Size = new System.Drawing.Size( 146, 22 );
			this.tripleDesMenuitem.Tag = "TripleDES";
			this.tripleDesMenuitem.Text = "TripleDES";
			this.tripleDesMenuitem.Click += new System.EventHandler( this.DoChangeAlgo );
			// 
			// desMenuitem
			// 
			this.desMenuitem.CheckOnClick = true;
			this.desMenuitem.Name = "desMenuitem";
			this.desMenuitem.Size = new System.Drawing.Size( 146, 22 );
			this.desMenuitem.Tag = "DES";
			this.desMenuitem.Text = "DES";
			this.desMenuitem.Click += new System.EventHandler( this.DoChangeAlgo );
			// 
			// rc2Menuitem
			// 
			this.rc2Menuitem.Name = "rc2Menuitem";
			this.rc2Menuitem.Size = new System.Drawing.Size( 146, 22 );
			this.rc2Menuitem.Tag = "RC2";
			this.rc2Menuitem.Text = "RC2";
			this.rc2Menuitem.Click += new System.EventHandler( this.DoChangeAlgo );
			// 
			// keyMenu
			// 
			this.keyMenu.Name = "keyMenu";
			this.keyMenu.Size = new System.Drawing.Size( 59, 20 );
			this.keyMenu.Text = "Key Size";
			// 
			// delimitorMenu
			// 
			this.delimitorMenu.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.spaceMenuitem,
            this.commaMenuItem} );
			this.delimitorMenu.Name = "delimitorMenu";
			this.delimitorMenu.Size = new System.Drawing.Size( 60, 20 );
			this.delimitorMenu.Text = "Delimiter";
			// 
			// spaceMenuitem
			// 
			this.spaceMenuitem.Checked = true;
			this.spaceMenuitem.CheckOnClick = true;
			this.spaceMenuitem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.spaceMenuitem.Name = "spaceMenuitem";
			this.spaceMenuitem.Size = new System.Drawing.Size( 152, 22 );
			this.spaceMenuitem.Text = "Space";
			this.spaceMenuitem.Click += new System.EventHandler( this.DoChangeDelim );
			// 
			// commaMenuItem
			// 
			this.commaMenuItem.CheckOnClick = true;
			this.commaMenuItem.Name = "commaMenuItem";
			this.commaMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.commaMenuItem.Text = "Comma";
			this.commaMenuItem.Click += new System.EventHandler( this.DoChangeDelim );
			// 
			// randomToolStripMenuItem
			// 
			this.randomToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.upperMenuItem,
            this.digitsMenuItem,
            this.specialMenuItem,
            this.similarMenuItem} );
			this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
			this.randomToolStripMenuItem.Size = new System.Drawing.Size( 58, 20 );
			this.randomToolStripMenuItem.Text = "Random";
			// 
			// upperMenuItem
			// 
			this.upperMenuItem.Checked = true;
			this.upperMenuItem.CheckOnClick = true;
			this.upperMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.upperMenuItem.Name = "upperMenuItem";
			this.upperMenuItem.Size = new System.Drawing.Size( 174, 22 );
			this.upperMenuItem.Text = "Uppercase";
			// 
			// digitsMenuItem
			// 
			this.digitsMenuItem.Checked = true;
			this.digitsMenuItem.CheckOnClick = true;
			this.digitsMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.digitsMenuItem.Name = "digitsMenuItem";
			this.digitsMenuItem.Size = new System.Drawing.Size( 174, 22 );
			this.digitsMenuItem.Text = "Digits";
			// 
			// specialMenuItem
			// 
			this.specialMenuItem.Checked = true;
			this.specialMenuItem.CheckOnClick = true;
			this.specialMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.specialMenuItem.Name = "specialMenuItem";
			this.specialMenuItem.Size = new System.Drawing.Size( 174, 22 );
			this.specialMenuItem.Text = "Special Characters";
			// 
			// similarMenuItem
			// 
			this.similarMenuItem.CheckOnClick = true;
			this.similarMenuItem.Name = "similarMenuItem";
			this.similarMenuItem.Size = new System.Drawing.Size( 174, 22 );
			this.similarMenuItem.Text = "Similar Characters";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.aboutPasswordMakerToolStripMenuItem} );
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size( 40, 20 );
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// contentsToolStripMenuItem
			// 
			this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
			this.contentsToolStripMenuItem.Size = new System.Drawing.Size( 195, 22 );
			this.contentsToolStripMenuItem.Text = "Contents";
			this.contentsToolStripMenuItem.Click += new System.EventHandler( this.DoHelp );
			// 
			// aboutPasswordMakerToolStripMenuItem
			// 
			this.aboutPasswordMakerToolStripMenuItem.Name = "aboutPasswordMakerToolStripMenuItem";
			this.aboutPasswordMakerToolStripMenuItem.Size = new System.Drawing.Size( 195, 22 );
			this.aboutPasswordMakerToolStripMenuItem.Text = "About Password Maker";
			this.aboutPasswordMakerToolStripMenuItem.Click += new System.EventHandler( this.DoShowAbout );
			// 
			// randomButton
			// 
			this.randomButton.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			this.randomButton.Location = new System.Drawing.Point( 6, 28 );
			this.randomButton.Name = "randomButton";
			this.randomButton.Size = new System.Drawing.Size( 62, 23 );
			this.randomButton.TabIndex = 11;
			this.randomButton.Text = "Create";
			this.randomButton.UseVisualStyleBackColor = true;
			this.randomButton.Click += new System.EventHandler( this.DoCreatePassword );
			// 
			// pwLengthField
			// 
			this.pwLengthField.Location = new System.Drawing.Point( 90, 31 );
			this.pwLengthField.MaxLength = 3;
			this.pwLengthField.Name = "pwLengthField";
			this.pwLengthField.Size = new System.Drawing.Size( 44, 20 );
			this.pwLengthField.TabIndex = 12;
			this.pwLengthField.Text = "8";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point( 91, 11 );
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size( 43, 13 );
			this.label5.TabIndex = 13;
			this.label5.Text = "Length:";
			// 
			// randomPanel
			// 
			this.randomPanel.Controls.Add( this.randomButton );
			this.randomPanel.Controls.Add( this.pwLengthField );
			this.randomPanel.Controls.Add( this.label5 );
			this.randomPanel.Location = new System.Drawing.Point( 248, 69 );
			this.randomPanel.Name = "randomPanel";
			this.randomPanel.Size = new System.Drawing.Size( 141, 57 );
			this.randomPanel.TabIndex = 14;
			this.randomPanel.TabStop = false;
			this.randomPanel.Text = "Random";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 401, 296 );
			this.Controls.Add( this.randomPanel );
			this.Controls.Add( this.displayPanel );
			this.Controls.Add( this.button1 );
			this.Controls.Add( this.ivField );
			this.Controls.Add( this.label4 );
			this.Controls.Add( this.keyField );
			this.Controls.Add( this.label3 );
			this.Controls.Add( this.cipherField );
			this.Controls.Add( this.label2 );
			this.Controls.Add( this.label1 );
			this.Controls.Add( this.pwField );
			this.Controls.Add( this.menuStrip1 );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Password Maker";
			this.Load += new System.EventHandler( this.DoLoad );
			this.displayPanel.ResumeLayout( false );
			this.displayPanel.PerformLayout();
			this.menuStrip1.ResumeLayout( false );
			this.menuStrip1.PerformLayout();
			this.randomPanel.ResumeLayout( false );
			this.randomPanel.PerformLayout();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox pwField;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox cipherField;
		private System.Windows.Forms.TextBox keyField;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ivField;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox displayPanel;
		private System.Windows.Forms.RadioButton baseRadiobutton;
		private System.Windows.Forms.RadioButton hexRadiobutton;
		private System.Windows.Forms.RadioButton decRadiobutton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem editMenu;
		private System.Windows.Forms.ToolStripMenuItem algoMenu;
		private System.Windows.Forms.ToolStripMenuItem aesMenuitem;
		private System.Windows.Forms.ToolStripMenuItem desMenuitem;
		private System.Windows.Forms.ToolStripMenuItem keyMenu;
		private System.Windows.Forms.ToolStripMenuItem copyMenuitem;
		private System.Windows.Forms.ToolStripMenuItem tripleDesMenuitem;
		private System.Windows.Forms.ToolStripMenuItem rc2Menuitem;
		private System.Windows.Forms.ToolStripMenuItem delimitorMenu;
		private System.Windows.Forms.ToolStripMenuItem spaceMenuitem;
		private System.Windows.Forms.ToolStripMenuItem commaMenuItem;
		private System.Windows.Forms.Button randomButton;
		private System.Windows.Forms.TextBox pwLengthField;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox randomPanel;
		private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem upperMenuItem;
		private System.Windows.Forms.ToolStripMenuItem digitsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem specialMenuItem;
		private System.Windows.Forms.ToolStripMenuItem similarMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutPasswordMakerToolStripMenuItem;
	}
}

