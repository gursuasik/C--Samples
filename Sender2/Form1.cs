using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Sender2
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
   this.button4.Location = new System.Drawing.Point(256, 40);
   this.button4.Name = "button4";
   this.button4.TabIndex = 31;
   this.button4.Text = "B�l";
   this.button4.Click += new System.EventHandler(this.i�lem_yap);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(176, 40);
   this.button3.Name = "button3";
   this.button3.TabIndex = 30;
   this.button3.Text = "��kar";
   this.button3.Click += new System.EventHandler(this.i�lem_yap);
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(176, 8);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(40, 23);
   this.Label2.TabIndex = 29;
   this.Label2.Text = "Say�2";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(224, 8);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 28;
   this.textBox2.Text = "textBox2";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(72, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 27;
   this.textBox1.Text = "textBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(16, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(48, 24);
   this.Label1.TabIndex = 26;
   this.Label1.Text = "Say�1";
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(96, 40);
   this.button2.Name = "button2";
   this.button2.TabIndex = 25;
   this.button2.Text = "�arp";
   this.button2.Click += new System.EventHandler(this.i�lem_yap);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(16, 40);
   this.button1.Name = "button1";
   this.button1.TabIndex = 24;
   this.button1.Text = "Topla";
   this.button1.Click += new System.EventHandler(this.i�lem_yap);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(336, 70);
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

  private void i�lem_yap(object sender, System.EventArgs e)
  {
   double s1, s2, sonu�=0;
   try
   {
    s1 = double.Parse(textBox1.Text);
    s2 = double.Parse(textBox2.Text);
   }
   catch
   {
    MessageBox.Show("Say�lar hatal�");
    return;
   }
   if ((sender as Button).Name == "button1") 
    sonu� = s1 + s2;
   if ((sender as Button).Name == "button2") 
    sonu� = s1 * s2;
   if ((sender as Button).Name == "button3") 
    sonu� = s1 - s2;
   if ((sender as Button).Name == "button4")
    sonu� = s1 / s2;
   MessageBox.Show("Sonu�:" + sonu�.ToString());
  }
	}
}
