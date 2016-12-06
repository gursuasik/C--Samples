using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListedenSeçme
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label Label4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.ListBox listBox3;
  internal System.Windows.Forms.ListBox listBox2;
  internal System.Windows.Forms.ListBox listBox1;
  internal System.Windows.Forms.TextBox textBox3;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.Label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.listBox3 = new System.Windows.Forms.ListBox();
   this.listBox2 = new System.Windows.Forms.ListBox();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.textBox3 = new System.Windows.Forms.TextBox();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(160, 184);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(160, 23);
   this.button2.TabIndex = 23;
   this.button2.Text = "Listeden Sil";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(16, 184);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(128, 23);
   this.button1.TabIndex = 22;
   this.button1.Text = "Listeye Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Label4
   // 
   this.Label4.Location = new System.Drawing.Point(216, 56);
   this.Label4.Name = "Label4";
   this.Label4.TabIndex = 21;
   this.Label4.Text = "Baba Adý";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(112, 56);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 20;
   this.Label3.Text = "Bölümü";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 56);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 19;
   this.Label2.Text = "Adý Soyadý";
   // 
   // listBox3
   // 
   this.listBox3.Location = new System.Drawing.Point(216, 80);
   this.listBox3.Name = "listBox3";
   this.listBox3.Size = new System.Drawing.Size(104, 95);
   this.listBox3.TabIndex = 18;
   // 
   // listBox2
   // 
   this.listBox2.Location = new System.Drawing.Point(112, 80);
   this.listBox2.Name = "listBox2";
   this.listBox2.Size = new System.Drawing.Size(96, 95);
   this.listBox2.TabIndex = 17;
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 80);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(96, 95);
   this.listBox1.TabIndex = 16;
   this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
   // 
   // textBox3
   // 
   this.textBox3.Location = new System.Drawing.Point(216, 32);
   this.textBox3.Name = "textBox3";
   this.textBox3.TabIndex = 15;
   this.textBox3.Text = "textBox3";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(112, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 14;
   this.textBox2.Text = "textBox2";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 32);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 13;
   this.textBox1.Text = "textBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 12;
   this.Label1.Text = "Öðrencinin:";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(328, 214);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1,
                                                              this.Label4,
                                                              this.Label3,
                                                              this.Label2,
                                                              this.listBox3,
                                                              this.listBox2,
                                                              this.listBox1,
                                                              this.textBox3,
                                                              this.textBox2,
                                                              this.textBox1,
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

  private void button1_Click(object sender, System.EventArgs e)
  {
   listBox1.Items.Add(textBox1.Text);
   listBox2.Items.Add(textBox2.Text);
   listBox3.Items.Add(textBox3.Text);
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   int ind;
   ind = listBox1.SelectedIndex;
   if (ind < 0)
    MessageBox.Show("Önce silinecek elemaný seçin");
   else
   {
    listBox1.Items.RemoveAt(ind);
    listBox2.Items.RemoveAt(ind);
    listBox3.Items.RemoveAt(ind);
   }
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   //Olaylarý birleþtir. 
   listBox2.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
   listBox3.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);

   //Dosyadaki bilgileri yükle
   try
   {
    //dosyayý aç 
    System.IO.TextReader bilgi = System.IO.File.OpenText("bilgi.dat");
    string satýr;
    //dosyadaki bilgileri listelere ekle
    while((satýr = bilgi.ReadLine())!= null)
    {
     listBox1.Items.Add(satýr);
     satýr = bilgi.ReadLine();
     listBox2.Items.Add(satýr);
     satýr = bilgi.ReadLine();
     listBox3.Items.Add(satýr);
    }
    
    //dosyayý kapat
    bilgi.Close();
   }
   catch
   {
    ;
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

   //Listelerdeki bilgileri Text kutularýnda göster
   textBox1.Text = listBox1.Text;
   textBox2.Text = listBox2.Text;
   textBox3.Text = listBox3.Text;
  }

  private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   //Listedeki bilgileri dosyalara kaydet
   //Dosyayý oluþtur
   System.IO.TextWriter bilgi = System.IO.File.CreateText("bilgi.dat");
   //Listedeki bilgileri dosyalara aktar
   for(int i=0;i<listBox1.Items.Count;i++)
   {
    bilgi.WriteLine(listBox1.Items[i]);
    bilgi.WriteLine(listBox2.Items[i]);
    bilgi.WriteLine(listBox3.Items[i]);
   }
   //dosyayý kapat
   bilgi.Close();
  }

 }
}
