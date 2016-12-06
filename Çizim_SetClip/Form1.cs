using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Çizim_SetClip
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
   this.ClientSize = new System.Drawing.Size(744, 550);
   this.Name = "Form1";
   this.Text = "Form1";
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

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   Image  resim = Image.FromFile("c:\\windows\\winnt.bmp");
   System.Drawing.Drawing2D.GraphicsPath p = new System.Drawing.Drawing2D.GraphicsPath();
   p.AddEllipse(0, 0, resim.Width, resim.Height);
   e.Graphics.SetClip(p);
   e.Graphics.DrawImage(resim, 0, 0);

   p.Reset();
   p.AddPie(300, 0, resim.Width, resim.Height, 30, 150);
   e.Graphics.SetClip(p);
   e.Graphics.DrawImage(resim, 300, 0);

   p.Reset();
   p.AddPie(0, 200, resim.Width, resim.Height, 30, 50);
   p.AddPie(0, 200, resim.Width, resim.Height, 100, 50);
   p.AddPie(0, 200, resim.Width, resim.Height, 170, 50);
   p.AddPie(0, 200, resim.Width, resim.Height, 240, 50);
   p.AddPie(0, 200, resim.Width, resim.Height, 310, 50);
   e.Graphics.SetClip(p);
   e.Graphics.DrawImage(resim, 0, 200);

   p.Reset();
   p.AddPie(200, 400, 100, 100, 30, 50);
   p.AddPie(200, 400, 100, 100, 100, 50);
   p.AddPie(200, 400, 100, 100, 170, 50);
   p.AddPie(200, 400, 100, 100, 240, 50);
   p.AddPie(200, 400, 100, 100, 310, 50);
   e.Graphics.SetClip(p);
   string  metin;
   Font fnt = new Font("Tahoma", 10, FontStyle.Bold);
   metin = "Visual C# .NET çok güçlü ve " +
    "çok kullanýþlý bir programla dilidir";
   e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), 200, 400, 100, 100);
   e.Graphics.DrawString(metin, fnt, new SolidBrush(Color.Brown), 
    new RectangleF(200, 400, 100, 100));

   p.Reset();
   p.AddPie(300, 200, 200, 200, 30, 50);
  p.AddPie(300, 200, 200, 200, 100, 50);
  p.AddPie(300, 200, 200, 200, 170, 50);
  p.AddPie(300, 200, 200, 200, 240, 50);
  p.AddPie(300, 200, 200, 200, 310, 50);
   e.Graphics.SetClip(p);
   fnt = new Font("Tahoma", 20, FontStyle.Bold);
   StringFormat fmt = new StringFormat();
   fmt.Alignment = StringAlignment.Center;
   metin = "Visual C# .NET çok güçlü ve " +
    "çok kullanýþlý bir programla dilidir";
   e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), 300, 200, 200, 200);
   e.Graphics.DrawString(metin, fnt, new SolidBrush(Color.Brown), 
    new RectangleF(300, 200, 200, 200), fmt);
   p.Reset();
   p.AddPie(300, 200, 200, 200, 80, 20);
  p.AddPie(300, 200, 200, 200, 150, 20);
  p.AddPie(300, 200, 200, 200, 220, 20);
  p.AddPie(300, 200, 200, 200, 290, 20);
  p.AddPie(300, 200, 200, 200, 360, 30);
   e.Graphics.SetClip(p);
   e.Graphics.FillRectangle(new SolidBrush(Color.Brown), 300, 200, 200, 200);
   e.Graphics.DrawString(metin, fnt, new SolidBrush(Color.Yellow), 
    new RectangleF(300, 200, 200, 200), fmt);
  }
	}
}
