namespace SinavSistemi
{
    partial class Sifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sifre));
            this.textBoxmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.buttonGoster = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttoncikis = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxmail
            // 
            this.textBoxmail.BackColor = System.Drawing.Color.Red;
            this.textBoxmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxmail.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxmail.Location = new System.Drawing.Point(65, 100);
            this.textBoxmail.Name = "textBoxmail";
            this.textBoxmail.Size = new System.Drawing.Size(254, 28);
            this.textBoxmail.TabIndex = 0;
            this.textBoxmail.Text = "Email Adres";
            this.textBoxmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxmail_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Location = new System.Drawing.Point(65, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 1);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "E mail Adresinizi Giriniz";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSifre.Location = new System.Drawing.Point(65, 215);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(71, 23);
            this.labelSifre.TabIndex = 3;
            this.labelSifre.Text = "label2";
            this.labelSifre.Visible = false;
            // 
            // buttonGoster
            // 
            this.buttonGoster.BackColor = System.Drawing.Color.Snow;
            this.buttonGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGoster.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGoster.Location = new System.Drawing.Point(65, 157);
            this.buttonGoster.Name = "buttonGoster";
            this.buttonGoster.Size = new System.Drawing.Size(107, 27);
            this.buttonGoster.TabIndex = 4;
            this.buttonGoster.Text = "İleri";
            this.buttonGoster.UseVisualStyleBackColor = false;
            this.buttonGoster.Click += new System.EventHandler(this.buttonGoster_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.buttoncikis);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 22);
            this.panel2.TabIndex = 5;
            // 
            // buttoncikis
            // 
            this.buttoncikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttoncikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttoncikis.BackgroundImage")));
            this.buttoncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttoncikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttoncikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncikis.Location = new System.Drawing.Point(365, 0);
            this.buttoncikis.Name = "buttoncikis";
            this.buttoncikis.Size = new System.Drawing.Size(26, 22);
            this.buttoncikis.TabIndex = 0;
            this.buttoncikis.UseVisualStyleBackColor = false;
            this.buttoncikis.Click += new System.EventHandler(this.buttoncikis_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 5);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(19, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 224);
            this.panel4.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Sifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(391, 306);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonGoster);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sifre";
            this.Text = "Sifre";
            this.Load += new System.EventHandler(this.Sifre_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Button buttonGoster;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttoncikis;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}