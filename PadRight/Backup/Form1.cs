using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PadRight
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.TextBox textBox2;
  private System.Windows.Forms.TextBox textBox3;
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.ListBox listBox1;
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
   this.label1 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(0, 8);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(32, 23);
   this.label1.TabIndex = 0;
   this.label1.Text = "Adý";
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(144, 8);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(48, 23);
   this.label2.TabIndex = 1;
   this.label2.Text = "Bölümü";
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(304, 8);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(40, 23);
   this.label3.TabIndex = 2;
   this.label3.Text = "Sýnýfý";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(32, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 3;
   this.textBox1.Text = "textBox1";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(200, 8);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 4;
   this.textBox2.Text = "textBox2";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(344, 8);
   this.textBox3.Name = "textBox3";
   this.textBox3.Size = new System.Drawing.Size(48, 20);
   this.textBox3.TabIndex = 5;
   this.textBox3.Text = "textBox3";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(392, 8);
   this.button1.Name = "button1";
   this.button1.TabIndex = 6;
   this.button1.Text = "Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(0, 40);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(472, 238);
   this.listBox1.TabIndex = 7;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(472, 278);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.listBox1,
                                                              this.button1,
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.textBox1,
                                                              this.label3,
                                                              this.label2,
                                                              this.label1});
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

  private void button1_Click(object sender, System.EventArgs e)
  {
   listBox1.Items.Add(textBox1.Text.PadRight(30, ' ') + " " + 
                      textBox2.Text.PadRight(15, ' ') + " " + 
                      textBox3.Text);
   textBox1.Text = "";
   textBox2.Text = "";
   textBox3.Text = "";
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   listBox1.Font = new Font("Courier New", 10, FontStyle.Regular);
   this.AcceptButton = button1;
  }
	}
}
