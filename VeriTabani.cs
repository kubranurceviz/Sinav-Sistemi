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
        object donusobj;

        public VeriTabani()
        {                                  //kullanılan database değişecek
            baglanti = new SqlConnection(@"Data Source=ZBETUL\SQLEXPRESS;Initial Catalog=Deneme;Integrated Security=True");
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

            return komut.ExecuteReader();
        }

        public object kolonGetir(SqlCommand komut)
        {
            komut.Connection = baglanti;
            BaglantiAyarla();
            donusobj = komut.ExecuteScalar();
            BaglantiAyarla();
            return donusobj;
        }

    }
}

