using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Hesap_Makinesi_Modern
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button Button_Geri_Sil;
  internal System.Windows.Forms.Button Button_C;
  internal System.Windows.Forms.Button Button_MR;
  internal System.Windows.Forms.Button Button_MEksi;
  internal System.Windows.Forms.Button Button_MArtý;
  internal System.Windows.Forms.Button Button_MC;
  internal System.Windows.Forms.Button Button_Kök;
  internal System.Windows.Forms.Button Button_Kare;
  internal System.Windows.Forms.Button Button_bir_bölü_x;
  internal System.Windows.Forms.Button Button_Eþit;
  internal System.Windows.Forms.Button Button_Eksi;
  internal System.Windows.Forms.Button Button_Artý;
  internal System.Windows.Forms.Button Button_Bölü;
  internal System.Windows.Forms.Button Button_Çarpý;
  internal System.Windows.Forms.Button Button_Virgül;
  internal System.Windows.Forms.Button Button_artý_eksi;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Button Button0;
  internal System.Windows.Forms.Button Button9;
  internal System.Windows.Forms.Button Button8;
  internal System.Windows.Forms.Button Button7;
  internal System.Windows.Forms.Button Button6;
  internal System.Windows.Forms.Button Button5;
  internal System.Windows.Forms.Button Button4;
  internal System.Windows.Forms.Button Button3;
  internal System.Windows.Forms.Button Button2;
  internal System.Windows.Forms.Button Button1;
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
   this.Button_Geri_Sil = new System.Windows.Forms.Button();
   this.Button_C = new System.Windows.Forms.Button();
   this.Button_MR = new System.Windows.Forms.Button();
   this.Button_MEksi = new System.Windows.Forms.Button();
   this.Button_MArtý = new System.Windows.Forms.Button();
   this.Button_MC = new System.Windows.Forms.Button();
   this.Button_Kök = new System.Windows.Forms.Button();
   this.Button_Kare = new System.Windows.Forms.Button();
   this.Button_bir_bölü_x = new System.Windows.Forms.Button();
   this.Button_Eþit = new System.Windows.Forms.Button();
   this.Button_Eksi = new System.Windows.Forms.Button();
   this.Button_Artý = new System.Windows.Forms.Button();
   this.Button_Bölü = new System.Windows.Forms.Button();
   this.Button_Çarpý = new System.Windows.Forms.Button();
   this.Button_Virgül = new System.Windows.Forms.Button();
   this.Button_artý_eksi = new System.Windows.Forms.Button();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Button0 = new System.Windows.Forms.Button();
   this.Button9 = new System.Windows.Forms.Button();
   this.Button8 = new System.Windows.Forms.Button();
   this.Button7 = new System.Windows.Forms.Button();
   this.Button6 = new System.Windows.Forms.Button();
   this.Button5 = new System.Windows.Forms.Button();
   this.Button4 = new System.Windows.Forms.Button();
   this.Button3 = new System.Windows.Forms.Button();
   this.Button2 = new System.Windows.Forms.Button();
   this.Button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // Button_Geri_Sil
   // 
   this.Button_Geri_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_Geri_Sil.ForeColor = System.Drawing.Color.Red;
   this.Button_Geri_Sil.Location = new System.Drawing.Point(192, 48);
   this.Button_Geri_Sil.Name = "Button_Geri_Sil";
   this.Button_Geri_Sil.Size = new System.Drawing.Size(32, 24);
   this.Button_Geri_Sil.TabIndex = 54;
   this.Button_Geri_Sil.Text = "<-";
   this.Button_Geri_Sil.Click += new System.EventHandler(this.Button_Geri_Sil_Click);
   // 
   // Button_C
   // 
   this.Button_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_C.ForeColor = System.Drawing.Color.Red;
   this.Button_C.Location = new System.Drawing.Point(160, 48);
   this.Button_C.Name = "Button_C";
   this.Button_C.Size = new System.Drawing.Size(32, 24);
   this.Button_C.TabIndex = 53;
   this.Button_C.Text = "C";
   this.Button_C.Click += new System.EventHandler(this.Button_C_Click);
   // 
   // Button_MR
   // 
   this.Button_MR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_MR.ForeColor = System.Drawing.Color.Blue;
   this.Button_MR.Location = new System.Drawing.Point(16, 152);
   this.Button_MR.Name = "Button_MR";
   this.Button_MR.Size = new System.Drawing.Size(32, 24);
   this.Button_MR.TabIndex = 52;
   this.Button_MR.Text = "MR";
   this.Button_MR.Click += new System.EventHandler(this.hafýza_iþlemleri);
   // 
   // Button_MEksi
   // 
   this.Button_MEksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_MEksi.ForeColor = System.Drawing.Color.Blue;
   this.Button_MEksi.Location = new System.Drawing.Point(16, 128);
   this.Button_MEksi.Name = "Button_MEksi";
   this.Button_MEksi.Size = new System.Drawing.Size(32, 24);
   this.Button_MEksi.TabIndex = 51;
   this.Button_MEksi.Text = "M-";
   this.Button_MEksi.Click += new System.EventHandler(this.hafýza_iþlemleri);
   // 
   // Button_MArtý
   // 
   this.Button_MArtý.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_MArtý.ForeColor = System.Drawing.Color.Blue;
   this.Button_MArtý.Location = new System.Drawing.Point(16, 104);
   this.Button_MArtý.Name = "Button_MArtý";
   this.Button_MArtý.Size = new System.Drawing.Size(32, 24);
   this.Button_MArtý.TabIndex = 50;
   this.Button_MArtý.Text = "M+";
   this.Button_MArtý.Click += new System.EventHandler(this.hafýza_iþlemleri);
   // 
   // Button_MC
   // 
   this.Button_MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_MC.ForeColor = System.Drawing.Color.Blue;
   this.Button_MC.Location = new System.Drawing.Point(16, 80);
   this.Button_MC.Name = "Button_MC";
   this.Button_MC.Size = new System.Drawing.Size(32, 24);
   this.Button_MC.TabIndex = 49;
   this.Button_MC.Text = "MC";
   this.Button_MC.Click += new System.EventHandler(this.hafýza_iþlemleri);
   // 
   // Button_Kök
   // 
   this.Button_Kök.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_Kök.Location = new System.Drawing.Point(192, 80);
   this.Button_Kök.Name = "Button_Kök";
   this.Button_Kök.Size = new System.Drawing.Size(32, 24);
   this.Button_Kök.TabIndex = 48;
   this.Button_Kök.Text = "Kök";
   this.Button_Kök.Click += new System.EventHandler(this.Ýþlem_Yap_2);
   // 
   // Button_Kare
   // 
   this.Button_Kare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_Kare.Location = new System.Drawing.Point(192, 104);
   this.Button_Kare.Name = "Button_Kare";
   this.Button_Kare.Size = new System.Drawing.Size(32, 24);
   this.Button_Kare.TabIndex = 47;
   this.Button_Kare.Text = "x²";
   this.Button_Kare.Click += new System.EventHandler(this.Ýþlem_Yap_2);
   // 
   // Button_bir_bölü_x
   // 
   this.Button_bir_bölü_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_bir_bölü_x.Location = new System.Drawing.Point(192, 128);
   this.Button_bir_bölü_x.Name = "Button_bir_bölü_x";
   this.Button_bir_bölü_x.Size = new System.Drawing.Size(32, 24);
   this.Button_bir_bölü_x.TabIndex = 46;
   this.Button_bir_bölü_x.Text = "1/x";
   this.Button_bir_bölü_x.Click += new System.EventHandler(this.Ýþlem_Yap_2);
   // 
   // Button_Eþit
   // 
   this.Button_Eþit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_Eþit.Location = new System.Drawing.Point(192, 152);
   this.Button_Eþit.Name = "Button_Eþit";
   this.Button_Eþit.Size = new System.Drawing.Size(32, 24);
   this.Button_Eþit.TabIndex = 45;
   this.Button_Eþit.Text = "=";
   this.Button_Eþit.Click += new System.EventHandler(this.Button_Eþit_Click);
   // 
   // Button_Eksi
   // 
   this.Button_Eksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_Eksi.Location = new System.Drawing.Point(160, 152);
   this.Button_Eksi.Name = "Button_Eksi";
   this.Button_Eksi.Size = new System.Drawing.Size(32, 24);
   this.Button_Eksi.TabIndex = 44;
   this.Button_Eksi.Text = "-";
   this.Button_Eksi.Click += new System.EventHandler(this.Dört_Ýþlem);
   // 
   // Button_Artý
   // 
   this.Button_Artý.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_Artý.Location = new System.Drawing.Point(160, 128);
   this.Button_Artý.Name = "Button_Artý";
   this.Button_Artý.Size = new System.Drawing.Size(32, 24);
   this.Button_Artý.TabIndex = 43;
   this.Button_Artý.Text = "+";
   this.Button_Artý.Click += new System.EventHandler(this.Dört_Ýþlem);
   // 
   // Button_Bölü
   // 
   this.Button_Bölü.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_Bölü.Location = new System.Drawing.Point(160, 104);
   this.Button_Bölü.Name = "Button_Bölü";
   this.Button_Bölü.Size = new System.Drawing.Size(32, 24);
   this.Button_Bölü.TabIndex = 42;
   this.Button_Bölü.Text = "/";
   this.Button_Bölü.Click += new System.EventHandler(this.Dört_Ýþlem);
   // 
   // Button_Çarpý
   // 
   this.Button_Çarpý.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_Çarpý.Location = new System.Drawing.Point(160, 80);
   this.Button_Çarpý.Name = "Button_Çarpý";
   this.Button_Çarpý.Size = new System.Drawing.Size(32, 24);
   this.Button_Çarpý.TabIndex = 41;
   this.Button_Çarpý.Text = "*";
   this.Button_Çarpý.Click += new System.EventHandler(this.Dört_Ýþlem);
   // 
   // Button_Virgül
   // 
   this.Button_Virgül.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_Virgül.Location = new System.Drawing.Point(120, 152);
   this.Button_Virgül.Name = "Button_Virgül";
   this.Button_Virgül.Size = new System.Drawing.Size(32, 24);
   this.Button_Virgül.TabIndex = 40;
   this.Button_Virgül.Text = ",";
   this.Button_Virgül.Click += new System.EventHandler(this.Button_Virgül_Click);
   // 
   // Button_artý_eksi
   // 
   this.Button_artý_eksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_artý_eksi.Location = new System.Drawing.Point(56, 152);
   this.Button_artý_eksi.Name = "Button_artý_eksi";
   this.Button_artý_eksi.Size = new System.Drawing.Size(32, 24);
   this.Button_artý_eksi.TabIndex = 39;
   this.Button_artý_eksi.Text = "±";
   this.Button_artý_eksi.Click += new System.EventHandler(this.Button_artý_eksi_Click);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(16, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(208, 20);
   this.textBox1.TabIndex = 38;
   this.textBox1.Text = "TextBox1";
   this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // Button0
   // 
   this.Button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button0.Location = new System.Drawing.Point(88, 152);
   this.Button0.Name = "Button0";
   this.Button0.Size = new System.Drawing.Size(32, 24);
   this.Button0.TabIndex = 37;
   this.Button0.Text = "0";
   this.Button0.Click += new System.EventHandler(this.rakamlar);
   // 
   // Button9
   // 
   this.Button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button9.Location = new System.Drawing.Point(120, 128);
   this.Button9.Name = "Button9";
   this.Button9.Size = new System.Drawing.Size(32, 24);
   this.Button9.TabIndex = 36;
   this.Button9.Text = "9";
   this.Button9.Click += new System.EventHandler(this.rakamlar);
   // 
   // Button8
   // 
   this.Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button8.Location = new System.Drawing.Point(88, 128);
   this.Button8.Name = "Button8";
   this.Button8.Size = new System.Drawing.Size(32, 24);
   this.Button8.TabIndex = 35;
   this.Button8.Text = "8";
   this.Button8.Click += new System.EventHandler(this.rakamlar);
   // 
   // Button7
   // 
   this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button7.Location = new System.Drawing.Point(56, 128);
   this.Button7.Name = "Button7";
   this.Button7.Size = new System.Drawing.Size(32, 24);
   this.Button7.TabIndex = 34;
   this.Button7.Text = "7";
   this.Button7.Click += new System.EventHandler(this.rakamlar);
   // 
   // Button6
   // 
   this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button6.Location = new System.Drawing.Point(120, 104);
   this.Button6.Name = "Button6";
   this.Button6.Size = new System.Drawing.Size(32, 24);
   this.Button6.TabIndex = 33;
   this.Button6.Text = "6";
   this.Button6.Click += new System.EventHandler(this.rakamlar);
   // 
   // Button5
   // 
   this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button5.Location = new System.Drawing.Point(88, 104);
   this.Button5.Name = "Button5";
   this.Button5.Size = new System.Drawing.Size(32, 24);
   this.Button5.TabIndex = 32;
   this.Button5.Text = "5";
   this.Button5.Click += new System.EventHandler(this.rakamlar);
   // 
   // Button4
   // 
   this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button4.Location = new System.Drawing.Point(56, 104);
   this.Button4.Name = "Button4";
   this.Button4.Size = new System.Drawing.Size(32, 24);
   this.Button4.TabIndex = 31;
   this.Button4.Text = "4";
   this.Button4.Click += new System.EventHandler(this.rakamlar);
   // 
   // Button3
   // 
   this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button3.Location = new System.Drawing.Point(120, 80);
   this.Button3.Name = "Button3";
   this.Button3.Size = new System.Drawing.Size(32, 24);
   this.Button3.TabIndex = 30;
   this.Button3.Text = "3";
   this.Button3.Click += new System.EventHandler(this.rakamlar);
   // 
   // Button2
   // 
   this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button2.Location = new System.Drawing.Point(88, 80);
   this.Button2.Name = "Button2";
   this.Button2.Size = new System.Drawing.Size(32, 24);
   this.Button2.TabIndex = 29;
   this.Button2.Text = "2";
   this.Button2.Click += new System.EventHandler(this.rakamlar);
   // 
   // Button1
   // 
   this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button1.Location = new System.Drawing.Point(56, 80);
   this.Button1.Name = "Button1";
   this.Button1.Size = new System.Drawing.Size(32, 24);
   this.Button1.TabIndex = 28;
   this.Button1.Text = "1";
   this.Button1.Click += new System.EventHandler(this.rakamlar);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(240, 190);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Button_Geri_Sil,
                                                              this.Button_C,
                                                              this.Button_MR,
                                                              this.Button_MEksi,
                                                              this.Button_MArtý,
                                                              this.Button_MC,
                                                              this.Button_Kök,
                                                              this.Button_Kare,
                                                              this.Button_bir_bölü_x,
                                                              this.Button_Eþit,
                                                              this.Button_Eksi,
                                                              this.Button_Artý,
                                                              this.Button_Bölü,
                                                              this.Button_Çarpý,
                                                              this.Button_Virgül,
                                                              this.Button_artý_eksi,
                                                              this.textBox1,
                                                              this.Button0,
                                                              this.Button9,
                                                              this.Button8,
                                                              this.Button7,
                                                              this.Button6,
                                                              this.Button5,
                                                              this.Button4,
                                                              this.Button3,
                                                              this.Button2,
                                                              this.Button1});
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
  decimal sayý1, sayý2, hafýza;
  string iþlem;
  Boolean sonuçlandý;

  private void Form1_Load(object sender, System.EventArgs e)
  {
   this.Text = "Bizim Hesap Makinesi";
   textBox1.Text = "";
  }

  private void rakamlar(object sender, System.EventArgs e)
  {
   if (sonuçlandý)
    textBox1.Text = (sender as Button).Text;
   else
    textBox1.Text = textBox1.Text + (sender as Button).Text;
   sonuçlandý = false;
  }
  
  private void Button_artý_eksi_Click(object sender, System.EventArgs e)
  {
   if (textBox1.Text.Length > 0)
    if (textBox1.Text.Substring(0, 1) == "-")
     //Sayýnýn baþýnda - varsa sil
     textBox1.Text = textBox1.Text.Substring(1);
    else
     //- yoksa - ekle
     textBox1.Text = "-" + textBox1.Text.Substring(0);
  }

  private void Button_Virgül_Click(object sender, System.EventArgs e)
  {
   //sayýda virgül yoksa
   if (textBox1.Text.IndexOf(",") <= 0)
    if (textBox1.Text.Length == 0)
     //hiç karakter yoksa 0, ekle
     textBox1.Text = "0,";
    else
     //sayý varsa sonuna virgül ekle
     textBox1.Text = textBox1.Text + ",";
  }

  private void Button_C_Click(object sender, System.EventArgs e)
  {
   textBox1.Text = "";
  }

  private void Button_Geri_Sil_Click(object sender, System.EventArgs e)
  {
   if (textBox1.Text.Length > 0)
    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
  }

  private void hafýza_iþlemleri(object sender, System.EventArgs e)
  {
   if (textBox1.Text.Length == 0)
    textBox1.Text = "0";
   switch((sender as Button).Text)
   {
    case "MC":
     hafýza = 0;
     break;
    case "M+":
     hafýza = hafýza + decimal.Parse(textBox1.Text);
     break;
    case "M-":
     hafýza = hafýza - decimal.Parse(textBox1.Text);
     break;
    case "MR":
     textBox1.Text = hafýza.ToString();
     break;
   }
  }

  private void Dört_Ýþlem(object sender, System.EventArgs e)
  {
   iþlem = (sender as Button).Text;
   if (textBox1.Text.Length == 0)
    textBox1.Text = "0";
   sayý1 = decimal.Parse(textBox1.Text);
   sonuçlandý = true;
  }

  private void Button_Eþit_Click(object sender, System.EventArgs e)
  {
   sayý2 = decimal.Parse(textBox1.Text);
   decimal sonuç=0;
   switch(iþlem)
   {
    case "+":
     sonuç = sayý1 + sayý2;
     break;
    case "-":
     sonuç = sayý1 - sayý2;
     break;
    case "*":
     sonuç = sayý1 * sayý2;
     break;
    case "/":
     if (sayý2 == 0)
      return;
     sonuç = sayý1 / sayý2;
     break;
   }
   sonuçlandý = true;
   textBox1.Text = sonuç.ToString();
   sayý1 = sayý2;
  }

  private void Ýþlem_Yap_2(object sender, System.EventArgs e)
  {
   decimal sayý;
   if (textBox1.Text.Length == 0)
    textBox1.Text = "0";
   sayý = decimal.Parse(textBox1.Text);
   switch((sender as Button).Text)
   {
    case "Kök":
     if (sayý >= 0)
      textBox1.Text = Math.Sqrt((double) sayý).ToString();
     break;
    case "x²":
     textBox1.Text = (sayý * sayý).ToString();
     break;
    case "1/x":
     if (sayý != 0)
      textBox1.Text = (1 / sayý).ToString();
     break;
   }
  }
 }
}
