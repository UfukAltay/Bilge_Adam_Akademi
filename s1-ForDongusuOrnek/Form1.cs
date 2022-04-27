using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s1_ForDongusuOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1 - 100 arası rasgele 10 adet sayı oluşturma...
            Random rnd = new Random();
            // int sayi = rnd.Next(1, 101); // max değer için istenilen sayının 1 fazlası yazılır...

            // MessageBox.Show(sayi.ToString());
            // Count => listbox eleman sayısını veren bir özelliktir
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }

            for (int i = 0; i < 10; i++)
            {
                int sayi = rnd.Next(1, 101);
                listBox1.Items.Add(sayi);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show(listBox1.SelectedItem.ToString());


            int sayi = Convert.ToInt32(listBox1.SelectedItem);

            listBox2.Items.Clear();

            for (int i = 0; i < sayi; i++)
            {
                listBox2.Items.Add("Merhaba");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sayi = listBox2.Items.Count;

            listBox3.Items.Clear();

            for (int i = sayi; i > 0; i--)
            {
                listBox3.Items.Add(i);
            }
        }
    }
}
