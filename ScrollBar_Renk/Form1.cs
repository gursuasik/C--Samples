using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ScrollBar_Renk
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label label4;
  internal System.Windows.Forms.Label label5;
  internal System.Windows.Forms.Label label6;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.HScrollBar hScrollBar3;
  internal System.Windows.Forms.HScrollBar hScrollBar2;
  internal System.Windows.Forms.HScrollBar hScrollBar1;
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
   this.label4 = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.label6 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
   this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
   this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(240, 104);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(38, 13);
   this.label4.TabIndex = 19;
   this.label4.Text = "Label4";
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Location = new System.Drawing.Point(240, 120);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(38, 13);
   this.label5.TabIndex = 18;
   this.label5.Text = "Label5";
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(240, 136);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(38, 13);
   this.label6.TabIndex = 17;
   this.label6.Text = "Label6";
   // 
   // Label3
   // 
   this.Label3.AutoSize = true;
   this.Label3.Location = new System.Drawing.Point(8, 136);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(28, 13);
   this.Label3.TabIndex = 16;
   this.Label3.Text = "Mavi";
   // 
   // Label2
   // 
   this.Label2.AutoSize = true;
   this.Label2.Location = new System.Drawing.Point(8, 120);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(29, 13);
   this.Label2.TabIndex = 15;
   this.Label2.Text = "Yeþil";
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(8, 104);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(36, 13);
   this.Label1.TabIndex = 14;
   this.Label1.Text = "Krmýzý";
   // 
   // hScrollBar3
   // 
   this.hScrollBar3.Location = new System.Drawing.Point(48, 136);
   this.hScrollBar3.Name = "hScrollBar3";
   this.hScrollBar3.Size = new System.Drawing.Size(184, 17);
   this.hScrollBar3.TabIndex = 13;
   // 
   // hScrollBar2
   // 
   this.hScrollBar2.Location = new System.Drawing.Point(48, 120);
   this.hScrollBar2.Name = "hScrollBar2";
   this.hScrollBar2.Size = new System.Drawing.Size(184, 17);
   this.hScrollBar2.TabIndex = 12;
   // 
   // hScrollBar1
   // 
   this.hScrollBar1.Location = new System.Drawing.Point(48, 104);
   this.hScrollBar1.Name = "hScrollBar1";
   this.hScrollBar1.Size = new System.Drawing.Size(184, 17);
   this.hScrollBar1.TabIndex = 11;
   this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 8);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(272, 80);
   this.textBox1.TabIndex = 10;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(288, 158);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label4,
                                                              this.label5,
                                                              this.label6,
                                                              this.Label3,
                                                              this.Label2,
                                                              this.Label1,
                                                              this.hScrollBar3,
                                                              this.hScrollBar2,
                                                              this.hScrollBar1,
                                                              this.textBox1});
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
   hScrollBar1.Maximum = 255;
   hScrollBar2.Maximum = 255;
   hScrollBar3.Maximum = 255;
   //Olaylarý birleþtir
   hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(hScrollBar1_Scroll);
   hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(hScrollBar1_Scroll);
  }

  private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
  {
   textBox1.BackColor = Color.FromArgb(hScrollBar1.Value, 
    hScrollBar2.Value, 
    hScrollBar3.Value);
   label4.Text = hScrollBar1.Value.ToString();
   label5.Text = hScrollBar2.Value.ToString();
   label6.Text = hScrollBar3.Value.ToString();
  }
	}
}
