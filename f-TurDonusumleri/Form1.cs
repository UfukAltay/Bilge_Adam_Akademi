using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f_TurDonusumleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // değişken tanımlarken aynı tipdeki değişkenleri yanyana , ile ayırarak tanımlabilirsiniz..

            int s1 = 1, s2, s3 = 4;

            // bazen tipler birbirine eşit olmazlar..

            // c#'da farklı tiplerin tür dönüşümü için Convert sınıfının methodları kullanılır

            // küp iconlu anahtar kelimeler method'dur... parantez açıp kapatmak zorundayız
            string str = Convert.ToString(s1);

            // ToString(string'e çevrilecek değer) gördüğümüz bütün tiplerin değerini string'e çevirir

            // Convert işlemi runtime'da (çalışma zamanında yapacağı için) hatalarıda çalışma zamanında alırız...


            //string str2 = "AA";
            //int sayi1 = Convert.ToInt32(str2); bu tür dönüşümünde hata alırız sebeb aa metninin sayı karşılığı olamaz...
            string str2 = "44";
            int sayi1 = Convert.ToInt32(str2);

            // char veritipindeki herbir karakter int'e çevrilebilir...nedeni her bir karakterin ascii kod karşılığı vardır...
            char chr = 'A';
            int sa = Convert.ToInt32(chr); // bu tür dönüşümü mümkündür.. A karakteri ' ' içerisinde tanımlandığı için asci kod karşılığı vardır.. sa değişkenin A'nın asci kod karşılığını atayacaktır...

            char c1 = '1';
            int ka = Convert.ToInt32(c1);
        }
    }
}
