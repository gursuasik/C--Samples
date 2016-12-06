using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Form_ActiveControl
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
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
   this.Label1 = new System.Windows.Forms.Label();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(184, 56);
   this.Label1.TabIndex = 7;
   this.Label1.Text = "Alt+Caps Lock tuþlarýna basarak kontrolleri iki katýna çýkarabilirsiniz";
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(96, 144);
   this.button2.Name = "button2";
   this.button2.TabIndex = 6;
   this.button2.Text = "Button2";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 144);
   this.button1.Name = "button1";
   this.button1.TabIndex = 5;
   this.button1.Text = "Button1";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 64);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(168, 64);
   this.textBox1.TabIndex = 4;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label1,
                                                              this.button2,
                                                              this.button1,
                                                              this.textBox1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
   this.Load += new System.EventHandler(this.Form1_Load);
   this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
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
   this.KeyPreview = true;
  }

  private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
  {
   if ((this.Tag != "1") && (e.Alt == true) && (e.KeyCode == Keys.CapsLock))
   {
    this.Tag = "1";
    this.ActiveControl.Width *= 2;
    this.ActiveControl.Height *= 2;
   }
  }

  private void Form1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
  {
   this.Tag = "0";
   if ((e.Alt == true) && (e.KeyCode == Keys.CapsLock))
   {
    this.ActiveControl.Width /= 2;
    this.ActiveControl.Height /= 2;
   }
  }
	}
}
