using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Check_Box
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.CheckBox checkBox2;
  internal System.Windows.Forms.TextBox textBox4;
  internal System.Windows.Forms.CheckBox checkBox1;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.checkBox2 = new System.Windows.Forms.CheckBox();
   this.textBox4 = new System.Windows.Forms.TextBox();
   this.checkBox1 = new System.Windows.Forms.CheckBox();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.Label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // checkBox2
   // 
   this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.checkBox2.Location = new System.Drawing.Point(115, 104);
   this.checkBox2.Name = "checkBox2";
   this.checkBox2.TabIndex = 19;
   this.checkBox2.Text = "Bayii";
   // 
   // textBox4
   // 
   this.textBox4.Location = new System.Drawing.Point(120, 128);
   this.textBox4.Name = "textBox4";
   this.textBox4.ReadOnly = true;
   this.textBox4.TabIndex = 18;
   this.textBox4.Text = "textBox4";
   this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // checkBox1
   // 
   this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.checkBox1.Location = new System.Drawing.Point(115, 80);
   this.checkBox1.Name = "checkBox1";
   this.checkBox1.TabIndex = 17;
   this.checkBox1.Text = "&18 KDV";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(120, 56);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 16;
   this.textBox3.Text = "textBox3";
   this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(8, 128);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 15;
   this.Label4.Text = "Tutarý";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 56);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 14;
   this.Label3.Text = "Adeti";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(120, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 13;
   this.textBox2.Text = "textBox2";
   this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 12;
   this.Label2.Text = "Birim Fiyatý";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(120, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 11;
   this.textBox1.Text = "textBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 10;
   this.Label1.Text = "Malzeme Adý";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(232, 158);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.checkBox2,
                                                              this.textBox4,
                                                              this.checkBox1,
                                                              this.textBox3,
                                                              this.Label4,
                                                              this.Label3,
                                                              this.textBox2,
                                                              this.Label2,
                                                              this.textBox1,
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
   textBox3.TextChanged += new EventHandler(textBox2_TextChanged);
   checkBox1.CheckedChanged += new EventHandler(textBox2_TextChanged);
   checkBox2.CheckedChanged += new EventHandler(textBox2_TextChanged);
  }

  private void textBox2_TextChanged(object sender, System.EventArgs e)
  {
   int a, bf, t;
   try
   {
    bf = int.Parse(textBox2.Text);
    a  = int.Parse(textBox3.Text);
    t  = bf * a;
    if (checkBox1.Checked==true) //iþaretli ise %18 Kdv ekle
     t =(int) (t+ t * 0.18);
    if (checkBox2.Checked==true) //iþaretli ise %25 indirim yap
     t = (int)(t - t * 0.25);
    textBox4.Text = t.ToString();
   }
   catch
   {;}
  }
	}
}
