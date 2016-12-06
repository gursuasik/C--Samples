using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
namespace FileSystemWatcher_DiskS�r�c�leriIzle
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.CheckedListBox checkedListBox1;
  internal System.Windows.Forms.ListView listView1;
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
  /// Clean up any resenders being used.
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
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
   this.listView1 = new System.Windows.Forms.ListView();
   this.SuspendLayout();
   // 
   // Label2
   // 
   this.Label2.AutoSize = true;
   this.Label2.Location = new System.Drawing.Point(180, 7);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(201, 13);
   this.Label2.TabIndex = 7;
   this.Label2.Text = "S�r�c�lerde meydana gelen de�i�imler";
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(12, 7);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(104, 13);
   this.Label1.TabIndex = 6;
   this.Label1.Text = "�zlenecek S�r�c�ler";
   // 
   // checkedListBox1
   // 
   this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
    | System.Windows.Forms.AnchorStyles.Left);
   this.checkedListBox1.Location = new System.Drawing.Point(12, 31);
   this.checkedListBox1.Name = "checkedListBox1";
   this.checkedListBox1.Size = new System.Drawing.Size(160, 229);
   this.checkedListBox1.TabIndex = 5;
   this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
   // 
   // listView1
   // 
   this.listView1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
    | System.Windows.Forms.AnchorStyles.Left) 
    | System.Windows.Forms.AnchorStyles.Right);
   this.listView1.Location = new System.Drawing.Point(180, 31);
   this.listView1.Name = "listView1";
   this.listView1.Size = new System.Drawing.Size(432, 232);
   this.listView1.TabIndex = 4;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(624, 270);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label2,
                                                              this.Label1,
                                                              this.checkedListBox1,
                                                              this.listView1});
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

  FileSystemWatcher[]izleyiciler;//Dinamik dizi
  private void Form1_Load(object sender, System.EventArgs e)
  {
   string[] s�r�c�ler;
   //Bilgisayardaki s�r�c� listesini al
   s�r�c�ler = Directory.GetLogicalDrives();
   //S�r�c� listesini checkedListBox1 i�ine ekle
   checkedListBox1.Items.AddRange(s�r�c�ler);

   // izleyiciler dizisini, s�r�c� say�s� kadar yeniden boyutland�r
   izleyiciler=new FileSystemWatcher[s�r�c�ler.Length];
   int i;
   //Her s�r�c� i�in izleyiciler dizisinden bir eleman� ayarla
   for (i = 0 ; i<= izleyiciler.Length - 1 ; i++)
   {
    izleyiciler[i] = new FileSystemWatcher();
    try
    {
     izleyiciler[i].Path = s�r�c�ler[i];
    }
    catch
    {;}
    izleyiciler[i].Filter = "*.*";
    izleyiciler[i].NotifyFilter = NotifyFilters.Attributes |
     NotifyFilters.CreationTime |
     NotifyFilters.DirectoryName |
     NotifyFilters.FileName |
     NotifyFilters.LastAccess |
     NotifyFilters.LastWrite |
     NotifyFilters.Security |
     NotifyFilters.Size;
    izleyiciler[i].IncludeSubdirectories = true;
    //Olaylar� ekle
    izleyiciler[i].Changed += new FileSystemEventHandler(de�i�ti);
    izleyiciler[i].Created += new FileSystemEventHandler(yeni);
    izleyiciler[i].Deleted += new FileSystemEventHandler(silindi);
    izleyiciler[i].Renamed += new RenamedEventHandler(ad_de�i�ti);
   }
   //listView kolonlar�n� belirle
   listView1.Columns.Add("S�r�c�", -2, HorizontalAlignment.Left);
   listView1.Columns.Add("��lem T�r�", -2, HorizontalAlignment.Left);
   listView1.Columns.Add("Klas�r/Dosya Ad�", -2, HorizontalAlignment.Left);
   listView1.Columns.Add("Detay", -2, HorizontalAlignment.Left);
   listView1.View = View.Details;
   listView1.Sorting = SortOrder.Ascending;
   listView1.Sorting = SortOrder.None;
  }                                                                                                                                                                                                                                                                                                                                                                                                                      
 
  private void checkedListBox1_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
  {
   if (e.NewValue == CheckState.Checked)
    //i�aretlenirse izlemeyi ba�lat
    izleyiciler[e.Index].EnableRaisingEvents = true;
   else
    //i�aret kald�r�l�rsa izlemeyi durdur
    izleyiciler[e.Index].EnableRaisingEvents = false;
  }
  
  //A�a��daki olaylar�n prosed�r ba�l�klar�n� da elle yaz�n
  private void de�i�ti(object sender, 
   System.IO.FileSystemEventArgs e)
  {

   ListViewItem eleman;
   eleman = listView1.Items.Add((sender as FileSystemWatcher).Path);
   eleman.SubItems.Add("De�i�iklik");
   eleman.SubItems.Add(e.FullPath);
   eleman.SubItems.Add(e.ChangeType.ToString());
  }

  private void yeni(object sender, System.IO.FileSystemEventArgs e)
  {
   ListViewItem eleman;
   eleman = listView1.Items.Add((sender as FileSystemWatcher).Path);
   eleman.SubItems.Add("Yeni");
   eleman.SubItems.Add(e.FullPath);
   eleman.SubItems.Add(e.ChangeType.ToString());
  }

  private void silindi(object sender, System.IO.FileSystemEventArgs e)
  {
   ListViewItem eleman;
   eleman = listView1.Items.Add((sender as FileSystemWatcher).Path);
   eleman.SubItems.Add("Silme");
   eleman.SubItems.Add(e.FullPath);
   eleman.SubItems.Add(e.ChangeType.ToString());
  }

  private void ad_de�i�ti(object sender, System.IO.RenamedEventArgs e)
  {
    
   ListViewItem eleman;
   eleman = listView1.Items.Add((sender as FileSystemWatcher).Path);
   eleman.SubItems.Add("Ad De�i�ikli�i");
   eleman.SubItems.Add(e.FullPath);
   eleman.SubItems.Add(e.OldFullPath);
  }
 }
}
