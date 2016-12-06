using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Break
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog1;
  internal System.Windows.Forms.Label label4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.Label5 = new System.Windows.Forms.Label();
   this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
   this.label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // Label5
   // 
   this.Label5.Location = new System.Drawing.Point(8, 72);
   this.Label5.Name = "Label5";
   this.Label5.Size = new System.Drawing.Size(120, 23);
   this.Label5.TabIndex = 21;
   this.Label5.Text = "Çýkmak için SON yazýn";
   // 
   // PrintPreviewDialog1
   // 
   this.PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
   this.PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
   this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
   this.PrintPreviewDialog1.Enabled = true;
   this.PrintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog1.Icon")));
   this.PrintPreviewDialog1.Location = new System.Drawing.Point(176, 232);
   this.PrintPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
   this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
   this.PrintPreviewDialog1.Opacity = 1;
   this.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
   this.PrintPreviewDialog1.Visible = false;
   // 
   // label4
   // 
   this.label4.Location = new System.Drawing.Point(128, 40);
   this.label4.Name = "label4";
   this.label4.TabIndex = 20;
   this.label4.Text = "Label4";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 40);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 19;
   this.Label3.Text = "Kareler Toplamý";
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(128, 16);
   this.label2.Name = "label2";
   this.label2.TabIndex = 18;
   this.label2.Text = "Label2";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 16);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(64, 23);
   this.Label1.TabIndex = 17;
   this.Label1.Text = "Sayý";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(128, 72);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(96, 20);
   this.textBox1.TabIndex = 16;
   this.textBox1.Text = "TextBox1";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(128, 104);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(104, 32);
   this.button1.TabIndex = 15;
   this.button1.Text = "Hesapla";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(240, 150);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label5,
                                                              this.label4,
                                                              this.Label3,
                                                              this.label2,
                                                              this.Label1,
                                                              this.textBox1,
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
   long  i=0, j=0;
   textBox1.Text = "";
   do
   {
    i = i + 1;
    label2.Text = i.ToString();
    j = j + i * i;
    label4.Text = j.ToString();
    if (textBox1.Text.ToUpper() == "SON") 
     break;
    Application.DoEvents();
   }while(i < 10000000);
   MessageBox.Show(i.ToString() + ".adýmda çýkýldý.");
  }
	}
}
