using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListView_TreeView_Dosya_Klasör_Listesi
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.ListView listView1;
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.TreeView treeView1;
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
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.listView1 = new System.Windows.Forms.ListView();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.treeView1 = new System.Windows.Forms.TreeView();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(328, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(224, 20);
   this.textBox1.TabIndex = 13;
   this.textBox1.Text = "textBox1";
   this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
   // 
   // Label1
   // 
   this.Label1.AutoSize = true;
   this.Label1.Location = new System.Drawing.Point(248, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(76, 13);
   this.Label1.TabIndex = 12;
   this.Label1.Text = "Dosya Filtresi:";
   // 
   // listView1
   // 
   this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
    | System.Windows.Forms.AnchorStyles.Right);
   this.listView1.Location = new System.Drawing.Point(248, 32);
   this.listView1.Name = "listView1";
   this.listView1.Size = new System.Drawing.Size(304, 224);
   this.listView1.TabIndex = 11;
   this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
   this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
   // 
   // pictureBox1
   // 
   this.pictureBox1.Location = new System.Drawing.Point(8, 264);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(544, 200);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
   this.pictureBox1.TabIndex = 10;
   this.pictureBox1.TabStop = false;
   // 
   // treeView1
   // 
   this.treeView1.HideSelection = false;
   this.treeView1.ImageIndex = -1;
   this.treeView1.Location = new System.Drawing.Point(8, 8);
   this.treeView1.Name = "treeView1";
   this.treeView1.SelectedImageIndex = -1;
   this.treeView1.Size = new System.Drawing.Size(232, 248);
   this.treeView1.TabIndex = 9;
   this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(552, 470);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox1,
                                                              this.Label1,
                                                              this.listView1,
                                                              this.pictureBox1,
                                                              this.treeView1});
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
   string[] sürücüler = System.IO.Directory.GetLogicalDrives();
   int i;
   for (i = 0 ; i<= sürücüler.GetUpperBound(0) ; i++)
    treeView1.Nodes.Add(sürücüler[i]);
   //Detay modunda göster
   listView1.View = View.Details;
   //Colonlarý ekle
   listView1.Columns.Add("Dosya Adý", -2, HorizontalAlignment.Left);
   listView1.Columns.Add("Boyut", -2, HorizontalAlignment.Right);
   listView1.Columns.Add("Oluþturma", -2, HorizontalAlignment.Right);
   listView1.Columns.Add("Son deðiþtirme", -2, HorizontalAlignment.Left);
   listView1.Sorting = SortOrder.Ascending; //Artan sýralama

   textBox1.Text="*.*";
  }

  void listele(string yol)
  {
   int i;
   string[] k;
   listView1.Items.Clear();
   string[] dosyalar  = System.IO.Directory.GetFiles(yol,textBox1.Text);
   for (i = 0 ; i<= dosyalar.GetUpperBound(0) ; i++)
   {
    ListViewItem Eleman = new ListViewItem();
    k = dosyalar[i].Split('\\');
    Eleman.Text = k[k.GetUpperBound(0)];
    System.IO.FileInfo FI = new System.IO.FileInfo(dosyalar[i]);
    long boyut;
    boyut = FI.Length;
    if (boyut < 1024)
     Eleman.SubItems.Add(boyut.ToString() + " bayt");
    else 
     if (boyut < 1024 * 1024)
     Eleman.SubItems.Add((boyut / 1024).ToString() + " kb");
    else
     Eleman.SubItems.Add((boyut / (1024 * 1024)).ToString() + " MB");
    Eleman.SubItems.Add(FI.CreationTime.ToShortDateString());
    Eleman.SubItems.Add(FI.LastWriteTime.ToShortDateString());
    //ReadOnly dosyalarý mavi göster
    if ((FI.Attributes & System.IO.FileAttributes.ReadOnly)>0) 
     Eleman.ForeColor = Color.Blue;
    //gizli ve system dosyalarýný kýrmýzý göster
    if ((FI.Attributes & System.IO.FileAttributes.Hidden)>0 || 
     (FI.Attributes & System.IO.FileAttributes.System)>0) 
     Eleman.ForeColor = Color.Red;
    listView1.Items.Add(Eleman);
   }
  }

  private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
  {
   //klasörleri listele
   try
   {
    string[] klasörler = 
     System.IO.Directory.GetDirectories(e.Node.FullPath + "\\");
    int i;
    string[] k;
    //Daha önce eklenmemiþse alt klasörleri ekle
    if (e.Node.GetNodeCount(true) == 0)
     for (i = 0 ; i<= klasörler.GetUpperBound(0); i++)
     {
      k = klasörler[i].Split('\\');
      e.Node.Nodes.Add(k[k.GetUpperBound(0)]);
     }
    //dosyalarý listele
    listele(e.Node.FullPath);
   }
   catch
   {;}
  }

  private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   try
   {
    pictureBox1.Image = Image.FromFile(treeView1.SelectedNode.FullPath + 
     "\\" + listView1.SelectedItems[0].Text);
   }
   catch
   {
    ;//Resim dosyasý deðilse hata vermesin
   }
  }

  private void textBox1_TextChanged(object sender, System.EventArgs e)
  {
   try
   {
    listele(treeView1.SelectedNode.FullPath);
   }
   catch
   {;}
  }

  private void listView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Delete)
   {
    int say, i;
    DialogResult c;
    string dosya;
    say = listView1.SelectedItems.Count;
    if (say > 0) //Seçili dosya varsa
    {
     c = MessageBox.Show("Seçili dosyalarý silmek istediðinizden emin misiniz",
      "Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2); 
     if (c == DialogResult.Yes)
     {
      for (i = 0 ; i<= say - 1 ; i++)
      {
       dosya = treeView1.SelectedNode.FullPath +
        "\\" + listView1.SelectedItems[i].Text;
       try
       {
        System.IO.FileInfo d = new System.IO.FileInfo(dosya);
        d.Delete();//Dosyayý sil
       }
       catch (Exception hata)
       {
        MessageBox.Show(dosya + " silinemedi:\r\n" + hata.Message);
       }
      }
      try //Dosya silindiði için listeyi yeniden oluþtur
      {
       listele(treeView1.SelectedNode.FullPath);
      }
      catch
      {;}
     }
    }
   }
  }
 }
}
