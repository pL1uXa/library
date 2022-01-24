using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma
{
    static class Program
    {
        public static ApplicationContext Context { get; set; }

        public static Form_main Form_main
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal static Properties.Resources Resources
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal static Properties.Settings Settings
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form_login()); // Форма авторизации
            //Application.Run(new Form_registration()); // Форма регистрации
            //Application.Run(new Form_group_1()); // Форма пользователя 1 группы

            Context = new ApplicationContext(new Form_main());
            Application.Run(Context);
        }
    }
}
