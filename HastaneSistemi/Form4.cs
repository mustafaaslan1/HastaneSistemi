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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
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
        }
    }
}
