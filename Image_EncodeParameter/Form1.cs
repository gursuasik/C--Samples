using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Imaging; //Bunu kod penceresinin en üstüne yazýn
namespace Image_EncodeParameter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.ListBox listBox1;
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
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.SuspendLayout();
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(328, 8);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(56, 8);
   this.pictureBox1.TabIndex = 5;
   this.pictureBox1.TabStop = false;
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(163, 13);
   this.Label1.TabIndex = 4;
   this.Label1.Text = "Jpeg Encoderi ve Parametreleri";
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 32);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(432, 225);
   this.listBox1.TabIndex = 3;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(448, 270);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.pictureBox1,
                                                              this.Label1,
                                                              this.listBox1});
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
   int i, j;
   ImageCodecInfo enc;
   Image resim;
   resim = pictureBox1.Image;
   //Yüklü kodlayýcý bilgilerini tara
   for (i = 0 ; i<= ImageCodecInfo.GetImageEncoders().Length - 1 ; i++)
   {
    enc = ImageCodecInfo.GetImageEncoders()[i];
    //Jpegi bul
    if (enc.MimeType == "image/jpeg")
    {
     //Jpege ait Encoder bilgilerini ekle
     listBox1.Items.Add("Codec Adý: " + 
      enc.CodecName);
     listBox1.Items.Add("Dosya uzantýlarý: " + 
      enc.FilenameExtension);
     listBox1.Items.Add("Codec Açýklamasý: " + 
      enc.FormatDescription);
     listBox1.Items.Add("Codec Guid Numarasý: " + 
      enc.Clsid.ToString());
     listBox1.Items.Add("Codec Mime Bilgisi: " + 
      enc.MimeType);
     listBox1.Items.Add("-------Encoder Parametreleri----------");
     EncoderParameter[] p;
     p = resim.GetEncoderParameterList(enc.Clsid).Param;
     listBox1.Items.Add("Toplam Parametre Sayýsý:" + p.GetUpperBound(0) + 1);
     for (j = 0 ; j<= p.GetUpperBound(0) ; j++)
     {
      listBox1.Items.Add("------" + "Parametre: " + j + "------");
      listBox1.Items.Add("Parametre türü:" + p[j].Type.ToString());
      listBox1.Items.Add("Deðer türü:" + p[j].ValueType.ToString());
      listBox1.Items.Add("Deðer sayýsý:" + p[j].NumberOfValues.ToString());
     }
     listBox1.Items.Add("--------------------------------------");
     }
   }
  }
	}
}
