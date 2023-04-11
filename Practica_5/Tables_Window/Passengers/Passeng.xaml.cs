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

namespace Practica_5.Tables_Window.Passengers
{
    public partial class Passeng : Page
    {
        PassengerTableAdapter passe = new PassengerTableAdapter();
        public Passeng()
        {
            InitializeComponent();
            Passeng_Grid.ItemsSource = passe.GetData();
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Passeng_Grid.SelectedItem == null)
            {
                MessageBox.Show(@" Вы не выбрали элемент!");
                return;
            }
            try
            {
                object id = (Passeng_Grid.SelectedItem as DataRowView).Row[0];
                passe.DeleteQuery(Convert.ToInt32(id));
                Passeng_Grid.ItemsSource = passe.GetData();
            }
            catch
            {
                MessageBox.Show(@" Вы выбрали элемент без штуки");
            }
        }

        private void Passeng_Grid_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
            passe.Update(Passeng_Grid.ItemsSource as AirLinersDataSet.PassengerDataTable);

            }
            catch
            {
                MessageBox.Show(@" Вы изменили что, что нельзя было изменять...");
            }
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            Add.Content = new Add_Pass();
        }
    }
}
