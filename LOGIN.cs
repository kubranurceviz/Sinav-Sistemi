using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class LOGIN : Form
    {
        BLL bLL;
        public LOGIN()
        {
            InitializeComponent();
            bLL = new BLL();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btn_grs_yap_Click(object sender, EventArgs e)
        {
            int deger;

            if(!string.IsNullOrEmpty(textBox_kullaniciad.Text) && !string.IsNullOrEmpty(textBox_password.Text))
            {
                deger = bLL.SistemGirisKontrol(textBox_kullaniciad.Text,textBox_password.Text);
                if(deger>0)
                {
                    OgrenciAnaForm ogrenciAnaForm = new OgrenciAnaForm();
                    ogrenciAnaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı ya da eksik parametre girdiniz. Lütfen tekrar deneyiniz!","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Eksik parametre girdiniz. Lütfen tekrar deneyiniz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void linkLabel_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Password password = new Password();
            password.Show();

        }

        private void linkLabel_kaydol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KAYDOL kaydol = new KAYDOL();   
            kaydol.Show();
        }
    }
}
