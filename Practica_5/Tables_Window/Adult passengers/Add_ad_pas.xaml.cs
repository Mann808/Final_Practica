using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
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
using Practica_5.Tables_Window.Airliens;

namespace Practica_5.Tables_Window.Adult_passengers
{
    public partial class Add_ad_pas : Page
    {
        adult_passengersTableAdapter adult_Passenger = new adult_passengersTableAdapter();
        PassengerTableAdapter passenger = new PassengerTableAdapter();
        public Add_ad_pas()
        {
            InitializeComponent();
            choose_pas.ItemsSource = passenger.GetData();
            choose_pas.DisplayMemberPath = "id_Passengers";
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void Adding_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(num_pas.Text))
            {
                MessageBox.Show(@" Вы не заполнили номер паспорта!");
                return;
            }
            else if (String.IsNullOrEmpty(choose_pas.Text))
            {
                MessageBox.Show(@" Вы не выбрали пассажира!");
                return;
            }
            else if (String.IsNullOrEmpty(point_issue.Text))
            {
                MessageBox.Show(@" Вы не заполнили город отправления!");
                return;
            }
            else
            {
                try
                {
                    adult_Passenger.InsertQuery((int)(choose_pas.SelectedValue as DataRowView).Row[0], (Convert.ToString(num_pas.Text)), (Convert.ToString(point_issue.Text)));
                    num_pas.Text = null;
                    choose_pas.Text = null;
                    point_issue.Text = null;
                    ((Application.Current.MainWindow as Personal_Cabinet).Page_Frame.Content as Adult_Pas).Ad_Pas_Grid.ItemsSource = adult_Passenger.GetData();
                }
                catch 
                {
                    MessageBox.Show(@" Вы не заполнили или ввели неправильно некоторые значения!");
                    return;
                }
            }
        }
    }
}
