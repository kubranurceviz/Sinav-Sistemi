using System;
using System.Collections.Generic;
using System.Text;

namespace SinavSistemi
{
    class SoruFabrikası
    {
        public ISoru SoruNesnesiOlustur()
        {
            return new Soru();
        }
    }
}
