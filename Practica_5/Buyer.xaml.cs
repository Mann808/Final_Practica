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
using System.Windows.Shapes;
using Practica_5.AirLinersDataSetTableAdapters;
using Practica_5.Model;
using Practica_5.Tables_Window.Airlines_data;
using Practica_5.Tables_Window.Books;

namespace Practica_5
{ 
    public partial class Buyer : Window
    {
        oplatiTableAdapter oplat = new oplatiTableAdapter();
        checkingTableAdapter check = new checkingTableAdapter();
        List<Cassa> cassa = new List<Cassa>();
        int sum = 0;
        public Buyer()
        {
            InitializeComponent();
            Buying_grid.ItemsSource = oplat.GetData();
            Check_grid.ItemsSource = cassa;
            cassa.Clear();
        }

        private void Del_list_Click(object sender, RoutedEventArgs e)
        {
            if (Check_grid.SelectedItems != null)
            {
                cassa.Remove((Cassa)Check_grid.SelectedItem);
            }
        }
        
        private void Add_list_Click_1(object sender, RoutedEventArgs e)
        {
            Check_grid.ItemsSource = null;
            if (Buying_grid.SelectedItem != null)
            {
                try
                {
                    Cassa cas = new Cassa();
                    cas.id = (int)(Buying_grid.SelectedItem as DataRowView).Row[0];
                    cas.arrival = (Buying_grid.SelectedItem as DataRowView).Row[1].ToString();
                    cas.cost = (int)(Buying_grid.SelectedItem as DataRowView).Row[2];
                    sum += cas.cost;
                    cassa.Add(cas);
                    Check_grid.ItemsSource = cassa;
                    Check.Text = String.Format("К оплате: {0}", sum);
                }
                catch
                {
                    MessageBox.Show(@" Вы не выбрали строку!");
                }
            }
        }

        private void create_check_Click(object sender, RoutedEventArgs e)
        {
            foreach (var items in cassa)
            {
                check.InsertQuery(items.id, items.arrival, items.cost);
            }
            cassa.Clear();
            sum = 0;
        }

        private void Login_in_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }
    }
}