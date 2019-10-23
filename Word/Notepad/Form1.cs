using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool fbold = false;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength != 0){
                DialogResult rez = MessageBox.Show("Сохранить текущие изменения?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rez == DialogResult.Yes){
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.FileName = "NewFile";
                    sfd.Filter = "Файл MS Word|*.docx";
                    if(sfd.ShowDialog() == DialogResult.OK){
                        File.WriteAllText(sfd.FileName, richTextBox1.Text);
                        richTextBox1.Clear();
                    }
                }
                if (rez == DialogResult.No){
                    richTextBox1.Clear();
                }
        }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "NewFile";
            sfd.Filter = "Файл MS Word|*.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, richTextBox1.Text);
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Файл MS Word|*.docx";
            if (ofd.ShowDialog() == DialogResult.OK){
                richTextBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void жToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, this.Font.Size, FontStyle.Bold);
        }

        private void курсивныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, this.Font.Size, FontStyle.Italic);
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, this.Font.Size, FontStyle.Regular);
        }

        private void перечеркнутыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, this.Font.Size, FontStyle.Strikeout);
        }

        private void подчеркнутыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, this.Font.Size, FontStyle.Underline);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,\b]");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text.ToString());
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, num, richTextBox1.SelectionFont.Style);
            }
            catch
            {
                MessageBox.Show("Не удается поменять шрифт!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Times new roman", 14, FontStyle.Regular);
        }

        private void courierNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Courier new", 14, FontStyle.Regular); 
        }

        private void tahomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void comicSansMsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Comic sans ms", 14, FontStyle.Regular);
        }

        private void brushScriptMtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Brush script mt", 14, FontStyle.Regular); 
        }

        string str;

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //str = richTextBox1.SelectedText;
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.Paste(str);
        }
    }
}
