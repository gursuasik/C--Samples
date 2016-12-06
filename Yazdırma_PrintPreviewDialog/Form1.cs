using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Yazdýrma_PrintPreviewDialog
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Button button1;
  private System.Drawing.Printing.PrintDocument printDocument1;
  private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
  private System.Windows.Forms.Button button2;
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
   this.button1 = new System.Windows.Forms.Button();
   this.printDocument1 = new System.Drawing.Printing.PrintDocument();
   this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
   this.button2 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(440, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(96, 23);
   this.button1.TabIndex = 1;
   this.button1.Text = "Yazdýr";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // printDocument1
   // 
   this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
   // 
   // printPreviewDialog1
   // 
   this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
   this.printPreviewDialog1.Enabled = true;
   this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
   this.printPreviewDialog1.Location = new System.Drawing.Point(140, 13);
   this.printPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
   this.printPreviewDialog1.Name = "printPreviewDialog1";
   this.printPreviewDialog1.Opacity = 1;
   this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
   this.printPreviewDialog1.Visible = false;
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(440, 40);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(96, 23);
   this.button2.TabIndex = 2;
   this.button2.Text = "Baský Önzileme";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(544, 266);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1});
   this.Name = "Form1";
   this.Text = "Form1";
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

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   e.Graphics.FillEllipse(new SolidBrush(Color.Red), 10, 10, 400, 60);
   e.Graphics.DrawString("Visual C# .NET", 
    new Font("Tahoma", 24, FontStyle.Regular), 
    new SolidBrush(Color.White), 75, 25);
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
    printDocument1.Print();  
  }

  private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
  {
   e.Graphics.FillEllipse(new SolidBrush(Color.Red), 10, 10, 400, 60);
   e.Graphics.DrawString("Visual C# .NET", 
    new Font("Tahoma", 24, FontStyle.Regular), 
    new SolidBrush(Color.White), 75, 25);
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   printPreviewDialog1.Document = printDocument1;
   printPreviewDialog1.ShowDialog();
  }
	}
}
