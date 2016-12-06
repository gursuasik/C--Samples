using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Dosyalama_AyarlarýKaydet
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.ColorDialog colorDialog1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.FontDialog fontDialog1;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.TextBox textBox2;
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
   this.button4 = new System.Windows.Forms.Button();
   this.colorDialog1 = new System.Windows.Forms.ColorDialog();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.fontDialog1 = new System.Windows.Forms.FontDialog();
   this.button3 = new System.Windows.Forms.Button();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // button4
   // 
   this.button4.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button4.Location = new System.Drawing.Point(224, 128);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(120, 23);
   this.button4.TabIndex = 9;
   this.button4.Text = "Form Baþlýðýný Ayarla";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // button2
   // 
   this.button2.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button2.Location = new System.Drawing.Point(224, 40);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(120, 23);
   this.button2.TabIndex = 7;
   this.button2.Text = "Zemin rengi seç";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button1.Location = new System.Drawing.Point(224, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(120, 23);
   this.button1.TabIndex = 6;
   this.button1.Text = "Yazý Rengi Seç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // button3
   // 
   this.button3.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button3.Location = new System.Drawing.Point(224, 72);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(120, 23);
   this.button3.TabIndex = 8;
   this.button3.Text = "Yazý Tipi Seç";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // textBox1
   // 
   this.textBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
    | System.Windows.Forms.AnchorStyles.Left) 
    | System.Windows.Forms.AnchorStyles.Right);
   this.textBox1.Location = new System.Drawing.Point(8, 8);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(208, 144);
   this.textBox1.TabIndex = 5;
   this.textBox1.Text = "TextBox1";
   // 
   // textBox2
   // 
   this.textBox2.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.textBox2.Location = new System.Drawing.Point(224, 102);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(120, 20);
   this.textBox2.TabIndex = 10;
   this.textBox2.Text = "textBox2";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(352, 158);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox2,
                                                              this.button1,
                                                              this.button3,
                                                              this.textBox1,
                                                              this.button4,
                                                              this.button2});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
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
   System.IO.FileInfo d = new System.IO.FileInfo("ayarlar.dat");
   if (d.Exists==true) //dosya varsa
   {
    System.IO.TextReader dosya = System.IO.File.OpenText("ayarlar.dat");
    textBox1.Text = dosya.ReadLine();
    textBox1.ForeColor = Color.FromName(dosya.ReadLine());
    textBox1.Font = new Font(dosya.ReadLine(), float.Parse(dosya.ReadLine()), 
     FontStyle.Bold, GraphicsUnit.Point);
    this.Text = dosya.ReadLine();
    textBox2.Text = this.Text;
    this.BackColor = Color.FromName(dosya.ReadLine());
    this.Width = int.Parse(dosya.ReadLine());
    this.Height = int.Parse(dosya.ReadLine());
    dosya.Close(); //dosyayý kapat
   }
  }

  private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   System.IO.TextWriter dosya=System.IO.File.CreateText("ayarlar.dat");
   dosya.WriteLine(textBox1.Text);
   dosya.WriteLine(textBox1.ForeColor.ToKnownColor().ToString());
   dosya.WriteLine(textBox1.Font.Name);
   dosya.WriteLine(textBox1.Font.Size);
   dosya.WriteLine(this.Text);
   dosya.WriteLine(BackColor.ToKnownColor().ToString());
   dosya.WriteLine(this.Size.Width);
   dosya.WriteLine(this.Size.Height);
   dosya.Close();//Dosyayý kapat
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   //Yazý rengini renk diyalog penceresinden seçilen renge ayarla
   if (colorDialog1.ShowDialog() == DialogResult.OK)
    textBox1.ForeColor = colorDialog1.Color;
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   //Formun zemin rengini renk diyalog penceresinden seçilen renge ayarla
   if (colorDialog1.ShowDialog() == DialogResult.OK)
    this.BackColor = colorDialog1.Color;
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   //Yazý tipini font diyalog penceresinden seçilen fonta ayarla
   if (fontDialog1.ShowDialog() == DialogResult.OK)
    textBox1.Font = fontDialog1.Font;
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   //form baþlýðýný kullanýcýya sor
   this.Text = textBox2.Text;
  }
  }
	}

