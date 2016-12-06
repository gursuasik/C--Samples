using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Radio_Button2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.GroupBox GroupBox1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.TextBox textBox5;
  internal System.Windows.Forms.RadioButton radioButton3;
  internal System.Windows.Forms.RadioButton radioButton2;
  internal System.Windows.Forms.RadioButton radioButton1;
  internal System.Windows.Forms.TextBox textBox4;
  internal System.Windows.Forms.TextBox textBox3;
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
   this.Label5 = new System.Windows.Forms.Label();
   this.Label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.textBox5 = new System.Windows.Forms.TextBox();
   this.GroupBox1 = new System.Windows.Forms.GroupBox();
   this.radioButton3 = new System.Windows.Forms.RadioButton();
   this.radioButton2 = new System.Windows.Forms.RadioButton();
   this.radioButton1 = new System.Windows.Forms.RadioButton();
   this.textBox4 = new System.Windows.Forms.TextBox();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.GroupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // Label5
   // 
   this.Label5.Location = new System.Drawing.Point(8, 112);
   this.Label5.Name = "Label5";
   this.Label5.TabIndex = 41;
   this.Label5.Text = "Tutar";
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(8, 88);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 37;
   this.Label4.Text = "KDV";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 64);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 36;
   this.Label3.Text = "Adeti";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(120, 40);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 35;
   this.textBox2.Text = "textBox2";
   this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 40);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 34;
   this.Label2.Text = "Birim Fiyatý";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(120, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 33;
   this.textBox1.Text = "textBox1";
   // 
   // textBox5
   // 
   this.textBox5.Location = new System.Drawing.Point(120, 112);
   this.textBox5.Name = "textBox5";
   this.textBox5.ReadOnly = true;
   this.textBox5.TabIndex = 42;
   this.textBox5.Text = "textBox5";
   this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // GroupBox1
   // 
   this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.radioButton3,
                                                                        this.radioButton2,
                                                                        this.radioButton1});
   this.GroupBox1.Location = new System.Drawing.Point(224, 8);
   this.GroupBox1.Name = "GroupBox1";
   this.GroupBox1.Size = new System.Drawing.Size(136, 128);
   this.GroupBox1.TabIndex = 40;
   this.GroupBox1.TabStop = false;
   this.GroupBox1.Text = "Malzeme Cinsi:";
   // 
   // radioButton3
   // 
   this.radioButton3.Location = new System.Drawing.Point(24, 80);
   this.radioButton3.Name = "radioButton3";
   this.radioButton3.TabIndex = 2;
   this.radioButton3.Text = "Gýda";
   // 
   // radioButton2
   // 
   this.radioButton2.Location = new System.Drawing.Point(24, 48);
   this.radioButton2.Name = "radioButton2";
   this.radioButton2.TabIndex = 1;
   this.radioButton2.Text = "Kýrtasiye";
   // 
   // radioButton1
   // 
   this.radioButton1.Location = new System.Drawing.Point(24, 16);
   this.radioButton1.Name = "radioButton1";
   this.radioButton1.TabIndex = 0;
   this.radioButton1.Text = "Beyaz Eþya";
   // 
   // textBox4
   // 
   this.textBox4.Location = new System.Drawing.Point(120, 88);
   this.textBox4.Name = "textBox4";
   this.textBox4.ReadOnly = true;
   this.textBox4.TabIndex = 39;
   this.textBox4.Text = "textBox4";
   this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(120, 64);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 38;
   this.textBox3.Text = "textBox3";
   this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 16);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 32;
   this.Label1.Text = "Malzeme Adý";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(360, 150);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label5,
                                                              this.Label4,
                                                              this.Label3,
                                                              this.textBox2,
                                                              this.Label2,
                                                              this.textBox1,
                                                              this.textBox5,
                                                              this.GroupBox1,
                                                              this.textBox4,
                                                              this.textBox3,
                                                              this.Label1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.GroupBox1.ResumeLayout(false);
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
   //Olaylarý birleþtir. 
   textBox3.TextChanged += new EventHandler(textBox2_TextChanged);
   textBox4.TextChanged += new EventHandler(textBox2_TextChanged);
   radioButton1.CheckedChanged += new EventHandler(textBox2_TextChanged);
   radioButton2.CheckedChanged += new EventHandler(textBox2_TextChanged);
   radioButton3.CheckedChanged += new EventHandler(textBox2_TextChanged);
   //textBox3,textBox4,radioButton1,radioButton2 ve radioButton3 için de textBox2_TextChaged olayý çalýþacaktýr
  }

  private void textBox2_TextChanged(object sender, System.EventArgs e)
  {
   decimal a, bf, kdv=0, t;
   try
   {
    bf = decimal.Parse(textBox2.Text);
    a = decimal.Parse(textBox3.Text);
    t = bf * a;
    //Beyaz eþya iþaretli ise Kdv %25 
    if (radioButton1.Checked==true) kdv = t * (decimal)0.25;
    //Kýrtasiye iþaretli ise Kdv %18 
    if (radioButton2.Checked==true) kdv = t * (decimal)0.18;
    //Gýda iþaretli ise Kdv %8 
    if (radioButton3.Checked==true) kdv = t * (decimal)0.08;
    t = t + kdv;
    textBox4.Text = kdv.ToString();
    textBox5.Text = t.ToString();
   }
   catch
   {;}
  }
	}
}
