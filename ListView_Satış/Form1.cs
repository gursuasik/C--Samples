using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListView_Sat��
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.ColumnHeader ColumnHeader5;
  internal System.Windows.Forms.ColumnHeader ColumnHeader4;
  internal System.Windows.Forms.ComboBox comboBox2;
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.ColumnHeader ColumnHeader1;
  internal System.Windows.Forms.ColumnHeader ColumnHeader3;
  internal System.Windows.Forms.ColumnHeader ColumnHeader2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.ComboBox comboBox1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.ImageList �mageList2;
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.ImageList �mageList1;
  internal System.Windows.Forms.ListView listView1;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox textBox4;
  private System.ComponentModel.IContainer components;

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
   this.components = new System.ComponentModel.Container();
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
   this.ColumnHeader5 = new System.Windows.Forms.ColumnHeader();
   this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
   this.�mageList2 = new System.Windows.Forms.ImageList(this.components);
   this.comboBox2 = new System.Windows.Forms.ComboBox();
   this.Label5 = new System.Windows.Forms.Label();
   this.button4 = new System.Windows.Forms.Button();
   this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
   this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
   this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.�mageList1 = new System.Windows.Forms.ImageList(this.components);
   this.Label1 = new System.Windows.Forms.Label();
   this.listView1 = new System.Windows.Forms.ListView();
   this.label6 = new System.Windows.Forms.Label();
   this.textBox4 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // ColumnHeader5
   // 
   this.ColumnHeader5.Text = "Tutar�";
   this.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // ColumnHeader4
   // 
   this.ColumnHeader4.Text = "Adeti";
   this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // �mageList2
   // 
   this.�mageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
   this.�mageList2.ImageSize = new System.Drawing.Size(16, 16);
   this.�mageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("�mageList2.ImageStream")));
   this.�mageList2.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // comboBox2
   // 
   this.comboBox2.Location = new System.Drawing.Point(384, 240);
   this.comboBox2.Name = "comboBox2";
   this.comboBox2.Size = new System.Drawing.Size(121, 21);
   this.comboBox2.TabIndex = 29;
   this.comboBox2.Text = "comboBox2";
   this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
   // 
   // Label5
   // 
   this.Label5.AutoSize = true;
   this.Label5.Location = new System.Drawing.Point(384, 224);
   this.Label5.Name = "Label5";
   this.Label5.Size = new System.Drawing.Size(51, 13);
   this.Label5.TabIndex = 28;
   this.Label5.Text = "G�r�n�m";
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(272, 240);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(104, 23);
   this.button4.TabIndex = 27;
   this.button4.Text = "Bul";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // ColumnHeader1
   // 
   this.ColumnHeader1.Text = "Ad� Soyad�";
   // 
   // ColumnHeader3
   // 
   this.ColumnHeader3.Text = "Birim Fiyat�";
   this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // ColumnHeader2
   // 
   this.ColumnHeader2.Text = "Ald��� Malzeme";
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(184, 240);
   this.button3.Name = "button3";
   this.button3.TabIndex = 26;
   this.button3.Text = "De�i�tir";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(96, 240);
   this.button2.Name = "button2";
   this.button2.TabIndex = 25;
   this.button2.Text = "Sil";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 240);
   this.button1.Name = "button1";
   this.button1.TabIndex = 24;
   this.button1.Text = "Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(408, 24);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 23;
   this.textBox3.Text = "textBox3";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(304, 24);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 22;
   this.textBox2.Text = "textBox2";
   // 
   // comboBox1
   // 
   this.comboBox1.Location = new System.Drawing.Point(152, 24);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(144, 21);
   this.comboBox1.TabIndex = 21;
   this.comboBox1.Text = "comboBox1";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 24);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(136, 20);
   this.textBox1.TabIndex = 20;
   this.textBox1.Text = "textBox1";
   // 
   // Label4
   // 
   this.Label4.AutoSize = true;
   this.Label4.Location = new System.Drawing.Point(408, 8);
   this.Label4.Name = "Label4";
   this.Label4.Size = new System.Drawing.Size(30, 13);
   this.Label4.TabIndex = 19;
   this.Label4.Text = "Adeti";
   // 
   // Label3
   // 
   this.Label3.AutoSize = true;
   this.Label3.Location = new System.Drawing.Point(304, 8);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(60, 13);
   this.Label3.TabIndex = 18;
   this.Label3.Text = "Birim Fiyat�";
   // 
   // Label2
   // 
   this.Label2.AutoSize = true;
   this.Label2.Location = new System.Drawing.Point(152, 8);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(53, 13);
   this.Label2.TabIndex = 17;
   this.Label2.Text = "Ald��� Mal";
   // 
   // �mageList1
   // 
   this.�mageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
   this.�mageList1.ImageSize = new System.Drawing.Size(32, 32);
   this.�mageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("�mageList1.ImageStream")));
   this.�mageList1.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(114, 13);
   this.Label1.TabIndex = 16;
   this.Label1.Text = "M��terinin Ad� Soyad�";
   // 
   // listView1
   // 
   this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                            this.ColumnHeader1,
                                                                            this.ColumnHeader2,
                                                                            this.ColumnHeader3,
                                                                            this.ColumnHeader4,
                                                                            this.ColumnHeader5});
   this.listView1.LargeImageList = this.�mageList1;
   this.listView1.Location = new System.Drawing.Point(8, 48);
   this.listView1.Name = "listView1";
   this.listView1.Size = new System.Drawing.Size(504, 168);
   this.listView1.SmallImageList = this.�mageList2;
   this.listView1.TabIndex = 15;
   this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
   // 
   // label6
   // 
   this.label6.Location = new System.Drawing.Point(185, 222);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(72, 16);
   this.label6.TabIndex = 30;
   this.label6.Text = "Aranan";
   // 
   // textBox4
   // 
   this.textBox4.Location = new System.Drawing.Point(272, 216);
   this.textBox4.Name = "textBox4";
   this.textBox4.Size = new System.Drawing.Size(104, 20);
   this.textBox4.TabIndex = 31;
   this.textBox4.Text = "textBox4";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(520, 270);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox4,
                                                              this.label6,
                                                              this.button4,
                                                              this.button3,
                                                              this.button2,
                                                              this.button1,
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.comboBox1,
                                                              this.textBox1,
                                                              this.Label4,
                                                              this.Label3,
                                                              this.Label2,
                                                              this.Label1,
                                                              this.listView1,
                                                              this.comboBox2,
                                                              this.Label5});
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
   comboBox1.Items.Add("Disket");
   comboBox1.Items.Add("CD");
   comboBox1.Items.Add("Monit�r");
   comboBox1.Items.Add("Klavye");
   comboBox1.Items.Add("Fare");

   comboBox2.Items.Add("B�y�k Simgeler");
   comboBox2.Items.Add("Detay");
   comboBox2.Items.Add("K���k Simgeler");
   comboBox2.Items.Add("Liste");
   comboBox2.Text = "B�y�k Simgeler";

   //Kullan�c� t�klama yaparak listedeki elemanlar� de�i�tirebilsin
   listView1.LabelEdit = true;
   listView1.HideSelection = false;

   //listview.txt dosyas�ndaki sat�rlar� listView i�ine al
   try
   {
    string x;
    int i, j, say;
    System.IO.TextReader dosya = System.IO.File.OpenText("listview.txt");
    //ilk kay�tta elaman say�s� var
    x=dosya.ReadLine();
    say = int.Parse(x);
    for (i = 0 ; i<= say - 1 ; i++)
    {
     //elaman�n ba�l���n� oku
     x=dosya.ReadLine();
     listView1.Items.Add(x);
     //resim indexini oku
     x=dosya.ReadLine();
     listView1.Items[i].ImageIndex = int.Parse(x);
     //alt elemanlar� oku
     for (j = 1 ; j<= listView1.Columns.Count - 1 ; j++)
     {
      x=dosya.ReadLine();
      listView1.Items[i].SubItems.Add(x);
     }
    }
    dosya.Close();
   }
   catch
   {
    ;
   }
  }

  private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   //g�r�n�m� de�i�tir
   listView1.View = (View) comboBox2.SelectedIndex;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   int index;
   //Kutularda yaz�l� olan� listenin sonuna ekle
   listView1.Items.Add(textBox1.Text);
   //Son eklenen eleman�n indexini bul
   index = listView1.Items.Count - 1;
   listView1.Items[index].ImageIndex = comboBox1.SelectedIndex;
   listView1.Items[index].SubItems.Add(comboBox1.Text);
   listView1.Items[index].SubItems.Add(textBox2.Text);
   listView1.Items[index].SubItems.Add(textBox3.Text);
   try
   {
    listView1.Items[index].SubItems.Add((int.Parse(textBox2.Text) * 
     int.Parse(textBox3.Text)).ToString());
   }
   catch
   {
    MessageBox.Show("Say�larda hata var");
   }
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   //Se�ili eleman� sil
   if (listView1.SelectedItems.Count > 0)//Se�ili eleman varsa sil
    listView1.SelectedItems[0].Remove();
   else
    MessageBox.Show("�nce silinecek eleman� se�iniz");
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
     //Se�ili eleman� kutularda yaz�l� olanla de�i�tir.
   if (listView1.SelectedItems.Count == 0)//Se�ili eleman yoksa
    MessageBox.Show("�nce de�i�tirilecek eleman� se�iniz");
   else
   {
    listView1.SelectedItems[0].Text = textBox1.Text;
    listView1.SelectedItems[0].ImageIndex = comboBox1.SelectedIndex;
    listView1.SelectedItems[0].SubItems[1].Text = comboBox1.Text;
    listView1.SelectedItems[0].SubItems[2].Text = textBox2.Text;
    listView1.SelectedItems[0].SubItems[3].Text = textBox3.Text;
    try
    {
     listView1.SelectedItems[0].SubItems[4].Text = (int.Parse(textBox2.Text) * 
      int.Parse(textBox3.Text)).ToString();
    }
    catch
    {
     MessageBox.Show("Say�larda hata var");
    }
   }
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   //Bul ve se�
   string aranan;
   int i;
   aranan = textBox4.Text;
   for (i = 0 ; i<=listView1.Items.Count - 1 ; i++)
    if (listView1.Items[i].Text == aranan)
    {
     listView1.Items[i].Selected = true;//Bulunanu se�
     return;//bulunursa aramaya devam etmeden ��k
    }
  }

  private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
     //se�ili elemana ait �zellikleri g�ster
   if (listView1.SelectedItems.Count > 0)
   {
    textBox1.Text = listView1.SelectedItems[0].Text;
    comboBox1.SelectedIndex = listView1.SelectedItems[0].ImageIndex;
    textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
    textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
   }
  }

  private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   string x;
   int i, j;
   System.IO.TextWriter dosya=System.IO.File.CreateText("listview.txt");
   //ilk kayda elaman say�s�n� yaz
   x = listView1.Items.Count.ToString();
   dosya.WriteLine(x);
   for (i = 0 ; i<= listView1.Items.Count - 1 ; i++)
   {
    //elaman�n ba�l���n� yaz
    x = listView1.Items[i].Text;
    dosya.WriteLine(x);
    //resim indexini yaz
    x = listView1.Items[i].ImageIndex.ToString();
    dosya.WriteLine(x);
    //alt elemanlar� yaz
    for (j = 1 ; j<= listView1.Columns.Count - 1 ; j++)
    {
     x = listView1.Items[i].SubItems[j].Text;
     dosya.WriteLine(x);
    }
   }
   dosya.Close();
  }
	}
}
