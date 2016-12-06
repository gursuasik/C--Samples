using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Splitter_Dock
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Splitter Splitter4;
  internal System.Windows.Forms.TextBox TextBox4;
  internal System.Windows.Forms.Splitter Splitter3;
  internal System.Windows.Forms.TextBox TextBox3;
  internal System.Windows.Forms.Splitter Splitter2;
  internal System.Windows.Forms.Splitter Splitter1;
  internal System.Windows.Forms.TextBox TextBox2;
  internal System.Windows.Forms.TextBox TextBox1;
  internal System.Windows.Forms.TextBox TextBox5;
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
   this.Splitter4 = new System.Windows.Forms.Splitter();
   this.TextBox4 = new System.Windows.Forms.TextBox();
   this.Splitter3 = new System.Windows.Forms.Splitter();
   this.TextBox3 = new System.Windows.Forms.TextBox();
   this.Splitter2 = new System.Windows.Forms.Splitter();
   this.Splitter1 = new System.Windows.Forms.Splitter();
   this.TextBox2 = new System.Windows.Forms.TextBox();
   this.TextBox1 = new System.Windows.Forms.TextBox();
   this.TextBox5 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // Splitter4
   // 
   this.Splitter4.Dock = System.Windows.Forms.DockStyle.Bottom;
   this.Splitter4.Location = new System.Drawing.Point(0, 331);
   this.Splitter4.Name = "Splitter4";
   this.Splitter4.Size = new System.Drawing.Size(504, 3);
   this.Splitter4.TabIndex = 26;
   this.Splitter4.TabStop = false;
   // 
   // TextBox4
   // 
   this.TextBox4.AutoSize = false;
   this.TextBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
   this.TextBox4.Location = new System.Drawing.Point(103, 311);
   this.TextBox4.Name = "TextBox4";
   this.TextBox4.Size = new System.Drawing.Size(298, 20);
   this.TextBox4.TabIndex = 25;
   this.TextBox4.Text = "TextBox4";
   // 
   // Splitter3
   // 
   this.Splitter3.Dock = System.Windows.Forms.DockStyle.Top;
   this.Splitter3.Location = new System.Drawing.Point(103, 20);
   this.Splitter3.Name = "Splitter3";
   this.Splitter3.Size = new System.Drawing.Size(298, 3);
   this.Splitter3.TabIndex = 24;
   this.Splitter3.TabStop = false;
   // 
   // TextBox3
   // 
   this.TextBox3.AutoSize = false;
   this.TextBox3.Dock = System.Windows.Forms.DockStyle.Top;
   this.TextBox3.Location = new System.Drawing.Point(103, 0);
   this.TextBox3.Name = "TextBox3";
   this.TextBox3.Size = new System.Drawing.Size(298, 20);
   this.TextBox3.TabIndex = 23;
   this.TextBox3.Text = "TextBox3";
   // 
   // Splitter2
   // 
   this.Splitter2.Dock = System.Windows.Forms.DockStyle.Right;
   this.Splitter2.Location = new System.Drawing.Point(401, 0);
   this.Splitter2.Name = "Splitter2";
   this.Splitter2.Size = new System.Drawing.Size(3, 331);
   this.Splitter2.TabIndex = 22;
   this.Splitter2.TabStop = false;
   // 
   // Splitter1
   // 
   this.Splitter1.Location = new System.Drawing.Point(100, 0);
   this.Splitter1.Name = "Splitter1";
   this.Splitter1.Size = new System.Drawing.Size(3, 331);
   this.Splitter1.TabIndex = 21;
   this.Splitter1.TabStop = false;
   // 
   // TextBox2
   // 
   this.TextBox2.AutoSize = false;
   this.TextBox2.Dock = System.Windows.Forms.DockStyle.Left;
   this.TextBox2.Name = "TextBox2";
   this.TextBox2.Size = new System.Drawing.Size(100, 331);
   this.TextBox2.TabIndex = 20;
   this.TextBox2.Text = "TextBox2";
   // 
   // TextBox1
   // 
   this.TextBox1.AutoSize = false;
   this.TextBox1.Dock = System.Windows.Forms.DockStyle.Right;
   this.TextBox1.Location = new System.Drawing.Point(404, 0);
   this.TextBox1.Name = "TextBox1";
   this.TextBox1.Size = new System.Drawing.Size(100, 331);
   this.TextBox1.TabIndex = 19;
   this.TextBox1.Text = "TextBox1";
   // 
   // TextBox5
   // 
   this.TextBox5.AutoSize = false;
   this.TextBox5.Dock = System.Windows.Forms.DockStyle.Fill;
   this.TextBox5.Name = "TextBox5";
   this.TextBox5.Size = new System.Drawing.Size(504, 331);
   this.TextBox5.TabIndex = 27;
   this.TextBox5.Text = "TextBox5";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(504, 334);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.TextBox4,
                                                              this.Splitter3,
                                                              this.TextBox3,
                                                              this.Splitter2,
                                                              this.Splitter1,
                                                              this.TextBox2,
                                                              this.TextBox1,
                                                              this.TextBox5,
                                                              this.Splitter4});
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
	}
}
