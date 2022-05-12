using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b1_PolymorphisimUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kedi k = new Kedi();

            MessageBox.Show(k.CikardigiSes());

            Kus ks = new Kus();

            MessageBox.Show(ks.CikardigiSes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HayvanlarAlemi[] alemci = new HayvanlarAlemi[2];

            Kus ks = new Kus();
            Kedi k = new Kedi();

            //HayvanlarAlemi av = k;
            alemci[0] = ks;
            alemci[1] = k;
            foreach (HayvanlarAlemi item in alemci)
            {
                MessageBox.Show(item.CikardigiSes());
            }
        }
    }
}
