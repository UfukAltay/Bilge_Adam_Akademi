using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r1_Hatalar_TryCatch2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte sayi1 = Convert.ToByte(textBox1.Text);
                byte sayi2 = Convert.ToByte(textBox2.Text);

                int sonuc = sayi1 / sayi2;
                MessageBox.Show(sonuc.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //catch (FormatException fe)
            //{
            //    MessageBox.Show("Lütfen Rakam Giriniz");
            //}
            //catch (OverflowException ex)
            //{
            //    //  MessageBox.Show(ex.Message);
            //    MessageBox.Show("Girilen Değer Aralığı 0-255 olmalıdır");
            //}
            //catch (DivideByZeroException de)
            //{
            //    MessageBox.Show("0' bölünemez");
            //}

            // c#'daa bir çok hata sınıfı vardır.. Bütün hatalar içinde ayrı ayrı sınıflar vardır...

            // Exception => bu sınıfta bütün hataların atasıdırççç
            // FormatException => türdönüşümü format hataları..
            // OverflowException => değerin taşma hatasıdır...
            // DivideByZeroException => 0 bölünme hatasıdır...
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(textBox3.Text);
                MessageBox.Show("Girilen değer rakam... " + textBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Girilen değer rakam değildir... " + textBox3.Text);
            }
        }
    }
}
