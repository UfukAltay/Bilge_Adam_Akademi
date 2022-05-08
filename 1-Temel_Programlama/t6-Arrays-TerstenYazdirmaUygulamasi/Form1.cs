using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t6_Arrays_TerstenYazdirmaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = textBox1.Text.Length - 1; i >= 0; i--)
            {
                label1.Text += textBox1.Text[i];
            }
        }
    }
}
