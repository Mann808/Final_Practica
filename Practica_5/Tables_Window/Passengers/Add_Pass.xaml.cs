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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Practica_5.AirLinersDataSetTableAdapters;
using Practica_5.Tables_Window.Minor_passengers;

namespace Practica_5.Tables_Window.Passengers
{
    public partial class Add_Pass : Page
    {
        PassengerTableAdapter passenger = new PassengerTableAdapter();
        UsersTableAdapter users = new UsersTableAdapter();
        public Add_Pass()
        {
            InitializeComponent();
            choose_user.ItemsSource = users.GetData();
            choose_user.DisplayMemberPath = "id_user";
        }

        private void Adding_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(add4.Text))
            {
                MessageBox.Show(@" Вы не заполнили эмаил!");
                return;
            }
            else if (String.IsNullOrEmpty(choose_user.Text))
            {
                MessageBox.Show(@" Вы не выбрали пользователя!");
                return;
            }
            else if (String.IsNullOrEmpty(add.Text))
            {
                MessageBox.Show(@" Вы не заполнили фамилию!");
                return;
            }
            else if (String.IsNullOrEmpty(add1.Text))
            {
                MessageBox.Show(@" Вы не заполнили имя!");
                return;
            }
            else if (String.IsNullOrEmpty(add2.Text))
            {
                MessageBox.Show(@" Вы не заполнили отчество!");
                return;
            }
            else if (String.IsNullOrEmpty(add3.Text))
            {
                MessageBox.Show(@" Вы не заполнили телефон!");
                return;
            }
            else
            {
                try
                {
                    passenger.InsertQuery((Convert.ToString(add.Text)), (Convert.ToString(add1.Text)), (Convert.ToString(add2.Text)), (Convert.ToInt32(add3.Text)), (Convert.ToString(add4.Text)), (int)(choose_user.SelectedValue as DataRowView).Row[0]);
                    add.Text = null;
                    add1.Text = null;
                    add2.Text = null;
                    add3.Text = null;
                    add4.Text = null;
                    ((Application.Current.MainWindow as Personal_Cabinet).Page_Frame.Content as Passeng).Passeng_Grid.ItemsSource = passenger.GetData();
                }
                catch
                {
                    MessageBox.Show(@" Вы не заполнили или ввели неправильно некоторые значения!");
                    return;
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
