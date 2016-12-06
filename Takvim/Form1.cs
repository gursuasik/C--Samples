using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Takvim
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.NumericUpDown numericUpDown2;
  internal System.Windows.Forms.NumericUpDown numericUpDown1;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
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
   this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
   this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
   this.SuspendLayout();
   // 
   // numericUpDown2
   // 
   this.numericUpDown2.Location = new System.Drawing.Point(152, 16);
   this.numericUpDown2.Name = "numericUpDown2";
   this.numericUpDown2.Size = new System.Drawing.Size(72, 20);
   this.numericUpDown2.TabIndex = 10;
   this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
   // 
   // numericUpDown1
   // 
   this.numericUpDown1.Location = new System.Drawing.Point(48, 16);
   this.numericUpDown1.Name = "numericUpDown1";
   this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
   this.numericUpDown1.TabIndex = 9;
   this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(120, 16);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(24, 16);
   this.Label2.TabIndex = 8;
   this.Label2.Text = "Y�l";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 16);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(24, 16);
   this.Label1.TabIndex = 7;
   this.Label1.Text = "Ay";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(704, 438);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.numericUpDown2,
                                                              this.numericUpDown1,
                                                              this.Label2,
                                                              this.Label1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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

  void �iz()
  {
   int i, j, x, y;
   Graphics g;
   int ay, y�l, hafta, gun=0; 
   DateTime Tarih;
   string str;
   Font Ay_Fontu = new Font("Tahoma", 14, FontStyle.Bold);
   Font G�nAd�_Fontu = new Font("Tahoma", 10, FontStyle.Bold);
   Font G�n_Fontu = new Font("Tahoma", 16, FontStyle.Regular);
   Font Hafta_Fontu = new Font("Tahoma", 16, FontStyle.Bold);
   ay = (int) numericUpDown1.Value;
   y�l =(int) numericUpDown2.Value;
   try
   {
    Tarih = new DateTime(y�l, ay, 1);//o ay�n birine ait tarihi olu�tur
   }
   catch
   {
    return;
   }
   g = CreateGraphics();
   g.Clear(Color.Brown);
   str = Tarih.ToString("MMMM") + " " + y�l + " Takvimi";
   g.DrawString(str, Ay_Fontu, new SolidBrush(Color.Yellow), 10, 50);
   y = 90;
   x = 10;
   g.DrawString("Hafta", G�nAd�_Fontu, new SolidBrush(Color.Cyan), x, y);
   x += 50;
   //G�n isimlerini yan yana yaz
   string [] g�nler = { "Pazartesi","Sal�","�ar�amba","Per�embe","Cuma","Cumartesi","Pazar"};
   for (i = 1 ; i<= 7 ; i++)
   {
    g.DrawString(g�nler[i-1], 
     G�nAd�_Fontu, new SolidBrush(Color.Cyan), x, y);
    x += 80;
   }
   y += 50;
   x = 10;
   int baslangic;
   //Ay�n ilk g�n�n�n haftan�n ka��nc� g�n� oldu�unu bul
   baslangic = (int) Tarih.DayOfWeek; 
   if (baslangic==0) //pazar ise
    baslangic=7;//bizde pazar g�n� ilk de�il son g�n
   
    //Y�l�n ka��nc� haftas� oldu�unu bul
   hafta = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetWeekOfYear(Tarih,System.Globalization.CalendarWeekRule.FirstDay,System.DayOfWeek.Monday );
   //Hafta numaralar�n� ve g�nleri yaz
   for (i = hafta ; i<= hafta + 6 ; i++)//Bir ayda 6 hafta olabilir
   {
    //Haftan�n numaras�n� yaz
    g.DrawString(i.ToString(), Hafta_Fontu, new SolidBrush(Color.DarkCyan), x, y);
    //Yan�na g�n numaralar�n� yaz
    for (j = baslangic ; j <= 7 ; j++)
    {
     gun += 1;
     if (gun > DateTime.DaysInMonth(y�l, ay)) 
      break;
     if ((j == 6) || (j == 7)) //cumartesi pazar� farkl� renkte yaz
      g.DrawString(gun.ToString(), G�n_Fontu, 
       new SolidBrush(Color.LightGreen), x + j * 80, y);
     else
      g.DrawString(gun.ToString(), G�n_Fontu, 
       new SolidBrush(Color.Yellow), x + j * 80, y);
    }
    baslangic = 1;
    if (gun > DateTime.DaysInMonth(y�l, ay)) 
     break;
    y += 50;
   }
   g.Dispose();
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   numericUpDown1.Minimum = 1;
   numericUpDown1.Maximum = 12;
   numericUpDown2.Minimum = 1;
   numericUpDown2.Maximum = 9999;
   numericUpDown1.Value = System.DateTime.Now.Month;
   numericUpDown2.Value = System.DateTime.Now.Year;
  }

  private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
  {
   //Ay de�i�ti�inde �iz
   �iz();
  }

  private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
  {
   //Y�l de�i�ti�inde �iz
   �iz();
  }

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   //Gerekti�inde takvimi yeniden �iz
   �iz();
  }
 }
}
