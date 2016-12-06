using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Form_Controls
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Button Button1;
  internal System.Windows.Forms.TextBox TextBox5;
  internal System.Windows.Forms.TextBox TextBox4;
  internal System.Windows.Forms.TextBox TextBox3;
  internal System.Windows.Forms.TextBox TextBox2;
  internal System.Windows.Forms.TextBox TextBox1;
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
   this.Label5 = new System.Windows.Forms.Label();
   this.Label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.Button1 = new System.Windows.Forms.Button();
   this.TextBox5 = new System.Windows.Forms.TextBox();
   this.TextBox4 = new System.Windows.Forms.TextBox();
   this.TextBox3 = new System.Windows.Forms.TextBox();
   this.TextBox2 = new System.Windows.Forms.TextBox();
   this.TextBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // Label5
   // 
   this.Label5.Location = new System.Drawing.Point(8, 104);
   this.Label5.Name = "Label5";
   this.Label5.TabIndex = 23;
   this.Label5.Text = "Label5";
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(8, 80);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 22;
   this.Label4.Text = "Label4";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 56);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 21;
   this.Label3.Text = "Label3";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 20;
   this.Label2.Text = "Label2";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(104, 24);
   this.Label1.TabIndex = 19;
   this.Label1.Text = "Label1";
   // 
   // Button1
   // 
   this.Button1.Location = new System.Drawing.Point(8, 136);
   this.Button1.Name = "Button1";
   this.Button1.Size = new System.Drawing.Size(216, 23);
   this.Button1.TabIndex = 18;
   this.Button1.Text = "Text kutularýnýn içeriklerini sil";
   this.Button1.Click += new System.EventHandler(this.Button1_Click);
   // 
   // TextBox5
   // 
   this.TextBox5.Location = new System.Drawing.Point(120, 104);
   this.TextBox5.Name = "TextBox5";
   this.TextBox5.TabIndex = 17;
   this.TextBox5.Text = "TextBox5";
   // 
   // TextBox4
   // 
   this.TextBox4.Location = new System.Drawing.Point(120, 80);
   this.TextBox4.Name = "TextBox4";
   this.TextBox4.TabIndex = 16;
   this.TextBox4.Text = "TextBox4";
   // 
   // TextBox3
   // 
   this.TextBox3.Location = new System.Drawing.Point(120, 56);
   this.TextBox3.Name = "TextBox3";
   this.TextBox3.TabIndex = 15;
   this.TextBox3.Text = "TextBox3";
   // 
   // TextBox2
   // 
   this.TextBox2.Location = new System.Drawing.Point(120, 32);
   this.TextBox2.Name = "TextBox2";
   this.TextBox2.TabIndex = 14;
   this.TextBox2.Text = "TextBox2";
   // 
   // TextBox1
   // 
   this.TextBox1.Location = new System.Drawing.Point(120, 8);
   this.TextBox1.Name = "TextBox1";
   this.TextBox1.TabIndex = 13;
   this.TextBox1.Text = "TextBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(232, 166);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label5,
                                                              this.Label4,
                                                              this.Label3,
                                                              this.Label2,
                                                              this.Label1,
                                                              this.Button1,
                                                              this.TextBox5,
                                                              this.TextBox4,
                                                              this.TextBox3,
                                                              this.TextBox2,
                                                              this.TextBox1});
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

  private void Button1_Click(object sender, System.EventArgs e)
  {
   int i;
   for (i = 0 ; i<= this.Controls.Count - 1; i++)
    if (this.Controls[i] is TextBox)
     this.Controls[i].Text = "";
  }
	}
}
