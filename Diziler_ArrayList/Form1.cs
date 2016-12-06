using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Diziler_ArrayList
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label8;
  internal System.Windows.Forms.Label Label6;
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Label label9;
  internal System.Windows.Forms.TextBox textBox5;
  internal System.Windows.Forms.TextBox textBox4;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label label7;
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
   this.label9 = new System.Windows.Forms.Label();
   this.Label8 = new System.Windows.Forms.Label();
   this.textBox5 = new System.Windows.Forms.TextBox();
   this.textBox4 = new System.Windows.Forms.TextBox();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.label7 = new System.Windows.Forms.Label();
   this.Label6 = new System.Windows.Forms.Label();
   this.Label5 = new System.Windows.Forms.Label();
   this.Label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // label9
   // 
   this.label9.Location = new System.Drawing.Point(104, 168);
   this.label9.Name = "label9";
   this.label9.TabIndex = 31;
   this.label9.Text = "Label9";
   // 
   // Label8
   // 
   this.Label8.Location = new System.Drawing.Point(8, 168);
   this.Label8.Name = "Label8";
   this.Label8.TabIndex = 30;
   this.Label8.Text = "Dizi Boyutu";
   // 
   // textBox5
   // 
   this.textBox5.Location = new System.Drawing.Point(96, 112);
   this.textBox5.Name = "textBox5";
   this.textBox5.TabIndex = 29;
   this.textBox5.Text = "TextBox5";
   // 
   // textBox4
   // 
   this.textBox4.Location = new System.Drawing.Point(96, 88);
   this.textBox4.Name = "textBox4";
   this.textBox4.TabIndex = 28;
   this.textBox4.Text = "TextBox4";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(96, 64);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 27;
   this.textBox3.Text = "TextBox3";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(96, 40);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 26;
   this.textBox2.Text = "TextBox2";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(96, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 25;
   this.textBox1.Text = "TextBox1";
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(208, 48);
   this.button2.Name = "button2";
   this.button2.TabIndex = 24;
   this.button2.Text = "Listele";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(208, 16);
   this.button1.Name = "button1";
   this.button1.TabIndex = 23;
   this.button1.Text = "Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label7
   // 
   this.label7.Location = new System.Drawing.Point(104, 144);
   this.label7.Name = "label7";
   this.label7.TabIndex = 22;
   this.label7.Text = "Label7";
   // 
   // Label6
   // 
   this.Label6.Location = new System.Drawing.Point(8, 144);
   this.Label6.Name = "Label6";
   this.Label6.TabIndex = 21;
   this.Label6.Text = "Personel Sayýsý";
   // 
   // Label5
   // 
   this.Label5.Location = new System.Drawing.Point(8, 112);
   this.Label5.Name = "Label5";
   this.Label5.TabIndex = 20;
   this.Label5.Text = "Çalýþtýðý Bölüm";
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(8, 88);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 19;
   this.Label4.Text = "Doðum Yeri";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 64);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 18;
   this.Label3.Text = "Baba Adý";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 40);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 17;
   this.Label2.Text = "Mesleði";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 16);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 16;
   this.Label1.Text = "Personelin Adý";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(312, 206);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label9,
                                                              this.Label8,
                                                              this.textBox5,
                                                              this.textBox4,
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.textBox1,
                                                              this.button2,
                                                              this.button1,
                                                              this.label7,
                                                              this.Label6,
                                                              this.Label5,
                                                              this.Label4,
                                                              this.Label3,
                                                              this.Label2,
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

  struct personel
  {
   public string Ad,Meslek,BabaAdi,DogumYeri,Bolum;
   public override string  ToString()
   {
    return "Adý=" + Ad + ", Mesleði=" + Meslek + ", Baba Adý=" + BabaAdi+ ", Doðum Yeri=" + DogumYeri+ ", Bölüm=" + Bolum ;
   }
  }
  ArrayList Pers = new ArrayList();

  private void Form1_Load(object sender, System.EventArgs e)
  {
   
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   personel p;
   p.Ad = textBox1.Text;
   p.Meslek = textBox2.Text;
   p.BabaAdi = textBox3.Text;
   p.DogumYeri = textBox4.Text;
   p.Bolum = textBox5.Text;
   Pers.Add(p);
   label7.Text = Pers.Count.ToString();
   label9.Text = Pers.Capacity.ToString();
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   int i;
   Form2 frm = new Form2();
   for (i=0 ; i<=Pers.Count-1 ; i++)
    frm.listBox1.Items.Add(Pers[i].ToString());
   frm.Show();
  }
	}
}
