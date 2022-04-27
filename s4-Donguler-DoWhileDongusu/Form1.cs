using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s4_Donguler_DoWhileDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //do
            //{

            // do while döngüsüde koşula bağlı bir döngüdür.. koşul true olduğu sürece döner...Önemli koşul true olsun olmasın do bloğu bir kere çalışır... yani önce do bloğu sonra while yapısı çalışır
            //}while(koşul);



            int sayac = 4;

            while (sayac == 0)
            {
                MessageBox.Show("Test");
            }


            do
            {
                MessageBox.Show("Test");
            } while (sayac == 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // while - for döngüsünde önce koşula bakılığ işlem yapılırken, do while döngüsünde önce işlem  yapılıp sonra koşula bakılır...
            int i = 0;

            do
            {
                listBox1.Items.Add(i);
                i++;
            } while (i < 10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Mesaj", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //button3.Text = dr.ToString();

            DialogResult dr2;
            do
            {
                dr2 = MessageBox.Show("Dönsünmü", "Bilgilendirme", MessageBoxButtons.YesNo);
            } while (dr2 == DialogResult.Yes);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            listBox2.Items.Clear();

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {

                int gelensayi = rnd.Next(1, 101);

                if (gelensayi % 2 == 0)
                {
                    listBox2.Items.Add(gelensayi);
                }
                else
                {
                    i--;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            Random rnd = new Random();

            int sayac = 0;
            while (sayac < 10)
            {
                int sayi = rnd.Next(0, 101);
                if (sayi % 2 == 0)
                {
                    listBox2.Items.Add(sayi);
                    sayac++;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // kimin elemanları temizlenecek??? listbox2'nin
            // ne zaman temizlenecek ??? elemanları olduğununda
            // elemanlarının olduğunu nasıl anlarız??? count özelliğinden

            //switch (listBox2.Items.Count)
            //{
            //    case 0:
            //        MessageBox.Show("Zaten Temizki");
            //        break;
            //    default:
            //         listBox2.Items.Clear();
            //        break;
            //}

            if (listBox2.Items.Count != 0) // eleman sayısı 0 dan farklı ise git sil
            {
                listBox2.Items.Clear();
            }
            else
            {
                MessageBox.Show("Zaten Temizki");
            }
        }
    }
}
