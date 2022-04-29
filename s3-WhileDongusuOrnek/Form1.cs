using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s3_WhileDongusuOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;

            comboBox3.Enabled = false;

            int gun = 1, ay = 1, yil = 1950;

            // gunleri combobox1'e ekleme
            while (gun <= 31)
            {
                comboBox1.Items.Add(gun);
                gun++;
            }

            while (ay <= 12)
            {
                comboBox2.Items.Add(ay);
                ay++;
            }

            while (yil < 2016)
            {

                comboBox3.Items.Add(yil);
                yil++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Enabled == true && comboBox2.Enabled == true && comboBox3.Enabled == true)
            {

                // string birlerşirme

                String.Format("{0} / {1} / {2}", "Ekrem", "Burak", "Samet");  // Ekrem / Burak / Samet

                // 2 yol
                string str = String.Format("{0} / {1} / {2} Seçtiniz", comboBox1.SelectedItem, comboBox2.SelectedItem, comboBox3.SelectedItem);


                // bildiğimiz yol
                //string str2 = comboBox1.SelectedItem.ToString() + " / " + comboBox2.SelectedItem.ToString() + " /" + comboBox3.SelectedItem.ToString();

                MessageBox.Show(str);
            }
            else
            {
                MessageBox.Show("Lütfen Gün-ay-yıl seçimlerini yapınız");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
        }
    }
}
