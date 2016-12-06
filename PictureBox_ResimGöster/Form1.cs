using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PictureBox_ResimGöster
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.GroupBox GroupBox1;
  internal System.Windows.Forms.CheckBox checkBox1;
  internal System.Windows.Forms.RadioButton radioButton4;
  internal System.Windows.Forms.RadioButton radioButton3;
  internal System.Windows.Forms.RadioButton radioButton2;
  internal System.Windows.Forms.RadioButton radioButton1;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.Button button1;
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
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
   this.GroupBox1 = new System.Windows.Forms.GroupBox();
   this.checkBox1 = new System.Windows.Forms.CheckBox();
   this.radioButton4 = new System.Windows.Forms.RadioButton();
   this.radioButton3 = new System.Windows.Forms.RadioButton();
   this.radioButton2 = new System.Windows.Forms.RadioButton();
   this.radioButton1 = new System.Windows.Forms.RadioButton();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.button2 = new System.Windows.Forms.Button();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.button1 = new System.Windows.Forms.Button();
   this.GroupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // GroupBox1
   // 
   this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.checkBox1,
                                                                        this.radioButton4,
                                                                        this.radioButton3,
                                                                        this.radioButton2,
                                                                        this.radioButton1});
   this.GroupBox1.Location = new System.Drawing.Point(144, 8);
   this.GroupBox1.Name = "GroupBox1";
   this.GroupBox1.Size = new System.Drawing.Size(408, 56);
   this.GroupBox1.TabIndex = 7;
   this.GroupBox1.TabStop = false;
   this.GroupBox1.Text = "Gösterim Modu:";
   // 
   // checkBox1
   // 
   this.checkBox1.Location = new System.Drawing.Point(344, 24);
   this.checkBox1.Name = "checkBox1";
   this.checkBox1.Size = new System.Drawing.Size(53, 24);
   this.checkBox1.TabIndex = 4;
   this.checkBox1.Text = "Döþe";
   this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
   // 
   // radioButton4
   // 
   this.radioButton4.Location = new System.Drawing.Point(280, 24);
   this.radioButton4.Name = "radioButton4";
   this.radioButton4.Size = new System.Drawing.Size(56, 24);
   this.radioButton4.TabIndex = 3;
   this.radioButton4.Text = "Ortala";
   // 
   // radioButton3
   // 
   this.radioButton3.Location = new System.Drawing.Point(152, 24);
   this.radioButton3.Name = "radioButton3";
   this.radioButton3.Size = new System.Drawing.Size(128, 24);
   this.radioButton3.TabIndex = 2;
   this.radioButton3.Text = "Otomatik Boyutlandýr";
   // 
   // radioButton2
   // 
   this.radioButton2.Location = new System.Drawing.Point(88, 24);
   this.radioButton2.Name = "radioButton2";
   this.radioButton2.Size = new System.Drawing.Size(56, 24);
   this.radioButton2.TabIndex = 1;
   this.radioButton2.Text = "Sýðdýr";
   // 
   // radioButton1
   // 
   this.radioButton1.Location = new System.Drawing.Point(16, 24);
   this.radioButton1.Name = "radioButton1";
   this.radioButton1.Size = new System.Drawing.Size(72, 24);
   this.radioButton1.TabIndex = 0;
   this.radioButton1.Text = "Normal";
   this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(8, 40);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(128, 23);
   this.button2.TabIndex = 6;
   this.button2.Text = "Panodan Yapýþtýr";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(8, 72);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(536, 216);
   this.pictureBox1.TabIndex = 4;
   this.pictureBox1.TabStop = false;
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(128, 23);
   this.button1.TabIndex = 5;
   this.button1.Text = "Resim Dosyasý Aç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(552, 294);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.pictureBox1,
                                                              this.button1,
                                                              this.GroupBox1});
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

  private void button1_Click(object sender, System.EventArgs e)
  {
   openFileDialog1.Filter = "Resim  Dosyalarý|" + 
    "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   IDataObject pano = Clipboard.GetDataObject();
   if (pano.GetDataPresent(DataFormats.Bitmap))
    pictureBox1.Image = (Bitmap) pano.GetData(DataFormats.Bitmap);
   else
    MessageBox.Show("Panoda uygun bir resim yok");
  }

  
  private void Form1_Load(object sender, System.EventArgs e)
  {
   //Olaylarý birleþtir
   radioButton2.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
   radioButton3.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
   radioButton4.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
  }

  private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
  {
   if ((sender as RadioButton).Checked)
   {
    switch((sender as RadioButton).Text)
    {
     case "Normal":
      pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
      break;
     case "Sýðdýr":
      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      break;
     case "Otomatik Boyutlandýr":
      pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
      break;
     case "Ortala":
      pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
      break;
    }
    pictureBox1.Width = ClientSize.Width;
    pictureBox1.Height = ClientSize.Height - pictureBox1.Top;
   }
  }

  private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
  {
   if (checkBox1.Checked)
    //Döþemesi için BackgroundImage özelliði kullanýlmalýdýr
    pictureBox1.BackgroundImage = pictureBox1.Image;
   else
    pictureBox1.BackgroundImage = null;
  }
	}
}
