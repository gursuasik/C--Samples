using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CheckButton
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.CheckBox checkBox3;
  internal System.Windows.Forms.CheckBox checkBox2;
  internal System.Windows.Forms.CheckBox checkBox1;
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
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
   this.checkBox3 = new System.Windows.Forms.CheckBox();
   this.checkBox2 = new System.Windows.Forms.CheckBox();
   this.checkBox1 = new System.Windows.Forms.CheckBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // checkBox3
   // 
   this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
   this.checkBox3.Image = ((System.Drawing.Bitmap)(resources.GetObject("checkBox3.Image")));
   this.checkBox3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.checkBox3.Location = new System.Drawing.Point(200, 8);
   this.checkBox3.Name = "checkBox3";
   this.checkBox3.Size = new System.Drawing.Size(72, 24);
   this.checkBox3.TabIndex = 7;
   this.checkBox3.Text = "Altý çizili";
   this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
   // 
   // checkBox2
   // 
   this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
   this.checkBox2.Image = ((System.Drawing.Bitmap)(resources.GetObject("checkBox2.Image")));
   this.checkBox2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.checkBox2.Location = new System.Drawing.Point(104, 8);
   this.checkBox2.Name = "checkBox2";
   this.checkBox2.Size = new System.Drawing.Size(56, 24);
   this.checkBox2.TabIndex = 6;
   this.checkBox2.Text = "Eðik";
   this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
   // 
   // checkBox1
   // 
   this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
   this.checkBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("checkBox1.Image")));
   this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.checkBox1.Location = new System.Drawing.Point(8, 8);
   this.checkBox1.Name = "checkBox1";
   this.checkBox1.Size = new System.Drawing.Size(56, 24);
   this.checkBox1.TabIndex = 5;
   this.checkBox1.Text = "Kalýn";
   this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 40);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(264, 120);
   this.textBox1.TabIndex = 4;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(280, 166);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.checkBox3,
                                                              this.checkBox2,
                                                              this.checkBox1,
                                                              this.textBox1});
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

  private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
  {
    textBox1.Font = new Font(textBox1.Font, 
                           textBox1.Font.Style ^ FontStyle.Bold);
  }

  private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
  {
     textBox1.Font = new Font(textBox1.Font, 
                           textBox1.Font.Style ^ FontStyle.Italic);
  }

  private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
  {
     textBox1.Font = new Font(textBox1.Font, 
                           textBox1.Font.Style ^ FontStyle.Underline);
  }
	}
}
