using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BinaryDecimalCevir
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label label1;
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
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(88, 56);
   this.button2.Name = "button2";
   this.button2.TabIndex = 7;
   this.button2.Text = "Decimal";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(8, 56);
   this.button1.Name = "button1";
   this.button1.TabIndex = 6;
   this.button1.Text = "Binary";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(160, 20);
   this.textBox1.TabIndex = 5;
   this.textBox1.Text = "textBox1";
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(8, 32);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(160, 23);
   this.label1.TabIndex = 4;
   this.label1.Text = "label1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(176, 86);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button2,
                                                              this.button1,
                                                              this.textBox1,
                                                              this.label1});
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
   int  i;
   string h,b,a,s="";
   try
   {
    //sayýyý hexadecimal formata çevir.
    h = int.Parse(textBox1.Text).ToString("X");
   }
   catch
   {
    MessageBox.Show("Sayý hatalý");
    return ;
   }
   for (i = 1 ; i<= h.Length; i++)
   {
    b = h.Substring(i-1, 1); //bir basamak al
    switch(b)
    {
     case "0" : a = "0000";break;
     case "1" : a = "0001";break;
     case "2" : a = "0010";break;
     case "3" : a = "0011";break;
     case "4" : a = "0100";break;
     case "5" : a = "0101";break;
     case "6" : a = "0110";break;
     case "7" : a = "0111";break;
     case "8" : a = "1000";break;
     case "9" : a = "1001";break;
     case "A" : a = "1010";break;
     case "B" : a = "1011";break;
     case "C" : a = "1100";break;
     case "D" : a = "1101";break;
     case "E" : a = "1110";break;
     case "F" : a = "1111";break;
     default  : a = "";break;
    }
    s = s + a;
   }
   label1.Text = s;
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   int i,j=0,s=0;
   try
   {
    for (i = textBox1.Text.Length  ; i>= 1 ; i--, j++)
     //Her bir basamaðý ikinin üstleri ile çarp
     s = s + int.Parse(textBox1.Text.Substring(i-1, 1)) * (int)(Math.Pow(2 , j));
      label1.Text = s.ToString();
   }
   catch
   {
    MessageBox.Show("Sayý hatalý");
   }
  }
	}
}
