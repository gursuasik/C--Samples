using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Binlik_Ayýr
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label label5;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Button Button1;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Label Label3;
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
   this.label5 = new System.Windows.Forms.Label();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Button1 = new System.Windows.Forms.Button();
   this.Label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // label5
   // 
   this.label5.Location = new System.Drawing.Point(112, 80);
   this.label5.Name = "label5";
   this.label5.TabIndex = 17;
   this.label5.Text = "label5";
   this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(112, 56);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 16;
   this.textBox3.Text = "textBox3";
   this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(112, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 15;
   this.textBox2.Text = "textBox2";
   this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(112, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 14;
   this.textBox1.Text = "textBox1";
   // 
   // Button1
   // 
   this.Button1.Location = new System.Drawing.Point(112, 104);
   this.Button1.Name = "Button1";
   this.Button1.Size = new System.Drawing.Size(104, 24);
   this.Button1.TabIndex = 13;
   this.Button1.Text = "Hesapla";
   this.Button1.Click += new System.EventHandler(this.Button1_Click);
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(8, 80);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 12;
   this.Label4.Text = "Tutar";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 56);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 11;
   this.Label3.Text = "Adet";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 8);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 10;
   this.Label2.Text = "Satýlan Mal";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 32);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 9;
   this.Label1.Text = "Birim Fiyat";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(224, 134);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label5,
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.textBox1,
                                                              this.Button1,
                                                              this.Label4,
                                                              this.Label3,
                                                              this.Label2,
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

  private void textBox2_TextChanged(object sender, System.EventArgs e)
  {
   try
   {
    decimal ücret;
    ücret = decimal.Parse(textBox2.Text);
    textBox2.Text =ücret.ToString("N");
    textBox2.SelectionStart = textBox2.Text.Length; //kursörü sona götür
   }
   catch
   {;}
  }

  private void Button1_Click(object sender, System.EventArgs e)
  {
   try
   {
    decimal tutar;
    tutar=decimal.Parse(textBox2.Text)*decimal.Parse(textBox3.Text);
    label5.Text=tutar.ToString("C0");
   }
   catch
   {
    MessageBox.Show("Geçersiz sayýlar tespit edildi");
   }
  }
 }
}
