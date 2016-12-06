using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace KarakterGruplarý
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.ComboBox comboBox1;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.ListBox listBox1;
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
   this.button1 = new System.Windows.Forms.Button();
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(232, 8);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(56, 24);
   this.button1.TabIndex = 7;
   this.button1.Text = "Listele";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // comboBox1
   // 
   this.comboBox1.Location = new System.Drawing.Point(104, 8);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(121, 21);
   this.comboBox1.TabIndex = 6;
   this.comboBox1.Text = "comboBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(120, 24);
   this.Label1.TabIndex = 5;
   this.Label1.Text = "Listelenecek Grup";
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 40);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(280, 212);
   this.listBox1.TabIndex = 4;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(296, 262);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.comboBox1,
                                                              this.Label1,
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
   //comboBox içine karakter gruplarýný ekle
   comboBox1.Items.Add("Control");
   comboBox1.Items.Add("Digit");
   comboBox1.Items.Add("Letter");
   comboBox1.Items.Add("LetterOrDigit");
   comboBox1.Items.Add("Lower");
   comboBox1.Items.Add("Number");
   comboBox1.Items.Add("Punctuation");
   comboBox1.Items.Add("Separator");
   comboBox1.Items.Add("Surrogate");
   comboBox1.Items.Add("Symbol");
   comboBox1.Items.Add("Upper");
   comboBox1.Items.Add("WhiteSpace");
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   int i;
   string s;
   listBox1.Font = new Font("Courier new", 10, FontStyle.Regular);
   listBox1.Items.Clear();
   listBox1.Items.Add("Karakter Kodu    Karakter");
   listBox1.Items.Add("-------------    --------");
   for (i = 0 ; i<= 255 ; i++)//256 karakteri tara
   {
    s = i.ToString().PadLeft(8,' '); //Karakter kodu
    s = s + "           " + (char) i; //Karakter 
    //i numaralý karakter ComboBox içinde seçilen gruptaysa listeye ekle
    switch(comboBox1.Text)
    {
     case "Control" :
      if (Char.IsControl((char) i)) 
       listBox1.Items.Add(s);
      break;
     case "Digit":
      if (Char.IsDigit((char) i)) 
       listBox1.Items.Add(s);
      break;
     case "Letter":
      if (Char.IsLetter((char) i)) 
       listBox1.Items.Add(s);
      break;
     case "LetterOrDigit":
      if (Char.IsLetterOrDigit((char) i))
       listBox1.Items.Add(s);
      break;
     case "Lower":
      if (Char.IsLower((char) i))
       listBox1.Items.Add(s);
      break;
     case "Number":
      if (Char.IsNumber((char) i)) 
       listBox1.Items.Add(s);
      break;
     case "Punctuation":
      if (Char.IsPunctuation((char) i))
       listBox1.Items.Add(s);
      break;
     case "Separator":
      if (Char.IsSeparator((char) i))
       listBox1.Items.Add(s);
      break;
     case "Surrogate":
      if (Char.IsSurrogate((char) i)) 
       listBox1.Items.Add(s);
      break;
     case "Symbol":
      if (Char.IsSymbol((char) i)) 
       listBox1.Items.Add(s);
      break;
     case "Upper":
      if (Char.IsUpper((char) i)) 
       listBox1.Items.Add(s);
      break;
     case "WhiteSpace":
      if (Char.IsWhiteSpace((char) i)) 
       listBox1.Items.Add(s);
      break;
    }
   }
  }
	}
}
