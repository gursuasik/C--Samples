using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Form_HelpButton
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(136, 40);
   this.button1.Name = "button1";
   this.button1.TabIndex = 5;
   this.button1.Text = "Çýkýþ";
   this.button1.Click += new System.EventHandler(this.Button1_Click);
   this.button1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Button1_HelpRequested);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(112, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 4;
   this.textBox1.Text = "textBox1";
   this.textBox1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.TextBox1_HelpRequested);
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 3;
   this.Label1.Text = "Adý Soyadý";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(224, 70);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.textBox1,
                                                              this.Label1});
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
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.HelpButton = true;
  }

  private void Button1_Click(object sender, System.EventArgs e)
  {
   this.Close();
  }

  private void TextBox1_HelpRequested(object sender, System.Windows.Forms.HelpEventArgs hlpevent)
  {
     Help.ShowPopup(textBox1, 
                "Bu kutuya adýnýzý soyadýnýzý yazýnýz", 
                 hlpevent.MousePos);
  }

  private void Button1_HelpRequested(object sender, System.Windows.Forms.HelpEventArgs hlpevent)
  {
     Help.ShowPopup(button1, 
                "Programdan çýkmak için bu düðmeyi týklayýnýz", 
                 hlpevent.MousePos);
  }
	}
}
