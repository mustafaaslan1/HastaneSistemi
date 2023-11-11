using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 doktor = new Form2();
            doktor.ShowDialog();
            this.Close();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 randevu = new Form4();
            randevu.ShowDialog();
            this.Close();
        }

        private void btnYonetim_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 yonetici = new Form5();
            yonetici.ShowDialog();
            this.Close();
        }

        private void btnÇıkışYap_Click(object sender, EventArgs e)
        {
            DialogResult çıkış;
            çıkış = MessageBox.Show("İşlemi sonlandırmak istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (çıkış == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (çıkış == DialogResult.No)
            {
                MessageBox.Show("Uygulama Kapatılmadı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
