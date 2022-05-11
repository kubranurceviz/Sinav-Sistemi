using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SinavSistemi.Formlar
{
    public partial class SonucEkran : Form
    {

        BLL bLL;
 
        Kullanici kullanici;
        public SonucEkran(Kullanici kullanici)
        {
            InitializeComponent();
            bLL = new BLL();
            this.kullanici = kullanici;
          
        }
     
        private void buttonSonuc_Click(object sender, EventArgs e)
        {
            buttonSonuc.Visible = false;
            label1.Visible = true;
            label1.Location = new System.Drawing.Point(100, 200);
            label1.Text = bLL.dogruSonuc(kullanici.kullaniciID);
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

       
    }
}
