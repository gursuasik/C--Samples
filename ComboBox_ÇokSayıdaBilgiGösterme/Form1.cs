using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ComboBox_ÇokSayýdaBilgiGösterme
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label5;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.Label label4;
  internal System.Windows.Forms.Label label2;
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
   this.Label5 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.SuspendLayout();
   // 
   // Label5
   // 
   this.Label5.AutoSize = true;
   this.Label5.Location = new System.Drawing.Point(9, 11);
   this.Label5.Name = "Label5";
   this.Label5.Size = new System.Drawing.Size(89, 13);
   this.Label5.TabIndex = 11;
   this.Label5.Text = "Bulunduðunuz Ýl:";
   // 
   // label4
   // 
   this.label4.Location = new System.Drawing.Point(122, 152);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(120, 23);
   this.label4.TabIndex = 10;
   this.label4.Text = "label4";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(18, 152);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 9;
   this.Label3.Text = "Plaka Kodu:";
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(122, 128);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(120, 23);
   this.label2.TabIndex = 8;
   this.label2.Text = "label2";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(18, 128);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 7;
   this.Label1.Text = "Seçtiðiniz Ýlin adý:";
   // 
   // comboBox1
   // 
   this.comboBox1.Location = new System.Drawing.Point(98, 8);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(152, 21);
   this.comboBox1.TabIndex = 6;
   this.comboBox1.Text = "comboBox1";
   this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(256, 182);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label5,
                                                              this.label4,
                                                              this.Label3,
                                                              this.label2,
                                                              this.Label1,
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
  class iller
  {
   public string Adý;
   public string Plaka;
   //iki parametreli constructor
   public iller(string ad, string plk)
   {
    Adý = ad;
    Plaka = plk;
   }
   //Parametresiz constructor
   public iller()
   {
    Adý="";
    Plaka="";
   }

   public override string  ToString()
   {
    return Plaka + " " + Adý;
   }
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   iller i = new iller("Hakkari", "30");
   comboBox1.Items.Add(i);
   iller[] il = {new iller("Ankara",   "06"), 
                 new iller("Ýstanbul", "34"), 
                 new iller("Erzurum",  "25"), 
                 new iller("Bursa",    "16"), 
                 new iller("Ýzmir",    "35")};
    comboBox1.Items.AddRange(il);
  }

  private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   if (comboBox1.SelectedIndex < 0)
    return;
   label2.Text = ((iller) comboBox1.SelectedItem).Adý;
   label4.Text = ((iller) comboBox1.SelectedItem).Plaka;
  }
	}
}
