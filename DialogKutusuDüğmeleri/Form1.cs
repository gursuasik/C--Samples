using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DialogKutusuD��meleri
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
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
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(80, 184);
   this.button1.Name = "button1";
   this.button1.TabIndex = 3;
   this.button1.Text = "Sil";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 8);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(232, 168);
   this.textBox1.TabIndex = 2;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(248, 214);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.textBox1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
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
   textBox1.Text="";
   //Bilgi.dat dosyas�ndaki sat�rlar� textBox1 i�ine al
   try
   {
    System.IO.TextReader dosya = System.IO.File.OpenText("bilgi.dat");
    string sat�r;
    while((sat�r = dosya.ReadLine())!= null)
     textBox1.Text+=sat�r+(char)13+(char)10;
    dosya.Close();
   }
   catch
   {
    ;
   }
  }

  private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   Form2 f = new Form2();
   DialogResult c;
   f.Text = "��k��";
   c = f.ShowDialog();
   switch(c)
   {
    case DialogResult.Yes: //Evet se�ildiyse
     //textBox1 i�indeki bilgileri bilgi.dat i�ine yaz
     System.IO.TextWriter dosya=System.IO.File.CreateText("bilgi.dat");
     dosya.Write(textBox1.Text);
     dosya.Close();
     break;
    case DialogResult.No: //Hay�r se�ildiyse bir i� yapmaya gerek yok
     break;
    case DialogResult.Cancel: //�ptal se�ildiyse
     e.Cancel = true; //��k��� iptal et
     break;
   }
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   Form2 f =new Form2();
   DialogResult c;
   f.Text = "Sil";
   f.label1.Text = "D � K K A T !!!\r\n" + 
    "Text kutusunun i�eri�i silinsin mi?";
   f.button3.Visible = false;
   c = f.ShowDialog();
   //Evet se�ildiyse sil
   if (c == DialogResult.Yes) textBox1.Text = "";
  }

	}
}
