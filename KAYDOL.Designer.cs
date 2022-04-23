namespace SinavSistemi
{
    partial class KAYDOL
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_kullaniciad = new System.Windows.Forms.TextBox();
            this.button_kaydol = new System.Windows.Forms.Button();
            this.button_geri = new System.Windows.Forms.Button();
            this.cmbx_kullaniciTipi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.Location = new System.Drawing.Point(128, 58);
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(164, 27);
            this.textBox_Ad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // textBox_Soyad
            // 
            this.textBox_Soyad.Location = new System.Drawing.Point(128, 108);
            this.textBox_Soyad.Name = "textBox_Soyad";
            this.textBox_Soyad.Size = new System.Drawing.Size(164, 27);
            this.textBox_Soyad.TabIndex = 1;
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(128, 211);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(164, 27);
            this.textBox_mail.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "E mail ";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(128, 266);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(164, 27);
            this.textBox_password.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifre";
            // 
            // textBox_kullaniciad
            // 
            this.textBox_kullaniciad.Location = new System.Drawing.Point(128, 161);
            this.textBox_kullaniciad.Name = "textBox_kullaniciad";
            this.textBox_kullaniciad.Size = new System.Drawing.Size(164, 27);
            this.textBox_kullaniciad.TabIndex = 1;
            // 
            // button_kaydol
            // 
            this.button_kaydol.Location = new System.Drawing.Point(198, 396);
            this.button_kaydol.Name = "button_kaydol";
            this.button_kaydol.Size = new System.Drawing.Size(94, 29);
            this.button_kaydol.TabIndex = 3;
            this.button_kaydol.Text = "KAYDOL";
            this.button_kaydol.UseVisualStyleBackColor = true;
          //  this.button_kaydol.Click += new System.EventHandler(this.button_kaydol_Click);
            // 
            // button_geri
            // 
            this.button_geri.Location = new System.Drawing.Point(68, 396);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(94, 29);
            this.button_geri.TabIndex = 3;
            this.button_geri.Text = "GERİ";
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // cmbx_kullaniciTipi
            // 
            this.cmbx_kullaniciTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_kullaniciTipi.FormattingEnabled = true;
            this.cmbx_kullaniciTipi.Items.AddRange(new object[] {
            "Öğrenci",
            "Sınav Sorumlusu",
            "Admin"});
            this.cmbx_kullaniciTipi.Location = new System.Drawing.Point(128, 324);
            this.cmbx_kullaniciTipi.Name = "cmbx_kullaniciTipi";
            this.cmbx_kullaniciTipi.Size = new System.Drawing.Size(164, 28);
            this.cmbx_kullaniciTipi.TabIndex = 4;
            // 
            // KAYDOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 475);
            this.Controls.Add(this.cmbx_kullaniciTipi);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.button_kaydol);
            this.Controls.Add(this.textBox_kullaniciad);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.textBox_Soyad);
            this.Controls.Add(this.textBox_Ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KAYDOL";
            this.Text = "KAYDOL";
            this.Load += new System.EventHandler(this.KAYDOL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_kullaniciad;
        private System.Windows.Forms.Button button_kaydol;
        private System.Windows.Forms.Button button_geri;
        private System.Windows.Forms.ComboBox cmbx_kullaniciTipi;
    }
}