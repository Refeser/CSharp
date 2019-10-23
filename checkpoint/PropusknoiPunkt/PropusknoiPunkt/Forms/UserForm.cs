using System;
using System.Windows.Forms;
using PropusknoiPunkt.Models;

namespace PropusknoiPunkt
{
    public partial class UserForm : Form
    {
        ////////////////////////////////////////////////////////
        private Form _form1;//объявление формы /////////////////
        string priority, name;//объявление переменных
        ////////////////////////////////////////////////////////

        ////////////////////////////////////////////
        /***** публичная строковая переменная *****/
        ////////////////////////////////////////////

        public string Priority//для передачи приоритета из формы авторизации
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
        public string Hello_name//для передачи имени из формы авторизации
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

        //////////////////////////////////
        /***** Инициализация и т.д. *****/
        //////////////////////////////////

        public UserForm(Form form1)
        {
            InitializeComponent();//инициализация компонента
            _form1 = form1;
        }

        ///////////////////////////////
        /***** Выход из аккаунта *****/
        ///////////////////////////////

        private void LogOut(object sender, EventArgs e) //выход из аккаунта
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            this.Close();//закрытие этой формы
            _form1.Show();//показать окно авторизации
            Cursor = Cursors.Arrow;//замена курсора
        }

        ////////////////////////////////
        /***** Вывод посещаемости *****/
        ////////////////////////////////

        private void Attendance(object sender, EventArgs e) 
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            try//попытаться
            {
                if (textBox1.Text == "")//если поле ввода пустое
                {
                    listBox1.Items.Clear();//очистка поля вывода (в этом случае листбокс)
                    int j = 0, k = 0;
                    foreach (var i in Connection.getAttendanceList())//пробегаемся по списку посещений
                    {
                        if (Connection.getAttendanceList()[j].Full_name != "")
                        {
                            k++;//порядковый номер
                            listBox1.Items.Add(k + " " + Connection.getAttendanceList()[j].Full_name + " " + Connection.getAttendanceList()[j].EnterTime);//добавляем нужные значения в листбокс
                            
                        }
                        j++;
                    }
                    MessageBox.Show("Кол-во проходов = " + k);
                }
                else
                {
                    listBox1.Items.Clear();//очистка поля вывода (в этом случае листбокс)
                    int j = 0, k = 0;
                    foreach (var i in Connection.getAttendanceList())//пробегаемся по списку посещений
                    {
                        if (Connection.getAttendanceList()[j].Full_name == textBox1.Text)//если фио в списке совпадает с фио в поле ввода
                        {
                            k++;//порядковый номер
                            listBox1.Items.Add(k + " " + Connection.getAttendanceList()[j].Full_name + " " + Connection.getAttendanceList()[j].EnterTime);//добавляем нужные значения в листбокс
                            
                        }
                            j++;
                    }
                    MessageBox.Show("Кол-во проходов = " + k);
                }
            }
            catch//иначе
            {
                MessageBox.Show("Что-то пошло не так! Проверьте введенные данные или попробуйте повторить попытку позже.");//выводим сообщение
            }
            Cursor = Cursors.Arrow;//замена курсора
        }

        //////////////////////////////////////////
        /***** При загрузке формы(открытии) *****/
        //////////////////////////////////////////

        private void UserForm_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            timer1.Start();//запустить таймер
            label5.Text = DateTime.Now.ToLongDateString();//поставить сегодняшнюю дату в label даты
            label4.Text = DateTime.Now.ToLongTimeString();//поставить нынешнее время в label времени
            label2.Text = "Здравствуйте, " + Hello_name;//текст здравствуйте, [имя владельца аккаунта]
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

        ///////////////////////////////////////////////////
        /***** Клик по щиту для перехода в AdminForm *****/
        ///////////////////////////////////////////////////

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            if (priority == "admin")//если приоритет аккаунта админ
            {
                AdminForm form2 = new AdminForm(this, _form1);//объявление формы администратора
                form2.Show();//показать форму администратора
                Hide();//спрятать
            }
            else
                MessageBox.Show("Вы не являетесь администратором!");//вывод сообщения
            Cursor = Cursors.Arrow;//замена курсора
        }

        ///////////////////////////////////////////////
        /***** Клик по кнопке показа сотрудников *****/
        ///////////////////////////////////////////////

        private void WorkersBttn(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            try//попытаться
            {
                listBox1.Items.Clear();//очистить листбокс
                int j=0;
                foreach (var i in Connection.getAccountsList())//пробежаться по списку аккаунтов
                {
                    listBox1.Items.Add(Connection.getAccountsList()[j].Id + " " + Connection.getAccountsList()[j].Full_name + " " + Connection.getAccountsList()[j].Position_ + " Пропуск с " + Connection.getAccountsList()[j].pass_from + " Пропуск по " + Connection.getAccountsList()[j].pass_untill);//добавить в листбокс нужные значения из connection.cs
                    j++;
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так! Попробуйте повторить попытку позже.");//вывод сообщения
            }
            Cursor = Cursors.Arrow;//замена курсора
        }

        ////////////////////////////////////////////
        /***** Клик по кнопке записать проход *****/
        ////////////////////////////////////////////

        private void AddEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            EnterAdd formadd = new EnterAdd(this, _form1);//объявление формы администратора
            formadd.Show();//показать форму администратора
            Hide();//спрятать
            Cursor = Cursors.Arrow;//замена курсора
        }

        ////////////////////////////////////
        /***** Клик по кнопке проходы *****/
        ////////////////////////////////////

        private void Enters(object sender, EventArgs e)
        { 
            Cursor = Cursors.WaitCursor;//замена курсора
            Days formdays = new Days(this, _form1);//объявление формы администратора
            formdays.Show();//показать форму администратора
            Hide();//спрятать
            Cursor = Cursors.Arrow;//замена курсора
        }

        ////////////////////////////////////////////////////////
        /***** Клик по щиту для показа посещения за месяц *****/
        ////////////////////////////////////////////////////////

        private void Attendance_month(object sender, EventArgs e)//посещение за месяц
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            listBox1.Items.Clear();//очистить листбокс
            try
            {
                if (textBox1.Text == "")//если поле фио пусто
                {
                    int j = 0, k = 0;
                    foreach (var i in Connection.getAttendanceList())//пробегаемся по списку посещений
                    {
                        if ((Connection.getAttendanceList()[j].EnterTime.Month == byte.Parse(textBox2.Text)) && Connection.getAttendanceList()[j].Full_name != "")//если месяц в списке совпал с месяцем в текстовом поле месяц
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
                        if ((Connection.getAttendanceList()[j].EnterTime.Month == byte.Parse(textBox2.Text)) && (Connection.getAttendanceList()[j].Full_name == textBox1.Text))//если месяц в списке совпал с месяцем в текстовом поле месяц и фио в списке совпала с фио в поле фио
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
    }
}
