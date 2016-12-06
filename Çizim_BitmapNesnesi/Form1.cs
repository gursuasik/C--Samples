using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Çizim_BitmapNesnesi
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
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(304, 80);
   this.button3.Name = "button3";
   this.button3.TabIndex = 8;
   this.button3.Text = "Aç";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(304, 48);
   this.button2.Name = "button2";
   this.button2.TabIndex = 7;
   this.button2.Text = "Kaydet";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(304, 16);
   this.button1.Name = "button1";
   this.button1.TabIndex = 6;
   this.button1.Text = "Çiz";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(384, 302);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button3,
                                                              this.button2,
                                                              this.button1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
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

  
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  
  Graphics g;
  Bitmap bmp;

  private void Form1_Load(object sender, System.EventArgs e)
  {
   Rectangle p = new Rectangle();
   p = Screen.GetBounds(p);
   //Ekran boyutlarý kadar bir bitmap oluþtur
   bmp = new Bitmap(p.Width, p.Height, 
    System.Drawing.Imaging.PixelFormat.Format32bppArgb);
   g = Graphics.FromImage(bmp);
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
   g.FillEllipse(new SolidBrush(Color.Red), 10, 10, 200, 30);
   g.DrawString("Visual C# .NET", new Font("Tahoma", 12, FontStyle.Regular), new SolidBrush(Color.Blue), 50, 15);
   this.Invalidate();
  }

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
    //sadece gerekli bölgeyi Bitmap nesnesinden forma kopyala
    e.Graphics.DrawImage(bmp, e.ClipRectangle, 
                         e.ClipRectangle.Left, e.ClipRectangle.Top, 
                         e.ClipRectangle.Width, e.ClipRectangle.Height, 
                         GraphicsUnit.Pixel);
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   bmp.Save("c:\\temp.bmp");
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   bmp = (Bitmap) Image.FromFile("c:\\temp.bmp");
   this.Invalidate();
  }
	}
}
