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
using Practica_5.Tables_Window.Passengers;

namespace Practica_5.Tables_Window.Flight
{
    public partial class Flights : Page
    {
        FlightTableAdapter flight = new FlightTableAdapter();
        public Flights()
        {
            InitializeComponent();
            Flight_Grid.ItemsSource = flight.GetData();
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Flight_Grid.SelectedItem == null)
            {
                MessageBox.Show(@" Вы не выбрали элемент!");
                return;
            }
            try
            {
                object id = (Flight_Grid.SelectedItem as DataRowView).Row[0];
                flight.DeleteQuery(Convert.ToInt32(id));
                Flight_Grid.ItemsSource = flight.GetData();
            }
            catch
            {
                MessageBox.Show(@" Вы выбрали элемент без штуки");
            }
        }

        private void Flight_Grid_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
            flight.Update(Flight_Grid.ItemsSource as AirLinersDataSet.FlightDataTable);

            }
            catch
            {
                MessageBox.Show(@" Вы изменили что, что нельзя было изменять...");
            }
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            Add.Content = new Add_Flight();
        }
    }
}
