﻿namespace SinavSistemi
{
    partial class OgrenciAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciAnaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonSonucEkran = new System.Windows.Forms.Button();
            this.buttonBasla = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelSoyad);
            this.panel1.Controls.Add(this.labelAd);
            this.panel1.Controls.Add(this.buttonCikis);
            this.panel1.Controls.Add(this.buttonSonucEkran);
            this.panel1.Controls.Add(this.buttonBasla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 700);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Location = new System.Drawing.Point(41, 228);
            this.labelSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(61, 22);
            this.labelSoyad.TabIndex = 1;
            this.labelSoyad.Text = "label1";
            this.labelSoyad.Visible = false;
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(41, 189);
            this.labelAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(61, 22);
            this.labelAd.TabIndex = 1;
            this.labelAd.Text = "label1";
            this.labelAd.Visible = false;
            // 
            // buttonCikis
            // 
            this.buttonCikis.Location = new System.Drawing.Point(0, 504);
            this.buttonCikis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(263, 43);
            this.buttonCikis.TabIndex = 0;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // buttonSonucEkran
            // 
            this.buttonSonucEkran.Location = new System.Drawing.Point(0, 454);
            this.buttonSonucEkran.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSonucEkran.Name = "buttonSonucEkran";
            this.buttonSonucEkran.Size = new System.Drawing.Size(263, 43);
            this.buttonSonucEkran.TabIndex = 0;
            this.buttonSonucEkran.Text = "Sonuç Ekranı";
            this.buttonSonucEkran.UseVisualStyleBackColor = true;
            // 
            // buttonBasla
            // 
            this.buttonBasla.Location = new System.Drawing.Point(0, 405);
            this.buttonBasla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(263, 43);
            this.buttonBasla.TabIndex = 0;
            this.buttonBasla.Text = "Sınava Başla";
            this.buttonBasla.UseVisualStyleBackColor = true;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // OgrenciAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 700);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OgrenciAnaForm";
            this.Text = "OgrenciAnaForm";
            this.Load += new System.EventHandler(this.OgrenciAnaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.Button buttonSonucEkran;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSoyad;
    }
}