using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace RGB
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.Label Label1;
  internal System.Windows.Forms.NumericUpDown numericUpDown3;
  internal System.Windows.Forms.NumericUpDown numericUpDown2;
  internal System.Windows.Forms.NumericUpDown numericUpDown1;
  internal System.Windows.Forms.TextBox textBox1;
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
   this.Label3 = new System.Windows.Forms.Label();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
   this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
   this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
   this.textBox1 = new System.Windows.Forms.TextBox();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
   this.SuspendLayout();
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(144, 56);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(48, 23);
   this.Label3.TabIndex = 13;
   this.Label3.Text = "Mavi";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(88, 56);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(48, 23);
   this.Label2.TabIndex = 12;
   this.Label2.Text = "Yeþil";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(32, 56);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(48, 23);
   this.Label1.TabIndex = 11;
   this.Label1.Text = "Kýrmýzý";
   // 
   // numericUpDown3
   // 
   this.numericUpDown3.Location = new System.Drawing.Point(144, 80);
   this.numericUpDown3.Name = "numericUpDown3";
   this.numericUpDown3.Size = new System.Drawing.Size(50, 20);
   this.numericUpDown3.TabIndex = 10;
   // 
   // numericUpDown2
   // 
   this.numericUpDown2.Location = new System.Drawing.Point(88, 80);
   this.numericUpDown2.Name = "numericUpDown2";
   this.numericUpDown2.Size = new System.Drawing.Size(50, 20);
   this.numericUpDown2.TabIndex = 9;
   // 
   // numericUpDown1
   // 
   this.numericUpDown1.Location = new System.Drawing.Point(32, 80);
   this.numericUpDown1.Name = "numericUpDown1";
   this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
   this.numericUpDown1.TabIndex = 8;
   this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(24, 16);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(184, 20);
   this.textBox1.TabIndex = 7;
   this.textBox1.Text = "textBox1";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(232, 118);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Label3,
                                                              this.Label2,
                                                              this.Label1,
                                                              this.numericUpDown3,
                                                              this.numericUpDown2,
                                                              this.numericUpDown1,
                                                              this.textBox1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
   numericUpDown1.Maximum = 255;
   numericUpDown2.Maximum = 255;
   numericUpDown3.Maximum = 255;
   //Olaylarý birleþtir
   numericUpDown2.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
   numericUpDown3.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
  }

  private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
  {
   textBox1.BackColor = Color.FromArgb((int) numericUpDown1.Value, 
    (int) numericUpDown2.Value, 
    (int) numericUpDown3.Value);
   textBox1.Text = textBox1.BackColor.ToString();
  }
	}
}
