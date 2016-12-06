using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FareileÇizim
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
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
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Name = "Form1";
   this.Text = "Form1";
   this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
   this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);

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

  Graphics g;
  int x, y;
  private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   if (e.Button == MouseButtons.Left)
   {//Baþlangýç koordinatlarýný al
    x = e.X;
    y = e.Y;
   }
   if (e.Button == MouseButtons.Right)
   {//sað tuþla sil
    g = this.CreateGraphics();
    g.Clear(Color.Blue);//silerken maviye boyar
    g.Dispose();
   }
  }

  private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   if (e.Button == MouseButtons.Left)
   {//Sol tuþla elips çiz
    g = this.CreateGraphics();
    g.DrawEllipse(new Pen(Color.Yellow), 
     x - Math.Abs(x - e.X) / 2, 
     y - Math.Abs(y - e.Y) / 2, 
     Math.Abs(x - e.X), 
     Math.Abs(y - e.Y));
    g.Dispose();
   }
  }
	}
}
