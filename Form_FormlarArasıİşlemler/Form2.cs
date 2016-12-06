using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Form_FormlarArasýÝþlemler
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
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
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 48);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(272, 20);
   this.textBox1.TabIndex = 0;
   this.textBox1.Text = "textBox1";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(96, 88);
   this.button1.Name = "button1";
   this.button1.TabIndex = 1;
   this.button1.Text = "button1";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form2
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(288, 126);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1,
                                                              this.textBox1});
   this.Name = "Form2";
   this.Text = "Form2";
   this.Load += new System.EventHandler(this.Form2_Load);
   this.ResumeLayout(false);

  }
		#endregion

  public System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.Button button1;


  public int x; //Form2 içindeki deðiþken
  private void Form2_Load(object sender, System.EventArgs e)
  {
    this.Text = "x=" + x.ToString();
  }

  private void button1_Click(object sender, System.EventArgs e)
  {
   Form1.y = 50;
   Form1.Text_Kutusu.Text = "Merhaba Form1";
  }
	}
}
