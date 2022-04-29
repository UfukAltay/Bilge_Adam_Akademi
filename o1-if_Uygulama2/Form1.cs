using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace o1_if_Uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                MessageBox.Show("Pazartesi");
            }
            else if (textBox1.Text == "2")
            {
                MessageBox.Show("Salı");
            }
            else if (textBox1.Text == "3")
            {
                MessageBox.Show("Çarşamba");
            }
            else if (textBox1.Text == "4")
            {
                MessageBox.Show("Perşembe");
            }
            else if (textBox1.Text == "5")
            {
                MessageBox.Show("Cuma");
            }
            else if (textBox1.Text == "6")
            {
                MessageBox.Show("Cumartesi");
            }
            else if (textBox1.Text == "7")
            {
                MessageBox.Show("Pazar");
            }
            else
            {
                MessageBox.Show("Geçerli bir tuşa basınız...");
            }
        }
    }
}
