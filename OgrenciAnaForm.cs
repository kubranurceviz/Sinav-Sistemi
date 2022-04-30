using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            if (Application.OpenForms["SINAV"] != null)
            {
                T = Application.OpenForms["SINAV"];
                T.Focus();
            }
            else
            {
                T = new SINAV();
                T.MdiParent = this;
                T.Show();
            }
        }
    }
}
