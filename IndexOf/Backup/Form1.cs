using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace IndexOf
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.Label Label1;
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
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.Label2 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(240, 88);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(80, 24);
   this.button2.TabIndex = 11;
   this.button2.Text = "Sonrakini Bul";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(240, 56);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(80, 24);
   this.button1.TabIndex = 10;
   this.button1.Text = "Bul";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(240, 8);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(72, 23);
   this.Label2.TabIndex = 9;
   this.Label2.Text = "Aranan Bilgi";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(240, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(80, 20);
   this.textBox2.TabIndex = 8;
   this.textBox2.Text = "textBox2";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(104, 16);
   this.Label1.TabIndex = 7;
   this.Label1.Text = "Metin";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 32);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(216, 20);
   this.textBox1.TabIndex = 6;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(328, 118);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1,
                                                              this.Label2,
                                                              this.textBox2,
                                                              this.Label1,
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

  int yer=0;//Global deðiþken.
            //Aramaya kaldýðý yerden devam edebilmesi için gerekli

  private void Form1_Load(object sender, System.EventArgs e)
  {
   textBox1.Multiline = true;;//Text kutusuna birden fazla satýr girilebilsin
   textBox1.Height = 100; //Yüksekliðini artýr
   textBox1.HideSelection = false; //Seçili kýsým gizlenmesin
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   //Baþtan ara
   yer = textBox1.Text.ToUpper().IndexOf(textBox2.Text.ToUpper());
   if (yer < 0)
    MessageBox.Show("Üzgünüm bulamadým");
   else
   {
    textBox1.SelectionStart = yer;
    textBox1.SelectionLength = textBox2.Text.Length;
    MessageBox.Show((yer + 1).ToString() + ". harfte buldum ve seçtim");
   }
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   //Kaldýðý yerden itibaren ara
   yer = textBox1.Text.ToUpper().IndexOf(textBox2.Text.ToUpper(), yer + 1);
   if (yer < 0)
    MessageBox.Show("Üzgünüm baþka bulamadým");
   else
   {
    textBox1.SelectionStart = yer;
    textBox1.SelectionLength = textBox2.Text.Length;
    MessageBox.Show((yer + 1).ToString() + ". harfte bir tane daha buldum ve seçtim");
   }
  }
	}
}
