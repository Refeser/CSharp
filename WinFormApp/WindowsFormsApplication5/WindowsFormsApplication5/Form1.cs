using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        TextBox textbox = new TextBox();
        int i = 0, j = 0;
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
                        if (i == 0)
                        {
                            textbox = new TextBox();
                            textbox.Parent = this;
                            textbox.Size = new Size(50, 20);
                            textbox.Location = new Point(e.Location.X, e.Location.Y);
                            textbox.Show();
                            i++;
                        }
                        else
                        {
                            if (i == 1)
                            {
                                Label lbl = new Label();
                                lbl.Parent = this;
                                lbl.Text = "label";
                                lbl.Size = new Size(50, 20);
                                lbl.Location = new Point(e.Location.X, e.Location.Y);
                                lbl.Show();
                                i++;
                            }
                            else
                            {
                                i = 0;
                                textbox = new TextBox();
                                textbox.Parent = this;
                                textbox.Size = new Size(50, 20);
                                textbox.Location = new Point(e.Location.X, e.Location.Y);
                                textbox.Show();
                                i++;
                            }
                        }
                        break;
                    }
                case MouseButtons.Right:
                    {
                        foreach (Control textbox in this.Controls)
                            if (textbox is TextBox)
                            {
                                this.Controls.Remove(textbox as TextBox);
                            }
                        break;
                    }
            }
        }
    }
}
