using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_VeriTipleri_Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // veritipi degiskenadi;
            // veritipi degiskenadi=deger;
            // atama yaparken deger ile veritipi birbirine eşit olmak zorundadır....

            // string veritipi hariç diğer bütün veritipleri değer tutarlar...

            // " " => string c# kod ekranında bunu yazdığınız zaman bunu bir metin olarak algılar...tek karakter yazsanızda birden fazla karakter yazsanızda çift tırnaklar her zman string'dir

            byte sayi = 5;

            string kelime = "C# la değişkenler ve veritipleri";
            string str = "A";
            char c = 'A';
            sbyte sb = -1;

            short sht = 5;
            ushort usht = 6;
            int sayi1 = 445646;
            uint usayi1 = 456465465;

            float fl = 3.1f;
            double dbl = 5.5d;
            decimal dml = 15.11m;



            // bool veritipi sadece iki değer alır....bunlar true ve false'dur.... bool veritipi mantıksal bir veritipidir.. programa yön vermek için kullanılır..
            bool bl = false;
            bool bl1 = true;
        }
    }
}
