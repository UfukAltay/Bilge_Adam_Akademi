using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b_Polymorphism_ToString__
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

            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adi = "Samet";
            ogr1.SoyAdi = "Uzun";

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Adi = "Celal";
            ogr2.SoyAdi = "Helvacı";

            listBox1.Items.Clear();


            // nesnenin objecte dönüşümüne boxing denir
            listBox1.Items.Add(ogr);
            listBox1.Items.Add(ogr1);
            listBox1.Items.Add(ogr2);

            listBox1.Items.Add(button1);
            listBox1.Items.Add("Ekrem");
            // nesneler çalışma zamanında veya derlenme zamanında stringe çevrilirken Projeismi.classIsmi ile çevrilir

            // derlenme zamanında listbox'a eleman eklerken object olarak eklenir...çalışma zamanında o elemanlar object olarak saklanır..son kullanıcıya gösterirkende string olarak gösterir...
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // objectin nesneye dönüşümüne unboxing denir
            object seciliOgrenci = listBox1.SelectedItem;

            // bu işlemi yaparken objecdeki tipin Ogrenci olduğuna emin olmalıyız...
            // NOt: Object kullanımında tip güvenliği yoktur... hatalar runtimeda oluşurlar...
            if (listBox1.SelectedItem is Ogrenci)
            {
                Ogrenci seciliOgr = (Ogrenci)listBox1.SelectedItem;
                MessageBox.Show(seciliOgr.Adi);
            }
            else
            {
                MessageBox.Show(seciliOgrenci.ToString());
            }
        }
    }
}
