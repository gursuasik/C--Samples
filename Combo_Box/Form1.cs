using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Combo_Box
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.ComboBox comboBox2;
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
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.comboBox2 = new System.Windows.Forms.ComboBox();
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 40);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(224, 120);
   this.textBox1.TabIndex = 5;
   this.textBox1.Text = "textBox1";
   // 
   // comboBox2
   // 
   this.comboBox2.Location = new System.Drawing.Point(136, 8);
   this.comboBox2.Name = "comboBox2";
   this.comboBox2.Size = new System.Drawing.Size(96, 21);
   this.comboBox2.TabIndex = 4;
   this.comboBox2.Text = "ComboBox2";
   // 
   // comboBox1
   // 
   this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.comboBox1.Location = new System.Drawing.Point(8, 8);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(121, 21);
   this.comboBox1.TabIndex = 3;
   this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(240, 166);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.textBox1,
                                                              this.comboBox2,
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
   //Mevcut fontlarý diziye al
   FontFamily[] fontlar = FontFamily.Families;
   int i;
   //fontlarý listeye aktar
   for (i = 0;i<=fontlar.GetUpperBound(0);i++)
    comboBox1.Items.Add(fontlar[i].Name);
   comboBox1.SelectedIndex = 0 ;//Ýlk elemaný seç
   //8-100 arasý rakamlarý Combo2 içine ekle
   for (i = 8;i<=100;i++)
    comboBox2.Items.Add(i);
   comboBox2.SelectedIndex = 0  ;//Ýlk elemaný seç

   //Olaylarý birleþtir. 
   comboBox2.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
   comboBox2.TextChanged += new EventHandler(comboBox1_SelectedIndexChanged);
  }

  private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   //Listeden seçilen fontu Text kutusunun fontu yap
   try
   {
    textBox1.Font = new Font(comboBox1.Text.ToString(), 
     float.Parse(comboBox2.Text),
     FontStyle.Regular);
   }
   catch
   {;}
  }
 }
}
