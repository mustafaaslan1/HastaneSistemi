namespace HastaneSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDoktor = new System.Windows.Forms.Button();
            this.btnYonetim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnÇıkışYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoktor
            // 
            this.btnDoktor.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDoktor.Image = ((System.Drawing.Image)(resources.GetObject("btnDoktor.Image")));
            this.btnDoktor.Location = new System.Drawing.Point(235, 172);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(128, 128);
            this.btnDoktor.TabIndex = 0;
            this.btnDoktor.UseVisualStyleBackColor = false;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // btnYonetim
            // 
            this.btnYonetim.BackColor = System.Drawing.Color.SeaGreen;
            this.btnYonetim.Image = ((System.Drawing.Image)(resources.GetObject("btnYonetim.Image")));
            this.btnYonetim.Location = new System.Drawing.Point(397, 172);
            this.btnYonetim.Name = "btnYonetim";
            this.btnYonetim.Size = new System.Drawing.Size(128, 128);
            this.btnYonetim.TabIndex = 2;
            this.btnYonetim.UseVisualStyleBackColor = false;
            this.btnYonetim.Click += new System.EventHandler(this.btnYonetim_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnÇıkışYap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 73);
            this.panel1.TabIndex = 1;
            // 
            // btnÇıkışYap
            // 
            this.btnÇıkışYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkışYap.Location = new System.Drawing.Point(641, 0);
            this.btnÇıkışYap.Name = "btnÇıkışYap";
            this.btnÇıkışYap.Size = new System.Drawing.Size(124, 42);
            this.btnÇıkışYap.TabIndex = 4;
            this.btnÇıkışYap.Text = "Çıkış Yap";
            this.btnÇıkışYap.UseVisualStyleBackColor = true;
            this.btnÇıkışYap.Click += new System.EventHandler(this.btnÇıkışYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(216, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merkezi Hastane Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(185, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beni Türk Hekimlerine Emanet Ediniz.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(520, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(261, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doktor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(421, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yönetim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnYonetim);
            this.Controls.Add(this.btnDoktor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merkezi Hastane Sistemi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Button btnYonetim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnÇıkışYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

