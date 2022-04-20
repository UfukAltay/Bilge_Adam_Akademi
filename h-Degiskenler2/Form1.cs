using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h_Degiskenler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // uygulama çalıştırmanın kısa yolu f5'dir

            // değişken ömürleri
            // değişkenler tanımlandıkları satırların altından erişilebilirler
            int sayi = 5;
            sayi += 5;
            // tanımlandığı scoplar içerisinde erişilebilir
            //sayac = sayac + 1;
            //sayac += 1;
            // bir artımlar için
            sayac++;
            // string'e convert için 1 yol
            // label1.Text = Convert.ToString(sayac);
            // string'e convert işleminin 2 yol
            label1.Text = sayac.ToString();
        }
        int sayac;
        private void button2_Click(object sender, EventArgs e)
        {
            sayac--;
            label1.Text = sayac.ToString();
        }
    }
}
