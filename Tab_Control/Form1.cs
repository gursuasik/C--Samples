using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tab_Control
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.ImageList ImageList1;
  internal System.Windows.Forms.TabControl tabControl1;
  internal System.Windows.Forms.TabPage TabPage1;
  internal System.Windows.Forms.Label Label12;
  internal System.Windows.Forms.PictureBox PictureBox1;
  internal System.Windows.Forms.TextBox TextBox3;
  internal System.Windows.Forms.TextBox TextBox2;
  internal System.Windows.Forms.TextBox TextBox1;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.TabPage TabPage2;
  internal System.Windows.Forms.TextBox TextBox8;
  internal System.Windows.Forms.Label Label8;
  internal System.Windows.Forms.TextBox TextBox6;
  internal System.Windows.Forms.TextBox TextBox7;
  internal System.Windows.Forms.Label Label6;
  internal System.Windows.Forms.Label Label7;
  internal System.Windows.Forms.TextBox TextBox4;
  internal System.Windows.Forms.TextBox TextBox5;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.TabPage TabPage3;
  internal System.Windows.Forms.TextBox TextBox9;
  internal System.Windows.Forms.Label Label9;
  internal System.Windows.Forms.TextBox TextBox10;
  internal System.Windows.Forms.TextBox TextBox11;
  internal System.Windows.Forms.Label Label10;
  internal System.Windows.Forms.Label Label11;
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
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
   this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
   this.tabControl1 = new System.Windows.Forms.TabControl();
   this.TabPage1 = new System.Windows.Forms.TabPage();
   this.Label12 = new System.Windows.Forms.Label();
   this.PictureBox1 = new System.Windows.Forms.PictureBox();
   this.TextBox3 = new System.Windows.Forms.TextBox();
   this.TextBox2 = new System.Windows.Forms.TextBox();
   this.TextBox1 = new System.Windows.Forms.TextBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.TabPage2 = new System.Windows.Forms.TabPage();
   this.TextBox8 = new System.Windows.Forms.TextBox();
   this.Label8 = new System.Windows.Forms.Label();
   this.TextBox6 = new System.Windows.Forms.TextBox();
   this.TextBox7 = new System.Windows.Forms.TextBox();
   this.Label6 = new System.Windows.Forms.Label();
   this.Label7 = new System.Windows.Forms.Label();
   this.TextBox4 = new System.Windows.Forms.TextBox();
   this.TextBox5 = new System.Windows.Forms.TextBox();
   this.Label4 = new System.Windows.Forms.Label();
   this.Label5 = new System.Windows.Forms.Label();
   this.TabPage3 = new System.Windows.Forms.TabPage();
   this.TextBox9 = new System.Windows.Forms.TextBox();
   this.Label9 = new System.Windows.Forms.Label();
   this.TextBox10 = new System.Windows.Forms.TextBox();
   this.TextBox11 = new System.Windows.Forms.TextBox();
   this.Label10 = new System.Windows.Forms.Label();
   this.Label11 = new System.Windows.Forms.Label();
   this.tabControl1.SuspendLayout();
   this.TabPage1.SuspendLayout();
   this.TabPage2.SuspendLayout();
   this.TabPage3.SuspendLayout();
   this.SuspendLayout();
   // 
   // ImageList1
   // 
   this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
   this.ImageList1.ImageSize = new System.Drawing.Size(32, 32);
   this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
   this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // tabControl1
   // 
   this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.TabPage1,
                                                                          this.TabPage2,
                                                                          this.TabPage3});
   this.tabControl1.ImageList = this.ImageList1;
   this.tabControl1.Location = new System.Drawing.Point(8, 8);
   this.tabControl1.Name = "tabControl1";
   this.tabControl1.SelectedIndex = 0;
   this.tabControl1.Size = new System.Drawing.Size(336, 144);
   this.tabControl1.TabIndex = 1;
   // 
   // TabPage1
   // 
   this.TabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                       this.Label12,
                                                                       this.PictureBox1,
                                                                       this.TextBox3,
                                                                       this.TextBox2,
                                                                       this.TextBox1,
                                                                       this.Label3,
                                                                       this.Label2,
                                                                       this.Label1});
   this.TabPage1.ImageIndex = 0;
   this.TabPage1.Location = new System.Drawing.Point(4, 39);
   this.TabPage1.Name = "TabPage1";
   this.TabPage1.Size = new System.Drawing.Size(328, 101);
   this.TabPage1.TabIndex = 0;
   this.TabPage1.Text = "Kiþisel Bilgiler";
   // 
   // Label12
   // 
   this.Label12.AutoSize = true;
   this.Label12.Location = new System.Drawing.Point(176, 2);
   this.Label12.Name = "Label12";
   this.Label12.Size = new System.Drawing.Size(52, 13);
   this.Label12.TabIndex = 7;
   this.Label12.Text = "Fotoðrafý:";
   // 
   // PictureBox1
   // 
   this.PictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("PictureBox1.Image")));
   this.PictureBox1.Location = new System.Drawing.Point(208, 8);
   this.PictureBox1.Name = "PictureBox1";
   this.PictureBox1.Size = new System.Drawing.Size(104, 80);
   this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
   this.PictureBox1.TabIndex = 8;
   this.PictureBox1.TabStop = false;
   // 
   // TextBox3
   // 
   this.TextBox3.Location = new System.Drawing.Point(72, 64);
   this.TextBox3.Name = "TextBox3";
   this.TextBox3.TabIndex = 6;
   this.TextBox3.Text = "TextBox3";
   // 
   // TextBox2
   // 
   this.TextBox2.Location = new System.Drawing.Point(72, 40);
   this.TextBox2.Name = "TextBox2";
   this.TextBox2.TabIndex = 5;
   this.TextBox2.Text = "TextBox2";
   // 
   // TextBox1
   // 
   this.TextBox1.Location = new System.Drawing.Point(72, 16);
   this.TextBox1.Name = "TextBox1";
   this.TextBox1.TabIndex = 4;
   this.TextBox1.Text = "TextBox1";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 64);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 3;
   this.Label3.Text = "Kan Grubu";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 40);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 2;
   this.Label2.Text = "Mesleði:";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 16);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 1;
   this.Label1.Text = "Adý Soyadý:";
   // 
   // TabPage2
   // 
   this.TabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                       this.TextBox8,
                                                                       this.Label8,
                                                                       this.TextBox6,
                                                                       this.TextBox7,
                                                                       this.Label6,
                                                                       this.Label7,
                                                                       this.TextBox4,
                                                                       this.TextBox5,
                                                                       this.Label4,
                                                                       this.Label5});
   this.TabPage2.ImageIndex = 1;
   this.TabPage2.Location = new System.Drawing.Point(4, 39);
   this.TabPage2.Name = "TabPage2";
   this.TabPage2.Size = new System.Drawing.Size(328, 101);
   this.TabPage2.TabIndex = 1;
   this.TabPage2.Text = "Ýletiþim Bilgileri";
   this.TabPage2.Visible = false;
   // 
   // TextBox8
   // 
   this.TextBox8.Location = new System.Drawing.Point(200, 32);
   this.TextBox8.Multiline = true;
   this.TextBox8.Name = "TextBox8";
   this.TextBox8.Size = new System.Drawing.Size(120, 64);
   this.TextBox8.TabIndex = 15;
   this.TextBox8.Text = "TextBox8";
   // 
   // Label8
   // 
   this.Label8.Location = new System.Drawing.Point(200, 8);
   this.Label8.Name = "Label8";
   this.Label8.TabIndex = 14;
   this.Label8.Text = "Adresi:";
   // 
   // TextBox6
   // 
   this.TextBox6.Location = new System.Drawing.Point(80, 76);
   this.TextBox6.Name = "TextBox6";
   this.TextBox6.TabIndex = 13;
   this.TextBox6.Text = "TextBox6";
   // 
   // TextBox7
   // 
   this.TextBox7.Location = new System.Drawing.Point(80, 52);
   this.TextBox7.Name = "TextBox7";
   this.TextBox7.TabIndex = 12;
   this.TextBox7.Text = "TextBox7";
   // 
   // Label6
   // 
   this.Label6.Location = new System.Drawing.Point(8, 76);
   this.Label6.Name = "Label6";
   this.Label6.TabIndex = 11;
   this.Label6.Text = "Cep Telefonu";
   // 
   // Label7
   // 
   this.Label7.Location = new System.Drawing.Point(8, 52);
   this.Label7.Name = "Label7";
   this.Label7.TabIndex = 10;
   this.Label7.Text = "Ev Telefonu";
   // 
   // TextBox4
   // 
   this.TextBox4.Location = new System.Drawing.Point(80, 32);
   this.TextBox4.Name = "TextBox4";
   this.TextBox4.TabIndex = 9;
   this.TextBox4.Text = "TextBox4";
   // 
   // TextBox5
   // 
   this.TextBox5.Location = new System.Drawing.Point(80, 8);
   this.TextBox5.Name = "TextBox5";
   this.TextBox5.TabIndex = 8;
   this.TextBox5.Text = "TextBox5";
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(8, 32);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 7;
   this.Label4.Text = "Web Sayfasý:";
   // 
   // Label5
   // 
   this.Label5.Location = new System.Drawing.Point(8, 8);
   this.Label5.Name = "Label5";
   this.Label5.TabIndex = 6;
   this.Label5.Text = "Email Adresi:";
   // 
   // TabPage3
   // 
   this.TabPage3.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                       this.TextBox9,
                                                                       this.Label9,
                                                                       this.TextBox10,
                                                                       this.TextBox11,
                                                                       this.Label10,
                                                                       this.Label11});
   this.TabPage3.ImageIndex = 2;
   this.TabPage3.Location = new System.Drawing.Point(4, 39);
   this.TabPage3.Name = "TabPage3";
   this.TabPage3.Size = new System.Drawing.Size(328, 101);
   this.TabPage3.TabIndex = 2;
   this.TabPage3.Text = "Bildiði Diller";
   this.TabPage3.Visible = false;
   // 
   // TextBox9
   // 
   this.TextBox9.Location = new System.Drawing.Point(136, 56);
   this.TextBox9.Name = "TextBox9";
   this.TextBox9.TabIndex = 18;
   this.TextBox9.Text = "TextBox9";
   // 
   // Label9
   // 
   this.Label9.AutoSize = true;
   this.Label9.Location = new System.Drawing.Point(8, 56);
   this.Label9.Name = "Label9";
   this.Label9.Size = new System.Drawing.Size(124, 13);
   this.Label9.TabIndex = 17;
   this.Label9.Text = "Bildiði Ýkinci Yabancý Dil";
   // 
   // TextBox10
   // 
   this.TextBox10.Location = new System.Drawing.Point(136, 32);
   this.TextBox10.Name = "TextBox10";
   this.TextBox10.TabIndex = 16;
   this.TextBox10.Text = "TextBox10";
   // 
   // TextBox11
   // 
   this.TextBox11.Location = new System.Drawing.Point(136, 8);
   this.TextBox11.Name = "TextBox11";
   this.TextBox11.TabIndex = 15;
   this.TextBox11.Text = "TextBox11";
   // 
   // Label10
   // 
   this.Label10.AutoSize = true;
   this.Label10.Location = new System.Drawing.Point(8, 31);
   this.Label10.Name = "Label10";
   this.Label10.Size = new System.Drawing.Size(126, 13);
   this.Label10.TabIndex = 14;
   this.Label10.Text = "En Ýyi Bildiði Yabancý Dil";
   // 
   // Label11
   // 
   this.Label11.AutoSize = true;
   this.Label11.Location = new System.Drawing.Point(8, 8);
   this.Label11.Name = "Label11";
   this.Label11.Size = new System.Drawing.Size(43, 13);
   this.Label11.TabIndex = 13;
   this.Label11.Text = "Ana Dili";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(352, 166);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.tabControl1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.tabControl1.ResumeLayout(false);
   this.TabPage1.ResumeLayout(false);
   this.TabPage2.ResumeLayout(false);
   this.TabPage3.ResumeLayout(false);
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
	}
}
