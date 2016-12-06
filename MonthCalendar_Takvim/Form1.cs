using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MonthCalendar_Takvim
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.MonthCalendar monthCalendar1;
  internal System.Windows.Forms.NumericUpDown numericUpDown2;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.NumericUpDown numericUpDown1;
  internal System.Windows.Forms.Label Label1;
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
   this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
   this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
   this.Label2 = new System.Windows.Forms.Label();
   this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
   this.Label1 = new System.Windows.Forms.Label();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
   this.SuspendLayout();
   // 
   // monthCalendar1
   // 
   this.monthCalendar1.Location = new System.Drawing.Point(8, 32);
   this.monthCalendar1.Name = "monthCalendar1";
   this.monthCalendar1.TabIndex = 9;
   // 
   // numericUpDown2
   // 
   this.numericUpDown2.Location = new System.Drawing.Point(184, 8);
   this.numericUpDown2.Name = "numericUpDown2";
   this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
   this.numericUpDown2.TabIndex = 8;
   this.numericUpDown2.Value = new System.Decimal(new int[] {
                                                             1,
                                                             0,
                                                             0,
                                                             0});
   // 
   // Label2
   // 
   this.Label2.AutoSize = true;
   this.Label2.Location = new System.Drawing.Point(168, 8);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(10, 13);
   this.Label2.TabIndex = 7;
   this.Label2.Text = "x";
   // 
   // numericUpDown1
   // 
   this.numericUpDown1.Location = new System.Drawing.Point(120, 8);
   this.numericUpDown1.Name = "numericUpDown1";
   this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
   this.numericUpDown1.TabIndex = 6;
   this.numericUpDown1.Value = new System.Decimal(new int[] {
                                                             1,
                                                             0,
                                                             0,
                                                             0});
   this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.TabIndex = 5;
   this.Label1.Text = "Takvim Formatý:";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(768, 470);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.monthCalendar1,
                                                              this.numericUpDown2,
                                                              this.Label2,
                                                              this.numericUpDown1,
                                                              this.Label1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
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
   numericUpDown1.Minimum = 1;
   numericUpDown1.Maximum = 12;
   numericUpDown2.Minimum = 1;
   numericUpDown2.Maximum = 12;
   monthCalendar1.ShowWeekNumbers = true;
   //1 ocak, 23 nisan, 19 mayýs, 29 ekim resmi tatil günleri
   DateTime[] tatiller  = {new DateTime( 2000,1,1),//1 ocak
                           new DateTime(2000,4,23),//23 nisan
                           new DateTime(2000,5,19),//19 mayýs 
                           new DateTime(2000,10,29)//29 ekim
                          }; //Yýl önemli deðil
   monthCalendar1.AnnuallyBoldedDates = tatiller;
   //Olaylarý birleþtir
   numericUpDown2.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
  }

  private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
  {
   if (numericUpDown1.Value * numericUpDown2.Value == 0)
    return;
   if (numericUpDown1.Value * numericUpDown2.Value > 12)
    MessageBox.Show("Satýr, Sütun çarpýmý 12yi geçemez");
   else
    monthCalendar1.CalendarDimensions = 
     new Size((int) numericUpDown1.Value, (int) numericUpDown2.Value);
  }
	}
}
