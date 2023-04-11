using System;
using System.Collections.Generic;
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
using Practica_5.Tables_Window.Books;

namespace Practica_5.Tables_Window.Price
{
    public partial class Add_price : Page
    {
        PriceTableAdapter price = new PriceTableAdapter();
        public Add_price()
        {
            InitializeComponent();
        }

        private void Adding_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(add.Text))
            {
                MessageBox.Show(@" Вы не заполнили дату!");
                return;
            }
            else if (String.IsNullOrEmpty(add1.Text))
            {
                MessageBox.Show(@" Вы не заполнили стоимость!");
                return;
            }
            else if (String.IsNullOrEmpty(add2.Text))
            {
                MessageBox.Show(@" Вы не заполнили детали!");
                return;
            }
            else
            {
                try
                {
                    price.InsertQuery((Convert.ToInt32(add1.Text)), (Convert.ToDateTime(add.Text)), (Convert.ToString(add2.Text)));
                    add.Text = null;
                    add1.Text = null;
                    add2.Text = null;
                    ((Application.Current.MainWindow as Personal_Cabinet).Page_Frame.Content as Price).Price_Grid.ItemsSource = price.GetData();
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
