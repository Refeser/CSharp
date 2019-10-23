using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PropusknoiPunkt
{
    public partial class UserForm : Form
    {
        ///////////////////////////////////////////////
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PPDB-2003.mdb;";
        //public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PPDB-2003.mdb;";
        private OleDbConnection myConnection;
        private Form _form1;
        string priority, name, full_name;
        ///////////////////////////////////////////////
        public string Priority
        {
            get
            {
                return priority;
            }
            set
            {
                priority = value;
            }
        }
        ///////////////////////////////////////////////
        public string Hello_name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        ///////////////////////////////////////////////
        public string Full_name
        {
            get
            {
                return full_name;
            }
            set
            {
                full_name = value;
            }
        }
        ///////////////////////////////////////////////
        public UserForm(Form form1) //инициализация формы и т.д.
        {
            InitializeComponent();
            _form1 = form1;
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
        private void LogOut(object sender, EventArgs e) //выход из аккаунта
        {
            this.Close();
            _form1.Show();
        }
        ///////////////////////////////////////////////
        private void DisconnectDB(object sender, FormClosingEventArgs e) //отключение бд
        {
                  myConnection.Close();
        }
        ///////////////////////////////////////////////
        private void Attendance(object sender, EventArgs e) //вывод посещаемости
        {
            try
            {
                string Full_name = '"' + textBox1.Text + '"';
                string query = "SELECT Full_name, Day_, Month_, Year_, Enter_time, Leave_time FROM Attendance WHERE Full_name = " + Full_name;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader reader = command.ExecuteReader();
                listBox1.Items.Clear();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + reader[2].ToString() + reader[3].ToString() + " " + reader[4].ToString() + " " + reader[5].ToString() + " ");
                }
                reader.Close();
                if (textBox1.Text == "")
                {
                    string query_all = "SELECT Full_name, Day_, Month_, Year_, Enter_time, Leave_time FROM Attendance";
                    OleDbCommand comand_all = new OleDbCommand(query_all, myConnection);
                    OleDbDataReader reader_all = comand_all.ExecuteReader();
                    listBox1.Items.Clear();
                    while (reader_all.Read())
                    {
                        listBox1.Items.Add(reader_all[0].ToString() + " " + reader_all[1].ToString() + reader_all[2].ToString() + reader_all[3].ToString() + " " + reader_all[4].ToString() + " " + reader_all[5].ToString() + " ");
                    }
                    reader_all.Close();
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так! Проверьте введенные данные или попробуйте повторить попытку позже.");
            }
        }
        ///////////////////////////////////////////////
        private void UserForm_Load(object sender, EventArgs e) //дата и время при загрузке
        {
            timer1.Start();
            label5.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
            //textBox1.Text = Full_name;
            label2.Text = "Здравствуйте, " + Hello_name;
        }
        ///////////////////////////////////////////////
        private void pictureBox2_Click(object sender, EventArgs e)//admin form open
        {
            if (priority == "admin")
            {
                AdminForm form2 = new AdminForm(this, _form1);
                form2.Show();
                Hide();
            }
            else
                MessageBox.Show("Вы не являетесь администратором!");
        }
        ///////////////////////////////////////////////
        private void WorkersBttn(object sender, EventArgs e)//показать сотрудников
        {
            try
            {
                string worker_ = "SELECT Full_name, Position_ FROM Workers";
                OleDbCommand command = new OleDbCommand(worker_, myConnection);
                OleDbDataReader reader___ = command.ExecuteReader();
                listBox1.Items.Clear();
                while (reader___.Read())
                {
                    listBox1.Items.Add(reader___[0].ToString() + " - " + reader___[1].ToString() + " ");
                }
                reader___.Close();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так! Попробуйте повторить попытку позже.");
            }
        }
        ///////////////////////////////////////////////
        private void timer1_Tick(object sender, EventArgs e) //дата и время таймер
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        ///////////////////////////////////////////////
        private void Attendance_month(object sender, EventArgs e)//посещение за месяц
        {
            try
            {
                string Full_name = '"' + textBox1.Text + '"';
                string month = '"' + textBox2.Text + '"';
                string query = "SELECT Full_name, Day_, Month_, Year_, Enter_time, Leave_time FROM Attendance WHERE Full_name = " + Full_name + "AND Month_ = " + month;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader reader = command.ExecuteReader();
                listBox1.Items.Clear();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + reader[2].ToString() + reader[3].ToString() + " " + reader[4].ToString() + " " + reader[5].ToString() + " ");
                }
                reader.Close();
                if (textBox1.Text == "")
                {
                    string _month_ = '"' + textBox2.Text + '"';
                    string query_all = "SELECT Full_name, Day_, Month_, Year_, Enter_time, Leave_time FROM Attendance WHERE Month_ = " + _month_;
                    OleDbCommand comand_all = new OleDbCommand(query_all, myConnection);
                    OleDbDataReader reader_all = comand_all.ExecuteReader();
                    listBox1.Items.Clear();
                    while (reader_all.Read())
                    {
                        listBox1.Items.Add(reader_all[0].ToString() + " " + reader_all[1].ToString() + reader_all[2].ToString() + reader_all[3].ToString() + " " + reader_all[4].ToString() + " " + reader_all[5].ToString() + " ");
                    }
                    reader_all.Close();
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так! Проверьте введенные данные или попробуйте повторить попытку позже.");
            }
        }
        ///////////////////////////////////////////////
    }
}
