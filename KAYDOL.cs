using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class KAYDOL : Form
    {
        BLL bLL;
        public KAYDOL()
        {
            InitializeComponent();
            bLL = new BLL();
        }

        private void KAYDOL_Load(object sender, EventArgs e)
        {

        }

        private void button_kaydol_Click(object sender, EventArgs e)
        {
            int deger;
          deger = bLL.KullaniciKayitEKLE(textBox_kullaniciad.Text, textBox_Ad.Text, textBox_Soyad.Text, textBox_mail.Text, textBox_password.Text);
            if(deger>0)
            {
                MessageBox.Show("Kaydolma işleminiz Başarılı bir şekilde gerçekleşti");
            }
            else
            {
                MessageBox.Show("Hatalı veya eksik parametre girişi yaptınız. Lütfen tekrar deneyiniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            LOGIN lOGIN = new LOGIN();
            lOGIN.Show();
        }
    }
}
