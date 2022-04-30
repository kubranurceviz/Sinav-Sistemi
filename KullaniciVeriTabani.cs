
using System.Data;
using System.Data.SqlClient;


namespace SinavSistemi
{
    public class KullaniciVeriTabani:BaseClass<Kullanici>
    {
        VeriTabani veriTabani;
        public KullaniciVeriTabani()
        {
            veriTabani = new VeriTabani();
        }

            public Kullanici SistemGirisKontrol(string kullaniciAdi)
            {
                data = new Kullanici();
                komut = new SqlCommand("select * from tblKullanici where kullaniciAdi = @kullaniciAdi");
                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
               
               reader=veriTabani.liste(komut); 
             while (reader.Read())
            {
                data.kullaniciID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                data.kullaniciAdi= reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                data.ad=reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                data.soyAd=reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                data.eMailAdresi=reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                data.sifre=reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                data.kullaniciTipiID=reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
            }
          
            reader.Close();
            veriTabani.BaglantiAyarla();
            return data;


        }
            public int KullaniciKayitEKLE(Kullanici kullanici)
            {


                komut = new SqlCommand("Insert into tblKullanici (kullaniciAdi,ad,soyAd,eMailAdresi,sifre,kullaniciTipiID) values (@kullaniciAdi,@ad,@soyAd,@eMailAdresi,@sifre,@kullaniciTipiID)");

                komut.Parameters.Add("@kullaniciAdi", SqlDbType.NVarChar).Value = kullanici.kullaniciAdi;
                komut.Parameters.Add("@ad", SqlDbType.NVarChar).Value = kullanici.ad;
                komut.Parameters.Add("@soyAd", SqlDbType.NVarChar).Value = kullanici.soyAd;
                komut.Parameters.Add("@eMailAdresi", SqlDbType.NVarChar).Value = kullanici.eMailAdresi;
                komut.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = kullanici.sifre;
                komut.Parameters.Add("@kullaniciTipiID",SqlDbType.Int).Value=kullanici.kullaniciTipiID;

                return veriTabani.ekleDuzenleSil(komut);

            }

            public string KullaniciSifreCekme(Kullanici kullanici)
            {
                string deger = string.Empty;
                komut = new SqlCommand("select sifre from tblKullanici where eMailAdresi = @eMailAdresi");
                komut.Parameters.AddWithValue("@eMailAdresi", kullanici.eMailAdresi);

                deger = (string)veriTabani.kolonGetir(komut);

                return deger;
            }
        }
    }

