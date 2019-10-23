using System;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-10";
            textBox2.Text = "10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            try
            {
                int a1 = int.Parse(textBox1.Text);
                int a2 = int.Parse(textBox2.Text);
                if (a1 < a2)
                {
                    while (a1 <= a2)
                    {
                        if (a1 <= a2)
                        {
                            if (a1 >= 0)
                                textBox3.Text += Environment.NewLine + "A = " + a1 + " X = " + Math.Pow(a1, 2) + ", Y = " + Math.Round(Math.Sqrt(a1), 3);
                            else
                                textBox3.Text += Environment.NewLine + "A = " + a1 + " X = " + Math.Pow(a1, 2) + ", Y = число отрицательное, корня нет";
                        }
                        a1++;
                    }
                }
                if (a1 > a2)
                {
                    while (a2 <= a1)
                    {
                        if (a2 <= a1)
                        {
                            if (a2 >= 0)
                                textBox3.Text += Environment.NewLine + "A = " + a2 + " X = " + Math.Pow(a2, 2) + ", Y = " + Math.Round(Math.Sqrt(a2), 3);
                            else
                                textBox3.Text += Environment.NewLine + "A = " + a2 + " X = " + Math.Pow(a2, 2) + ", Y = число отрицательное, корня нет";
                        }
                        a2++;
                    }
                }
                if (a1 == a2)
                    textBox3.Text += Environment.NewLine + "X = " + Math.Pow(a1, 2) + ", Y = " + Math.Sqrt(a1);
            }
            catch
            {
                MessageBox.Show("Введите целое число!");
            }
        }
    }
}
