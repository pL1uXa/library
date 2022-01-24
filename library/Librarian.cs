using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma
{
    static class Librarian
    {
        public static DataTable users; // Таблица всех пользователей
        public static DataTable debts; // Таблица долгов пользователя
        public static DataTable instances; // Таблица экземпляров книги
        public static DataTable issuance; // Таблица всех долгов читателей

        public static Form_group_2 Form_group_2
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        // Работа с пользователями
        public static DataTable uSearch(string search, int search_by, string limit_1, string limit_2, string sort_by, string sort_by_2) // Поиск по пользователям
        {
            if (search == "")
                Working.request(5, 5, null, null, null, null, null, null, null, limit_1, limit_2, sort_by, sort_by_2);
            else
                switch (search_by)
                {
                    case 0: Working.request(5, 5, search, null, null, null, null, null, null, limit_1, limit_2, sort_by, sort_by_2); break;
                    case 1: Working.request(5, 5, null, search, null, null, null, null, null, limit_1, limit_2, sort_by, sort_by_2); break;
                    case 2: Working.request(5, 5, null, null, search, null, null, null, null, limit_1, limit_2, sort_by, sort_by_2); break;
                    case 3: Working.request(5, 5, null, null, null, search, null, null, null, limit_1, limit_2, sort_by, sort_by_2); break;
                    case 4: Working.request(5, 5, null, null, null, null, search, null, null, limit_1, limit_2, sort_by, sort_by_2); break;
                    case 5: Working.request(5, 5, null, null, null, null, null, search, null, limit_1, limit_2, sort_by, sort_by_2); break;
                    case 6: Working.request(5, 5, null, null, null, null, null, null, search, limit_1, limit_2, sort_by, sort_by_2); break;
                }
            return users;
        }
        public static string uEdit(string id, string old_library_card, string library_card, string login, string email, string phone, string fio, string group) // Редактирование пользователя
        {
            if (library_card == "") library_card = "NULL";
            Working.request(6, 6, library_card, id);
            if (Working.arg_return == 0) // Проверка билета
            {
                Working.request(7, 6, login, id);
                if (Working.arg_return == 0) // Проверка логина
                {
                    Working.request(8, 6, email, id);
                    if (Working.arg_return == 0) // Проверка e-mail
                    {
                        Working.request(9, 6, phone, id);
                        if (Working.arg_return == 0) // Проверка телефона
                        {
                            if (old_library_card != "" && old_library_card != library_card)
                                Working.request(10, 6, old_library_card);
                            if (Working.arg_return == 0) // Проверка задолжностей
                            {
                                if (group == "Пользователь" || User.group == 3)
                                { // Нельзя трогать Библиотекарей и Директора
                                    if (library_card == "") library_card = "NULL";
                                    Working.request(11, 0, library_card, login, fio, email, phone, id);
                                    return "Изменения сохранены!";
                                }
                                else return "Недостаточно прав!";
                            }
                            else return "На текущем читательском билете еще есть задолжности!";
                        }
                        else return "Данный телефон уже используется!";
                    }
                    else return "Данный e-mail уже используется!";
                }
                else return "Данный логин уже используется!";
            }
            else return "Данный читательский билет уже используется!";
        }
        public static string uNewPass(string id, string new_pass, string new_pass_2, string group) // Смена пароля пользователя
        {
            if (new_pass == new_pass_2)
            {
                if (group == "Пользователь" || User.group == 3)
                {
                    Working.request(12, 0, new_pass, id);
                    return "Пароль успешно изменен!";
                }
                else return "Недостаточно прав!";
            }
            else return "Пароли не совпадают!";
        }
        public static DataTable uDebts(string library_card) // Обновление долгов пользователя
        {
            Working.request(3, 7, library_card);
            return debts;
        }
        public static string uDelete(string id, string library_card, string group) // Удаление пользователя
        {
            int check = 0;
            if (library_card != "")
            {
                Working.request(10, 6, library_card);
                if (Working.arg_return == 0) check = 0;
                else check = 1;
            }
            if (check == 0) // Проверка задолжностей
            {
                if (group == "Пользователь" || User.group == 3 || User.id.ToString() == id)
                { // Нельзя трогать Библиотекарей, Директора и себя
                    Working.request(13, 0, id);
                    return "Пользователь удален!";
                }
                else return "Недостаточно прав!";
            }
            else return "На текущем читательском билете еще есть задолжности!";
        }
        public static string uCreate(string login, string pass, string pass_2, string fio, string email, string phone, string library_card) // Создание пользователя
        {
            string lib_card = library_card;
            if (lib_card == "") lib_card = "NULL";

            if (login == "") return "Введите логин!";
            if (fio == "") return "Введите ФИО!";
            if (email == "") return "Введите e-mail!";
            if (phone == "") return "Введите телефон!";
            if (pass == "") return "Введите пароль!";
            if (pass_2 == "") return "Введите пароль еще раз!";
            if (pass != pass_2) return "Пароли не совпадают!";

            Working.request(6, 6, lib_card, null);
            if (Working.arg_return == 0) // Проверка билета
            {
                Working.request(7, 6, login, null);
                if (Working.arg_return == 0) // Проверка логина
                {
                    Working.request(8, 6, email, null);
                    if (Working.arg_return == 0) // Проверка e-mail
                    {
                        Working.request(9, 6, phone, null);
                        if (Working.arg_return == 0) // Проверка телефона
                        {
                            Working.request(14, 0, login, pass, fio, email, phone, lib_card);
                            return "Пользователь создан!";
                        }
                        else return "Данный телефон уже используется!";
                    }
                    else return "Данный e-mail уже используется!";
                }
                else return "Данный логин уже используется!";
            }
            else return "Данный читательский билет уже используется!";
        }

        // Работа с долгами пользователей
        public static string dAdd(string code_instances, string library_card, string date_of_completion) // Добавление книги(долга) пользователю
        {
            Working.request(16, 6, code_instances);
            if (Working.arg_return == 1) // Проверяем существует ли такой экземпляр
            {
                Working.request(17, 6, code_instances);
                if (Working.arg_return == 0) // Проверяем свободна ли книга
                {
                    // Смотрим чтобы дата сдачи была больше текущей даты
                    Working.request(15, 0, code_instances, library_card, date_of_completion); // Добавляем запись
                    return "Книга успешно добавлена!";
                }
                else return "Данная книга уже кем-то взята!";
            }
            else return "Данный экземпляр в базе данных не числится!";
        }
        public static string dDelete(string code_issuing) // Удаление книги(долга) пользователя
        {
            Working.request(18, 0, code_issuing);
            return "Книга успешно удалена!";
        }
        public static DataTable dUpdate(string limit_1, string limit_2) // Обновление каталога долгов
        {
            Working.request(29, 10, limit_1, limit_2);
            return issuance;
        }

        // Работа с каталогом книг
        public static DataTable bInstances(string code_book) // Обновление списка экземпляров книги
        {
            Working.request(19, 8, code_book);
            return instances;
        }
        public static string bEdit(string code_book, string title, string author, string authors_other, string year_of_publ) // Редактирование книги
        {
            Working.request(20, 0, title, author, authors_other, year_of_publ, code_book);
            return "Изменения сохранены!";
        }
        public static string bDelete(string code_book) // Удаление книги
        {
            if (instances.Rows.Count == 0) // Если у книги нет экземпляров
            {
                Working.request(21, 0, code_book);
                return "Книга успешно удалена!";
            }
            else return "У книги есть экземпляры!";
        }
        public static string bCreate(string title, string author, string authors_other, string year_of_publ) // Создание книги
        {
            Working.request(24, 0, title, author, authors_other, year_of_publ);
            return "Книга создана!";
        }

        // Работа с экземплярами книг
        public static string iDelete(string code_instances) // Удаление экземпляра книги
        {
            Working.request(22, 6, code_instances);
            if (Working.arg_return == 0)
            {
                Working.request(23, 0, code_instances);
                return "Экземпляр книги успешно удален!";
            }
            return "Данный экземпляр находится у читателя!";
        }
        public static string iAdd(string state_instances, string isbn_issn, string code_book) // Добавление экземпляра книги
        {
            if (isbn_issn != "")
            {
                Working.request(25, 6, isbn_issn, null);
                if (Working.arg_return == 0) // Проверка ISBN/ISSN
                {
                    Working.request(26, 0, isbn_issn, state_instances, code_book);
                    return "Книга успешно добавлена!";
                }
                else return "Данный ISBN/ISSN уже используется!";
            }
            else return "Введите ISBN/ISSN!";
        }
        public static string iEdit(string code_instances, string isbn_issn, string state_instances) // Редактирование экземпляра
        {
            if (isbn_issn != "")
            {
                Working.request(25, 6, isbn_issn, code_instances);
                if (Working.arg_return == 0) // Проверка ISBN/ISSN
                {
                    Working.request(27, 0, isbn_issn, state_instances, state_instances);
                    return "Изменения сохранены!";
                }
                else return "Данный ISBN/ISSN уже используется!";
            }
            else return "Введите ISBN/ISSN!";
        }
    }
}
