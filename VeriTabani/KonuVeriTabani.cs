
using System.Collections.Generic;

namespace SinavSistemi
{
    public class KonuVeriTabani:BaseClass<Konu>
    {
        VeriTabani veriTabani;
        public KonuVeriTabani()
        {
            veriTabani = new VeriTabani();
        }

        // konuları veritabanından çekmek
        public List<Konu> konuListeGetir()
        {
            liste = new List<Konu>();
            komut = new System.Data.SqlClient.SqlCommand("select * from tblKonu");
           // komut.Parameters.AddWithValue("@uniteID", uniteID);
            
            reader = veriTabani.liste(komut);

            while (reader.Read())
            {
                liste.Add(new Konu()
                {
                    konuID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    uniteID = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                    konuAdi = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),

                });
            }
            reader.Close();
            veriTabani.BaglantiAyarla();
            return liste;
        }

        //Seçilen konun bilgilerini veritabanından çekmek
        public Konu konuBilgiGetir(string konuAdi)
        {
            data = new Konu();
            komut = new System.Data.SqlClient.SqlCommand("select * from tblKonu where konuAdi=@konuAdi");
            komut.Parameters.AddWithValue("@konuAdi", konuAdi);
            reader = veriTabani.liste(komut);
            while (reader.Read())
            {
                data.konuID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                data.uniteID = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                data.konuAdi = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
            };
            reader.Close();
            veriTabani.BaglantiAyarla();
            return data;
        }
    }
}
