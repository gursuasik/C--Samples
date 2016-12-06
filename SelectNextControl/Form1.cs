using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SelectNextControl
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.TextBox textBox2;
  private System.Windows.Forms.TextBox textBox3;
  private System.Windows.Forms.Label label1;
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
   this.label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(32, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 0;
   this.textBox1.Text = "textBox1";
   this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(32, 40);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 1;
   this.textBox2.Text = "textBox2";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(32, 72);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 2;
   this.textBox3.Text = "textBox3";
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(32, 104);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(100, 40);
   this.label1.TabIndex = 3;
   this.label1.Text = "Kontroller arasýnda Enter tuþu ile dolaþabilirsiniz.";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(168, 166);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label1,
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
   textBox2.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
   textBox3.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
  }

  private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
  {
   if (e.KeyChar == (char) 13) //Entere basýlmýþsa
   {
    this.SelectNextControl(sender as Control, true, true, true, true);
    e.Handled = true; //Bip sesi çýkmamasý için tuþu iptal et
   }
  }
	}
}
