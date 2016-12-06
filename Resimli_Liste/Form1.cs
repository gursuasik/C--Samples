using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Resimli_Liste
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.ListBox listBox1;
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
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.ýmageList1 = new System.Windows.Forms.ImageList(this.components);
   this.SuspendLayout();
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 8);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(144, 199);
   this.listBox1.TabIndex = 1;
   this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
   // 
   // ýmageList1
   // 
   this.ýmageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
   this.ýmageList1.ImageSize = new System.Drawing.Size(32, 32);
   this.ýmageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ýmageList1.ImageStream")));
   this.ýmageList1.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(160, 214);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
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
   string[] x = {"CD Rom", "Disket", "Monitör", "Fare", "Klavye", 
                 "Bilgisayar"};
   listBox1.DrawMode = DrawMode.OwnerDrawFixed;//Sabit yükseklikli liste
   listBox1.ItemHeight = 32;//Her eleman 32 pixel yüksekliðinde olacak
   listBox1.Items.AddRange(x);//Dizideki elemanlarý listeye ekle
  }

  private void listBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   string s;
   s = listBox1.Items[e.Index].ToString();
   e.DrawBackground();
   e.DrawFocusRectangle();
   ýmageList1.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, e.Index);
   e.Graphics.DrawString(s, new Font("Tahoma", 14, FontStyle.Bold), 
    new SolidBrush(Color.Black), 
    e.Bounds.Left + 35, e.Bounds.Top);
  }
	}
}
