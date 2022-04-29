using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_KarsilastirmaOperatorleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 3, sayi2 = 1;

            // ; satırı sonlandırır

            if (sayi1 > sayi2)
            {
                MessageBox.Show("1. sayı büyüktür");
            }
            else
            {
                MessageBox.Show("2. sayı büyüktür");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // if bloğu her zaman karşışaltırmanın sonucu true iken çalışır...
            bool durum1 = false, durum2 = true;

            if (durum1 == durum2)
            {
                MessageBox.Show("Durumlar Eşit");
            }
            else
            {
                MessageBox.Show("Durumlar Eşit Değildir");
            }

            if (durum1 != durum2)
            {
                MessageBox.Show("Durumlar Eşit Değildir");
            }
            else
            {
                MessageBox.Show("Durumlar Eşit");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            // "A" > "D" stringler eşitlik ve eşitdeğil durumları dışında karşılaştırılamazlar

            if (sayi1 > sayi2)
            {
                MessageBox.Show("1. sayı büyüktür");
            }
            else
            {
                MessageBox.Show("2. sayı büyüktür");
            }
        }
    }
}
