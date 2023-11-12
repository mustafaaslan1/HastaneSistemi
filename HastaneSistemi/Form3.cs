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
            listBox1.Items.Add("Adı Soyadı: " + txtAdSoyad);
            listBox1.Items.Add("Doğum Tarihi: " + maskedTxtDoğum);
            listBox1.Items.Add("Telefon Numarası: " + maskedTxtTelefon);
            listBox1.Items.Add("Kimlik Numarası: " + maskedTxtKimlik);
            listBox1.Items.Add("Şehir: " + comboŞehir);
            listBox1.Items.Add("Kan Grubu: " + comboKanGrubu);
            listBox1.Items.Add("Şikayet: " + txtŞikayet);


        }
    }
}
