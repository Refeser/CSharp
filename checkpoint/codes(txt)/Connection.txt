using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PropusknoiPunkt.Models
{
     public static  class Connection
    {
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static string connectString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\APP_DATA\PPDB.MDF;Integrated Security=True;";//строка подключения для БД PPDB.MDF
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////
        /***** Список посещений *****/
        //////////////////////////////

        public static List<Attendance> getAttendanceList()
        {
            List<Attendance> atttendanceList = new List<Attendance>();//объявление списка
            SqlConnection sqlConnection = new SqlConnection(connectString);//объявление соединения
            atttendanceList.Clear();//очистка списка
            sqlConnection.Open();//открытие соединения
            SqlCommand command = new SqlCommand("SELECT * FROM Attendance", sqlConnection);//команда на SQL
            SqlDataReader reader = command.ExecuteReader();//объявление ридера (для считывания нескольких данных)
            while (reader.Read())//пока ридеру есть чего ситывать
            {
                atttendanceList.Add(new Attendance() { Id = uint.Parse(reader[0].ToString()), Full_name = reader[1].ToString(), EnterTime = DateTime.Parse(reader[2].ToString())});//добавление в список нужных значений
            }
            sqlConnection.Close();//закрытие соединения

            return atttendanceList;//возврат списка
        }

        //////////////////////////////
        /***** Список аккаунтов *****/
        //////////////////////////////

        public static List<Account> getAccountsList()//объявление списка
        {
            List<Account> accountsList = new List<Account>();//объявление списка
            SqlConnection sqlConnection = new SqlConnection(connectString);//объявление соединения
            accountsList.Clear();//очистка списка
            sqlConnection.Open();//открытие соединения
            SqlCommand command = new SqlCommand("SELECT * FROM Accounts", sqlConnection);//команда на SQL
            SqlDataReader reader = command.ExecuteReader();//объявление ридера (для считывания нескольких данных)
            while (reader.Read())//пока ридеру есть чего ситывать
            {
                accountsList.Add(new Account() { Id = uint.Parse(reader[0].ToString()), Full_name = reader[1].ToString(), Login = reader[2].ToString(), Password = reader[3].ToString(), Priority = reader[4].ToString(), Short_name = reader[5].ToString(), Position_ = reader[6].ToString(), pass_from = Convert.ToDateTime(reader[7].ToString()), pass_untill = Convert.ToDateTime(reader[8].ToString()) });//добавление в список нужных значений
            }
            sqlConnection.Close();//закрытие соединения

            return accountsList;//возврат списка
        }

        ///////////////////////////////
        /***** INSERT INTO (SQL) *****/
        ///////////////////////////////

        public static bool insert(string full_name, string login, string password, string priority, string name, string position, string pass_from, string pass_untill)
        {
            try//попытаться
            {
                if (full_name == "" || name == "" || position == "" || pass_from == "" || pass_untill == "" || full_name == "NULL" || name == "NULL" || position == "NULL" || pass_from == "NULL" || pass_untill == "NULL")//если обязательные поля пучты или NULL
                {
                    MessageBox.Show("Не все обязательные поля были заполнены! Пожалуйста, заполните их и повторите попытку.");//вывод сообщения
                }
                else
                {
                    if ((login != "" && password != "" && priority != "") || (login != "NULL" && password != "NULL" && priority != "NULL"))//если необязательные поля не заполнены
                    {
                        SqlConnection sqlConnection = new SqlConnection(connectString);//объявление соединения
                        sqlConnection.Open();//открытие соединения
                        SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Accounts] ([Full_name], [Login], [Password], [Priority], [Short_name], [Position_], [pass_from], [pass_until]) VALUES (N'" + full_name + "', N'" + login + "', N'" + password + "', N'" + priority + "', N'" + name + "', N'" + position + "', N'" + DateTime.Parse(pass_from).Date + "', N'" + DateTime.Parse(pass_untill).Date + "');", sqlConnection);//команда на SQL
                        command.ExecuteNonQuery();//выполнение команды без возврата значений
                        sqlConnection.Close();//закрыть соединение
                            MessageBox.Show("Пропуск добален!");//показать сообщение
                    }
                    else
                    {
                        SqlConnection sqlConnection = new SqlConnection(connectString);
                        sqlConnection.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Accounts] ([Full_name], [Short_name], [Position_], [pass_from], [pass_until]) VALUES (N'" + full_name + "', N'" + name + "', N'" + position + "', N'" + DateTime.Parse(pass_from).Date + "', N'" + DateTime.Parse(pass_untill).Date + "');", sqlConnection);
                        command.ExecuteNonQuery();
                        sqlConnection.Close();
                            MessageBox.Show("Пропуск проден!");//показать сообщение
                    }
                }
            }
            catch//иначе
            {
                    MessageBox.Show("Не удалось продлить пропуск! Попробуйте позже.");//показать сообщение
            }
            return false;//возврат false
        }

        ///////////////////////////////
        /***** DELETE FROM (SQL) *****/
        ///////////////////////////////

        public static bool delete(string full_name, string login, string password, string priority, string name, string position, string pass_from, string pass_untill)
        {
            try
            {
                if (full_name == "" || name == "" || position == "" || pass_from == "" || pass_untill == "" || full_name == "NULL" || name == "NULL" || position == "NULL" || pass_from == "NULL" || pass_untill == "NULL")
                {
                    MessageBox.Show("Не все обязательные поля были заполнены! Пожалуйста, заполните их и повторите попытку.");
                }
                else
                {
                    if ((login != "" && password != "" && priority != "")||(login != "NULL" && password != "NULL" && priority != "NULL"))
                    {
                        SqlConnection sqlConnection = new SqlConnection(connectString);
                        sqlConnection.Open();
                            SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Accounts] WHERE [Full_name] = N'" + full_name + "' AND [Short_name] = N'" + name + "' AND [Position_] = N'" + position + "' AND [pass_from] = N'" + DateTime.Parse(pass_from).Date + "' AND [pass_until] = N'" + DateTime.Parse(pass_untill).Date + "';", sqlConnection);
                            command.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("Сотрудник удален!");
                    }
                    else
                    {
                        SqlConnection sqlConnection = new SqlConnection(connectString);
                        sqlConnection.Open();
                            SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Accounts] WHERE [Full_name] = N'" + full_name + "' AND [Login] = N'" + login + "' AND [Password] = N'" + password + "' AND [Priority] = N'" + priority + "' AND [Short_name] = N'" + name + "' AND [Position_] = N'" + position + "' AND [pass_from] = N'" + DateTime.Parse(pass_from).Date + "' AND [pass_until] = N'" + DateTime.Parse(pass_untill).Date + "';", sqlConnection);
                            command.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("Сотрудник удален!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось удалить сотрудника! Попробуйте позже.");
            }
            return false;
        }

        ////////////////////////////////////////////////////////////////
        /***** Запись нужных значений в combobox (форма enteradd) *****/
        ////////////////////////////////////////////////////////////////

        public static bool addCombo(ComboBox comboBox1)
        {
            try
            {
                 
                SqlConnection sqlConnection = new SqlConnection(connectString);//объявление соединения
                sqlConnection.Open();//открытие соединения
                SqlCommand command = new SqlCommand("SELECT Full_name, Position_, pass_from, pass_until FROM Accounts", sqlConnection);//команда на SQL
                SqlDataReader reader = command.ExecuteReader();//объявление ридера (для считывания нескольких данных)
                while (reader.Read())//пока ридеру есть чего ситывать
                {
                    comboBox1.Items.Add(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]);//запись нужных значений из БД в combobox (фио, должность, дата срока пропуска)
                }

                sqlConnection.Close();//закрытие соединения
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с БД! Попробуйте позже!");//вывести сообщение
            }

            return false;//возврат false
        }

        //////////////////////////////////////////////////////////////
        /***** Запись прохода по нажатии на кнопку "пропустить" *****/
        //////////////////////////////////////////////////////////////

        public static bool entr(ComboBox comboBox1)
        {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(connectString);//объявление соединения
                    string[] itms = comboBox1.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//разделение строки из combobox по пробелам
                    string today = DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;//сегодняшняя дата
                    if (DateTime.Parse(itms[4]) > DateTime.Parse(today) || DateTime.Parse(itms[6]) < DateTime.Parse(today))//сравнение нынешней даты со сроком пропуска
                    {
                        MessageBox.Show("Пропуск недействителен!");//вывести сообщение
                    
                    }
                    else
                    {
                        sqlConnection.Open();//открытие соединения
                        SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Attendance] ([Full_name], [EnterTime]) VALUES (N'" + itms[0] + " " + itms[1] + " " + itms[2] + "', N'" + DateTime.Now.Month + "." + DateTime.Now.Day + "." + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "');", sqlConnection);//команда на SQL
                        command.ExecuteNonQuery();//выполнить команду без ожидания возврата
                        sqlConnection.Close();//закрытие соединения 
                        MessageBox.Show("Сотрудник пропущен!");//вывести сообщение
                    }
                }
                catch
                {
                    MessageBox.Show("Не удалось связаться с БД! Попробуйте позже!");//вывести сообщение
                }
            return false;//возврат false
        }

        //////////////////////////
        /***** UPDATE (SQL) *****/
        //////////////////////////

        public static bool update(string full_name, string pass_from, string pass_untill)
        {
            try//попытаться
            {
                string[] a = new string[1] { "" };
                if ((full_name != "" && pass_from != "" && pass_untill != "") && (full_name != "NULL" && pass_from != "NULL" && pass_untill != "NULL"))
                {
                    DateTime from_ = new DateTime();//объявление даты
                    DateTime untill_ = new DateTime();//объявление даты
                    from_ = DateTime.Parse(pass_from).Date;//присвоение строки с переводом в дату время
                    untill_ = DateTime.Parse(pass_untill).Date;//присвоение строки с переводом в дату время
                    SqlConnection sqlConnection = new SqlConnection(connectString);//объявление соединения
                    sqlConnection.Open();//открытие соединения
                    try
                    {
                        SqlCommand select = new SqlCommand("SELECT * FROM [Accounts] WHERE Full_name = @full_name;", sqlConnection);
                        select.Parameters.Add("@full_name", full_name);
                        SqlDataReader reader = select.ExecuteReader();//объявление ридера (для считывания нескольких данных)
                        while (reader.Read())//пока ридеру есть чего ситывать
                        {
                            a[0] = reader[1].ToString();
                        }
                        reader.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Пропуск не найден!");
                    }
                    if (a[0] != "")
                    {
                        SqlCommand command = new SqlCommand("UPDATE [Accounts] SET pass_from = @from, pass_until= @untill WHERE Full_name = @full_name", sqlConnection);//команда на SQL
                        command.Parameters.Add("@from", from_);//добавить парамет со значением выше в @ из строки команды
                        command.Parameters.Add("@untill", untill_);//добавить парамет со значением выше в @ из строки команды
                        command.Parameters.Add("@full_name", full_name);//добавить парамет со значением выше в @ из строки команды
                        command.ExecuteNonQuery();//выполнение команды без возврата значений
                        sqlConnection.Close();//закрыть соединение
                        MessageBox.Show("Пропуск продлен!");//показать сообщение
                    }
                    else
                    {
                        MessageBox.Show("Пропуск неверен!");
                    }
                }
                else
                {
                    MessageBox.Show("Пропуск неверен!");
                }

            }
            catch//иначе
            {
                
                    MessageBox.Show("Не удалось продлить пропуск! Попробуйте позже.");//показать сообщение
                
            }
            return false;//возврат false
        }
    }
}
