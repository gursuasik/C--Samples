using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ScrollBar
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.HScrollBar hScrollBar2;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.HScrollBar hScrollBar1;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // hScrollBar2
   // 
   this.hScrollBar2.Location = new System.Drawing.Point(8, 88);
   this.hScrollBar2.Name = "hScrollBar2";
   this.hScrollBar2.Size = new System.Drawing.Size(176, 17);
   this.hScrollBar2.TabIndex = 7;
   this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(8, 64);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(56, 20);
   this.textBox2.TabIndex = 6;
   this.textBox2.Text = "textBox2";
   // 
   // hScrollBar1
   // 
   this.hScrollBar1.Location = new System.Drawing.Point(8, 32);
   this.hScrollBar1.Name = "hScrollBar1";
   this.hScrollBar1.Size = new System.Drawing.Size(176, 17);
   this.hScrollBar1.TabIndex = 5;
   this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(176, 20);
   this.textBox1.TabIndex = 4;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(192, 118);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.hScrollBar2,
                                                              this.textBox2,
                                                              this.hScrollBar1,
                                                              this.textBox1});
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
   hScrollBar1.Minimum = 0;
   hScrollBar1.Maximum = 100000;
   hScrollBar2.Minimum = hScrollBar2.Left;
   hScrollBar2.Maximum = hScrollBar2.Right - textBox2.Width;
  }

  private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
  {
   textBox1.Text = e.NewValue.ToString(); //textBox1 içindeki sayýyý deðþtir
  }

  private void hScrollBar2_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
  {
   textBox2.Left = e.NewValue;//textBox2nin yatay koordinatýný deðiþtir
  }
	}
}
