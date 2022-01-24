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
    public partial class Form_group_2 : Form
    {
        // Общие параметры
        Form_main main;

        public Form_group_2(Form_main main)
        {
            this.main = main;
            InitializeComponent();
            _focus.Focus();
        }
        private void Form_group_2_Load(object sender, EventArgs e)
        {
            comboBox_users_search_by.SelectedIndex = 0; // Начинаем с "ID"
            comboBox_catalogue_search_by.SelectedIndex = 0; // Начинаем с "По названию"
            users_search(); // Выводим первую страницу пользователей
            books_search(); // Выводим первую страницу каталога книг
            issuance_update(); // Обновление каталога долгов
            panel_users.BringToFront(); // Выбириаем первый элемент импровизированного tabControl
            paint_button(button_users); // Закрашиваем первый элемент импровизированного tabControl
            paint_sortLabelBook(label_book_sort_by_id); // Закрашиваем первый элемент сортировки каталога
            paint_sortLabelUser(label_user_sort_by_library_card); // Закрашиваем первый элемент сортировки пользователей
        }
        private void Form_group_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
        }
        private void paint_button(Button btn)
        {
            _focus.Focus();

            button_users.BackColor = SystemColors.ScrollBar;
            button_books.BackColor = SystemColors.ScrollBar;
            button_issuance.BackColor = SystemColors.ScrollBar;

            btn.BackColor = SystemColors.ActiveCaption;
        }

        // Работа с панелью пользователей
        private static int pSizeUser = 14; // Размер страницы (пользователи)
        private static int pNumberUser = 0; // Текущая страница (пользователи)

        private void button_users_Click(object sender, EventArgs e)
        {
            paint_button(button_users);
            panel_users.BringToFront();
        }

        private void users_search() // Поиск по каталогу пользователей
        {
            if (pNumberUser <= 0) button_users_backPage.Enabled = false;
            else button_users_backPage.Enabled = true;

            dgv_users_search.DataSource = Librarian.uSearch(cueTextBox_users.Text, comboBox_users_search_by.SelectedIndex, (pNumberUser * pSizeUser).ToString(), pSizeUser.ToString(), user_sort_by, user_sort_asc_desc);

            if (Librarian.users.Rows.Count < pSizeUser) button_users_nextPage.Enabled = false;
            else button_users_nextPage.Enabled = true;
        }
        private void button_users_search_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            pNumberUser = 0;
            users_search();
        }
        private void button_users_backPage_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            pNumberUser--;
            users_search();
        }
        private void button_users_nextPage_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            pNumberUser++;
            users_search();
        }
        private void dgv_users_search_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_users_search.CurrentRow != null)
            {
                Form FG = new Form_user_profile_edit(dgv_users_search.CurrentRow.Cells[0].Value.ToString(), dgv_users_search.CurrentRow.Cells[1].Value.ToString(), dgv_users_search.CurrentRow.Cells[2].Value.ToString(), dgv_users_search.CurrentRow.Cells[3].Value.ToString(), dgv_users_search.CurrentRow.Cells[4].Value.ToString(), dgv_users_search.CurrentRow.Cells[5].Value.ToString(), dgv_users_search.CurrentRow.Cells[6].Value.ToString());
                FG.ShowDialog();
                users_search();
            }
        }
        private void button_users_create_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            Form FG = new Form_user_create();
            FG.ShowDialog();
            users_search();
        }

        // Работа с панелью каталога книг
        private static int pSizeBook = 14; // Размер страницы (книги)
        private static int pNumberBook = 0; // Текущая страница (книги)

        private void button_books_Click(object sender, EventArgs e)
        {
            paint_button(button_books);
            panel_books.BringToFront();
        }

        private void books_search() // Поиск по каталогу книг
        {
            if (pNumberBook <= 0) button_catalogue_backPage.Enabled = false;
            else button_catalogue_backPage.Enabled = true;

            // Вывод всего каталога
            if (cueTextBox_catalogue_search.Text == "")
                Working.request(4, 4, null, null, (pNumberBook * pSizeBook).ToString(), pSizeBook.ToString(), book_sort_by, book_sort_asc_desc);
            // Поиск по названию
            else if (comboBox_catalogue_search_by.SelectedIndex == 0)
                Working.request(4, 4, cueTextBox_catalogue_search.Text, null, (pNumberBook * pSizeBook).ToString(), pSizeBook.ToString(), book_sort_by, book_sort_asc_desc);
            // Поиск по автору
            else
                Working.request(4, 4, null, cueTextBox_catalogue_search.Text, (pNumberBook * pSizeBook).ToString(), pSizeBook.ToString(), book_sort_by, book_sort_asc_desc);

            if (Working.buffer_cbook.Rows.Count < pSizeUser) button_catalogue_nextPage.Enabled = false;
            else button_catalogue_nextPage.Enabled = true;

            dgv_catalogue.DataSource = Working.buffer_cbook;
        }
        private void button_catalogue_search_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            pNumberBook = 0;
            books_search();
        }
        private void button_catalogue_backPage_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            pNumberBook--;
            books_search();
        }
        private void button_catalogue_nextPage_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            pNumberBook++;
            books_search();
        }
        private void dgv_catalogue_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_catalogue.CurrentRow != null)
            {
                Form_book_edit FG = new Form_book_edit(dgv_catalogue.CurrentRow.Cells[0].Value.ToString(), dgv_catalogue.CurrentRow.Cells[1].Value.ToString(), dgv_catalogue.CurrentRow.Cells[2].Value.ToString(), dgv_catalogue.CurrentRow.Cells[3].Value.ToString(), dgv_catalogue.CurrentRow.Cells[4].Value.ToString());
                FG.ShowDialog();
                if (FG.user_id != 0)
                {
                    panel_users.BringToFront();
                    paint_button(button_users);
                    comboBox_users_search_by.SelectedIndex = 0;
                    cueTextBox_users.Text = FG.user_id.ToString();
                    users_search();
                }
                books_search();
            }
        }
        private void button_books_create_Click(object sender, EventArgs e)
        {
            Form FG = new Form_book_create();
            FG.ShowDialog();
            books_search();
            _focus.Focus();
        }

        // Работа с панелью долгов читателей
        private static int pSizeIssuance = 17; // Размер страницы (долги)
        private static int pNumberIssuance = 0; // Текущая страница (долги)

        private void button_issuance_Click(object sender, EventArgs e)
        {
            paint_button(button_issuance);
            panel_issuance.BringToFront();
        }

        private void issuance_update() // Обновление каталога долгов
        {
            if (pNumberIssuance <= 0) button_issuance_backPage.Enabled = false;
            else button_issuance_backPage.Enabled = true;

            dgv_issuance.DataSource = Librarian.dUpdate((pNumberIssuance * pSizeIssuance).ToString(), pSizeIssuance.ToString());
            dgv_issuance.Columns[4].Visible = false; // Отключаем отображение id пользователя

            if (Librarian.issuance.Rows.Count < pSizeIssuance) button_issuance_nextPage.Enabled = false;
            else button_issuance_nextPage.Enabled = true;
        }
        private void button_issuance_update_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            pNumberIssuance = 0;
            issuance_update();
        }
        private void button_issuance_backPage_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            pNumberIssuance--;
            issuance_update();
        }
        private void button_issuance_nextPage_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            pNumberIssuance++;
            issuance_update();
        }
        private void dgv_issuance_DoubleClick(object sender, EventArgs e)
        {
            panel_users.BringToFront();
            paint_button(button_users);
            comboBox_users_search_by.SelectedIndex = 0;
            cueTextBox_users.Text = dgv_issuance.CurrentRow.Cells[4].Value.ToString();
            users_search();
        }

        // Сортировка электронного каталога
        private string book_sort_by = "3"; // Сортировать каталог по..
        private string book_sort_asc_desc = "0"; // Сортировать ▲▼

        private void label_book_sort_by_id_Click(object sender, EventArgs e)
        {
            paint_sortLabelBook(label_book_sort_by_id);
            pNumberBook = 0;
            book_sort_by = "3";
            books_search(); // Обновление каталога
        }
        private void label_book_sort_by_title_Click(object sender, EventArgs e)
        {
            paint_sortLabelBook(label_book_sort_by_title);
            pNumberBook = 0;
            book_sort_by = "0";
            books_search(); // Обновление каталога
        }
        private void label_book_sort_by_author_Click(object sender, EventArgs e)
        {
            paint_sortLabelBook(label_book_sort_by_author);
            pNumberBook = 0;
            book_sort_by = "1";
            books_search(); // Обновление каталога
        }
        private void label_book_sort_by_year_of_publ_Click(object sender, EventArgs e)
        {
            paint_sortLabelBook(label_book_sort_by_year_of_publ);
            pNumberBook = 0;
            book_sort_by = "2";
            books_search(); // Обновление каталога
        }
        private void label_sort_abc_Click(object sender, EventArgs e)
        {
            if (label_book_sort_abc.Text == "▲")
            {
                label_book_sort_abc.Text = "▼";
                book_sort_asc_desc = "1";
            }
            else
            {
                label_book_sort_abc.Text = "▲";
                book_sort_asc_desc = "0";
            }
            pNumberBook = 0;
            books_search(); // Обновление каталога
        }
        private void paint_sortLabelBook(Label lab) // Визуальное оформление сортировки
        {
            // Дефолтный цвет для всех кнопок
            label_book_sort_by_title.BackColor = SystemColors.Control;
            label_book_sort_by_author.BackColor = SystemColors.Control;
            label_book_sort_by_year_of_publ.BackColor = SystemColors.Control;
            label_book_sort_by_id.BackColor = SystemColors.Control;

            // Нажатую кнопку окрашиваем
            lab.BackColor = SystemColors.ActiveCaption;
        }

        // Сортировка каталога пользователей
        private string user_sort_by = "0"; // Сортировать каталог по..
        private string user_sort_asc_desc = "0"; // Сортировать ▲▼

        private void label_user_sort_by_library_card_Click(object sender, EventArgs e)
        {
            paint_sortLabelUser(label_user_sort_by_library_card);
            pNumberUser = 0;
            user_sort_by = "0";
            users_search(); // Обновление каталога
        }
        private void label_user_sort_by_id_Click(object sender, EventArgs e)
        {
            paint_sortLabelUser(label_user_sort_by_id);
            pNumberUser = 0;
            user_sort_by = "1";
            users_search(); // Обновление каталога
        }
        private void label_user_sort_by_login_Click(object sender, EventArgs e)
        {
            paint_sortLabelUser(label_user_sort_by_login);
            pNumberUser = 0;
            user_sort_by = "2";
            users_search(); // Обновление каталога
        }
        private void label_user_sort_by_fio_Click(object sender, EventArgs e)
        {
            paint_sortLabelUser(label_user_sort_by_fio);
            pNumberUser = 0;
            user_sort_by = "3";
            users_search(); // Обновление каталога
        }
        private void label_user_sort_by_email_Click(object sender, EventArgs e)
        {
            paint_sortLabelUser(label_user_sort_by_email);
            pNumberUser = 0;
            user_sort_by = "4";
            users_search(); // Обновление каталога
        }
        private void label_user_sort_by_phone_Click(object sender, EventArgs e)
        {
            paint_sortLabelUser(label_user_sort_by_phone);
            pNumberUser = 0;
            user_sort_by = "5";
            users_search(); // Обновление каталога
        }
        private void label_user_sort_by_group_Click(object sender, EventArgs e)
        {
            paint_sortLabelUser(label_user_sort_by_group);
            pNumberUser = 0;
            user_sort_by = "6";
            users_search(); // Обновление каталога
        }
        private void label_user_sort_abc_Click(object sender, EventArgs e)
        {
            if (label_user_sort_abc.Text == "▲")
            {
                label_user_sort_abc.Text = "▼";
                user_sort_asc_desc = "1";
            }
            else
            {
                label_user_sort_abc.Text = "▲";
                user_sort_asc_desc = "0";
            }
            pNumberUser = 0;
            users_search(); // Обновление каталога
        }
        private void paint_sortLabelUser(Label lab)
        {
            // Дефолтный цвет для всех кнопок
            label_user_sort_by_library_card.BackColor = SystemColors.Control;
            label_user_sort_by_id.BackColor = SystemColors.Control;
            label_user_sort_by_login.BackColor = SystemColors.Control;
            label_user_sort_by_fio.BackColor = SystemColors.Control;
            label_user_sort_by_email.BackColor = SystemColors.Control;
            label_user_sort_by_phone.BackColor = SystemColors.Control;
            label_user_sort_by_group.BackColor = SystemColors.Control;

            // Нажатую кнопку окрашиваем
            lab.BackColor = SystemColors.ActiveCaption;
        }
    }
}
