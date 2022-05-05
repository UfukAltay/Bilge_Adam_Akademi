using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t5_ArraySinifi_Methodlari3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // sizin yapacağınız girilen değer 0-20 arasında olacak...
            // bu işlemleri yapıp arama yaparken indexof methoduu ile yapacaksınız...
            listBox1.Items.Clear();
            int[] dizi = new int[10];
            Random rnd = new Random();
            // dizinin elemanlarını ekleme
            for (int i = 0; i < 10; i++)
            {
                dizi[i] = rnd.Next(0, 20);
            }

            foreach (int s in dizi)
            {
                listBox1.Items.Add(s);
            }

            int sayi = Convert.ToInt32(textBox1.Text);
            // dizi içerisind girilen sayıyı arama
            int adet = 0;
            for (int i = 0; i < 10; i++)
            {
                if (dizi[i] == sayi)
                {
                    adet++;
                }

            }

            label1.Text = adet + " sayı tahmin ettiniz";
        }
    }
}
