using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u3_MethodsExample2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] isimler = { "Simge", "Baturay", "Gürkan", "Yiğit", "Ali", "Kübra", "Davut", "Celal", "Erkan", "Samet" };
            // method olacak... method bu dizide arama yapıp bize aranan değerin olup olmadığını söyleyecek...
            if (Arasana(isimler, textBox1.Text) == "var")
            {
                MessageBox.Show("Aranan eleman var");
            }
            else
            {
                MessageBox.Show("Aranan eleman yok");
            }
        }

        // değer parametresini dizide arıyacak...
        string Arasana(string[] dizi, string deger)
        {
            string donenDeger = "";
            if (Array.IndexOf(dizi, deger) > -1)
            {
                donenDeger = "var";
            }
            else
            {
                donenDeger = "yok";
            }

            return donenDeger;
        }
    }
}
