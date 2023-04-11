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
using Practica_5.Tables_Window.Adult_passengers;

namespace Practica_5.Tables_Window.Minor_passengers
{
    public partial class Add_min_pas : Page
    {
        PassengerTableAdapter passenger = new PassengerTableAdapter();
        minor_passengersTableAdapter min_pas = new minor_passengersTableAdapter();
        public Add_min_pas()
        {
            InitializeComponent();
            choose_pas.ItemsSource = passenger.GetData();
            choose_pas.DisplayMemberPath = "id_Passengers";
        }

        private void Adding_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(add.Text))
            {
                MessageBox.Show(@" Вы не заполнили свидетельство о рождении!");
                return;
            }
            else if (String.IsNullOrEmpty(choose_pas.Text))
            {
                MessageBox.Show(@" Вы не выбрали пассажира!");
                return;
            }
            else if (String.IsNullOrEmpty(add1.Text))
            {
                MessageBox.Show(@" Вы не заполнили фамилию!");
                return;
            }
            else if (String.IsNullOrEmpty(add2.Text))
            {
                MessageBox.Show(@" Вы не заполнили имя!");
                return;
            }
            else if (String.IsNullOrEmpty(add3.Text))
            {
                MessageBox.Show(@" Вы не заполнили отчество!");
                return;
            }
            else if (String.IsNullOrEmpty(add4.Text))
            {
                MessageBox.Show(@" Вы не заполнили возраст!");
                return;
            }
            if (Convert.ToInt32(add4.Text) >= 18)
            {
                MessageBox.Show(@" Gfitk yf[eq!!!!!!");
                return;
            }
            else
            {
                try
                {
                    min_pas.InsertQuery((int)(choose_pas.SelectedValue as DataRowView).Row[0], (Convert.ToInt32(add.Text)), (Convert.ToString(add1.Text)), (Convert.ToString(add2.Text)), (Convert.ToString(add3.Text)), (Convert.ToInt32(add4.Text)));
                    add.Text = null;
                    add1.Text = null;
                    add2.Text = null;
                    add3.Text = null;
                    add4.Text = null;
                    ((Application.Current.MainWindow as Personal_Cabinet).Page_Frame.Content as Minor_Pas).Min_Pas_Grid.ItemsSource = min_pas.GetData();
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
