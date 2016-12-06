using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace RichTextBox_RTFKodu
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.RichTextBox richTextBox1;
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
   this.button1 = new System.Windows.Forms.Button();
   this.richTextBox1 = new System.Windows.Forms.RichTextBox();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 160);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(320, 96);
   this.textBox1.TabIndex = 5;
   this.textBox1.Text = "TextBox1";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 128);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(320, 23);
   this.button1.TabIndex = 4;
   this.button1.Text = "RTF Kodunu Göster";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // richTextBox1
   // 
   this.richTextBox1.Location = new System.Drawing.Point(8, 8);
   this.richTextBox1.Name = "richTextBox1";
   this.richTextBox1.Size = new System.Drawing.Size(320, 120);
   this.richTextBox1.TabIndex = 3;
   this.richTextBox1.Text = "RichTextBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(336, 262);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox1,
                                                              this.button1,
                                                              this.richTextBox1});
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
     richTextBox1.SelectedRtf = "{\\rtf1 \r\n" +
                             "Merhaba\\par \r\n" + 
                             "Ali\\par \r\n" + 
                             "\\b Nerelisin ? \\b0 \\par \r\n" + 
                             "\\ul iyi gunler \\ul \r\n" + 
                             "}";
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   textBox1.Text = richTextBox1.Rtf;
  }
	}
}
