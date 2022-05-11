using SinavSistemi.Formlar;
using System;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class OgrenciAnaForm : Form
    {
        Kullanici kullanici;
        Form T;
        
        public OgrenciAnaForm(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OgrenciAnaForm_Load(object sender, EventArgs e)
        {
            labelAd.Visible = true;
            labelSoyad.Visible = true;
            labelAd.Text = kullanici.ad;
            labelSoyad.Text = kullanici.soyAd;
         
        }

       
        private void buttonBasla_Click(object sender, EventArgs e)
        {
           
            buttonSonucEkran.Enabled = false;
            if (Application.OpenForms["SINAV"] != null)
            {
                T = Application.OpenForms["SINAV"];
                T.Focus();
            }
            else
            {
                T = new SINAV(kullanici);
                T.MdiParent = this;
                T.Show();
            }
       
            
        }

        private void buttonSonucEkran_Click(object sender, EventArgs e)
        {
         
                if (Application.OpenForms["SonucEkran"] != null)
                {
                    T = Application.OpenForms["SonucEkran"];
                    T.Focus();
                }
                else
                {
                    T = new SonucEkran(kullanici);
                    T.MdiParent = this;
                    T.Show();
                }
           
        }

        

  

        private void panelOgrAnaFrm_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (Control control in panelOgrAnaFrm.Controls)
            {
                if (Application.OpenForms["SINAV"] == null)
                {
                    buttonSonucEkran.Enabled = true;
                }
            }

        }
    }
}
