using System;

namespace SystemMenüsü
{
 /// <summary>
 /// Summary description for Class1.
 /// </summary>
 public class Mesaj_Ýþle  : System.Windows.Forms.IMessageFilter
 {
  public Mesaj_Ýþle()
  {
   //
   // TODO: Add constructor logic here
   //
  }
  public Boolean PreFilterMessage(ref System.Windows.Forms.Message m) 
  {
   if (m.Msg == 0x112) //WM_SYSCOMMAND ise
    switch(m.WParam.ToInt32())
    {
     case 10 : System.Windows.Forms.MessageBox.Show("Bu program formlarýn System Menüsüne yeni menülerin " +
                "nasýl ekleneceðini göstermek için yapýlmýþtýr");
      return true; //mesajýn iþlendiðini bildir
     case 20 : 
      Form1.Dosya_Aç_Penceresi.Filter = 
       "Program dosyalarý|*.exe;*.com;*.bat;*.pif|" + 
       "Bütün dosyalar|*.*";
      if (Form1.Dosya_Aç_Penceresi.ShowDialog() == System.Windows.Forms.DialogResult.OK)
       System.Diagnostics.Process.Start(Form1.Dosya_Aç_Penceresi.FileName);
      return true; //mesajýn iþlendiðini bildir
     case 0xF030: //Ekraný kapla menüsü
      System.Windows.Forms.MessageBox.Show("Ekraný kapla menüsü iptal edildi");
      //mesajýn iþlendiðini bildirerek ekraný kapla kodunun çalýþmasýný önle
      return true;
     default:
      return false; //Mesajýn iþlenmediðini bildir
    }
   else
    return false; //Mesajýn iþlenmediðini bildir
  }
	}
}
