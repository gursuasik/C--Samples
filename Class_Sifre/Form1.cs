using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Class_Sifre
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
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
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(72, 57);
   this.textBox3.Name = "textBox3";
   this.textBox3.Size = new System.Drawing.Size(88, 20);
   this.textBox3.TabIndex = 16;
   this.textBox3.Text = "TextBox3";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 57);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 15;
   this.Label3.Text = "Sonuç";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(72, 33);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(88, 20);
   this.textBox2.TabIndex = 14;
   this.textBox2.Text = "TextBox2";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 33);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(56, 16);
   this.Label2.TabIndex = 13;
   this.Label2.Text = "Þifre";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 16);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(56, 16);
   this.Label1.TabIndex = 12;
   this.Label1.Text = "Metin";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(72, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(88, 20);
   this.textBox1.TabIndex = 11;
   this.textBox1.Text = "TextBox1";
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(184, 48);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(104, 32);
   this.button2.TabIndex = 10;
   this.button2.Text = "Çöz";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(184, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(104, 32);
   this.button1.TabIndex = 9;
   this.button1.Text = "Þifrele";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(296, 86);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox3,
                                                              this.Label3,
                                                              this.textBox2,
                                                              this.Label2,
                                                              this.Label1,
                                                              this.textBox1,
                                                              this.button2,
                                                              this.button1});
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

  private void button1_Click(object sender, System.EventArgs e)
  {
   sifre s = new sifre();
   s.Text  = textBox1.Text;
   s.Þifre = textBox2.Text;
   textBox3.Text = s.Þifrele();
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   sifre s = new sifre(); 
   s.Text = textBox1.Text;
   s.Þifre = textBox2.Text;
   textBox3.Text = s.Çöz();
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   
  }

	}
}












