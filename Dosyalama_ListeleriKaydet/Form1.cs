using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Dosyalama_ListeleriKaydet
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.ListBox listBox3;
  internal System.Windows.Forms.ListBox listBox2;
  internal System.Windows.Forms.ListBox listBox1;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label2;
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
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.listBox3 = new System.Windows.Forms.ListBox();
   this.listBox2 = new System.Windows.Forms.ListBox();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(328, 40);
   this.button2.Name = "button2";
   this.button2.TabIndex = 21;
   this.button2.Text = "Sil";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(328, 8);
   this.button1.Name = "button1";
   this.button1.TabIndex = 20;
   this.button1.Text = "Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // listBox3
   // 
   this.listBox3.Location = new System.Drawing.Point(256, 56);
   this.listBox3.Name = "listBox3";
   this.listBox3.Size = new System.Drawing.Size(56, 186);
   this.listBox3.TabIndex = 19;
   // 
   // listBox2
   // 
   this.listBox2.Location = new System.Drawing.Point(144, 56);
   this.listBox2.Name = "listBox2";
   this.listBox2.Size = new System.Drawing.Size(104, 186);
   this.listBox2.TabIndex = 18;
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 56);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(120, 186);
   this.listBox1.TabIndex = 17;
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(256, 32);
   this.textBox3.Name = "textBox3";
   this.textBox3.Size = new System.Drawing.Size(56, 20);
   this.textBox3.TabIndex = 16;
   this.textBox3.Text = "TextBox3";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(144, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 15;
   this.textBox2.Text = "TextBox2";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(256, 8);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(32, 23);
   this.Label3.TabIndex = 14;
   this.Label3.Text = "Sýnýfý";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 32);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(120, 20);
   this.textBox1.TabIndex = 13;
   this.textBox1.Text = "TextBox1";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(144, 8);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 12;
   this.Label2.Text = "Bölümü";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 11;
   this.Label1.Text = "Öðrencinin Adý";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(408, 254);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1,
                                                              this.listBox3,
                                                              this.listBox2,
                                                              this.listBox1,
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.Label3,
                                                              this.textBox1,
                                                              this.Label2,
                                                              this.Label1});
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
   System.IO.FileInfo d = new System.IO.FileInfo("öðrenci.dat");
   if (d.Exists==true) //dosya varsa
   {
    System.IO.TextReader dosya = System.IO.File.OpenText("öðrenci.dat");
    string adý, bölümü, sýnýfý;
    while ((adý=dosya.ReadLine())!=null)
    {
     listBox1.Items.Add(adý);
     bölümü = dosya.ReadLine();
     listBox2.Items.Add(bölümü);
     sýnýfý = dosya.ReadLine();
     listBox3.Items.Add(sýnýfý);
    }
    dosya.Close(); //dosyayý kapat
   }
  }

  private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   int i;
   System.IO.TextWriter dosya=System.IO.File.CreateText("öðrenci.dat");
   for (i = 0 ; i <= listBox1.Items.Count - 1 ; i++)
   {
    //Bilgileri dosyaya yaz
    dosya.WriteLine(listBox1.Items[i]);
    dosya.WriteLine(listBox2.Items[i]);
    dosya.WriteLine(listBox3.Items[i]);
   }
   dosya.Close();//Dosyayý kapat
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   //Text kutularýndaki bilgileri listelere ekle
   listBox1.Items.Add(textBox1.Text);
   listBox2.Items.Add(textBox2.Text);
   listBox3.Items.Add(textBox3.Text);
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   int ind;
   ind = listBox1.SelectedIndex;
   if (ind < 0)
    MessageBox.Show("Silinecek elemaný seçiniz");
   else
   {
    listBox1.Items.RemoveAt(ind);
    listBox2.Items.RemoveAt(ind);
    listBox3.Items.RemoveAt(ind);
   }
  }
	}
}
