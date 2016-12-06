using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Form_GetNextControl
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.TextBox textBox4;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.TextBox textBox2;
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
   this.textBox4 = new System.Windows.Forms.TextBox();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 112);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(192, 40);
   this.Label1.TabIndex = 9;
   this.Label1.Text = "Enter tuþu ile kontroller arasýnda geçiþ yapabilirsiniz";
   // 
   // textBox4
   // 
   this.textBox4.Location = new System.Drawing.Point(8, 80);
   this.textBox4.Name = "textBox4";
   this.textBox4.Size = new System.Drawing.Size(192, 20);
   this.textBox4.TabIndex = 8;
   this.textBox4.Text = "textBox4";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(8, 56);
   this.textBox3.Name = "textBox3";
   this.textBox3.Size = new System.Drawing.Size(192, 20);
   this.textBox3.TabIndex = 7;
   this.textBox3.Text = "textBox3";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(8, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(192, 20);
   this.textBox2.TabIndex = 6;
   this.textBox2.Text = "textBox2";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(192, 20);
   this.textBox1.TabIndex = 5;
   this.textBox1.Text = "textBox1";
   this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(208, 158);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label1,
                                                              this.textBox4,
                                                              this.textBox3,
                                                              this.textBox2,
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
   //Olaylarý birleþtir
   textBox2.KeyDown += new KeyEventHandler(textBox1_KeyDown);
   textBox3.KeyDown += new KeyEventHandler(textBox1_KeyDown);
   textBox4.KeyDown += new KeyEventHandler(textBox1_KeyDown);
  }

  private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Enter)
    this.GetNextControl((sender as Control), true).Focus();
  }
	}
}
