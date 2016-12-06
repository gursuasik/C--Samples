using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Panel_Resim
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.Panel panel1;
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
   this.panel1 = new System.Windows.Forms.Panel();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.button1 = new System.Windows.Forms.Button();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.panel1.SuspendLayout();
   this.SuspendLayout();
   // 
   // panel1
   // 
   this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                     this.pictureBox1});
   this.panel1.Location = new System.Drawing.Point(16, 8);
   this.panel1.Name = "panel1";
   this.panel1.Size = new System.Drawing.Size(176, 192);
   this.panel1.TabIndex = 2;
   // 
   // pictureBox1
   // 
   this.pictureBox1.Location = new System.Drawing.Point(8, 8);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(160, 176);
   this.pictureBox1.TabIndex = 0;
   this.pictureBox1.TabStop = false;
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(16, 208);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(176, 23);
   this.button1.TabIndex = 3;
   this.button1.Text = "Resim Yükle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(208, 246);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.panel1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.panel1.ResumeLayout(false);
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
   pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
   panel1.AutoScroll = true;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   if(openFileDialog1.ShowDialog()==DialogResult.OK)
    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
  }
	}
}
