using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TabControl_Resim
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TabControl tabControl1;
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
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.button1 = new System.Windows.Forms.Button();
   this.tabControl1 = new System.Windows.Forms.TabControl();
   this.SuspendLayout();
   // 
   // pictureBox1
   // 
   this.pictureBox1.Location = new System.Drawing.Point(8, 40);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(408, 200);
   this.pictureBox1.TabIndex = 5;
   this.pictureBox1.TabStop = false;
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(144, 248);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(120, 24);
   this.button1.TabIndex = 4;
   this.button1.Text = "Resimleri Seç";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // tabControl1
   // 
   this.tabControl1.Location = new System.Drawing.Point(8, 8);
   this.tabControl1.Name = "tabControl1";
   this.tabControl1.SelectedIndex = 0;
   this.tabControl1.Size = new System.Drawing.Size(408, 24);
   this.tabControl1.TabIndex = 3;
   this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(424, 278);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.tabControl1,
                                                              this.pictureBox1});
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
   //Tablar tek satýrda olsun
   tabControl1.Multiline = false;
   //Resimler sýðdýrýlsýn
   pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   //Birden fazla dosya seçilebilsin 
   openFileDialog1.Multiselect = true;
   openFileDialog1.Filter = "Resim Dosyalarý|*.bmp;*.jpg;*.gif;*.wmf";
   if(openFileDialog1.ShowDialog()==DialogResult.OK)
   {
    int i;
    //seçilen bütün dosyalar için
    for (i = 0;i<= openFileDialog1.FileNames.GetUpperBound(0);i++)
     //Baþlýðýnda dosya adý yazan yeni Tab ekle
     tabControl1.TabPages.Add(new TabPage(openFileDialog1.FileNames[i]));
    //Resimlerden birini göstermesi için SelectedIndexChanged olayýný çaðýr
    tabControl1_SelectedIndexChanged(sender, e);
   }
  }

  private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   //Tab deðiþtiðinde baþlýðýnda yazan dosyayý yükle
   try
   {
    pictureBox1.Image = Image.FromFile(tabControl1.SelectedTab.Text);
   }
   catch
   {;}
  }
	}
}
