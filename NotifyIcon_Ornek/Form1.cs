using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NotifyIcon_Ornek
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.ContextMenu contextMenu1;
  internal System.Windows.Forms.MenuItem Mn_Ayarlar;
  internal System.Windows.Forms.MenuItem Mn_Çýkýþ;
  internal System.Windows.Forms.Button button4;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.ListBox listBox2;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.ListBox listBox1;
  internal System.Windows.Forms.NotifyIcon notifyIcon1;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
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
   this.contextMenu1 = new System.Windows.Forms.ContextMenu();
   this.Mn_Ayarlar = new System.Windows.Forms.MenuItem();
   this.Mn_Çýkýþ = new System.Windows.Forms.MenuItem();
   this.button4 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.button3 = new System.Windows.Forms.Button();
   this.listBox2 = new System.Windows.Forms.ListBox();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // contextMenu1
   // 
   this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                             this.Mn_Ayarlar,
                                                                             this.Mn_Çýkýþ});
   this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
   // 
   // Mn_Ayarlar
   // 
   this.Mn_Ayarlar.Index = 0;
   this.Mn_Ayarlar.Text = "Ayarlar";
   this.Mn_Ayarlar.Click += new System.EventHandler(this.Mn_Ayarlar_Click);
   // 
   // Mn_Çýkýþ
   // 
   this.Mn_Çýkýþ.Index = 1;
   this.Mn_Çýkýþ.Text = "Çýkýþ";
   this.Mn_Çýkýþ.Click += new System.EventHandler(this.Mn_Çýkýþ_Click);
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(275, 160);
   this.button4.Name = "button4";
   this.button4.TabIndex = 19;
   this.button4.Text = "Gizle";
   this.button4.Click += new System.EventHandler(this.button4_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(275, 56);
   this.button2.Name = "button2";
   this.button2.TabIndex = 17;
   this.button2.Text = "Gözat";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(275, 24);
   this.button1.Name = "button1";
   this.button1.TabIndex = 16;
   this.button1.Text = "Listeye Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(275, 88);
   this.button3.Name = "button3";
   this.button3.TabIndex = 18;
   this.button3.Text = "Sil";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // listBox2
   // 
   this.listBox2.Location = new System.Drawing.Point(139, 48);
   this.listBox2.Name = "listBox2";
   this.listBox2.Size = new System.Drawing.Size(128, 134);
   this.listBox2.TabIndex = 15;
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(11, 48);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(120, 134);
   this.listBox1.TabIndex = 14;
   // 
   // notifyIcon1
   // 
   this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
   this.notifyIcon1.Text = "NotifyIcon1";
   this.notifyIcon1.Visible = true;
   this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(139, 24);
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(128, 20);
   this.textBox2.TabIndex = 13;
   this.textBox2.Text = "textBox2";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(11, 24);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(120, 20);
   this.textBox1.TabIndex = 12;
   this.textBox1.Text = "textBox1";
   // 
   // Label2
   // 
   this.Label2.AutoSize = true;
   this.Label2.Location = new System.Drawing.Point(139, 8);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(76, 13);
   this.Label2.TabIndex = 11;
   this.Label2.Text = "Programýn Adý";
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(11, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(91, 13);
   this.Label1.TabIndex = 10;
   this.Label1.Text = "Program Dosyasý";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(360, 190);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button3,
                                                              this.listBox2,
                                                              this.listBox1,
                                                              this.textBox2,
                                                              this.textBox1,
                                                              this.Label2,
                                                              this.Label1,
                                                              this.button4,
                                                              this.button2,
                                                              this.button1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
   this.Load += new System.EventHandler(this.Form1_Load);
   this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
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
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   openFileDialog1.Filter = "Program dosyalarý|*.exe;*.com;*.bat;*.pif|" +
    "Bütün dosyalar|*.*";
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
   {
    textBox1.Text = openFileDialog1.FileName;
    textBox2.Text = 
     System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
   }
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   int ind;
   ind = listBox1.SelectedIndex;
   if (ind < 0)
    MessageBox.Show("Silinecek programý listeden seçiniz");
   else
   {
    listBox1.Items.RemoveAt(ind);
    listBox2.Items.RemoveAt(ind);
   }
  }

  private void button4_Click(object sender, System.EventArgs e)
  {
   this.Hide();
  }

  private void Form1_VisibleChanged(object sender, System.EventArgs e)
  {
   notifyIcon1.Visible = !this.Visible;
  }

  private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
  {
   this.Show();
  }

  private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   System.IO.TextWriter dosya=System.IO.File.CreateText(Application.StartupPath+"ayarlar.dat");
   int i;
   for (i = 0 ; i<= listBox1.Items.Count - 1 ; i++)
   {
    dosya.WriteLine(listBox1.Items[i]);
    dosya.WriteLine(listBox2.Items[i]);
   }
   dosya.Close();
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   notifyIcon1.Text = "Hýzlý Baþlat 1.0";
   notifyIcon1.ContextMenu = contextMenu1;
   this.Text = "Hýzlý Baþlat 1.0";
   try
   {
    System.IO.TextReader dosya = System.IO.File.OpenText(Application.StartupPath+"ayarlar.dat");
    string satýr;
    while((satýr = dosya.ReadLine())!= null)
    {
     listBox1.Items.Add(satýr);
     satýr = dosya.ReadLine();
     listBox2.Items.Add(satýr);
    }
    dosya.Close();
   }
   catch
   {;}
  }

  private void Mn_Çýkýþ_Click(object sender, System.EventArgs e)
  {
   this.Close();
  }

  private void Mn_Ayarlar_Click(object sender, System.EventArgs e)
  {
   this.Show();
  }

  private void contextMenu1_Popup(object sender, System.EventArgs e)
  {
   int i;
   //Bütün menüleri sil
   contextMenu1.MenuItems.Clear();
   //Listedeki program isimlerini menü olarak ekle
   for (i = 0 ; i<= listBox1.Items.Count - 1 ; i++)
    contextMenu1.MenuItems.Add(listBox2.Items[i].ToString(), new EventHandler(menu_týklandý));
   contextMenu1.MenuItems.Add("-");//Kesme çizgisi ekle
   contextMenu1.MenuItems.Add(Mn_Ayarlar);//Ayarlar menüsünü ekle
   contextMenu1.MenuItems.Add(Mn_Çýkýþ);//Çýkýþ menüsünü ekle
  }

  private void menu_týklandý(object sender, System.EventArgs e)
  {
   string dosya;
   dosya = listBox1.Items[(sender as MenuItem).Index].ToString();
   try
   {
    System.Diagnostics.Process.Start(dosya);
   }
   catch
   {
    MessageBox.Show(dosya + " dosyasý çalýþtýrýlamadý");
   }
  }

          }
 }
