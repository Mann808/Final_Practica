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

namespace Practica_5.Tables_Window.Airliens
{
    public partial class Add_airline : Page
    {
        AirlineTableAdapter airlines = new AirlineTableAdapter();
        Airline_dataTableAdapter airline_Data = new Airline_dataTableAdapter();
        public Add_airline()
        {
            InitializeComponent();
            choose_add.ItemsSource = airline_Data.GetData();
            choose_add.DisplayMemberPath = "id_airline_data";
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void Adding_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(add1.Text))
            {
                MessageBox.Show(@" Вы не заполнили название авиакомпании!");
                return;
            }
            else if (String.IsNullOrEmpty(choose_add.Text))
            {
                MessageBox.Show(@" Вы не выбрали данные авиакомпании!");
                return;
            }
            else
            {
                try
                {
                    airlines.InsertQuery((Convert.ToString(add1.Text)), (int)(choose_add.SelectedValue as DataRowView).Row[0]);
                    choose_add.Text = null;
                    add1.Text = null;
                    ((Application.Current.MainWindow as Personal_Cabinet).Page_Frame.Content as Airlines).Airline_Grid.ItemsSource = airlines.GetData();
                }
                catch
                {
                    MessageBox.Show(@" Вы не заполнили или ввели неправильно некоторые значения!");
                    return;
                }
            }
        }
    }
}
