using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MDIForm_Ornek
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.Label label4;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.MenuItem Mn_Sil;
  internal System.Windows.Forms.MenuItem MenuItem1;
  internal System.Windows.Forms.MenuItem MenuItem2;
  internal System.Windows.Forms.MenuItem Mn_Veri;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.MainMenu mainMenu1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
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
				if(components != null)
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
   this.label4 = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.Mn_Sil = new System.Windows.Forms.MenuItem();
   this.mainMenu1 = new System.Windows.Forms.MainMenu();
   this.MenuItem1 = new System.Windows.Forms.MenuItem();
   this.MenuItem2 = new System.Windows.Forms.MenuItem();
   this.Mn_Veri = new System.Windows.Forms.MenuItem();
   this.Label1 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(72, 80);
   this.button1.Name = "button1";
   this.button1.TabIndex = 20;
   this.button1.Text = "Çarp";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label4
   // 
   this.label4.Location = new System.Drawing.Point(80, 56);
   this.label4.Name = "label4";
   this.label4.TabIndex = 19;
   this.label4.Text = "label4";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(80, 32);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 18;
   this.textBox2.Text = "textBox2";
   // 
   // Mn_Sil
   // 
   this.Mn_Sil.Index = 0;
   this.Mn_Sil.Text = "Sil";
   this.Mn_Sil.Click += new System.EventHandler(this.Mn_Sil_Click);
   // 
   // mainMenu1
   // 
   this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.MenuItem1,
                                                                          this.Mn_Veri});
   // 
   // MenuItem1
   // 
   this.MenuItem1.Index = 0;
   this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                          this.MenuItem2});
   this.MenuItem1.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
   this.MenuItem1.Text = "Dosya";
   // 
   // MenuItem2
   // 
   this.MenuItem2.Index = 0;
   this.MenuItem2.MergeOrder = 1;
   this.MenuItem2.Text = "Kaydet";
   // 
   // Mn_Veri
   // 
   this.Mn_Veri.Index = 1;
   this.Mn_Veri.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                        this.Mn_Sil});
   this.Mn_Veri.Text = "Veri";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(60, 23);
   this.Label1.TabIndex = 14;
   this.Label1.Text = "1. Sayý";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 56);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 16;
   this.Label3.Text = "Sonuç:";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 15;
   this.Label2.Text = "2. Sayý";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(80, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 17;
   this.textBox1.Text = "textBox1";
   // 
   // Form2
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(192, 105);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label4,
                                                              this.textBox2,
                                                              this.Label1,
                                                              this.Label3,
                                                              this.Label2,
                                                              this.textBox1,
                                                              this.button1});
   this.Menu = this.mainMenu1;
   this.Name = "Form2";
   this.Text = "Form2";
   this.ResumeLayout(false);

  }
		#endregion

  private void button1_Click(object sender, System.EventArgs e)
  {
   try
   {
    label4.Text = (float.Parse(textBox1.Text) * float.Parse(textBox2.Text)).ToString();
   }
   catch
   {
    label4.Text="Sayýlar hatalý";
   }
  }

  private void Mn_Sil_Click(object sender, System.EventArgs e)
  {
   textBox1.Text = "";
   textBox2.Text = "";
   label4.Text = "";
  }
	}
}
