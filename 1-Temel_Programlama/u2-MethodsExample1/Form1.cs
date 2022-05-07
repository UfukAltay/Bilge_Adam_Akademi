using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u2_MethodsExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // kullanıcı Adı admin şifre 123 ise hoş geldin admin değilse hatalı bilgi girdiniz mesajı veren prog...


            //if (KontrolEt(textBox1.Text, textBox2.Text) == true)
            if (KontrolEt(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Hoş Geldin Admin");
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi Girdiniz");
            }
        }

        bool KontrolEt(string kullaniciAdi, string Sifre)
        {

            if (kullaniciAdi == "Admin" && Sifre == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
