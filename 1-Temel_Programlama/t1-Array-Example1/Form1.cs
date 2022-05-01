using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t1_Array_Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 10 elemanlı bir sayı dizisi
            // 50 ile 100 arası rasgele 10 adet sayı bu diziye yerleştirilecek
            // oluşturaln bu 10 adet sayı listboxx'da gösterilecektir...

            int[] sayilar = new int[10];
            Random rnd = new Random();

            int i = 0;
            while (i < sayilar.Length)
            {
                sayilar[i++] = rnd.Next(50, 101);
            }

            foreach (int a in sayilar)
            {
                listBox1.Items.Add(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            int metinuzunlugu = isim.Length;

            char[] dizim = new char[metinuzunlugu];

            int sira = 0;
            for (int i = isim.Length - 1; i >= 0; i--)
            {
                char c = isim[i];
                dizim[sira++] = isim[i];
            }


            label1.Text = "";
            foreach (char c in dizim)
            {
                label1.Text += c.ToString();
            }
        }
    }
}
