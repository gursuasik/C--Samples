using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Çizim_Satýr_Yaz
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.ListBox listBox1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.FontDialog fontDialog1;
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
   this.button3 = new System.Windows.Forms.Button();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.button2 = new System.Windows.Forms.Button();
   this.fontDialog1 = new System.Windows.Forms.FontDialog();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // button3
   // 
   this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
   this.button3.Location = new System.Drawing.Point(184, 56);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(88, 23);
   this.button3.TabIndex = 9;
   this.button3.Text = "Yazý Tipi Seç";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 32);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(168, 199);
   this.listBox1.TabIndex = 8;
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(184, 32);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(88, 23);
   this.button2.TabIndex = 7;
   this.button2.Text = "Forma Yazdýr";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(184, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(88, 23);
   this.button1.TabIndex = 6;
   this.button1.Text = "Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(168, 20);
   this.textBox1.TabIndex = 5;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(280, 238);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.listBox1,
                                                              this.button2,
                                                              this.button1,
                                                              this.textBox1,
                                                              this.button3});
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

  public static Font fnt;//Form2'den seçilen fonta eriþmek için
  public static ListBox Lst; //Form2'den Listeye eriþmek için

  private void button1_Click(object sender, System.EventArgs e)
  {
    listBox1.Items.Add(textBox1.Text);
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   Form2 frm = new Form2();
   frm.Show();
   Lst = listBox1;
   fnt = fontDialog1.Font;
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   fontDialog1.ShowDialog();
  }
	}
}
