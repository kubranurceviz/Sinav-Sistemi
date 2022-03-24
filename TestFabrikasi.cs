using System;
using System.Collections.Generic;
using System.Text;

namespace SinavSistemi
{
    class TestFabrikasi
    {
        public ITest TestNesnesiOlustur()
        {
            return new Test();
        }
    }
}
