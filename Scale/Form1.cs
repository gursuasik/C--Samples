using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Scale
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.ComboBox comboBox1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Button Button3;
  internal System.Windows.Forms.ListBox ListBox1;
  internal System.Windows.Forms.Button Button2;
  internal System.Windows.Forms.TextBox TextBox4;
  internal System.Windows.Forms.TextBox TextBox3;
  internal System.Windows.Forms.TextBox TextBox2;
  internal System.Windows.Forms.TextBox TextBox1;
  internal System.Windows.Forms.Button Button1;
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
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.Button3 = new System.Windows.Forms.Button();
   this.ListBox1 = new System.Windows.Forms.ListBox();
   this.Button2 = new System.Windows.Forms.Button();
   this.TextBox4 = new System.Windows.Forms.TextBox();
   this.TextBox3 = new System.Windows.Forms.TextBox();
   this.TextBox2 = new System.Windows.Forms.TextBox();
   this.TextBox1 = new System.Windows.Forms.TextBox();
   this.Button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // comboBox1
   // 
   this.comboBox1.Location = new System.Drawing.Point(64, 144);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(80, 21);
   this.comboBox1.TabIndex = 19;
   this.comboBox1.Text = "comboBox1";
   this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(16, 144);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(32, 23);
   this.Label1.TabIndex = 18;
   this.Label1.Text = "Oran:";
   // 
   // Button3
   // 
   this.Button3.Location = new System.Drawing.Point(176, 112);
   this.Button3.Name = "Button3";
   this.Button3.TabIndex = 17;
   this.Button3.Text = "Button3";
   // 
   // ListBox1
   // 
   this.ListBox1.Location = new System.Drawing.Point(128, 16);
   this.ListBox1.Name = "ListBox1";
   this.ListBox1.Size = new System.Drawing.Size(120, 95);
   this.ListBox1.TabIndex = 16;
   // 
   // Button2
   // 
   this.Button2.Location = new System.Drawing.Point(96, 112);
   this.Button2.Name = "Button2";
   this.Button2.TabIndex = 15;
   this.Button2.Text = "Button2";
   // 
   // TextBox4
   // 
   this.TextBox4.Location = new System.Drawing.Point(16, 88);
   this.TextBox4.Name = "TextBox4";
   this.TextBox4.TabIndex = 14;
   this.TextBox4.Text = "TextBox4";
   // 
   // TextBox3
   // 
   this.TextBox3.Location = new System.Drawing.Point(16, 64);
   this.TextBox3.Name = "TextBox3";
   this.TextBox3.TabIndex = 13;
   this.TextBox3.Text = "TextBox3";
   // 
   // TextBox2
   // 
   this.TextBox2.Location = new System.Drawing.Point(16, 40);
   this.TextBox2.Name = "TextBox2";
   this.TextBox2.TabIndex = 12;
   this.TextBox2.Text = "TextBox2";
   // 
   // TextBox1
   // 
   this.TextBox1.Location = new System.Drawing.Point(16, 16);
   this.TextBox1.Name = "TextBox1";
   this.TextBox1.TabIndex = 11;
   this.TextBox1.Text = "TextBox1";
   // 
   // Button1
   // 
   this.Button1.Location = new System.Drawing.Point(16, 112);
   this.Button1.Name = "Button1";
   this.Button1.TabIndex = 10;
   this.Button1.Text = "Button1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(256, 174);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.comboBox1,
                                                              this.Label1,
                                                              this.Button3,
                                                              this.ListBox1,
                                                              this.Button2,
                                                              this.TextBox4,
                                                              this.TextBox3,
                                                              this.TextBox2,
                                                              this.TextBox1,
                                                              this.Button1});
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
   int i;
   for (i = 20 ; i<= 200 ; i+=20)
    comboBox1.Items.Add("%" + i.ToString());
  }

  private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   this.Scale(float.Parse(comboBox1.Text.Substring(1)) / 100);
  }
	}
}
