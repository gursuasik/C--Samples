using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Resimli_ComboBox
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.ComboBox comboBox1;
  internal System.Windows.Forms.ImageList ýmageList1;
  private System.ComponentModel.IContainer components;

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
   this.components = new System.ComponentModel.Container();
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.ýmageList1 = new System.Windows.Forms.ImageList(this.components);
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(120, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(160, 20);
   this.textBox1.TabIndex = 7;
   this.textBox1.Text = "textBox1";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 16);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 6;
   this.Label2.Text = "Adýnýz:";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 48);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(112, 23);
   this.Label1.TabIndex = 5;
   this.Label1.Text = "Bulunduðunuz Ülke:";
   // 
   // ýmageList1
   // 
   this.ýmageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
   this.ýmageList1.ImageSize = new System.Drawing.Size(32, 32);
   this.ýmageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ýmageList1.ImageStream")));
   this.ýmageList1.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // comboBox1
   // 
   this.comboBox1.IntegralHeight = false;
   this.comboBox1.Location = new System.Drawing.Point(120, 48);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(160, 21);
   this.comboBox1.TabIndex = 4;
   this.comboBox1.Text = "comboBox1";
   this.comboBox1.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.comboBox1_MeasureItem);
   this.comboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 86);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label2,
                                                              this.Label1,
                                                              this.comboBox1,
                                                              this.textBox1});
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
   string[] x = {"Türkiye", "Danimarka", "Almanya", "Avusturya", "Japonya", 
                 "Ýtalya"};
    //Deðiþken yükseklikli liste
    comboBox1.DrawMode = DrawMode.OwnerDrawVariable ;
   comboBox1.Items.AddRange(x);//Dizideki elemanlarý listeye ekle
  }

  private void comboBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   string s;
   s = comboBox1.Items[e.Index].ToString();
   e.DrawBackground();
   e.DrawFocusRectangle();
   //Bayrak resmini çiz
   ýmageList1.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, e.Index);
   //Yanýna ülke adýný yaz
   e.Graphics.DrawString(s, new Font("Tahoma", 10, FontStyle.Bold), 
    new SolidBrush(Color.Black), 
    e.Bounds.Left + 35, e.Bounds.Top + 8);
  }

  private void comboBox1_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
  {
   e.ItemHeight = 32;
  }
	}
}
