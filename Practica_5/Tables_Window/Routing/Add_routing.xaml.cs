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
using Practica_5.Tables_Window.Flight;

namespace Practica_5.Tables_Window.Routing
{
    public partial class Add_routing : Page
    {
        RoutingTableAdapter rout = new RoutingTableAdapter();
        AirlineTableAdapter air = new AirlineTableAdapter();
        public Add_routing()
        {
            InitializeComponent();
            add5.ItemsSource = air.GetData();
            add5.DisplayMemberPath = "id_airlines";
        }

        private void Adding_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(add.Text))
            {
                MessageBox.Show(@" Вы не пункт отправления!");
                return;
            }
            else if (String.IsNullOrEmpty(add1.Text))
            {
                MessageBox.Show(@" Вы не заполнили аэропорт отбытия!");
                return;
            }
            else if (String.IsNullOrEmpty(add2.Text))
            {
                MessageBox.Show(@" Вы не заполнили пункт прибытия!");
                return;
            }
            else if (String.IsNullOrEmpty(add3.Text))
            {
                MessageBox.Show(@" Вы не заполнили аэропорт прибытия!");
                return;
            }
            else if (String.IsNullOrEmpty(add4.Text))
            {
                MessageBox.Show(@" Вы не заполнили длительность полёта!");
                return;
            }
            else if (String.IsNullOrEmpty(add5.Text))
            {
                MessageBox.Show(@" Вы не выбрали авиакомпанию!");
                return;
            }
            else
            {
                try
                {
                    rout.InsertQuery(add.Text, (Convert.ToString(add1.Text)), (Convert.ToString(add2.Text)), (Convert.ToString(add3.Text)), (Convert.ToInt32(add4.Text)), (int)(add5.SelectedValue as DataRowView).Row[0]);
                    add.Text = null;
                    add1.Text = null;
                    add2.Text = null;
                    add3.Text = null;
                    add4.Text = null;
                    add5.Text = null;
                    ((Application.Current.MainWindow as Personal_Cabinet).Page_Frame.Content as Routing).Routing_Grid.ItemsSource = rout.GetData();
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
