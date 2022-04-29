using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r_HataYonetimiVeHatalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // runtime'da hata oluşursa eğer hata oluşan satırın altındaki hiç bir komut çalışmaz.. ama program çalışmaya devam eder... Bu satırda veri dışarıdan geleceği için program hata verme olasılığı her zman vardır...

            // c#'da bütün hatalara karşılık gelen hata sınıfları vardır..

            // hataları yönetmek için try-catch blokları kullanılır... catch bloğu try bloğundaki hataları yakalar.... try'da hata oluşunca catch bloğu devreye girer.. hata satırının altındaki hiç bir komut çalışmaz.. direkt catch bloğu çalışır

            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                a += 5;
                MessageBox.Show("Toplam = " + a.ToString());
            }
            catch
            {
                MessageBox.Show("Lütfen rakam giriniz");
            }
        }
    }
}
