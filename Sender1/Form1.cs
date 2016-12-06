using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Sender1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
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
   this.button4 = new System.Windows.Forms.Button();
   this.button3 = new System.Windows.Forms.Button();
   this.Label2 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(256, 48);
   this.button4.Name = "button4";
   this.button4.TabIndex = 23;
   this.button4.Text = "Böl";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(176, 48);
   this.button3.Name = "button3";
   this.button3.TabIndex = 22;
   this.button3.Text = "Çýkar";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(176, 16);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(40, 23);
   this.Label2.TabIndex = 21;
   this.Label2.Text = "Sayý2";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(224, 16);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 20;
   this.textBox2.Text = "textBox2";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(72, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 19;
   this.textBox1.Text = "textBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(16, 16);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(48, 24);
   this.Label1.TabIndex = 18;
   this.Label1.Text = "Sayý1";
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(96, 48);
   this.button2.Name = "button2";
   this.button2.TabIndex = 17;
   this.button2.Text = "Çarp";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(16, 48);
   this.button1.Name = "button1";
   this.button1.TabIndex = 16;
   this.button1.Text = "Topla";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(344, 86);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button4,
                                                              this.button3,
                                                              this.Label2,
                                                              this.textBox2,
                                                              this.textBox1,
                                                              this.Label1,
                                                              this.button2,
                                                              this.button1});
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

  private void button1_Click(object sender, System.EventArgs e)
  {
   double s1, s2, sonuç=0;
   try
   {
    s1 = double.Parse(textBox1.Text);
    s2 = double.Parse(textBox2.Text);
   }
   catch
   {
    MessageBox.Show("Sayýlar hatalý");
    return;
   }
   if ((sender as Button).Text== "Topla") 
    sonuç = s1 + s2;
   if ((sender as Button).Text== "Çarp") 
    sonuç = s1 * s2;
   if ((sender as Button).Text== "Çýkar") 
    sonuç = s1 - s2;
   if ((sender as Button).Text== "Böl")
    sonuç = s1 / s2;
   MessageBox.Show("Sonuç:" + sonuç.ToString());
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   button1_Click(sender, e) ;//button1deki kodu çaðýr;
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   button1_Click(sender, e) ;//button1deki kodu çaðýr;
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   button1_Click(sender, e) ;//button1deki kodu çaðýr;
  }
	}
}
