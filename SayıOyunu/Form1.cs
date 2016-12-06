using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SayýOyunu
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label label7;
  internal System.Windows.Forms.Label Label6;
  internal System.Windows.Forms.Label label5;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Label label3;
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
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.label7 = new System.Windows.Forms.Label();
   this.Label6 = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.Label4 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(248, 40);
   this.button2.Name = "button2";
   this.button2.TabIndex = 19;
   this.button2.Text = "Baþla";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(248, 8);
   this.button1.Name = "button1";
   this.button1.TabIndex = 18;
   this.button1.Text = "Tamam";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label7
   // 
   this.label7.Location = new System.Drawing.Point(112, 85);
   this.label7.Name = "label7";
   this.label7.TabIndex = 17;
   this.label7.Text = "label7";
   // 
   // Label6
   // 
   this.Label6.Location = new System.Drawing.Point(8, 85);
   this.Label6.Name = "Label6";
   this.Label6.TabIndex = 16;
   this.Label6.Text = "Puan";
   // 
   // label5
   // 
   this.label5.Location = new System.Drawing.Point(112, 64);
   this.label5.Name = "label5";
   this.label5.TabIndex = 15;
   this.label5.Text = "label5";
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(8, 64);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 14;
   this.Label4.Text = "Tahmin Sayýsý:";
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(112, 32);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(128, 32);
   this.label3.TabIndex = 13;
   this.label3.Text = "label3";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 12;
   this.Label2.Text = "Durum:";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(144, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 11;
   this.textBox1.Text = "textBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(136, 23);
   this.Label1.TabIndex = 10;
   this.Label1.Text = "0-100 arasý bir sayý girin";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(328, 110);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1,
                                                              this.label7,
                                                              this.Label6,
                                                              this.label5,
                                                              this.Label4,
                                                              this.label3,
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

  int sayý;
  private void Form1_Load(object sender, System.EventArgs e)
  {
   textBox1.Text = "";
   button1.Enabled = false;
   this.AcceptButton = button1;//entere tuþuna basýlýnca otomatik çalýþsýn
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   //Baþla düðmesi
   button1.Enabled = true;
   button2.Enabled = false;
   Random r = new Random();
   sayý = r.Next(100); //0-100 arasý bir sayý tut
   label7.Text = "1000"; //baþlangýçta 1000 puan
   label5.Text = "0"; //tahmin sayýsý 0
   label3.Text = "";
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   int tahmin_sayýsý, puan, tahmin;
   try
   {
    tahmin = int.Parse(textBox1.Text);
   }
   catch
   {
    MessageBox.Show("Geçersiz sayý");
    return;//prosedürden çýk
   }
   tahmin_sayýsý = int.Parse(label5.Text);
   tahmin_sayýsý ++;//Tahmin sayýsýný artýr
   label5.Text = tahmin_sayýsý.ToString(); 
   puan = int.Parse(label7.Text);
   puan = puan - tahmin_sayýsý*10;
   label7.Text = puan.ToString();   //Puaný azalt
   //Tutulan sayý ile tahmin edileni karþýlaþtýr
   if (sayý < tahmin)
    label3.Text = "Sayýyý küçültünüz";
   else
    if (sayý > tahmin)
    label3.Text = "Sayýyý büyütünüz";
   else
   {
    label3.Text = "Tebrikler. " + label5.Text + " defada bilip " + 
     label7.Text + " puan aldýnýz.";
    button2.Enabled = true;
    button1.Enabled = false;
   }
   textBox1.Text = "";
  }
	}
}
