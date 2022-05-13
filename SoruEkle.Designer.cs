namespace SinavSistemi
{
    partial class SoruEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoruEkle));
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.textBoxDogruSecenek = new System.Windows.Forms.TextBox();
            this.textBoxYanlis1 = new System.Windows.Forms.TextBox();
            this.textBoxYanlis2 = new System.Windows.Forms.TextBox();
            this.comboBoxUnite = new System.Windows.Forms.ComboBox();
            this.comboBoxKonu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSoruID = new System.Windows.Forms.TextBox();
            this.textBoxYanlis3 = new System.Windows.Forms.TextBox();
            this.textBoxMetin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textResimEkle = new System.Windows.Forms.TextBox();
            this.linkLabelResim = new System.Windows.Forms.LinkLabel();
            this.openFileDialogResim1 = new System.Windows.Forms.OpenFileDialog();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Controls.Add(this.buttonKapat);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(871, 23);
            this.panel4.TabIndex = 3;
            // 
            // buttonKapat
            // 
            this.buttonKapat.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKapat.BackgroundImage")));
            this.buttonKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKapat.Location = new System.Drawing.Point(845, 0);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(26, 23);
            this.buttonKapat.TabIndex = 0;
            this.buttonKapat.UseVisualStyleBackColor = false;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // textBoxDogruSecenek
            // 
            this.textBoxDogruSecenek.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxDogruSecenek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDogruSecenek.ForeColor = System.Drawing.Color.Black;
            this.textBoxDogruSecenek.Location = new System.Drawing.Point(335, 45);
            this.textBoxDogruSecenek.Name = "textBoxDogruSecenek";
            this.textBoxDogruSecenek.Size = new System.Drawing.Size(327, 22);
            this.textBoxDogruSecenek.TabIndex = 5;
            this.textBoxDogruSecenek.Text = "Lütfen doğru seçeneği buraya giriniz";
            this.textBoxDogruSecenek.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMetin_MouseClick);
            // 
            // textBoxYanlis1
            // 
            this.textBoxYanlis1.BackColor = System.Drawing.Color.SkyBlue;
            this.textBoxYanlis1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYanlis1.ForeColor = System.Drawing.Color.Black;
            this.textBoxYanlis1.Location = new System.Drawing.Point(383, 102);
            this.textBoxYanlis1.Name = "textBoxYanlis1";
            this.textBoxYanlis1.Size = new System.Drawing.Size(303, 22);
            this.textBoxYanlis1.TabIndex = 5;
            this.textBoxYanlis1.Text = "yanlış seçenek";
            this.textBoxYanlis1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMetin_MouseClick);
            // 
            // textBoxYanlis2
            // 
            this.textBoxYanlis2.BackColor = System.Drawing.Color.SkyBlue;
            this.textBoxYanlis2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYanlis2.ForeColor = System.Drawing.Color.Black;
            this.textBoxYanlis2.Location = new System.Drawing.Point(383, 156);
            this.textBoxYanlis2.Name = "textBoxYanlis2";
            this.textBoxYanlis2.Size = new System.Drawing.Size(303, 22);
            this.textBoxYanlis2.TabIndex = 5;
            this.textBoxYanlis2.Text = "yanlış seçenek";
            this.textBoxYanlis2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMetin_MouseClick);
            // 
            // comboBoxUnite
            // 
            this.comboBoxUnite.BackColor = System.Drawing.Color.SkyBlue;
            this.comboBoxUnite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUnite.FormattingEnabled = true;
            this.comboBoxUnite.Location = new System.Drawing.Point(112, 35);
            this.comboBoxUnite.Name = "comboBoxUnite";
            this.comboBoxUnite.Size = new System.Drawing.Size(193, 30);
            this.comboBoxUnite.TabIndex = 6;
            this.comboBoxUnite.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnite_SelectedIndexChanged);
            // 
            // comboBoxKonu
            // 
            this.comboBoxKonu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.comboBoxKonu.Enabled = false;
            this.comboBoxKonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKonu.FormattingEnabled = true;
            this.comboBoxKonu.Location = new System.Drawing.Point(112, 90);
            this.comboBoxKonu.Name = "comboBoxKonu";
            this.comboBoxKonu.Size = new System.Drawing.Size(193, 30);
            this.comboBoxKonu.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ünite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Konu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soru NO";
            // 
            // textBoxSoruID
            // 
            this.textBoxSoruID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxSoruID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSoruID.Location = new System.Drawing.Point(112, 146);
            this.textBoxSoruID.Name = "textBoxSoruID";
            this.textBoxSoruID.Size = new System.Drawing.Size(64, 29);
            this.textBoxSoruID.TabIndex = 10;
            this.textBoxSoruID.Text = "0";
            this.textBoxSoruID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSoruID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMetin_MouseClick);
            // 
            // textBoxYanlis3
            // 
            this.textBoxYanlis3.BackColor = System.Drawing.Color.SkyBlue;
            this.textBoxYanlis3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYanlis3.ForeColor = System.Drawing.Color.Black;
            this.textBoxYanlis3.Location = new System.Drawing.Point(383, 211);
            this.textBoxYanlis3.Name = "textBoxYanlis3";
            this.textBoxYanlis3.Size = new System.Drawing.Size(303, 22);
            this.textBoxYanlis3.TabIndex = 5;
            this.textBoxYanlis3.Text = "yanlış seçenek";
            this.textBoxYanlis3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMetin_MouseClick);
            // 
            // textBoxMetin
            // 
            this.textBoxMetin.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxMetin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMetin.ForeColor = System.Drawing.Color.Black;
            this.textBoxMetin.Location = new System.Drawing.Point(25, 28);
            this.textBoxMetin.Multiline = true;
            this.textBoxMetin.Name = "textBoxMetin";
            this.textBoxMetin.Size = new System.Drawing.Size(272, 235);
            this.textBoxMetin.TabIndex = 5;
            this.textBoxMetin.Text = "\r\nLÜTFEN SORU METNİNİ BUARAYA GİRİNİZ!\r\n\r\n";
            this.textBoxMetin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMetin_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSoruID);
            this.groupBox1.Controls.Add(this.comboBoxUnite);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxKonu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(44, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 195);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.textBoxDogruSecenek);
            this.groupBox2.Controls.Add(this.textBoxYanlis1);
            this.groupBox2.Controls.Add(this.textBoxMetin);
            this.groupBox2.Controls.Add(this.textBoxYanlis3);
            this.groupBox2.Controls.Add(this.textBoxYanlis2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(44, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 280);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkBlue;
            this.panel5.Location = new System.Drawing.Point(335, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 1);
            this.panel5.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(335, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 1);
            this.panel1.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox3.Controls.Add(this.textResimEkle);
            this.groupBox3.Controls.Add(this.linkLabelResim);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(442, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 195);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // textResimEkle
            // 
            this.textResimEkle.BackColor = System.Drawing.Color.AliceBlue;
            this.textResimEkle.Location = new System.Drawing.Point(21, 98);
            this.textResimEkle.Name = "textResimEkle";
            this.textResimEkle.Size = new System.Drawing.Size(275, 29);
            this.textResimEkle.TabIndex = 1;
            // 
            // linkLabelResim
            // 
            this.linkLabelResim.AutoSize = true;
            this.linkLabelResim.LinkColor = System.Drawing.Color.Black;
            this.linkLabelResim.Location = new System.Drawing.Point(21, 43);
            this.linkLabelResim.Name = "linkLabelResim";
            this.linkLabelResim.Size = new System.Drawing.Size(128, 22);
            this.linkLabelResim.TabIndex = 0;
            this.linkLabelResim.TabStop = true;
            this.linkLabelResim.Text = "RESİM EKLE";
            this.linkLabelResim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelResim_LinkClicked);
            // 
            // openFileDialogResim1
            // 
            this.openFileDialogResim1.FileName = "openFileDialog1";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkBlue;
            this.panel9.Location = new System.Drawing.Point(854, 39);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2, 580);
            this.panel9.TabIndex = 14;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKaydet.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKaydet.ForeColor = System.Drawing.Color.Black;
            this.buttonKaydet.Location = new System.Drawing.Point(196, 567);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(446, 44);
            this.buttonKaydet.TabIndex = 15;
            this.buttonKaydet.Text = "Soruyu Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Location = new System.Drawing.Point(12, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 580);
            this.panel2.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Navy;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 634);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(871, 5);
            this.panel8.TabIndex = 17;
            // 
            // SoruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(871, 639);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SoruEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoruEkle";
            this.Load += new System.EventHandler(this.SoruEkle_Load);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxDogruSecenek;
        private System.Windows.Forms.TextBox textBoxYanlis1;
        private System.Windows.Forms.TextBox textBoxYanlis2;
        private System.Windows.Forms.ComboBox comboBoxUnite;
        private System.Windows.Forms.ComboBox comboBoxKonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSoruID;
        private System.Windows.Forms.TextBox textBoxYanlis3;
        private System.Windows.Forms.TextBox textBoxMetin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonKapat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textResimEkle;
        private System.Windows.Forms.LinkLabel linkLabelResim;
        private System.Windows.Forms.OpenFileDialog openFileDialogResim1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
    }
}