using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Matris
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label label3;
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
   this.button1 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 136);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(102, 23);
   this.button1.TabIndex = 18;
   this.button1.Text = "Topla";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(120, 136);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(104, 23);
   this.button2.TabIndex = 17;
   this.button2.Text = "Çarp";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // textBox3
   // 
   this.textBox3.AutoSize = false;
   this.textBox3.Location = new System.Drawing.Point(232, 32);
   this.textBox3.Multiline = true;
   this.textBox3.Name = "textBox3";
   this.textBox3.Size = new System.Drawing.Size(100, 100);
   this.textBox3.TabIndex = 16;
   this.textBox3.Text = "TextBox3";
   // 
   // textBox2
   // 
   this.textBox2.AutoSize = false;
   this.textBox2.Location = new System.Drawing.Point(120, 32);
   this.textBox2.Multiline = true;
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(100, 100);
   this.textBox2.TabIndex = 15;
   this.textBox2.Text = "TextBox2";
   // 
   // textBox1
   // 
   this.textBox1.AutoSize = false;
   this.textBox1.Location = new System.Drawing.Point(8, 32);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(100, 100);
   this.textBox1.TabIndex = 14;
   this.textBox1.Text = "TextBox1";
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(232, 8);
   this.label3.Name = "label3";
   this.label3.TabIndex = 13;
   this.label3.Text = "Label3";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(128, 8);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 12;
   this.Label2.Text = "B Matrisi";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 11;
   this.Label1.Text = "A matrisi";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(344, 166);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.button2,
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.textBox1,
                                                              this.label3,
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

  int [,] a = new int[3,3];
  int [,] b = new int[3,3];
  int [,] c = new int[3,3];

  bool matris_al(string str, int [,] dizi)
  {
   string[] s;
   char[] bölücüler = { ' ',  '\r'};
   s=str.Split(bölücüler);
   if (s.GetUpperBound(0)<8 )
   {
    MessageBox.Show("Matris yanlýþ girilmiþ");
    return false;
   }
   int i, j, k=0;
   for (i = 0 ; i <= 2 ; i++)
    for (j = 0 ; j <= 2 ; j++)
    {
     dizi[i,j]=int.Parse(s[k]);
     k++;
    }
   return true;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   //Topla düðmesi
   matris_al(textBox1.Text,a);
   matris_al(textBox2.Text,b);
   int i, j;
   label3.Text = "A+B Matrisi";
   textBox3.Text = "";
   for (i = 0 ; i <= 2 ; i++)
   {
    for (j = 0 ; j <= 2 ; j++)
    {
     c[i,j] = a[i,j] + b[i,j];
     textBox3.Text = textBox3.Text + " " + c[i,j].ToString();
    }
    textBox3.Text = textBox3.Text + "\r\n";//alt satýra geçir
   }
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   //Çarp düðmesi
   matris_al(textBox1.Text,a);
   matris_al(textBox2.Text,b);
   int i, j, k, x=0;
   label3.Text = "AxB Matrisi";
   textBox3.Text = "";
   //çarpýmý bul
   for (i = 0 ; i <= 2 ; i++)
   {
    for (j = 0 ; j <= 2 ; j++)
    {
     x = 0;
     for (k = 0 ; k <= 2 ; k++)
     {
      x = x + a[i, k] * b[k, j];
     }
     c[i, j] = x;
    }
   }
   //sonucu textBox3 içine yaz
   for (i = 0 ; i <= 2 ; i++)
   {
    for (j = 0 ; j <= 2 ; j++)
     textBox3.Text = textBox3.Text + "  " + c[i, j].ToString();
    textBox3.Text = textBox3.Text + "\r\n";
   }
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   MessageBox.Show("Matrisleri elemanlar arasýna boþluk býrakarak yazýnýz\r\n"+
     "Satýrlar arasýnda enter tuþuna basýnýz");
  }
	}
}
