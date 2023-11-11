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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            string KullaniciAdi = txtKullanici.Text;
            txtKullanici.KeyPress += TextBox_KeyPress;
        }

        private void btnGizle_Click(object sender, EventArgs e)
        {
            if (txtŞifre.UseSystemPasswordChar)
            {
                txtŞifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtŞifre.UseSystemPasswordChar = true;
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Girilen karakterin boşluk veya harf olup olmadığını kontrol et
            if (!char.IsControl(e.KeyChar) && e.KeyChar != ' ' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                // // Eğer boşluk veya harf değilse, olayı işleme alma ve karakteri kabul etme
            }
        }

        private void btnGirişYap_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = txtKullanici.Text;
            string Şifre = txtŞifre.Text;

            if (string.IsNullOrWhiteSpace(KullaniciAdi) || string.IsNullOrWhiteSpace(Şifre))
            {
                DialogResult islem;
                islem = MessageBox.Show("Kullanıcı Adı veya Şifre girmediniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide();
                Form6 yonetici = new Form6(txtKullanici.Text);
                yonetici.ShowDialog();
                this.Close();
            }
        }
    }
}
