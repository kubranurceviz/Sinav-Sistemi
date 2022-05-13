namespace SinavSistemi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciAnaForm));
            this.panelOgrAnaFrm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonSonucEkran = new System.Windows.Forms.Button();
            this.buttonBasla = new System.Windows.Forms.Button();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelOgrAnaFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOgrAnaFrm
            // 
            this.panelOgrAnaFrm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelOgrAnaFrm.Controls.Add(this.lbl);
            this.panelOgrAnaFrm.Controls.Add(this.lblDakika);
            this.panelOgrAnaFrm.Controls.Add(this.lblSaniye);
            this.panelOgrAnaFrm.Controls.Add(this.pictureBox1);
            this.panelOgrAnaFrm.Controls.Add(this.labelSoyad);
            this.panelOgrAnaFrm.Controls.Add(this.labelAd);
            this.panelOgrAnaFrm.Controls.Add(this.buttonCikis);
            this.panelOgrAnaFrm.Controls.Add(this.buttonSonucEkran);
            this.panelOgrAnaFrm.Controls.Add(this.buttonBasla);
            this.panelOgrAnaFrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOgrAnaFrm.Location = new System.Drawing.Point(0, 0);
            this.panelOgrAnaFrm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelOgrAnaFrm.Name = "panelOgrAnaFrm";
            this.panelOgrAnaFrm.Size = new System.Drawing.Size(263, 700);
            this.panelOgrAnaFrm.TabIndex = 0;
            this.panelOgrAnaFrm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelOgrAnaFrm_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 92);
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
            this.buttonCikis.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCikis.Location = new System.Drawing.Point(0, 504);
            this.buttonCikis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(263, 43);
            this.buttonCikis.TabIndex = 0;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // buttonSonucEkran
            // 
            this.buttonSonucEkran.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonSonucEkran.Location = new System.Drawing.Point(0, 454);
            this.buttonSonucEkran.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSonucEkran.Name = "buttonSonucEkran";
            this.buttonSonucEkran.Size = new System.Drawing.Size(263, 43);
            this.buttonSonucEkran.TabIndex = 0;
            this.buttonSonucEkran.Text = "Sonuç Ekranı";
            this.buttonSonucEkran.UseVisualStyleBackColor = false;
            this.buttonSonucEkran.Click += new System.EventHandler(this.buttonSonucEkran_Click);
            // 
            // buttonBasla
            // 
            this.buttonBasla.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonBasla.Location = new System.Drawing.Point(0, 405);
            this.buttonBasla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(263, 43);
            this.buttonBasla.TabIndex = 0;
            this.buttonBasla.Text = "Sınava Başla";
            this.buttonBasla.UseVisualStyleBackColor = false;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Location = new System.Drawing.Point(125, 623);
            this.lblSaniye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(20, 22);
            this.lblSaniye.TabIndex = 3;
            this.lblSaniye.Text = "  ";
            this.lblSaniye.Visible = false;
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblDakika.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDakika.ForeColor = System.Drawing.Color.Black;
            this.lblDakika.Location = new System.Drawing.Point(60, 623);
            this.lblDakika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(16, 22);
            this.lblDakika.TabIndex = 4;
            this.lblDakika.Text = " ";
            this.lblDakika.Visible = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(101, 623);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(22, 22);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "  ";
            this.lbl.Visible = false;
            // 
            // OgrenciAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 700);
            this.Controls.Add(this.panelOgrAnaFrm);
            this.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OgrenciAnaForm";
            this.Text = "OgrenciAnaForm";
            this.Load += new System.EventHandler(this.OgrenciAnaForm_Load);
            this.panelOgrAnaFrm.ResumeLayout(false);
            this.panelOgrAnaFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSoyad;
        internal System.Windows.Forms.Button buttonSonucEkran;
        internal System.Windows.Forms.Panel panelOgrAnaFrm;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Timer timer1;
    }
}