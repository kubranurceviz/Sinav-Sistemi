namespace SinavSistemi.Formlar
{
    partial class SonucEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SonucEkran));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSonuc = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // buttonSonuc
            // 
            this.buttonSonuc.BackColor = System.Drawing.Color.White;
            this.buttonSonuc.Location = new System.Drawing.Point(321, 210);
            this.buttonSonuc.Name = "buttonSonuc";
            this.buttonSonuc.Size = new System.Drawing.Size(94, 52);
            this.buttonSonuc.TabIndex = 1;
            this.buttonSonuc.Text = "button1";
            this.buttonSonuc.UseVisualStyleBackColor = false;
            this.buttonSonuc.Click += new System.EventHandler(this.buttonSonuc_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCikis.BackgroundImage")));
            this.buttonCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCikis.Location = new System.Drawing.Point(723, 0);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(31, 23);
            this.buttonCikis.TabIndex = 1;
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.buttonCikis);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(754, 23);
            this.panel4.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Navy;
            this.panel10.Location = new System.Drawing.Point(47, 10);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(670, 1);
            this.panel10.TabIndex = 2;
            // 
            // SonucEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(754, 521);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonSonuc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SonucEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SonucEkran";
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSonuc;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
    }
}