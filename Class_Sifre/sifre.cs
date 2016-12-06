using System;

namespace Class_Sifre
{
 public class sifre
 {

  public sifre()
  {
   þifre= "123";
   text= "Þifrelenecek metin";
  }

  public sifre(string Þifre, string Text)
  {
   þifre = Þifre;
   text = Text;
  }

  private string þifre;
  public string Þifre
  {
   get
   {
    return þifre; 
   }
   set
   {
    þifre = value; 
   }
  }

  private string text;
  public string Text
  {
   get
   {
    return text; 
   }
   set
   {
    text = value; 
   }
  }

  public string Þifrele()//Þifrele metodu
  {
   return (Þifrele_Çöz());
  }

  public string Çöz()//Çöz metodu
  {
   return (Þifrele_Çöz());
  }

  private string Þifrele_Çöz()//Þifreleme ve çözme fonksiyonu
  {
   string Sonuç, AraSonuç;
   int i, j;
   char c;
   Sonuç = text;
   for (j = 0 ; j<= þifre.Length - 1 ; j++)
   {
    AraSonuç = "";
    for (i = 0 ; i<= Sonuç.Length - 1 ; i++)
    {
     c = (char) (Sonuç[i] ^ þifre[j]);
     if (c == '0')
      c = þifre[j];
     AraSonuç  = AraSonuç  + (char) c;
    }
    Sonuç = AraSonuç;
   }
   return Sonuç;
  }
 }
}
