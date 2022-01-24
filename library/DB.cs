using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace diploma
{
    static class DB
    {
        private static string host = "sangvinius.ru"; // 192.168.1.39 || localhost
        private static string userdb = "andrei";
        private static string password = "qwerty";
        private static string database = "library_3";

        private static string strConn = $"server={host};userid={userdb};password={password};database={database}";

        private static MySqlConnection connection = new MySqlConnection(strConn);

        public static DataTable request(string query) // Выполняем запрос
        {
            MySqlCommand cmd;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            try
            {
                cmd = new MySqlCommand(query, connection);
                adapter.SelectCommand = cmd; // Указываем выполняемую команду
                adapter.Fill(table); // Записываем результат команды

                return table; // Возвращаем таблицу
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так..");
            }

            return null;
        }
    }
}