using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d_Example3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // + => toplama operatörü 

            //button1.Left = button1.Left + 10;
            // button1.Top = button1.Top + 10;

            // 2 yol
            button1.Left += 10;
            button1.Top += 10;

            // bu özellikler değerler aynıda olsa değiştirilemez.. sadece okunabilir özelliklerdirler...
            //button1.Right = 10; 
            //button1.Bottom = 10;
        }
    }
}
