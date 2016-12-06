using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Radio_Button
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.RadioButton radioButton3;
  internal System.Windows.Forms.RadioButton radioButton2;
  internal System.Windows.Forms.RadioButton radioButton1;
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
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.radioButton3 = new System.Windows.Forms.RadioButton();
   this.radioButton2 = new System.Windows.Forms.RadioButton();
   this.radioButton1 = new System.Windows.Forms.RadioButton();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 48);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(328, 96);
   this.textBox1.TabIndex = 7;
   this.textBox1.Text = "textBox1";
   // 
   // radioButton3
   // 
   this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
   this.radioButton3.Image = ((System.Drawing.Bitmap)(resources.GetObject("radioButton3.Image")));
   this.radioButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.radioButton3.Location = new System.Drawing.Point(272, 16);
   this.radioButton3.Name = "radioButton3";
   this.radioButton3.Size = new System.Drawing.Size(64, 24);
   this.radioButton3.TabIndex = 6;
   this.radioButton3.Text = "Saða";
   this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
   // 
   // radioButton2
   // 
   this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
   this.radioButton2.Image = ((System.Drawing.Bitmap)(resources.GetObject("radioButton2.Image")));
   this.radioButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.radioButton2.Location = new System.Drawing.Point(128, 16);
   this.radioButton2.Name = "radioButton2";
   this.radioButton2.Size = new System.Drawing.Size(72, 24);
   this.radioButton2.TabIndex = 5;
   this.radioButton2.Text = "Ortaya";
   this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
   // 
   // radioButton1
   // 
   this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
   this.radioButton1.Image = ((System.Drawing.Bitmap)(resources.GetObject("radioButton1.Image")));
   this.radioButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.radioButton1.Location = new System.Drawing.Point(8, 16);
   this.radioButton1.Name = "radioButton1";
   this.radioButton1.Size = new System.Drawing.Size(64, 24);
   this.radioButton1.TabIndex = 4;
   this.radioButton1.Text = "Sola";
   this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(344, 158);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox1,
                                                              this.radioButton3,
                                                              this.radioButton2,
                                                              this.radioButton1});
   this.Name = "Form1";
   this.Text = "Form1";
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

   private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
   {
      textBox1.TextAlign = HorizontalAlignment.Left;
   }

   private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
   {
      textBox1.TextAlign = HorizontalAlignment.Center;
   }

   private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
   {
      textBox1.TextAlign = HorizontalAlignment.Right;
   }
	}
}
