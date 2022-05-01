using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t_Diziler_Arrays_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sayi3 = Convert.ToInt32(textBox3.Text);

            int enb = 0;
            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                enb = sayi1;
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                enb = sayi2;
            }
            else
            {
                enb = sayi3;
            }

            int enk = enb;
            if (sayi1 < enk)
            {
                enk = sayi1;
            }

            if (sayi2 < enk)
            {
                enk = sayi2;
            }

            if (sayi3 < enk)
            {
                enk = sayi3;
            }
            lblSonuc.Text = String.Format("Girilen sayılardan en büyük sayı {0} en küçük sayı {1}", enb, enk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // dizi = programalam dillerinde birden fazla değerin bir arada bellekte kümelenerek saklanmasıdır.. diziler birden fazla değerin tek başlk altında referansını saklarlar...

            // dizi tanmlarken;

            // veritipi[] diziAdi = new veritipi[elemanSayisi];
            // tutacağımız değişken adedi...

            int[] sayilar = new int[3];
            int sayi;
            int[] sayilar2; // bu kullanımda new int[elemansayisi] vermediğimiz için sayilar2 dizisinin null olduğunu görürüz....normalde int null olamaz... sadece referans tipler null olabilir... dizilerde hangi tipde olursa olsun eleman sayısı kadar değişkenin(değerin) referansını tutar....

            // diziye değer atarken ;
            // diziAdi[indexNumarası]
            sayilar[0] = 5;

            // diziden değer okurken;
            // int a = diziAdi[indexNumarası]
            int a = sayilar[0];

            string[] isimler = new string[5];

            isimler[0] = "Barış";
            isimler[1] = "Simge";
            isimler[2] = "Yiğit";
            isimler[3] = "Ali";
            isimler[4] = "baturay";

            //isimler[5] = "davut"; bu atamada hata alırız.... dizinin en büyük indexi 4'tür.. her zman en büyük index dizinin eleman sayısının bir eksiğidir...

            // bu şekilde dizi elemanları okunabilir... ama uzun sürer.. dizi kullanımının mantığı kalmaz...
            //MessageBox.Show(isimler[0]);
            //MessageBox.Show(isimler[1]);
            //MessageBox.Show(isimler[2]);
            //MessageBox.Show(isimler[3]);
            //MessageBox.Show(isimler[4]);

            //isimler.Length dizinin uzunluğunu verir...

            label4.Text = " ";
            for (int i = 0; i < isimler.Length; i++)
            {
                // burayı kesin açın..
                //   MessageBox.Show(isimler[i]);
                label4.Text += isimler[i];
            }

            for (int i = 4; i >= 0; i--)
            {
                MessageBox.Show(isimler[i]);

            }



            //int sayac=4;
            //do
            //{
            //    MessageBox.Show(isimler[sayac]);
            //    sayac--;
            //}
            //while (sayac >= 0);
        }
    }
}
