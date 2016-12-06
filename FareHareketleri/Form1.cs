using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FareHareketleri
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.TextBox textBox2;
  private System.Windows.Forms.TextBox textBox3;
  private System.Windows.Forms.Button button1;
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
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(80, 56);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 0;
   this.textBox1.Text = "textBox1";
   this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
   this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
   this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(80, 88);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 1;
   this.textBox2.Text = "textBox2";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(80, 120);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 2;
   this.textBox3.Text = "textBox3";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(96, 160);
   this.button1.Name = "button1";
   this.button1.TabIndex = 3;
   this.button1.Text = "button1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
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
   textBox2.MouseEnter += new EventHandler(textBox1_MouseEnter);
   textBox3.MouseEnter += new EventHandler(textBox1_MouseEnter);
   button1.MouseEnter += new EventHandler(textBox1_MouseEnter);

   textBox2.MouseLeave += new EventHandler(textBox1_MouseLeave);
   textBox3.MouseLeave += new EventHandler(textBox1_MouseLeave);
   button1.MouseLeave += new EventHandler(textBox1_MouseLeave);

   textBox2.MouseHover += new EventHandler(textBox1_MouseHover);
   textBox3.MouseHover += new EventHandler(textBox1_MouseHover);
   button1.MouseHover += new EventHandler(textBox1_MouseHover);
  }

  private void textBox1_MouseEnter(object sender, System.EventArgs e)
  {
   (sender as Control).BackColor = Color.Red;
  }

  private void textBox1_MouseLeave(object sender, System.EventArgs e)
  {
   (sender as Control).BackColor = Color.White;
   (sender as Control).ForeColor = Color.Black;
  }

  private void textBox1_MouseHover(object sender, System.EventArgs e)
  {
   (sender as Control).ForeColor = Color.Yellow;
  }
	}
}
