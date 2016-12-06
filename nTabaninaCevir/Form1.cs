using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace nTabaninaCevir
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label label4;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Label label3;
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
   this.label4 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(112, 104);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(104, 23);
   this.button1.TabIndex = 13;
   this.button1.Text = "Çevir";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label4
   // 
   this.label4.Location = new System.Drawing.Point(112, 72);
   this.label4.Name = "label4";
   this.label4.TabIndex = 12;
   this.label4.Text = "label4";
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(8, 72);
   this.label3.Name = "label3";
   this.label3.TabIndex = 11;
   this.label3.Text = "Sonuç";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(112, 40);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 10;
   this.textBox2.Text = "textBox2";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 40);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 9;
   this.Label2.Text = "Hangi tabana";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(112, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 8;
   this.textBox1.Text = "textBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(104, 24);
   this.Label1.TabIndex = 7;
   this.Label1.Text = "Çevrilecek Sayý";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(224, 134);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.label4,
                                                              this.label3,
                                                              this.textBox2,
                                                              this.Label2,
                                                              this.textBox1,
                                                              this.Label1});
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

  string tabançevir(long x, int n)
  {
   //2 den küçük taban olamaz
   if (n < 2) 
    return  "-1";
   long  b;
   string s="";
   while (x >= n)
   {
    b = x % n; //n'e bölümünde kalan
    x = x / n; //n'e tam böl
    if (b > 9)
     s = (char)(55 + b) + s;
    else
     s = b + s;
   }
   if (x > 9)
    s = (char)(55 + x) + s;
   else
    s = x + s;
   return s;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   long x;
   int n;
   try
   {
    x = int.Parse(textBox1.Text);
    n = int.Parse(textBox2.Text);
    label3.Text = n.ToString() + " tabanýnda " + x.ToString() + "=";
    label4.Text = tabançevir(x, n);
   }
   catch
   {
    MessageBox.Show("Sayý hatalý");
   }
  }
	}
}
