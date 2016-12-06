using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Yazdýrma_EðikYazýlar
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
  internal System.Drawing.Printing.PrintDocument printDocument1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox textBox1;
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
   this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
   this.printDocument1 = new System.Drawing.Printing.PrintDocument();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // printPreviewDialog1
   // 
   this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
   this.printPreviewDialog1.Enabled = true;
   this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
   this.printPreviewDialog1.Location = new System.Drawing.Point(33, 4);
   this.printPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.Name = "PrintPreviewDialog1";
   this.printPreviewDialog1.Opacity = 1;
   this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
   this.printPreviewDialog1.Visible = false;
   // 
   // printDocument1
   // 
   this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(112, 40);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(112, 23);
   this.button2.TabIndex = 3;
   this.button2.Text = "Baský Önizleme";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(16, 40);
   this.button1.Name = "button1";
   this.button1.TabIndex = 2;
   this.button1.Text = "Yazdýr";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(8, 8);
   this.label1.Name = "label1";
   this.label1.TabIndex = 4;
   this.label1.Text = "Yazdýrýlacak Metin";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(112, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(112, 20);
   this.textBox1.TabIndex = 5;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(232, 70);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox1,
                                                              this.label1,
                                                              this.button2,
                                                              this.button1});
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

  private void button1_Click(object sender, System.EventArgs e)
  {
   printDocument1.Print();
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   printPreviewDialog1.Document = printDocument1;
   printPreviewDialog1.ShowDialog();
  }

  private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
  {
   Font fnt = new Font("Tahoma", 12, FontStyle.Bold);
   string metin = textBox1.Text;
   e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
   System.Drawing.Printing.PageSettings p;
   p=printDocument1.DefaultPageSettings;

   //Koordinat sistemini kaðýdýn ortasýna taþý
   e.Graphics.TranslateTransform(p.PaperSize.Width / 2, 
    p.PaperSize.Height / 2);
   //45 derece sola çevir
   e.Graphics.RotateTransform(-45);
   e.Graphics.DrawString(metin, fnt, Brushes.Red, 0, 0);
   //45 derece saða çevir (orjinal konumuna geldi)
   e.Graphics.RotateTransform(45);
   e.Graphics.DrawString(metin, fnt, Brushes.Green, 0, 0);
   //90 derece saða çevir
   e.Graphics.RotateTransform(90);
   e.Graphics.DrawString(metin, fnt, Brushes.Blue, 0, 0);
   //135 derece daha saða çevir (toplam 225 derece)
   e.Graphics.RotateTransform(135);
   e.Graphics.DrawString(metin, fnt, Brushes.Brown, 0, 0);
  }
	}
}
