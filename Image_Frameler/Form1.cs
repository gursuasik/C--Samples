using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Image_Frameler
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label label2;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Button button1;
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
   this.label2 = new System.Windows.Forms.Label();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.Label1 = new System.Windows.Forms.Label();
   this.button1 = new System.Windows.Forms.Button();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.SuspendLayout();
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(168, 64);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(120, 23);
   this.label2.TabIndex = 7;
   this.label2.Text = "Label2";
   this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(168, 40);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(126, 13);
   this.Label1.TabIndex = 6;
   this.Label1.Text = "Resimdeki Frame Sayýsý";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(168, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(120, 23);
   this.button1.TabIndex = 5;
   this.button1.Text = "Resim Seç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // pictureBox1
   // 
   this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
   this.pictureBox1.Location = new System.Drawing.Point(8, 8);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(152, 80);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
   this.pictureBox1.TabIndex = 4;
   this.pictureBox1.TabStop = false;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 126);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label1,
                                                              this.button1,
                                                              this.pictureBox1,
                                                              this.label2});
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
    Guid[] g;
    g = resim.FrameDimensionsList;
    System.Drawing.Imaging.FrameDimension f;
    f = new System.Drawing.Imaging.FrameDimension(g[0]);
    int i;
    //Formun geniþliðini bütün frameleri alacak þekilde ayarla
    this.Width = (int) resim.PhysicalDimension.Width * resim.GetFrameCount(f);
    Application.DoEvents();
    this.Height = (int) resim.PhysicalDimension.Height + pictureBox1.Bottom + 50;
    Application.DoEvents();
   
    label2.Text = resim.GetFrameCount(f).ToString();
    if (resim.GetFrameCount(f) == 1 )
     MessageBox.Show("Bu resimde sadece 1 fareme var. \r\n" + 
      "Örneðin etkisini görmek için Animated Gif türü resiler seçiniz");
    Graphics gr;
    gr = this.CreateGraphics();
    this.Invalidate(); //Önceki resmin formdan silinmesini saðla
    Application.DoEvents();
    for (i = 0 ; i<= resim.GetFrameCount(f) - 1 ; i++)
    {
     resim.SelectActiveFrame(f, i);//aktif frameyi seç
     //aktif frameyi forma çiz (pictureBoxun altýna, yan yana çiz)
     gr.DrawImage(resim, i * resim.Width, pictureBox1.Bottom + 10);
    }
    gr.Dispose();
   }
  }
	}
}
