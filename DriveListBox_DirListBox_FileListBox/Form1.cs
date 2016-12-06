using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DriveListBox_DirListBox_FileListBox
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  private Microsoft.VisualBasic.Compatibility.VB6.DirListBox dirListBox1;
  private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox driveListBox1;
  private Microsoft.VisualBasic.Compatibility.VB6.FileListBox fileListBox1;
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.ComboBox comboBox1;
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
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.dirListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
   this.driveListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
   this.fileListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.FileListBox();
   this.SuspendLayout();
   // 
   // pictureBox1
   // 
   this.pictureBox1.Location = new System.Drawing.Point(384, 8);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(288, 248);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
   this.pictureBox1.TabIndex = 6;
   this.pictureBox1.TabStop = false;
   // 
   // comboBox1
   // 
   this.comboBox1.Location = new System.Drawing.Point(192, 8);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(184, 21);
   this.comboBox1.TabIndex = 5;
   this.comboBox1.Text = "comboBox1";
   this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
   // 
   // dirListBox1
   // 
   this.dirListBox1.IntegralHeight = false;
   this.dirListBox1.Location = new System.Drawing.Point(8, 32);
   this.dirListBox1.Name = "dirListBox1";
   this.dirListBox1.Size = new System.Drawing.Size(176, 224);
   this.dirListBox1.TabIndex = 7;
   this.dirListBox1.SelectedIndexChanged += new System.EventHandler(this.dirListBox1_SelectedIndexChanged);
   // 
   // driveListBox1
   // 
   this.driveListBox1.Location = new System.Drawing.Point(8, 8);
   this.driveListBox1.Name = "driveListBox1";
   this.driveListBox1.Size = new System.Drawing.Size(176, 21);
   this.driveListBox1.TabIndex = 8;
   this.driveListBox1.SelectedIndexChanged += new System.EventHandler(this.driveListBox1_SelectedIndexChanged);
   // 
   // fileListBox1
   // 
   this.fileListBox1.Location = new System.Drawing.Point(192, 32);
   this.fileListBox1.Name = "fileListBox1";
   this.fileListBox1.Pattern = "*.*";
   this.fileListBox1.Size = new System.Drawing.Size(184, 225);
   this.fileListBox1.TabIndex = 9;
   this.fileListBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fileListBox1_KeyDown);
   this.fileListBox1.SelectedIndexChanged += new System.EventHandler(this.fileListBox1_SelectedIndexChanged);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(680, 262);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.fileListBox1,
                                                              this.driveListBox1,
                                                              this.dirListBox1,
                                                              this.pictureBox1,
                                                              this.comboBox1});
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

  private void driveListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   try
   {
    dirListBox1.Path = driveListBox1.Drive;
   }
   catch (Exception hata)
   {
    MessageBox.Show(driveListBox1.Drive + " sürücüsüne eriþilemedi\r\n" +
     hata.Message);
   }
  }

  private void dirListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   fileListBox1.Path = dirListBox1.Path;
   try//aktif klasörü deðiþ
   {
    System.IO.Directory.SetCurrentDirectory(dirListBox1.Path);
   }
   catch (Exception hata)
   {
    MessageBox.Show("Klasör aktif yapýlamadý.\r\n" + hata.Message);
   }
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   comboBox1.Items.Add("*.bmp;*.gif;*.jpg;*.png;*.wmf;*.ico");
   comboBox1.Items.Add("*.*");
   comboBox1.SelectedIndex = 0;
  }

  private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   fileListBox1.Pattern = comboBox1.Text;
  }

  private void fileListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   try
   {
    pictureBox1.Image = Image.FromFile(fileListBox1.FileName);
   }
   catch (Exception hata)
   {
    MessageBox.Show(fileListBox1.FileName +
     " dosyasý geçerli bir resim dosyasý deðil\r\n" +
     hata.Message);
   }
  }

  private void fileListBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
  {
   //Delete tuþuna basýlýrsa
   if (e.KeyCode == Keys.Delete)
    try
    {
     //resim dosyasý açýksa silinemez. 
     pictureBox1.Image = null;
     Application.DoEvents();
     //dosyayý sil
     System.IO.FileInfo dosya = new System.IO.FileInfo(fileListBox1.FileName);
     dosya.Delete();
     //fileListBox kontrolünü güncelle
     fileListBox1.Refresh();
    }
    catch (Exception hata )
    {
     MessageBox.Show(fileListBox1.FileName + " dosyasý silinemiyor.\r\n" +
      hata.Message);
    }
  }
 }
}