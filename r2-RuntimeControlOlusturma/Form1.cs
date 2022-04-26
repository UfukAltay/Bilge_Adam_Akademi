using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r2_RuntimeControlOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            // button oluştur

            for (int i = 1; i <= 20; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.BackColor = Color.Red;
                btn.Width = 100;
                btn.Height = 50;

                this.Controls.Add(btn);
                flowLayoutPanel1.Controls.Add(btn);
            }
            // oluşan butonu forma ekle

            // içinde bulunduğumuz class'ın o anki instance'dır... instance (bellek üzerindeki örneği)
            //  this.Controls.Add(btn);

            // c#'ta iki adet tip vardır...
            // value Type => değer Tipler=> sadece değer tutarlar...(struct value Typler bir struct)
            // Reference Type => Referans tipler.. sadece referans tutarlar...(class referans Typler classlardır...)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            Color[] renkler = { Color.White, Color.Yellow, Color.Red, Color.Purple, Color.Pink, Color.Brown, Color.AliceBlue, Color.Bisque, Color.Firebrick, Color.DarkSalmon, Color.Blue, Color.Gray, Color.Blue };

            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.Width = 75;
                btn.Height = 50;
                btn.BackColor = renkler[rnd.Next(0, renkler.Length)];
                btn.Text = i.ToString();


                flowLayoutPanel1.Controls.Add(btn);
            }
        }
    }
}
