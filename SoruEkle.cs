using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class SoruEkle : Form
    {
        BLL bLL;
        List<Konu> listekonu;
        List<Unite> listunite;
        string _konu;
        public SoruEkle()
        {
            InitializeComponent();
            bLL = new BLL();
            listunite = bLL.uniteListeGetir();
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
            foreach (Unite unite in listunite)
            {
                comboBoxUnite.Items.Add(unite.uniteAdi);
            }
        }

        private void comboBoxUnite_SelectedIndexChanged(object sender, EventArgs e)
        {
            listekonu = bLL.konuListeGetir(comboBoxUnite.SelectedIndex + 1);

            foreach (Konu konu in listekonu)
            {
                comboBoxKonu.Items.Add(konu.konuAdi);
            }

        }

        private void comboBoxKonu_SelectedIndexChanged(object sender, EventArgs e)
        {
            _konu= comboBoxKonu.Text;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            Konu konu = bLL.konuBilgiGetir(_konu);
            int sonuc;
            sonuc=bLL.SoruKayitEkle(int.Parse(textBoxSoruID.Text), textBoxMetin.Text, konu.konuID,konu.uniteID, textResimEkle.Text, textBoxDogruSecenek.Text, textBoxYanlis1.Text, textBoxYanlis2.Text, textBoxYanlis3.Text);
            if(sonuc>0)
            {
                MessageBox.Show("Soru Başarılı bir şekilde kaydedildi...","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Soru kaydedilememiştir. \nLütfen tekrar deneyiniz!","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
