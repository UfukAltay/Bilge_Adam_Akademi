using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u4_MethodOverloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mesaj("mesaj", "Uyarı");

            Mesaj("Uygulamadan çıkılsın mı?", "Uyarı");

            DialogResult cvp = Mesaj("Uygulamdan çıkılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        // method overload => methodları aşırı yükleme
        // method overload => parametreler aynı olmadığı sürece methodlar overload edilebilirler...
        void Mesaj(string icerik)
        {
            MessageBox.Show(icerik);
        }


        void Mesaj(string icerik, string baslik)
        {
            MessageBox.Show(icerik, baslik);
        }

        DialogResult Mesaj(string icerik, string baslik, MessageBoxButtons btn, MessageBoxIcon ikon)
        {
            DialogResult donendeger = MessageBox.Show(icerik, baslik, btn, ikon);
            return donendeger;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = Toplama(3, 5);
            int s1 = Toplama(2, 2);
            MessageBox.Show(Toplama(1, 1).ToString());

            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            int sonuc = Toplama(a, b);
        }

        // dışarıdan girilen iki sayıyı toplayan ve sonucunu veren bir method...

        int Toplama(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }
    }
}
