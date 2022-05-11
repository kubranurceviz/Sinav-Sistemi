using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class SoruEkle : Form
    {
        BLL bLL;
        List<string> listunite = new List<string>();    
        public SoruEkle()
        {
            InitializeComponent();
            bLL = new BLL();
            
        }

        private void textBoxMetin_MouseClick(object sender, MouseEventArgs e)
        {

            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
            textBox.ForeColor = Color.Black;
        }
        private void buttonKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void linkLabelResim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialogResim1.ShowDialog();
            textResimEkle.Text = openFileDialogResim1.FileName;
        }
        private void SoruEkle_Load(object sender, EventArgs e)
        {
            listunite = bLL.aa();

            for (int i=0; i<listunite.Count;i++)
            {
                comboBoxUnite.Items.Add(listunite[i]);
            }
        }
        private void comboBoxUnite_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKonu.Enabled = true;
            listunite = bLL.bb(comboBoxUnite.SelectedIndex + 1);

            for (int i = 0; i < listunite.Count; i++)
            {
                comboBoxKonu.Items.Add(listunite[i]);
            }

        }
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
          int  sonuc = bLL.SoruKayitEkle(int.Parse(textBoxSoruID.Text),comboBoxKonu.Text,textBoxMetin.Text, textResimEkle.Text, textBoxDogruSecenek.Text, textBoxYanlis1.Text, textBoxYanlis2.Text, textBoxYanlis3.Text);
            if(sonuc>0)
            {
                MessageBox.Show("Soru Başarılı bir şekilde kaydedildi...","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                bLL.SoruKullaniciTablo(int.Parse(textBoxSoruID.Text));
            }
            else
            {
                MessageBox.Show("Soru kaydedilememiştir. \nLütfen tekrar deneyiniz!","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
