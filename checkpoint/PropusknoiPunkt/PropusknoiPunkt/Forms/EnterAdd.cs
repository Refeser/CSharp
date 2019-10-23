using System;
using System.Windows.Forms;
using PropusknoiPunkt.Models;

namespace PropusknoiPunkt
{
    public partial class EnterAdd : Form
    {
        //////////////////////////////////////
        private Form _form2;//объявление формы
        private Form _form1;//объявление формы
        //////////////////////////////////////

        //////////////////////////////////
        /***** Инициализация и т.д. *****/
        //////////////////////////////////

        public EnterAdd(Form form2, Form form1)
        {
            InitializeComponent();
            _form2 = form2;
            _form1 = form1;
        }

        ///////////////////////////
        /***** Загрузка формы*****/
        ///////////////////////////

        private void EnterAdd_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            Connection.addCombo(comboBox1);//заполнение комбобокса
            timer1.Start();//запустить таймер
            label5.Text = DateTime.Now.ToLongDateString();//поставить сегодняшнюю дату в label даты
            label4.Text = DateTime.Now.ToLongTimeString();//поставить нынешнее время в label времени
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

        ///////////////////////
        /***** Не пропуск*****/
        ///////////////////////

        private void noEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            MessageBox.Show("Сотрудник не пропущен!");//вывести сообщение
            Cursor = Cursors.Arrow;//замена курсора
        }

        ////////////////////////
        /***** Пропустить *****/
        ////////////////////////

        private void enter(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            if (comboBox1.SelectedItem != null)//если комбобокс не выбран
            {
                try
                {
                    Connection.entr(comboBox1);//выполнить entr из connection.cs, передав значение комбобокса
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка при проверке пропуска!");//вывести сообщение
                }
                listBox1.Items.Clear();//очистить листбокс
                int j = 0, k = 1;
                foreach (var i in Connection.getAttendanceList())//пробегаемся по списку посещений
                {

                    listBox1.Items.Add(k + " " + Connection.getAttendanceList()[j].Full_name + " " + Connection.getAttendanceList()[j].EnterTime);//добавление в листбокс нужных значений списка посещений
                    k++;//порядковый номер
                    j++;
                }
            }
            else
                MessageBox.Show("Вы не выбрали пропуск!");//вывести сообщение
            Cursor = Cursors.Arrow;//замена курсора
        }
    }
}
