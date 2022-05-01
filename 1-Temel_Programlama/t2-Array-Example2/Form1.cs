using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t2_Array_Example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] isimler = new string[8];
        private void button1_Click(object sender, EventArgs e)
        {
            // dizi oluşturulacak... listbox'a eklenecek
            isimler[0] = "Simge";
            isimler[1] = "Gürkan";
            isimler[2] = "Tunay";
            isimler[3] = "Yiğit";
            isimler[4] = "Ali";
            isimler[5] = "Celal";
            isimler[6] = "Davut";
            isimler[7] = "Erkan";

            foreach (string item in isimler)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int sayi = rnd.Next(0, 8);
            MessageBox.Show(isimler[sayi]);
            // diziden rasgele eleman seçilecek...
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kelime = textBox1.Text;

            int i = 0, j = kelime.Length - 1;
            bool bl = false;
            while (i < j)
            {
                char ilk = kelime[i];
                char sonk = kelime[j];
                if (ilk == sonk)
                {
                    bl = true;
                }
                else
                {
                    bl = false;
                    break;
                }
                i++;
                j--;
            }

            if (bl)
            {
                listBox2.Items.Add(kelime);
            }
            else
            {
                listBox3.Items.Add(kelime);
            }
        }
    }
}
