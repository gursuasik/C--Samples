using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace YazýyaÇevir
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.Label label1;
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
   this.button1 = new System.Windows.Forms.Button();
   this.label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 24);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(200, 20);
   this.textBox1.TabIndex = 0;
   this.textBox1.Text = "textBox1";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(216, 24);
   this.button1.Name = "button1";
   this.button1.TabIndex = 1;
   this.button1.Text = "Çevir";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(8, 56);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(35, 13);
   this.label1.TabIndex = 2;
   this.label1.Text = "label1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 94);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label1,
                                                              this.button1,
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

  string çevir(string sayý) 
  {
   int max_basamak_say = 18; //18 basamaklý-katrilyon, daha da artýrýlabilir
   string[] birler =  { "", "bir", "iki", "üç", "dört", "beþ", "altý", 
                       "yedi", "sekiz", "dokuz"};
   string[] onlar  = { "", "on", "yirmi", "otuz", "kýrk", "elli", "altmýþ", 
                       "yetmiþ", "seksen", "doksan"};
   //Eðer 18 basamaktan daha fazla kullanacaksanýz 
   //katrilyondan önce o basamaklarý da ekleyin
   string[] binler = {"katrilyon", "trilyon", "milyar", "milyon", "bin", ""};
   int i, uz ;
   int[] bas = new int[3];
   string sonuç="", ara_sonuç="";
   uz = sayý.Length; 
   //sayýnýn kullanýlmayan basamaklarýný sýfýrla doldur
   sayý = sayý.PadLeft(max_basamak_say, '0');
   //sayýyý üçerli basamaklar halinde ele al
   for (i = 0 ; i <= max_basamak_say / 3 - 1 ; i++)
   {
    //üçlü basamaktaki birinci sayý yani yüzler basamaðý
    bas[0] = int.Parse(sayý.Substring(i * 3, 1));
    //üçlü basamaktaki ikinci sayý yani onlar basamaðý
    bas[1] = int.Parse(sayý.Substring((i * 3) + 1, 1));
    //üçlü basamaktaki üçüncü sayý yani birler basamaðý
    bas[2] = int.Parse(sayý.Substring((i * 3) + 2, 1)); 
    if (bas[0] == 0)
     ara_sonuç = ""; //yüzler basamaðý boþ
    else
     if (bas[0] == 1)
     ara_sonuç = "yüz"; //yüzler basamaðýnda 1 varsa 1 yüz olmaz sadece yüz
    else
     ara_sonuç = birler[bas[0]] + "yüz"; //yüzler basamaðýndaki sayý ve yüz 
    //ikiyüz gibi
    //yüzler+onlar+birler basamaðýný birleþtir
    ara_sonuç = ara_sonuç + onlar[bas[1]] + birler[bas[2]];
    //basamak deðeri oluþmadýysa yani 000 ise binler basamaðýný ekle
    if (ara_sonuç != "") 
     ara_sonuç = ara_sonuç + binler[i];
    //birbin olmaz
    if ((i > 1) && (ara_sonuç == "birbin"))
     ara_sonuç = "bin";
    if (ara_sonuç != "") 
     sonuç = sonuç + ara_sonuç + " ";
   }
   if (sonuç.Trim() == "") 
    sonuç = "sýfýr";
   return sonuç.Trim();
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   try
   {
    label1.Text = çevir(textBox1.Text);
   }
   catch
   {
    MessageBox.Show("Geçersiz sayý");
   }
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   this.AcceptButton=button1;
  }
	}
}
