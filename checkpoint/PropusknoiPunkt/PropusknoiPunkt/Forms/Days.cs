using System;
using System.Windows.Forms;
using PropusknoiPunkt.Models;

namespace PropusknoiPunkt
{
    public partial class Days : Form
    {
        //////////////////////////////////////
        private Form _form2;//объявление формы
        private Form _form1;//объявление формы
        //////////////////////////////////////

        //////////////////
        /***** Назад*****/
        //////////////////

        private void Back(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            _form2.Show();
            Close();
            Cursor = Cursors.Arrow;//замена курсора
        }

        ///////////////////////////////
        /***** Выход из аккаунта *****/
        ///////////////////////////////

        private void LogOut(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            _form1.Show();
            Close();
            Cursor = Cursors.Arrow;//замена курсора
        }

        //////////////////////////////////
        /***** Инициализация и т.д. *****/
        //////////////////////////////////

        public Days(Form form2, Form form1)
        {
            InitializeComponent();
            _form2 = form2;
            _form1 = form1;
        }

        /////////////////////////////////////////
        /***** Клик по кнопке проходы день *****/
        /////////////////////////////////////////

        private void enter_kol(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            listBox1.Items.Clear();//очистить листбокс
            try
            {
                if (textBox3.Text == "")//если поле фио пусто
                {
                    int j = 0, k = 0;
                    foreach (var i in Connection.getAttendanceList())//пробегаемся по списку посещений
                    {
                        if ((Connection.getAttendanceList()[j].EnterTime.Day == byte.Parse(textBox1.Text)) && Connection.getAttendanceList()[j].Full_name != "")//если day в списке совпал с day в текстовом поле day
                        {
                            k++;//порядковый номер
                            listBox1.Items.Add(k + " " + Connection.getAttendanceList()[j].Full_name + " " + Connection.getAttendanceList()[j].EnterTime);//добавление в листбокс нужных значений списка посещений

                        }
                        j++;
                    }
                    MessageBox.Show("Кол-во проходов = " + k);
                }
                else
                {
                    int j = 0, k = 0;
                    foreach (var i in Connection.getAttendanceList())//пробежаться по списку посещений
                    {
                        if ((Connection.getAttendanceList()[j].EnterTime.Day == byte.Parse(textBox1.Text)) && (Connection.getAttendanceList()[j].Full_name == textBox3.Text))//если day в списке совпал с day в текстовом поле day и фио в списке совпала с фио в поле фио
                        {
                            k++;//порядковый номер
                            listBox1.Items.Add(k + " " + Connection.getAttendanceList()[j].Full_name + " " + Connection.getAttendanceList()[j].EnterTime);//добавление в листбокс нужных значений списка посещений

                        }
                        j++;
                    }
                    MessageBox.Show("Кол-во проходов = " + k);
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так! Проверьте введенные данные или попробуйте повторить попытку позже.");//вывод сообщения
            }
            Cursor = Cursors.Arrow;//замена курсора
        }

        ////////////////////////////////////////
        /***** Клик по кнопке проходы год *****/
        ////////////////////////////////////////

        private void enter_kol_year(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            listBox1.Items.Clear();//очистить листбокс
            try
            {
                if (textBox3.Text == "")//если поле фио пусто
                {
                    int j = 0, k = 0;
                    foreach (var i in Connection.getAttendanceList())//пробегаемся по списку посещений
                    {
                        if ((Connection.getAttendanceList()[j].EnterTime.Year == int.Parse(textBox2.Text)) && Connection.getAttendanceList()[j].Full_name != "")//если year в списке совпал с year в текстовом поле year
                        {
                            k++;//порядковый номер
                            listBox1.Items.Add(k + " " + Connection.getAttendanceList()[j].Full_name + " " + Connection.getAttendanceList()[j].EnterTime);//добавление в листбокс нужных значений списка посещений

                        }
                        j++;
                    }
                    MessageBox.Show("Кол-во проходов = " + k);
                }
                else
                {
                    int j = 0, k = 0;
                    foreach (var i in Connection.getAttendanceList())//пробежаться по списку посещений
                    {
                        if ((Connection.getAttendanceList()[j].EnterTime.Year == int.Parse(textBox2.Text)) && (Connection.getAttendanceList()[j].Full_name == textBox3.Text))//если year в списке совпал с year в текстовом поле year и фио в списке совпала с фио в поле фио
                        {
                            k++;//порядковый номер
                            listBox1.Items.Add(k + " " + Connection.getAttendanceList()[j].Full_name + " " + Connection.getAttendanceList()[j].EnterTime);//добавление в листбокс нужных значений списка посещений

                        }
                        j++;
                    }
                    MessageBox.Show("Кол-во проходов = " + k);
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так! Проверьте введенные данные или попробуйте повторить попытку позже.");//вывод сообщения
            }
            Cursor = Cursors.Arrow;//замена курсора
        }

        /////////////////////////
        /***** Тик таймера *****/
        /////////////////////////

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();//поставить нынешнее время в label времени
            timer1.Start();//запустить таймер(продолжить его работу)
        }

        //////////////////////////////////////////
        /***** При загрузке формы(открытии) *****/
        //////////////////////////////////////////

        private void Days_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            timer1.Start();//запустить таймер
            label5.Text = DateTime.Now.ToLongDateString();//поставить сегодняшнюю дату в label даты
            label4.Text = DateTime.Now.ToLongTimeString();//поставить нынешнее время в label времени
            Cursor = Cursors.Arrow;//замена курсора
        }
    }
}
