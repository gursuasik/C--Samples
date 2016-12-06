using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Çizim_Brush
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.ComboBox comboBox1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
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
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(16, 8);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(72, 64);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
   this.pictureBox1.TabIndex = 11;
   this.pictureBox1.TabStop = false;
   // 
   // comboBox1
   // 
   this.comboBox1.Location = new System.Drawing.Point(336, 208);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(121, 21);
   this.comboBox1.TabIndex = 10;
   this.comboBox1.Text = "comboBox1";
   this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(256, 208);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(80, 23);
   this.Label1.TabIndex = 9;
   this.Label1.Text = "Boyama Þekli";
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(176, 208);
   this.button3.Name = "button3";
   this.button3.TabIndex = 8;
   this.button3.Text = "Yazý";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(88, 208);
   this.button2.Name = "button2";
   this.button2.TabIndex = 7;
   this.button2.Text = "Elips";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 208);
   this.button1.Name = "button1";
   this.button1.TabIndex = 6;
   this.button1.Text = "Dikdörtgen";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(464, 238);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.comboBox1,
                                                              this.Label1,
                                                              this.button3,
                                                              this.button2,
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

  Brush b;
  private void Form1_Load(object sender, System.EventArgs e)
  {
   comboBox1.Items.Add("SolidBrush");
   comboBox1.Items.Add("HatchBrush");
   comboBox1.Items.Add("LinearGradientBrush");
   comboBox1.Items.Add("PathGradientBrush");
   comboBox1.Items.Add("TextureBrush");
   comboBox1.SelectedIndex = 0;
   pictureBox1.Visible = false;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   Graphics g;
   g = this.CreateGraphics();
   Random r = new Random();
   g.FillRectangle(b, r.Next(200), r.Next(200), r.Next(200), r.Next(200));
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   Graphics g;
   g = this.CreateGraphics();
   Random r = new Random();
   g.FillEllipse(b, r.Next(200), r.Next(200), r.Next(200), r.Next(200));  
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   Graphics g;
   g = this.CreateGraphics();
   Random r = new Random();
   g.DrawString("Visual C# .NET", new Font("Tahoma", 30, 
    FontStyle.Bold), b,
    r.Next(200), r.Next(200));
  }

  private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   Color renk, renk2;
   //Rasgele renk oluþtur
   Random r = new Random();
   renk = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
   renk2 = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
   switch(comboBox1.SelectedIndex)
   {
    case 0 : //SolidBrush
     b = new SolidBrush(renk);
     break;
    case 1 : //HatchBrush 
     b = new System.Drawing.Drawing2D.HatchBrush((System.Drawing.Drawing2D.HatchStyle)r.Next(50), renk);
     break;
    case 2 : //LinearGradientBrush
     b = new System.Drawing.Drawing2D.LinearGradientBrush(new Point(r.Next(200), 
      r.Next(200)), 
      new Point(r.Next(200), 
      r.Next(200)), 
      renk, renk2);
     break;
    case 3 : //PathGradientBrush
     Point[] p= new Point[2];
     p[0] = new Point(r.Next(200), r.Next(200));
     p[1] = new Point(r.Next(200), r.Next(200));
     b = new System.Drawing.Drawing2D.PathGradientBrush(p);
     ((System.Drawing.Drawing2D.PathGradientBrush)b).CenterColor = renk;
      ((System.Drawing.Drawing2D.PathGradientBrush)b).CenterPoint = 
      new PointF(r.Next(200), r.Next(200));
     break;
    case 4 : //TextureBrush
     b = new TextureBrush(pictureBox1.Image);
     break;
   }
  }
 }
}
