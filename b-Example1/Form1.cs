using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b_Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // yorum satır.. derleyici yorum satırlarını dikkate almaz


            //name özelliği kontrol için benzersiz bir özelliktir.. kontrolleri name özelliği sayedinde tanırız..name özelliğindeki değerler benzersiz olmalıdır...


            // = atama operatörüdür... sağdaki değeri soldaki değere atar...
            // atama operatörü katı bu operatördür...sağdaki değerle sodaki değer eşit olmak zorundadır...

            //  bir kontrolün (buttonun) özelliklerine gidebilmek için . kullanırız (kontrol.ozellik gibi)


            // c# büyük-küçük harf duyarlılığı olan bir prg. dilidir... yani nasıl tanımlandıysa öyle çağrılmak zorundadır...

            // c#'da komut satırları ; ile sonlandırılmalıdır...

            // c#'da açılan herşey kapatılmalıdır.. bu genel bir kuraldır....,
            

            button1.Text = "Tıklandı";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Text = "Üzerime gelme :D";
        }
    }
}
