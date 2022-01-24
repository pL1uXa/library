using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma
{
    static class Working
    {
        public static DataTable buffer_cbook;
        public static int arg_return;
        public static DateTime time;
        public static string news;

        private static void action(int arg, DataTable table)
        {
            if (table != null)
            {
                switch (arg)
                {
                    case 1: // Получение текущего времени БД
                        time = DateTime.Parse(table.Rows[0]["NOW()"].ToString());
                        break;
                    case 2: // Проверка читательского билета
                        if (table.Rows[0]["library_card"].ToString() != "")
                            User.library_card = int.Parse(table.Rows[0]["library_card"].ToString());
                        else User.library_card = 0;
                        break;
                    case 3: // Получаем информацию о задолжностях
                        User.extend_book = table;
                        break;
                    case 4: // Загружаем каталог книг
                        buffer_cbook = table;
                        break;
                    case 5: // Загружаем каталог пользователей
                        Librarian.users = table;
                        break;
                    case 6: // Разные проверки
                        if (table.Rows[0][0].ToString() == "0") arg_return = 0;
                        else arg_return = 1;
                        break;
                    case 7: // Загружаем долги пользователя
                        Librarian.debts = table;
                        break;
                    case 8: // Загружаем экземпляры книги
                        Librarian.instances = table;
                        break;
                    case 9: // Получаем id читателя у которого книга
                        arg_return = int.Parse(table.Rows[0][0].ToString());
                        break;
                    case 10: // Загружаем каталог долгов
                        Librarian.issuance = table;
                        break;
                    case 11: // Загружаем актуальные новости
                        news = table.Rows[0]["news"].ToString();
                        break;
                    case 12: // Загружаем список сотрудников
                        Director.users = table;
                        break;
                    case 13: // Проверяем группу пользователя
                        if (table.Rows[0]["user_group"].ToString() == "Пользователь") arg_return = 0;
                        else arg_return = 1;
                        break;
                    case 14: // Проверяем существует ли пользователь с таким логином
                        if (table.Rows[0]["COUNT(*)"].ToString() != "0") arg_return = 0;
                        else arg_return = 1;
                        break;
                }
            }
        }
        public static void request(int arg1, int arg2, params string[] textb)
        {
            string str = "";
            switch (arg1)
            {
                    // Узнаем текущую дату БД
                case 1: str = "SELECT NOW();"; break;
                    // Получаем данные читателя по id пользователя
                case 2: str = "SELECT * FROM readers WHERE user_id = '" + textb[0] + "';"; break;
                    // Получаем задолжности по номеру читательского билета
                case 3: str = "SELECT books.title as 'Название книги', instances.state_instances as 'Состояние', issuance.date_of_issue as 'Была взята', issuance.date_of_completion as 'Взята до', instances.isbn_issn as 'ISBN/ISSN', issuance.code_instances as 'Код экземпляра', issuance.code_issuing as 'Код задолжности' FROM issuance JOIN instances ON issuance.code_instances = instances.code_instances JOIN books ON instances.code_book = books.code_book JOIN readers ON issuance.readers_id = readers.id WHERE readers.library_card = " + textb[0] + " ORDER BY issuance.date_of_completion;"; break;
                    // Поиск в электронном каталоге
                case 4: str = "SELECT books.code_book as 'ID', books.title as 'Название книги', books.author as 'Автор', books.authors_other as 'Другие авторы', books.year_of_publ as 'Год публикации', COUNT(instances.code_instances) - COUNT(issuance.code_instances) as 'Экземпляров в наличии' FROM books LEFT JOIN instances ON books.code_book = instances.code_book LEFT OUTER JOIN issuance ON instances.code_instances = issuance.code_instances WHERE books.title LIKE '%" + textb[0] + "%' and (books.author LIKE '%" + textb[1] + "%' or books.authors_other LIKE '%" + textb[1] + "%') GROUP BY books.code_book ORDER BY books.";
                        if (textb[4] == "0") str += "title";
                        else if (textb[4] == "1") str += "author";
                        else if (textb[4] == "2") str += "year_of_publ";
                        else if (textb[4] == "3") str += "code_book";
                        if (textb[5] == "0") str += " ASC";
                        else if (textb[5] == "1") str += " DESC";
                        str += " LIMIT " + textb[2] + ", " + textb[3] + ";";
                    break;
                    // Поиск по пользователям
                case 5: str = "SELECT readers.library_card as 'Билет', users.id as 'ID', users.user_login as 'Логин', users.user_fio as 'ФИО', users.user_email as 'E-Mail', users.user_phone as 'Телефон', users.user_group as 'Группа' FROM users LEFT JOIN readers ON readers.user_id = users.id ";
                        if (textb[0] != null) str += "WHERE users.id = '" + textb[0] + "' ";
                        else if (textb[1] != null) str += "WHERE readers.library_card = '" + textb[1] + "' or readers.library_card IS NULL ";
                        else if (textb[2] != null) str += "WHERE users.user_login = '" + textb[2] + "' ";
                        else if (textb[3] != null) str += "WHERE users.user_fio LIKE '%" + textb[3] + "%' ";
                        else if (textb[4] != null) str += "WHERE users.user_email = '" + textb[4] + "' ";
                        else if (textb[5] != null) str += "WHERE users.user_phone LIKE '%" + textb[5] + "%' ";
                        else if (textb[6] != null) str += "WHERE users.user_group LIKE '%" + textb[6] + "%' ";
                        if (textb[9] == "0") str += "ORDER BY readers.library_card";
                        else if (textb[9] == "1") str += "ORDER BY users.id";
                        else if (textb[9] == "2") str += "ORDER BY users.user_login";
                        else if (textb[9] == "3") str += "ORDER BY users.user_fio";
                        else if (textb[9] == "4") str += "ORDER BY users.user_email";
                        else if (textb[9] == "5") str += "ORDER BY users.user_phone";
                        else if (textb[9] == "6") str += "ORDER BY users.user_group";
                        if (textb[10] == "0") str += " ASC ";
                        else if (textb[10] == "1") str += " DESC ";
                    str += "LIMIT " + textb[7] + ", " + textb[8] + ";";
                    break;
                    // Проверка совпадений данных при редактировании пользователя
                case 6: str = "SELECT COUNT(*) FROM readers WHERE library_card = " + textb[0];
                        if (textb[1] != null) str += " and user_id != " + textb[1];
                        str += ";";
                    break;
                case 7: str = "SELECT COUNT(*) FROM users WHERE user_login = '" + textb[0] + "'";
                        if (textb[1] != null) str += " and id != " + textb[1];
                        str += ";";
                    break;
                case 8: str = "SELECT COUNT(*) FROM users WHERE user_email = '" + textb[0] + "'";
                        if (textb[1] != null) str += " and id != " + textb[1];
                        str += ";";
                    break;
                case 9: str = "SELECT COUNT(*) FROM users WHERE user_phone = '" + textb[0] + "'";
                        if (textb[1] != null) str += " and id != " + textb[1];
                        str += ";";
                    break;
                case 10: str = "SELECT COUNT(*) FROM issuance JOIN readers ON issuance.readers_id = readers.id WHERE readers.library_card = " + textb[0] + ";"; break;
                    // Редактирование пользователя
                case 11: str = "START TRANSACTION; SET foreign_key_checks = 0; UPDATE users LEFT JOIN readers ON users.id = readers.user_id SET readers.library_card = " + textb[0] + ", users.user_login = '" + textb[1] + "', users.user_fio = '" + textb[2] + "', users.user_email = '" + textb[3] + "', users.user_phone = '" + textb[4] + "' WHERE users.id = " + textb[5] + "; SET foreign_key_checks = 1; COMMIT;"; break;
                    // Смена пароля пользователя
                case 12: str = "UPDATE users SET user_password = '" + textb[0] + "' WHERE id = " + textb[1] + ";"; break;
                    // Удаление пользователя
                case 13: str = "DELETE FROM users WHERE id = " + textb[0] + ";"; break;
                    // Создание пользователя
                case 14: str = "START TRANSACTION; INSERT INTO users (user_login, user_password, user_fio, user_email, user_phone) VALUES ('" + textb[0] + "', MD5('" + textb[1] + "'), '" + textb[2] + "', '" + textb[3] + "', '" + textb[4] + "'); INSERT INTO readers (user_id, library_card) SELECT id, " + textb[5] + " FROM users WHERE user_login = '" + textb[0] + "'; COMMIT;"; break;
                    // Добавление книги пользователю
                case 15: str = "INSERT INTO issuance (code_instances, readers_id, date_of_issue, date_of_completion) SELECT " + textb[0] + ", id, NOW(), '" + textb[2] + "' FROM readers WHERE library_card = " + textb[1] + ";"; break;
                    // Проверяем существует ли экземпляр книги
                case 16: str = "SELECT COUNT(*) FROM instances WHERE code_instances = " + textb[0] + ";"; break;
                    // Проверяем свободен ли экземпляр книги
                case 17: str = "SELECT COUNT(*) FROM issuance WHERE code_instances = " + textb[0] + ";"; break;
                    // Удаление книги(долга) пользователя
                case 18: str = "DELETE FROM issuance WHERE code_issuing = " + textb[0] + ";"; break;
                    // Получения списка экземпляров книги
                case 19: str = "SELECT instances.code_instances as 'ID экземпляра', instances.isbn_issn as 'ISBN/ISSN', instances.state_instances as 'Состояние экземпляра', IF((SELECT COUNT(*) FROM issuance WHERE issuance.code_instances = instances.code_instances) > 0, 'Взята', 'Свободна') as 'Наличие' FROM instances LEFT JOIN issuance ON issuance.code_instances = instances.code_instances WHERE code_book = " + textb[0] + ";"; break;
                    // Редактирование книги
                case 20: str = "UPDATE books SET title = '" + textb[0] + "', author = '" + textb[1] + "', authors_other = '" + textb[2] + "', year_of_publ = " + textb[3] + " WHERE books.code_book = " + textb[4] + ";"; break;
                    // Удаление книги
                case 21: str = "DELETE FROM books WHERE code_book = " + textb[0] + ";"; break;
                    // Проверка взят ли экземпляр читателем перед его удалением
                case 22: str = "SELECT COUNT(*) FROM issuance JOIN instances ON issuance.code_instances = instances.code_instances WHERE instances.code_instances = " + textb[0] + ";"; break;
                    // Удаление экземпляра книги
                case 23: str = "DELETE FROM instances WHERE code_instances = " + textb[0] + ";"; break;
                    // Создание (добавление) книги
                case 24: str = "INSERT INTO books (title, author, authors_other, year_of_publ) VALUES ('" + textb[0] + "', '" + textb[1] + "', '" + textb[2] + "', " + textb[3] + ");"; break;
                    // Проверка ISBN/ISSN в бд при добавлении экземпляра
                case 25: str = "SELECT COUNT(*) FROM instances WHERE isbn_issn = '" + textb[0] + "'";
                        if (textb[1] != null) str += " and code_instances != " + textb[1];
                        str += ";";
                    break;
                    // Создание (добавление) экземпляра книги
                case 26: str = "INSERT INTO instances (isbn_issn, state_instances, code_book) VALUES ('" + textb[0] + "', '" + textb[1] + "', " + textb[2] + ");"; break;
                    // Редактирование экземпляра книги
                case 27: str = "UPDATE instances SET isbn_issn = '" + textb[0] + "', state_instances = '" + textb[1] + "' WHERE instances.code_instances = " + textb[2] + ";"; break;
                    // Получаем id читателя у которого книга
                case 28: str = "SELECT readers.user_id FROM issuance JOIN readers ON readers.id = issuance.readers_id WHERE issuance.code_instances = " + textb[0] + ";"; break;
                    // Обновление каталога долгов
                case 29: str = "SELECT issuance.code_issuing as 'ID долга', issuance.code_instances as 'ID экземпляра', issuance.date_of_issue as 'Была взята', issuance.date_of_completion as 'Взята до', readers.user_id as 'ID пользователя' FROM issuance JOIN readers ON readers.id = issuance.readers_id ORDER BY issuance.date_of_completion LIMIT " + textb[0] + ", " + textb[1] + ";"; break;
                    // Получение актуальных новостей
                case 30: str = "SELECT news FROM settings;"; break;
                    // Редактирование актуальных новостей
                case 31: str = "UPDATE settings SET news = '" + textb[0] + "' WHERE id = 1;"; break;
                    // Получение списка сотрудников
                case 32: str = "SELECT id as 'ID', user_login as 'Логин', user_fio as 'ФИО', user_email as 'E-Mail', user_phone as 'Телефон', user_group as 'Группа' FROM users WHERE user_group = 'Библиотекарь';"; break;
                    // Забираем права библиотекаря
                case 33: str = "UPDATE users SET user_group = 'Пользователь' WHERE id = " + textb[0] + ";"; break;
                    // Выдаем права библиотекаря
                case 34: str = "UPDATE users SET user_group = 'Библиотекарь' WHERE user_login = '" + textb[0] + "';"; break;
                    // Смотрим группу пользователя перед выдачей прав
                case 35: str = "SELECT user_group FROM users WHERE user_login = '" + textb[0] + "';"; break;
                    // Смотрим существует ли пользователь перед выдачей прав
                case 36: str = "SELECT COUNT(*) FROM users WHERE user_login = '" + textb[0] + "';"; break;

            }
            action(arg2, DB.request(str));
        }

        public static int request_login(params string[] textb)
        {
            string str = "SELECT * FROM users WHERE user_login = '" + textb[0] + "' and user_password = MD5('" + textb[1] + "');";
            DataTable table = DB.request(str);

            if (table.Rows.Count == 1 && table != null)
            {
                User.login(table); // Добавляем информацию о пользователи
                return User.group;
            }
            return 0;
        }
    }
}
