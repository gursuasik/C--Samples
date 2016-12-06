using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListBox_NesneEkleme
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button3;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.ListBox listBox1;
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
   this.Label1 = new System.Windows.Forms.Label();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.SuspendLayout();
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(208, 208);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(96, 32);
   this.button3.TabIndex = 9;
   this.button3.Text = "Seçili Noktayý Sil";
   this.button3.Click += new System.EventHandler(this.button3_Click);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(112, 208);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(88, 32);
   this.button2.TabIndex = 8;
   this.button2.Text = "Aç";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(16, 208);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(88, 32);
   this.button1.TabIndex = 7;
   this.button1.Text = "Kaydet";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(200, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(100, 32);
   this.Label1.TabIndex = 6;
   this.Label1.Text = "Fare ile Týklanan Koordinatlar";
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(200, 40);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(104, 160);
   this.listBox1.TabIndex = 5;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(312, 246);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button3,
                                                              this.button2,
                                                              this.button1,
                                                              this.Label1,
                                                              this.listBox1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
   this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
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

  private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   Point p=new Point();
   p.X = e.X;
   p.Y = e.Y;
   listBox1.Items.Add(p);
   Point onceki;
   Graphics g;
   if (listBox1.Items.Count > 1)
   {
    onceki = (Point) listBox1.Items[listBox1.Items.Count - 2];
    g = this.CreateGraphics();
    g.DrawLine(new Pen(Color.Red), onceki.X, onceki.Y, p.X, p.Y);
    g.Dispose();
   }
  }

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   int i;
   for (i = 1;i<=listBox1.Items.Count - 1;i++)
   {
    Point p, onceki;
    p = (Point) listBox1.Items[i];
    onceki =(Point)  listBox1.Items[i - 1];
    e.Graphics.DrawLine(new Pen(Color.Red), onceki.X, onceki.Y, p.X, p.Y);
   }
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   int i;
   //resim.dat dosyasýný oluþtur
   System.IO.TextWriter dosya=System.IO.File.CreateText("resim.dat");
   for (i = 0;i<=listBox1.Items.Count - 1;i++)
   {
    dosya.WriteLine(((Point)listBox1.Items[i]).X.ToString()); //X koordinatýný kaydet
    dosya.WriteLine(((Point)listBox1.Items[i]).Y.ToString()); //y koordinatýný kaydet
   }
   dosya.Close();//Dosyayý kapat
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   listBox1.Items.Clear();//listeyi sil
   Point p=new Point();
   try
   {
    System.IO.TextReader dosya = System.IO.File.OpenText("resim.dat");
    string satýr;
    while((satýr = dosya.ReadLine())!= null)
    {
     p.X=int.Parse(satýr);
     satýr = dosya.ReadLine();
     p.Y=int.Parse(satýr);
     listBox1.Items.Add(p);//Listeye ekle
    }
    dosya.Close();
   }
   catch
   {
    ;
   }

   this.Invalidate();//Paint olayýný çaðýrýp çizimi yaptýr
  }

  private void button3_Click(object sender, System.EventArgs e)
  {
   listBox1.Items.Remove(listBox1.SelectedItem);
   this.Invalidate();//Paint olayýný çaðýrýp çizimi yaptýr
  }
	}
}
