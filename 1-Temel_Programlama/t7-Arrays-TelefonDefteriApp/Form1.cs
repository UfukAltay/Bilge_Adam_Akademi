using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t7_Arrays_TelefonDefteriApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] Adsoyad = new string[0];

        string[] Telefon = new string[0];

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Array.Resize(ref Adsoyad, Adsoyad.Length + 1);
            Adsoyad[Adsoyad.Length - 1] = txtAdSoyad.Text;
            Array.Resize(ref Telefon, Telefon.Length + 1);
            Telefon[Telefon.Length - 1] = txtTelNo.Text;

            //2.boyutlu diziye eleman tanımlama
            TelefonDefteri[0, 0] = txtAdSoyad.Text;
            TelefonDefteri[0, 1] = txtTelNo.Text;
            //int sayi=  TelefonDefteri.Length;

            txtAdSoyad.Clear();
            txtTelNo.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Telefon.Length; i++)
            {
                lstRehber.Items.Add(Adsoyad[i] + " " + Telefon[i]);
            }


            //lstRehber.Items.AddRange(Adsoyad);rakamsal dizilerde hata verir.

            //foreach (string item in Adsoyad)
            //{
            //    lstRehber.Items.Add(item);
            //}


            /* 2 Boyutlu dizilerde ekleme işlemi*/

            //for (int i = 0; i < TelefonDefteri.Length; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        lstRehber.Items.Add(TelefonDefteri[i, j]);
            //    }
            //}

        }

        //2 boyutlu dizi
        string[,] TelefonDefteri = new string[50, 2];

        private void button2_Click(object sender, EventArgs e)
        {
            //Düzensiz dizi
            string[][,] aa = new string[6][,]{

            new string[,] {{"","",""}},

            new string[,] {{"","","",""} },

            new string[,] {{"","",""}},

            new string[,] {{"","",""}},

            new string[,] {{"","",""}},

             new string[,] {{"","",""}},
           };

            int a = aa[1].Length;
        }
    }
}
