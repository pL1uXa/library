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
    public partial class Form_book_instances_add : Form
    {
        string code_book;

        public Form_book_instances_add(string code_book)
        {
            this.code_book = code_book;
            InitializeComponent();
            _focus.Focus();
        }

        private void button_instances_add_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Добавление книги
            string str = Librarian.iAdd(cueTextBox_state_instances.Text, cueTextBox_isbn_issn.Text, code_book);
            if (str == "Книга успешно добавлена!")
            {
                this.Close(); // Закрываем текущую форму
            }
            MessageBox.Show(str);
        }
    }
}
