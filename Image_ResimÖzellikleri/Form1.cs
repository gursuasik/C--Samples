using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Image_ResimÖzellikleri
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label9;
  internal System.Windows.Forms.Label Label7;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label label8;
  internal System.Windows.Forms.Label label6;
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.Label label4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.Label label10;
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
   this.Label9 = new System.Windows.Forms.Label();
   this.Label7 = new System.Windows.Forms.Label();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.button1 = new System.Windows.Forms.Button();
   this.label8 = new System.Windows.Forms.Label();
   this.label6 = new System.Windows.Forms.Label();
   this.Label5 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.label10 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // Label9
   // 
   this.Label9.AutoSize = true;
   this.Label9.Location = new System.Drawing.Point(8, 88);
   this.Label9.Name = "Label9";
   this.Label9.Size = new System.Drawing.Size(119, 13);
   this.Label9.TabIndex = 36;
   this.Label9.Text = "Dikey Çözünürlük (dpi)";
   // 
   // Label7
   // 
   this.Label7.AutoSize = true;
   this.Label7.Location = new System.Drawing.Point(8, 64);
   this.Label7.Name = "Label7";
   this.Label7.Size = new System.Drawing.Size(119, 13);
   this.Label7.TabIndex = 35;
   this.Label7.Text = "Yatay Çözünürlük (dpi)";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 136);
   this.button1.Name = "button1";
   this.button1.TabIndex = 39;
   this.button1.Text = "Resim Seç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Location = new System.Drawing.Point(144, 88);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(38, 13);
   this.label8.TabIndex = 37;
   this.label8.Text = "Label8";
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(144, 64);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(38, 13);
   this.label6.TabIndex = 34;
   this.label6.Text = "Label6";
   // 
   // Label5
   // 
   this.Label5.AutoSize = true;
   this.Label5.Location = new System.Drawing.Point(8, 112);
   this.Label5.Name = "Label5";
   this.Label5.Size = new System.Drawing.Size(70, 13);
   this.Label5.TabIndex = 33;
   this.Label5.Text = "Frame Sayýsý";
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(144, 40);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(38, 13);
   this.label4.TabIndex = 32;
   this.label4.Text = "Label4";
   // 
   // Label3
   // 
   this.Label3.AutoSize = true;
   this.Label3.Location = new System.Drawing.Point(8, 40);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(79, 13);
   this.Label3.TabIndex = 31;
   this.Label3.Text = "Piksel Formatý:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(144, 16);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(38, 13);
   this.label2.TabIndex = 30;
   this.label2.Text = "Label2";
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(8, 16);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(84, 13);
   this.Label1.TabIndex = 29;
   this.Label1.Text = "Resim Boyutlar:";
   // 
   // pictureBox1
   // 
   this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
   this.pictureBox1.Location = new System.Drawing.Point(8, 168);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(344, 200);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
   this.pictureBox1.TabIndex = 28;
   this.pictureBox1.TabStop = false;
   // 
   // label10
   // 
   this.label10.AutoSize = true;
   this.label10.Location = new System.Drawing.Point(144, 112);
   this.label10.Name = "label10";
   this.label10.Size = new System.Drawing.Size(45, 13);
   this.label10.TabIndex = 38;
   this.label10.Text = "Label10";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(360, 374);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label7,
                                                              this.button1,
                                                              this.label8,
                                                              this.label6,
                                                              this.Label5,
                                                              this.label4,
                                                              this.Label3,
                                                              this.label2,
                                                              this.Label1,
                                                              this.pictureBox1,
                                                              this.label10,
                                                              this.Label9});
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
   openFileDialog1.Filter = "Resim  Dosyalarý|" + 
    "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
   {
    Image resim;
    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
    resim = pictureBox1.Image;
    label2.Text = resim.PhysicalDimension.Width + "x" +
     resim.PhysicalDimension.Height;
    label4.Text = resim.PixelFormat.ToString();
    label6.Text = resim.HorizontalResolution.ToString();
    label8.Text = resim.VerticalResolution.ToString();
    Guid[] g;
    g = resim.FrameDimensionsList;
    System.Drawing.Imaging.FrameDimension f ;
    f= new System.Drawing.Imaging.FrameDimension(g[0]);
    label10.Text = resim.GetFrameCount(f).ToString();
   }
  }
	}
}
