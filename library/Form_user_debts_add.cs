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
    public partial class Form_user_debts_add : Form
    {
        string library_card;

        public Form_user_debts_add(string library_card)
        {
            this.library_card = library_card;
            InitializeComponent();
            _focus.Focus();
        }

        private void button_debts_add_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Добавление книги
            string str = Librarian.dAdd(cueTextBox_code_instance.Text, library_card, dateTP_issue_up_to.Value.Date.ToString("yyyy-MM-dd"));
            if (str == "Книга успешно добавлена!")
            {
                this.Close(); // Закрываем текущую форму
            }
            MessageBox.Show(str);
        }

        private void Form_user_debts_add_Load(object sender, EventArgs e)
        {
            Working.request(1, 1);
            dateTP_issue_up_to.MinDate = Working.time;
        }
    }
}
