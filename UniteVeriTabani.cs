
using System.Collections.Generic;


namespace SinavSistemi
{
    public class UniteVeriTabani:BaseClass<Unite>
    {
        VeriTabani veriTabani;
        public UniteVeriTabani()
        {
            veriTabani = new VeriTabani();
        }

        //Unite bilgilerini veritabanından çekmek
        public List<Unite> uniteListeGetir()
        {
            liste = new List<Unite>();
            komut = new System.Data.SqlClient.SqlCommand("select * from tblUnite");

            reader = veriTabani.liste(komut);

            while (reader.Read())
            {
                liste.Add(new Unite()
                {
                    uniteID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    uniteAdi = reader.IsDBNull(1) ? string.Empty : reader.GetString(1)

                });
            }
            reader.Close();
            veriTabani.BaglantiAyarla();
            return liste;
        }
    }
}
