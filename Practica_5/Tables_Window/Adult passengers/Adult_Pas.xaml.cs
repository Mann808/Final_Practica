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

namespace Practica_5.Tables_Window.Adult_passengers
{
    public partial class Adult_Pas : Page
    {
        adult_passengersTableAdapter adult_pas = new adult_passengersTableAdapter();
        public Adult_Pas()
        {
            InitializeComponent();
            Ad_Pas_Grid.ItemsSource = adult_pas.GetData();
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Ad_Pas_Grid.SelectedItem == null)
            {
                MessageBox.Show(@" Вы не выбрали элемент!");
                return;
            }
        }

        private void Grid_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                adult_pas.Update(Ad_Pas_Grid.ItemsSource as AirLinersDataSet.adult_passengersDataTable);
            }
            catch
            {
                MessageBox.Show(@" Вы изменили что, что нельзя было изменять...");
            }
            Ad_Pas_Grid.ItemsSource = adult_pas.GetData();

        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            Add.Content = new Add_ad_pas();
        }
    }
}
