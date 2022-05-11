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

            Kullanici kullanici=bLL.SistemGirisKontrol(string.Empty,textBoxmail.Text);
            labelSifre.Visible = true;
            labelSifre.Text = "Şifreniz: " + kullanici.sifre;
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

        private void Sifre_Load(object sender, EventArgs e)
        {

        }
    }
}
