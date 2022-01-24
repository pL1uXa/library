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
    public partial class Form_group_3 : Form
    {
        // Общие параметры
        Form_main main;

        public Form_group_3(Form_main main)
        {
            this.main = main;
            InitializeComponent();
        }
        private void Form_group_3_Load(object sender, EventArgs e)
        {
            panel_news.BringToFront(); // Выбириаем первый элемент импровизированного tabControl
            paint_button(button_news); // Закрашиваем первый элемент импровизированного tabControl
            news_update(); // Обновление новостей
            users_update(); // Обновление сотрудников
        }
        private void Form_group_3_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.news_update(); // Обновление новостей
            main.Show();
        }
        private void paint_button(Button btn)
        {
            _focus.Focus();

            button_news.BackColor = SystemColors.ScrollBar;
            button_users.BackColor = SystemColors.ScrollBar;

            btn.BackColor = SystemColors.ActiveCaption;
        }

        private void button_news_Click(object sender, EventArgs e)
        {
            paint_button(button_news);
            panel_news.BringToFront();
            news_update(); // Обновление новостей
        }
        private void button_users_Click(object sender, EventArgs e)
        {
            paint_button(button_users);
            panel_users.BringToFront();
            users_update(); // Обновление сотрудников
        }

        // Актуальные новости
        private void button_news_save_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            Working.request(31, 0, richTextBox_news.Text);
            MessageBox.Show("Новость обновлена!");
        }
        private void news_update() // Обновление новостей
        {
            richTextBox_news.Text = Director.nUpdate();
        }

        // Сотрудники
        private void dgv_users_search_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(Director.uDemotion(dgv_users_search.CurrentRow.Cells[0].Value.ToString()));
            users_update(); // Обновление сотрудников
        }
        private void button_raise_to_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Повышение сотрудника в должности
            string str = Director.uPromotion(cueTextBox_users.Text);
            if (str == "Права успешно выданы!")
            {
                users_update(); // Обновление сотрудников
            }
            MessageBox.Show(str);
            cueTextBox_users.Text = "";
        }
        private void users_update() // Обновление сотрудников
        {
            dgv_users_search.DataSource = Director.uUpdate();
        }
    }
}
