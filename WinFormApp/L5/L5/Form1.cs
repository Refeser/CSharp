using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L5
{
    public partial class Form1 : Form
    {
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
                        if (e.Location.X>=0 && e.Location.X <= this.Width/2)
                        {
                            Button button = new Button();
                            button.Parent = this;
                            button.Size = new Size(60, 20);
                            button.Location = new Point(e.Location.X, e.Location.Y);
                            button.Text = "Слева";
                            button.Show();
                        }
                        else
                        {
                            TextBox textbox = new TextBox();
                            textbox.Parent = this;
                            textbox.Size = new Size(60, 20);
                            textbox.Location = new Point(e.Location.X, e.Location.Y);
                            textbox.Text = "Справа";
                            textbox.Show();
                        }
                        break;
                    }
            }
        }
    }
}
