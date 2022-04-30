using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class SINAV : Form
    {
        BLL bLL;
        Soru soru = new Soru();
        List<Soru> soruList;
        int[] diziSoru;
        int[] diziRastgele;

        public SINAV()
        {
            InitializeComponent();
            bLL = new BLL();
            soruList = bLL.SoruListesiGetir();
        }

      
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SINAV_Load(object sender, EventArgs e)
        {
            diziSoru = (from sorudizi in soruList select sorudizi.soruID).ToArray();
            diziRastgele = dizisira(diziSoru.Length);
        }
        public int[] dizisira(int boyut)
        {
            int[] dizi = new int[boyut];
            for (int i = 0; i < boyut; i++)
            {
                int sayi = rastgele(boyut);
                if (i == 0)
                {
                    dizi[i] = sayi;
                }
                else
                {
                    if (!dizi.Contains(sayi))
                    {
                        dizi[i] = sayi;
                    }
                    else
                    {
                        i--;
                    }
                }

            }


            return dizi;
        }
      
        public int rastgele(int boyut)
        {
            Random random = new Random();
            int sayi = random.Next(1, boyut+1);
            return sayi;
        }

        int sayac = 0;
       
        private void buttonNext_Click(object sender, EventArgs e)
        {
            

            if (sayac == 0) 
            {
                buttonNext.Location= new System.Drawing.Point(650, 547);
                buttonNext.Size = new System.Drawing.Size(150, 50);
                buttonNext.Text = "Sonraki";

                foreach (Control control in this.Controls)
                {
                    Control next = control;
                    next.Visible = true;
                }
            }

            int[] diziSecenek = dizisira(4);
            if(sayac<5)
            {
                string[] cevap = new string[4];
                soru = bLL.SoruBilgileriniCekme(diziSoru[diziRastgele[sayac]-1]);
                labelSoruNo.Text = soru.soruID.ToString();
                lblSoruMetni.Text = soru.soruMetni;
                cevap[0] = soru.yanlisCevap1;
                cevap[1] = soru.yanlisCevap2;
                cevap[2] = soru.yanlisCevap3;
                cevap[3] = soru.dogruCevap;
                radioButton1.Text = cevap[diziSecenek[0] - 1].ToString();
                radioButton2.Text = cevap[diziSecenek[1] - 1].ToString();
                radioButton3.Text = cevap[diziSecenek[2] - 1].ToString();
                radioButton4.Text = cevap[diziSecenek[3] - 1].ToString();
                pictureBox1.ImageLocation = soru.resimYolu;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else
            {
                buttonNext.Location = new System.Drawing.Point(368, 285);
                buttonNext.Size = new System.Drawing.Size(173, 81);
                buttonNext.Text = "SINAVI GÖNDER";
                foreach (Control control in this.Controls)
                {
                    Control next = control;
                    if(!(next is Button))
                    {
                        next.Visible = false;
                    }
                    
                }
            }

            sayac++;
        }


    }
}
