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
using Practica_5.Tables_Window.Passengers;

namespace Practica_5.Tables_Window.Users
{
    public partial class Users_table : Page
    {
        UsersTableAdapter user = new UsersTableAdapter();
        public Users_table()
        {
            InitializeComponent();
            User_Grid.ItemsSource = user.GetData();
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            if (User_Grid.SelectedItem == null)
            {
                MessageBox.Show(@" Вы не выбрали элемент!");
                return;
            }
            try
            {
                object id = (User_Grid.SelectedItem as DataRowView).Row[0];
                user.DeleteQuery(Convert.ToInt32(id));
                User_Grid.ItemsSource = user.GetData();
            }
            catch
            {
                MessageBox.Show(@" Вы выбрали элемент без штуки");
            }
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
            Application.Current.MainWindow.Show();
        }
    }
}
