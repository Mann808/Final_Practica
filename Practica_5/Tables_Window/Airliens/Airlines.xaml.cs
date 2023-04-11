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

namespace Practica_5.Tables_Window.Airliens
{
    public partial class Airlines : Page
    {
        AirlineTableAdapter airline = new AirlineTableAdapter();
        public Airlines()
        {
            InitializeComponent();
            Airline_Grid.ItemsSource = airline.GetData();
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Airline_Grid.SelectedItem == null)
            {
                MessageBox.Show(@" Вы не выбрали элемент!");
                return;
            }
            try
            {
                object id = (Airline_Grid.SelectedItem as DataRowView).Row[0];
                airline.DeleteQuery(Convert.ToInt32(id));
                Airline_Grid.ItemsSource = airline.GetData();
            }
            catch
            {
                MessageBox.Show(@" Вы выбрали элемент без штуки");
            }
        }

        private void Grid_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
            airline.Update(Airline_Grid.ItemsSource as AirLinersDataSet.AirlineDataTable);

            }
            catch
            {
                MessageBox.Show(@" Вы изменили что, что нельзя было изменять...");
            }
        }
        private void Add_Button_Click_1(object sender, RoutedEventArgs e)
        {
            Add.Content = new Add_airline();
        }
    }
}
