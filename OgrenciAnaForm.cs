using SinavSistemi.Formlar;
using System;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class OgrenciAnaForm : Form
    {
        Kullanici kullanici;
        Form T;
        Test test= new Test();
        
        public OgrenciAnaForm(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
        }
        
        int saniye = 60;
        int dakika = 0;
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
            timer1.Start();
            dakika = test.soruSayisi;
            lblDakika.Text = "--";
            lblSaniye.Text = "--";
            lbl.Text = ":";
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
        private void timer1_Tick(object sender, EventArgs e)

        {
            timer1.Interval = 100;

            saniye = saniye - 1;
            lblSaniye.Text = Convert.ToString(saniye);
            lblDakika.Text = Convert.ToString(dakika - 1);
            if (saniye == 0)
            {

                dakika = dakika - 1;
                lblDakika.Text = Convert.ToString(dakika);
                saniye = 60;
            }

            if (lblDakika.Text == "-1")
            {
                timer1.Stop();
                lblDakika.Text = "00";
                lblSaniye.Text = "00";
                
            }
            lblDakika.Text = " ";
            lblSaniye.Text = " ";
            lbl.Text = " ";
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

