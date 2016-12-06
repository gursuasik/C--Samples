using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListeKutusu_Fontlar
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.TextBox textBox1;
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
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(200, 8);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(288, 216);
   this.textBox1.TabIndex = 3;
   this.textBox1.Text = "textBox1";
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 8);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(184, 212);
   this.listBox1.TabIndex = 2;
   this.listBox1.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBox1_MeasureItem);
   this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
   this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(496, 230);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox1,
                                                              this.listBox1});
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
   listBox1.DrawMode = DrawMode.OwnerDrawVariable ;
   FontFamily[] fontlar  = FontFamily.Families;
   int i;
   //fontlarý listeye aktar
   for (i = 0;i<=fontlar.GetUpperBound(0);i++)
    listBox1.Items.Add(fontlar[i].Name);
  }

  private void listBox1_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
  {
   Font fnt;
   string ad;
   ad = listBox1.Items[e.Index].ToString();//Listede yazan font adý
   try
   {
    fnt = new Font(ad, 12, FontStyle.Regular); //Listedeki fontu oluþtur
    e.ItemHeight = fnt.Height; //Yüksekliðini belirle
   }
   catch
   {;}
  }

  private void listBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   e.DrawBackground();//Elemanýn arka planýný çiz
   e.DrawFocusRectangle();//Elamanýn seçme çerçevesini çiz
   string ad;
   ad = listBox1.Items[e.Index].ToString();//Listede yazan font adý
   try
   {
    //Font adýný o fontla yaz 
    e.Graphics.DrawString(ad, new Font(ad, 12, FontStyle.Regular), 
     new SolidBrush(Color.Black), 
     e.Bounds.Left, e.Bounds.Top);
   }
   catch
   {; }
  }

  private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   //Listeden seçilen fontu Text kutusunun fontu yap
   try
   {
    textBox1.Font = new Font(listBox1.SelectedItem.ToString(), 14, 
     FontStyle.Regular);
   }
   catch
   {
    MessageBox.Show("Bu font görüntülenemedi");
   }
  }
	}
}
