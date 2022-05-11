using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class LOGIN : Form
    {
        BLL bLL;
        Kullanici kullanici = new Kullanici();
        public LOGIN()
        {
            InitializeComponent();
            bLL = new BLL();

        }
        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void textKullaniciAd_MouseClick(object sender, MouseEventArgs e)
        {

            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
            textBox.ForeColor = Color.Black;
        }

        private void textSifre_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
            textBox.ForeColor = Color.Black;
            textBox.PasswordChar = '*';
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            kullanici = bLL.SistemGirisKontrol(textKullaniciAd.Text,string.Empty);

            if (kullanici.kullaniciAdi == textKullaniciAd.Text && kullanici.sifre == textSifre.Text)
            {
                switch (kullanici.kullaniciTipiID)
                {
                    case 1:
                        OgrenciAnaForm ogrenciAnaForm = new OgrenciAnaForm(kullanici);
                        ogrenciAnaForm.Show();
                        this.Hide();
                        break;
                    case 2:
                        SinavSorumlusu sinavSorumlusu = new SinavSorumlusu(kullanici);
                        sinavSorumlusu.Show();
                        this.Hide();
                        
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            }

        }

        private void linkLabelSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sifre sifre = new Sifre();
            sifre.Show();

        }

        private void buttonKaydol_Click(object sender, EventArgs e)
        {
            int tip = 0;
            if (radioButtonOgr.Checked)
                tip = 1;
            else if (radioButtonSSorumlu.Checked)
                tip = 2;
            else if (radioBtnAdmin.Checked)
                tip = 3;
            else
                MessageBox.Show("Kullanıcı Tipinizi Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            int sonuc = bLL.KullaniciKayitEKLE(textKaydolKullanici.Text, textBoxAd.Text, textBoxSoyad.Text, textBoxEmail.Text, textKaydolSifre.Text, tip);

            if (sonuc > 0)
            {
                Kullanici kullanici = bLL.SistemGirisKontrol(textKaydolKullanici.Text,textBoxEmail.Text);
                if (kullanici.kullaniciTipiID==1)
                {
                   
                        bLL.KullaniciSoruTablo(kullanici.kullaniciID);
                    

                }
                MessageBox.Show("Başarılı bir şekilde kaydoldunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
            else
            {
                MessageBox.Show("Kaydolma işleminiz gerçekleşemedi \n Lütfen tekrar deneyiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBoxGiris_Enter(object sender, EventArgs e)
        {

        }
    }
}
    

