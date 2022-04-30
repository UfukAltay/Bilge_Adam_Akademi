using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_KararYapilariSwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // switch - case yapısı if bloklarının bir alternatifi değildir... daha basit ifler yerine kullanılabilir.. tek bir nesnenin veya değerin eşitlik durumu sorgulanabilir...

            int a = 1;
            // break => komutu bulunduğu scope'u kırar..Bulunduğu scope'daki  kullanılan satırın altındaki komutların hiçbirini çalıştırmaz
            switch (a)
            {
                case 1:
                    int ab = 4;
                    break;
                case 2:
                    break;
                case 5:
                    MessageBox.Show("Burası");
                    break;
                default:
                    // case'lerin değilsesi eğer caselerden birisi değilse değer direkt default kısmı çalışır....

                    MessageBox.Show("Bunlardan Birisi Değil");
                    break;
            }

            MessageBox.Show("Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "1":
                    MessageBox.Show("Pazartesi");
                    break;
                case "2":
                    MessageBox.Show("Salı");
                    break;
                case "3":
                    MessageBox.Show("Çarşamba");
                    break;
                case "4":
                    MessageBox.Show("Perşembe");
                    break;
                case "5":
                    MessageBox.Show("Cuma");
                    break;
                default:
                    MessageBox.Show("Geçerli bir değer giriniz");
                    break;
            }
        }
    }
}
