using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TreeView_Klas�rListesi_2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.ListBox listBox1;
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
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.treeView1 = new System.Windows.Forms.TreeView();
   this.SuspendLayout();
   // 
   // pictureBox1
   // 
   this.pictureBox1.Location = new System.Drawing.Point(8, 264);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(424, 200);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
   this.pictureBox1.TabIndex = 5;
   this.pictureBox1.TabStop = false;
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(248, 8);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(184, 251);
   this.listBox1.TabIndex = 4;
   this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
   // 
   // treeView1
   // 
   this.treeView1.HideSelection = false;
   this.treeView1.ImageIndex = -1;
   this.treeView1.Location = new System.Drawing.Point(8, 8);
   this.treeView1.Name = "treeView1";
   this.treeView1.SelectedImageIndex = -1;
   this.treeView1.Size = new System.Drawing.Size(232, 248);
   this.treeView1.TabIndex = 3;
   this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(440, 470);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.pictureBox1,
                                                              this.listBox1,
                                                              this.treeView1});
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

  void listele(string yol, TreeNode d���m)
  {
   //klas�rleri listele
   try
   {
    string[] klas�rler = 
     System.IO.Directory.GetDirectories(d���m.FullPath + "\\");
    int i;
    string[] k;
    for (i = 0 ; i<= klas�rler.GetUpperBound(0) ; i++)
    {
     k = klas�rler[i].Split('\\');
     d���m.Nodes.Add(k[k.GetUpperBound(0)]);
     Application.DoEvents();
     this.Text = d���m.Nodes[i].FullPath;
     listele(d���m.Nodes[i].FullPath, d���m.Nodes[i]);
    }
   }
   catch
   {;}
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   Show();
   string[] s�r�c�ler  = System.IO.Directory.GetLogicalDrives();
   int i;
   for (i = 0 ; i<= s�r�c�ler.GetUpperBound(0) ; i++)
    treeView1.Nodes.Add(s�r�c�ler[i]);
   for (i = 0 ; i<= s�r�c�ler.GetUpperBound(0) ; i++)
    listele(s�r�c�ler[i], treeView1.Nodes[i]);
  }

  private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
  {
   //dosyalar� listele
   try
   {
    listBox1.Items.Clear();
    string[] dosyalar  = 
     System.IO.Directory.GetFiles(e.Node.FullPath);
    int i;
    string[] k;
    for (i = 0 ; i<= dosyalar.GetUpperBound(0) ; i++)
    {
     k = dosyalar[i].Split('\\');
     listBox1.Items.Add(k[k.GetUpperBound(0)]);
    }
   }
   catch
   {
    ;//s�r�c�de disket yoksa hata vermemesi i�in
   }
  }

  private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   try
   {
    pictureBox1.Image = Image.FromFile(treeView1.SelectedNode.FullPath +
     "\\" + listBox1.SelectedItem);
   }
   catch
   {
    ;//Resim dosyas� de�ilse hata vermesin
   }
  }

  private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
   Environment.Exit(0);
  }
 }
}
