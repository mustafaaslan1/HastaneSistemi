namespace HastaneSistemi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.btnGizle = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblŞifre = new System.Windows.Forms.Label();
            this.btnGirişYap = new System.Windows.Forms.Button();
            this.chckBoxBeniHatirla = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(137, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(154, 144);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(177, 22);
            this.txtKullanici.TabIndex = 0;
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(154, 200);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(177, 22);
            this.txtŞifre.TabIndex = 1;
            this.txtŞifre.UseSystemPasswordChar = true;
            // 
            // btnGizle
            // 
            this.btnGizle.Image = ((System.Drawing.Image)(resources.GetObject("btnGizle.Image")));
            this.btnGizle.Location = new System.Drawing.Point(348, 187);
            this.btnGizle.Name = "btnGizle";
            this.btnGizle.Size = new System.Drawing.Size(48, 48);
            this.btnGizle.TabIndex = 2;
            this.btnGizle.UseVisualStyleBackColor = true;
            this.btnGizle.Click += new System.EventHandler(this.btnGizle_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(30, 146);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(106, 20);
            this.lblKullanici.TabIndex = 3;
            this.lblKullanici.Text = "Kullanıcı Adı:";
            // 
            // lblŞifre
            // 
            this.lblŞifre.AutoSize = true;
            this.lblŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblŞifre.Location = new System.Drawing.Point(87, 202);
            this.lblŞifre.Name = "lblŞifre";
            this.lblŞifre.Size = new System.Drawing.Size(49, 20);
            this.lblŞifre.TabIndex = 3;
            this.lblŞifre.Text = "Şifre:";
            // 
            // btnGirişYap
            // 
            this.btnGirişYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirişYap.Location = new System.Drawing.Point(176, 274);
            this.btnGirişYap.Name = "btnGirişYap";
            this.btnGirişYap.Size = new System.Drawing.Size(138, 49);
            this.btnGirişYap.TabIndex = 4;
            this.btnGirişYap.Text = "Giriş Yap";
            this.btnGirişYap.UseVisualStyleBackColor = true;
            this.btnGirişYap.Click += new System.EventHandler(this.btnGirişYap_Click);
            // 
            // chckBoxBeniHatirla
            // 
            this.chckBoxBeniHatirla.AutoSize = true;
            this.chckBoxBeniHatirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckBoxBeniHatirla.Location = new System.Drawing.Point(154, 238);
            this.chckBoxBeniHatirla.Name = "chckBoxBeniHatirla";
            this.chckBoxBeniHatirla.Size = new System.Drawing.Size(105, 22);
            this.chckBoxBeniHatirla.TabIndex = 3;
            this.chckBoxBeniHatirla.Text = "Beni Hatırla";
            this.chckBoxBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Giriş Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.Button btnGizle;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblŞifre;
        private System.Windows.Forms.Button btnGirişYap;
        private System.Windows.Forms.CheckBox chckBoxBeniHatirla;
    }
}