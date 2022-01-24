using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma
{
    static class User
    {
        public static int id;
        public static int library_card;
        public static int group;
        private static string login_usr;
        private static string password;
        private static string fio;
        private static string email;
        private static string phone;
        public static DataTable extend_book;

        public static void login(DataTable table) // Записываем данные пользователя
        {
            id = int.Parse(table.Rows[0]["id"].ToString());
            login_usr = table.Rows[0]["user_login"].ToString();
            password = table.Rows[0]["user_password"].ToString();
            fio = table.Rows[0]["user_fio"].ToString();
            email = table.Rows[0]["user_email"].ToString();
            phone = table.Rows[0]["user_phone"].ToString();
            if (table.Rows[0]["user_group"].ToString() == "Пользователь") group = 1;
            else if (table.Rows[0]["user_group"].ToString() == "Библиотекарь") group = 2;
            else if (table.Rows[0]["user_group"].ToString() == "Директор") group = 3;
            Working.request(2, 2, id.ToString());
        }
        public static void logout() // Удаляем данные пользователя
        {
            id = -99;
            group = -99;
            library_card = -99;
            login_usr = null;
            password = null;
            fio = null;
            email = null;
            phone = null;
            extend_book = null;
        }
        public static string get_info() // Получаем информацию о пользователе
        {
            string str = "";
            str += $"ID: {id}\nЛогин: {login_usr}\nФИО: {fio}\nE-Mail: {email}\nТелефон: {phone}";
            if (library_card != 0)
            {
                str += $"\n\nНомер читательского билета: {library_card}";
            }
            else
            {
                str += "\n\nЧитательский билет не привязан к вашей учетной записи!\nОбратитесь в библиотеку.";
            }

            return str;
        }
        public static DataTable get_extend_book() // Получаем информацию о задолжностях
        {
            Working.request(3, 3, library_card.ToString());
            extend_book.Columns.RemoveAt(4); // Удаляем столбец "Код экземпляра"
            extend_book.Columns.RemoveAt(4); // Удаляем столбец "Код задолжности"
            return extend_book;
        }
        public static string registration(string login, string pass, string pass_2, string fio, string email, string phone)
        {
            if (login == "") return "Введите логин!";
            if (fio == "") return "Введите ФИО!";
            if (email == "") return "Введите e-mail!";
            if (phone == "") return "Введите телефон!";
            if (pass == "") return "Введите пароль!";
            if (pass_2 == "") return "Введите пароль еще раз!";
            if (pass != pass_2) return "Пароли не совпадают!";

            Working.request(7, 6, login, null);
            if (Working.arg_return == 0) // Проверка логина
            {
                Working.request(8, 6, email, null);
                if (Working.arg_return == 0) // Проверка e-mail
                {
                    Working.request(9, 6, phone, null);
                    if (Working.arg_return == 0) // Проверка телефона
                    {
                        Working.request(14, 0, login, pass, fio, email, phone, "NULL");
                        return "Вы успешно зарегистрировались!";
                    }
                    else return "Данный телефон уже используется!";
                }
                else return "Данный e-mail уже используется!";
            }
            else return "Данный логин уже используется!";
        }
    }
}
