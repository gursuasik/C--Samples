using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ReadOnly
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.TextBox textBox2;
  private System.Windows.Forms.TextBox textBox3;
  private System.Windows.Forms.TextBox textBox4;
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.Label label2;
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
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox4 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.label2 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(8, 24);
   this.label1.Name = "label1";
   this.label1.TabIndex = 0;
   this.label1.Text = "Þifre";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(120, 24);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 1;
   this.textBox1.Text = "textBox1";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(120, 56);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 2;
   this.textBox2.Text = "textBox2";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(120, 88);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 3;
   this.textBox3.Text = "textBox3";
   // 
   // textBox4
   // 
   this.textBox4.Location = new System.Drawing.Point(120, 120);
   this.textBox4.Name = "textBox4";
   this.textBox4.TabIndex = 4;
   this.textBox4.Text = "textBox4";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(232, 24);
   this.button1.Name = "button1";
   this.button1.TabIndex = 5;
   this.button1.Text = "Tamam";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(8, 56);
   this.label2.Name = "label2";
   this.label2.TabIndex = 6;
   this.label2.Text = "Adýnýz";
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(8, 88);
   this.label3.Name = "label3";
   this.label3.TabIndex = 7;
   this.label3.Text = "Soyadýnýz";
   // 
   // label4
   // 
   this.label4.Location = new System.Drawing.Point(8, 120);
   this.label4.Name = "label4";
   this.label4.TabIndex = 8;
   this.label4.Text = "Doðum Yeriniz";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(312, 150);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label4,
                                                              this.label3,
                                                              this.label2,
                                                              this.button1,
                                                              this.textBox4,
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.textBox1,
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
   textBox1.PasswordChar='*';
   foreach(Control i in this.Controls)
    if (i.GetType().Name == "TextBox")
     ((TextBox)i).ReadOnly = true;
   textBox1.ReadOnly=false;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   Boolean d;
   if (textBox1.Text=="1234")
    d=false;
   else
    d=true;
   foreach(Control i in this.Controls)
    if (i.GetType().Name == "TextBox")
     ((TextBox)i).ReadOnly = d;
   textBox1.ReadOnly=false;
  }
  
	}
}
