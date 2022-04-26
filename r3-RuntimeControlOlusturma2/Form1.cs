using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r3_RuntimeControlOlusturma2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Yeni Button";
            btn.Width = 60;
            btn.Height = 50;
            // code behind'da olay oluşturma
            // olay adını yazdıktan sonra += ile tab tab yaparsanız o olay için bir method oluşturacaktır....
            btn.Click += btn_Click;
            flowLayoutPanel1.Controls.Add(btn);
        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int j = 0; j < 5; j++)
            {
                Button btn1 = new Button();
                btn1.Text = j.ToString();
                btn1.Width = 50;
                btn1.Height = 50;
                btn1.Click += btn1_Click;
                flowLayoutPanel1.Controls.Add(btn1);
            }
        }

        // object sender parametresi bu olayı tetikleyen kontroldür...
        void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Text);
        }
    }
}
