using System;
using System.Collections.Generic;
using System.Text;

namespace SinavSistemi
{
    class Soru: ISoru
    {
        public int soruID { get; set; }

        public string soruMetni { get; set; }
        public int konuID { get; set; }
        public int uniteID { get; set; }

        public string resimYolu { get; set; }
        public string dogruCevap { get; set; }

        public List<string> yanlisCevaplar = new List<string>();









    }
}
