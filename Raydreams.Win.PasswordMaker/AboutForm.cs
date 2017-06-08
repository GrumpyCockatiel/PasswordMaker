using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Raydreams.Win.PasswordMaker
{
    /// <summary>displays the about form</summary>
    public partial class AboutForm : Form
    {
		private static readonly string _webUrl = @"http://blog.raydreams.com/";

		/// <summary>Constructor</summary>
		public AboutForm()
        {
            InitializeComponent();
        }

		/// <summary></summary>
		private void DoLoad( object sender, EventArgs e )
		{
			try
			{
				// get the assembly
				Assembly aERPS = Assembly.GetExecutingAssembly();

				// get and set custom attributes
				object[] attributes = aERPS.GetCustomAttributes( false );

				foreach ( object attr in attributes )
				{
					if ( attr is AssemblyCopyrightAttribute )
						this.copyrightLabel.Text = ( (AssemblyCopyrightAttribute)attr ).Copyright;
					else if ( attr is AssemblyCompanyAttribute )
						this.companyLabel.Text = ( (AssemblyCompanyAttribute)attr ).Company;
					else if ( attr is AssemblyProductAttribute )
					{
						this.titleLabel.Text = ( (AssemblyProductAttribute)attr ).Product;
						this.Text = String.Format( "About {0}", this.titleLabel.Text );
					}
				}

				// get standard attributes
				this.versionLabel.Text = String.Format( "Version:{0}", aERPS.GetName().Version );

				// put stuff in the textbox
				StringBuilder sb = new StringBuilder();
				sb.AppendFormat( "{0}{1}", aERPS.FullName, Environment.NewLine );
				this.infoTextbox.Text = sb.ToString();

				// add link to link label
				this.companyLabel.Links.Add( 0, this.companyLabel.Text.Length, _webUrl );
			}
			catch ( System.Exception exp )
			{
				throw exp;
			}
		}
		
		private void DoLaunchLink( object sender, LinkLabelLinkClickedEventArgs e )
		{
			// determine which link was clicked within the LinkLabel.
			this.companyLabel.Links[0].Visited = true;

			// get link data as string
			string target = e.Link.LinkData as string;

			// if the value looks like a URL, navigate to it.
			if ( !String.IsNullOrEmpty(target) )
			{
				System.Diagnostics.Process.Start( target );
			}

		}

    }
}