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

namespace Practica_5.Tables_Window.Flight
{
    public partial class Add_Flight : Page
    {
        RoutingTableAdapter rout = new RoutingTableAdapter();
        FlightTableAdapter flight = new FlightTableAdapter();
        public Add_Flight()
        {
            InitializeComponent();
            add4.ItemsSource = rout.GetData();
            add4.DisplayMemberPath = "id_routings";
        }

        private void Adding_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(add1.Text))
            {
                MessageBox.Show(@" Вы не заполнили время отбытия!");
                return;
            }
            else if (String.IsNullOrEmpty(add2.Text))
            {
                MessageBox.Show(@" Вы не заполнили время прибытия!");
                return;
            }
            else if (String.IsNullOrEmpty(add3.Text))
            {
                MessageBox.Show(@" Вы не заполнили статус!");
                return;
            }
            else if (String.IsNullOrEmpty(add4.Text))
            {
                MessageBox.Show(@" Вы не выбрали пассажира!");
                return;
            }
            else
            {
                try
                {
                    flight.InsertQuery((Convert.ToDateTime(add1.Text)), (Convert.ToDateTime(add2.Text)), (Convert.ToString(add3.Text)), (int)(add4.SelectedValue as DataRowView).Row[0]);
                    add1.Text = null;
                    add2.Text = null;
                    add3.Text = null;
                    add4.Text = null;
                    ((Application.Current.MainWindow as Personal_Cabinet).Page_Frame.Content as Flights).Flight_Grid.ItemsSource = flight.GetData();
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
