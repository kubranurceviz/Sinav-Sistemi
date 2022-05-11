using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace SinavSistemi
{
    internal class VeriTabani
    {
        SqlConnection baglanti;
        int donusdegeri;
  
        public VeriTabani()
        {                                 
            baglanti = new SqlConnection(@"Data Source=ZBETUL\SQLEXPRESS;Initial Catalog=Sinav_Sistemi;Integrated Security=True");
        }
        public void BaglantiAyarla()
        {
            if (baglanti.State == System.Data.ConnectionState.Closed)
                baglanti.Open();
            else
                baglanti.Close();
        }

        public int ekleDuzenleSil(SqlCommand komut)
        {
            komut.Connection = baglanti;
            BaglantiAyarla();
            donusdegeri = komut.ExecuteNonQuery();
            BaglantiAyarla();
            return donusdegeri;
        }
        public SqlDataReader liste(SqlCommand komut)
        {
            komut.Connection = baglanti;
            BaglantiAyarla();
            return komut.ExecuteReader();
        }

    }
}

