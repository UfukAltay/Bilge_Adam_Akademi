using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s_Donguler_ForDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // for döngüsü
            // sayac, karşılaştırma operatörleri

            // blokları kullanırken  parantezlerde ; kullanmayalım arkadaşlar

            // if,else if,for(); bu kullanım yanlıştır..; komut satırını sonlandırır... ama blokların scope'ları olduğu için başlık kısmında sonlandırılamazlar...
            // for(başlangıçdegeri; koşul; sayac)
            //{
            //
            //}

            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }

            // listbox2 100'den 1'e kadar olan sayıları ekleme

            for (int i = 100; i >= 1; i--)
            {
                listBox2.Items.Add(i);
            }
        }
    }
}
