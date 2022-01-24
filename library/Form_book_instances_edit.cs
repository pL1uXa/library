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
    public partial class Form_book_instances_edit : Form
    {
        string code_instances;
        string isbn_issn;
        string state_instances;

        public Form_book_instances_edit(string code_instances, string isbn_issn, string state_instances)
        {
            InitializeComponent();
            _focus.Focus();

            this.code_instances = code_instances;
            textBox_edit_isbn_issn.Text = this.isbn_issn = isbn_issn;
            textBox_edit_state_instances.Text = this.state_instances = state_instances;
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Редактирование экземпляра
            string str = Librarian.iEdit(code_instances, textBox_edit_isbn_issn.Text, textBox_edit_state_instances.Text);
            if (str == "Изменения сохранены!")
            {
                isbn_issn = textBox_edit_isbn_issn.Text;
                state_instances = textBox_edit_state_instances.Text;
            }
            MessageBox.Show(str);
        }
    }
}
