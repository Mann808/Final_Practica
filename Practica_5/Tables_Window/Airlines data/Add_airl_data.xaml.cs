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
using Practica_5.Tables_Window.Airliens;

namespace Practica_5.Tables_Window.Airlines_data
{
    public partial class Add_airl_data : Page
    {
        Airline_dataTableAdapter air_data = new Airline_dataTableAdapter();
        public Add_airl_data()
        {
            InitializeComponent();
        }

        private void Adding_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(add.Text))
            {
                MessageBox.Show(@" Вы не заполнили пресс центр!");
                return;
            }
            else if (String.IsNullOrEmpty(add1.Text))
            {
                MessageBox.Show(@" Вы не заполнили журнал продажи билетов!");
                return;
            }
            else if (String.IsNullOrEmpty(add2.Text))
            {
                MessageBox.Show(@" Вы не заполнили контактный телефон!");
                return;
            }
            else if (String.IsNullOrEmpty(add3.Text))
            {
                MessageBox.Show(@" Вы не заполнили адреса офисов!");
                return;
            }
            else if (String.IsNullOrEmpty(add4.Text))
            {
                MessageBox.Show(@" Вы не заполнили авиа-школу!");
                return;
            }
            else if (String.IsNullOrEmpty(add5.Text))
            {
                MessageBox.Show(@" Вы не заполнили детали комании!");
                return;
            }
            else if (String.IsNullOrEmpty(add6.Text))
            {
                MessageBox.Show(@" Вы не заполнили торги и закупки!");
                return;
            }
            else if (String.IsNullOrEmpty(add7.Text))
            {
                MessageBox.Show(@" Вы не заполнили партнёры!");
                return;
            }
            else
            {
                try
                {
                    air_data.InsertQuery((Convert.ToString(add.Text)), (Convert.ToString(add1.Text)), (Convert.ToInt32(add2.Text)), (Convert.ToString(add3.Text)), (Convert.ToString(add4.Text)), (Convert.ToString(add5.Text)), (Convert.ToString(add6.Text)), (Convert.ToString(add7.Text)));
                    add.Text = null;
                    add1.Text = null;
                    add2.Text = null;
                    add3.Text = null;
                    add4.Text = null;
                    add5.Text = null;
                    add6.Text = null;
                    add7.Text = null;
                    ((Application.Current.MainWindow as Personal_Cabinet).Page_Frame.Content as Airl_Data).Air_Data_Grid.ItemsSource = air_data.GetData();
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
