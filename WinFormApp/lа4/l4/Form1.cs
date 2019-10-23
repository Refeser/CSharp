using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = "";
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);

                double rez_a = Math.Sin(a) + Math.Cos(2 * a);
                double rez_b = Math.Sin(b) + Math.Cos(2 * b);
                double rez_c = Math.Sin(c) + Math.Cos(2 * c);

                if (rez_a < rez_b && rez_a < rez_c)
                    textBox4.Text = "В точке а минимальный результат = " + Math.Round(rez_a,3);
                else
                    if (rez_b < rez_a && rez_b < rez_c)
                    textBox4.Text = "В точке b минимальный результат = " + Math.Round(rez_b, 3);
                else
                    if (rez_c < rez_b && rez_c < rez_a)
                    textBox4.Text = "В точке c минимальный результат = " + Math.Round(rez_c, 3);
                else
                    textBox4.Text = "Значение во всех точках одинаковое = " + Math.Round(rez_a, 3);
            }
            catch
            {
                MessageBox.Show("Введите целые числа!");
            }
        }
    }
}
