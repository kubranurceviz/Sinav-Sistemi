using SinavSistemi.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class SINAV : Form
    {
        BLL bLL;
        Soru soru = new Soru();
        Kullanici kullanici;
        Timer timer;

        List<Soru> CozulenSorular=new List<Soru>();
        public SINAV(Kullanici kullanici)
        {
            InitializeComponent();
            bLL = new BLL();
            this.kullanici = kullanici;
        }
 
        private void SINAV_Load(object sender, EventArgs e)
        {
            bLL.SoruAyarla(kullanici.kullaniciID);
        }
        int saniye = 0;
        int dakika = 0;
        int sayac = 0;

     
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(sayac==0)
            {
                dakika = bLL.testSorular.Count-1;
                timer = new Timer();
                timer.Tick += Timer_Tick;
                timer.Interval = 1000;
                saniye = 60;
                timer.Start();

            }

             buttonNext.Location = new System.Drawing.Point(670, 547);
             buttonNext.Size = new System.Drawing.Size(150, 50);
             buttonNext.Text = "Sonraki";
             kontrolDonguleri(true);
             panel1.Visible = true;
             buttonCikis.Visible = true;

            int sayi = 0;
            if (sayac < bLL.testSorular.Count)
                {
                    soruGoster();
                }

                else
                {
                    timer.Dispose();
                    timer.Stop();
                   sayi += bLL.CozulenSoru(kullanici.kullaniciID, CozulenSorular);
                    if (sayi > 0)
                    {
                        kontrolDonguleri(false);
                        labelKonum("SINAVINIZ GÖNDERİLDİ \n         BAŞARILAR...");
                    }
                    else
                    {
                        kontrolDonguleri(false);
                        labelKonum("SINAVINIZ GÖNDERİLEMEDİ!");

                    }

                }
            
            sayac++;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            saniye--;
            if(saniye<0)
            {
                dakika--;
                saniye = 59;
                
            }

            if(saniye<=0 && dakika<=0)
            {
                lblDakika.Text = $"{00} : {00}";
                timer.Dispose();
                timer.Stop();
                timer.Dispose();
                timer.Stop();

               kontrolDonguleri(false);
               labelKonum("SINAVINIZ GÖNDERİLEMEDİ!");
           
              
            }
            else
            {
                lblDakika.Text = $"{dakika}dk : {saniye}sn";
            }
            
        }

        public void soruGoster()
        {
                int[] diziSecenek = bLL.dizisira(4);
                string[] cevap = new string[4];
                soru = bLL.SoruBilgileriniCekme(kullanici.kullaniciID,sayac);
                labelSoruNo.Text = soru.soruID.ToString() + $"  {sayac + 1}";
                lblSoruMetni.Text = soru.soruMetni;
                cevap[0] = soru.yanlisCevap1;
                cevap[1] = soru.yanlisCevap2;
                cevap[2] = soru.yanlisCevap3;
                cevap[3] = soru.dogruCevap;
                radioButton1.Text = cevap[diziSecenek[0] - 1];
                radioButton2.Text = cevap[diziSecenek[1] - 1];
                radioButton3.Text = cevap[diziSecenek[2] - 1];
                radioButton4.Text = cevap[diziSecenek[3] - 1];
                pictureBox1.ImageLocation = soru.resimYolu;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                soru.cozumTarih = DateTime.Now;
            
               
            foreach (Control control in this.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Checked)
                    {
                        radioButton.Checked = false;
                    }
                }
            }
        }
    
        public void kontrolDonguleri(bool ackapa)
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = ackapa;
            }

        }
        public void labelKonum(string mesaj)
        {
            label1.Visible = true;
            label1.Location = new System.Drawing.Point(300, 280);
            label1.Font = new System.Drawing.Font("Century", 16);
            label1.Text = mesaj;
            panel1.Visible = true;
            buttonCikis.Visible = true;
        }      
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                if (radio.Text == soru.dogruCevap)
                {
                    soru.cozulduMu = true;
                    soru.dogruCozum += 1;
                }
                else
                {
                    soru.cozulduMu = false;
                    soru.dogruCozum = 0;
                }
            }
            CozulenSorular.Add(new Soru()
            {
                soruID = soru.soruID,
                cozulduMu = soru.cozulduMu,
                cozumTarih = soru.cozumTarih,
                dogruCozum = soru.dogruCozum,
            });

        }
    }
 }

