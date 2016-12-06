using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Çizim_RotateTransform
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Timer timer1;
  private System.ComponentModel.IContainer components;

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
   this.components = new System.ComponentModel.Container();
   this.timer1 = new System.Windows.Forms.Timer(this.components);
   // 
   // timer1
   // 
   this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(672, 486);
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);

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
   timer1.Interval = 100;
   timer1.Enabled = true;
   this.WindowState = FormWindowState.Maximized;
  }

  int açý=0;
  private void timer1_Tick(object sender, System.EventArgs e)
  {
   Graphics g;
   Color renk1, renk2;
   Random r = new Random();
   açý += 10 % 360;
   renk1 = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
   renk2 = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
   g = this.CreateGraphics();
   string metin;
   Font fnt = new Font("Tahoma", 20, FontStyle.Bold);
   StringFormat fmt = new StringFormat();
   fmt.Alignment = StringAlignment.Center;
   metin = "Visual C# .NET çok güçlü ve " +
    "çok kullanýþlý bir programla dilidir";
   g.RotateTransform(açý);
   int xorta, yorta;
   xorta = this.ClientSize.Width / 2;
   yorta = this.ClientSize.Height / 2;
   g.FillRectangle(new SolidBrush(renk1), xorta, yorta, 200, 200);
   g.DrawString(metin, fnt, new SolidBrush(renk2), 
    new RectangleF(xorta, yorta, 200, 200), fmt);
   g.Dispose();
  }

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   string metin;
   Font fnt = new Font("Tahoma", 20, FontStyle.Bold);
   StringFormat fmt = new StringFormat();
   fmt.Alignment = StringAlignment.Center;
   metin = "Visual C# .NET çok güçlü ve " +
    "çok kullanýþlý bir programla dilidir";
   e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), 
    100, 10, 200, 200);
   e.Graphics.DrawString(metin, fnt, new SolidBrush(Color.Brown), 
    new RectangleF(100, 10, 200, 200), fmt);
   e.Graphics.RotateTransform(30);
   e.Graphics.FillRectangle(new SolidBrush(Color.Brown), 
    100, 10, 200, 200);
   e.Graphics.DrawString(metin, fnt, new SolidBrush(Color.Yellow), 
    new RectangleF(100, 10, 200, 200), fmt);
  }
	}
}
