using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Numeric_UpDown
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label label1;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.NumericUpDown numericUpDown1;
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
   this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(8, 16);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(68, 13);
   this.label1.TabIndex = 21;
   this.label1.Text = "Font Boyutu:";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(8, 40);
   this.textBox1.Multiline = true;
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(120, 64);
   this.textBox1.TabIndex = 20;
   this.textBox1.Text = "textBox1";
   // 
   // numericUpDown1
   // 
   this.numericUpDown1.Location = new System.Drawing.Point(80, 16);
   this.numericUpDown1.Name = "numericUpDown1";
   this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
   this.numericUpDown1.TabIndex = 19;
   this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(136, 118);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.label1,
                                                              this.textBox1,
                                                              this.numericUpDown1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
   numericUpDown1.Minimum = 8 ;//En az 8 punto olsun
   numericUpDown1.Maximum = 200 ;//En çok 200 punto olsun
   numericUpDown1.Increment = 2 ;//ikiþer artsýn
   //Þu anki font boyutunu göster
   numericUpDown1.Value = (decimal) textBox1.Font.Size;
  }

  private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
  {
   textBox1.Font = new Font(textBox1.Font.FontFamily, 
    (float) numericUpDown1.Value);
  }
 }
}
