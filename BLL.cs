
using System.Collections.Generic;

namespace SinavSistemi
{
    public class BLL
    {
        KullaniciVeriTabani kullaniciVeriTabani;
        SoruVeriTabani soruVeriTabani;
        KonuVeriTabani konuVeriTabani;
        UniteVeriTabani uniteVeriTabani;
        public BLL()
        {
            kullaniciVeriTabani = new KullaniciVeriTabani();
            soruVeriTabani = new SoruVeriTabani();
            konuVeriTabani =new KonuVeriTabani();
            uniteVeriTabani =new UniteVeriTabani();
            
        }
        public Kullanici SistemGirisKontrol(string kullaniciAdi)
        {
                
                return kullaniciVeriTabani.SistemGirisKontrol(kullaniciAdi);

        }
        public int KullaniciKayitEKLE(string kullaniciAdi, string ad, string soyAd, string eMailAdresi, string sifre,int kullaniciTipiID)
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
        public string KullaniciSifreCekme(string eMailAdresi)
        {
            if (!string.IsNullOrEmpty(eMailAdresi))
            {
                return kullaniciVeriTabani.KullaniciSifreCekme(new Kullanici()
                {

                    eMailAdresi = eMailAdresi,

                });
            }
            else
            {
                return "Hatalı değer girişi yaptınız";

            }

        }
        public int SoruKayitEkle(int soruID, string soruMetni, int konuID, int uniteID, string resimYolu, string dogruCevap, string yanlisCevap1, string yanlisCevap2, string yanlisCevap3)
        {
            return soruVeriTabani.SoruKayitEkle(
                new Soru()
                {
                    soruID = soruID,
                    soruMetni = soruMetni,
                    konuID = konuID,
                    uniteID = uniteID,
                    resimYolu = resimYolu,
                    dogruCevap = dogruCevap,
                    yanlisCevap1 = yanlisCevap1,
                    yanlisCevap2 = yanlisCevap2,
                    yanlisCevap3 = yanlisCevap3,
                }
                );
        }
        public Konu konuBilgiGetir(string konuAdi)
        {
            return konuVeriTabani.konuBilgiGetir(konuAdi);

        }
        public List<Konu> konuListeGetir(int uniteID)
        {
            return konuVeriTabani.konuListeGetir(uniteID);
        }
        public List<Unite> uniteListeGetir()
        {
            return uniteVeriTabani.uniteListeGetir();
        }

    }
}
