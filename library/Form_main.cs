using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma
{
    public partial class Form_main : Form
    {
        private int pageSize = 14; // Размер страницы
        private int pageNumber = 0; // Текущая страница
        private string sort_by = "0"; // Сортировать каталог по..
        private string sort_asc_desc = "0"; // Сортировать ▲▼

        // Окно
        public Form_main() // Инициализация формы
        {
            InitializeComponent();
            _focus.Focus();
        }

        public Form_registration Form_registration
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private void Form_group_1_Load(object sender, EventArgs e) // Начальные параметры формы
        {
            comboBox_catalogue_search_by.SelectedIndex = 0; // Начинаем с "По названию"
            catalogue_search(); // Выводим первую страницу каталога
            panel_news.BringToFront(); // Выбириаем первый элемент импровизированного tabControl
            paint_button(button_news); // Закрашиваем первый элемент импровизированного tabControl
            paint_sortLabel(label_sort_by_title); // Закрашиваем первый элемент сортировки
            news_update(); // Обновление новостей
        }

        // Электронный каталог
        private void button_catalogue_search_Click(object sender, EventArgs e) // Поиск по каталогу
        {
            _focus.Focus(); // Перевод фокуса кнопки
            pageNumber = 0; // Первая страница каталога
            catalogue_search(); // Обновление каталога
        }
        private void button_catalogue_backPage_Click(object sender, EventArgs e) // Предыдущая страница каталога
        {
            _focus.Focus(); // Перевод фокуса кнопки
            pageNumber--; // Предыдущая страница каталога
            catalogue_search(); // Обновление каталога
        }
        private void button_catalogue_nextPage_Click(object sender, EventArgs e) // Следующая страница каталога
        {
            _focus.Focus(); // Перевод фокуса кнопки
            pageNumber++; // Следующая страница каталога
            catalogue_search(); // Обновление каталога
        }
        private void catalogue_search() // Поиск по каталогу
        {
            // Блокируем кнопку назад если это первая страница
            if (pageNumber <= 0) button_catalogue_backPage.Enabled = false;
            else button_catalogue_backPage.Enabled = true;

            // Вывод всего каталога
            if (cueTextBox_catalogue_search.Text == "")
                Working.request(4, 4, null, null, (pageNumber * pageSize).ToString(), pageSize.ToString(), sort_by, sort_asc_desc);
            // Поиск по названию
            else if (comboBox_catalogue_search_by.SelectedIndex == 0)
                Working.request(4, 4, cueTextBox_catalogue_search.Text, null, (pageNumber * pageSize).ToString(), pageSize.ToString(), sort_by, sort_asc_desc);
            // Поиск по автору
            else
                Working.request(4, 4, null, cueTextBox_catalogue_search.Text, (pageNumber * pageSize).ToString(), pageSize.ToString(), sort_by, sort_asc_desc);

            // Блокируем кнопку вперед если это последняя страница
            if (Working.buffer_cbook.Rows.Count < pageSize) button_catalogue_nextPage.Enabled = false;
            else button_catalogue_nextPage.Enabled = true;

            // Выводим каталог
            dataGridView_catalogue_search.DataSource = Working.buffer_cbook;
            dataGridView_catalogue_search.Columns.RemoveAt(0); // Удаляем столбец "ID"
        }

        // Импровизированный tabControl
        private void paint_button(Button btn) // Визуальное оформление кнопок
        {
            _focus.Focus(); // Перевод фокуса кнопки

            // Дефолтный цвет для всех кнопок
            button_info.BackColor = SystemColors.ScrollBar;
            button_ebook.BackColor = SystemColors.ScrollBar;
            button_catalogue.BackColor = SystemColors.ScrollBar;
            button_news.BackColor = SystemColors.ScrollBar;
            button_login.BackColor = SystemColors.ScrollBar;
            button_logout.BackColor = SystemColors.ScrollBar;

            // Нажатую кнопку окрашиваем
            btn.BackColor = SystemColors.ActiveCaption;
        }
        private void button_info_Click(object sender, EventArgs e) // Вывод панели информации о пользователе
        {
            paint_button(button_info); // Красим кнопку
            panel_info.BringToFront(); // Панель на передний план
        }
        private void button_ebook_Click(object sender, EventArgs e) // Вывод панели долгов пользователя
        {
            
            paint_button(button_ebook); // Красим кнопку
            panel_extend_book.BringToFront(); // Панель на передний план
        }
        private void button_catalogue_Click(object sender, EventArgs e) // Вывод панели с каталогом
        {
            paint_button(button_catalogue); // Красим кнопку
            panel_catalogue.BringToFront(); // Панель на передний план
        }
        private void button_news_Click(object sender, EventArgs e) // Вывод панели актуальных новостей
        {
            paint_button(button_news); // Красим кнопку
            panel_news.BringToFront(); // Панель на передний план
        }
        private void button_login_Click(object sender, EventArgs e) // Вывод панели авторизации
        {
            paint_button(button_login); // Красим кнопку
            panel_login.BringToFront(); // Панель на передний план
        }

        // Авторизация
        private void button_usr_login_Click(object sender, EventArgs e) // Кнопка входа
        {
            // Проверка логина и пароля
            int arg = Working.request_login(cueTextBox_usr_login.Text, cueTextBox_usr_password.Text);
            if (arg == 1 || arg == 2 || arg ==3) // Все группы
            {
                paint_button(button_news);  // Красим кнопку
                panel_news.BringToFront(); // Панель новостей на передний план
                panel_login.Visible = false; // Убираем панель авторизации

                // Кнопка долгов пользователя
                if (User.library_card != 0) button_ebook.Visible = true;
                else button_ebook.Visible = false;
                button_info.Visible = true; // Кнопка информации о пользователе
                button_login.Visible = false; // Убираем кнопку панели авторизации
                button_logout.Visible = true; // Кнопка выйти из системы

                label_errorLogin.Visible = false; // Убираем надпись ошибки авторизации

                label_personal_data.Text = User.get_info(); // Выводим информацию о пользователе
                if (User.library_card != 0) // Если привязан читательский билет
                    dataGridView_extend_book.DataSource = User.get_extend_book(); // Получаем информацию о задолжностях

                if (arg == 2 || arg == 3) // Библиотекарь или директор
                {
                    button_group_2.Visible = true; // Кнопка панели библиотекаря

                    if (arg == 3) // Только директор
                    {
                        button_group_3.Visible = true; // Кнопка панели директора
                    }
                }
            }
            else label_errorLogin.Visible = true; // Надпись ошибки авторизации
        }
        private void button_logout_Click(object sender, EventArgs e) // Выход пользователя из системы
        {
            User.logout(); // Очистка данных предыдущего пользователя

            // Работа с кнопками
            paint_button(button_news);
            panel_news.BringToFront();
            panel_login.Visible = true;
            button_info.Visible = false;
            button_ebook.Visible = false;
            button_login.Visible = true;
            button_logout.Visible = false;
            button_group_2.Visible = false;
            button_group_3.Visible = false;
        }
        private void button_usr_registration_Click(object sender, EventArgs e)
        {
            _focus.Focus(); // Перевод фокуса кнопки
            Form FG = new Form_registration(); // Создаем новое окно
            FG.ShowDialog(); // Отображаем новое окно
        }

        // Другие окна
        private void button_group_3_Click(object sender, EventArgs e) // Окно директора
        {
            _focus.Focus(); // Перевод фокуса кнопки
            Form FG = new Form_group_3(this); // Создаем новое окно
            FG.Show(); // Отображаем новое окно
            this.Hide(); // Скрываем текущее окно
        }
        private void button_group_2_Click(object sender, EventArgs e) // Окно библиотекаря
        {
            _focus.Focus(); // Перевод фокуса кнопки
            Form FG = new Form_group_2(this); // Создаем новое окно
            FG.Show(); // Отображаем новое окно
            this.Hide(); // Скрываем текущее окно
        }
        
        // Сортировка электронного каталога
        private void label_sort_by_title_Click(object sender, EventArgs e)
        {
            paint_sortLabel(label_sort_by_title);
            pageNumber = 0;
            sort_by = "0";
            catalogue_search(); // Обновление каталога
        }
        private void label_sort_by_author_Click(object sender, EventArgs e)
        {
            paint_sortLabel(label_sort_by_author);
            pageNumber = 0;
            sort_by = "1";
            catalogue_search(); // Обновление каталога
        }
        private void label_sort_by_year_of_publ_Click(object sender, EventArgs e)
        {
            paint_sortLabel(label_sort_by_year_of_publ);
            pageNumber = 0;
            sort_by = "2";
            catalogue_search(); // Обновление каталога
        }
        private void label_sort_abc_Click(object sender, EventArgs e)
        {
            if (label_sort_abc.Text == "▲")
            {
                label_sort_abc.Text = "▼";
                sort_asc_desc = "1";
            }
            else
            {
                label_sort_abc.Text = "▲";
                sort_asc_desc = "0";
            }
            pageNumber = 0;
            catalogue_search(); // Обновление каталога
        }
        private void paint_sortLabel(Label lab) // Визуальное оформление сортировки
        {
            // Дефолтный цвет для всех кнопок
            label_sort_by_title.BackColor = SystemColors.Control;
            label_sort_by_author.BackColor = SystemColors.Control;
            label_sort_by_year_of_publ.BackColor = SystemColors.Control;

            // Нажатую кнопку окрашиваем
            lab.BackColor = SystemColors.ActiveCaption;
        }

        // Актуальные новости
        public void news_update() // Обновление новостей
        {
            Working.request(30, 11);
            richTextBox_news.Text = Working.news;
        }
    }
}