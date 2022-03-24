using System;
using System.Collections.Generic;
using System.Text;

namespace SinavSistemi
{
    class Kullanici
    {
        public string ad { get; set; }
        public string soyAd { get; set; }
        public string eMailAdresi { get; set; }
        public string sifre { get; set; }
        int kullaniciID { get; set; }
        public string kullaniciAdi { get; set; }
        public int kullaniciTipiID { get; set; }
        enum kullaniciTipiAdi { Ogrenci, Admin, SinavSorumlusu}

        //0'dan başlatır.
    }
}
