using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListedeSayýSýralama
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.ListBox listBox1;
  private System.Windows.Forms.Button button1;
  internal System.Windows.Forms.GroupBox GroupBox1;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button4;
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
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.button1 = new System.Windows.Forms.Button();
   this.GroupBox1 = new System.Windows.Forms.GroupBox();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button4 = new System.Windows.Forms.Button();
   this.GroupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 8);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(144, 251);
   this.listBox1.TabIndex = 0;
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 272);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(144, 32);
   this.button1.TabIndex = 2;
   this.button1.Text = "Sýrala";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // GroupBox1
   // 
   this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.button3,
                                                                        this.button2,
                                                                        this.button4});
   this.GroupBox1.Location = new System.Drawing.Point(160, 8);
   this.GroupBox1.Name = "GroupBox1";
   this.GroupBox1.Size = new System.Drawing.Size(208, 112);
   this.GroupBox1.TabIndex = 6;
   this.GroupBox1.TabStop = false;
   this.GroupBox1.Text = "2000 Elemanlý bir listeyi";
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(8, 80);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(192, 23);
   this.button3.TabIndex = 3;
   this.button3.Text = "Bir Dizi Üzerinde Sýrala";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(8, 48);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(192, 23);
   this.button2.TabIndex = 2;
   this.button2.Text = "BeginUpdate-EndUpdate ile Sýrala";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(8, 16);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(192, 23);
   this.button4.TabIndex = 1;
   this.button4.Text = "Sýrala";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(368, 310);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.GroupBox1,
                                                              this.button1,
                                                              this.listBox1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.GroupBox1.ResumeLayout(false);
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
   int i;
   Random r=new Random();
   //Listeye 20 tane rasgele sayý ekle
   for (i = 1;i<=20;i++)
    listBox1.Items.Add(((int) r.Next(1000)).ToString());
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   int i, j, c ;
   for (i = 0;i<=listBox1.Items.Count - 1;i++)
    for (j = i;j<=listBox1.Items.Count - 1;j++)
     if (int.Parse(listBox1.Items[j].ToString()) > 
      int.Parse(listBox1.Items[i].ToString()))
     {
      //elemanlarýn yerini deðiþtir
      c = int.Parse(listBox1.Items[i].ToString());
      listBox1.Items[i] = listBox1.Items[j];
      listBox1.Items[j] = c.ToString();
     }
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   int i, j, c ;
   listBox1.Items.Clear();
   Random r=new Random();
   //Listeye 2000 tane rasgele sayý ekle
   for (i = 1;i<=2000;i++)
    listBox1.Items.Add(((int) r.Next(1000)).ToString());

   DateTime baslama_zamani, bitis_zamani;
   TimeSpan fark;
   this.Text="Lütfen bekleyin..";
   baslama_zamani = DateTime.Now;
   listBox1.BeginUpdate();
   for (i = 0;i<=listBox1.Items.Count - 1;i++)
    for (j = i;j<=listBox1.Items.Count - 1;j++)
     if (int.Parse(listBox1.Items[j].ToString()) > int.Parse(listBox1.Items[i].ToString()))
     {
      //elemanlarýn yerini deðiþtir
      c = int.Parse(listBox1.Items[i].ToString());
      listBox1.Items[i] = listBox1.Items[j];
      listBox1.Items[j] = c.ToString();
     }
   listBox1.EndUpdate();
   bitis_zamani = DateTime.Now;
   fark = bitis_zamani-baslama_zamani;
   this.Text = "Ýþlem süresi "+fark.ToString();
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   int i, j, c ;
   listBox1.Items.Clear();
   Random r=new Random();
   //Listeye 2000 tane rasgele sayý ekle
   for (i = 1;i<=2000;i++)
    listBox1.Items.Add(((int) r.Next(1000)).ToString());
   DateTime baslama_zamani, bitis_zamani;
   TimeSpan fark;
   this.Text="Lütfen bekleyin..";
   baslama_zamani = DateTime.Now;
   for (i = 0;i<=listBox1.Items.Count - 1;i++)
    for (j = i;j<=listBox1.Items.Count - 1;j++)
     if (int.Parse(listBox1.Items[j].ToString()) > 
      int.Parse(listBox1.Items[i].ToString()))
     {
      //elemanlarýn yerini deðiþtir
      c = int.Parse(listBox1.Items[i].ToString());
      listBox1.Items[i] = listBox1.Items[j];
      listBox1.Items[j] = c.ToString();
     }
   bitis_zamani = DateTime.Now;
   fark = bitis_zamani-baslama_zamani;
   this.Text = "Ýþlem süresi "+fark.ToString();
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   int i, j, c ;
   listBox1.Items.Clear();
   Random r=new Random();
   //Listeye 2000 tane rasgele sayý ekle
   for (i = 1;i<=2000;i++)
    listBox1.Items.Add(((int) r.Next(1000)).ToString());
   DateTime baslama_zamani, bitis_zamani;
   TimeSpan fark;
   this.Text="Lütfen bekleyin..";
   baslama_zamani = DateTime.Now;
   listBox1.BeginUpdate();
   int[] x=new int[listBox1.Items.Count];
   //listeyi diziye al
   for(i = 0;i<=listBox1.Items.Count - 1;i++)
    x[i] = int.Parse(listBox1.Items[i].ToString());
   //diziyi sýrala
   for (i = 0;i<=listBox1.Items.Count - 1;i++)
    for (j = i;j<=listBox1.Items.Count - 1;j++)
     if (x[j] > x[i])
     {
      //elemanlarýn yerini deðiþtir
      c = x[i];
      x[i] = x[j];
      x[j] = c;
     }
   //Diziyi listeye al
   for (i = 0;i<=listBox1.Items.Count - 1;i++)
    listBox1.Items[i] = x[i];
   listBox1.EndUpdate();
   bitis_zamani = DateTime.Now;
   fark = bitis_zamani-baslama_zamani;
   this.Text = "Ýþlem süresi "+fark.ToString();
  }
	}
}
