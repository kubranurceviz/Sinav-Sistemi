using System;
using System.Collections.Generic;
using System.Text;

namespace SinavSistemi
{
    internal class BLL
    {
        VeriTabani veriTabani;
        public BLL()
        {
            veriTabani = new VeriTabani();
        }
        public int SistemGirisKontrol(string kullaniciAdi, string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                return veriTabani.SistemGirisKontrol(new Kullanici()
                {
                    kullaniciAdi = kullaniciAdi,
                    sifre = sifre
                });
            }
            else
            {
                return -1;
            }

        }
        public int KullaniciKayitEKLE(string kullaniciAdi, string ad, string soyAd, string eMailAdresi, string sifre)
        {

            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre) && !string.IsNullOrEmpty(eMailAdresi))
            {
                return veriTabani.KullaniciKayitEKLE(new Kullanici()
                {
                    kullaniciAdi = kullaniciAdi,
                    sifre = sifre,
                    eMailAdresi = eMailAdresi,
                    soyAd = soyAd,
                    ad = ad
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
                return veriTabani.KullaniciSifreCekme(new Kullanici()
                {

                    eMailAdresi = eMailAdresi,

                });
            }
            else
            {
                return "Hatalı değer girişi yaptınız";

            }

        }

    }
}
