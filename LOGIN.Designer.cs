namespace SinavSistemi
{
    partial class LOGIN
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
            this.btn_grs_yap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_password = new System.Windows.Forms.LinkLabel();
            this.textBox_kullaniciad = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel_kaydol = new System.Windows.Forms.LinkLabel();
            this.rdbtn_ogrenci = new System.Windows.Forms.RadioButton();
            this.rdbtn_SinavSorumlusu = new System.Windows.Forms.RadioButton();
            this.rdbtn_Admin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_grs_yap
            // 
            this.btn_grs_yap.Location = new System.Drawing.Point(177, 245);
            this.btn_grs_yap.Name = "btn_grs_yap";
            this.btn_grs_yap.Size = new System.Drawing.Size(113, 31);
            this.btn_grs_yap.TabIndex = 0;
            this.btn_grs_yap.Text = "Giriş Yap\r\n";
            this.btn_grs_yap.UseVisualStyleBackColor = true;
            this.btn_grs_yap.Click += new System.EventHandler(this.btn_grs_yap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // linkLabel_password
            // 
            this.linkLabel_password.AutoSize = true;
            this.linkLabel_password.Location = new System.Drawing.Point(92, 292);
            this.linkLabel_password.Name = "linkLabel_password";
            this.linkLabel_password.Size = new System.Drawing.Size(117, 20);
            this.linkLabel_password.TabIndex = 2;
            this.linkLabel_password.TabStop = true;
            this.linkLabel_password.Text = "Şifremi Unuttum";
            this.linkLabel_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_password_LinkClicked);
            // 
            // textBox_kullaniciad
            // 
            this.textBox_kullaniciad.Location = new System.Drawing.Point(150, 32);
            this.textBox_kullaniciad.Name = "textBox_kullaniciad";
            this.textBox_kullaniciad.Size = new System.Drawing.Size(235, 27);
            this.textBox_kullaniciad.TabIndex = 3;
            this.textBox_kullaniciad.TextChanged += new System.EventHandler(this.textBox_kullaniciad_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(150, 82);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(235, 27);
            this.textBox_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // linkLabel_kaydol
            // 
            this.linkLabel_kaydol.AutoSize = true;
            this.linkLabel_kaydol.Location = new System.Drawing.Point(261, 292);
            this.linkLabel_kaydol.Name = "linkLabel_kaydol";
            this.linkLabel_kaydol.Size = new System.Drawing.Size(55, 20);
            this.linkLabel_kaydol.TabIndex = 2;
            this.linkLabel_kaydol.TabStop = true;
            this.linkLabel_kaydol.Text = "Kaydol";
            this.linkLabel_kaydol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_kaydol_LinkClicked);
            // 
            // rdbtn_ogrenci
            // 
            this.rdbtn_ogrenci.AutoSize = true;
            this.rdbtn_ogrenci.Location = new System.Drawing.Point(47, 148);
            this.rdbtn_ogrenci.Name = "rdbtn_ogrenci";
            this.rdbtn_ogrenci.Size = new System.Drawing.Size(82, 24);
            this.rdbtn_ogrenci.TabIndex = 4;
            this.rdbtn_ogrenci.TabStop = true;
            this.rdbtn_ogrenci.Text = "Öğrenci";
            this.rdbtn_ogrenci.UseVisualStyleBackColor = true;
            this.rdbtn_ogrenci.CheckedChanged += new System.EventHandler(this.rdbtn_ogrenci_CheckedChanged);
            // 
            // rdbtn_SinavSorumlusu
            // 
            this.rdbtn_SinavSorumlusu.AutoSize = true;
            this.rdbtn_SinavSorumlusu.Location = new System.Drawing.Point(135, 148);
            this.rdbtn_SinavSorumlusu.Name = "rdbtn_SinavSorumlusu";
            this.rdbtn_SinavSorumlusu.Size = new System.Drawing.Size(138, 24);
            this.rdbtn_SinavSorumlusu.TabIndex = 5;
            this.rdbtn_SinavSorumlusu.TabStop = true;
            this.rdbtn_SinavSorumlusu.Text = "Sınav Sorumlusu";
            this.rdbtn_SinavSorumlusu.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Admin
            // 
            this.rdbtn_Admin.AutoSize = true;
            this.rdbtn_Admin.Location = new System.Drawing.Point(284, 148);
            this.rdbtn_Admin.Name = "rdbtn_Admin";
            this.rdbtn_Admin.Size = new System.Drawing.Size(74, 24);
            this.rdbtn_Admin.TabIndex = 6;
            this.rdbtn_Admin.TabStop = true;
            this.rdbtn_Admin.Text = "Admin";
            this.rdbtn_Admin.UseVisualStyleBackColor = true;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 424);
            this.Controls.Add(this.rdbtn_Admin);
            this.Controls.Add(this.rdbtn_SinavSorumlusu);
            this.Controls.Add(this.rdbtn_ogrenci);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_kullaniciad);
            this.Controls.Add(this.linkLabel_kaydol);
            this.Controls.Add(this.linkLabel_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_grs_yap);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_grs_yap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_password;
        private System.Windows.Forms.TextBox textBox_kullaniciad;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel_kaydol;
        private System.Windows.Forms.RadioButton rdbtn_ogrenci;
        private System.Windows.Forms.RadioButton rdbtn_SinavSorumlusu;
        private System.Windows.Forms.RadioButton rdbtn_Admin;
    }
}