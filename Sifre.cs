using System;
using System.Drawing;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class Sifre : Form
    {
        BLL bLL;
        public Sifre()
        {
            InitializeComponent();
            bLL = new BLL();
        }

  
        private void buttonGoster_Click(object sender, EventArgs e)
        {

            string sifre=bLL.KullaniciSifreCekme(textBoxmail.Text);
            labelSifre.Visible = true;
            labelSifre.Text = "Şifreniz: " + sifre;
        }

        private void buttoncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
        private void textBoxmail_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
            textBox.ForeColor = Color.Black;
        }

       
    }
}
