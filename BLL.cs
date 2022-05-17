
using System;
using System.Collections.Generic;
using System.Linq;

namespace SinavSistemi
{
    public class BLL
    {
        KullaniciVeriTabani kullaniciVeriTabani;
        SoruVeriTabani soruVeriTabani;
        KonuVeriTabani konuVeriTabani;
        UniteVeriTabani uniteVeriTabani;
 
        List<Soru> Sorular;
        public List<Soru> testSorular;
        List<Soru> gelenSorular;

        int[] diziRastgele;
        public BLL()
        {
            kullaniciVeriTabani = new KullaniciVeriTabani();
            soruVeriTabani = new SoruVeriTabani();
            konuVeriTabani =new KonuVeriTabani();
            uniteVeriTabani =new UniteVeriTabani();
            testSorular = new List<Soru>();
        }

    
        public string dogruSonuc(int kullaniciID)
        {
            int dogruSayisi = 0;
            Sorular=soruVeriTabani.SoruListesiGetir(kullaniciID);
            List<Soru> dogruSorular = new List<Soru>();
            dogruSorular=(from list in Sorular where list.cozumTarih.Date==DateTime.Now.Date select list).ToList();
           
        
            foreach(Soru s in dogruSorular)
            {
                if(s.cozulduMu)
                {
                    dogruSayisi++;
                }
            }
            int yanlis = dogruSorular.Count - dogruSayisi;

            string mesaj= $"Sonuçlarınız  \nDoğru : {dogruSayisi} \nYanlış : {yanlis}";

            return mesaj;
         
        }
        public void SoruAyarla(int kullaniciID)
        {
            List<Soru> SigmaSorular=new List<Soru>();
            Sorular = soruVeriTabani.SoruListesiGetir(kullaniciID);
            gelenSorular = (from soru in Sorular where soru.cozulduMu == false select soru).ToList();

          foreach (Soru soru in Sorular)
          {
                if(soru.cozulduMu==true)
                {
                    TimeSpan ts = DateTime.Now.Date - soru.cozumTarih.Date;
                    if(soru.dogruCozum==1 && ts.TotalDays==1)
                    {
                        SigmaSorular.Add(soru);
                    }
                    else if(soru.dogruCozum==2 && ts.TotalDays==6)
                    {
                        SigmaSorular.Add(soru);
                    }
                    else if(soru.dogruCozum==3 && ts.TotalDays==23)
                    {
                        SigmaSorular.Add(soru);
                    }
                    else if(soru.dogruCozum==4 && ts.TotalDays==60)
                    {
                        SigmaSorular.Add(soru);
                    }
                    else if (soru.dogruCozum == 5 && ts.TotalDays == 90)
                    {
                        SigmaSorular.Add(soru);
                    }
                    else if (soru.dogruCozum == 4 && ts.TotalDays == 185)
                    {
                        SigmaSorular.Add(soru);
                    }
                }
            }



            
            if (gelenSorular.Count >= 10)
            {    
                diziRastgele = dizisira(gelenSorular.Count);
                for (int i = 0; i < 10; i++)
                {
                    testSorular.Add(gelenSorular[diziRastgele[i] - 1]);
                }
                testSorular.Concat(SigmaSorular);
                diziRastgele = dizisira(testSorular.Count);
            }
            else if (gelenSorular.Count > 0 && gelenSorular.Count < 10)
            {
                diziRastgele = dizisira(gelenSorular.Count);
                for (int i = 0; i < gelenSorular.Count; i++)
                {
                    testSorular.Add(gelenSorular[diziRastgele[i] - 1]);
                }
                testSorular.Concat(SigmaSorular);
                diziRastgele = dizisira(testSorular.Count);
            }
            else
            {
                for (int i = 0; i < SigmaSorular.Count; i++)
                {
                    testSorular.Add(SigmaSorular[i]);
                }
                diziRastgele = dizisira(testSorular.Count);
            }
        }
        public int rastgele(int boyut)
        {
            Random random = new Random();
            int sayi = random.Next(1, boyut + 1);
            return sayi;
        }
        public int[] dizisira(int boyut)
        {
            int[] dizi = new int[boyut];
            for (int i = 0; i < boyut; i++)
            {
                int sayi = rastgele(boyut);
                if (i == 0)
                {
                    dizi[i] = sayi;
                }
                else
                {
                    if (!dizi.Contains(sayi))
                    {
                        dizi[i] = sayi;
                    }
                    else
                    {
                        i--;
                    }
                }

            }


            return dizi;
        }
        public Soru SoruBilgileriniCekme(int kullaniciID,int sayac)
        {   
            Soru soru = new Soru();
            soru= testSorular.ElementAtOrDefault(diziRastgele[sayac] - 1);
            return soruVeriTabani.SoruBilgileriniCekme(soru.soruID,kullaniciID);
        }
        public int CozulenSoru(int kullaniciID, List<Soru> s)
        {
            return soruVeriTabani.CozulenSoru(kullaniciID, s);
        }
        public int SoruKayitEkle(int soruID,string konuAdi,string soruMetni, string resimYolu, string dogruCevap, string yanlisCevap1, string yanlisCevap2, string yanlisCevap3)
        {
            Konu konu=konuVeriTabani.konuBilgiGetir(konuAdi);
            return soruVeriTabani.SoruKayitEkle(
                new Soru()
                {
                    soruID = soruID,
                    soruMetni = soruMetni,
                    konuID = konu.konuID,
                    uniteID = konu.uniteID,
                    resimYolu = resimYolu,
                    dogruCevap = dogruCevap,
                    yanlisCevap1 = yanlisCevap1,
                    yanlisCevap2 = yanlisCevap2,
                    yanlisCevap3 = yanlisCevap3,

                });

        }
        public int SoruKullaniciTablo(int soruID)
        {
            List<Kullanici> list = kullaniciVeriTabani.KullaniciListeGetir();
            return soruVeriTabani.SoruKullaniciTablo(soruID, list);
        }
        public int KullaniciSoruTablo(int kullaniciID)
        {
            Sorular = soruVeriTabani.SoruListesiTumGetir();
            if (Sorular.Count > 0)
            {
                return kullaniciVeriTabani.KullaniciSoruTablo(kullaniciID, Sorular);
            }
            else
            {
                return -1;
            }
        }
        public Kullanici SistemGirisKontrol(string kullaniciAdi,string eMailAdresi)
       {
          
            return kullaniciVeriTabani.KullaniciGetir(kullaniciAdi,eMailAdresi);
         
       }
        public int KullaniciKayitEKLE(string kullaniciAdi, string ad, string soyAd, string eMailAdresi, string sifre, int kullaniciTipiID)
        {

            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre) && !string.IsNullOrEmpty(eMailAdresi))
            {
                return kullaniciVeriTabani.KullaniciKayitEKLE(new Kullanici()
                {
                    kullaniciAdi = kullaniciAdi,
                    sifre = sifre,
                    eMailAdresi = eMailAdresi,
                    soyAd = soyAd,
                    ad = ad,
                    kullaniciTipiID = kullaniciTipiID,

                });
            }
            else
            {
                return -1; //Eksik Parametre
            }

        }
        public List<string> aa()
        {
            List<Unite> list = uniteVeriTabani.uniteListeGetir();

            List<string> ahh = new List<string>();

            foreach(Unite unite in list)
            {
                ahh.Add(unite.uniteAdi);
            }
            return ahh;
        }
        public List<string> bb(int uniteID)
        {
            List<Konu> list = konuVeriTabani.konuListeGetir();

            List<string> ahh = new List<string>();

            foreach (Konu konu in list)
            {
                if(konu.uniteID==uniteID)
                {
                    ahh.Add(konu.konuAdi);
                }
            }
            return ahh;

        }

    }
}
