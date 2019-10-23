using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
	/*Task: to place on the form a number of input fields (TextBox). 
	Create event handlers for clicking the input field data, 
	which will display its number in the current input field. 
	Create a form resize event handler (Resize) 
	that will clear all input fields.*/

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "2";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "3";
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
