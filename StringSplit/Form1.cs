using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace StringSplit
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox textBox2;
  private System.Windows.Forms.Button button2;
  private System.Windows.Forms.ListBox listBox1;
  private System.Windows.Forms.ListBox listBox2;
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
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.label2 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.button2 = new System.Windows.Forms.Button();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.listBox2 = new System.Windows.Forms.ListBox();
   this.label3 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(8, 8);
   this.label1.Name = "label1";
   this.label1.TabIndex = 0;
   this.label1.Text = "Adýnýz Soyadýnýz";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(112, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(192, 20);
   this.textBox1.TabIndex = 1;
   this.textBox1.Text = "textBox1";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(328, 8);
   this.button1.Name = "button1";
   this.button1.TabIndex = 2;
   this.button1.Text = "Tamam";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(8, 40);
   this.label2.Name = "label2";
   this.label2.TabIndex = 3;
   this.label2.Text = "Bir kaç cümle girin";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(112, 40);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(192, 20);
   this.textBox2.TabIndex = 4;
   this.textBox2.Text = "textBox2";
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(328, 40);
   this.button2.Name = "button2";
   this.button2.TabIndex = 5;
   this.button2.Text = "Tamam";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 88);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(128, 160);
   this.listBox1.TabIndex = 6;
   // 
   // listBox2
   // 
   this.listBox2.Location = new System.Drawing.Point(144, 88);
   this.listBox2.Name = "listBox2";
   this.listBox2.Size = new System.Drawing.Size(264, 160);
   this.listBox2.TabIndex = 7;
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(8, 72);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(100, 16);
   this.label3.TabIndex = 8;
   this.label3.Text = "Girilen kelimeler";
   // 
   // label4
   // 
   this.label4.Location = new System.Drawing.Point(144, 72);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(128, 12);
   this.label4.TabIndex = 9;
   this.label4.Text = "Girilen cümleler";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(416, 254);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label4,
                                                              this.label3,
                                                              this.listBox2,
                                                              this.listBox1,
                                                              this.button2,
                                                              this.textBox2,
                                                              this.label2,
                                                              this.button1,
                                                              this.textBox1,
                                                              this.label1});
   this.Name = "Form1";
   this.Text = "Form1";
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

  private void button1_Click(object sender, System.EventArgs e)
  {
   string adsoyad, ad, soyad;
   string[] s;
   adsoyad = textBox1.Text;
   s = adsoyad.Split(' ');
   if (s.Length  == 1)//boþluk bulunmadýysa
   {
    ad = s[0];
    MessageBox.Show(ad + " Bey. Soyadýnýzý girmediniz");
   }
   if (s.Length == 2) //Bir boþluk bulunduysa
   {
    ad = s[0];
    soyad = s[1];
    MessageBox.Show(ad + " Bey, Soyadýnýz " + soyad);
   }
   if (s.Length == 3) //iki boþluk bulunduysa
   {
    ad = s[0] + " " + s[1]; //Adamýn ismi iki bölümlüdür
    soyad = s[2];
    MessageBox.Show(ad + " Bey, Soyadýnýz " + soyad);
   }
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   string cümle;
   string[] s;
   int i;
   cümle = textBox2.Text;
   s = cümle.Split(' '); //Kelimeleri bul
   MessageBox.Show(s.Length.ToString() + " kelime yazdýnýz");
   for (i = 0 ; i < s.Length ; i++)
    listBox1.Items.Add(s[i]);
   s = cümle.Split('.'); //Cümleleri bul
   MessageBox.Show(s.Length.ToString() + " cümle yazdýnýz");
   for (i = 0 ; i < s.Length ; i++)
    listBox2.Items.Add(s[i]);
  }
	}
}
