

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SinavSistemi
{
    public class SoruVeriTabani:BaseClass<Soru>
    {
        VeriTabani veriTabani;
        public SoruVeriTabani()
        {
            veriTabani = new VeriTabani();
        }

        public int SoruKayitEkle(Soru soru)
        {

            komut = new SqlCommand("Insert into tblSoru (soruID,soruMetni,konuID,uniteID,resimYolu,dogruCevap,yanlisCevap1,yanlisCevap2,yanlisCevap3) values (@soruID,@soruMetni,@konuID,@uniteID,@resimYolu,@dogruCevap,@yanlisCevap1,@yanlisCevap2,@yanlisCevap3)");

            komut.Parameters.AddWithValue("@soruID", soru.soruID);
            komut.Parameters.AddWithValue("@soruMetni", soru.soruMetni);
            komut.Parameters.AddWithValue("@konuID", soru.konuID);
            komut.Parameters.AddWithValue("@uniteID", soru.uniteID);
            komut.Parameters.AddWithValue("@resimYolu", soru.resimYolu);
            komut.Parameters.AddWithValue("@dogruCevap", soru.dogruCevap);
            komut.Parameters.AddWithValue("@yanlisCevap1", soru.yanlisCevap1);
            komut.Parameters.AddWithValue("@yanlisCevap2", soru.yanlisCevap2);
            komut.Parameters.AddWithValue("@yanlisCevap3", soru.yanlisCevap3);
          

            return veriTabani.ekleDuzenleSil(komut);
        }
        public List<Soru> SoruListesiTumGetir()
        {
            liste = new List<Soru>();
            komut = new SqlCommand("select * from tblSoru");
            
            reader = veriTabani.liste(komut);
            while (reader.Read())
            {
                liste.Add(new Soru()
                {
                    soruMetni = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    soruID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    dogruCevap = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                    resimYolu = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    konuID = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                    uniteID = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                    yanlisCevap1 = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                    yanlisCevap2 = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                    yanlisCevap3 = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                  

                });
            }
            reader.Close();
            veriTabani.BaglantiAyarla();
            return liste;
        }
        public Soru SoruBilgileriniCekme(int soruID,int kullaniciID)
        {
            data = new Soru();
            komut = new SqlCommand("select * from tblSoru inner join tblSoru_Kullanici  on tblSoru.soruID = tblSoru_Kullanici.soruID where tblSoru_Kullanici.kullaniciID=@kullaniciID and tblSoru_Kullanici.soruID = @soruID");
            komut.Parameters.AddWithValue("@soruID", soruID);
            komut.Parameters.AddWithValue("@kullaniciID", kullaniciID);
            reader= veriTabani.liste(komut);
            while (reader.Read())
            {

                data.soruMetni = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                data.soruID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                data.dogruCevap = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                data.resimYolu = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                data.konuID = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                data.uniteID= reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                data.yanlisCevap1 = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                data.yanlisCevap2 = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                data.yanlisCevap3 = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                data.cozulduMu = (bool)(reader.IsDBNull(11) ? false : reader.GetValue(11));
                data.cozumTarih = reader.IsDBNull(12) ? Convert.ToDateTime("01.01.1999") : (DateTime)reader.GetValue(12);
                data.dogruCozum = reader.IsDBNull(13) ? 0 : reader.GetInt32(13);
            }
            reader.Close();
            veriTabani.BaglantiAyarla();

            return data;

        }
        public List<Soru> SoruListesiGetir(int kullaniciID)
        {
            liste=new List<Soru>();
            komut = new SqlCommand("select * from tblSoru inner join tblSoru_Kullanici on tblSoru.soruID = tblSoru_Kullanici.soruID where tblSoru_Kullanici.kullaniciID=@kullaniciID");
            komut.Parameters.AddWithValue("@kullaniciID", kullaniciID);
            reader = veriTabani.liste(komut);
            while(reader.Read())
            {
                liste.Add(new Soru()
                {
                    soruMetni = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    soruID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    dogruCevap = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                    resimYolu = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    konuID = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                    uniteID = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                    yanlisCevap1 = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                    yanlisCevap2 = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                    yanlisCevap3 = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                    cozulduMu = (bool)(reader.IsDBNull(11) ? false : reader.GetValue(11)),
                    cozumTarih = reader.IsDBNull(12) ?  Convert.ToDateTime("01.01.1999") : (DateTime)reader.GetValue(12),
                    dogruCozum = reader.IsDBNull(13) ? 0 : reader.GetInt32(13),
                }) ;
            }
            reader.Close();
            veriTabani.BaglantiAyarla();
            return liste;
        }
        public int CozulenSoru(int kullaniciID, List<Soru> soru)
        {
            foreach (Soru s in soru)
            {
                komut = new SqlCommand("update tblSoru_Kullanici set cozulduMu = @cozulduMu,cozumTarih=@cozumTarih, dogruCozum=@dogruCozum where soruID = @soruID and kullaniciID=@kullaniciID");
                komut.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                komut.Parameters.AddWithValue("@soruID", s.soruID);
                komut.Parameters.AddWithValue("@cozulduMu", s.cozulduMu);
                komut.Parameters.AddWithValue("@cozumTarih", s.cozumTarih);
                komut.Parameters.AddWithValue("@dogruCozum", s.dogruCozum);

                donusdeger += veriTabani.ekleDuzenleSil(komut);
            }
            return donusdeger;
        }
        public int SoruKullaniciTablo(int soruID, List<Kullanici> kullanici)
       {
            foreach (Kullanici k in kullanici)
            {
                if (k.kullaniciTipiID == 1)
                {
                    komut = new SqlCommand("insert into tblSoru_Kullanici (kullaniciID,soruID,cozulduMu) values(@kullaniciID,@soruID,@cozulduMu)");
                    komut.Parameters.AddWithValue("@kullaniciID", k.kullaniciID);
                    komut.Parameters.AddWithValue("@soruID", soruID);
                    komut.Parameters.AddWithValue("@cozulduMu", false);
                    donusdeger += veriTabani.ekleDuzenleSil(komut);
                }
            }
            return donusdeger;
        }
    }
}
