using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace KeyPress
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label1;
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
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 8);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(168, 192);
   this.textBox1.TabIndex = 0;
   this.textBox1.Text = "textBox1";
   this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
   this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(16, 208);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(160, 40);
   this.Label1.TabIndex = 2;
   this.Label1.Text = "Text kutusuna rakam girmeyi ve F1, F2, F3 tuþlarýný deneyin.";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(184, 254);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label1,
                                                              this.textBox1});
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

  private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
  {
     string[] rakamlar = {"sýfýr", "bir", "iki", "üç", "dört", "beþ", 
                    "altý", "yedi", "sekiz", "dokuz"};
  //0-9 arasý ise yazýyla yaz
   if (e.KeyChar >= '0' && e.KeyChar <= '9')
   {
    textBox1.SelectedText = rakamlar[e.KeyChar-(char) '0'];
    e.Handled = true;
   }
  }

  private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
  {
   switch(e.KeyCode)
   {
    case Keys.F1 : textBox1.SelectedText = DateTime.Now.ToLongTimeString();
     break;
    case Keys.F2 : textBox1.SelectedText = DateTime.Now.ToLongDateString();
     break;
    case Keys.F3 : textBox1.SelectedText = DateTime.Now.ToString();
     break;
   }
  }
	}
}
