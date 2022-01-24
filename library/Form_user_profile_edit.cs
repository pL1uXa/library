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
    public partial class Form_user_profile_edit : Form
    {
        private string library_card;
        private string id;
        private string login;
        private string fio;
        private string email;
        private string phone;
        private string group;

        // Окно
        public Form_user_profile_edit(string library_card, string id, string login, string fio, string email, string phone, string group)
        {
            InitializeComponent();
            _focus.Focus();

            this.id = id;
            this.group = group;
            textBox_edit_library_card.Text = this.library_card = library_card;
            textBox_edit_login.Text = this.login = login;
            textBox_edit_fio.Text = this.fio = fio;
            textBox_edit_email.Text = this.email = email;
            textBox_edit_phone.Text = this.phone = phone;
        }

        private void Form_use_profile_edit_Load(object sender, EventArgs e)
        {
            update_debts(); // Обновление списка долгов
            panel_users_edit.BringToFront(); // Выбириаем первый элемент импровизированного tabControl
            paint_button(button_users_edit_view); // Закрашиваем первый элемент импровизированного tabControl
        }

        // Кнопки меню
        private void paint_button(Button btn)
        {
            _focus.Focus();

            button_users_edit_view.BackColor = SystemColors.ScrollBar;
            button_debts_view.BackColor = SystemColors.ScrollBar;

            btn.BackColor = SystemColors.ActiveCaption;
        }
        private void button_users_edit_view_Click(object sender, EventArgs e)
        {
            // Панель редактирования пользователя
            paint_button(button_users_edit_view);
            panel_users_edit.BringToFront();
        }
        private void button_debts_view_Click(object sender, EventArgs e)
        {
            // Панель редактирования долгов пользователя
            update_debts(); // Вывод долгов пользователя
            panel_users_debts.BringToFront(); // Выбириаем первый элемент импровизированного tabControl
            paint_button(button_debts_view); // Закрашиваем первый элемент импровизированного tabControl
        }

        // Редактирование пользователя
        private void button_edit_new_pass_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Смена пароля пользователя
            MessageBox.Show(Librarian.uNewPass(id, cueTextBox_edit_new_pass.Text, cueTextBox_edit_new_pass_2.Text, group)); // Редактирование пароля пользователя
            cueTextBox_edit_new_pass.Text = "";
            cueTextBox_edit_new_pass_2.Text = "";
        }
        private void button_users_edit_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Редактирование пользователя
            string str = Librarian.uEdit(id, library_card, textBox_edit_library_card.Text, textBox_edit_login.Text, textBox_edit_email.Text, textBox_edit_phone.Text, textBox_edit_fio.Text, group);
            if (str == "Изменения сохранены!")
            {
                library_card = textBox_edit_library_card.Text;
                login = textBox_edit_login.Text;
                fio = textBox_edit_fio.Text;
                email = textBox_edit_email.Text;
                phone = textBox_edit_phone.Text;
            }
            MessageBox.Show(str);
        }
        private void button_users_delete_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Удаление пользователя
            string str = Librarian.uDelete(id, library_card, group);
            if (str == "Пользователь удален!")
            {
                this.Close(); // Закрываем текущую форму
            }
            MessageBox.Show(str);
        }

        // Редактирование долгов пользователя
        private void update_debts() // Обновление списка долгов
        {
            if (library_card == "")
            {
                dgv_users_debts.DataSource = null;
                label_error_library_card.Visible = true;
                button_debts_delete.Enabled = false;
                button_debts_add.Enabled = false;
            }
            else
            {
                dgv_users_debts.DataSource = Librarian.uDebts(library_card);
                label_error_library_card.Visible = false;
                button_debts_delete.Enabled = true;
                button_debts_add.Enabled = true;
            }

            if (dgv_users_debts.Rows.Count == 0) button_debts_delete.Enabled = false;
            else button_debts_delete.Enabled = true;
        }
        private void button_debts_delete_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Удаление долга пользователя
            MessageBox.Show(Librarian.dDelete(dgv_users_debts.CurrentRow.Cells[6].Value.ToString()));
            update_debts(); // Вывод долгов пользователя
        }
        private void button_debts_add_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Форма добавления книги пользователю
            Form FG = new Form_user_debts_add(library_card);
            FG.ShowDialog();
            update_debts(); // Вывод долгов пользователя
        }
    }
}
