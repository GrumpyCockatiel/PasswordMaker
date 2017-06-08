using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Raydreams.Win.PasswordMaker
{
	public partial class MainForm: Form
	{
		private static readonly string decFormat = @"{0:D}{1}";
		private static readonly string hexFormat = @"{0:X2}{1}";
		private int _keySize = 0;
		private CipherMessage _msg = null;
		private SymmetricEncryptor _encryptor = null;
		private RNGCryptoServiceProvider _rnd = null;
		private TextBox _selectedField = null;
		
		/// <summary></summary>
		public MainForm()
		{
			InitializeComponent();
			this._rnd = new RNGCryptoServiceProvider();
		}

		/// <summary></summary>
		private void DoEncrypt( object sender, EventArgs e )
		{
			if ( String.IsNullOrEmpty( this.pwField.Text ) )
			{
				this._msg = null;
				return;
			}

			this._msg = this._encryptor.EncryptStringToBytes( this.pwField.Text.Trim(), this._keySize );

			this.FormatFields();
		}

		/// <summary></summary>
		private void DoLoad( object sender, EventArgs e )
		{
			// uncheck all
			foreach ( ToolStripMenuItem item in this.algoMenu.DropDownItems )
				item.Checked = false;

			// check the selected
			ToolStripMenuItem first = (ToolStripMenuItem)this.algoMenu.DropDownItems[0];
			first.Checked = true;

			SymmetricAlgoType algo =
				(SymmetricAlgoType)Enum.Parse( typeof( SymmetricAlgoType ), first.Tag.ToString(), true );

			// create a new encryptor
			this._encryptor = new SymmetricEncryptor( algo );

			// create key sizes
			this.PopulateKeyMenu();

			// set the key size
			this._keySize = Convert.ToInt32( ( (ToolStripMenuItem)this.keyMenu.DropDownItems[0] ).Tag );

			// init the seleted field
			this._selectedField = this.cipherField;
		}

		/// <summary></summary>
		private void FormatFields()
		{
			if ( this._msg == null )
			{
				this.cipherField.Text = String.Empty;
				this.keyField.Text = String.Empty;
				this.ivField.Text = String.Empty;
				return;
			}

			if ( this.decRadiobutton.Checked )
			{
				this.cipherField.Text = this.BytesToString( this._msg.CipherBytes, decFormat );
				this.keyField.Text = this.BytesToString( this._msg.Key, decFormat );
				this.ivField.Text = this.BytesToString( this._msg.IV, decFormat );
			}
			else if ( this.hexRadiobutton.Checked )
			{
				this.cipherField.Text = this.BytesToString( this._msg.CipherBytes, hexFormat );
				this.keyField.Text = this.BytesToString( this._msg.Key, hexFormat );
				this.ivField.Text = this.BytesToString( this._msg.IV, hexFormat );
			}
			else
			{
				this.cipherField.Text = Convert.ToBase64String(this._msg.CipherBytes);
				this.keyField.Text = Convert.ToBase64String( this._msg.Key);
				this.ivField.Text = Convert.ToBase64String( this._msg.IV);
			}
		}

		/// <summary></summary>
		private string BytesToString(byte[] bytes, string format)
		{
			StringBuilder sb = new StringBuilder();

			string delim = String.Empty;
			if ( this.spaceMenuitem.Checked && this.commaMenuItem.Checked )
				delim = ", ";
			else if ( this.spaceMenuitem.Checked )
				delim = " ";
			else if ( this.commaMenuItem.Checked )
				delim = ",";
			else
				delim = String.Empty;

			foreach ( byte b in bytes )
				sb.AppendFormat( format, b, delim );

			sb.Length -= delim.Length;
			return sb.ToString();
		}

		/// <summary></summary>
		private void DoChangeFormat( object sender, EventArgs e )
		{
			this.FormatFields();
		}

		/// <summary></summary>
		private void DoChangeAlgo( object sender, EventArgs e )
		{
			// release the old encryptor
			this._encryptor.Clear();

			// clear out the keys menu
			this.keyMenu.DropDownItems.Clear();

			// uncheck all
			foreach ( ToolStripMenuItem item in this.algoMenu.DropDownItems )
				item.Checked = false;

			// check the selected
			( (ToolStripMenuItem)sender ).Checked = true;

			SymmetricAlgoType algo = 
				(SymmetricAlgoType)Enum.Parse( typeof( SymmetricAlgoType ), ( (ToolStripMenuItem)sender ).Tag.ToString(), true );

			// create a new encryptor
			this._encryptor = new SymmetricEncryptor( algo );

			// create key sizes
			this.PopulateKeyMenu();
			
			// set the key size
			this._keySize = Convert.ToInt32( ( (ToolStripMenuItem)this.keyMenu.DropDownItems[0] ).Tag );
		}

		/// <summary></summary>
		private void DoChangeKeySize( object sender, EventArgs e )
		{
			// uncheck all
			foreach ( ToolStripMenuItem item in this.keyMenu.DropDownItems )
				item.Checked = false;

			// check the selected
			( (ToolStripMenuItem)sender ).Checked = true;

			this._keySize = Convert.ToInt32( ( (ToolStripMenuItem)sender ).Tag );
		}

		/// <summary></summary>
		private void DoCopy( object sender, EventArgs e )
		{
			Clipboard.SetText( this._selectedField.Text.Trim() );
		}

		/// <summary></summary>
		private void PopulateKeyMenu()
		{
			int keySize = this._encryptor.KeySizes.MaxSize;
			
			while ( keySize >= this._encryptor.KeySizes.MinSize )
			{
				ToolStripMenuItem newKeyMenuItem = new ToolStripMenuItem( keySize.ToString() );
				newKeyMenuItem.Tag = keySize;
				newKeyMenuItem.Click += new EventHandler( DoChangeKeySize );
				this.keyMenu.DropDownItems.Add( newKeyMenuItem );
				
				if ( this._encryptor.KeySizes.SkipSize < 1 )
					break;

				keySize -= this._encryptor.KeySizes.SkipSize;
			}

			// set the first key size menu item
			( (ToolStripMenuItem)this.keyMenu.DropDownItems[0] ).Checked = true;
		}

		/// <summary></summary>
		private void DoChangeDelim( object sender, EventArgs e )
		{
			this.FormatFields();
		}

		/// <summary></summary>
		private void OnSelectField( object sender, EventArgs e )
		{
			this._selectedField = (TextBox)sender;
		}

		/// <summary></summary>
		private void DoCreatePassword( object sender, EventArgs e )
		{
			string digits = @"0123456789";
			string letters = @"abcdefghijklmnopqrstuvwxyz";
			string special = @"~`!@#$%^&*()-_+={}[]|\:;'<>,.?/";

			StringBuilder set = new StringBuilder( letters );
			if ( this.upperMenuItem.Checked )
				set.Append( letters.ToUpper() );
			if ( this.digitsMenuItem.Checked )
				set.Append( digits );
			if ( this.specialMenuItem.Checked )
				set.Append( special );

			if ( !this.similarMenuItem.Checked )
			{
				set.Replace( "O", String.Empty );
				set.Replace( "l", String.Empty );
				set.Replace( "|", String.Empty );
			}

			// get password length
			int length = 8;
			if ( !Int32.TryParse( this.pwLengthField.Text, out length ) || length < 1 )
				length = 8;

			if ( length > 255 )
				length = 255;

			// get random bytes
			byte[] password = new byte[length];
			RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider();
			rnd.GetBytes( password );

			// normalize the bytes to the set range
			char[] pw = new char[length];
			
			for ( int i = 0; i < pw.Length; ++i )
			{
				pw[i] = set[ this.RandomInt(0, set.Length - 1) ];
			}

			this.pwField.Text = new String( pw );

			this.DoEncrypt( null, e );
		}

		/// <summary></summary>
		private int RandomInt(int low, int high)
		{
			byte[] seed = new byte[4];
			this._rnd.GetBytes( seed );
			Random r = new Random( BitConverter.ToInt32(seed, 0) );

			return r.Next(low, high + 1);
		}

		/// <summary></summary>
		private void DoShowAbout( object sender, EventArgs e )
		{
			AboutForm abt = new AboutForm();
			abt.ShowDialog( this );
		}

		/// <summary></summary>
		private void DoHelp( object sender, EventArgs e )
		{
			string path = String.Format( @"{0}\PasswordMaker.chm", System.Windows.Forms.Application.StartupPath );
			if (!File.Exists(path))
				path = String.Format( @"{0}\Help\PasswordMaker.chm", System.Windows.Forms.Application.StartupPath );
			Help.ShowHelp( this, path );
		}
	}
}