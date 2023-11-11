namespace HastaneSistemi
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.chckBoxBeniHatirla = new System.Windows.Forms.CheckBox();
            this.btnGirişYap = new System.Windows.Forms.Button();
            this.lblŞifre = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnGizle = new System.Windows.Forms.Button();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(134, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici Giriş Paneli";
            // 
            // chckBoxBeniHatirla
            // 
            this.chckBoxBeniHatirla.AutoSize = true;
            this.chckBoxBeniHatirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckBoxBeniHatirla.Location = new System.Drawing.Point(155, 234);
            this.chckBoxBeniHatirla.Name = "chckBoxBeniHatirla";
            this.chckBoxBeniHatirla.Size = new System.Drawing.Size(105, 22);
            this.chckBoxBeniHatirla.TabIndex = 9;
            this.chckBoxBeniHatirla.Text = "Beni Hatırla";
            this.chckBoxBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // btnGirişYap
            // 
            this.btnGirişYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirişYap.Location = new System.Drawing.Point(177, 270);
            this.btnGirişYap.Name = "btnGirişYap";
            this.btnGirişYap.Size = new System.Drawing.Size(138, 49);
            this.btnGirişYap.TabIndex = 12;
            this.btnGirişYap.Text = "Giriş Yap";
            this.btnGirişYap.UseVisualStyleBackColor = true;
            this.btnGirişYap.Click += new System.EventHandler(this.btnGirişYap_Click);
            // 
            // lblŞifre
            // 
            this.lblŞifre.AutoSize = true;
            this.lblŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblŞifre.Location = new System.Drawing.Point(88, 198);
            this.lblŞifre.Name = "lblŞifre";
            this.lblŞifre.Size = new System.Drawing.Size(49, 20);
            this.lblŞifre.TabIndex = 10;
            this.lblŞifre.Text = "Şifre:";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(31, 142);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(106, 20);
            this.lblKullanici.TabIndex = 11;
            this.lblKullanici.Text = "Kullanıcı Adı:";
            // 
            // btnGizle
            // 
            this.btnGizle.Image = ((System.Drawing.Image)(resources.GetObject("btnGizle.Image")));
            this.btnGizle.Location = new System.Drawing.Point(349, 183);
            this.btnGizle.Name = "btnGizle";
            this.btnGizle.Size = new System.Drawing.Size(48, 48);
            this.btnGizle.TabIndex = 8;
            this.btnGizle.UseVisualStyleBackColor = true;
            this.btnGizle.Click += new System.EventHandler(this.btnGizle_Click);
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(155, 196);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(177, 22);
            this.txtŞifre.TabIndex = 7;
            this.txtŞifre.UseSystemPasswordChar = true;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(155, 140);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(177, 22);
            this.txtKullanici.TabIndex = 5;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.chckBoxBeniHatirla);
            this.Controls.Add(this.btnGirişYap);
            this.Controls.Add(this.lblŞifre);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnGizle);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Giriş Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chckBoxBeniHatirla;
        private System.Windows.Forms.Button btnGirişYap;
        private System.Windows.Forms.Label lblŞifre;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnGizle;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.TextBox txtKullanici;
    }
}