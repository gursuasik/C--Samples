using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Dock
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Panel Panel3;
  internal System.Windows.Forms.Button Button15;
  internal System.Windows.Forms.Button Button14;
  internal System.Windows.Forms.Button Button13;
  internal System.Windows.Forms.Button Button12;
  internal System.Windows.Forms.Button Button1;
  internal System.Windows.Forms.ImageList ImageList1;
  internal System.Windows.Forms.Panel Panel1;
  internal System.Windows.Forms.Button Button11;
  internal System.Windows.Forms.Button Button9;
  internal System.Windows.Forms.Button Button4;
  internal System.Windows.Forms.Button Button3;
  internal System.Windows.Forms.Button Button2;
  internal System.Windows.Forms.Panel Panel2;
  internal System.Windows.Forms.Button Button10;
  internal System.Windows.Forms.Button Button8;
  internal System.Windows.Forms.Button Button7;
  internal System.Windows.Forms.Button Button6;
  internal System.Windows.Forms.Button Button5;
  internal System.Windows.Forms.ComboBox comboBox1;
  internal System.Windows.Forms.ComboBox comboBox3;
  internal System.Windows.Forms.ComboBox comboBox2;
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
   this.Panel3 = new System.Windows.Forms.Panel();
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.Button15 = new System.Windows.Forms.Button();
   this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
   this.Button14 = new System.Windows.Forms.Button();
   this.Button13 = new System.Windows.Forms.Button();
   this.Button12 = new System.Windows.Forms.Button();
   this.Button1 = new System.Windows.Forms.Button();
   this.Panel1 = new System.Windows.Forms.Panel();
   this.comboBox3 = new System.Windows.Forms.ComboBox();
   this.Button11 = new System.Windows.Forms.Button();
   this.Button9 = new System.Windows.Forms.Button();
   this.Button4 = new System.Windows.Forms.Button();
   this.Button3 = new System.Windows.Forms.Button();
   this.Button2 = new System.Windows.Forms.Button();
   this.Panel2 = new System.Windows.Forms.Panel();
   this.comboBox2 = new System.Windows.Forms.ComboBox();
   this.Button10 = new System.Windows.Forms.Button();
   this.Button8 = new System.Windows.Forms.Button();
   this.Button7 = new System.Windows.Forms.Button();
   this.Button6 = new System.Windows.Forms.Button();
   this.Button5 = new System.Windows.Forms.Button();
   this.Panel3.SuspendLayout();
   this.Panel1.SuspendLayout();
   this.Panel2.SuspendLayout();
   this.SuspendLayout();
   // 
   // Panel3
   // 
   this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.Panel3.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                     this.comboBox1,
                                                                     this.Button15,
                                                                     this.Button14,
                                                                     this.Button13,
                                                                     this.Button12,
                                                                     this.Button1});
   this.Panel3.Location = new System.Drawing.Point(90, 75);
   this.Panel3.Name = "Panel3";
   this.Panel3.Size = new System.Drawing.Size(304, 40);
   this.Panel3.TabIndex = 10;
   // 
   // comboBox1
   // 
   this.comboBox1.Location = new System.Drawing.Point(168, 8);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(128, 21);
   this.comboBox1.TabIndex = 15;
   this.comboBox1.Text = "comboBox1";
   this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
   // 
   // Button15
   // 
   this.Button15.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button15.Image")));
   this.Button15.ImageIndex = 0;
   this.Button15.ImageList = this.ImageList1;
   this.Button15.Location = new System.Drawing.Point(136, 8);
   this.Button15.Name = "Button15";
   this.Button15.Size = new System.Drawing.Size(24, 24);
   this.Button15.TabIndex = 14;
   this.Button15.Text = "15";
   // 
   // ImageList1
   // 
   this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
   this.ImageList1.ImageSize = new System.Drawing.Size(16, 16);
   this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
   this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // Button14
   // 
   this.Button14.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button14.Image")));
   this.Button14.ImageIndex = 14;
   this.Button14.ImageList = this.ImageList1;
   this.Button14.Location = new System.Drawing.Point(104, 8);
   this.Button14.Name = "Button14";
   this.Button14.Size = new System.Drawing.Size(24, 24);
   this.Button14.TabIndex = 13;
   // 
   // Button13
   // 
   this.Button13.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button13.Image")));
   this.Button13.ImageIndex = 13;
   this.Button13.ImageList = this.ImageList1;
   this.Button13.Location = new System.Drawing.Point(72, 8);
   this.Button13.Name = "Button13";
   this.Button13.Size = new System.Drawing.Size(24, 24);
   this.Button13.TabIndex = 12;
   // 
   // Button12
   // 
   this.Button12.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button12.Image")));
   this.Button12.ImageIndex = 12;
   this.Button12.ImageList = this.ImageList1;
   this.Button12.Location = new System.Drawing.Point(40, 8);
   this.Button12.Name = "Button12";
   this.Button12.Size = new System.Drawing.Size(24, 24);
   this.Button12.TabIndex = 11;
   // 
   // Button1
   // 
   this.Button1.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button1.Image")));
   this.Button1.ImageIndex = 11;
   this.Button1.ImageList = this.ImageList1;
   this.Button1.Location = new System.Drawing.Point(8, 8);
   this.Button1.Name = "Button1";
   this.Button1.Size = new System.Drawing.Size(24, 24);
   this.Button1.TabIndex = 10;
   // 
   // Panel1
   // 
   this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.Panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                     this.comboBox3,
                                                                     this.Button11,
                                                                     this.Button9,
                                                                     this.Button4,
                                                                     this.Button3,
                                                                     this.Button2});
   this.Panel1.ForeColor = System.Drawing.SystemColors.Highlight;
   this.Panel1.Location = new System.Drawing.Point(90, 227);
   this.Panel1.Name = "Panel1";
   this.Panel1.Size = new System.Drawing.Size(296, 40);
   this.Panel1.TabIndex = 12;
   // 
   // comboBox3
   // 
   this.comboBox3.Location = new System.Drawing.Point(168, 8);
   this.comboBox3.Name = "comboBox3";
   this.comboBox3.Size = new System.Drawing.Size(120, 21);
   this.comboBox3.TabIndex = 10;
   this.comboBox3.Text = "comboBox3";
   // 
   // Button11
   // 
   this.Button11.ForeColor = System.Drawing.SystemColors.ControlText;
   this.Button11.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button11.Image")));
   this.Button11.ImageIndex = 9;
   this.Button11.ImageList = this.ImageList1;
   this.Button11.Location = new System.Drawing.Point(136, 8);
   this.Button11.Name = "Button11";
   this.Button11.Size = new System.Drawing.Size(24, 24);
   this.Button11.TabIndex = 9;
   // 
   // Button9
   // 
   this.Button9.ForeColor = System.Drawing.SystemColors.ControlText;
   this.Button9.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button9.Image")));
   this.Button9.ImageIndex = 3;
   this.Button9.ImageList = this.ImageList1;
   this.Button9.Location = new System.Drawing.Point(104, 8);
   this.Button9.Name = "Button9";
   this.Button9.Size = new System.Drawing.Size(24, 24);
   this.Button9.TabIndex = 7;
   // 
   // Button4
   // 
   this.Button4.ForeColor = System.Drawing.SystemColors.ControlText;
   this.Button4.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button4.Image")));
   this.Button4.ImageIndex = 2;
   this.Button4.ImageList = this.ImageList1;
   this.Button4.Location = new System.Drawing.Point(40, 8);
   this.Button4.Name = "Button4";
   this.Button4.Size = new System.Drawing.Size(24, 24);
   this.Button4.TabIndex = 2;
   // 
   // Button3
   // 
   this.Button3.ForeColor = System.Drawing.SystemColors.ControlText;
   this.Button3.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button3.Image")));
   this.Button3.ImageIndex = 1;
   this.Button3.ImageList = this.ImageList1;
   this.Button3.Location = new System.Drawing.Point(72, 8);
   this.Button3.Name = "Button3";
   this.Button3.Size = new System.Drawing.Size(24, 24);
   this.Button3.TabIndex = 1;
   // 
   // Button2
   // 
   this.Button2.ForeColor = System.Drawing.SystemColors.ControlText;
   this.Button2.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button2.Image")));
   this.Button2.ImageIndex = 0;
   this.Button2.ImageList = this.ImageList1;
   this.Button2.Location = new System.Drawing.Point(8, 8);
   this.Button2.Name = "Button2";
   this.Button2.Size = new System.Drawing.Size(24, 24);
   this.Button2.TabIndex = 0;
   // 
   // Panel2
   // 
   this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.Panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                     this.comboBox2,
                                                                     this.Button10,
                                                                     this.Button8,
                                                                     this.Button7,
                                                                     this.Button6,
                                                                     this.Button5});
   this.Panel2.ForeColor = System.Drawing.SystemColors.Highlight;
   this.Panel2.Location = new System.Drawing.Point(90, 147);
   this.Panel2.Name = "Panel2";
   this.Panel2.Size = new System.Drawing.Size(304, 40);
   this.Panel2.TabIndex = 11;
   // 
   // comboBox2
   // 
   this.comboBox2.Location = new System.Drawing.Point(168, 8);
   this.comboBox2.Name = "comboBox2";
   this.comboBox2.Size = new System.Drawing.Size(128, 21);
   this.comboBox2.TabIndex = 9;
   this.comboBox2.Text = "comboBox2";
   // 
   // Button10
   // 
   this.Button10.ForeColor = System.Drawing.SystemColors.ControlText;
   this.Button10.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button10.Image")));
   this.Button10.ImageIndex = 7;
   this.Button10.ImageList = this.ImageList1;
   this.Button10.Location = new System.Drawing.Point(136, 8);
   this.Button10.Name = "Button10";
   this.Button10.Size = new System.Drawing.Size(24, 24);
   this.Button10.TabIndex = 8;
   // 
   // Button8
   // 
   this.Button8.ForeColor = System.Drawing.SystemColors.ControlText;
   this.Button8.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button8.Image")));
   this.Button8.ImageIndex = 6;
   this.Button8.ImageList = this.ImageList1;
   this.Button8.Location = new System.Drawing.Point(8, 8);
   this.Button8.Name = "Button8";
   this.Button8.Size = new System.Drawing.Size(24, 24);
   this.Button8.TabIndex = 6;
   // 
   // Button7
   // 
   this.Button7.ForeColor = System.Drawing.SystemColors.ControlText;
   this.Button7.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button7.Image")));
   this.Button7.ImageIndex = 5;
   this.Button7.ImageList = this.ImageList1;
   this.Button7.Location = new System.Drawing.Point(40, 8);
   this.Button7.Name = "Button7";
   this.Button7.Size = new System.Drawing.Size(24, 24);
   this.Button7.TabIndex = 5;
   // 
   // Button6
   // 
   this.Button6.ForeColor = System.Drawing.SystemColors.ControlText;
   this.Button6.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button6.Image")));
   this.Button6.ImageIndex = 4;
   this.Button6.ImageList = this.ImageList1;
   this.Button6.Location = new System.Drawing.Point(104, 8);
   this.Button6.Name = "Button6";
   this.Button6.Size = new System.Drawing.Size(24, 24);
   this.Button6.TabIndex = 4;
   // 
   // Button5
   // 
   this.Button5.ForeColor = System.Drawing.SystemColors.ControlText;
   this.Button5.Image = ((System.Drawing.Bitmap)(resources.GetObject("Button5.Image")));
   this.Button5.ImageIndex = 8;
   this.Button5.ImageList = this.ImageList1;
   this.Button5.Location = new System.Drawing.Point(72, 8);
   this.Button5.Name = "Button5";
   this.Button5.Size = new System.Drawing.Size(24, 24);
   this.Button5.TabIndex = 3;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(480, 342);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Panel1,
                                                              this.Panel2,
                                                              this.Panel3});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.Panel3.ResumeLayout(false);
   this.Panel1.ResumeLayout(false);
   this.Panel2.ResumeLayout(false);
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
   string[] s = {"Yok", "Sola", "Saða", "Üste", "Alta", "Ýçine"};
   comboBox1.Items.AddRange(s);
   comboBox2.Items.AddRange(s);
   comboBox3.Items.AddRange(s);
   //Olaylarý birleþtir
   comboBox2.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
   comboBox3.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
  }

  private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   switch((sender as ComboBox).Text)
   {
    case "Sola":
     (sender as ComboBox).Parent.Dock = DockStyle.Left;
     break;
    case "Saða":
     (sender as ComboBox).Parent.Dock = DockStyle.Right;
     break;
    case "Üste":
     (sender as ComboBox).Parent.Dock = DockStyle.Top;
     break;
    case "Alta":
     (sender as ComboBox).Parent.Dock = DockStyle.Bottom;
     break;
    case "Ýçine":
     (sender as ComboBox).Parent.Dock = DockStyle.Fill;
     break;
    case "Yok":
     (sender as ComboBox).Parent.Dock = DockStyle.None;
     break;
   }
  }

	}
}
