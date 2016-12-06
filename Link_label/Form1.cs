using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Link_label
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.LinkLabel linkLabel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
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
   this.linkLabel1 = new System.Windows.Forms.LinkLabel();
   this.SuspendLayout();
   // 
   // linkLabel1
   // 
   this.linkLabel1.Location = new System.Drawing.Point(8, 16);
   this.linkLabel1.Name = "linkLabel1";
   this.linkLabel1.Size = new System.Drawing.Size(272, 152);
   this.linkLabel1.TabIndex = 0;
   this.linkLabel1.TabStop = true;
   this.linkLabel1.Text = "linkLabel1";
   this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 182);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.linkLabel1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.ResumeLayout(false);

  }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

  private void Form1_Load(object sender, System.EventArgs e)
  {
   linkLabel1.Text = "Sitemize girmek i�in buray� t�klay�n.\r\n" + 
    "Mail g�ndermek i�in  buray� t�klay�n.\r\n" + 
    "Hesap makinesini �al��t�rmak i�in  buray� t�klay�n.\r\n" + 
    "Harddiskin i�eri�ini g�rmek i�in  buray� t�klay�n.";
   linkLabel1.Links.Add(21, 6, "http://www.hakkarim.net");
   linkLabel1.Links.Add(60, 6, "mailto:ikaragulle@hotmail.com");
   linkLabel1.Links.Add(113, 6, "calc.exe");
   linkLabel1.Links.Add(165, 6, "c:\\");
   //Linkleri mavi g�ster
   linkLabel1.LinkColor = Color.Blue;
   //Gezilmi� linkleri k�rm�z� g�ster
   linkLabel1.VisitedLinkColor = Color.Red;
   //Aktif linkleri kahverengi g�ster
   linkLabel1.ActiveLinkColor = Color.Brown;
   //Linklerin alt�n� fare �zerine geldi�inde �iz
   linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
  }

  private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
  {
   //T�klanan linki ziyaret edilmi� renkle g�ster
   linkLabel1.Links[linkLabel1.Links.IndexOf(e.Link)].Visited = true;
   //Linki �al��t�r
   System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
  }
	}
}
