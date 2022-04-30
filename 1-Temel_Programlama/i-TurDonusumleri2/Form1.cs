using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace i_TurDonusumleri2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dikkat : Convert işlemlerinde farklı değerler birbierlerine çevrilebilir.. ama formatlar aynı olmalı

            // True "True" 1

            // "A" sayıya çevrilemez sayı formatında bir değer değildir. "1" sayıya bir olarak çevrilir

            // 'A' sayıya çevrilebilir ama ascii kod karşılığı ile.. '1' sayıya çevrilebilir... fakat 1 olarak değil ascii kod karşılığı olarak

            int a = Convert.ToInt32("1");
            //     int ac = Convert.ToInt32("AA"); hata alırız

            bool dgr = Convert.ToBoolean("False");
            bool kontrol = Convert.ToBoolean(1);




            int b = Convert.ToInt32('1'); // char içerisindeki değeri ascii kod karşılığını b'ye çevirir
            int s = Convert.ToInt32('1'); // char içerisindeki değerin ascii kod karşılığını s'ye çevirir

            char c = Convert.ToChar(49); // 49 sayısının ascii kod karşılığı 1 olarak çevirir

            char c1 = Convert.ToChar("A");
            char c2 = Convert.ToChar("AA");
        }
    }
}
