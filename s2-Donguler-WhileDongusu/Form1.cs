using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s2_Donguler_WhileDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 5;
            while (i < 10)
            {
                comboBox1.Items.Add(i);
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1 ile 100 arası rasgele çift sayı gelene kadar listbox'a eleman ekleme...
            listBox1.Items.Clear();


            string str = "a";
            Random rnd = new Random();

            while (str == "a")
            {
                int sayi = rnd.Next(1, 101);

                int ciftmi = sayi % 2; // 2 ye bölümden kalanı verir
                if (ciftmi == 0)
                {
                    listBox1.Items.Add(sayi);
                }
                else
                {
                    str = "b";
                }
            }
        }
    }
}
