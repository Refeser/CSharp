using System;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            try
            {
                int Ot = int.Parse(textBox1.Text);
                int Do = int.Parse(textBox2.Text);
                if (Ot < Do)
                {
                    while (Ot <= Do)
                    {
                        if (Ot == 0) textBox3.Text += Environment.NewLine + "Это 0";
                        if (Ot > 0)
                            textBox3.Text += Environment.NewLine + "Квадрат числа " + Ot + " = " + Math.Pow(Ot, 2);
                        else
                        {
                            if (Ot < 0)
                                textBox3.Text += Environment.NewLine + "Куб числа " + Ot + " = " + Math.Pow(Ot, 3);
                        }
                        Ot++;
                    }
                }
                else
                {
                    if (Ot > Do)
                    {
                        while (Do <= Ot)
                        {
                            if (Do == 0) textBox3.Text += Environment.NewLine + "Это 0";
                            if (Do > 0)
                                textBox3.Text += Environment.NewLine + "Квадрат числа " + Do + " = " + Math.Pow(Do, 2);
                            else
                            {
                                if (Do < 0)
                                    textBox3.Text += Environment.NewLine + "Куб числа " + Do + " = " + Math.Pow(Do, 3);
                            }
                            Do++;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введите целое число!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-10";
            textBox2.Text = "10";
        }
    }
}
