using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a1_PropertiesUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba arb = new Araba();
            arb.Marka = txtMarka.Text;
            arb.Model = txtModel.Text;
            arb.Renk = txtRenk.Text;
            arb.UretimYili = Convert.ToInt32(txtUretimYili.Text);
            arb.Aciklama = txtAciklama.Text;

            listBox1.Items.Add("------------");
            listBox1.Items.Add(arb.TumOzellikler);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Araba arb = new Araba();
            arb.Marka = "Ford";
            arb.Model = "Fiesta";
            arb.UretimYili = 2012;


            arb.Renk = "Beyaz";
            arb.Aciklama = "Sahibinden besmeleyle binilmiş küfür edilmemiş temiz araba";
            MessageBox.Show(arb.Aciklama);


            Araba arb2 = new Araba();
            arb2.Marka = "Renault";
            arb2.Model = "Clio";
            arb2.Renk = "Kırmızı";
            arb2.UretimYili = 2014;
            arb2.Aciklama = "Kırmızı çiçeğimi satıyorum  .... Sadece SOl ayna değişmemiş.";

            //BizimProp = textBox1.Text;

            listBox1.Items.Add(arb.TumOzellikler);
            listBox1.Items.Add("---------------");
            listBox1.Items.Add(arb2.TumOzellikler);

            //listBox1.Items.Add(String.Format("Marka = {0} Model= {1} Üretim Yılı {2} Renk {3}", arb.Marka, arb.Model, arb.UretimYili, arb.Renk));

            //listBox1.Items.Add(String.Format("Marka = {0} Model= {1} Üretim Yılı {2} Renk {3}", arb2.Marka, arb2.Model, arb2.UretimYili, arb2.Renk));
        }

        public string BizimProp
        {
            set
            {
                label1.Text = value;
            }
        }
    }
}
