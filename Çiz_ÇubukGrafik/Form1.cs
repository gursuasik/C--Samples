using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Çiz_ÇubukGrafik
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label2;
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
   this.button1 = new System.Windows.Forms.Button();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(224, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(120, 46);
   this.button1.TabIndex = 14;
   this.button1.Text = "Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(120, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 13;
   this.textBox2.Text = "textBox2";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(120, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 12;
   this.textBox1.Text = "textBox1";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 11;
   this.Label2.Text = "Aldýðý Oy";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 10;
   this.Label1.Text = "Parti Adý";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(352, 398);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.textBox2,
                                                              this.textBox1,
                                                              this.Label2,
                                                              this.Label1});
   this.Name = "Form1";
   this.Text = "Form1";
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

  string[] partiler = new string[20];
  int[] oylar = new int[20];
  int sýra_no , toplam_oy;

  private void button1_Click(object sender, System.EventArgs e)
  {
   if (sýra_no == 20)
   {
    MessageBox.Show("En çok 20 parti olabilir");
    return;
   }
   try
   {
    oylar[sýra_no] = int.Parse(textBox2.Text);
   }
   catch
   {
    MessageBox.Show("Oy sayýsýnda hata var");
    return;
   }
   partiler[sýra_no] = textBox1.Text;
   toplam_oy += oylar[sýra_no];
   sýra_no+= 1;
   Graphics g;
   g = this.CreateGraphics();
   g.Clear(this.BackColor);
   Random r = new Random();
   int i, boy;
   Color renk;
   System.Drawing.Drawing2D.HatchBrush fýrça;
   for (i = 0 ; i<= sýra_no - 1 ; i++)
   {
    boy = 100 * oylar[i] / toplam_oy;
    renk = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
    fýrça = new System.Drawing.Drawing2D.HatchBrush(
     (System.Drawing.Drawing2D.HatchStyle)r.Next(50), renk);
    //Pasta dilimini çiz  
    g.FillRectangle(fýrça, 0, 80 + i * 20, boy, 18);
    //Yanýna % oranýný yaz
    g.DrawString("% " + boy.ToString(), 
     new Font("Tahoma", 8, FontStyle.Regular), 
     new SolidBrush(Color.Red), 
     boy + 5, 80 + i * 20);
    //O rengin açýklamasýný belirtmesi için küçük bir dikdörtgen çiz
    g.FillRectangle(fýrça, 210, 80 + i * 20, 18, 18);
    //Yanýna parti adýný ve aldýðý oyu yaz
    g.DrawString(partiler[i] + "=" + oylar[i], 
     new Font("Tahoma", 8, FontStyle.Regular), 
     new SolidBrush(Color.Red), 
     230, 80 + i * 20);
   }
  }
	}
}
