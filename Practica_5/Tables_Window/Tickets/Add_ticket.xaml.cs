using Practica_5.AirLinersDataSetTableAdapters;
using Practica_5.Tables_Window.Airlines_data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica_5.Tables_Window.Tickets
{
    public partial class Add_ticket : Page
    {
        FlightTableAdapter flight = new FlightTableAdapter();
        PassengerTableAdapter passenger = new PassengerTableAdapter();
        PriceTableAdapter price = new PriceTableAdapter();
        BookTableAdapter book = new BookTableAdapter();
        ticketTableAdapter ticket = new ticketTableAdapter();
        public Add_ticket()
        {
            InitializeComponent();
            add1.ItemsSource = flight.GetData();
            add1.DisplayMemberPath = "id_flights";
            add2.ItemsSource = passenger.GetData();
            add2.DisplayMemberPath = "id_Passengers";
            add3.ItemsSource = price.GetData();
            add3.DisplayMemberPath = "id_prices";
            add5.ItemsSource = book.GetData();
            add5.DisplayMemberPath = "id_booking";
        }

        private void Adding_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(add.Text))
            {
                MessageBox.Show(@" Вы не заполнили самолёт!");
                return;
            }
            else if (String.IsNullOrEmpty(add1.Text))
            {
                MessageBox.Show(@" Вы не выбрали рейс!");
                return;
            }
            else if (String.IsNullOrEmpty(add2.Text))
            {
                MessageBox.Show(@" Вы не выбрали пассажира!");
                return;
            }
            else if (String.IsNullOrEmpty(add3.Text))
            {
                MessageBox.Show(@" Вы не выбрали цену!");
                return;
            }
            else if (String.IsNullOrEmpty(add4.Text))
            {
                MessageBox.Show(@" Вы не заполнили место в самолте!");
                return;
            }
            else if (String.IsNullOrEmpty(add5.Text))
            {
                MessageBox.Show(@" Вы не выбрали бронирование!");
                return;
            }
            else
            {
                try
                {
                    ticket.InsertQuery((Convert.ToString(add.Text)), (Convert.ToInt32(add1.Text)), (Convert.ToInt32(add2.Text)), (Convert.ToInt32(add3.Text)), (Convert.ToInt32(add4.Text)), (Convert.ToInt32(add5.Text)));
                    add.Text = null;
                    add1.Text = null;
                    add2.Text = null;
                    add3.Text = null;
                    add4.Text = null;
                    add5.Text = null;
                    ((Application.Current.MainWindow as Personal_Cabinet).Page_Frame.Content as Tickets).Ticket_Grid.ItemsSource = ticket.GetData();
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
