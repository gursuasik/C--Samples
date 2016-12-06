using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;

namespace NumericUpDown_TarihSaat
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.NumericUpDown numericUpDown6;
  internal System.Windows.Forms.NumericUpDown numericUpDown5;
  internal System.Windows.Forms.NumericUpDown numericUpDown4;
  internal System.Windows.Forms.NumericUpDown numericUpDown3;
  internal System.Windows.Forms.NumericUpDown numericUpDown2;
  internal System.Windows.Forms.NumericUpDown numericUpDown1;
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
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
   this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
   this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
   this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
   this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
   this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
   this.SuspendLayout();
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(16, 48);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(56, 23);
   this.Label2.TabIndex = 15;
   this.Label2.Text = "Saat:";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(16, 16);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(56, 23);
   this.Label1.TabIndex = 14;
   this.Label1.Text = "Tarih:";
   // 
   // numericUpDown6
   // 
   this.numericUpDown6.Location = new System.Drawing.Point(168, 48);
   this.numericUpDown6.Name = "numericUpDown6";
   this.numericUpDown6.Size = new System.Drawing.Size(40, 20);
   this.numericUpDown6.TabIndex = 13;
   // 
   // numericUpDown5
   // 
   this.numericUpDown5.Location = new System.Drawing.Point(128, 48);
   this.numericUpDown5.Name = "numericUpDown5";
   this.numericUpDown5.Size = new System.Drawing.Size(40, 20);
   this.numericUpDown5.TabIndex = 12;
   // 
   // numericUpDown4
   // 
   this.numericUpDown4.Location = new System.Drawing.Point(88, 48);
   this.numericUpDown4.Name = "numericUpDown4";
   this.numericUpDown4.Size = new System.Drawing.Size(40, 20);
   this.numericUpDown4.TabIndex = 11;
   // 
   // numericUpDown3
   // 
   this.numericUpDown3.Location = new System.Drawing.Point(168, 16);
   this.numericUpDown3.Name = "numericUpDown3";
   this.numericUpDown3.Size = new System.Drawing.Size(64, 20);
   this.numericUpDown3.TabIndex = 10;
   // 
   // numericUpDown2
   // 
   this.numericUpDown2.Location = new System.Drawing.Point(128, 16);
   this.numericUpDown2.Name = "numericUpDown2";
   this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
   this.numericUpDown2.TabIndex = 9;
   // 
   // numericUpDown1
   // 
   this.numericUpDown1.Location = new System.Drawing.Point(88, 16);
   this.numericUpDown1.Name = "numericUpDown1";
   this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
   this.numericUpDown1.TabIndex = 8;
   this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(248, 86);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label2,
                                                              this.Label1,
                                                              this.numericUpDown6,
                                                              this.numericUpDown5,
                                                              this.numericUpDown4,
                                                              this.numericUpDown3,
                                                              this.numericUpDown2,
                                                              this.numericUpDown1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
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


  public struct SystemTime //apiler için gerekli zaman yapýsý
  {
   public short wYear;
   public short wMonth;
   public short wDayOfWeek;
   public short wDay;
   public short wHour;
   public short wMinute;
   public short wSecond;
   public short wMilliseconds;
  }

  public class tarih_saat_ayarla
  {
   //Saati öðrenmek ve deðiþtirmek için gerekli apiler 
   [DllImport("kernel32.dll")]
   public static extern bool GetLocalTime(ref SystemTime systemTime);
   [DllImport("kernel32.dll")]
   public static extern bool SetLocalTime(ref SystemTime systemTime);

   public void saat_ayarla(short saat, short dakika, short saniye)
   {
    SystemTime st = new SystemTime();
    GetLocalTime(ref st);//þu anki zamaný öðren
    //saat:dakika:saniyeyi deðiþtir
    st.wHour = saat;
    st.wMinute = dakika;
    st.wSecond = saniye;
    //yeni zamaný ata
    SetLocalTime(ref st);
   }

   public void tarih_ayarla(short gun, short ay, short yýl)
   {
    SystemTime st = new SystemTime();
    GetLocalTime(ref st);//þu anki tarihi öðren
    //Gun/Ay/Yýlý deðiþtir
    st.wDay = gun;
    st.wMonth = ay;
    st.wYear = yýl;
    //yeni tarihi ata
    SetLocalTime(ref st);
   }
  }


  Boolean baþlangýç;
  private void Form1_Load(object sender, System.EventArgs e)
  {
   baþlangýç = true;
  //Gün ay yýl 0 olmaz
  numericUpDown1.Minimum = 1 ;//gün
  numericUpDown2.Minimum = 1 ;//ay
  numericUpDown3.Minimum = 1 ;//yýl
  //Gün ay yýlýn en büyük deðerleri
  numericUpDown1.Maximum = 31 ;//gün
  numericUpDown2.Maximum = 12 ;//ay
  numericUpDown3.Maximum = 9999 ;//yýl
  //Saatin en büyük deðerleri
  numericUpDown4.Maximum = 23 ;//saat
  numericUpDown5.Maximum = 59 ;//dakika
  numericUpDown6.Maximum = 59 ;//saniye
  //Kullanýcý içine direk yazamasýn
  numericUpDown1.ReadOnly = true;
  numericUpDown2.ReadOnly = true;
  numericUpDown3.ReadOnly = true;
  numericUpDown4.ReadOnly = true;
  numericUpDown5.ReadOnly = true;
  numericUpDown6.ReadOnly = true;
  //Þu anki tarihi göster
  numericUpDown1.Value = DateTime.Now.Day;
  numericUpDown2.Value = DateTime.Now.Month;
  numericUpDown3.Value = DateTime.Now.Year;
  //Þu anki saati göster
  numericUpDown4.Value = DateTime.Now.Hour;
  numericUpDown5.Value = DateTime.Now.Minute;
  numericUpDown6.Value = DateTime.Now.Second;
  baþlangýç = false;

   //Olaylarý birleþtir. 
   numericUpDown2.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
   numericUpDown3.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
   numericUpDown4.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
   numericUpDown5.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
   numericUpDown6.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
  }

  private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
  {
   if (baþlangýç)
    return;//Form_Load alýþýyorsa ayarlamadan çýk
   try
   {
    tarih_saat_ayarla tarih = new tarih_saat_ayarla();
    tarih.tarih_ayarla((short) numericUpDown1.Value,(short) numericUpDown2.Value,(short) numericUpDown3.Value);
    tarih.saat_ayarla((short) numericUpDown4.Value,(short) numericUpDown5.Value,(short) numericUpDown6.Value);
   }
   catch
   {
    MessageBox.Show("Tarih veya saat geçersiz ");
   }
  }
	}
}
