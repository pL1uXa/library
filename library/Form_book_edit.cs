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
    public partial class Form_book_edit : Form
    {
        public string code_book;
        public string title;
        public string author;
        public string authors_other;
        public string year_of_publ;

        public int user_id { set; get; }

        // Окно
        public Form_book_edit(string code_book, string title, string author, string authors_other, string year_of_publ)
        {
            InitializeComponent();
            _focus.Focus();

            this.code_book = code_book;
            textBox_edit_title.Text = this.title = title;
            textBox_edit_author.Text = this.author = author;
            textBox_edit_authors_other.Text = this.authors_other = authors_other;
            textBox_edit_year_of_publ.Text = this.year_of_publ = year_of_publ;
        }
        private void Form_book_edit_Load(object sender, EventArgs e)
        {
            update_instances(); // Обновление списка экземпляров
            panel_books_edit.BringToFront(); // Выбириаем первый элемент импровизированного tabControl
            paint_button(button_books_edit_view); // Закрашиваем первый элемент импровизированного tabControl
        }

        // Кнопки меню
        private void paint_button(Button btn)
        {
            _focus.Focus();

            button_books_edit_view.BackColor = SystemColors.ScrollBar;
            button_instances_view.BackColor = SystemColors.ScrollBar;

            btn.BackColor = SystemColors.ActiveCaption;
        }
        private void button_books_edit_view_Click(object sender, EventArgs e)
        {
            // Панель редактирования книги
            panel_books_edit.BringToFront(); // Выбириаем первый элемент импровизированного tabControl
            paint_button(button_books_edit_view); // Закрашиваем первый элемент импровизированного tabControl
        }
        private void button_instances_view_Click(object sender, EventArgs e)
        {
            // Панель редактирования списка экземпляров
            update_instances(); // Вывод списка экземпляров
            panel_books_instances.BringToFront(); // Выбириаем первый элемент импровизированного tabControl
            paint_button(button_instances_view); // Закрашиваем первый элемент импровизированного tabControl
        }

        // Редактирование книги
        private void button_books_edit_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Редактирование книги
            string str = Librarian.bEdit(code_book, textBox_edit_title.Text, textBox_edit_author.Text, textBox_edit_authors_other.Text, textBox_edit_year_of_publ.Text);
            if (str == "Изменения сохранены!")
            {
                title = textBox_edit_title.Text;
                author = textBox_edit_author.Text;
                authors_other = textBox_edit_authors_other.Text;
                year_of_publ = textBox_edit_year_of_publ.Text;
            }
            MessageBox.Show(str);
        }
        private void button_books_delete_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Удаление пользователя
            string str = Librarian.bDelete(code_book);
            if (str == "Книга успешно удалена!")
            {
                this.Close(); // Закрываем текущую форму
            }
            MessageBox.Show(str);
        }

        // Редактирование экземпляров книги
        private void update_instances() // Обновление списка экземпляров
        {
            dgv_books_instances.DataSource = Librarian.bInstances(code_book);

            if (dgv_books_instances.Rows.Count == 0)
            {
                button_instances_delete.Enabled = false;
                button_instances_view_user.Enabled = false;
            }
            else
            {
                button_instances_delete.Enabled = true;
                button_instances_view_user.Enabled = true;
            }
        }
        private void button_instances_delete_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Удаление экземпляра книги
            MessageBox.Show(Librarian.iDelete(dgv_books_instances.CurrentRow.Cells[0].Value.ToString()));
            update_instances(); // Обновление списка экземпляров
        }
        private void button_instances_add_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Форма добавления экземпляра книги
            Form FG = new Form_book_instances_add(code_book);
            FG.ShowDialog();
            update_instances(); // Обновление списка экземпляров
        }
        private void dgv_books_instances_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_books_instances.CurrentRow != null)
            {
                Form FG = new Form_book_instances_edit(dgv_books_instances.CurrentRow.Cells[0].Value.ToString(), dgv_books_instances.CurrentRow.Cells[1].Value.ToString(), dgv_books_instances.CurrentRow.Cells[2].Value.ToString());
                FG.ShowDialog();
                update_instances();
            }
        }
        private void button_instances_view_user_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Посмотреть у какого пользователя данный экземпляр
            if (dgv_books_instances.CurrentRow.Cells[3].Value.ToString() == "Взята")
            {
                Working.request(28, 9, dgv_books_instances.CurrentRow.Cells[0].Value.ToString());
                user_id = Working.arg_return;
                this.Close();
            }
            else MessageBox.Show("Книга находится в библиотеке!");
        }
    }
}
