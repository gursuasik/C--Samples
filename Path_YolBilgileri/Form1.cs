using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
namespace Path_YolBilgileri
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.ListBox listBox1;
  internal System.Windows.Forms.OpenFileDialog openFileDialog1;
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
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.SuspendLayout();
   // 
   // listBox1
   // 
   this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(292, 264);
   this.listBox1.TabIndex = 1;
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
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
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
   {
    string yol= openFileDialog1.FileName;
    listBox1.Items.Add("Bulunduðu klasör:" +
     System.IO.Path.GetDirectoryName(yol));
    listBox1.Items.Add("Dosya adý:" + Path.GetFileName(yol));
    listBox1.Items.Add("Uzantýsý:" + Path.GetExtension(yol));
    listBox1.Items.Add("Uzantýsýz dosya adý:" +
     Path.GetFileNameWithoutExtension(yol));
    listBox1.Items.Add("Tam yolu:" + Path.GetFullPath(yol));
    listBox1.Items.Add("Kök klasörü:" + Path.GetPathRoot(yol));
    listBox1.Items.Add("Yol içinde kök klasör yazýlý mý?:" +
     Path.IsPathRooted(yol));
    listBox1.Items.Add("Dosya uzantýsý var mý?:" +
     Path.HasExtension(yol));
   }
  }
	}
}
