using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Form_BirdenFazlaForm_2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
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
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(72, 224);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(120, 24);
   this.button1.TabIndex = 0;
   this.button1.Text = "Form2\'yi G�ster";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(292, 266);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.button1});
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

  Form2 frm;
  private void button1_Click(object sender, System.EventArgs e)
  {
   if (frm == null) //form de�i�keni bir nesneyi g�stermiyorsa
   {
    frm = new Form2(); //Yeni form olu�tur
    //Yeni formun Closing olay�n� kapand� prosed�r� olarak g�ster
    frm.Closed += new EventHandler(kapand�);
    //formu g�ster
    frm.Show();
   }
   else
    //form zaten varsa �ne getir
    frm.Activate();
  }

  private void kapand�(object sender, System.EventArgs e )
  {
   frm = null;
  }

 }
}
