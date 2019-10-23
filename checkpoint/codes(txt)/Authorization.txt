using System;
using System.Windows.Forms;
using PropusknoiPunkt.Models;

namespace PropusknoiPunkt
{
    public partial class Authorization : Form
    {
        //////////////////////////////////
        /***** инициализация и т.д. *****/
        //////////////////////////////////

        public Authorization()
        {
            InitializeComponent();// инициализация компонента
            textBox2.PasswordChar = '*';// для поля пароль визуально устанавливает * вместо вводимых значений
            textBox2.MaxLength = 10; // для поля пароль устанавливает максимальную длину 10 символов
        }

        //////////////////////////////////
        /***** клик на кнопку войти *****/
        //////////////////////////////////

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            try //попытаться
            {
                bool lgn_true = false, pswrd_true = false, lgn=false, pswrd=false;
                for (int i = 0; i < Connection.getAccountsList().Count; i++) //прохождение по списку аккаунтов
                {
                    if (Connection.getAccountsList()[i].Login == textBox1.Text)// если элемент списка совпадает с полем логин
                    {
                        if(textBox1.Text != "") //если поле логин не пуста
                        lgn_true = true;
                    }
                    if (Connection.getAccountsList()[i].Password == textBox2.Text)// если элемент списка совпадает с полем пароль
                    {
                        if(textBox2.Text != "") //если поле пароль не пуста
                        pswrd_true = true;
                    }
                    if (lgn_true == true && pswrd_true == true)//если логин и пароль были найдены
                    {
                        UserForm form3 = new UserForm(this);//объявление другой формы(UserForm)
                        form3.Priority = Connection.getAccountsList()[i].Priority;//передача приоритета из списка в переменную другой формы
                        form3.Hello_name = Connection.getAccountsList()[i].Short_name;//передача имени из списка в переменную другой формы
                        form3.Show();//показать UserForm
                        textBox1.Text = "";//очистить поле логин
                        textBox2.Text = "";//очистить поле пароль
                        Hide();//спрятать данную форму
                        lgn_true = false;
                        pswrd_true = false;
                        lgn = true;
                        pswrd = true;
                    }
                }
                if (lgn == false && pswrd == false)//если логин и пароль были не найдены
                    MessageBox.Show("Логин или пароль неверны! Проверьте данные.");//показать сообщение
            }
            catch //иначе
            {
                MessageBox.Show("Не возможно подключиться к базе данных! Попробуйте повторить вход позже.");//показать сообщение
            }
            Cursor = Cursors.Arrow;//замена курсора
        }

        /////////////////////////////////////////////////////
        /***** нажатие кнопки вход при нажатии энетера *****/
        /////////////////////////////////////////////////////

        private void enter(object sender, KeyEventArgs e) 
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            if (e.KeyCode == Keys.Enter) button1.PerformClick();//еслии нажатая кнопка - энтер, то нажимается кнопка вход
            Cursor = Cursors.Arrow;//замена курсора
        }

        ///////////////////////////////////////////////////////////////
        /***** Выход из приложения при нажатии на картинку power *****/
        ///////////////////////////////////////////////////////////////

        private void Quit(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            Application.Exit();//выйти из проекта (закрыть)
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
            label6.Text = DateTime.Now.ToLongTimeString();//поставить нынешнее время в label времени
            Cursor = Cursors.Arrow;//замена курсора
        }

        /////////////////////////
        /***** Тик таймера *****/
        /////////////////////////

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongTimeString();//поставить нынешнее время в label времени
            timer1.Start();//запустить таймер(продолжить его работу)
        }
    }
}
