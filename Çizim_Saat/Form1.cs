using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace �izim_Saat
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
   //Formun i� y�ksekli�i ile i� geni�li�ini e�itle
   this.Height = this.Width + this.ClientSize.Width - this.ClientSize.Height;
  }

  private void timer1_Tick(object sender, System.EventArgs e)
  {
   Graphics g;
   g = this.CreateGraphics();
   float xorta, yorta, yar�_�ap, sx, sy;
   if (this.ClientSize.Width > this.ClientSize.Height)
    yar�_�ap = this.ClientSize.Height / 2;
   else
    yar�_�ap = this.ClientSize.Width / 2;
   g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
   //Saatin etraf�ndaki ait daireleri �iz
   g.DrawEllipse(new Pen(Color.Red), 0, 0, 2 * yar�_�ap, 2 * yar�_�ap);
   g.DrawEllipse(new Pen(Color.Red), 8, 8, 
    2 * yar�_�ap - 16, 2 * yar�_�ap - 16);
   g.FillEllipse(new SolidBrush(this.BackColor), 9, 9, 
    2 * yar�_�ap - 18, 2 * yar�_�ap - 18);
   xorta = yar�_�ap;
   yorta = yar�_�ap;
   yar�_�ap -= 8;
   int a��, saniye, dakika, saat, i;
   int kx1, kx2, ky1, ky2;
   //Saati ve dakikay� g�steren �izgileri olu�tur
   for (a�� = 0 ; a��<= 360 ; a��+=6)
   {
    kx1 = (int) (xorta + (yar�_�ap + 8) * Math.Cos(a�� * 3.1415 / 180));
    ky1 = (int) (yorta - (yar�_�ap + 8) * Math.Sin(a�� * 3.1415 / 180));
    kx2 = (int) (xorta + (yar�_�ap) * Math.Cos(a�� * 3.1415 / 180));
    ky2 = (int) (yorta - (yar�_�ap) * Math.Sin(a�� * 3.1415 / 180));
    if ((a�� % 30) == 0)
     //Her 30 derecede bir saat ba�� bulunur. Bunlar� kal�n �iz
     g.DrawLine(new Pen(Color.Red, 4), kx1, ky1, kx2, ky2);
    else
     //Her 6 derecede bir dakika bulunur. Bunlar� ince �iz
     g.DrawLine(new Pen(Color.Blue, 2), kx1, ky1, kx2, ky2);
   }
   //Orta noktay� bulup Bizim Saat yaz
   kx1 = (int)(xorta - (g.MeasureString("Bizim Saat", 
    new Font("Tahoma", 8, FontStyle.Regular)).Width) / 2);
   ky1 = 30;
   g.DrawString("Bizim Saat", new Font("Tahoma", 8, FontStyle.Regular), 
    new SolidBrush(Color.Blue), kx1, ky1);
   //Saat, Dakika, Saniye �izgilerini hesapla
   System.Drawing.Drawing2D.GraphicsPath p = new System.Drawing.Drawing2D.GraphicsPath();
   saat = DateTime.Now.TimeOfDay.Hours; //saati al
   a�� = -saat * 30 + 90; //her saat 30 derecedir. 
   //360 derece / 12 saat = 30
   sx = (int)(xorta + yar�_�ap * 2 / 3 * Math.Cos(a�� * 3.1415 / 180));
   sy = (int)(yorta - yar�_�ap * 2 / 3 * Math.Sin(a�� * 3.1415 / 180));
   kx1 = (int)(xorta - 8 * Math.Cos(a�� * 3.1415 / 180 + Math.PI / 2));
   kx2 = (int)(xorta + 8 * Math.Cos(a�� * 3.1415 / 180 + Math.PI / 2));
   ky1 = (int)(yorta + 8 * Math.Sin(a�� * 3.1415 / 180 + Math.PI / 2));
   ky2 = (int)(yorta - 8 * Math.Sin(a�� * 3.1415 / 180 + Math.PI / 2));
   //Akrebi ��gen �eklinde �iz
   p.AddLine(kx1, ky1, sx, sy);
   p.AddLine(kx2, ky2, sx, sy);
   p.AddLine(kx1, ky1, kx2, ky2);

   dakika = DateTime.Now.TimeOfDay.Minutes; //dakikay� saatten al
   a�� = -dakika * 6 + 90; //her bir dakika 6 derecedir.360 derece/60dakika
   sx = (float)(xorta + yar�_�ap * Math.Cos(a�� * 3.1415 / 180));
   sy = (float)(yorta - yar�_�ap * Math.Sin(a�� * 3.1415 / 180));
   kx1 = (int)(xorta - 4 * Math.Cos(a�� * 3.1415 / 180 + Math.PI / 2));
   kx2 = (int)(xorta + 4 * Math.Cos(a�� * 3.1415 / 180 + Math.PI / 2));
   ky1 = (int)(yorta + 4 * Math.Sin(a�� * 3.1415 / 180 + Math.PI / 2));
   ky2 = (int)(yorta - 4 * Math.Sin(a�� * 3.1415 / 180 + Math.PI / 2));
   //Yelkovan� ��gen �eklinde �iz
   p.AddLine(kx1, ky1, sx, sy);
   p.AddLine(kx2, ky2, sx, sy);
   p.AddLine(kx1, ky1, kx2, ky2);

   saniye = DateTime.Now.TimeOfDay.Seconds; //saniyeyi saatten al
   a�� = -saniye * 6 + 90; //her bir saniye 6 derecedir.360 derece/60saniye
   sx = (float)(xorta + yar�_�ap * Math.Cos(a�� * 3.1415 / 180));
   sy = (float)(yorta - yar�_�ap * Math.Sin(a�� * 3.1415 / 180));
   kx1 = (int)(xorta - 1 * Math.Cos(a�� * 3.1415 / 180 + Math.PI / 2));
   kx2 = (int)(xorta + 1 * Math.Cos(a�� * 3.1415 / 180 + Math.PI / 2));
   ky1 = (int)(yorta + 1 * Math.Sin(a�� * 3.1415 / 180 + Math.PI / 2));
   ky2 = (int)(yorta - 1 * Math.Sin(a�� * 3.1415 / 180 + Math.PI / 2));
   //Saniyeyi ��gen �eklinde �iz
   p.AddLine(kx1, ky1, sx, sy);
   p.AddLine(kx2, ky2, sx, sy);
   p.AddLine(kx1, ky1, kx2, ky2);
   //Ortadaki yuvarlak
   p.AddEllipse(xorta - 8, yorta - 8, 16, 16);
   //Akrep, Yelkovan ve Saniye �izimlerini yap
   g.DrawPath(new Pen(Color.Blue, 1), p);
   //Ortadaki yuvarla�� boya
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
   //Form boyutland���nda i�eri�i sil
   Graphics g;
   g = this.CreateGraphics();
   g.Clear(this.BackColor);
   g.Dispose();
  }
	}
}
