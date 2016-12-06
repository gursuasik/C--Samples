using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace XOrÞifreleGeliþmiþ
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.TextBox textBox3;
  private System.Windows.Forms.TextBox textBox2;
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
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
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(160, 120);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(104, 23);
   this.button1.TabIndex = 13;
   this.button1.Text = "Þifrele/Çöz";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(160, 88);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 12;
   this.textBox3.Text = "textBox3";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(160, 48);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 11;
   this.textBox2.Text = "textBox2";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(160, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 10;
   this.textBox1.Text = "textBox1";
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(8, 88);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(152, 23);
   this.label3.TabIndex = 9;
   this.label3.Text = "Kodlanmýþ/Çözülmüþ Metin:";
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(8, 48);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(152, 23);
   this.label2.TabIndex = 8;
   this.label2.Text = "Þifre:(0-255)";
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(8, 8);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(152, 23);
   this.label1.TabIndex = 7;
   this.label1.Text = "Metin:";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(272, 150);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.textBox1,
                                                              this.label3,
                                                              this.label2,
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
   string metin, þifre, ÞifreliMetin="";
   int i, j;
   char c;
   metin = textBox1.Text;
   þifre = textBox2.Text;
   //Þifrele
   for (j = 0 ; j <= þifre.Length - 1 ; j++)
   {
    ÞifreliMetin = "";
    for (i = 0 ; i <= metin.Length - 1 ; i++)
    {
     c = (char) (metin[i] ^ þifre[j]);
     if (c == '0')
      c =  þifre[j];
     ÞifreliMetin = ÞifreliMetin + (char) c;
    }
    metin = ÞifreliMetin;
   }
   textBox3.Text=ÞifreliMetin;
  }
	}
}
