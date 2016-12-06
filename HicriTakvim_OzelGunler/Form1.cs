using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace HicriTakvim_OzelGunler
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label4;
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
   this.label1 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(16, 16);
   this.label1.Name = "label1";
   this.label1.TabIndex = 0;
   this.label1.Text = "Miladi Tarih:";
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(16, 48);
   this.label2.Name = "label2";
   this.label2.TabIndex = 1;
   this.label2.Text = "Hicri Tarih:";
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(112, 16);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(152, 23);
   this.label3.TabIndex = 2;
   this.label3.Text = "label3";
   // 
   // label4
   // 
   this.label4.Location = new System.Drawing.Point(112, 48);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(144, 23);
   this.label4.TabIndex = 3;
   this.label4.Text = "label4";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(280, 78);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label4,
                                                              this.label3,
                                                              this.label2,
                                                              this.label1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
   label3.Text=DateTime.Now.ToString("d-MMMM-yyyy");
   System.Globalization.HijriCalendar hicri = new System.Globalization.HijriCalendar();
   DateTime hicri_tarih=
    new DateTime(DateTime.Now.Year,
    DateTime.Now.Month,
    DateTime.Now.Day,
    DateTime.Now.Hour,
    DateTime.Now.Minute,
    DateTime.Now.Second,
    System.Globalization.HijriCalendar.CurrentEra);

   string[] aylar = {"Muharrem", "Safer", "Rebiül Evvel", "Rebiül Ahir", "Cemaziyel Evvel", "Cemaziyel Ahir", "Recep", "Þaban", "Ramazan", "Þevval", "Zilkadde", "Zilhicce"};
   int h_gun, h_ay, h_yýl;
   h_gun=hicri.GetDayOfMonth(hicri_tarih);
   h_ay=hicri.GetMonth(hicri_tarih);
   h_yýl=hicri.GetYear(hicri_tarih);
   label4.Text=h_gun.ToString()+"-"+aylar[h_ay-1]+'-'+h_yýl.ToString();
   string msg="";
   if (h_ay==9) 
    msg="Bu gün ramazanýn " + h_gun.ToString() + ".günü";
   if (h_ay==9 && h_gun==26) 
    msg="Bu gece Kadir Gecesi. Kandiliniz mübarek olsun.";
   if (h_ay==3 && h_gun==11)
    msg="Bu gece Mevlit Kandili. Kandiliniz mübarek olsun.";
   //recep ayýnýn ilk cuma gecesi Regaip Kandili
   if (h_ay==7 && hicri.GetDayOfWeek(hicri_tarih)==DayOfWeek.Thursday  && h_gun<=7)
    msg= "Bu gece Regaip Kandili. Kandiliniz mübarek olsun.";
   if (h_ay==7 && h_gun==26)
    msg="Bu gece Miraç Kandili. Kandiliniz mübarek olsun.";
   if (h_ay==8 && h_gun==14) 
    msg="Bu gece Beraat Kandili. Kandiliniz mübarek olsun.";
   if (h_ay==10 && h_gun>=1 && h_gun<=3)
    msg= "Ramazan bayramýnýz mübarek olsun. Bugün bayramýn " + h_gun.ToString() + ".günü";
   if (h_ay==11 && h_gun>=10 && h_gun<=13)
    msg = "Kurban bayramýnýz mübarek olsun. Bugün bayramýn " + (h_gun-9).ToString() + ".günü";
   if (h_ay==1 && h_gun==1)
    msg="Bugün Hicri Yýlbaþý. Yeni yýlýnýz hayýrlý olsun";
   if (msg != "") 
    MessageBox.Show(msg);
  }
	}
}
