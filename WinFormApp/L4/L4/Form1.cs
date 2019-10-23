using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double max(double x, double y)
        {
            if (x > y)
                return x;
            else
                if (x < y)
                return y;
            return x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text), b = double.Parse(textBox2.Text), c = double.Parse(textBox3.Text), d = double.Parse(textBox4.Text);
                double maximum = max(a, b);
                maximum = max(maximum, c);
                maximum = max(maximum, d);
                textBox5.Text = "Максимальное число = " + maximum;
            }
            catch
            {
                MessageBox.Show("Вы ввели не число!");
            }
        }
    }
}
