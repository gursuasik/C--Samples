using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SelectedText
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button5;
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox textBox2;
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
   this.button5 = new System.Windows.Forms.Button();
   this.button4 = new System.Windows.Forms.Button();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // button5
   // 
   this.button5.Location = new System.Drawing.Point(304, 168);
   this.button5.Name = "button5";
   this.button5.Size = new System.Drawing.Size(110, 23);
   this.button5.TabIndex = 11;
   this.button5.Text = "Sil";
   this.button5.Click += new System.EventHandler(this.button5_Click);
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(304, 144);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(110, 23);
   this.button4.TabIndex = 10;
   this.button4.Text = "Bul";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(304, 56);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(110, 23);
   this.button3.TabIndex = 9;
   this.button3.Text = "Küçük Harfe Çevir";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(304, 32);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(110, 23);
   this.button2.TabIndex = 8;
   this.button2.Text = "Büyük Harfe Çevir";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(304, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(110, 23);
   this.button1.TabIndex = 7;
   this.button1.Text = "Tümünü Seç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 8);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(288, 184);
   this.textBox1.TabIndex = 6;
   this.textBox1.Text = "textBox1";
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(304, 88);
   this.label1.Name = "label1";
   this.label1.TabIndex = 12;
   this.label1.Text = "Aranan";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(304, 112);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 13;
   this.textBox2.Text = "textBox2";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(416, 198);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox2,
                                                              this.label1,
                                                              this.button5,
                                                              this.button4,
                                                              this.button3,
                                                              this.button2,
                                                              this.button1,
                                                              this.textBox1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.ResumeLayout(false);

  }
		#endregion

		/// <summary>
			/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

  private void Form1_Load(object sender, System.EventArgs e)
  {
   textBox1.Multiline = true;
   textBox1.ScrollBars = ScrollBars.Vertical;
   textBox1.HideSelection = false;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   textBox1.SelectAll();
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   if (textBox1.SelectionLength > 0)
    //seçili bölge varsa seçili bölgeyi büyük harfe çevir
    textBox1.SelectedText = textBox1.SelectedText.ToUpper();
     else
    //seçili bölge yoksa tümünü büyük harfe çevir
    textBox1.Text = textBox1.Text.ToUpper();
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   if (textBox1.SelectionLength > 0)
    //seçili bölge varsa seçili bölgeyi küçük harfe çevir
    textBox1.SelectedText = textBox1.SelectedText.ToLower();
   else
    //seçili bölge yoksa tümünü küçük harfe çevir
    textBox1.Text = textBox1.Text.ToLower();
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   int  yer;
   string aranan=textBox2.Text;
   if (textBox1.SelectionLength > 0)
    //seçili bölge varsa seçili bölgede ara
    yer = textBox1.SelectionStart + textBox1.SelectedText.IndexOf(aranan);
   else
    //seçili bölge yoksa tümünde ara
    yer = textBox1.Text.IndexOf(aranan);
   if (yer == 0)
    MessageBox.Show("Bulunamadý");
   else
   {
    //bulundu ise seç
    textBox1.Select(yer , aranan.Length);
    //Ekrana getir
    textBox1.ScrollToCaret();
   }
  }

  private void button5_Click(object sender, System.EventArgs e)
  {
   if (textBox1.SelectionLength > 0)
    //seçili bölge varsa orayý sil
    textBox1.SelectedText = "";
   else
    //seçili bölge yoksa tümünü sil
    textBox1.Text = "";
  }
	}
}
