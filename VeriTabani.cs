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
        SqlCommand komut;
        int donusdegeri;
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
        public int SistemGirisKontrol(Kullanici kullanici)
        {
            komut = new SqlCommand("select count (*) from Kullanici where kullaniciAdi = @kullaniciAdi  and sifre = @sifre", baglanti);
            komut.Parameters.AddWithValue("@kullaniciAdi", kullanici.kullaniciAdi);
            komut.Parameters.AddWithValue("@sifre", kullanici.sifre);
            BaglantiAyarla();
            donusdegeri = (int)komut.ExecuteScalar();
            BaglantiAyarla();
            return donusdegeri;
        }
        public int KullaniciKayitEKLE(Kullanici kullanici)
        {


            string sorgu = "Insert into Kullanici (kullaniciAdi,ad,soyAd,eMailAdresi,sifre) values (@kullaniciAdi,@ad,@soyAd,@eMmailAdresi,@sifre)";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.Add("@kulaniciAdi", SqlDbType.NVarChar).Value = kullanici.kullaniciAdi;

            komut.Parameters.Add("@ad", SqlDbType.NVarChar).Value = kullanici.ad;

            komut.Parameters.Add("@soyAd", SqlDbType.NVarChar).Value = kullanici.soyAd;

            komut.Parameters.Add("@eMailAdresi", SqlDbType.NVarChar).Value = kullanici.eMailAdresi;

            komut.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = kullanici.sifre;

            BaglantiAyarla();

            donusdegeri = komut.ExecuteNonQuery();

            BaglantiAyarla();
            return donusdegeri;


        }
        public string KullaniciSifreCekme(Kullanici kullanici)
        {
            string deger = string.Empty;
            komut = new SqlCommand("select * from Kullanici where  eMailAdresi = @eMailAdresi", baglanti);
            komut.Parameters.AddWithValue("@eMailAdresi", kullanici.eMailAdresi);
            BaglantiAyarla();
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                deger = reader["sifre"].ToString();
            }
            reader.Close();
            BaglantiAyarla();
            return deger;
        }

    }
}

