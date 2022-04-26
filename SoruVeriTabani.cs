

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

    }
}
