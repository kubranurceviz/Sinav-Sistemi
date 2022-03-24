using System;
using System.Collections.Generic;
using System.Text;

namespace SinavSistemi
{
    class Test : ITest
    {
        public int testID { get; set; }
        public int soruSayisi { get; set; }
        public int testSuresi { get; set; }

        List<Soru> test = new List<Soru>();


        List<string> cevapAnahtari = new List<string>();
    }
}
