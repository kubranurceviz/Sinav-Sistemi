using System;
using System.Collections.Generic;
using System.Text;

namespace SinavSistemi
{
    public class Soru
    {
        public int soruID { get; set; }
        public string soruMetni { get; set; }
        public int konuID { get; set; }
        public int uniteID { get; set; }
        public string resimYolu { get; set; }
        public string dogruCevap { get; set; }
        public string yanlisCevap1 { get; set; }
        public string yanlisCevap2 { get; set; }
        public string yanlisCevap3 { get; set; }
        public bool cozulduMu { get; set; }
        public DateTime cozumTarih{ get; set; }
        public int dogruCozum { get; set; }

    }
}
