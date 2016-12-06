using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DateTime_TimeSpan
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.TextBox textBox2;
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
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(8, 32);
   this.textBox2.Multiline = true;
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(336, 104);
   this.textBox2.TabIndex = 7;
   this.textBox2.Text = "textBox2";
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(8, 8);
   this.label1.Name = "label1";
   this.label1.TabIndex = 6;
   this.label1.Text = "Doðum Tarihiniz:";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(120, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(120, 20);
   this.textBox1.TabIndex = 5;
   this.textBox1.Text = "textBox1";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(248, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(96, 23);
   this.button1.TabIndex = 4;
   this.button1.Text = "Hesapla";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(352, 142);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox2,
                                                              this.label1,
                                                              this.textBox1,
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
   DateTime doðum_tarihi;
   TimeSpan fark;
   try
   {
    doðum_tarihi = DateTime.Parse(textBox1.Text);
    fark = DateTime.Now.Subtract(doðum_tarihi);
    textBox2.Text = 
     "Yaþadýðýnýz saat: " +fark.TotalHours.ToString()+"\r\n"+
     "Yaþadýðýnýz dakika: " +fark.TotalMinutes.ToString()+"\r\n"+
     "Yaþadýðýnýz saniye: " +fark.TotalSeconds.ToString()+"\r\n"+
     "Yaþadýðýnýz Gün: " +fark.TotalDays.ToString();
   }
   catch
   {
    MessageBox.Show("Tarih hatalý");
   }
  }
	}
}
