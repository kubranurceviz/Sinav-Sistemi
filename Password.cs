using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class Password : Form
    {
        BLL bLL;
        public Password()
        {
            InitializeComponent();
            bLL = new BLL();
        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            string deger= string.Empty;
            if(!string.IsNullOrEmpty(textBox_mail.Text))
            {
                deger=bLL.KullaniciSifreCekme(textBox_mail.Text);
                if(textBox_mail.Text == deger)
                {
                    lbl_mesaj.Text = "Şifreniz : " + deger;
                    lbl_mesaj.Visible = true;
                }
                else
                {
                    MessageBox.Show(deger,"Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hatalı ya da eksik parametre girdiniz. Lütfen tekrar deneyiniz!");
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            LOGIN lOGIN = new LOGIN();
            lOGIN.Show();
            
        }
    }
}
