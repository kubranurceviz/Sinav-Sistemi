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
            this.SuspendLayout();
            // 
            // btn_grs_yap
            // 
            this.btn_grs_yap.Location = new System.Drawing.Point(150, 217);
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
            this.label1.Location = new System.Drawing.Point(22, 85);
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
            this.textBox_kullaniciad.Location = new System.Drawing.Point(130, 78);
            this.textBox_kullaniciad.Name = "textBox_kullaniciad";
            this.textBox_kullaniciad.Size = new System.Drawing.Size(179, 27);
            this.textBox_kullaniciad.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(130, 140);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(179, 27);
            this.textBox_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // linkLabel_kaydol
            // 
            this.linkLabel_kaydol.AutoSize = true;
            this.linkLabel_kaydol.Location = new System.Drawing.Point(254, 292);
            this.linkLabel_kaydol.Name = "linkLabel_kaydol";
            this.linkLabel_kaydol.Size = new System.Drawing.Size(55, 20);
            this.linkLabel_kaydol.TabIndex = 2;
            this.linkLabel_kaydol.TabStop = true;
            this.linkLabel_kaydol.Text = "Kaydol";
            this.linkLabel_kaydol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_kaydol_LinkClicked);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 391);
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
    }
}