
namespace SinavSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_ogr = new System.Windows.Forms.Button();
            this.button_ssorumlusu = new System.Windows.Forms.Button();
            this.button_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ogr
            // 
            this.button_ogr.Location = new System.Drawing.Point(50, 83);
            this.button_ogr.Name = "button_ogr";
            this.button_ogr.Size = new System.Drawing.Size(135, 171);
            this.button_ogr.TabIndex = 0;
            this.button_ogr.Text = "Öğrenci";
            this.button_ogr.UseVisualStyleBackColor = true;
            // 
            // button_ssorumlusu
            // 
            this.button_ssorumlusu.Location = new System.Drawing.Point(213, 83);
            this.button_ssorumlusu.Name = "button_ssorumlusu";
            this.button_ssorumlusu.Size = new System.Drawing.Size(135, 171);
            this.button_ssorumlusu.TabIndex = 0;
            this.button_ssorumlusu.Text = "Sınav \r\nSorumlusu\r\n";
            this.button_ssorumlusu.UseVisualStyleBackColor = true;
            // 
            // button_admin
            // 
            this.button_admin.Location = new System.Drawing.Point(379, 83);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(135, 171);
            this.button_admin.TabIndex = 0;
            this.button_admin.Text = "Admin";
            this.button_admin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 349);
            this.Controls.Add(this.button_admin);
            this.Controls.Add(this.button_ssorumlusu);
            this.Controls.Add(this.button_ogr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ogr;
        private System.Windows.Forms.Button button_ssorumlusu;
        private System.Windows.Forms.Button button_admin;
    }
}

