using System;

namespace Class_MotorluAra�
{
 public delegate void Ceza_Puan�_Handler(int ceza, int toplam);
 public abstract class motorlu_ara�
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
  private int yolcu_say�s�;
  public int Yolcu_say�s�
  {
   get
   {
    return yolcu_say�s�;
   }
  }

  private bool s�r�c�;
  public bool S�r�c�
  {
   get
   {
    return s�r�c�;
   }
  }
                                                                                                                                                                                      
  private bool �al���yor;
  public bool �al���yor
  {
   get
   {
    return �al���yor;
   }
  }
                                                                                                                                                                                                                                                                
  protected int s�r�c�_ceza_puan�;
  public int S�r�c�_ceza_puan�
  {
   get
   {
    return s�r�c�_ceza_puan�;
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
   Bo�ta,
   �leri,
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

  public void s�r�c�_bindir()
  {
   if (s�r�c�==true)
   {
    ArgumentException S�r�c�_Var_Hatas� = new ArgumentException("S�r�c� zaten binmi�");
    throw S�r�c�_Var_Hatas�;
   }
   else
   {
    s�r�c� = true;
   }
  }

  public void s�r�c�_indir()
  {
   if (s�r�c�==false)
   {
    ArgumentException S�r�c�_Yok_Hatas� = new ArgumentException("Ara�ta s�r�c� yok");
    throw S�r�c�_Yok_Hatas�;
   }
   else if (gidiyor)
   {
    ArgumentException �nilmez_Hatas� = new ArgumentException("Ara� giderken inilmez");
    s�r�c�_ceza_puan� += 25;
    ceza_bildir(25,s�r�c�_ceza_puan�);
    throw �nilmez_Hatas�;
   }
   else
   {
    s�r�c� = false;
   }
  }

  public event Ceza_Puan�_Handler ceza_bildir;
  protected void ceza_puan�_de�i�ti(int ceza, int toplam) 
  {
   if (ceza_bildir!= null) 
    ceza_bildir(ceza, toplam);
  }

  public void s�r�c�_de�i�()
  {
   if (s�r�c�==true)
   {
    ArgumentException S�r�c�_Var_Hatas� = new ArgumentException("Bu ara�ta s�r�c� var");
    throw S�r�c�_Var_Hatas�;
   }
   else if (gidiyor)
   {
    ArgumentException S�r�c�_De�i�mez_Hatas� = new ArgumentException("Ara� giderken s�r�c� de�i�tirilmez");
    s�r�c�_ceza_puan� += 25;
    ceza_bildir(25,s�r�c�_ceza_puan�);
    throw S�r�c�_De�i�mez_Hatas�;
   }
   else
   {
    s�r�c�_ceza_puan� = 0;
    ceza_bildir(0,s�r�c�_ceza_puan�);
   }
  }

  public void yolcu_bindir()
  {
   if (yolcu_say�s� == yolcu_kapasitesi)
   {
    ArgumentException Yolcu_Dolu_Hatas� = new ArgumentException("Yolcu kapasitesi dolu");
    throw Yolcu_Dolu_Hatas�;
   }
   else if (gidiyor)
   {
    ArgumentException Binilmez_Hatas� = new ArgumentException("Ara� giderken binilmez");
    s�r�c�_ceza_puan� += 15;
    ceza_bildir(15,s�r�c�_ceza_puan�);
    throw Binilmez_Hatas�;
   }
   else
   {
    yolcu_say�s� += 1;
   }
  }

  public void yolcu_indir()
  {
   if (yolcu_say�s� == 0)
   {
    ArgumentException Yolcu_Yok_Hatas� = new ArgumentException("Ara�ta yolcu yok");
    throw Yolcu_Yok_Hatas�;
   }
   else if (gidiyor)
   {
    ArgumentException �nilmez_Hatas� = new ArgumentException("Ara� giderken inilmez");
    s�r�c�_ceza_puan� += 15;
    ceza_bildir(15,s�r�c�_ceza_puan�);
    throw �nilmez_Hatas�;
   }
   else
   {
    yolcu_say�s� -= 1;
   }
  }

  public void vites_de�i�(Vitesler pvites)
  {
   vites = pvites;
   if (vites == Vitesler.Bo�ta)
   {
    gidiyor = false;
    saat.Enabled = false;
   }
  }

  public void �al��t�r()
  {
   if (s�r�c�==false)
   {
    ArgumentException S�r�c�_Yok_Hatas� = new ArgumentException("Ara�ta s�r�c� yok");
    throw S�r�c�_Yok_Hatas�;
   }
   else if(gidiyor)
   {
    ArgumentException �al���yor_Hatas� = new ArgumentException("Ara� zaten �al���yor");
    s�r�c�_ceza_puan� += 5;
    ceza_bildir(5,s�r�c�_ceza_puan�);
    throw �al���yor_Hatas�;
   }
   else if(�al���yor)
   {
    ArgumentException �al���yor_Hatas� = new ArgumentException("Ara� zaten �al���yor");
    s�r�c�_ceza_puan� += 5;
    ceza_bildir(5,s�r�c�_ceza_puan�);
    throw �al���yor_Hatas�;
   }
   else 
   {
    if(vites != Vitesler.Bo�ta)
    {
     ArgumentException Vites_Hatas� = new ArgumentException("Ara� vitesteyken �al��maz");
     s�r�c�_ceza_puan� += 10;
     ceza_bildir(10,s�r�c�_ceza_puan�);
     throw Vites_Hatas�;
    }
    else
    {
     �al���yor = true;
    }
   }
  }

  public void dur()
  {
   if (vites != Vitesler.Bo�ta)
   {
    ArgumentException Vites_Hatas� = new ArgumentException("Vites bo�a al�nmadan araba durmaz");
    s�r�c�_ceza_puan� += 5;
    ceza_bildir(5,s�r�c�_ceza_puan�);
    throw Vites_Hatas�;
   }
   else
   {
    �al���yor = false;
    saat.Enabled = false;
   }
  }

  public void git(Vitesler pvites)
  {
   if (�al���yor==false)
   {
    ArgumentException �al��m�yor_Hatas� = new ArgumentException("Ara� �al��t�r�lmadan gitmez");
    s�r�c�_ceza_puan� += 5;
    ceza_bildir(5,s�r�c�_ceza_puan�);
    throw �al��m�yor_Hatas�;
   }
   else if(s�r�c�_ceza_puan� > 100)
   {
    ArgumentException Cezal�_S�r�c�_Hatas� = new ArgumentException("Bu s�r�c�n�n 100 puandan fazla cezas� var. Bu s�r�c� ara� kullanamaz");
    throw Cezal�_S�r�c�_Hatas�;
   }
   else if(pvites == Vitesler.Bo�ta)
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
   s = "Ara� rengi:" + renk.ToString() + ".";
   if (s�r�c�==true) 
    s += "Arac�n s�r�c�s� var.";
   if (�al���yor) 
    s += "Ara� �al���yor.";
   if (gidiyor) 
    s += "Ara� " + vites.ToString() + " do�ru gidiyor.";
   if (s�r�c�_ceza_puan� > 0)
    s += "S�r�c�n�n " + s�r�c�_ceza_puan�.ToString() + " ceza puan� var.";
   else
    s += "S�r�c�n�n ceza puan� yok.";
   if (yolcu_say�s� > 0)
    s += "Ara�ta " + yolcu_say�s�.ToString() + " yolcu var.";
   else
    s += "Ara�ta yolcu yok";
   return s;
  }

  System.Timers.Timer saat;

  public motorlu_ara�(System.Drawing.Color renk)
  {
   saat = new System.Timers.Timer();
   saat.Elapsed += new System.Timers.ElapsedEventHandler(this.zaman_doldu);
   saat.Interval = 1000;
   saat.Enabled = false;
   this.renk = renk;
  }

  public event EventHandler Ara�_Gidiyor;

  private void zaman_doldu(object sender,System.Timers.ElapsedEventArgs e)
  {
   Ara�_Gidiyor(this, null);
  }

 }


 public class otomobil:motorlu_ara�
 {
  private bool hava_yast���;
  public bool Hava_yast���
  {
   get
   {
    return hava_yast���;
   }
   set
   {
    hava_yast��� = value;
   }
  }

  public otomobil(System.Drawing.Color renk):base(renk)
  {
   Yolcu_kapasitesi = 4;
  }

  public otomobil(System.Drawing.Color renk, bool hava_yast���):base(renk)
  {
   Yolcu_kapasitesi = 4;
   Hava_yast��� = hava_yast���;
  }

  public override string durum()
  {
   string s = base.durum();
   if (hava_yast���) 
    s += "Ara�ta hava yast��� var.";
   if (s�r�c�_ceza_puan� > 70) 
    s += "Bu arac�n s�r�c�s� bir trafik canavar�.";
   return s;
  }
 }


 public class kamyon:motorlu_ara�
 {
  private int y�k_kapasitesi;
  public int Y�k_kapasitesi
  {
   get
   {
    return y�k_kapasitesi;
   }
   set
   {
    y�k_kapasitesi = value;
   }
  }

  private int aks_say�s�;
  public int Aks_say�s�
  {
   get
   {
    return aks_say�s�;
   }
   set
   {
    aks_say�s� = value;
   }
  }

  private int y�k�;
  public int Y�k�
  {
   get
   {
    return y�k�;
   }
  }
  
  public void y�kle(int y�k)
  {
   if (Gidiyor)
   {
    ArgumentException Y�klenemez_Hatas� = new ArgumentException("Ara� giderken y�klenemez");
    s�r�c�_ceza_puan� += 5;
    ceza_puan�_de�i�ti(5,s�r�c�_ceza_puan�);
    throw Y�klenemez_Hatas�;
   }
   else if (y�k� + y�k > y�k_kapasitesi)
   {
    ArgumentException A��r�_y�kleme_Hatas� = new ArgumentException("Ara� bu y�k� alam�yor");
    s�r�c�_ceza_puan� += 5;
    ceza_puan�_de�i�ti(5,s�r�c�_ceza_puan�);
    throw A��r�_y�kleme_Hatas�;
   }
   else
   {
    y�k� += y�k;
   }
  }

  public void bo�alt(int y�k)
  {
   if (Gidiyor)
   {
    ArgumentException Bo�alt�lamaz_Hatas� = new ArgumentException("Ara� giderken y�k bo�alt�lamaz");
    s�r�c�_ceza_puan� += 5;
    ceza_puan�_de�i�ti(5,s�r�c�_ceza_puan�);
    throw Bo�alt�lamaz_Hatas�;
   }
   else if (y�k� - y�k < 0)
   {
    ArgumentException Y�k_Yok_Hatas� = new ArgumentException("Ara�ta bu kadar y�k yok");
    throw Y�k_Yok_Hatas�;
   }
   else
   {
    y�k� -= y�k;
   }
  }


  public kamyon(System.Drawing.Color renk):base(renk)
  {
   y�k_kapasitesi = 40000;
   aks_say�s� = 4;
   Yolcu_kapasitesi = 2;
  }

  public kamyon(System.Drawing.Color renk, int aks_say�s�):base(renk)
  {
   y�k_kapasitesi = 40000;
   this.aks_say�s� = aks_say�s�;
   Yolcu_kapasitesi = 2;
  }

  public kamyon(System.Drawing.Color renk, int aks_say�s� , int y�k_kapasite):base(renk)
  {
   y�k_kapasitesi = y�k_kapasite;
   this.aks_say�s� = aks_say�s�;
   Yolcu_kapasitesi = 2;
  }

  public override string durum()
  {
   string s = base.durum();
   if (y�k� > 0) 
    s += "Ara�ta " + y�k�.ToString() + " kg y�k var.";
   if (s�r�c�_ceza_puan� > 70) 
    s += "Bu arac�n s�r�c�s� bir trafik canavar�.";
   if (aks_say�s� > 0) 
    s += "Ara�ta " + aks_say�s�.ToString() + " aks var.";
   return s;
  }

 }
}
