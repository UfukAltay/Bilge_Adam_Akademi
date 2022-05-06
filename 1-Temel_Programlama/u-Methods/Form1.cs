using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // method parametreleri =>  methodun gövdesine dışardan değer aktarmaktır...

        // method adları => tanımlanan scope için verilen addır...methodu o adıyla çağırırız...

        // erişim belirleyicileri => Access Modifers (private,protected,public,internal,protected internal) bunlar methodun nerelerden erişilebileceğini derleyiciye söylerler... şimdilik sadece kendi sınıflarım için yazdığımız methodlara private erişim belirleyisini kullanırız...

        // donüş tipi => yazılın methodun çağrılan scop'a işlem yaptıktan sonra geri dönüş (return value) bildirmesidir... eğer bir method void ise geridönüşü(return value) yoktur... ama void değilse geri dönüşü(return value) vardır()


        // avantajları
        // method 1 kere yazılıp birden çok yerde çağrılıp kullanılabilir...
        // method tek bir yerden kontrol sağlar....
        // method program içerisinde modüllerle ilerleminizi sağlar...

        // dezavantajları
        // yoktur...

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Selam");
            MesajVersene();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Selam");
            MesajVersene();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Selam");
            MesajVersene();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mesaj2("A : Selam");
            Mesaj2("B : Slm");
            Mesaj2("A : NBR ???");
            Mesaj2("B : iiii");
            Mesaj2("bağlantı koptu");

            string deneme = "----";
            Mesaj2(deneme);
        }

        private void MesajVersene()
        {
            MessageBox.Show("Selam");
        }

        private void Mesaj2(string msj)
        {
            listBox1.Items.Add(msj);
        }
    }
}
