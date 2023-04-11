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

namespace Practica_5.Tables_Window.Airlines_data
{
    public partial class Airl_Data : Page
    {
        Airline_dataTableAdapter air_data = new Airline_dataTableAdapter();
        public Airl_Data()
        {
            InitializeComponent();
            Air_Data_Grid.ItemsSource = air_data.GetData();
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Air_Data_Grid.SelectedItem == null)
            {
                MessageBox.Show(@" Вы не выбрали элемент!");
                return;
            }
            try
            {
                object id = (Air_Data_Grid.SelectedItem as DataRowView).Row[0];
                air_data.DeleteQuery(Convert.ToInt32(id));
                Air_Data_Grid.ItemsSource = air_data.GetData();
            }
            catch
            {
                MessageBox.Show(@" Вы выбрали элемент без штуки");
            }
        }

        private void Air_Data_Grid_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
            air_data.Update(Air_Data_Grid.ItemsSource as AirLinersDataSet.Airline_dataDataTable);

            }
            catch
            {
                MessageBox.Show(@" Вы изменили что, что нельзя было изменять...");
            }
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            Add.Content = new Add_airl_data();
        }
    }
}
