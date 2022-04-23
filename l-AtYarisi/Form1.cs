using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        private void btnBasla_Click_1(object sender, EventArgs e)
        {
            timer1.Interval = 250;
            timer1.Start();
        }

        Random rnd = new Random();        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Left += rnd.Next(10, 35);
            pictureBox2.Left += rnd.Next(10, 35);
            pictureBox3.Left += rnd.Next(10, 35);
            pictureBox4.Left += rnd.Next(10, 35);

            if ((pictureBox1.Left + pictureBox1.Width) >= lblFinish.Left && pictureBox1.Left > pictureBox2.Left && pictureBox1.Left > pictureBox3.Left && pictureBox1.Left > pictureBox4.Left)
            {
                timer1.Stop();
                MessageBox.Show("Şahbatur Kazandı");
                pictureBox1.Left = pictureBox2.Left = pictureBox3.Left = pictureBox4.Left = 5;
            }
            else if ((pictureBox2.Left + pictureBox2.Width) >= lblFinish.Left && pictureBox2.Left > pictureBox3.Left && pictureBox2.Left > pictureBox4.Left && pictureBox2.Left > pictureBox1.Left)
            {
                timer1.Stop();
                MessageBox.Show("GülBatur Kazandı");
                pictureBox1.Left = pictureBox2.Left = pictureBox3.Left = pictureBox4.Left = 5;
            }
            else if ((pictureBox3.Left + pictureBox3.Width) >= lblFinish.Left && pictureBox3.Left > pictureBox2.Left && pictureBox3.Left > pictureBox1.Left && pictureBox4.Left > pictureBox4.Left)
            {
                timer1.Stop();
                MessageBox.Show("Fehmi Kazandı");
                pictureBox1.Left = pictureBox2.Left = pictureBox3.Left = pictureBox4.Left = 5;
            }
            else if ((pictureBox4.Left + pictureBox4.Width) >= lblFinish.Left && pictureBox4.Left > pictureBox2.Left && pictureBox4.Left > pictureBox3.Left && pictureBox4.Left > pictureBox1.Left)
            {
                timer1.Stop();
                MessageBox.Show("Kara Şimşek Kazandı");
                pictureBox1.Left = pictureBox2.Left = pictureBox3.Left = pictureBox4.Left = 5;
            }
        }        
    }
}
