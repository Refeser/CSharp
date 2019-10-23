using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l5
{
    public partial class Form1 : Form
    {
        int k = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        if (k%2 == 0)
                        {
                            Button button = new Button();
                            button.Parent = this;
                            button.Size = new Size(60, 20);
                            button.Location = new Point(e.Location.X, e.Location.Y);
                            button.Text = "Кнопка";
                            button.Show();
                            k++;
                        }
                        else
                        {
                            TextBox textbox = new TextBox();
                            textbox.Parent = this;
                            textbox.Size = new Size(60, 20);
                            textbox.Location = new Point(e.Location.X-60, e.Location.Y-20);
                            textbox.Text = "Поле";
                            textbox.Show();
                            k++;
                        }
                        break;
                    }
            }
        }
    }
}
