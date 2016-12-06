using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Çizim_Saat
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
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Name = "Form1";
   this.Text = "Form1";
   this.Resize += new System.EventHandler(this.Form1_Resize);
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
   timer1.Interval = 1000;
   timer1.Enabled = true;
   //Formun iç yüksekliði ile iç geniþliðini eþitle
   this.Height = this.Width + this.ClientSize.Width - this.ClientSize.Height;
  }

  private void timer1_Tick(object sender, System.EventArgs e)
  {
   Graphics g;
   g = this.CreateGraphics();
   float xorta, yorta, yarý_çap, sx, sy;
   if (this.ClientSize.Width > this.ClientSize.Height)
    yarý_çap = this.ClientSize.Height / 2;
   else
    yarý_çap = this.ClientSize.Width / 2;
   g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
   //Saatin etrafýndaki ait daireleri çiz
   g.DrawEllipse(new Pen(Color.Red), 0, 0, 2 * yarý_çap, 2 * yarý_çap);
   g.DrawEllipse(new Pen(Color.Red), 8, 8, 
    2 * yarý_çap - 16, 2 * yarý_çap - 16);
   g.FillEllipse(new SolidBrush(this.BackColor), 9, 9, 
    2 * yarý_çap - 18, 2 * yarý_çap - 18);
   xorta = yarý_çap;
   yorta = yarý_çap;
   yarý_çap -= 8;
   int açý, saniye, dakika, saat, i;
   int kx1, kx2, ky1, ky2;
   //Saati ve dakikayý gösteren çizgileri oluþtur
   for (açý = 0 ; açý<= 360 ; açý+=6)
   {
    kx1 = (int) (xorta + (yarý_çap + 8) * Math.Cos(açý * 3.1415 / 180));
    ky1 = (int) (yorta - (yarý_çap + 8) * Math.Sin(açý * 3.1415 / 180));
    kx2 = (int) (xorta + (yarý_çap) * Math.Cos(açý * 3.1415 / 180));
    ky2 = (int) (yorta - (yarý_çap) * Math.Sin(açý * 3.1415 / 180));
    if ((açý % 30) == 0)
     //Her 30 derecede bir saat baþý bulunur. Bunlarý kalýn çiz
     g.DrawLine(new Pen(Color.Red, 4), kx1, ky1, kx2, ky2);
    else
     //Her 6 derecede bir dakika bulunur. Bunlarý ince çiz
     g.DrawLine(new Pen(Color.Blue, 2), kx1, ky1, kx2, ky2);
   }
   //Orta noktayý bulup Bizim Saat yaz
   kx1 = (int)(xorta - (g.MeasureString("Bizim Saat", 
    new Font("Tahoma", 8, FontStyle.Regular)).Width) / 2);
   ky1 = 30;
   g.DrawString("Bizim Saat", new Font("Tahoma", 8, FontStyle.Regular), 
    new SolidBrush(Color.Blue), kx1, ky1);
   //Saat, Dakika, Saniye çizgilerini hesapla
   System.Drawing.Drawing2D.GraphicsPath p = new System.Drawing.Drawing2D.GraphicsPath();
   saat = DateTime.Now.TimeOfDay.Hours; //saati al
   açý = -saat * 30 + 90; //her saat 30 derecedir. 
   //360 derece / 12 saat = 30
   sx = (int)(xorta + yarý_çap * 2 / 3 * Math.Cos(açý * 3.1415 / 180));
   sy = (int)(yorta - yarý_çap * 2 / 3 * Math.Sin(açý * 3.1415 / 180));
   kx1 = (int)(xorta - 8 * Math.Cos(açý * 3.1415 / 180 + Math.PI / 2));
   kx2 = (int)(xorta + 8 * Math.Cos(açý * 3.1415 / 180 + Math.PI / 2));
   ky1 = (int)(yorta + 8 * Math.Sin(açý * 3.1415 / 180 + Math.PI / 2));
   ky2 = (int)(yorta - 8 * Math.Sin(açý * 3.1415 / 180 + Math.PI / 2));
   //Akrebi üçgen þeklinde çiz
   p.AddLine(kx1, ky1, sx, sy);
   p.AddLine(kx2, ky2, sx, sy);
   p.AddLine(kx1, ky1, kx2, ky2);

   dakika = DateTime.Now.TimeOfDay.Minutes; //dakikayý saatten al
   açý = -dakika * 6 + 90; //her bir dakika 6 derecedir.360 derece/60dakika
   sx = (float)(xorta + yarý_çap * Math.Cos(açý * 3.1415 / 180));
   sy = (float)(yorta - yarý_çap * Math.Sin(açý * 3.1415 / 180));
   kx1 = (int)(xorta - 4 * Math.Cos(açý * 3.1415 / 180 + Math.PI / 2));
   kx2 = (int)(xorta + 4 * Math.Cos(açý * 3.1415 / 180 + Math.PI / 2));
   ky1 = (int)(yorta + 4 * Math.Sin(açý * 3.1415 / 180 + Math.PI / 2));
   ky2 = (int)(yorta - 4 * Math.Sin(açý * 3.1415 / 180 + Math.PI / 2));
   //Yelkovaný üçgen þeklinde çiz
   p.AddLine(kx1, ky1, sx, sy);
   p.AddLine(kx2, ky2, sx, sy);
   p.AddLine(kx1, ky1, kx2, ky2);

   saniye = DateTime.Now.TimeOfDay.Seconds; //saniyeyi saatten al
   açý = -saniye * 6 + 90; //her bir saniye 6 derecedir.360 derece/60saniye
   sx = (float)(xorta + yarý_çap * Math.Cos(açý * 3.1415 / 180));
   sy = (float)(yorta - yarý_çap * Math.Sin(açý * 3.1415 / 180));
   kx1 = (int)(xorta - 1 * Math.Cos(açý * 3.1415 / 180 + Math.PI / 2));
   kx2 = (int)(xorta + 1 * Math.Cos(açý * 3.1415 / 180 + Math.PI / 2));
   ky1 = (int)(yorta + 1 * Math.Sin(açý * 3.1415 / 180 + Math.PI / 2));
   ky2 = (int)(yorta - 1 * Math.Sin(açý * 3.1415 / 180 + Math.PI / 2));
   //Saniyeyi üçgen þeklinde çiz
   p.AddLine(kx1, ky1, sx, sy);
   p.AddLine(kx2, ky2, sx, sy);
   p.AddLine(kx1, ky1, kx2, ky2);
   //Ortadaki yuvarlak
   p.AddEllipse(xorta - 8, yorta - 8, 16, 16);
   //Akrep, Yelkovan ve Saniye çizimlerini yap
   g.DrawPath(new Pen(Color.Blue, 1), p);
   //Ortadaki yuvarlaðý boya
   g.FillPath(new SolidBrush(Color.Blue), p);
   g.Dispose();
   p.Dispose();
  }

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   e.Graphics.Clear(this.BackColor);
  }

  private void Form1_Resize(object sender, System.EventArgs e)
  {
   //Form boyutlandýðýnda içeriði sil
   Graphics g;
   g = this.CreateGraphics();
   g.Clear(this.BackColor);
   g.Dispose();
  }
	}
}
