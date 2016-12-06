using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Çizim_Grafik_2
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

  private float f(float x)
  {
   return (float) (x * Math.Sin(5 * x * Math.PI / 180)); //y=x*sin(5x) 
  }

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   int xorta, yorta, xmax, ymax;
   xorta = this.ClientSize.Width / 2;
   yorta = this.ClientSize.Height / 2;
   e.Graphics.TranslateTransform(xorta, yorta);
   xmax = this.ClientSize.Width;
   ymax = this.ClientSize.Height;
   //Önceki grafiði sil
   e.Graphics.Clear(this.BackColor);
   //eksenleri çiz
   e.Graphics.DrawLine(new  Pen(Color.Blue, 2), -xorta, 0, xorta, 0);//x 
   e.Graphics.DrawLine(new  Pen(Color.Blue, 2), 0, -yorta, 0, yorta);//y 
   float x, y;
   for (x = -xorta ; x<= xorta ; x+= 0.1F)
   {
    //fonksiyonu hesapla
    y = -f(x);
    //O noktaya 1 pixellik çizgi çiz
    e.Graphics.DrawLine(new  Pen(Color.Red, 1), x, y, x + 1, y);
   }
  }
	}
}
