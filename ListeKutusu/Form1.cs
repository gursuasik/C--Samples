using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListeKutusu
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.ListBox listBox3;
  internal System.Windows.Forms.ListBox listBox2;
  internal System.Windows.Forms.Label label7;
  internal System.Windows.Forms.Label Label6;
  internal System.Windows.Forms.Label label5;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.ListBox listBox1;
  internal System.Windows.Forms.Button button6;
  internal System.Windows.Forms.Button button5;
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.GroupBox GroupBox1;
  internal System.Windows.Forms.ComboBox comboBox2;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.ComboBox comboBox1;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  private System.Windows.Forms.TextBox textBox2;
  private System.Windows.Forms.Label label8;
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
   this.listBox3 = new System.Windows.Forms.ListBox();
   this.listBox2 = new System.Windows.Forms.ListBox();
   this.label7 = new System.Windows.Forms.Label();
   this.Label6 = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.Label4 = new System.Windows.Forms.Label();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.button6 = new System.Windows.Forms.Button();
   this.button5 = new System.Windows.Forms.Button();
   this.button4 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.GroupBox1 = new System.Windows.Forms.GroupBox();
   this.comboBox2 = new System.Windows.Forms.ComboBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.label8 = new System.Windows.Forms.Label();
   this.GroupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // listBox3
   // 
   this.listBox3.Location = new System.Drawing.Point(312, 128);
   this.listBox3.Name = "listBox3";
   this.listBox3.Size = new System.Drawing.Size(144, 108);
   this.listBox3.TabIndex = 27;
   // 
   // listBox2
   // 
   this.listBox2.Location = new System.Drawing.Point(160, 128);
   this.listBox2.Name = "listBox2";
   this.listBox2.Size = new System.Drawing.Size(144, 108);
   this.listBox2.TabIndex = 26;
   // 
   // label7
   // 
   this.label7.Location = new System.Drawing.Point(352, 256);
   this.label7.Name = "label7";
   this.label7.TabIndex = 25;
   this.label7.Text = "Label7";
   // 
   // Label6
   // 
   this.Label6.AutoSize = true;
   this.Label6.Location = new System.Drawing.Point(304, 256);
   this.Label6.Name = "Label6";
   this.Label6.Size = new System.Drawing.Size(45, 13);
   this.Label6.TabIndex = 24;
   this.Label6.Text = "Sýra No:";
   // 
   // label5
   // 
   this.label5.Location = new System.Drawing.Point(96, 256);
   this.label5.Name = "label5";
   this.label5.TabIndex = 23;
   this.label5.Text = "Label5";
   // 
   // Label4
   // 
   this.Label4.AutoSize = true;
   this.Label4.Location = new System.Drawing.Point(8, 256);
   this.Label4.Name = "Label4";
   this.Label4.Size = new System.Drawing.Size(84, 13);
   this.Label4.TabIndex = 22;
   this.Label4.Text = "Personel sayýsý:";
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 128);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(144, 108);
   this.listBox1.TabIndex = 21;
   this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
   // 
   // button6
   // 
   this.button6.Location = new System.Drawing.Point(360, 96);
   this.button6.Name = "button6";
   this.button6.Size = new System.Drawing.Size(88, 23);
   this.button6.TabIndex = 20;
   this.button6.Text = "Araya Ekle";
   this.button6.Click += new System.EventHandler(this.button6_Click);
   // 
   // button5
   // 
   this.button5.Location = new System.Drawing.Point(272, 96);
   this.button5.Name = "button5";
   this.button5.TabIndex = 19;
   this.button5.Text = "Deðiþtir";
   this.button5.Click += new System.EventHandler(this.button5_Click);
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(360, 64);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(88, 23);
   this.button4.TabIndex = 18;
   this.button4.Text = "Sonrakini Bul";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(272, 16);
   this.button1.Name = "button1";
   this.button1.TabIndex = 15;
   this.button1.Text = "Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // GroupBox1
   // 
   this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.comboBox2,
                                                                        this.Label3,
                                                                        this.comboBox1,
                                                                        this.Label2,
                                                                        this.Label1,
                                                                        this.textBox1});
   this.GroupBox1.Location = new System.Drawing.Point(8, 8);
   this.GroupBox1.Name = "GroupBox1";
   this.GroupBox1.Size = new System.Drawing.Size(240, 112);
   this.GroupBox1.TabIndex = 14;
   this.GroupBox1.TabStop = false;
   this.GroupBox1.Text = "Personelin:";
   // 
   // comboBox2
   // 
   this.comboBox2.Location = new System.Drawing.Point(112, 80);
   this.comboBox2.Name = "comboBox2";
   this.comboBox2.Size = new System.Drawing.Size(121, 21);
   this.comboBox2.TabIndex = 6;
   this.comboBox2.Text = "ComboBox2";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 80);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 5;
   this.Label3.Text = "Çalýþtýðý Birim";
   // 
   // comboBox1
   // 
   this.comboBox1.Location = new System.Drawing.Point(112, 48);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(120, 21);
   this.comboBox1.TabIndex = 4;
   this.comboBox1.Text = "ComboBox1";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 48);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 3;
   this.Label2.Text = "Mesleði";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 24);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 2;
   this.Label1.Text = "Adý Soyadý";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(112, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(112, 20);
   this.textBox1.TabIndex = 1;
   this.textBox1.Text = "TextBox1";
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(272, 64);
   this.button3.Name = "button3";
   this.button3.TabIndex = 17;
   this.button3.Text = "Bul";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(360, 16);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(88, 23);
   this.button2.TabIndex = 16;
   this.button2.Text = "Sil";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(358, 40);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(88, 20);
   this.textBox2.TabIndex = 28;
   this.textBox2.Text = "textBox2";
   // 
   // label8
   // 
   this.label8.Location = new System.Drawing.Point(272, 43);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(72, 23);
   this.label8.TabIndex = 29;
   this.label8.Text = "Aranan:";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(464, 286);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label8,
                                                              this.textBox2,
                                                              this.listBox3,
                                                              this.listBox2,
                                                              this.label7,
                                                              this.Label6,
                                                              this.label5,
                                                              this.Label4,
                                                              this.listBox1,
                                                              this.button6,
                                                              this.button5,
                                                              this.button4,
                                                              this.button1,
                                                              this.GroupBox1,
                                                              this.button3,
                                                              this.button2});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
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
   string[] meslekler = {"Mühendis", "Öðretmen", "Öðrenci", "Ýþçi", 
                         "Muhasebeci", "Programcý"};
   comboBox1.Items.AddRange(meslekler);
   string[] birimler = {"Satýþ", "Eðitim", "Pazarlama", "Muhasebe", 
                      "Reklam", "Üretim"};
   comboBox2.Items.AddRange(birimler);

   //Dosyadaki dosyaleri yükle
   try
   {
    //dosyayý aç 
    System.IO.TextReader dosya = System.IO.File.OpenText("pers.dat");
    string satýr;
    //dosyadaki dosyaleri listelere ekle
    while((satýr = dosya.ReadLine())!= null)
    {
     listBox1.Items.Add(satýr);
     satýr = dosya.ReadLine();
     listBox2.Items.Add(satýr);
     satýr = dosya.ReadLine();
     listBox3.Items.Add(satýr);
    }
    
    //dosyayý kapat
    dosya.Close();
   }
   catch
   {
    ;
   }
   label5.Text = listBox1.Items.Count.ToString();
   label7.Text = (listBox1.SelectedIndex + 1).ToString();

   //Olaylarý birleþtir. 
   listBox2.SelectedIndexChanged += new 
    EventHandler(listBox1_SelectedIndexChanged);
   listBox3.SelectedIndexChanged += new 
    EventHandler(listBox1_SelectedIndexChanged);
  }

  private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   //Listedeki dosyaleri dosyalara kaydet
   //Dosyayý oluþtur
   System.IO.TextWriter dosya = System.IO.File.CreateText("pers.dat");
   //Listedeki dosyaleri dosyalara aktar
   for(int i=0;i<listBox1.Items.Count;i++)
   {
    dosya.WriteLine(listBox1.Items[i]);
    dosya.WriteLine(listBox2.Items[i]);
    dosya.WriteLine(listBox3.Items[i]);
   }
   //dosyayý kapat
   dosya.Close();
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   //Ekle düðmesi 
   int yer;
   yer = listBox1.FindStringExact(textBox1.Text); //bul
   if (yer < 0) //listede yoksa ekle
   {
    listBox1.Items.Add(textBox1.Text);
    listBox2.Items.Add(comboBox1.Text);
    listBox3.Items.Add(comboBox2.Text);
    label5.Text = listBox1.Items.Count.ToString();
   }
   else //Listede varsa
   {
    listBox1.SelectedIndex = yer; //bulunaný seç
    MessageBox.Show("Bu elaman zaten listede var");
   }
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   //Sil düðmesi
   if (listBox1.SelectedIndex < 0)
   {
    MessageBox.Show("Önce silinecek elemaný seçiniz");
    return;
   }
   int ind;
   DialogResult c;
   ind = listBox1.SelectedIndex;
   c = MessageBox.Show(listBox1.SelectedItem + " silinsin mi","Sil",MessageBoxButtons.YesNo);
   if (c == DialogResult.Yes)
   {
    listBox1.Items.RemoveAt(ind);
    listBox2.Items.RemoveAt(ind);
    listBox3.Items.RemoveAt(ind);
    label5.Text = listBox1.Items.Count.ToString();
   }
  }

  int yer=-1;
  string aranan;
  private void button3_Click(object sender, System.EventArgs e)
  {
   //Bul düðmesi
   aranan = textBox2.Text;
   yer = listBox1.FindStringExact(aranan);
   if (yer < 0)
   {
    //Bulunamazsa benzerini ara
    yer = listBox1.FindString(aranan);
    if (yer < 0) 
     MessageBox.Show("Bulunamadý");
   }
   if (yer >= 0) 
    listBox1.SelectedIndex = yer; //Bulundu ise seç
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   //Sonrakini Bul düðmesi
   if (yer < listBox1.Items.Count - 1)
   {
    yer = listBox1.FindString(aranan, yer);
    if (yer >= 0) 
     listBox1.SelectedIndex = yer;//Bulundu ise seç
   }
  }

  private void button5_Click(object sender, System.EventArgs e)
  {
   //Deðiþtir düðmesi
   int ind;
   string ad, meslek, birim;
   ad = textBox1.Text;
   meslek = comboBox1.Text;
   birim = comboBox2.Text;
   ind = listBox1.SelectedIndex;
   if (ind < 0)
    MessageBox.Show("Önce deðiþtirilecek elemaný seçiniz");
   else
   {
    listBox1.Items[ind] = ad;
    listBox2.Items[ind] = meslek;
    listBox3.Items[ind] = birim;
   }
  }

  private void button6_Click(object sender, System.EventArgs e)
  {
   //Araya ekle düðmesi
   int ind;
   ind = listBox1.SelectedIndex;
   if (ind < 0)
    MessageBox.Show("Önce elemanýn nereye ekleneceðini seçiniz");
   else
   {
    int yer;
    yer = listBox1.FindStringExact(textBox1.Text); //bul
    if (yer < 0) //listede yoksa ekle
    {
     listBox1.Items.Insert(ind, textBox1.Text);
     listBox2.Items.Insert(ind, comboBox1.Text);
     listBox3.Items.Insert(ind, comboBox2.Text);
     label5.Text = listBox1.Items.Count.ToString();
    }
    else //Listede varsa
    {
     listBox1.SelectedIndex = yer; //bulunaný seç
     MessageBox.Show("Bu elaman zaten listede var");
    }
   }
  }

  private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   int ind;
   ind = (sender as ListBox).SelectedIndex; //Seçili elemanýn indexi
   //diðer listelerde de ayný elemaný seç
   listBox1.SelectedIndex = ind;
   listBox2.SelectedIndex = ind;
   listBox3.SelectedIndex = ind;
   int Top_ind;
   Top_ind = (sender as ListBox).TopIndex; //Seçili elemanýn top indexi
   //diðer listelerin de TopIndexini ayarla
   listBox1.TopIndex = Top_ind;
   listBox2.TopIndex = Top_ind;
   listBox3.TopIndex = Top_ind;

   //Listelerdeki bilgileri Text ve Combo kutularýnda göster
   textBox1.Text = listBox1.Text;
   comboBox1.Text = listBox2.Text;
   comboBox2.Text = listBox3.Text;

   //Seçili elemanýn numarasýný göster
   label7.Text = (listBox1.SelectedIndex + 1).ToString();
  }
 }
}