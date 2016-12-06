using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ImageList_ResimParçala
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.PictureBox pictureBox2;
  internal System.Windows.Forms.ImageList ýmageList1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.PictureBox pictureBox1;
  private System.ComponentModel.IContainer components;

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
   this.components = new System.ComponentModel.Container();
   this.pictureBox2 = new System.Windows.Forms.PictureBox();
   this.ýmageList1 = new System.Windows.Forms.ImageList(this.components);
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.Label1 = new System.Windows.Forms.Label();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.SuspendLayout();
   // 
   // pictureBox2
   // 
   this.pictureBox2.Location = new System.Drawing.Point(8, 56);
   this.pictureBox2.Name = "pictureBox2";
   this.pictureBox2.Size = new System.Drawing.Size(424, 40);
   this.pictureBox2.TabIndex = 9;
   this.pictureBox2.TabStop = false;
   // 
   // ýmageList1
   // 
   this.ýmageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
   this.ýmageList1.ImageSize = new System.Drawing.Size(16, 16);
   this.ýmageList1.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(256, 24);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(88, 23);
   this.button2.TabIndex = 8;
   this.button2.Text = "14 Taþ Daðýt";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(176, 24);
   this.button1.Name = "button1";
   this.button1.TabIndex = 7;
   this.button1.Text = "Taþ Seç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(8, 32);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(111, 13);
   this.Label1.TabIndex = 6;
   this.Label1.Text = "Rasgele Seçilen Taþ:";
   // 
   // pictureBox1
   // 
   this.pictureBox1.Location = new System.Drawing.Point(128, 8);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(40, 40);
   this.pictureBox1.TabIndex = 5;
   this.pictureBox1.TabStop = false;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(440, 110);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1,
                                                              this.Label1,
                                                              this.pictureBox1,
                                                              this.pictureBox2});
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
   ýmageList1.ImageSize = new Size(30, 40);
   //Resmi 30 pixel geniþliðinde parçalar olarak ekle 
   ýmageList1.Images.AddStrip(Image.FromFile("okey.gif"));
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   int tas;
   Random r =new Random((int)(System.DateTime.Now.Ticks % 
    System.Int32.MaxValue));
   //ýmageList içinden rasgele bir taþ seç
   tas = r.Next(ýmageList1.Images.Count);
   //pictureBox içinde göster
   pictureBox1.Image = ýmageList1.Images[tas];
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   pictureBox2.Width = 30 * 14;
   int i, tas; 
   Graphics  g = pictureBox2.CreateGraphics();
   Random r =new Random((int)(System.DateTime.Now.Ticks % 
    System.Int32.MaxValue));
   for (i = 0;i<=13;i++)
   {
    tas = r.Next(ýmageList1.Images.Count);
    ýmageList1.Draw(g, i * 30, 0, tas);
   }
   g.Dispose();
  }
	}
}
