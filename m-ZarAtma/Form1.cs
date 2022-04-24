using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace m_ZarAtma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblBirinciZar.Text = rnd.Next(1, 7).ToString();
            lblİkinciZar.Text = rnd.Next(1, 7).ToString();

            sayac++;
            switch (sayac)
            {
                case 20:
                    timer1.Interval = 200;
                    break;
                case 30:
                    timer1.Interval = 300;
                    break;
                case 40:
                    timer1.Stop();
                    timer1.Enabled = false;
                    break;
                default:
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayac = 0;
            timer1.Interval = 100;
            timer1.Enabled = true;
            //timer1.Start();
        }
    }
}
