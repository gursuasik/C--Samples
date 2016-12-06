using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Dosyalama_Binary_Gif
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.PictureBox pictureBox1;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.OpenFileDialog openFileDialog1;
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
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.label1 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.button1 = new System.Windows.Forms.Button();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.SuspendLayout();
   // 
   // pictureBox1
   // 
   this.pictureBox1.Location = new System.Drawing.Point(16, 40);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(288, 264);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
   this.pictureBox1.TabIndex = 0;
   this.pictureBox1.TabStop = false;
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(8, 8);
   this.label1.Name = "label1";
   this.label1.TabIndex = 1;
   this.label1.Text = "Dosya Versiyonu:";
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(120, 8);
   this.label2.Name = "label2";
   this.label2.TabIndex = 2;
   this.label2.Text = "label2";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(232, 8);
   this.button1.Name = "button1";
   this.button1.TabIndex = 3;
   this.button1.Text = "Dosya Seç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(312, 318);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.label2,
                                                              this.label1,
                                                              this.pictureBox1});
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
   openFileDialog1.Filter = "GIF dosyalarý|*.gif";
   openFileDialog1.Title  = "Açýlacak GIF dosyasýný seçiniz";
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
   {
    System.IO.FileStream fs = new System.IO.FileStream(openFileDialog1.FileName ,System.IO.FileMode.Open);
    System.IO.BinaryReader dosya = new System.IO.BinaryReader(fs);
    byte [] d = new byte[6];
    //ilk 6 baytý oku
    d=dosya.ReadBytes(6);
    System.Text.ASCIIEncoding çevirici = new System.Text.ASCIIEncoding();
    string s;
    //okunan bilgileri stringe çevir
    s = çevirici.GetString(d);
    label2.Text=s;
    dosya.Close();
    fs.Close();
    //resmi pictureBox1 içinde göster
    pictureBox1.Image=Image.FromFile(openFileDialog1.FileName);
   }
  }
	}
}
