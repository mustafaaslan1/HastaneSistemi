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
    public partial class Form3 : Form
    {
        public Form3(string a)
        {
            InitializeComponent();

            txtAdSoyad.KeyPress += TextBox_KeyPress;
            
            DateTime zaman = DateTime.Now;
            label12.Text = ("Hoşgeldiniz ") + a + (" - ") + zaman;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
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

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            string AdSoyad = txtAdSoyad.Text;
            string Dogumtarihi = maskedTxtDoğum.Text;
            string Telefon = maskedTxtTelefon.Text;
            string Kimlik = maskedTxtKimlik.Text;
            string Sehir = comboŞehir.Text;
            string KanGrubu = comboKanGrubu.Text;
            string Sikayet = txtŞikayet.Text;
            string Zaman = dateTimePicker1.Text + maskedTxtSaat.Text;
            if (string.IsNullOrWhiteSpace(AdSoyad) || string.IsNullOrWhiteSpace(Dogumtarihi) || string.IsNullOrWhiteSpace(Telefon) ||
                string.IsNullOrWhiteSpace(Kimlik) || string.IsNullOrWhiteSpace(Sehir) || string.IsNullOrWhiteSpace(KanGrubu) ||
                string.IsNullOrWhiteSpace(Sikayet) || string.IsNullOrWhiteSpace(Zaman))
            {
                DialogResult kaydet;

                kaydet = MessageBox.Show("Boş bir sekme olamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                listBox1.Items.Add("Adı Soyadı: " + txtAdSoyad.Text);
                listBox1.Items.Add("Doğum Tarihi: " + maskedTxtDoğum.Text);
                listBox1.Items.Add("Kimlik Numarası: " + maskedTxtKimlik.Text);
                listBox1.Items.Add("Kan Grubu: " + comboKanGrubu.Text);
                listBox1.Items.Add("Şehir: " + comboŞehir.Text);
                listBox1.Items.Add("Tarih / Saat: " + dateTimePicker1.Text + maskedTxtSaat.Text);
                listBox1.Items.Add("Şikayeti: " + txtŞikayet.Text);
                listBox1.Items.Add(" ");

            }

        }
    }
}
