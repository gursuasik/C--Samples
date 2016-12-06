using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Checked_ListBox
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.GroupBox GroupBox2;
  internal System.Windows.Forms.ListBox listBox1;
  internal System.Windows.Forms.ListBox listBox2;
  internal System.Windows.Forms.Label label4;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.GroupBox GroupBox1;
  internal System.Windows.Forms.CheckedListBox checkedListBox2;
  internal System.Windows.Forms.CheckedListBox checkedListBox1;
  internal System.Windows.Forms.Button button2;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.TextBox textBox2;
  internal System.Windows.Forms.TextBox textBox1;
  internal System.Windows.Forms.Label Label2;
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
   this.GroupBox2 = new System.Windows.Forms.GroupBox();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.listBox2 = new System.Windows.Forms.ListBox();
   this.label4 = new System.Windows.Forms.Label();
   this.Label3 = new System.Windows.Forms.Label();
   this.GroupBox1 = new System.Windows.Forms.GroupBox();
   this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
   this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
   this.button2 = new System.Windows.Forms.Button();
   this.button1 = new System.Windows.Forms.Button();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.Label1 = new System.Windows.Forms.Label();
   this.GroupBox2.SuspendLayout();
   this.GroupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // GroupBox2
   // 
   this.GroupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.listBox1,
                                                                        this.listBox2,
                                                                        this.label4,
                                                                        this.Label3});
   this.GroupBox2.Location = new System.Drawing.Point(296, 8);
   this.GroupBox2.Name = "GroupBox2";
   this.GroupBox2.Size = new System.Drawing.Size(264, 224);
   this.GroupBox2.TabIndex = 3;
   this.GroupBox2.TabStop = false;
   this.GroupBox2.Text = "Satýlan Malzeme";
   // 
   // listBox1
   // 
   this.listBox1.Location = new System.Drawing.Point(8, 16);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(160, 173);
   this.listBox1.TabIndex = 14;
   // 
   // listBox2
   // 
   this.listBox2.Location = new System.Drawing.Point(168, 16);
   this.listBox2.Name = "listBox2";
   this.listBox2.Size = new System.Drawing.Size(88, 173);
   this.listBox2.TabIndex = 12;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(168, 200);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(38, 13);
   this.label4.TabIndex = 11;
   this.label4.Text = "Label4";
   // 
   // Label3
   // 
   this.Label3.AutoSize = true;
   this.Label3.Location = new System.Drawing.Point(96, 200);
   this.Label3.Name = "Label3";
   this.Label3.Size = new System.Drawing.Size(54, 13);
   this.Label3.TabIndex = 10;
   this.Label3.Text = "TOPLAM:";
   // 
   // GroupBox1
   // 
   this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                        this.checkedListBox2,
                                                                        this.checkedListBox1,
                                                                        this.button2,
                                                                        this.button1,
                                                                        this.textBox2,
                                                                        this.textBox1,
                                                                        this.Label2,
                                                                        this.Label1});
   this.GroupBox1.Location = new System.Drawing.Point(8, 8);
   this.GroupBox1.Name = "GroupBox1";
   this.GroupBox1.Size = new System.Drawing.Size(280, 224);
   this.GroupBox1.TabIndex = 2;
   this.GroupBox1.TabStop = false;
   this.GroupBox1.Text = "Malzeme Listesi:";
   // 
   // checkedListBox2
   // 
   this.checkedListBox2.IntegralHeight = false;
   this.checkedListBox2.Items.AddRange(new object[] {
                                                     "18",
                                                     "80",
                                                     "85",
                                                     "20",
                                                     "65",
                                                     "10",
                                                     "18",
                                                     "35"});
   this.checkedListBox2.Location = new System.Drawing.Point(160, 80);
   this.checkedListBox2.Name = "checkedListBox2";
   this.checkedListBox2.Size = new System.Drawing.Size(112, 136);
   this.checkedListBox2.TabIndex = 14;
   this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
   // 
   // checkedListBox1
   // 
   this.checkedListBox1.IntegralHeight = false;
   this.checkedListBox1.Items.AddRange(new object[] {
                                                     "RAM",
                                                     "CPU",
                                                     "Harddisk",
                                                     "Grafik Kartý",
                                                     "Ana Kart",
                                                     "FDD",
                                                     "CD Rom",
                                                     "DVD Rom"});
   this.checkedListBox1.Location = new System.Drawing.Point(8, 80);
   this.checkedListBox1.Name = "checkedListBox1";
   this.checkedListBox1.Size = new System.Drawing.Size(152, 136);
   this.checkedListBox1.TabIndex = 10;
   this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
   // 
   // button2
   // 
   this.button2.Location = new System.Drawing.Point(192, 48);
   this.button2.Name = "button2";
   this.button2.TabIndex = 6;
   this.button2.Text = "Sil";
   this.button2.Click += new System.EventHandler(this.button2_Click);
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(192, 24);
   this.button1.Name = "button1";
   this.button1.TabIndex = 5;
   this.button1.Text = "Ekle";
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(88, 48);
   this.textBox2.Name = "textBox2";
   this.textBox2.TabIndex = 4;
   this.textBox2.Text = "textBox2";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(88, 24);
   this.textBox1.Name = "textBox1";
   this.textBox1.TabIndex = 3;
   this.textBox1.Text = "textBox1";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 48);
   this.Label2.Name = "Label2";
   this.Label2.TabIndex = 2;
   this.Label2.Text = "Fiyatý:";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 32);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(80, 16);
   this.Label1.TabIndex = 1;
   this.Label1.Text = "Malzeme Adý:";
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(568, 238);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.GroupBox2,
                                                              this.GroupBox1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.GroupBox2.ResumeLayout(false);
   this.GroupBox1.ResumeLayout(false);
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
   checkedListBox1.Items.Add(textBox1.Text);
   checkedListBox2.Items.Add(textBox2.Text);
  }

  private void button2_Click(object sender, System.EventArgs e)
  {
   int ind;
   ind = checkedListBox1.SelectedIndex;
   if (ind < 0)
    MessageBox.Show("Önce sileceðiniz elemaný seçin");
   else
   {
    checkedListBox1.Items.RemoveAt(ind);
    checkedListBox2.Items.RemoveAt(ind);
   }
  }

  private void checkedListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   int ind, b, t, i;
   //seçili elemanýn indexini al
   ind = checkedListBox1.SelectedIndex;
   //Her iki listede de ayný elemanlarýn seçili olmasýný saðla
   checkedListBox2.SelectedIndex = ind;
   if (ind < 0) 
    return;
   //ve iþaretlerininde ayný olmasýný saðla
   checkedListBox2.SetItemChecked(ind, 
    checkedListBox1.GetItemChecked(ind));
   //Satýlan malzeme listesinden bul
   b = listBox1.Items.IndexOf(checkedListBox1.Items[ind]);
   if (b < 0)//Satýlan malzeme listesinde yoksa
   {
    if (checkedListBox1.GetItemChecked(ind)==true)//ve iþaretliyse
    {
     //Satýlan malzeme listesine ekle
     listBox1.Items.Add(checkedListBox1.Items[ind]);
     //Fiyatýný ekle
     listBox2.Items.Add(checkedListBox2.Items[ind]);
    }
   }
   if (b >= 0)//Satýlan malzeme listesinde varsa
   {
    if (checkedListBox1.GetItemChecked(ind)==false)//ve Ýþaretli deðilse
    {
     //Ýþareti kaldýrýldýysa satýlan malzeme listesinden kaldýr;
     listBox1.Items.RemoveAt(b);
     listBox2.Items.RemoveAt(b);
    }
   }
   //toplam fiyatý bul
   t = 0;
   for (i = 0;i<=listBox2.Items.Count - 1;i++)
    t = t + int.Parse(listBox2.Items[i].ToString());
   label4.Text = t.ToString();
  }

  private void checkedListBox2_SelectedIndexChanged(object sender, System.EventArgs e)
  {
   //Her iki listede de ayný elemanlarýn seçili olmasýný saðla
   checkedListBox1.SelectedIndex = checkedListBox2.SelectedIndex;
  }
	}
}
