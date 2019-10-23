using System;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        double fx, otvet;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                double q = Convert.ToDouble(textBox2.Text.Replace('.', ','));
                if (radioButton1.Checked)
                    fx = Math.Sinh(x);
                if (radioButton2.Checked)
                    fx = Math.Pow(x, 2);
                if (radioButton3.Checked)
                    fx = Math.Pow(Math.E, x);
                if (Math.Abs(x * q) > 10)
                {
                    otvet = Math.Log(Math.Abs(fx) + Math.Abs(q));
                }
                else
                {
                    if (Math.Abs(x * q) < 10)
                        otvet = Math.Pow(Math.E, (fx + q));
                    else
                    {
                        if (Math.Abs(x * q) == 10)
                            otvet = fx + q;
                    }
                }
                textBox3.Text = "X = " + x + Environment.NewLine;
                textBox3.Text += "Q = " + q + Environment.NewLine;
                textBox3.Text += "f(x) = " + Math.Round(fx, 3) + Environment.NewLine;
                textBox3.Text += "Ответ: " + Math.Round(otvet, 3);
            }
            catch
            {
                MessageBox.Show("Ошибка! Введены неверные значения!");
            }
        }
    }
}
