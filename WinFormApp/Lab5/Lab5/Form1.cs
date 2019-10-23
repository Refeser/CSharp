using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 20, y = 5;
        Panel pan = new Panel();
        TextBox tb = new TextBox();
        public void button1_Click(object sender, EventArgs e)
        {
            pan = new Panel();
            pan.Parent = this;
            pan.Location = new Point(x, 100);
            x += 80;
            pan.Size = new Size(70, 90);
            pan.BackColor = Color.Green;
            pan.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb = new TextBox();
            foreach (Control c in this.Controls)
                if (c is Panel)
                {
                    tb = new TextBox();
                    tb.Parent = c;
                    tb.Size = new Size(20, 10);
                    tb.Location = new Point(5, y);
                    tb.Show();
                }
            y += 20;
        }
    }
}
