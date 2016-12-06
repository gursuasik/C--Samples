using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace VizeFinalButunleme
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox textBox1;
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
   this.label1 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(0, 16);
   this.label1.Name = "label1";
   this.label1.TabIndex = 0;
   this.label1.Text = "Vize Notunuz:";
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(0, 48);
   this.label2.Name = "label2";
   this.label2.TabIndex = 1;
   this.label2.Text = "Final Notunuz:";
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(0, 88);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(112, 23);
   this.label3.TabIndex = 2;
   this.label3.Text = "B�t�nleme Notunuz:";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(112, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 3;
   this.textBox1.Text = "textBox1";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(112, 48);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 4;
   this.textBox2.Text = "textBox2";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(112, 88);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 5;
   this.textBox3.Text = "textBox3";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(112, 120);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(104, 23);
   this.button1.TabIndex = 6;
   this.button1.Text = "Hesapla";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(224, 150);
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
   int v, f, b;
   float ort;
   try
   {
    v = int.Parse(textBox1.Text);
    f = int.Parse(textBox2.Text);
   }
   catch
   {
    MessageBox.Show("Vize ve final i�in ge�erli say� girilmemi�");
    return;
   }
   ort = v * 40 / 100 + f * 60 / 100;
   if (ort >= 49.5 && f >= 50) 
    MessageBox.Show("Ge�tiniz, Ortalaman�z:" + ort.ToString());
   else
   {
    MessageBox.Show("B�t�nlemeye Kald�n�z");
    try
    {
     b = int.Parse(textBox3.Text);
    }
    catch
    {
     MessageBox.Show("B�t�nleme i�in ge�erli say� girilmemi�");
     return;
    }
    ort = v * 40 / 100 + b * 60 / 100;
    if (ort >= 49.5 && b >= 50) 
     MessageBox.Show("B�t�nlemede ge�tiniz, Ortalaman�z:" + ort.ToString());
    else
     MessageBox.Show("Kald�n�z, Ortalaman�z:" + ort.ToString());
   }
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   textBox1.Text="";
   textBox2.Text="";
   textBox3.Text="";
   this.AcceptButton=button1;
  }
	}
}
