using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u1_Methods1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // geriye değer döndüren methodu çağırma

            // METHODDAN GELEN değer değişkene atanıp kullanılabilir...  eğer değişkene atmayıp 
            // geriye gelen değeri değişken bütün işlemlerde kullanabilirsiniz (sadece değer atamak hariç) methodlara değer atanmaz...methodlara değer gönderilir parametre ile
            bool a = varmi();

            if (varmi())
            {

            }
            else
            {

            }
        }

        // return komutu kullanıldığı scopu sonlandırmak için kullanılır... return komutu methodlarda kullandığımız zaman eğer method void ise kendi başına kullanabilir...method tipi void değilse return komutu kesinlikle kullanılmak zorundadır.. çünkü return o bloğu sonlandırırken methodda işimiz bittiğinde return ile bittiğini söyleyip çıkarken dönüş tipinde bir değeri çıkarmak zorudayız...

        // geriye değer döndüren methodlar... void dışında bütün tipler bu kategoriye girer.. ama çağrıldığı scopa işlem bittikten sonra değer taşımaktır... 
        private void BosMethod()
        {
            string str = "Tipsiz method";
        }

        private bool varmi()
        {
            return false;
        }

        private int Met1()
        {
            int a = 4;
            return a;
        }
    }
}
