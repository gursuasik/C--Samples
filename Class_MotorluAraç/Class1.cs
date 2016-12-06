using System;

namespace Class_MotorluAraç
{
 public delegate void Ceza_Puaný_Handler(int ceza, int toplam);
 public abstract class motorlu_araç
 {
  private System.Drawing.Color renk;
  public System.Drawing.Color Renk
  {
   get
   {
    return renk;
   }
  }
  private int yolcu_kapasitesi;
  public int Yolcu_kapasitesi
  {
   get
   {
    return yolcu_kapasitesi;
   }
   set
   {
    yolcu_kapasitesi = value;
   }
  }
  private int yolcu_sayýsý;
  public int Yolcu_sayýsý
  {
   get
   {
    return yolcu_sayýsý;
   }
  }

  private bool sürücü;
  public bool Sürücü
  {
   get
   {
    return sürücü;
   }
  }
                                                                                                                                                                                      
  private bool çalýþýyor;
  public bool Çalýþýyor
  {
   get
   {
    return çalýþýyor;
   }
  }
                                                                                                                                                                                                                                                                
  protected int sürücü_ceza_puaný;
  public int Sürücü_ceza_puaný
  {
   get
   {
    return sürücü_ceza_puaný;
   }
  }

  private bool gidiyor;
  public bool Gidiyor
  {
   get
   {
    return gidiyor;
   }
  }

  public enum Vitesler
  {
   Boþta,
   Ýleri,
   Geri
  }

  private Vitesler vites;
  public Vitesler Vites
  {
   get
   {
    return vites;
   }
  }

  public void sürücü_bindir()
  {
   if (sürücü==true)
   {
    ArgumentException Sürücü_Var_Hatasý = new ArgumentException("Sürücü zaten binmiþ");
    throw Sürücü_Var_Hatasý;
   }
   else
   {
    sürücü = true;
   }
  }

  public void sürücü_indir()
  {
   if (sürücü==false)
   {
    ArgumentException Sürücü_Yok_Hatasý = new ArgumentException("Araçta sürücü yok");
    throw Sürücü_Yok_Hatasý;
   }
   else if (gidiyor)
   {
    ArgumentException Ýnilmez_Hatasý = new ArgumentException("Araç giderken inilmez");
    sürücü_ceza_puaný += 25;
    ceza_bildir(25,sürücü_ceza_puaný);
    throw Ýnilmez_Hatasý;
   }
   else
   {
    sürücü = false;
   }
  }

  public event Ceza_Puaný_Handler ceza_bildir;
  protected void ceza_puaný_deðiþti(int ceza, int toplam) 
  {
   if (ceza_bildir!= null) 
    ceza_bildir(ceza, toplam);
  }

  public void sürücü_deðiþ()
  {
   if (sürücü==true)
   {
    ArgumentException Sürücü_Var_Hatasý = new ArgumentException("Bu araçta sürücü var");
    throw Sürücü_Var_Hatasý;
   }
   else if (gidiyor)
   {
    ArgumentException Sürücü_Deðiþmez_Hatasý = new ArgumentException("Araç giderken sürücü deðiþtirilmez");
    sürücü_ceza_puaný += 25;
    ceza_bildir(25,sürücü_ceza_puaný);
    throw Sürücü_Deðiþmez_Hatasý;
   }
   else
   {
    sürücü_ceza_puaný = 0;
    ceza_bildir(0,sürücü_ceza_puaný);
   }
  }

  public void yolcu_bindir()
  {
   if (yolcu_sayýsý == yolcu_kapasitesi)
   {
    ArgumentException Yolcu_Dolu_Hatasý = new ArgumentException("Yolcu kapasitesi dolu");
    throw Yolcu_Dolu_Hatasý;
   }
   else if (gidiyor)
   {
    ArgumentException Binilmez_Hatasý = new ArgumentException("Araç giderken binilmez");
    sürücü_ceza_puaný += 15;
    ceza_bildir(15,sürücü_ceza_puaný);
    throw Binilmez_Hatasý;
   }
   else
   {
    yolcu_sayýsý += 1;
   }
  }

  public void yolcu_indir()
  {
   if (yolcu_sayýsý == 0)
   {
    ArgumentException Yolcu_Yok_Hatasý = new ArgumentException("Araçta yolcu yok");
    throw Yolcu_Yok_Hatasý;
   }
   else if (gidiyor)
   {
    ArgumentException Ýnilmez_Hatasý = new ArgumentException("Araç giderken inilmez");
    sürücü_ceza_puaný += 15;
    ceza_bildir(15,sürücü_ceza_puaný);
    throw Ýnilmez_Hatasý;
   }
   else
   {
    yolcu_sayýsý -= 1;
   }
  }

  public void vites_deðiþ(Vitesler pvites)
  {
   vites = pvites;
   if (vites == Vitesler.Boþta)
   {
    gidiyor = false;
    saat.Enabled = false;
   }
  }

  public void çalýþtýr()
  {
   if (sürücü==false)
   {
    ArgumentException Sürücü_Yok_Hatasý = new ArgumentException("Araçta sürücü yok");
    throw Sürücü_Yok_Hatasý;
   }
   else if(gidiyor)
   {
    ArgumentException Çalýþýyor_Hatasý = new ArgumentException("Araç zaten çalýþýyor");
    sürücü_ceza_puaný += 5;
    ceza_bildir(5,sürücü_ceza_puaný);
    throw Çalýþýyor_Hatasý;
   }
   else if(çalýþýyor)
   {
    ArgumentException Çalýþýyor_Hatasý = new ArgumentException("Araç zaten çalýþýyor");
    sürücü_ceza_puaný += 5;
    ceza_bildir(5,sürücü_ceza_puaný);
    throw Çalýþýyor_Hatasý;
   }
   else 
   {
    if(vites != Vitesler.Boþta)
    {
     ArgumentException Vites_Hatasý = new ArgumentException("Araç vitesteyken çalýþmaz");
     sürücü_ceza_puaný += 10;
     ceza_bildir(10,sürücü_ceza_puaný);
     throw Vites_Hatasý;
    }
    else
    {
     çalýþýyor = true;
    }
   }
  }

  public void dur()
  {
   if (vites != Vitesler.Boþta)
   {
    ArgumentException Vites_Hatasý = new ArgumentException("Vites boþa alýnmadan araba durmaz");
    sürücü_ceza_puaný += 5;
    ceza_bildir(5,sürücü_ceza_puaný);
    throw Vites_Hatasý;
   }
   else
   {
    çalýþýyor = false;
    saat.Enabled = false;
   }
  }

  public void git(Vitesler pvites)
  {
   if (çalýþýyor==false)
   {
    ArgumentException Çalýþmýyor_Hatasý = new ArgumentException("Araç çalýþtýrýlmadan gitmez");
    sürücü_ceza_puaný += 5;
    ceza_bildir(5,sürücü_ceza_puaný);
    throw Çalýþmýyor_Hatasý;
   }
   else if(sürücü_ceza_puaný > 100)
   {
    ArgumentException Cezalý_Sürücü_Hatasý = new ArgumentException("Bu sürücünün 100 puandan fazla cezasý var. Bu sürücü araç kullanamaz");
    throw Cezalý_Sürücü_Hatasý;
   }
   else if(pvites == Vitesler.Boþta)
   {
    vites = pvites;
    gidiyor = false;
    saat.Enabled = false;
   }
   else
   {
    vites = pvites;
    gidiyor = true;
    saat.Enabled = true;
   }
  }

  public virtual string durum()
  {
   string s;
   s = "Araç rengi:" + renk.ToString() + ".";
   if (sürücü==true) 
    s += "Aracýn sürücüsü var.";
   if (çalýþýyor) 
    s += "Araç çalýþýyor.";
   if (gidiyor) 
    s += "Araç " + vites.ToString() + " doðru gidiyor.";
   if (sürücü_ceza_puaný > 0)
    s += "Sürücünün " + sürücü_ceza_puaný.ToString() + " ceza puaný var.";
   else
    s += "Sürücünün ceza puaný yok.";
   if (yolcu_sayýsý > 0)
    s += "Araçta " + yolcu_sayýsý.ToString() + " yolcu var.";
   else
    s += "Araçta yolcu yok";
   return s;
  }

  System.Timers.Timer saat;

  public motorlu_araç(System.Drawing.Color renk)
  {
   saat = new System.Timers.Timer();
   saat.Elapsed += new System.Timers.ElapsedEventHandler(this.zaman_doldu);
   saat.Interval = 1000;
   saat.Enabled = false;
   this.renk = renk;
  }

  public event EventHandler Araç_Gidiyor;

  private void zaman_doldu(object sender,System.Timers.ElapsedEventArgs e)
  {
   Araç_Gidiyor(this, null);
  }

 }


 public class otomobil:motorlu_araç
 {
  private bool hava_yastýðý;
  public bool Hava_yastýðý
  {
   get
   {
    return hava_yastýðý;
   }
   set
   {
    hava_yastýðý = value;
   }
  }

  public otomobil(System.Drawing.Color renk):base(renk)
  {
   Yolcu_kapasitesi = 4;
  }

  public otomobil(System.Drawing.Color renk, bool hava_yastýðý):base(renk)
  {
   Yolcu_kapasitesi = 4;
   Hava_yastýðý = hava_yastýðý;
  }

  public override string durum()
  {
   string s = base.durum();
   if (hava_yastýðý) 
    s += "Araçta hava yastýðý var.";
   if (sürücü_ceza_puaný > 70) 
    s += "Bu aracýn sürücüsü bir trafik canavarý.";
   return s;
  }
 }


 public class kamyon:motorlu_araç
 {
  private int yük_kapasitesi;
  public int Yük_kapasitesi
  {
   get
   {
    return yük_kapasitesi;
   }
   set
   {
    yük_kapasitesi = value;
   }
  }

  private int aks_sayýsý;
  public int Aks_sayýsý
  {
   get
   {
    return aks_sayýsý;
   }
   set
   {
    aks_sayýsý = value;
   }
  }

  private int yükü;
  public int Yükü
  {
   get
   {
    return yükü;
   }
  }
  
  public void yükle(int yük)
  {
   if (Gidiyor)
   {
    ArgumentException Yüklenemez_Hatasý = new ArgumentException("Araç giderken yüklenemez");
    sürücü_ceza_puaný += 5;
    ceza_puaný_deðiþti(5,sürücü_ceza_puaný);
    throw Yüklenemez_Hatasý;
   }
   else if (yükü + yük > yük_kapasitesi)
   {
    ArgumentException Aþýrý_yükleme_Hatasý = new ArgumentException("Araç bu yükü alamýyor");
    sürücü_ceza_puaný += 5;
    ceza_puaný_deðiþti(5,sürücü_ceza_puaný);
    throw Aþýrý_yükleme_Hatasý;
   }
   else
   {
    yükü += yük;
   }
  }

  public void boþalt(int yük)
  {
   if (Gidiyor)
   {
    ArgumentException Boþaltýlamaz_Hatasý = new ArgumentException("Araç giderken yük boþaltýlamaz");
    sürücü_ceza_puaný += 5;
    ceza_puaný_deðiþti(5,sürücü_ceza_puaný);
    throw Boþaltýlamaz_Hatasý;
   }
   else if (yükü - yük < 0)
   {
    ArgumentException Yük_Yok_Hatasý = new ArgumentException("Araçta bu kadar yük yok");
    throw Yük_Yok_Hatasý;
   }
   else
   {
    yükü -= yük;
   }
  }


  public kamyon(System.Drawing.Color renk):base(renk)
  {
   yük_kapasitesi = 40000;
   aks_sayýsý = 4;
   Yolcu_kapasitesi = 2;
  }

  public kamyon(System.Drawing.Color renk, int aks_sayýsý):base(renk)
  {
   yük_kapasitesi = 40000;
   this.aks_sayýsý = aks_sayýsý;
   Yolcu_kapasitesi = 2;
  }

  public kamyon(System.Drawing.Color renk, int aks_sayýsý , int yük_kapasite):base(renk)
  {
   yük_kapasitesi = yük_kapasite;
   this.aks_sayýsý = aks_sayýsý;
   Yolcu_kapasitesi = 2;
  }

  public override string durum()
  {
   string s = base.durum();
   if (yükü > 0) 
    s += "Araçta " + yükü.ToString() + " kg yük var.";
   if (sürücü_ceza_puaný > 70) 
    s += "Bu aracýn sürücüsü bir trafik canavarý.";
   if (aks_sayýsý > 0) 
    s += "Araçta " + aks_sayýsý.ToString() + " aks var.";
   return s;
  }

 }
}
