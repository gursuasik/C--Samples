using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace OlaylaraOrtakKodYazma
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label label12;
  internal System.Windows.Forms.Label Label11;
  internal System.Windows.Forms.Label label10;
  internal System.Windows.Forms.Label Label9;
  internal System.Windows.Forms.Label label8;
  internal System.Windows.Forms.Label Label7;
  internal System.Windows.Forms.TextBox textBox4;
  internal System.Windows.Forms.Label Label6;
  internal System.Windows.Forms.Label label5;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.label12 = new System.Windows.Forms.Label();
   this.Label11 = new System.Windows.Forms.Label();
   this.label10 = new System.Windows.Forms.Label();
   this.Label9 = new System.Windows.Forms.Label();
   this.label8 = new System.Windows.Forms.Label();
   this.Label7 = new System.Windows.Forms.Label();
   this.textBox4 = new System.Windows.Forms.TextBox();
   this.Label6 = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.Label4 = new System.Windows.Forms.Label();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // label12
   // 
   this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.label12.Location = new System.Drawing.Point(160, 179);
   this.label12.Name = "label12";
   this.label12.TabIndex = 47;
   this.label12.Text = "Label12";
   this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   // 
   // Label11
   // 
   this.Label11.Location = new System.Drawing.Point(16, 184);
   this.Label11.Name = "Label11";
   this.Label11.TabIndex = 46;
   this.Label11.Text = "Net Maaþý";
   // 
   // label10
   // 
   this.label10.Location = new System.Drawing.Point(160, 152);
   this.label10.Name = "label10";
   this.label10.TabIndex = 45;
   this.label10.Text = "Label10";
   this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   // 
   // Label9
   // 
   this.Label9.Location = new System.Drawing.Point(16, 160);
   this.Label9.Name = "Label9";
   this.Label9.TabIndex = 44;
   this.Label9.Text = "%15 SSK Primi";
   // 
   // label8
   // 
   this.label8.Location = new System.Drawing.Point(160, 128);
   this.label8.Name = "label8";
   this.label8.TabIndex = 43;
   this.label8.Text = "Label8";
   this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   // 
   // Label7
   // 
   this.Label7.Location = new System.Drawing.Point(16, 136);
   this.Label7.Name = "Label7";
   this.Label7.TabIndex = 42;
   this.Label7.Text = "%20 Gelir vergisi";
   // 
   // textBox4
   // 
   this.textBox4.Location = new System.Drawing.Point(160, 104);
   this.textBox4.Name = "textBox4";
   this.textBox4.TabIndex = 41;
   this.textBox4.Text = "TextBox4";
   this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // Label6
   // 
   this.Label6.Location = new System.Drawing.Point(16, 112);
   this.Label6.Name = "Label6";
   this.Label6.Size = new System.Drawing.Size(143, 26);
   this.Label6.TabIndex = 40;
   this.Label6.Text = "Ay içinde ödenen avanslar";
   // 
   // label5
   // 
   this.label5.Location = new System.Drawing.Point(160, 80);
   this.label5.Name = "label5";
   this.label5.TabIndex = 39;
   this.label5.Text = "Label5";
   this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(16, 88);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 38;
   this.Label4.Text = "Brüt Maaþý";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(160, 56);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 37;
   this.textBox3.Text = "TextBox3";
   this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(16, 64);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(104, 23);
   this.Label3.TabIndex = 36;
   this.Label3.Text = "Çalýþtýðý Gün Sayýsý";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(160, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 35;
   this.textBox2.Text = "TextBox2";
   this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(16, 40);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 34;
   this.Label2.Text = "Yevmiyesi";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(160, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 33;
   this.textBox1.Text = "TextBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(16, 16);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(72, 24);
   this.Label1.TabIndex = 32;
   this.Label1.Text = "Ýþçinin Adý";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(272, 222);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label12,
                                                              this.Label11,
                                                              this.label10,
                                                              this.Label9,
                                                              this.label8,
                                                              this.Label7,
                                                              this.textBox4,
                                                              this.Label6,
                                                              this.label5,
                                                              this.Label4,
                                                              this.textBox3,
                                                              this.Label3,
                                                              this.textBox2,
                                                              this.Label2,
                                                              this.textBox1,
                                                              this.Label1});
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

  private void textBox2_TextChanged(object sender, System.EventArgs e)
  {
   long Yevmiye, Gün, Net_Maaþ, Vergi, Avans, SSK, Brüt_Maaþ;
   try
   {
    Yevmiye = long.Parse(textBox2.Text);
    Gün = long.Parse(textBox3.Text);
    Avans = long.Parse(textBox4.Text);
   }
   catch
   {
    this.Text = "Geçersiz rakamlar girdiniz.";
    return;
   }
   this.Text = "Maaþ Hesabý";
   Brüt_Maaþ = Yevmiye * Gün;
   //Sayýlarý binlik basamaklara ayýr ve sonuna TL yaz
   label5.Text = String.Format("{0:0,0. TL}", Brüt_Maaþ);
   Vergi = Brüt_Maaþ * 20 / 100;
   label8.Text = String.Format("{0:0,0. TL}", Vergi);
   SSK = Brüt_Maaþ * 15 / 100;
   label10.Text = String.Format("{0:0,0. TL}", SSK);
   Net_Maaþ = Brüt_Maaþ - Avans - Vergi - SSK;
   label12.Text = String.Format("{0:0,0. TL}", Net_Maaþ);
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   textBox3.TextChanged += new System.EventHandler(textBox2_TextChanged);
   textBox4.TextChanged += new System.EventHandler(textBox2_TextChanged);
  }
 }
}
