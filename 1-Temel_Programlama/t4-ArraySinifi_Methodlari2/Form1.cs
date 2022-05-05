using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t4_ArraySinifi_Methodlari2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1 ile 40 arası rasgele 10 adet benzersiz sayı oluşturulup listbox'a eklenecek...Önce diziye sayılar atanacak sonra listbox'a eklenecek...

            // önce rnd nesnesi oluşturulacak (random rnd =new random())
            // 10 elemanlı bir dizi
            // 10 kere dönebilecek bir döngü
            // 1 ile 40 arası rasgele oluşacak bir sayı
            // oluşan sayı dizide aranacak
            // eğer sayı dizide yoksa diziye eklenecek varsa eklenyecek


            // IndexOf methodu dizi içerisinde arama yapar...eğer aradığımız değer dizide var ise o arana değerin indexini döndürür...eğer aranan eleman dizide yoksa geriye -1 döner...çünkü dizide o eleman olmadığı için indexi olamaz...

            // Array.IndexOf(dizi,aranandeger);
            int[] sayilar = { 3, 6, 1, 9, 2, 8 };
            int i = Array.IndexOf(sayilar, 5);

            string[] isimler = { "erkan", "celal", "yiğit", "ali", "samet" };
            i = Array.IndexOf(isimler, "davut");


            char[] karakterler = { 'A', 'B', 'C', 'D', 'Z', 'T' };
            i = Array.IndexOf(karakterler, 'B');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] sayilar = new int[10];


            int i = 0;
            while (i < 10)
            {
                int sayi = rnd.Next(1, 41); // sayı oluştur

                int sonuc = Array.IndexOf(sayilar, sayi); // sayıyı dizide ara

                if (sonuc == -1)
                {
                    sayilar[i] = sayi;
                    i++;

                }


            }

            // dizideki elemanları listbox'a while dışında ekleyin...
        }
    }
}
