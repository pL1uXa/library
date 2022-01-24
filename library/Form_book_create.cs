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
    public partial class Form_book_create : Form
    {
        public Form_book_create()
        {
            InitializeComponent();
            _focus.Focus();
        }

        private void button_books_create_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Создание книги
            string str = Librarian.bCreate(cueTextBox_create_title.Text, cueTextBox_create_author.Text, cueTextBox_create_authors_other.Text, cueTextBox_create_year_of_publ.Text);
            if (str == "Книга создана!")
            {
                this.Close(); // Закрываем текущую форму
            }
            MessageBox.Show(str);
        }
    }
}
