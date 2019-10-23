using System;
using System.Windows.Forms;

namespace PP_LR4
{
    public partial class Form1 : Form
    {
	/*The task: to write a method that counts the number of punctuation in the passed string. 
	Use it to process five different lines and display the results on the screen.*/

        public Form1()
        {
            InitializeComponent();
        }

        public string Znaki (string stroka)
        {
            int kol = 0;
            for(int i=0; i<stroka.Length; i++)
            {
                switch(stroka[i])
                {
                    case '.':
                    case ',':
                    case ':':
                    case ';':
                    case '-':
                    case '!':
                    case '?':
                        {
                            kol++;
                            break;
                        }
                    default: break;
                }
            }
            stroka = kol.ToString();
            return stroka;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("В первой строке " + Znaki(textBox1.Text) + " знаков препинания.");
            listBox1.Items.Add("Во второй строке " + Znaki(textBox2.Text) + " знаков препинания.");
            listBox1.Items.Add("В третей строке " + Znaki(textBox3.Text) + " знаков препинания.");
            listBox1.Items.Add("В четвертой строке " + Znaki(textBox4.Text) + " знаков препинания.");
            listBox1.Items.Add("В пятой строке " + Znaki(textBox5.Text) + " знаков препинания.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
