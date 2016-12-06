using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ForNextFaktöriyel
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.Button button1;
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
   this.label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(0, 8);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(128, 23);
   this.label1.TabIndex = 0;
   this.label1.Text = "Faktöriyeli Alýnacak Sayý";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(128, 8);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 1;
   this.textBox1.Text = "textBox1";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(120, 40);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(112, 23);
   this.button1.TabIndex = 2;
   this.button1.Text = "Hesapla";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(240, 70);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
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
   int sayý, i;
   decimal faktöriyel;
   sayý = int.Parse(textBox1.Text);
   faktöriyel = 1;
   for (i = 1 ; i<= sayý ; i++)
   {
    try
    {
     faktöriyel = faktöriyel * i;
    }
    catch
    {
     MessageBox.Show(i.ToString() + " den büyük sayýlarý hesaplayamýyorum");
     sayý = i - 1;
     break; //Döngüden çýk
    }
   }
   MessageBox.Show(sayý.ToString() + "!=" + faktöriyel.ToString());
  }

  
	}
}
