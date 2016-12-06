using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Decimal_HexaDecimal
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(144, 56);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(125, 23);
   this.button2.TabIndex = 19;
   this.button2.Text = "Çevir";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(4, 58);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(125, 23);
   this.button1.TabIndex = 18;
   this.button1.Text = "Çevir";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(144, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(125, 20);
   this.textBox2.TabIndex = 16;
   this.textBox2.Text = "textBox2";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(4, 34);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(125, 20);
   this.textBox1.TabIndex = 15;
   this.textBox1.Text = "textBox1";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(144, 8);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(125, 23);
   this.Label2.TabIndex = 13;
   this.Label2.Text = "HexaDecimal";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(4, 10);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(125, 23);
   this.Label1.TabIndex = 12;
   this.Label1.Text = "Decimal";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(280, 86);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1,
                                                              this.textBox2,
                                                              this.textBox1,
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

  private void button1_Click(object sender, System.EventArgs e)
  {
   long s;
   try
   {
    s = long.Parse(textBox1.Text);
    textBox2.Text = s.ToString("X16");//16 basamaða tamamla
   }
   catch
   {;}
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   long s;
   try
   {
    s = long.Parse(textBox2.Text,System.Globalization.NumberStyles.HexNumber);
    textBox1.Text = s.ToString();
   }
   catch
   {;}
  }
	}
}
