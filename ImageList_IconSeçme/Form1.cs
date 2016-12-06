using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ImageList_IconSeçme
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.NumericUpDown numericUpDown1;
  internal System.Windows.Forms.ImageList ýmageList1;
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
   this.Label1 = new System.Windows.Forms.Label();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
   this.ýmageList1 = new System.Windows.Forms.ImageList(this.components);
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
   this.SuspendLayout();
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 10);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(64, 23);
   this.Label1.TabIndex = 4;
   this.Label1.Text = "Simge Seç:";
   // 
   // pictureBox1
   // 
   this.pictureBox1.Location = new System.Drawing.Point(88, 40);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(32, 32);
   this.pictureBox1.TabIndex = 3;
   this.pictureBox1.TabStop = false;
   // 
   // numericUpDown1
   // 
   this.numericUpDown1.Location = new System.Drawing.Point(80, 8);
   this.numericUpDown1.Name = "numericUpDown1";
   this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
   this.numericUpDown1.TabIndex = 5;
   this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
   // 
   // ýmageList1
   // 
   this.ýmageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
   this.ýmageList1.ImageSize = new System.Drawing.Size(32, 32);
   this.ýmageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ýmageList1.ImageStream")));
   this.ýmageList1.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(136, 78);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.pictureBox1,
                                                              this.numericUpDown1,
                                                              this.Label1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
   numericUpDown1.Maximum = ýmageList1.Images.Count;
   numericUpDown1.Minimum = 1;
  }

  private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
  {
   Bitmap resim;
   resim = (Bitmap) ýmageList1.Images[(int)(numericUpDown1.Value - 1)];
   this.Icon = Icon.FromHandle(resim.GetHicon());
   pictureBox1.Image = resim;
  }
	}
}
