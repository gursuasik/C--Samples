using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Imaging;//Bunu kod penceresinin en üstüne yazýn
namespace Image_EncoderDecoder
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.ListBox listBox2;
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
   this.listBox2 = new System.Windows.Forms.ListBox();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // listBox2
   // 
   this.listBox2.Location = new System.Drawing.Point(8, 176);
   this.listBox2.Name = "listBox2";
   this.listBox2.Size = new System.Drawing.Size(480, 134);
   this.listBox2.TabIndex = 7;
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 24);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(480, 134);
   this.listBox1.TabIndex = 6;
   // 
   // Label2
   // 
   this.Label2.AutoSize = true;
   this.Label2.Location = new System.Drawing.Point(8, 160);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(323, 13);
   this.Label2.TabIndex = 5;
   this.Label2.Text = "Bilgisayarýnýzda Yüklü Image Decoderler (Resim kod çözücüler)";
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(309, 13);
   this.Label1.TabIndex = 4;
   this.Label1.Text = "Bilgisayarýnýzda Yüklü Image Encoderler (Resim kodlayýcýlar)";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(496, 318);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.listBox2,
                                                              this.listBox1,
                                                              this.Label2,
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
   int i;
   //Yüklü kodlayýcý bilgilerini listeye ekle
   for (i = 0 ; i<= ImageCodecInfo.GetImageEncoders().Length - 1 ; i++)
   {
    listBox1.Items.Add("Codec Adý: " + 
     ImageCodecInfo.GetImageEncoders()[i].CodecName);
    listBox1.Items.Add("Dosya uzantýlarý: " + 
     ImageCodecInfo.GetImageEncoders()[i].FilenameExtension);
    listBox1.Items.Add("Codec Açýklamasý: " + 
     ImageCodecInfo.GetImageEncoders()[i].FormatDescription);
    listBox1.Items.Add("Codec Guid Numarasý: " + 
     ImageCodecInfo.GetImageEncoders()[i].Clsid.ToString());
    listBox1.Items.Add("Codec Mime Bilgisi: " + 
     ImageCodecInfo.GetImageEncoders()[i].MimeType);
    listBox1.Items.Add("-------------------");
   }

   //Yüklü kod çözücü bilgilerini listeye ekle
   for (i = 0 ; i<= ImageCodecInfo.GetImageDecoders().Length - 1 ; i++)
   {
    listBox2.Items.Add("Codec Adý: " + 
     ImageCodecInfo.GetImageDecoders()[i].CodecName);
    listBox2.Items.Add("Dosya uzantýlarý: " + 
     ImageCodecInfo.GetImageDecoders()[i].FilenameExtension);
    listBox2.Items.Add("Codec Açýklamasý: " + 
     ImageCodecInfo.GetImageDecoders()[i].FormatDescription);
    listBox2.Items.Add("Codec Guid Numarasý: " + 
     ImageCodecInfo.GetImageDecoders()[i].Clsid.ToString());
    listBox2.Items.Add("Codec Mime Bilgisi: " + 
     ImageCodecInfo.GetImageDecoders()[i].MimeType);
    listBox2.Items.Add("-------------------");
   }
  }
	}
}
