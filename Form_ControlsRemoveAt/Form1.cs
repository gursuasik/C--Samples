using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Form_ControlsRemoveAt
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button Button5;
  internal System.Windows.Forms.Button Button4;
  internal System.Windows.Forms.Button Button3;
  internal System.Windows.Forms.TextBox TextBox3;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.TextBox TextBox2;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.TextBox TextBox1;
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
   this.Button5 = new System.Windows.Forms.Button();
   this.Button4 = new System.Windows.Forms.Button();
   this.Button3 = new System.Windows.Forms.Button();
   this.TextBox3 = new System.Windows.Forms.TextBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.TextBox2 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.TextBox1 = new System.Windows.Forms.TextBox();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // Button5
   // 
   this.Button5.Location = new System.Drawing.Point(216, 56);
   this.Button5.Name = "Button5";
   this.Button5.TabIndex = 21;
   this.Button5.Text = "Button5";
   // 
   // Button4
   // 
   this.Button4.Location = new System.Drawing.Point(216, 32);
   this.Button4.Name = "Button4";
   this.Button4.TabIndex = 20;
   this.Button4.Text = "Button4";
   // 
   // Button3
   // 
   this.Button3.Location = new System.Drawing.Point(216, 8);
   this.Button3.Name = "Button3";
   this.Button3.TabIndex = 19;
   this.Button3.Text = "Button3";
   // 
   // TextBox3
   // 
   this.TextBox3.Location = new System.Drawing.Point(112, 56);
   this.TextBox3.Name = "TextBox3";
   this.TextBox3.TabIndex = 18;
   this.TextBox3.Text = "TextBox3";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 56);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 17;
   this.Label3.Text = "Label3";
   // 
   // TextBox2
   // 
   this.TextBox2.Location = new System.Drawing.Point(112, 32);
   this.TextBox2.Name = "TextBox2";
   this.TextBox2.TabIndex = 16;
   this.TextBox2.Text = "TextBox2";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 15;
   this.Label2.Text = "Label2";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 14;
   this.Label1.Text = "Label1";
   // 
   // TextBox1
   // 
   this.TextBox1.Location = new System.Drawing.Point(112, 8);
   this.TextBox1.Name = "TextBox1";
   this.TextBox1.TabIndex = 13;
   this.TextBox1.Text = "TextBox1";
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(136, 88);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(152, 23);
   this.button2.TabIndex = 12;
   this.button2.Text = "Sadece Text Kutularýný Sil";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 88);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(120, 23);
   this.button1.TabIndex = 11;
   this.button1.Text = "Bütün Kontrolleri Sil";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(304, 118);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Button5,
                                                              this.Button4,
                                                              this.Button3,
                                                              this.TextBox3,
                                                              this.Label3,
                                                              this.TextBox2,
                                                              this.Label2,
                                                              this.Label1,
                                                              this.TextBox1,
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
   int i;
   int say = this.Controls.Count;
   for (i = 0 ; i< say ; i++)
    this.Controls.RemoveAt(0);
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   int i = 0;
   while (i < this.Controls.Count)
   {
    if (this.Controls[i] is TextBox)
     this.Controls.RemoveAt(i);
    else
     i += 1;
   }
  }
	}
}
