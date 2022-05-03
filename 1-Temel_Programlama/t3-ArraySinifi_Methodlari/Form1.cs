using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t3_ArraySinifi_Methodlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // https://www.youtube.com/watch?v=lyZQPjUT5B4 


            // dizide sıralama işlemleri
            // dizide arama işlemleri
            // dizinin uzunluğu
            //  bu tür işlemler alt seviye dillerde algoritmalarlaw bir çok satır komut kullanılırken c#'da bunlar tek satırlık methodlarla yapılabiliyor....

            // Diziler ile ilgili çalışmaları Array sınıfının methodlarında bulabiliriz...


            int[] sayilar = new int[3];
            sayilar[0] = 8;
            sayilar[1] = 1;
            sayilar[2] = 0;

            // diziyi sıralar
            Array.Sort(sayilar);

            // diziyi ters çevirir

            int[] sayilar2 = { 4, 3, 9, 0 }; // diziye ilk değerleri vermek için tercih edilir...

            Array.Reverse(sayilar2);
        }

        int[] sayilar = new int[10];
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = rnd.Next(0, 101);
            }
            listBox1.Items.Clear();
            foreach (int i in sayilar)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Sort(sayilar);
            listBox1.Items.Clear();

            foreach (int i in sayilar)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Array.Reverse(sayilar);
            listBox1.Items.Clear();
            foreach (int i in sayilar)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
