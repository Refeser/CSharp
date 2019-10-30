using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

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
                DialogResult rez = MessageBox.Show("Сохранить текущий файл?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rez == DialogResult.Yes){
                    сохранитьКакToolStripMenuItem_Click(sender, e);
                }
                if (rez == DialogResult.No){
                    очиститьToolStripMenuItem_Click(sender, e);
                }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + @"\" + "Save_Channel.xlsx";

            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            for (int i = 1; i < dataGridView1.RowCount + 1; i++) {
                for (int j = 1; j < dataGridView1.ColumnCount + 1; j++) {
                    worksheet.Rows[i].Columns[j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            excelapp.AlertBeforeOverwriting = false;
            workbook.SaveAs(path);
            excelapp.Quit();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            ofd.Title = "Выберите документ Excel";

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Process.Start(ofd.FileName);
        }

        private int columnsNumber(string itm)
        {
            int num = 0;
            switch (itm) {
                case "A":
                    num = 1;
                    break;
                case "B":
                    num = 2;
                    break;
                case "C":
                    num = 3;
                    break;
                case "D":
                    num = 4;
                    break;
                case "E":
                    num = 5;
                    break;
                case "F":
                    num = 6;
                    break;
                case "G":
                    num = 7;
                    break;
                case "H":
                    num = 8;
                    break;
                case "I":
                    num = 9;
                    break;
                case "K":
                    num = 10;
                    break;
            }
            return num;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string a1, a2, b1, b2;
                a1 = comboBox1.SelectedItem.ToString();
                a2 = comboBox2.SelectedItem.ToString();
                b1 = comboBox3.SelectedItem.ToString();
                b2 = comboBox4.SelectedItem.ToString();
                if (columnsNumber(a1) == 0 || columnsNumber(b1) == 0)
                {
                    MessageBox.Show("Вы не выбрали колонку!");
                }
                else {
                    string s1, s2;
                    s1 = (string)dataGridView1[columnsNumber(a1), int.Parse(a2)].Value;
                    s2 = (string)dataGridView1[columnsNumber(b1), int.Parse(b2)].Value;
                    dataGridView1.Rows[int.Parse(b2)-1].Cells[columnsNumber(b1)-1].Value = (string)s1 + (string)s2;
                }
            }
            catch {
                MessageBox.Show("Error!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            сохранитьКакToolStripMenuItem_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Внимание! объединение ячейки 1 с ячейкой 2 происходит в ячейку на 1 правее и ниже второй ячейки! Не баг, а фича!");
        }
    }
}
