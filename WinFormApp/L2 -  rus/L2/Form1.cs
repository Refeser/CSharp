using System;
using System.Windows.Forms;

namespace L2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "3,7";
            textBox2.Text = "0,07";
            textBox3.Text = "1,5";
            textBox4.Text = "5,75";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double a = double.Parse(textBox1.Text.Replace('.',','));
                textBox5.Text += "a = " + a.ToString();
                double b = double.Parse(textBox2.Text.Replace('.', ','));
                textBox5.Text += Environment.NewLine + "b = " + b.ToString();
                double c = double.Parse(textBox3.Text.Replace('.', ','));
                textBox5.Text += Environment.NewLine + "c = " + c.ToString();
                double x = double.Parse(textBox4.Text.Replace('.', ','));
                textBox5.Text += Environment.NewLine + "x = " + x.ToString();
                double y = Math.Sqrt(c * x);
                y -= 2.7 * ((Math.Abs(c) + Math.Abs(x)) / (Math.Pow(c, 2) * Math.Pow(x, 2))) * Math.Pow(Math.E, (c * x)); ;
                y += Math.Cos(Math.Pow(a + b, 2) / (c * x - b));
                y = Math.Round(y, 3);
                textBox5.Text += Environment.NewLine + "Result Y = " + y.ToString();
            }
            catch
            {
                MessageBox.Show("Insert the number!");
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
