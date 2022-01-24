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
    public partial class Form_user_create : Form
    {
        public Form_user_create()
        {
            InitializeComponent();
            _focus.Focus();
        }

        private void button_users_create_Click(object sender, EventArgs e)
        {
            _focus.Focus();
            // Создание пользователя
            string str = Librarian.uCreate(cueTextBox_create_login.Text, cueTextBox_create_new_pass.Text, cueTextBox_create_new_pass_2.Text, cueTextBox_create_fio.Text, cueTextBox_create_email.Text, cueTextBox_create_phone.Text, cueTextBox_create_library_card.Text);
            if (str == "Пользователь создан!")
            {
                this.Close(); // Закрываем текущую форму
            }
            MessageBox.Show(str);
        }
    }
}
