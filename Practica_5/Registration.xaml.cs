using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Practica_5.AirLinersDataSetTableAdapters;

namespace Practica_5
{
    public partial class Registration : Window
    {
        UsersTableAdapter User = new UsersTableAdapter();
        public Registration()
        {
            InitializeComponent();
            Role_id.Items.Add("Админ");
            Role_id.Items.Add("Покупаетль");
            Role_id.Items.Add("Импорт");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string role;
            var name_check = User.GetData();
            if ((string)(Role_id.SelectedValue) == "Админ")
            {
                role = "admin";
            }
            else if((string)(Role_id.SelectedValue) == "Покупаетль")
            {
                role = "buyer";
            }
            else
            {
                role = "import";
            }
            if ((String.IsNullOrEmpty(Name_text.Text)) || (String.IsNullOrEmpty(Password_text.Password)) || Role_id.SelectedValue == null || (String.IsNullOrEmpty(Role_email.Text)))
            {
                MessageBox.Show(@" Вы не заполнили некоторые строки!");
                return;
            }
            for (int i = 0; i < name_check.Count; i++)
            {
                if (name_check[i][2].ToString() == Name_text.Text)
                {
                    MessageBox.Show(@" Имя такого пользователя уже есть!");
                    return;
                }
            }
            string[] dataLogin = Role_email.Text.Split('@');
            if (dataLogin.Length == 2)
            {
                string[] data2Login = dataLogin[1].Split('.');
                if (data2Login.Length == 2)
                {
                    if (Password_text.Password.Length >= 6)
                    {
                        bool en = true;
                        bool symbol = false;
                        bool number = false;

                        for (int i = 0; i < Password_text.Password.Length; i++)
                        {
                            if (Password_text.Password[i] >= 'А' && Password_text.Password[i] <= 'Я') en = false;
                            if (Password_text.Password[i] >= '0' && Password_text.Password[i] <= '9') number = true;
                            if (Password_text.Password[i] == '_' || Password_text.Password[i] == '-' || Password_text.Password[i] == '!') symbol = true;
                        }

                        if (!en)
                            MessageBox.Show("В пароле доступна только английская раскладка");
                        else if (!symbol)
                            MessageBox.Show("В пароле добавьте один из следующих символов: _ - !");
                        else if (!number)
                            MessageBox.Show("В пароле добавьте хотя бы одну цифру");
                        if (en && symbol && number)
                        {
                            User.InsertQuery(role, Name_text.Text, Password_text.Password, Role_email.Text);
                            MessageBox.Show(@" Вы зарегистрировали пользователя!");
                            Name_text.Clear();
                            Password_text.Clear();
                            Role_email.Clear();
                            Role_id.SelectedItem = 0;
                        }
                    }
                    else MessageBox.Show("Пароль слишком короткий, минимум 6 символов");
                }
                else MessageBox.Show("Укажите почту в форме х@x.x");
            }
            else MessageBox.Show("Укажите почту в форме х@x.x");
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
