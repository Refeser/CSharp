using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PropusknoiPunkt
{
    public partial class AdminForm : Form
    {
        ///////////////////////////////////////////////
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PPDB-2003.mdb;";
        //public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PPDB-2003.mdb;";
        private OleDbConnection myConnection;
        private Form _form2;
        private Form _form1;
        ///////////////////////////////////////////////
        public AdminForm(Form form2, Form form1)
        {
            InitializeComponent();
            _form2 = form2;
            _form1 = form1;
            textBox3.MaxLength = 10;
            try
            {
                myConnection = new OleDbConnection(connectString);
                myConnection.Open();
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к серверу! Попробуйте повторить позже.");
            }
        }
        ///////////////////////////////////////////////
        private void LogOut(object sender, EventArgs e)
        {
            this.Hide();
            _form1.Show();
        }
        ///////////////////////////////////////////////
        private void Back(object sender, EventArgs e)
        {
            this.Hide();
            _form2.Show();
        }
        ///////////////////////////////////////////////
        private void UserForm_Load(object sender, EventArgs e) //дата и время при загрузке
        {
            timer1.Start();
            label9.Text = DateTime.Now.ToLongDateString();
            label10.Text = DateTime.Now.ToLongTimeString();
        }
        ///////////////////////////////////////////////
        private void timer1_Tick(object sender, EventArgs e) //дата и время таймер
        {
            label10.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        ///////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)//добавление сотрудника
        {
            try
            {
                string s1 = '"' + textBox1.Text + '"', s2 = '"' + textBox4.Text + '"', s3 = '"' + textBox3.Text + '"', s4 = '"' + textBox2.Text + '"', s5 = '"' + textBox9.Text + '"';
                string query = "INSERT INTO Accounts VALUES (" + s1 + ',' + s2 + ',' + s3 + ',' + s4 + ',' + s5 + ");";
                OleDbCommand command1 = new OleDbCommand(query, myConnection);
                command1.Connection = myConnection;
                command1.ExecuteNonQuery();

                string _s1 = '"' + textBox1.Text + '"', _s2 = '"' + textBox6.Text + '"', _s3 = '"' + textBox8.Text + '"', _s4 = '"' + textBox5.Text + '"', _s5 = '"' + textBox7.Text + '"';
                string query2 = "INSERT INTO Workers VALUES (" + _s1 + ", " + _s2 + ", " + _s3 + ", " + _s4 + ", " + _s5 + ");";
                OleDbCommand command2 = new OleDbCommand(query2, myConnection);
                command2.Connection = myConnection;
                command2.ExecuteNonQuery();
                MessageBox.Show("Сотрудник успешно добавлен!");

                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";
                textBox7.Text = ""; textBox8.Text = ""; textBox9.Text = "";
            }
            catch
            {
                MessageBox.Show("Не удалось добавить сотрудника! Попробуйте позже.");
            }
        }
        ///////////////////////////////////////////////
        private void DisconnectDB(object sender, FormClosingEventArgs e) //отключение бд
        {
            myConnection.Close();
        }
        ///////////////////////////////////////////////
        private void button2_Click(object sender, EventArgs e)//удаление сотрудника
        {
            try
            {
                string s1 = '"' + textBox1.Text + '"', s2 = '"' + textBox4.Text + '"', s3 = '"' + textBox3.Text + '"', s4 = '"' + textBox2.Text + '"', s5 = '"' + textBox9.Text + '"';
                string delete = "DELETE FROM Accounts WHERE Full_name = " + s1 + " AND Login = " + s2 + " AND Password = " + s3 + " AND Priority = " + s4 + " AND Short_name = " + s5 + ";";
                OleDbCommand command1 = new OleDbCommand(delete, myConnection);
                command1.Connection = myConnection;
                command1.ExecuteNonQuery();

                string _s1 = '"' + textBox1.Text + '"', _s2 = '"' + textBox6.Text + '"', _s3 = '"' + textBox8.Text + '"', _s4 = '"' + textBox5.Text + '"', _s5 = '"' + textBox7.Text + '"';
                string delete2 = "DELETE FROM Workers WHERE Full_name = " + _s1 + " AND Position = " + _s2 + " AND Experience = " + _s3 + " AND Payment_per_hour = " + _s4 + " AND Overtime_pay = " + _s5 + ";";
                OleDbCommand command2 = new OleDbCommand(delete2, myConnection);
                command2.Connection = myConnection;
                command2.ExecuteNonQuery();
                MessageBox.Show("Сотрудник успешно удален!");

                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";
                textBox7.Text = ""; textBox8.Text = ""; textBox9.Text = "";
            }
            catch
            {
                MessageBox.Show("Не удалось удалить сотрудника! Попробуйте позже.");
            }
        }
        ///////////////////////////////////////////////
    }
}
