using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n_DijitalSaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
        }

        int saniye = 0;
        int dakika = 0;
        int saat = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            saniye++;


            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
                if (dakika == 60)
                {
                    dakika = 0;
                    saat++;
                    if (saat == 24)
                    {
                        saat = 0;

                    } //saat if i 

                    if (saat < 10)
                    {
                        lblSaat.Text = "0" + saat.ToString();
                    }
                    else
                        lblSaat.Text = saat.ToString();


                }//dakika if i

                if (dakika < 10)
                {
                    lblDakika.Text = "0" + dakika.ToString();
                }
                else
                    lblDakika.Text = dakika.ToString();
            }//saniye if inin bitişi

            if (saniye < 10)
            {
                lblSaniye.Text = "0" + saniye.ToString();
            }
            else
                lblSaniye.Text = saniye.ToString();
        }
        
    }
}
