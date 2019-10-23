using System;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength != 0){
                DialogResult rez = MessageBox.Show("Сохранить текущие изменения?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rez == DialogResult.Yes){
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.FileName = "TextFile";
                    sfd.Filter = "Текстовый файл|*.txt";
                    if(sfd.ShowDialog() == DialogResult.OK){
                        File.WriteAllText(sfd.FileName, textBox1.Text);
                        textBox1.Clear();
                    }
                }
                if (rez == DialogResult.No){
                    textBox1.Clear();
                }
        }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "TextFile";
            sfd.Filter = "Текстовый файл|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBox1.Text);
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Текстовые файлы|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK){
                textBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }

        string str;

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            str = textBox1.SelectedText.ToString();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste(str.ToString());
        }
    }
}
