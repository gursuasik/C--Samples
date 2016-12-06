using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Renkli_ComboBox
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
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
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.SuspendLayout();
   // 
   // comboBox1
   // 
   this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
   this.comboBox1.Location = new System.Drawing.Point(24, 8);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(128, 21);
   this.comboBox1.TabIndex = 1;
   this.comboBox1.Text = "comboBox1";
   this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
   this.comboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
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

  private void Form1_Load(object sender, System.EventArgs e)
  {
   string[] renkler = {"Kýrmýzý", "Yeþil", "Sarý", "Siyah", "Mavi", 
                       "Kahverengi"};
    comboBox1.Items.AddRange(renkler);
  }

  private void comboBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
  {
   Color renk=Color.Black;
   string eleman;
   eleman = comboBox1.Items[e.Index].ToString();
   switch(eleman)
   {
    case "Kýrmýzý" : renk = Color.Red;break;
    case "Yeþil" : renk = Color.Green;break;
    case "Sarý" : renk = Color.Yellow;break;
    case "Siyah" : renk = Color.Black;break;
    case "Mavi" : renk = Color.Blue;break;
    case "Kahverengi" : renk = Color.Brown;break;
   }
   if (e.State == DrawItemState.Selected) //seçili ise turquaz renkle çiz
    e.Graphics.FillRectangle(new SolidBrush(Color.Turquoise), 
     e.Bounds.Left, e.Bounds.Top, 
     e.Bounds.Width, e.Bounds.Height);
   else //Seçili deðilse kendi rengiyle çiz
    e.Graphics.FillRectangle(new SolidBrush(renk), 
     e.Bounds.Left, e.Bounds.Top, 
     e.Bounds.Width, e.Bounds.Height);
   //Rengin adýný beyaz olarak yaz
   e.Graphics.DrawString(eleman, e.Font, new SolidBrush(Color.White), 
    e.Bounds.Left, e.Bounds.Top);
   //Seçme çerçevesini çiz
   e.DrawFocusRectangle();
  }

  private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   Color renk=Color.Black;
   string eleman;
   eleman = comboBox1.SelectedItem.ToString();
   switch(eleman)
   {
    case "Kýrmýzý" : renk = Color.Red;break;
    case "Yeþil" : renk = Color.Green;break;
    case "Sarý" : renk = Color.Yellow;break;
    case "Siyah" : renk = Color.Black;break;
    case "Mavi" : renk = Color.Blue;break;
    case "Kahverengi" : renk = Color.Brown;break;
   }
   this.BackColor = renk;
   comboBox1.BackColor = renk;
   comboBox1.ForeColor = Color.White;
  }
	}
}
