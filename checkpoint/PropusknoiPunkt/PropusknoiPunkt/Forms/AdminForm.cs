using System;
using System.Windows.Forms;
using PropusknoiPunkt.Models;

namespace PropusknoiPunkt
{
    public partial class AdminForm : Form
    {
        
        //////////////////////////////////////
        private Form _form2;//объявление формы
        private Form _form1;//объявление формы
        //////////////////////////////////////

        //////////////////////////////////
        /***** инициализация и т.д. *****/
        //////////////////////////////////

        public AdminForm(Form form2, Form form1)
        {
            InitializeComponent();//инициализация компонента
            _form2 = form2;
            _form1 = form1;
            textBox3.MaxLength = 10;//максимальная длина поля пароль = 10
            foreach (Control textbox in this.Controls)//пробегаемся по объектам на форме
                if (textbox is TextBox)//если это текстовое поле
                {
                    if ((textbox as TextBox).Text == "")//если поле пусто, то ставим туда NULL
                        (textbox as TextBox).Text = "NULL";
                }
        }

        ///////////////////////////////
        /***** Выход из аккаунта *****/
        ///////////////////////////////

        private void LogOut(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            this.Hide();//спрятать эту форму
            _form1.Show();//показать форму авторизации
            Cursor = Cursors.Arrow;//замена курсора
        }

        ////////////////////////////////////
        /***** Клик на текстовое поле *****/
        ////////////////////////////////////

        private void txtbx_click(object sender, EventArgs e)//поле фио
        {
            foreach (Control textbox in this.Controls)//пробегаемся по объектам на форме
                if (textbox is TextBox)//если это текстовое поле
                {
                    if ((textbox as TextBox).Text == "")//если поле пусто, то ставим туда NULL
                        (textbox as TextBox).Text = "NULL";
                }
            if (textBox1.Text == "NULL")//если в поле написано NULL, то очищаем поле
                textBox1.Text = "";
        }
        ///////////////////////////////////////////////
        private void txtbx2_click(object sender, EventArgs e)//поле приоритет
        {
            foreach (Control textbox in this.Controls)
                if (textbox is TextBox)
                {
                    if ((textbox as TextBox).Text == "")
                        (textbox as TextBox).Text = "NULL";
                }
            if (textBox2.Text == "NULL")
                textBox2.Text = "";
        }
        ///////////////////////////////////////////////
        private void txtbx3_click(object sender, EventArgs e)//поле пароль
        {
            foreach (Control textbox in this.Controls)
                if (textbox is TextBox)
                {
                    if ((textbox as TextBox).Text == "")
                        (textbox as TextBox).Text = "NULL";
                }
            if (textBox3.Text == "NULL")
                textBox3.Text = "";
        }
        ///////////////////////////////////////////////
        private void txtbx4_click(object sender, EventArgs e)//поле логин
        {
            foreach (Control textbox in this.Controls)
                if (textbox is TextBox)
                {
                    if ((textbox as TextBox).Text == "")
                        (textbox as TextBox).Text = "NULL";
                }
            if (textBox4.Text == "NULL")
                textBox4.Text = "";
        }
        ///////////////////////////////////////////////
        private void txtbx5_click(object sender, EventArgs e)//поле пропуск с
        {
            foreach (Control textbox in this.Controls)
                if (textbox is TextBox)
                {
                    if ((textbox as TextBox).Text == "")
                        (textbox as TextBox).Text = "NULL";
                }
            if (textBox5.Text == "NULL")
                textBox5.Text = "";
        }
        ///////////////////////////////////////////////
        private void txtbx6_click(object sender, EventArgs e)//поле должность
        {
            foreach (Control textbox in this.Controls)
                if (textbox is TextBox)
                {
                    if ((textbox as TextBox).Text == "")
                        (textbox as TextBox).Text = "NULL";
                }
            if (textBox6.Text == "NULL")
                textBox6.Text = "";
        }
        ///////////////////////////////////////////////
        private void txtbx7_click(object sender, EventArgs e)//поле пропуск по
        {
            foreach (Control textbox in this.Controls)
                if (textbox is TextBox)
                {
                    if ((textbox as TextBox).Text == "")
                        (textbox as TextBox).Text = "NULL";
                }
            if (textBox7.Text == "NULL")
                textBox7.Text = "";

        }
        ///////////////////////////////////////////////
        private void txtbx9_click(object sender, EventArgs e)//поле имя
        {
            foreach (Control textbox in this.Controls)
                if (textbox is TextBox)
                {
                    if ((textbox as TextBox).Text == "")
                        (textbox as TextBox).Text = "NULL";
                }
            if (textBox9.Text == "NULL")
                textBox9.Text = "";
        }

        //////////////////////////////////////////////
        /***** Клик на форму или текст на форме *****/
        //////////////////////////////////////////////

        private void form_click(object sender, EventArgs e)
        {
            foreach (Control textbox in this.Controls)//пробегаемся по объектам на форме
                if (textbox is TextBox)//если это текстовое поле
                {
                    if ((textbox as TextBox).Text == "")//если поле пусто, то ставим туда NULL
                        (textbox as TextBox).Text = "NULL";
                }
        }

        //////////////////////////////////
        /***** Клик на кнопку назад *****/
        //////////////////////////////////

        private void Back(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            this.Hide();//спрятать эту форму
            _form2.Show();//показать UserForm
            Cursor = Cursors.Arrow;//замена курсора
        }

        //////////////////////////////////////////
        /***** При загрузке формы(открытии) *****/
        //////////////////////////////////////////

        private void UserForm_Load(object sender, EventArgs e)
        {
            timer1.Start();//запустить таймер
            label9.Text = DateTime.Now.ToLongDateString();//поставить сегодняшнюю дату в label даты
            label10.Text = DateTime.Now.ToLongTimeString();//поставить нынешнее время в label времени

        }

        /////////////////////////
        /***** Тик таймера *****/
        /////////////////////////

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToLongTimeString();//поставить нынешнее время в label времени
            timer1.Start();//запустить таймер(продолжить его работу)
        }

        //////////////////////////////////////
        /***** Клик добавить сотрудника *****/
        //////////////////////////////////////

        public void insertCard(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            Connection.insert(textBox1.Text, textBox4.Text, textBox3.Text, textBox2.Text, textBox9.Text, textBox6.Text, textBox5.Text, textBox7.Text);//выполнить insert в connection, передав значения текстбоксов
            Cursor = Cursors.Arrow;//замена курсора
        }

        //////////////////////////////////////
        /***** Клик удалить сотрудника *****/
        //////////////////////////////////////

        private void deleteCard(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            Connection.delete(textBox1.Text, textBox4.Text, textBox3.Text, textBox2.Text, textBox9.Text, textBox6.Text, textBox5.Text, textBox7.Text);//выполнить delete в connection, передав значения текстбоксов
            Cursor = Cursors.Arrow;//замена курсора
        }

        ////////////////////////////////////////////
        /***** Клик по картинкам с вопросиком *****/
        ////////////////////////////////////////////

        private void question_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            foreach (Control textbox in this.Controls)//пробегаемся по объектам на форме
                if (textbox is TextBox)//если это текстовое поле
                {
                    if ((textbox as TextBox).Text == "")//если поле пусто, то ставим туда NULL
                        (textbox as TextBox).Text = "NULL";
                }
            MessageBox.Show("Формат даты MM-DD-YYYY! (при продлении DD-MM-YYYY)");//показать сообщение
            Cursor = Cursors.Arrow;//замена курсора
        }

        ///////////////////////////////////////////////
        /***** Нажатие кнопки продления пропуска *****/
        ///////////////////////////////////////////////

        private void cardRenewal(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//замена курсора
            Connection.update(textBox1.Text, textBox5.Text, textBox7.Text);
            Cursor = Cursors.Arrow;//замена курсора
        }

        private void question_Click_fio(object sender, EventArgs e)
        {
            MessageBox.Show("ФИО должно быть полным (содержать фамилию, имя и отчество через пробел)!");
        }

        private void question_Click_(object sender, EventArgs e)
        {
            MessageBox.Show("Должность не должна содержать пробелов!");
        }
    }
}
