using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace EnterLeave
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.TextBox textBox2;
  private System.Windows.Forms.TextBox textBox3;
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
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(16, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 0;
   this.textBox1.Text = "textBox1";
   this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
   this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(16, 48);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 1;
   this.textBox2.Text = "textBox2";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(16, 80);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 2;
   this.textBox3.Text = "textBox3";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(136, 118);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
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
   textBox2.Enter += new EventHandler(textBox1_Enter);
   textBox3.Enter += new EventHandler(textBox1_Enter);

   textBox2.Leave += new EventHandler(textBox1_Leave);
   textBox3.Leave += new EventHandler(textBox1_Leave);
  }

  private void textBox1_Enter(object sender, System.EventArgs e)
  {
   (sender as Control).BackColor = Color.Red;  
  }

  private void textBox1_Leave(object sender, System.EventArgs e)
  {
   (sender as Control).BackColor = Color.White;
  }
	}
}
