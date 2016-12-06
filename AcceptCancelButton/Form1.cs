using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AcceptCancelButton
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Button button2;
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
   this.button1 = new System.Windows.Forms.Button();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.button2 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(16, 56);
   this.button1.Name = "button1";
   this.button1.TabIndex = 18;
   this.button1.Text = "Tamam";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(72, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.PasswordChar = '*';
   this.textBox1.TabIndex = 21;
   this.textBox1.Text = "TextBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(16, 16);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(48, 23);
   this.Label1.TabIndex = 20;
   this.Label1.Text = "Þifreniz:";
   // 
   // button2
   // 
   this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.button2.Location = new System.Drawing.Point(96, 56);
   this.button2.Name = "button2";
   this.button2.TabIndex = 19;
   this.button2.Text = "Ýptal";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // Form1
   // 
   this.AcceptButton = this.button1;
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.CancelButton = this.button2;
   this.ClientSize = new System.Drawing.Size(184, 94);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
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
   if (textBox1.Text == "1234")
    MessageBox.Show("Þifre doðru");
   else
    MessageBox.Show("Þifre Yanlýþ");
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   Close();
  }
	}
}
