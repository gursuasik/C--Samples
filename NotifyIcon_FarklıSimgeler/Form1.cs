using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NotifyIcon_FarklýSimgeler
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.NumericUpDown numericUpDown1;
  internal System.Windows.Forms.NotifyIcon notifyIcon1;
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
   this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
   this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
   this.ýmageList1 = new System.Windows.Forms.ImageList(this.components);
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
   this.SuspendLayout();
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 16);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(136, 23);
   this.Label1.TabIndex = 3;
   this.Label1.Text = "Kaçýncý Simge Kullanýlsýn";
   // 
   // numericUpDown1
   // 
   this.numericUpDown1.Location = new System.Drawing.Point(144, 16);
   this.numericUpDown1.Name = "numericUpDown1";
   this.numericUpDown1.TabIndex = 2;
   this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
   // 
   // notifyIcon1
   // 
   this.notifyIcon1.Text = "NotifyIcon1";
   this.notifyIcon1.Visible = true;
   // 
   // ýmageList1
   // 
   this.ýmageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
   this.ýmageList1.ImageSize = new System.Drawing.Size(16, 16);
   this.ýmageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ýmageList1.ImageStream")));
   this.ýmageList1.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(296, 46);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label1,
                                                              this.numericUpDown1});
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
   numericUpDown1.Minimum = 0;
   numericUpDown1.Maximum = 3;
  }

  private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
  {
   Bitmap resim;
   resim = (Bitmap) ýmageList1.Images[(int)numericUpDown1.Value];
   notifyIcon1.Icon = Icon.FromHandle(resim.GetHicon());
  }
	}
}
