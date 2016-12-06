using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Progress_Bar
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.ProgressBar progressBar1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.ListBox listBox1;
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
   this.progressBar1 = new System.Windows.Forms.ProgressBar();
   this.button1 = new System.Windows.Forms.Button();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.SuspendLayout();
   // 
   // progressBar1
   // 
   this.progressBar1.Location = new System.Drawing.Point(8, 240);
   this.progressBar1.Name = "progressBar1";
   this.progressBar1.Size = new System.Drawing.Size(208, 23);
   this.progressBar1.TabIndex = 5;
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(224, 16);
   this.button1.Name = "button1";
   this.button1.TabIndex = 4;
   this.button1.Text = "Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 8);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(208, 225);
   this.listBox1.TabIndex = 3;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(304, 270);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.progressBar1,
                                                              this.button1,
                                                              this.listBox1});
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
   progressBar1.Visible = false;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   progressBar1.Minimum = 1;
   progressBar1.Maximum = 10000;
   progressBar1.Visible = true;
   int i;
   for (i = 1; i<= 10000; i++)
   {
    progressBar1.Value = i;
    listBox1.Items.Add(i.ToString() + "^2=" + (i * i).ToString());
    Application.DoEvents();
   }
   progressBar1.Visible = false;
  }
	}
}
