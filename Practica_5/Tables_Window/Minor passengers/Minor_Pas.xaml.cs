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

namespace Practica_5.Tables_Window.Minor_passengers
{
    public partial class Minor_Pas : Page
    {
        minor_passengersTableAdapter min_pas = new minor_passengersTableAdapter();
        public Minor_Pas()
        {
            InitializeComponent();
            Min_Pas_Grid.ItemsSource = min_pas.GetData();
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Min_Pas_Grid.SelectedItem == null)
            {
                MessageBox.Show(@" Вы не выбрали элемент!");
                return;
            }
            MessageBox.Show(@" Удаление пользователя происходит в таблице 'Пассажиры'");
        }

        private void Min_Pas_Grid_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
            min_pas.Update(Min_Pas_Grid.ItemsSource as AirLinersDataSet.minor_passengersDataTable);

            }
            catch
            {
                MessageBox.Show(@" Вы изменили что, что нельзя было изменять...");
            }
            Min_Pas_Grid.ItemsSource = min_pas.GetData();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            Add.Content = new Add_min_pas();
        }
    }
}
