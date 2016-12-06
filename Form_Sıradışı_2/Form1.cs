using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Form_Sýradýþý_2
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
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
   this.button3 = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // button3
   // 
   this.button3.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button3.BackColor = System.Drawing.Color.Blue;
   this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.button3.ForeColor = System.Drawing.Color.White;
   this.button3.Location = new System.Drawing.Point(728, 8);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(24, 23);
   this.button3.TabIndex = 5;
   this.button3.Text = "x";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button2.BackColor = System.Drawing.Color.Blue;
   this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.button2.ForeColor = System.Drawing.Color.White;
   this.button2.Location = new System.Drawing.Point(704, 8);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(24, 23);
   this.button2.TabIndex = 4;
   this.button2.Text = "-";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
   this.button1.BackColor = System.Drawing.Color.Blue;
   this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
   this.button1.ForeColor = System.Drawing.Color.White;
   this.button1.Location = new System.Drawing.Point(680, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(24, 23);
   this.button1.TabIndex = 3;
   this.button1.Text = "_";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(760, 438);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button3,
                                                              this.button2,
                                                              this.button1});
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
   this.Name = "Form1";
   this.Text = "Form1";
   this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
   this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
   this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
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

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   System.Drawing.Drawing2D.GraphicsPath Grafik_Þekli;
   Grafik_Þekli = new System.Drawing.Drawing2D.GraphicsPath();
   //0,0 noktasýndan formun geniþiði kadar 90 pixel yüksekliðinde
   //bir dikdörtgen çiz
   Grafik_Þekli.AddRectangle(new Rectangle(0, 0, this.ClientSize.Width, 90));
   //95 punto büyüklükte Tahoma fontuyla kalýn olarak Sýradýþý Form Yaz
   Grafik_Þekli.AddString("Sýra Dýþý Form", 
    new FontFamily("Tahoma"),
    (int) FontStyle.Bold, 
    (float) 95,
    new PointF(0, 100), 
    new StringFormat(StringFormat.GenericDefault));
   //Formun altýna, formun geniþiði kadar 90 pixel yüksekliðinde
   //bir dikdörtgen daha çiz
   Grafik_Þekli.AddRectangle(new Rectangle(0, this.ClientSize.Height - 90, 
    this.ClientSize.Width, 90));
   //Bu þekli forma uygula
   this.Region = new Region(Grafik_Þekli);
  }

  Point týklanan_nokta;
  private void Form1_MouseDown(object sender, 
   System.Windows.Forms.MouseEventArgs e)
  {
   //Farenin týklandýðý noktadaki koordinatlarýný al
   týklanan_nokta = new Point(e.X, e.Y);
  }

  private void Form1_MouseMove(object sender, 
   System.Windows.Forms.MouseEventArgs e)
  {
   //Sol tuþ basýlý olarak hareket ettiriliyorsa formu taþý
   if (e.Button == MouseButtons.Left)
   {
    Point Koordinatlar;
    Koordinatlar = Control.MousePosition;
    Koordinatlar.Offset(-týklanan_nokta.X, -týklanan_nokta.Y);
    this.Location = Koordinatlar;
   }
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   this.WindowState = FormWindowState.Minimized;
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   if (this.WindowState == FormWindowState.Maximized)
    this.WindowState = FormWindowState.Normal;
   else
    this.WindowState = FormWindowState.Maximized;
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   this.Close();
  }

 }
}
