using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace �izim_Sat�r_Yaz
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
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
				if(components != null)
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
   // Form2
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Name = "Form2";
   this.Text = "Form2";
   this.Resize += new System.EventHandler(this.Form2_Resize);
   this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);

  }
		#endregion

  private void Form2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   string metin;
   Font fnt = Form1.fnt;
   int i, x, y=0;
   //Ba�l��� olu�tur
   metin = "P E R S O N E L  L � S T E S �";
   //Yaz�y� ortalamak i�in x koordinat�n� bul
   x=(int) (this.ClientSize.Width - e.Graphics.MeasureString(metin, fnt).Width)/2;
   e.Graphics.DrawString(metin, fnt, new SolidBrush(Color.Brown), x, y);
   //ba�l���n ba��na elips �izdir
   e.Graphics.FillEllipse(new SolidBrush(Color.Black), x - 10, y, 10, 10);
   //ba�l���n sonuna elips �izdir
   e.Graphics.FillEllipse(new SolidBrush(Color.Black), 
    x + e.Graphics.MeasureString(metin, fnt).Width, y, 10, 10);
   x = 10;
   y += (int) e.Graphics.MeasureString(metin, fnt).Height;
   e.Graphics.DrawLine(new Pen(Color.Black), 0, y, this.ClientSize.Width, y);
  
   //Liste sat�rlar�n� yaz
   for (i = 0 ; i<= Form1.Lst.Items.Count - 1 ; i++)
   {
    metin = Form1.Lst.Items[i].ToString();
    e.Graphics.DrawString(metin, fnt, new SolidBrush(Color.Red), x, y);
    y += (int) e.Graphics.MeasureString(metin, fnt).Height;
    e.Graphics.DrawLine(new Pen(Color.Black), 0, y, this.ClientSize.Width,y);
   }
   metin = "Toplam " + Form1.Lst.Items.Count.ToString() + " personel";
   //Personel say�s�n� sa�a yana��k yazmak i�in gerekli koordinat� bul
   x = (int) (this.ClientSize.Width - e.Graphics.MeasureString(metin, fnt).Width);
   e.Graphics.DrawString(metin, fnt, new SolidBrush(Color.Blue), x, y);
  }

  private void Form2_Resize(object sender, System.EventArgs e)
  {
   //Form boyutlar� de�i�ti�inde paint olay�n� �a��r
   this.Invalidate();
  }
	}
}
