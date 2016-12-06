using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Function_Faktöriyel
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.ListBox listBox1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox textBox2;
  private System.Windows.Forms.TextBox textBox3;
  private System.Windows.Forms.Button button1;
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
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.label2 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.label6 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(16, 32);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(216, 20);
   this.textBox1.TabIndex = 0;
   this.textBox1.Text = "textBox1";
   this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(16, 64);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(216, 23);
   this.label1.TabIndex = 1;
   this.label1.Text = "label1";
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(240, 32);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(224, 134);
   this.listBox1.TabIndex = 2;
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(16, 8);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(144, 23);
   this.label2.TabIndex = 3;
   this.label2.Text = "Faktöriyeli alýnacak sayý:";
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(240, 8);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(224, 23);
   this.label3.TabIndex = 4;
   this.label3.Text = "1\'den 20\'ye kadar olan sayýlarýn Faktöriyeli";
   // 
   // label4
   // 
   this.label4.Location = new System.Drawing.Point(16, 96);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(152, 23);
   this.label4.TabIndex = 5;
   this.label4.Text = "Kombinasyon Hesapla:";
   // 
   // label5
   // 
   this.label5.Location = new System.Drawing.Point(16, 120);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(24, 23);
   this.label5.TabIndex = 6;
   this.label5.Text = "n:";
   // 
   // label6
   // 
   this.label6.Location = new System.Drawing.Point(16, 144);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(24, 23);
   this.label6.TabIndex = 7;
   this.label6.Text = "r:";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(64, 120);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 8;
   this.textBox2.Text = "textBox2";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(64, 144);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 9;
   this.textBox3.Text = "textBox3";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(168, 120);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(56, 48);
   this.button1.TabIndex = 10;
   this.button1.Text = "Hesapla";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(472, 174);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.label6,
                                                              this.label5,
                                                              this.label4,
                                                              this.label3,
                                                              this.label2,
                                                              this.listBox1,
                                                              this.label1,
                                                              this.textBox1});
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

  double Fak(byte x)
  {
   byte i ;
   double s;
   s = 1;
   for (i = 1 ; i <= x ; i++)
    s = s * i;
   return s; //sonucu geri gönder
  }

  private void textBox1_TextChanged(object sender, System.EventArgs e)
  {
   byte sayý;
   double sonuç;
   try
   {
    sayý = byte.Parse(textBox1.Text);
    sonuç = Fak(sayý);
    label1.Text = sonuç.ToString();
   }
   catch
   {
    MessageBox.Show("Sayý geçersiz veya çok büyük");
   }
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   byte i;
   for (i = 1 ; i <= 20 ; i++)
    listBox1.Items.Add(Fak(i).ToString());
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   byte n, r;
   double s;
   try
   {
    n = byte.Parse(textBox2.Text);
    r = byte.Parse(textBox3.Text);
    s = Fak(n) / (Fak(r) * Fak((byte) (n - r)));
    MessageBox.Show("n-r kombinasyonu: " + s.ToString());
   }
   catch
   {
    MessageBox.Show("Sayý geçersiz veya çok büyük");
   }
  }
	}
}
