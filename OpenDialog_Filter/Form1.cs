using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace OpenDialog_Filter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.RichTextBox richTextBox1;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.PictureBox pictureBox1;
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
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.richTextBox1 = new System.Windows.Forms.RichTextBox();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(192, 144);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(312, 112);
   this.textBox1.TabIndex = 7;
   this.textBox1.Text = "TextBox1";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(16, 144);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(168, 23);
   this.button1.TabIndex = 6;
   this.button1.Text = "Dosya Aç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // richTextBox1
   // 
   this.richTextBox1.Location = new System.Drawing.Point(192, 8);
   this.richTextBox1.Name = "richTextBox1";
   this.richTextBox1.Size = new System.Drawing.Size(312, 128);
   this.richTextBox1.TabIndex = 5;
   this.richTextBox1.Text = "RichTextBox1";
   // 
   // pictureBox1
   // 
   this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
   this.pictureBox1.Location = new System.Drawing.Point(8, 8);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(176, 128);
   this.pictureBox1.TabIndex = 4;
   this.pictureBox1.TabStop = false;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(512, 262);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.richTextBox1,
                                                              this.pictureBox1,
                                                              this.textBox1});
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
   openFileDialog1.Title = "Açýlacak dosyayý seçiniz";
   openFileDialog1.Filter = "Text Dosyalarý|*.TXT|" + 
    "RTF Dosyalarý|*.RTF|" + 
    "Resimler|*.GIF;*.BMP;*.JPG;*.WMF;*PNG;*.TIF|" + 
    "Programlar|*.EXE";
   openFileDialog1.FilterIndex = 1;
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
    switch(openFileDialog1.FilterIndex)
    {
     case 1: //Text dosyasý ise Edit1 içinde göster
      textBox1.Text = "";
      System.IO.TextReader dosya = System.IO.File.OpenText(openFileDialog1.FileName);
      string satýr;
      while((satýr = dosya.ReadLine())!= null)
       textBox1.Text+=satýr+(char)13+(char)10;
      dosya.Close();
      break;
     case 2: //RTF ise richTextBox içinde göster
      richTextBox1.LoadFile(openFileDialog1.FileName);
      break;
     case 3: //Resimse pictureBox içinde göster
      pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
      break;
     case 4: //Programsa çalýþtýr
      System.Diagnostics.Process.Start(openFileDialog1.FileName);
      break;
    }
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   textBox1.Multiline = true;
   pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
  }
	}
}
