using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u6_StringMethodlari2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = "yiğit";
            // Substring() => string içerisinden karakter almayı sağlar
            string a = isim.Substring(0, 1);

            string b = isim.Substring(1, 2);
            string son = isim.Substring(isim.Length - 1, 1);
            // ekrem yıldırım
            // Ekrem
            // Yıldırım
            // isim soyisimi ayrımak için isim ile soyisim arasındaki boşluktan faydalanalım...
            string FullAdi = textBox1.Text;
            // IndexOf methodu metin içerisinde karakter arar... aranan karakter varsa indexini döner... eğer aynı karakter birden fazla varsa ilkinin indexini döner...



            // ekrem yıldırım
            int i = FullAdi.IndexOf(" ");

            // ali berke bektaş,
            int k = FullAdi.IndexOf(" ", i + 1);
            if (k > -1) // i -1 den büyükse ikinci boşluk var demektir...
            {
                i = k;  // ikinci boşluun indexini i'ye at
            }
            string Adi = FullAdi.Substring(0, i);
            string SoyAdi = FullAdi.Substring(i + 1, FullAdi.Length - i - 1);

            label1.Text = Adi;
            label2.Text = SoyAdi.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string isim = "ali berke bektaş";

            string isim2 = "ekrem yıldırım";


            // Split metni belirtilen karaktere göre parçalar.. ve geriye string dizisi döner
            string[] dizi = isim.Split(' ');

            string[] dizi2 = isim2.Split(' ');

            label1.Text = dizi2[0];
            label2.Text = dizi2[1];


            string yeni = textBox1.Text;

            string[] yeniDizi = yeni.Split(' ');

            label1.Text = yeniDizi[0];
            if (yeniDizi.Length == 3)
            {
                label1.Text = label1.Text + " " + yeniDizi[1];
            }
            label2.Text = yeniDizi[yeniDizi.Length - 1];




            // ekrem bu gün çok heycanlıydı En yakın arkadaşı yiğit ile buluşacaktı evde ütü yapıyordu yiğitle kavak sulayıp piknik yapacaklardı 


            // bu cümle içerisinde geçen tesrten ve düzden okunuşları aynı alan kelimleri listbox2de belirtin. cümleyi ise listbox1'e ekleyin...
        }
    }
}
