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
    public partial class Form6 : Form
    {
        public Form6(string s)
        {
            InitializeComponent();

            DateTime tarih = DateTime.Now;     
            label1.Text = ("Hoşgeldiniz ") + s + (" - ") + tarih;
            label6.Text = (" " + s);
        }
    }
}
