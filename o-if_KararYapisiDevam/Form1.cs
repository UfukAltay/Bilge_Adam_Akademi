using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace o_if_KararYapisiDevam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int hak = 3;

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = "admin", sifre = "123";

            if (txtKullaniciAdi.Text == kullaniciAdi && txtSifre.Text == sifre)
            {
                MessageBox.Show("Hoş geldin " + kullaniciAdi);
            }
            else
            {
                if (hak == 0)
                {
                    MessageBox.Show("Hesabınız bloke edilmiştir... Hakkınız Bitti");
                    button1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş! " + hak.ToString() + " Hakkınız Kaldı");
                    hak--;
                }
            }
        }
    }
}
