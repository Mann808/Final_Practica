using Practica_5.Tables_Window.Airliens;
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

namespace Practica_5.Tables_Window.Books
{
    public partial class Add_book : Page
    {
        BookTableAdapter book = new BookTableAdapter();
        public Add_book()
        {
            InitializeComponent();
        }

        private void Adding_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(add.Text))
            {
                MessageBox.Show(@" Вы не заполнили номер билета!");
                return;
            }
            else if (String.IsNullOrEmpty(add1.Text))
            {
                MessageBox.Show(@" Вы не заполнили дату!");
                return;
            }
            else
            {
                try
                {
                    book.InsertQuery((Convert.ToInt32(add.Text)), (Convert.ToDateTime(add1.Text)));
                    add.Text = null;
                    add1.Text = null;
                    ((Application.Current.MainWindow as Personal_Cabinet).Page_Frame.Content as Books).Book_Grid.ItemsSource = book.GetData();
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
