using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace j_Operatorler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // operatörler


            // operatörlerin tek başlarına bir anlamı yoktur...
            // değerlere anlam katar.. programın işleyişini değiştirir



            // = atama operatörü
            // += toplama ve atama (değerin kendisiyle)

            int sayi = 1;
            sayi += 2;

            // karşılaştırma operatörleri => iki değeri karşılaştıran operatrlerdir...
            // karşılaştırma operatörleri true veya false dönerler
            // > büyüktür soldaki değerin sağdaki değerden büyükmu  olduğunu sorgular

            // >= büyük eşitmi

            // == eşitlik operatörü  iki değer eşitmi kontrolü yapar
            // != eşit değil  iki değer birbirine eşit değilmi kontrolü yapar

            bool sonuc = 3 > 5; // false
            sonuc = 3 < 5; // true
            sonuc = 3 >= 5; // false;
            sonuc = 5 >= 3;// true
            sonuc = 3 <= 5; // true
            sonuc = 3 == 3; // true
            string isim = "ekrem";
            sonuc = isim == "admin"; // false
            sonuc = isim != "admin"; //  true


            // iki ve daha fazla değeri karşılaştırmak için mantıksal operatörleri kullanıyoruz
            // kısa devre operatörleride derler...
            // ve (and) && 
            // veya (or) || 


            // shift+6 tuşu
            bool sonuc2 = 3 > 1 && 2 == 2; //true
            sonuc2 = 4 < 1 && 5 > 0; // false;
            sonuc2 = 2 == 3 && 1 != 0; // false;
            sonuc2 = 3 > 3 && 1 == 0; // false;

            // veya için altgr+küçükbüyük tuşları

            bool sonuc3 = 3 > 1 || 2 == 2; //true
            sonuc3 = 4 < 1 || 5 > 0; // true;
            sonuc3 = 2 == 3 || 1 != 0; // true;
            sonuc3 = 3 > 3 || 1 == 0; // false;
        }
    }
}
