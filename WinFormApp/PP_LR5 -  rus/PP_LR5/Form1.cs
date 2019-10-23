using System;
using System.Drawing;
using System.Windows.Forms;

namespace PP_LR5
{
    public partial class Form1 : Form
    {
	/*The task: to create a program with two buttons on a 
	form that dynamically generates labels or input fields on the window. 
	When you click on the first button, each label is horizontally doubled. 
	When you click on the second button, each field is halved vertically.*/

        public Form1()
        {
            InitializeComponent();
        }

        int y_l = 30;
        int x_size = 10;
        private void button1_Click(object sender, EventArgs e)
        {
           
            Label l = new Label();
            l.Text = "label";
            l.Parent = this;
            l.Location = new Point(100, y_l);
            
            l.Size = new Size(x_size, 10);
            l.Width *= 2;
            l.Text += "label";
            l.Show();
            x_size *= 2;
            y_l += 30;
        }
        int y = 60;
        int y_size = 30;
        private void button2_Click(object sender, EventArgs e)
        {
            TextBox t = new TextBox();
            t.Multiline = true;
            t.Parent = this;
            t.Location = new Point(300, y);
            t.Size = new Size(100, y_size);
            t.Height *= 2;
            t.Show();

            y_size /= 2;
            y += 70;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
