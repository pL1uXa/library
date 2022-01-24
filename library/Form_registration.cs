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
    public partial class Form_registration : Form
    {
        string text_capcha;

        public Form_registration()
        {
            InitializeComponent();
        }
        private void Form_registration_Load(object sender, EventArgs e)
        {
            capcha_update(); // Рисуем капчу
        }

        private void button_usr_registration_Click(object sender, EventArgs e)
        {
            if (textBox_capcha.Text.ToUpper() == this.text_capcha)
            {
                _focus.Focus();
                // Регистрация пользователя
                string fio = cueTextBox_usr_middle_name.Text + " " + cueTextBox_usr_name.Text + " " + cueTextBox_usr_surname.Text;
                string str = User.registration(cueTextBox_usr_login.Text, cueTextBox_usr_password.Text, cueTextBox_usr_password_again.Text, fio, cueTextBox_usr_email.Text, cueTextBox_usr_phone.Text);
                if (str == "Вы успешно зарегистрировались!")
                {
                    this.Close(); // Закрываем текущую форму
                }
                else capcha_update(); // Рисуем капчу
                MessageBox.Show(str);
            }
            else
            {
                MessageBox.Show("Неверно введена капча!");
                capcha_update(); // Рисуем капчу
            }  
        }

        private Bitmap Capcha(int Width, int Height) // Каптча
        {
            Random rnd = new Random();
            Bitmap result = new Bitmap(Width, Height);

            // Позиция текста
            int Xpos = 10;
            int Ypos = 10;
            // Разный цвет текста
            Brush[] colors = { Brushes.Black, Brushes.Red, Brushes.RoyalBlue, Brushes.Green, Brushes.Yellow, Brushes.White, Brushes.Tomato, Brushes.Sienna, Brushes.Pink };
            // Разный цвет линий
            Pen[] colorpens = { Pens.Black, Pens.Red, Pens.RoyalBlue, Pens.Green, Pens.Yellow, Pens.White, Pens.Tomato, Pens.Sienna, Pens.Pink };
            // Случайный стиль текста
            FontStyle[] fontstyle = { FontStyle.Bold, FontStyle.Italic, FontStyle.Regular, FontStyle.Strikeout, FontStyle.Underline};
            // Углы поворота текста
            Int16[] rotate = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6 };
            // Рисуем
            Graphics g = Graphics.FromImage((Image)result);
            g.Clear(Color.Gray); // Серый фон
            // Случайный угл поворота текста
            g.RotateTransform(rnd.Next(rotate.Length));
            // Генерация текста
            text_capcha = String.Empty;
            string ALF = "АБВГДЕЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789";
            for (int i = 0; i < 5; ++i) text_capcha += ALF[rnd.Next(ALF.Length)];
            // Выводим на изображение
            g.DrawString(text_capcha, new Font("Arial", 25, fontstyle[rnd.Next(fontstyle.Length)]), colors[rnd.Next(colors.Length)], new PointF(Xpos, Ypos));
            // Помехи
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)], new Point(0, 0), new Point(Width - 1, Height - 1));
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)], new Point(0, Height - 1), new Point(Width - 1, 0));
            //Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0) result.SetPixel(i, j, Color.White);

            return result;
        }
        private void capcha_update()
        {
            pictureBox_capcha.Image = Capcha(pictureBox_capcha.Width, pictureBox_capcha.Height); // Рисуем капчу
            textBox_capcha.Text = "";
        }
        private void button_capcha_update_Click(object sender, EventArgs e)
        {
            capcha_update(); // Рисуем капчу
        }
    }
}
