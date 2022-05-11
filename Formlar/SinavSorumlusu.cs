using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class SinavSorumlusu : Form
    {
        Kullanici kullanici;
        Form T;
        public SinavSorumlusu(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
        }

        
        private void SinavSorumlusu_Load(object sender, EventArgs e)
        {
            labelAd.Text = kullanici.ad;
            labelSoyad.Text = kullanici.soyAd;

        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SoruEkle"] != null)
            {
                T = Application.OpenForms["SoruEkle"];
                T.Focus();
            }
            else
            {
                T = new SoruEkle();
                T.MdiParent = this;
                T.Show();
            }
        }

        private void buttonSoruListele_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SoruListele"] != null)
            {
                T = Application.OpenForms["SoruListele"];
                T.Focus();
            }
            else
            {
                T = new SoruListele();
                T.MdiParent = this;
                T.Show();
            }
        }
    }
}
