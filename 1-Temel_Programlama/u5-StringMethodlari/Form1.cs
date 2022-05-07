using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u5_StringMethodlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //"A" ile "a" farklıdır

            string isim = "Yiğit";

            string yeniIsim = isim.ToUpper(); // YİĞİT


            // textboxa girilen değer admin ise doğru değilse yanlış.. Admin, ADmin,admiN bunların hepsi admindir..

            if (textBox1.Text.ToUpper().Trim() == "ADMİN")
            {
                MessageBox.Show("Doğru");
            }
            else
            {
                MessageBox.Show("Yanlış");
            }


            // metnin başındaki  boşlukları kaldırmak için TrimStart() sonundaki boşlukları kaldırmak için TrimEnd() her iki tarafıda kaldırmak için Trim() methodları kullanılır...
            string isim2 = "    davut       ";
            isim2 = isim2; // "         davut     ";
            isim2 = isim2.Trim(); // "davut";


            char[] dizi = isim2.ToArray(); // ToArray() methodu metnin char dizisine çevirir....


            MessageBox.Show(isim2.Length.ToString());

            string sifre = "1988";



            // for yazıp tab tab yaparsanız görürsünüz...
        }
    }
}
