using System;
using System.Windows.Forms;

namespace PP_LR3
{
    public partial class Form1 : Form
    {
        double f_x;
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                double x = Convert.ToDouble(textBox2.Text.Replace('.', ','));
                double alpha = Convert.ToDouble(textBox3.Text.Replace('.', ','));
                
                if (radioButton1.Checked)
                    f_x = Math.Sinh(x);
                if (radioButton2.Checked)
                    f_x = Math.Pow(x, 2);
                if (radioButton3.Checked)
                    f_x = Math.Pow(Math.E, x);
                if ((Math.Abs(x)) > 1 && (Math.Abs(x) < 3))
                {
                    alpha = ((a * Math.Pow(x, 2) + 2) / (Math.Pow(x, 2) + 1)) * f_x;
                }
                if (Math.Abs(x) >= x)
                {
                    alpha = Math.Pow(alpha, 2) + f_x;
                }
                if (Math.Abs(x) <= 1)
                {
                    alpha = (a * x) * (f_x / (x + 2));
                }
                listBox1.Items.Clear();
                listBox1.Items.Add("At:");
                listBox1.Items.Add("A = " + textBox1.Text);
                listBox1.Items.Add("X = " + textBox2.Text);
                listBox1.Items.Add("Alpha = " + textBox3.Text);
                listBox1.Items.Add("Result = " + alpha);
            }
            catch
            {
                MessageBox.Show("Mistake! Invalid values entered!");
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listBox1.Items.Clear();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
