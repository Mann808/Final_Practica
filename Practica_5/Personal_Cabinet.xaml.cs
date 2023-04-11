using Practica_5.Tables_Window.Adult_passengers;
using Practica_5.Tables_Window.Airliens;
using Practica_5.Tables_Window.Airlines_data;
using Practica_5.Tables_Window.Books;
using Practica_5.Tables_Window.Flight;
using Practica_5.Tables_Window.Minor_passengers;
using Practica_5.Tables_Window.Passengers;
using Practica_5.Tables_Window.Price;
using Practica_5.Tables_Window.Routing;
using Practica_5.Tables_Window.Tickets;
using Practica_5.Tables_Window.Users;
using System;
using System.Collections.Generic;
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

namespace Practica_5
{
    public partial class Personal_Cabinet : Window
    {
        public Personal_Cabinet()
        {
            InitializeComponent();
            if (Admin_Check.Imp_Chk)
            {
                Spisok_Tables.Items.Add("Пассажиры");
                Spisok_Tables.Items.Add("Несоверш. пассажиры");
                Spisok_Tables.Items.Add("Соверш. пассажиры");
                Spisok_Tables.Items.Add("Данные авиакомпаний");
                Spisok_Tables.Items.Add("Авиакомпании");
                Spisok_Tables.Items.Add("Маршруты");
                Spisok_Tables.Items.Add("Рейсы");
                Spisok_Tables.Items.Add("Цены");
                Spisok_Tables.Items.Add("Бронированные");
                Spisok_Tables.Items.Add("Билеты");
                Regis.IsEnabled = false;
            }
            else
            {
                Spisok_Tables.Items.Add("Пользователи");
                Spisok_Tables.Items.Add("Пассажиры");
                Spisok_Tables.Items.Add("Несоверш. пассажиры");
                Spisok_Tables.Items.Add("Соверш. пассажиры");
                Spisok_Tables.Items.Add("Данные авиакомпаний");
                Spisok_Tables.Items.Add("Авиакомпании");
                Spisok_Tables.Items.Add("Маршруты");
                Spisok_Tables.Items.Add("Рейсы");
                Spisok_Tables.Items.Add("Цены");
                Spisok_Tables.Items.Add("Бронированные");
                Spisok_Tables.Items.Add("Билеты");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
            Application.Current.MainWindow.Show();
        }

        private void Spisok_Tables_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((string)(Spisok_Tables.SelectedValue) == "Пользователи")
            {
                Page_Frame.Content = new Users_table();
            }
            else if ((string)(Spisok_Tables.SelectedValue) == "Пассажиры")
            {
                    Page_Frame.Content = new Passeng();
            }
            else if ((string)(Spisok_Tables.SelectedValue) == "Несоверш. пассажиры")
            {
                Page_Frame.Content = new Minor_Pas();
            }
            else if ((string)(Spisok_Tables.SelectedValue) == "Соверш. пассажиры")
            {
                Page_Frame.Content = new Adult_Pas();
            }
            else if ((string)(Spisok_Tables.SelectedValue) == "Данные авиакомпаний")
            {
                Page_Frame.Content = new Airl_Data();
            }
            else if ((string)(Spisok_Tables.SelectedValue) == "Авиакомпании")
            {
                Page_Frame.Content = new Airlines();
            }
            else if ((string)(Spisok_Tables.SelectedValue) == "Маршруты")
            {
                Page_Frame.Content = new Flights();
            }
            else if ((string)(Spisok_Tables.SelectedValue) == "Рейсы")
            {
                Page_Frame.Content = new Routing();
            }
            else if ((string)(Spisok_Tables.SelectedValue) == "Цены")
            {
                Page_Frame.Content = new Price();
            }
            else if ((string)(Spisok_Tables.SelectedValue) == "Бронированные")
            {
                Page_Frame.Content = new Books();
            }
            else if ((string)(Spisok_Tables.SelectedValue) == "Билеты")
            {
                Page_Frame.Content = new Tickets();
            }
        }
    }
}
