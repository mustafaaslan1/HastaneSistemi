﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            txtKullanici.KeyPress += TextBox_KeyPress;
        }

        private void btnGizle_Click(object sender, EventArgs e)
        {
            if(txtŞifre.UseSystemPasswordChar)
            {
                txtŞifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtŞifre.UseSystemPasswordChar= true;
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
                islem = MessageBox.Show("Kullanıcı adı veya Şifre Girmediniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide();
                Form3 doktor1 = new Form3(txtKullanici.Text);
                doktor1.ShowDialog();
                this.Close();
            }
        }
    }
}
