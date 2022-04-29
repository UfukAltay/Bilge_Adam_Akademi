using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q_Listbox_ComboboxKontrolleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // object c#'da herşeyin(bütün tiplerin) atasıdır...yani c#'da herşey birer object'dir...farklı tiplerdeki değerler object'de saklanabilir...

            // boxing => kutulama
            object o = "C# dersleri";
            int sayi = 4;
            // boxing => kutulama
            object obj = sayi;

            listBox1.Items.Add("Ekrem");
            listBox1.Items.Add('A');
            listBox1.Items.Add(44);
            listBox1.Items.Add(false);
            listBox1.Items.Add(4.1f);

            // combobox'a eleman ekleme
            comboBox1.Items.Add("Ekrem Yıldırım");
            comboBox1.Items.Add("Samet");
            comboBox1.Items.Add("Tayfun");
            comboBox1.Items.Add("Burak");
            comboBox1.Items.Add("Davut");
            comboBox1.Items.Add("Celal");
            comboBox1.Items.Add("Ufuk");
            comboBox1.Items.Add("Baturay");
            comboBox1.Items.Add("Yiğit");
            comboBox1.Items.Add("Gürkan");
            comboBox1.Items.Add("Tunay");
            comboBox1.Items.Add("Barış");
            comboBox1.Items.Add("Simge");
        }
    }
}
