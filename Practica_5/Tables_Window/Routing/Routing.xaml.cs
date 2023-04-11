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

namespace Practica_5.Tables_Window.Routing
{
    public partial class Routing : Page
    {
        RoutingTableAdapter rout = new RoutingTableAdapter();
        public Routing()
        {
            InitializeComponent();
            Routing_Grid.ItemsSource = rout.GetData();
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Routing_Grid.SelectedItem == null)
            {
                MessageBox.Show(@" Вы не выбрали элемент!");
                return;
            }
            try
            {
                object id = (Routing_Grid.SelectedItem as DataRowView).Row[0];
                rout.DeleteQuery(Convert.ToInt32(id));
                Routing_Grid.ItemsSource = rout.GetData();
            }
            catch
            {
                MessageBox.Show(@" Вы выбрали элемент без штуки");
            }
        }

        private void Routing_Grid_CurrentCellChanged(object sender, EventArgs e)
        {
            rout.Update(Routing_Grid.ItemsSource as AirLinersDataSet.RoutingDataTable);
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            Add.Content = new Add_routing();
        }
    }
}
