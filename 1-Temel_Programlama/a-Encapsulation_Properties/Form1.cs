using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a_Encapsulation_Properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Yiğit";
            ogr.SoyAdi = "Yeprem";
            ogr.VizeNotu = 40;
            ogr.FinalNotu = 50;


            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adi = "DaVuT";
            ogr1.SoyAdi = "Avcı";
            ogr1.VizeNotu = 60;
            ogr1.FinalNotu = 50;

            //ogr1.Ortalama = 90; bu atama işlemi hatalı olacaktır... çünkü Ortalama propertysinin set bloğu kaldırıldığı için sadece okunabilir bir özelliktir..

            MessageBox.Show(ogr.Ortalama.ToString());
            MessageBox.Show(ogr1.Ortalama.ToString());
        }
    }
}
