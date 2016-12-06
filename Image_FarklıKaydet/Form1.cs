using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Imaging;//Bunu kod penceresinin en üstüne yazýn
namespace Image_FarklýKaydet
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Panel Panel1;
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.GroupBox GroupBox3;
  internal System.Windows.Forms.RadioButton radioButton7;
  internal System.Windows.Forms.RadioButton radioButton6;
  internal System.Windows.Forms.RadioButton radioButton5;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.GroupBox GroupBox2;
  internal System.Windows.Forms.RadioButton radioButton3;
  internal System.Windows.Forms.RadioButton radioButton4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.SaveFileDialog saveFileDialog1;
  internal System.Windows.Forms.GroupBox GroupBox1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.RadioButton radioButton2;
  internal System.Windows.Forms.RadioButton radioButton1;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.NumericUpDown numericUpDown1;
  internal System.Windows.Forms.Label Label1;
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
   this.Panel1 = new System.Windows.Forms.Panel();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.GroupBox3 = new System.Windows.Forms.GroupBox();
   this.radioButton7 = new System.Windows.Forms.RadioButton();
   this.radioButton6 = new System.Windows.Forms.RadioButton();
   this.radioButton5 = new System.Windows.Forms.RadioButton();
   this.Label4 = new System.Windows.Forms.Label();
   this.button4 = new System.Windows.Forms.Button();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.GroupBox2 = new System.Windows.Forms.GroupBox();
   this.radioButton3 = new System.Windows.Forms.RadioButton();
   this.radioButton4 = new System.Windows.Forms.RadioButton();
   this.Label3 = new System.Windows.Forms.Label();
   this.button3 = new System.Windows.Forms.Button();
   this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
   this.GroupBox1 = new System.Windows.Forms.GroupBox();
   this.button2 = new System.Windows.Forms.Button();
   this.radioButton2 = new System.Windows.Forms.RadioButton();
   this.radioButton1 = new System.Windows.Forms.RadioButton();
   this.Label2 = new System.Windows.Forms.Label();
   this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
   this.Label1 = new System.Windows.Forms.Label();
   this.button1 = new System.Windows.Forms.Button();
   this.Panel1.SuspendLayout();
   this.GroupBox3.SuspendLayout();
   this.GroupBox2.SuspendLayout();
   this.GroupBox1.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
   this.SuspendLayout();
   // 
   // Panel1
   // 
   this.Panel1.AutoScroll = true;
   this.Panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                     this.pictureBox1});
   this.Panel1.Location = new System.Drawing.Point(8, 8);
   this.Panel1.Name = "Panel1";
   this.Panel1.Size = new System.Drawing.Size(312, 288);
   this.Panel1.TabIndex = 10;
   // 
   // pictureBox1
   // 
   this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
   this.pictureBox1.Location = new System.Drawing.Point(8, 4);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(296, 280);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
   this.pictureBox1.TabIndex = 2;
   this.pictureBox1.TabStop = false;
   // 
   // GroupBox3
   // 
   this.GroupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.radioButton7,
                                                                        this.radioButton6,
                                                                        this.radioButton5,
                                                                        this.Label4,
                                                                        this.button4});
   this.GroupBox3.Location = new System.Drawing.Point(320, 208);
   this.GroupBox3.Name = "GroupBox3";
   this.GroupBox3.Size = new System.Drawing.Size(288, 88);
   this.GroupBox3.TabIndex = 9;
   this.GroupBox3.TabStop = false;
   this.GroupBox3.Text = "TIFF";
   // 
   // radioButton7
   // 
   this.radioButton7.Location = new System.Drawing.Point(208, 24);
   this.radioButton7.Name = "radioButton7";
   this.radioButton7.Size = new System.Drawing.Size(48, 24);
   this.radioButton7.TabIndex = 11;
   this.radioButton7.Text = "LZW";
   // 
   // radioButton6
   // 
   this.radioButton6.Location = new System.Drawing.Point(120, 24);
   this.radioButton6.Name = "radioButton6";
   this.radioButton6.Size = new System.Drawing.Size(80, 24);
   this.radioButton6.TabIndex = 10;
   this.radioButton6.Text = "CCITT-3";
   // 
   // radioButton5
   // 
   this.radioButton5.Location = new System.Drawing.Point(64, 24);
   this.radioButton5.Name = "radioButton5";
   this.radioButton5.Size = new System.Drawing.Size(48, 24);
   this.radioButton5.TabIndex = 9;
   this.radioButton5.Text = "Yok";
   // 
   // Label4
   // 
   this.Label4.AutoSize = true;
   this.Label4.Location = new System.Drawing.Point(8, 28);
   this.Label4.Name = "Label4";
   this.Label4.Size = new System.Drawing.Size(53, 13);
   this.Label4.TabIndex = 8;
   this.Label4.Text = "Sýkýþtýrma";
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(200, 56);
   this.button4.Name = "button4";
   this.button4.TabIndex = 0;
   this.button4.Text = "Kaydet";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // GroupBox2
   // 
   this.GroupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.radioButton3,
                                                                        this.radioButton4,
                                                                        this.Label3,
                                                                        this.button3});
   this.GroupBox2.Location = new System.Drawing.Point(320, 136);
   this.GroupBox2.Name = "GroupBox2";
   this.GroupBox2.Size = new System.Drawing.Size(288, 64);
   this.GroupBox2.TabIndex = 8;
   this.GroupBox2.TabStop = false;
   this.GroupBox2.Text = "BMP";
   // 
   // radioButton3
   // 
   this.radioButton3.Location = new System.Drawing.Point(64, 24);
   this.radioButton3.Name = "radioButton3";
   this.radioButton3.Size = new System.Drawing.Size(48, 24);
   this.radioButton3.TabIndex = 10;
   this.radioButton3.Text = "Yok";
   // 
   // radioButton4
   // 
   this.radioButton4.Location = new System.Drawing.Point(128, 24);
   this.radioButton4.Name = "radioButton4";
   this.radioButton4.Size = new System.Drawing.Size(48, 24);
   this.radioButton4.TabIndex = 9;
   this.radioButton4.Text = "RLE";
   // 
   // Label3
   // 
   this.Label3.AutoSize = true;
   this.Label3.Location = new System.Drawing.Point(8, 28);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(53, 13);
   this.Label3.TabIndex = 8;
   this.Label3.Text = "Sýkýþtýrma";
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(200, 24);
   this.button3.Name = "button3";
   this.button3.TabIndex = 0;
   this.button3.Text = "Kaydet";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // saveFileDialog1
   // 
   this.saveFileDialog1.FileName = "doc1";
   // 
   // GroupBox1
   // 
   this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.button2,
                                                                        this.radioButton2,
                                                                        this.radioButton1,
                                                                        this.Label2,
                                                                        this.numericUpDown1,
                                                                        this.Label1});
   this.GroupBox1.Location = new System.Drawing.Point(320, 32);
   this.GroupBox1.Name = "GroupBox1";
   this.GroupBox1.Size = new System.Drawing.Size(288, 96);
   this.GroupBox1.TabIndex = 7;
   this.GroupBox1.TabStop = false;
   this.GroupBox1.Text = "Jpeg";
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(200, 24);
   this.button2.Name = "button2";
   this.button2.TabIndex = 8;
   this.button2.Text = "Kaydet";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // radioButton2
   // 
   this.radioButton2.Location = new System.Drawing.Point(184, 64);
   this.radioButton2.Name = "radioButton2";
   this.radioButton2.Size = new System.Drawing.Size(88, 24);
   this.radioButton2.TabIndex = 7;
   this.radioButton2.Text = "Progressive";
   // 
   // radioButton1
   // 
   this.radioButton1.Location = new System.Drawing.Point(104, 64);
   this.radioButton1.Name = "radioButton1";
   this.radioButton1.Size = new System.Drawing.Size(72, 24);
   this.radioButton1.TabIndex = 6;
   this.radioButton1.Text = "Standart";
   // 
   // Label2
   // 
   this.Label2.AutoSize = true;
   this.Label2.Location = new System.Drawing.Point(16, 69);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(85, 13);
   this.Label2.TabIndex = 5;
   this.Label2.Text = "Gösterim Modu:";
   // 
   // numericUpDown1
   // 
   this.numericUpDown1.Location = new System.Drawing.Point(112, 24);
   this.numericUpDown1.Name = "numericUpDown1";
   this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
   this.numericUpDown1.TabIndex = 4;
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(20, 27);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(80, 23);
   this.Label1.TabIndex = 3;
   this.Label1.Text = "Resim Kalitesi:";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(320, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(128, 23);
   this.button1.TabIndex = 6;
   this.button1.Text = "Resim Dosyasý Aç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(608, 302);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.GroupBox2,
                                                              this.GroupBox1,
                                                              this.button1,
                                                              this.Panel1,
                                                              this.GroupBox3});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.Panel1.ResumeLayout(false);
   this.GroupBox3.ResumeLayout(false);
   this.GroupBox2.ResumeLayout(false);
   this.GroupBox1.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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

  ImageCodecInfo bul(string MimeType)
  {
   int i;
   for (i = 0 ; i<= ImageCodecInfo.GetImageEncoders().Length - 1 ; i++)
    if (ImageCodecInfo.GetImageEncoders()[i].MimeType == MimeType)
    {
     return ImageCodecInfo.GetImageEncoders()[i];
    }
   return null;
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   numericUpDown1.Minimum = 1;
   numericUpDown1.Maximum = 100;
   numericUpDown1.Value = 50;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   //Dosya Aç
   openFileDialog1.Filter = "Resim  Dosyalarý|" + 
    "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
    try
    {
     pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
    }
    catch
    {
     MessageBox.Show(openFileDialog1.FileName + " geçerli resim dosyasý deðil");
    }
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   //Jpeg Kaydet
   saveFileDialog1.Filter = "Jpeg Dosyasý|*.jpg;*.jpeg";
   saveFileDialog1.DefaultExt = "jpg";
   if (saveFileDialog1.ShowDialog() == DialogResult.OK)
   {
    Image resim;
    resim = pictureBox1.Image;
    ImageCodecInfo Codec_Bilgisi;
    //Jpeg encoderini bul
    Codec_Bilgisi = bul("image/jpeg");

    EncoderParameter parametre1, parametre2;
    //Resim kalitesi 
    long kalite;
    kalite = (long) numericUpDown1.Value;
    parametre1 = new EncoderParameter(Encoder.Quality, kalite);
    if (radioButton1.Checked)
     parametre2 = new EncoderParameter(Encoder.RenderMethod, 
      (int) EncoderValue.RenderNonProgressive);
    else
     parametre2 = new EncoderParameter(Encoder.RenderMethod, 
      (int)EncoderValue.RenderProgressive);
    EncoderParameters parametreler;
    //2 parametremiz var
    parametreler = new EncoderParameters(2);
    //parametreleri ata
    parametreler.Param[0] = parametre1;
    parametreler.Param[1] = parametre2;
    //kaydet
    resim.Save(saveFileDialog1.FileName, Codec_Bilgisi, parametreler);
   }
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   //BMP Kaydet
   saveFileDialog1.Filter = "Bmp Dosyasý|*.bmp";
   saveFileDialog1.DefaultExt = "bmp";
   if (saveFileDialog1.ShowDialog() == DialogResult.OK)
   {
    Image resim;
    resim = pictureBox1.Image;
    ImageCodecInfo Codec_Bilgisi;
    //Bmp encoderini bul
    Codec_Bilgisi = bul("image/bmp");

    EncoderParameter parametre;
    //Sýkýþtýrma
    if (radioButton3.Checked)
     parametre = new EncoderParameter(Encoder.Compression, 
      (int) EncoderValue.CompressionNone);
    else
     parametre = new EncoderParameter(Encoder.Compression, 
      (int)EncoderValue.CompressionRle);
    EncoderParameters parametreler;
    //1 parametremiz var
    parametreler = new EncoderParameters(1);
    //parametreleri ata
    parametreler.Param[0] = parametre;
    //kaydet
    resim.Save(saveFileDialog1.FileName, Codec_Bilgisi, parametreler);
   }
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   //TIFF Kaydet
   saveFileDialog1.Filter = "Tiff Dosyasý|*.tif;*.tiff";
   saveFileDialog1.DefaultExt = "tif";
   if (saveFileDialog1.ShowDialog() == DialogResult.OK)
   {
    Bitmap resim;
    resim = (Bitmap) pictureBox1.Image;
    ImageCodecInfo Codec_Bilgisi;
    //tiff encoderini bul
    Codec_Bilgisi = bul("image/tiff");

    EncoderParameter parametre=null;
   
    if (radioButton5.Checked)
     parametre = new EncoderParameter(Encoder.Compression, 
      (long)EncoderValue.CompressionNone);
    if (radioButton6.Checked)
     parametre = new EncoderParameter(Encoder.Compression, 
      (long)EncoderValue.CompressionCCITT3);
    if (radioButton7.Checked)
     parametre = new EncoderParameter(Encoder.Compression, 
      (long)EncoderValue.CompressionLZW);
    EncoderParameters parametreler;
    if (radioButton6.Checked==false)
    {
     parametreler = new EncoderParameters(1);
     parametreler.Param[0] = parametre;
    }
    else
    {
     parametreler = new EncoderParameters(2);
     parametreler.Param[0] = parametre;
     EncoderParameter parametre2;
     parametre2 = new EncoderParameter(Encoder.ColorDepth, (long)1);
     parametreler.Param[1] = parametre2;
    }
    //kaydet
    try
    {
     resim.Save(saveFileDialog1.FileName, Codec_Bilgisi, parametreler);
    }
    catch
    {
     MessageBox.Show("Dosya bu formata çevirilemedi");
    }
   }
  }

  
 }
}
