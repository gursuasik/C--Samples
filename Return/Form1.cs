using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Return
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.ListBox listBox1;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox textBox1;
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
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 8);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(168, 212);
   this.listBox1.TabIndex = 0;
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(184, 8);
   this.label1.Name = "label1";
   this.label1.TabIndex = 1;
   this.label1.Text = "Kaça Kadar";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(184, 32);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(112, 20);
   this.textBox1.TabIndex = 2;
   this.textBox1.Text = "textBox1";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(184, 56);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(112, 23);
   this.button1.TabIndex = 3;
   this.button1.Text = "Logaritma Hesapla";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(304, 222);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.textBox1,
                                                              this.label1,
                                                              this.listBox1});
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
   int  i,j;
   j=int.Parse(textBox1.Text);
   listBox1.Items.Clear();
   if (j<=0) 
    return;
   for (i=1;i<=j;i++)
    listBox1.Items.Add("Log("+i.ToString()+")=" + 
     Math.Log10(i).ToString());
  }
	}
}
