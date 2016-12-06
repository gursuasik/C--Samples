using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Image_ResimDöndür
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.PictureBox pictureBox2;
  internal System.Windows.Forms.ComboBox comboBox1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.PictureBox pictureBox1;
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
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
   this.pictureBox2 = new System.Windows.Forms.PictureBox();
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.button1 = new System.Windows.Forms.Button();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.SuspendLayout();
   // 
   // pictureBox2
   // 
   this.pictureBox2.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox2.Image")));
   this.pictureBox2.Location = new System.Drawing.Point(200, 48);
   this.pictureBox2.Name = "pictureBox2";
   this.pictureBox2.Size = new System.Drawing.Size(177, 141);
   this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
   this.pictureBox2.TabIndex = 12;
   this.pictureBox2.TabStop = false;
   // 
   // comboBox1
   // 
   this.comboBox1.Location = new System.Drawing.Point(16, 16);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(176, 21);
   this.comboBox1.TabIndex = 11;
   this.comboBox1.Text = "ComboBox1";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(200, 16);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(173, 24);
   this.button1.TabIndex = 10;
   this.button1.Text = "Çevir/Döndür";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(16, 48);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(177, 141);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
   this.pictureBox1.TabIndex = 9;
   this.pictureBox1.TabStop = false;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(384, 198);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.pictureBox2,
                                                              this.comboBox1,
                                                              this.button1,
                                                              this.pictureBox1});
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
   int i;
   for (i = 0 ; i <= 6 ; i++)
    comboBox1.Items.Add((RotateFlipType)i);
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   Image resim;
   resim = (Image) pictureBox1.Image.Clone();
   resim.RotateFlip((RotateFlipType)comboBox1.SelectedItem);
   pictureBox2.Image = resim;
  }
 }
}
