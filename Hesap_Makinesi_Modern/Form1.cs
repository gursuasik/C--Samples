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
  internal System.Windows.Forms.Button Button_MArt�;
  internal System.Windows.Forms.Button Button_MC;
  internal System.Windows.Forms.Button Button_K�k;
  internal System.Windows.Forms.Button Button_Kare;
  internal System.Windows.Forms.Button Button_bir_b�l�_x;
  internal System.Windows.Forms.Button Button_E�it;
  internal System.Windows.Forms.Button Button_Eksi;
  internal System.Windows.Forms.Button Button_Art�;
  internal System.Windows.Forms.Button Button_B�l�;
  internal System.Windows.Forms.Button Button_�arp�;
  internal System.Windows.Forms.Button Button_Virg�l;
  internal System.Windows.Forms.Button Button_art�_eksi;
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
   this.Button_MArt� = new System.Windows.Forms.Button();
   this.Button_MC = new System.Windows.Forms.Button();
   this.Button_K�k = new System.Windows.Forms.Button();
   this.Button_Kare = new System.Windows.Forms.Button();
   this.Button_bir_b�l�_x = new System.Windows.Forms.Button();
   this.Button_E�it = new System.Windows.Forms.Button();
   this.Button_Eksi = new System.Windows.Forms.Button();
   this.Button_Art� = new System.Windows.Forms.Button();
   this.Button_B�l� = new System.Windows.Forms.Button();
   this.Button_�arp� = new System.Windows.Forms.Button();
   this.Button_Virg�l = new System.Windows.Forms.Button();
   this.Button_art�_eksi = new System.Windows.Forms.Button();
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
   this.Button_MR.Click += new System.EventHandler(this.haf�za_i�lemleri);
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
   this.Button_MEksi.Click += new System.EventHandler(this.haf�za_i�lemleri);
   // 
   // Button_MArt�
   // 
   this.Button_MArt�.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_MArt�.ForeColor = System.Drawing.Color.Blue;
   this.Button_MArt�.Location = new System.Drawing.Point(16, 104);
   this.Button_MArt�.Name = "Button_MArt�";
   this.Button_MArt�.Size = new System.Drawing.Size(32, 24);
   this.Button_MArt�.TabIndex = 50;
   this.Button_MArt�.Text = "M+";
   this.Button_MArt�.Click += new System.EventHandler(this.haf�za_i�lemleri);
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
   this.Button_MC.Click += new System.EventHandler(this.haf�za_i�lemleri);
   // 
   // Button_K�k
   // 
   this.Button_K�k.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_K�k.Location = new System.Drawing.Point(192, 80);
   this.Button_K�k.Name = "Button_K�k";
   this.Button_K�k.Size = new System.Drawing.Size(32, 24);
   this.Button_K�k.TabIndex = 48;
   this.Button_K�k.Text = "K�k";
   this.Button_K�k.Click += new System.EventHandler(this.��lem_Yap_2);
   // 
   // Button_Kare
   // 
   this.Button_Kare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_Kare.Location = new System.Drawing.Point(192, 104);
   this.Button_Kare.Name = "Button_Kare";
   this.Button_Kare.Size = new System.Drawing.Size(32, 24);
   this.Button_Kare.TabIndex = 47;
   this.Button_Kare.Text = "x�";
   this.Button_Kare.Click += new System.EventHandler(this.��lem_Yap_2);
   // 
   // Button_bir_b�l�_x
   // 
   this.Button_bir_b�l�_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_bir_b�l�_x.Location = new System.Drawing.Point(192, 128);
   this.Button_bir_b�l�_x.Name = "Button_bir_b�l�_x";
   this.Button_bir_b�l�_x.Size = new System.Drawing.Size(32, 24);
   this.Button_bir_b�l�_x.TabIndex = 46;
   this.Button_bir_b�l�_x.Text = "1/x";
   this.Button_bir_b�l�_x.Click += new System.EventHandler(this.��lem_Yap_2);
   // 
   // Button_E�it
   // 
   this.Button_E�it.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_E�it.Location = new System.Drawing.Point(192, 152);
   this.Button_E�it.Name = "Button_E�it";
   this.Button_E�it.Size = new System.Drawing.Size(32, 24);
   this.Button_E�it.TabIndex = 45;
   this.Button_E�it.Text = "=";
   this.Button_E�it.Click += new System.EventHandler(this.Button_E�it_Click);
   // 
   // Button_Eksi
   // 
   this.Button_Eksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_Eksi.Location = new System.Drawing.Point(160, 152);
   this.Button_Eksi.Name = "Button_Eksi";
   this.Button_Eksi.Size = new System.Drawing.Size(32, 24);
   this.Button_Eksi.TabIndex = 44;
   this.Button_Eksi.Text = "-";
   this.Button_Eksi.Click += new System.EventHandler(this.D�rt_��lem);
   // 
   // Button_Art�
   // 
   this.Button_Art�.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_Art�.Location = new System.Drawing.Point(160, 128);
   this.Button_Art�.Name = "Button_Art�";
   this.Button_Art�.Size = new System.Drawing.Size(32, 24);
   this.Button_Art�.TabIndex = 43;
   this.Button_Art�.Text = "+";
   this.Button_Art�.Click += new System.EventHandler(this.D�rt_��lem);
   // 
   // Button_B�l�
   // 
   this.Button_B�l�.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_B�l�.Location = new System.Drawing.Point(160, 104);
   this.Button_B�l�.Name = "Button_B�l�";
   this.Button_B�l�.Size = new System.Drawing.Size(32, 24);
   this.Button_B�l�.TabIndex = 42;
   this.Button_B�l�.Text = "/";
   this.Button_B�l�.Click += new System.EventHandler(this.D�rt_��lem);
   // 
   // Button_�arp�
   // 
   this.Button_�arp�.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_�arp�.Location = new System.Drawing.Point(160, 80);
   this.Button_�arp�.Name = "Button_�arp�";
   this.Button_�arp�.Size = new System.Drawing.Size(32, 24);
   this.Button_�arp�.TabIndex = 41;
   this.Button_�arp�.Text = "*";
   this.Button_�arp�.Click += new System.EventHandler(this.D�rt_��lem);
   // 
   // Button_Virg�l
   // 
   this.Button_Virg�l.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_Virg�l.Location = new System.Drawing.Point(120, 152);
   this.Button_Virg�l.Name = "Button_Virg�l";
   this.Button_Virg�l.Size = new System.Drawing.Size(32, 24);
   this.Button_Virg�l.TabIndex = 40;
   this.Button_Virg�l.Text = ",";
   this.Button_Virg�l.Click += new System.EventHandler(this.Button_Virg�l_Click);
   // 
   // Button_art�_eksi
   // 
   this.Button_art�_eksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.Button_art�_eksi.Location = new System.Drawing.Point(56, 152);
   this.Button_art�_eksi.Name = "Button_art�_eksi";
   this.Button_art�_eksi.Size = new System.Drawing.Size(32, 24);
   this.Button_art�_eksi.TabIndex = 39;
   this.Button_art�_eksi.Text = "�";
   this.Button_art�_eksi.Click += new System.EventHandler(this.Button_art�_eksi_Click);
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
                                                              this.Button_MArt�,
                                                              this.Button_MC,
                                                              this.Button_K�k,
                                                              this.Button_Kare,
                                                              this.Button_bir_b�l�_x,
                                                              this.Button_E�it,
                                                              this.Button_Eksi,
                                                              this.Button_Art�,
                                                              this.Button_B�l�,
                                                              this.Button_�arp�,
                                                              this.Button_Virg�l,
                                                              this.Button_art�_eksi,
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
  decimal say�1, say�2, haf�za;
  string i�lem;
  Boolean sonu�land�;

  private void Form1_Load(object sender, System.EventArgs e)
  {
   this.Text = "Bizim Hesap Makinesi";
   textBox1.Text = "";
  }

  private void rakamlar(object sender, System.EventArgs e)
  {
   if (sonu�land�)
    textBox1.Text = (sender as Button).Text;
   else
    textBox1.Text = textBox1.Text + (sender as Button).Text;
   sonu�land� = false;
  }
  
  private void Button_art�_eksi_Click(object sender, System.EventArgs e)
  {
   if (textBox1.Text.Length > 0)
    if (textBox1.Text.Substring(0, 1) == "-")
     //Say�n�n ba��nda - varsa sil
     textBox1.Text = textBox1.Text.Substring(1);
    else
     //- yoksa - ekle
     textBox1.Text = "-" + textBox1.Text.Substring(0);
  }

  private void Button_Virg�l_Click(object sender, System.EventArgs e)
  {
   //say�da virg�l yoksa
   if (textBox1.Text.IndexOf(",") <= 0)
    if (textBox1.Text.Length == 0)
     //hi� karakter yoksa 0, ekle
     textBox1.Text = "0,";
    else
     //say� varsa sonuna virg�l ekle
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

  private void haf�za_i�lemleri(object sender, System.EventArgs e)
  {
   if (textBox1.Text.Length == 0)
    textBox1.Text = "0";
   switch((sender as Button).Text)
   {
    case "MC":
     haf�za = 0;
     break;
    case "M+":
     haf�za = haf�za + decimal.Parse(textBox1.Text);
     break;
    case "M-":
     haf�za = haf�za - decimal.Parse(textBox1.Text);
     break;
    case "MR":
     textBox1.Text = haf�za.ToString();
     break;
   }
  }

  private void D�rt_��lem(object sender, System.EventArgs e)
  {
   i�lem = (sender as Button).Text;
   if (textBox1.Text.Length == 0)
    textBox1.Text = "0";
   say�1 = decimal.Parse(textBox1.Text);
   sonu�land� = true;
  }

  private void Button_E�it_Click(object sender, System.EventArgs e)
  {
   say�2 = decimal.Parse(textBox1.Text);
   decimal sonu�=0;
   switch(i�lem)
   {
    case "+":
     sonu� = say�1 + say�2;
     break;
    case "-":
     sonu� = say�1 - say�2;
     break;
    case "*":
     sonu� = say�1 * say�2;
     break;
    case "/":
     if (say�2 == 0)
      return;
     sonu� = say�1 / say�2;
     break;
   }
   sonu�land� = true;
   textBox1.Text = sonu�.ToString();
   say�1 = say�2;
  }

  private void ��lem_Yap_2(object sender, System.EventArgs e)
  {
   decimal say�;
   if (textBox1.Text.Length == 0)
    textBox1.Text = "0";
   say� = decimal.Parse(textBox1.Text);
   switch((sender as Button).Text)
   {
    case "K�k":
     if (say� >= 0)
      textBox1.Text = Math.Sqrt((double) say�).ToString();
     break;
    case "x�":
     textBox1.Text = (say� * say�).ToString();
     break;
    case "1/x":
     if (say� != 0)
      textBox1.Text = (1 / say�).ToString();
     break;
   }
  }
 }
}
