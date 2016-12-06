using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Key_Down
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.TextBox textBox2;
  private System.Windows.Forms.TextBox textBox3;
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
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(88, 72);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 0;
   this.textBox1.Text = "textBox1";
   this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(88, 104);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 1;
   this.textBox2.Text = "textBox2";
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(88, 136);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 2;
   this.textBox3.Text = "textBox3";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(104, 176);
   this.button1.Name = "button1";
   this.button1.TabIndex = 3;
   this.button1.Text = "button1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(488, 266);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.textBox3,
                                                              this.textBox2,
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
   //Text kutusunu dikey olarak boyutlandýrabilmek için gerekli
   textBox1.AutoSize = false;
   textBox2.AutoSize = false;
   textBox3.AutoSize = false;

   //Olaylarý birleþtir
   textBox2.KeyDown += new KeyEventHandler(textBox1_KeyDown);
   textBox3.KeyDown += new KeyEventHandler(textBox1_KeyDown);
  }

  private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
  {
   //Ctrl tuþu basýlý ise
   if (e.Control)
   {
    //Yön tuþlarý ile hareket ettir
    switch(e.KeyCode)
    {
     case Keys.Left :  (sender as TextBox).Left = (sender as TextBox).Left - 5;
      break;
     case Keys.Right : (sender as TextBox).Left = (sender as TextBox).Left + 5;
      break;
     case Keys.Up :    (sender as TextBox).Top = (sender as TextBox).Top - 5;
      break;
     case Keys.Down :  (sender as TextBox).Top = (sender as TextBox).Top + 5;
      break;
    }
   }
   //Alt tuþu basýlý ise
   if (e.Alt)
   {
    //Yön tuþlarý ile boyutlarýný deðiþtir
    switch(e.KeyCode)
    {
     case Keys.Left :  (sender as TextBox).Width = (sender as TextBox).Width - 5;
      break;
     case Keys.Right : (sender as TextBox).Width = (sender as TextBox).Width + 5;
      break;
     case Keys.Up :    (sender as TextBox).Height = (sender as TextBox).Height - 5;
      break;
     case Keys.Down :  (sender as TextBox).Height = (sender as TextBox).Height + 5;
      break;
    }
   }

   //f5 tuþuna basýlmýþsa
   if (e.KeyCode == Keys.F5)
   {
    //Alt F5 ise büyük harfe çevir
    if (e.Alt)
     (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
    //Ctrl F5 ise küçük harfe çevir
    if (e.Control)
     (sender as TextBox).Text = (sender as TextBox).Text.ToLower();
   }

   //Shift BackSpace tuþuna basýlmýþsa tümünü sil
   if (e.Shift && (e.KeyCode == Keys.Back))
    (sender as TextBox).Text = "";
  
   //F10 tuþuna basýlýnca programdan çýk
   if (e.KeyCode == Keys.F10)
    Close();

   //Formun baþlýðýnda basýlan tuþun kodunu ve adýný göster
   this.Text = "Bastýðýnýz tuþun sayýsal kodu:" + e.KeyValue.ToString() +
    " Sembolik Adý:" + e.KeyCode.ToString();
  }
	}
}
