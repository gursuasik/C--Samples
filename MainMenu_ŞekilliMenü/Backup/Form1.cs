using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MainMenu_ÞekilliMenü
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.MenuItem Mn_Elips;
  internal System.Windows.Forms.MenuItem Mn_Dikdörtgen;
  internal System.Windows.Forms.MainMenu mainMenu1;
  internal System.Windows.Forms.MenuItem MenuItem1;
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
   this.Mn_Elips = new System.Windows.Forms.MenuItem();
   this.Mn_Dikdörtgen = new System.Windows.Forms.MenuItem();
   this.mainMenu1 = new System.Windows.Forms.MainMenu();
   this.MenuItem1 = new System.Windows.Forms.MenuItem();
   // 
   // Mn_Elips
   // 
   this.Mn_Elips.Index = 1;
   this.Mn_Elips.OwnerDraw = true;
   this.Mn_Elips.Text = "Elips";
   this.Mn_Elips.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Mn_Elips_DrawItem);
   this.Mn_Elips.Click += new System.EventHandler(this.Mn_Elips_Click);
   this.Mn_Elips.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.Mn_Elips_MeasureItem);
   // 
   // Mn_Dikdörtgen
   // 
   this.Mn_Dikdörtgen.Index = 0;
   this.Mn_Dikdörtgen.OwnerDraw = true;
   this.Mn_Dikdörtgen.Text = "Dikdörtgen";
   this.Mn_Dikdörtgen.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Mn_Dikdörtgen_DrawItem);
   this.Mn_Dikdörtgen.Click += new System.EventHandler(this.Mn_Dikdörtgen_Click);
   this.Mn_Dikdörtgen.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.Mn_Dikdörtgen_MeasureItem);
   // 
   // mainMenu1
   // 
   this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.MenuItem1});
   // 
   // MenuItem1
   // 
   this.MenuItem1.Index = 0;
   this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.Mn_Dikdörtgen,
                                                                          this.Mn_Elips});
   this.MenuItem1.Text = "Þekil";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Menu = this.mainMenu1;
   this.Name = "Form1";
   this.Text = "Form1";

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

  private void Mn_Dikdörtgen_Click(object sender, System.EventArgs e)
  {
   Graphics g;
   g = this.CreateGraphics();
   Random r=new Random();
   g.FillRectangle(new SolidBrush(Color.FromArgb(r.Next(255), 
    r.Next(255) , 
    r.Next(255))), 
    r.Next(this.Width / 2), r.Next(this.Height / 2), 
    r.Next(this.Width / 2) , r.Next(this.Height / 2));
   g.Dispose();
  }

  private void Mn_Elips_Click(object sender, System.EventArgs e)
  {
   Graphics g;
   g = this.CreateGraphics();
   Random r=new Random();
   g.FillEllipse(new SolidBrush(Color.FromArgb(r.Next(255), 
    r.Next(255) , 
    r.Next(255))), 
    r.Next(this.Width / 2), r.Next(this.Height / 2), 
    r.Next(this.Width / 2) , r.Next(this.Height / 2));
   g.Dispose();
  }

  private void Mn_Dikdörtgen_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
    e.Graphics.FillRectangle(new SolidBrush(Color.Red), 
                           e.Bounds.Left, e.Bounds.Top,
                           e.Bounds.Width, e.Bounds.Height);
  }

  private void Mn_Elips_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   e.Graphics.FillEllipse(new SolidBrush(Color.Red), 
    e.Bounds.Left, e.Bounds.Top,
    e.Bounds.Width, e.Bounds.Height);
  }

  private void Mn_Dikdörtgen_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
  {
   e.ItemHeight = 30;
   e.ItemWidth = 100;
  }

  private void Mn_Elips_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
  {
   e.ItemHeight = 30;
   e.ItemWidth = 100;
  }
	}
}
