using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma
{
    static class Director
    {
        public static DataTable users; // Таблица всех сотрудников

        public static Form_group_3 Form_group_3
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public static DataTable uUpdate() // Обновление списка сотрудников
        {
            Working.request(32, 12);
            return users;
        }
        public static string nUpdate() // Обновление актуальных новостей
        {
            Working.request(30, 11);
            return Working.news;
        }
        public static string uDemotion(string id) // Забирать права пользователя
        {
            Working.request(33, 0, id);
            return "С пользователя были сняты все права!";
        }
        public static string uPromotion(string login) // Выдать права пользователю
        {
            Working.request(36, 14, login); // Существует ли пользователь
            if (Working.arg_return == 0)
            {
                Working.request(35, 13, login); // Проверка на группу
                if (Working.arg_return == 0)
                {
                    Working.request(34, 0, login);
                    return "Права успешно выданы!";
                }
                return "Данный пользователь уже библиотекарь или директор!";
            }
            return "Такого пользователя не существует!";
        }
    }
}
