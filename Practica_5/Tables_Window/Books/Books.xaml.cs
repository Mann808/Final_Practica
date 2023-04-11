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
using Practica_5.Model;
using Practica_5.Tables_Window.Adult_passengers;
using Practica_5.Tables_Window.Passengers;
using Practica_5.Tables_Window.Price;

namespace Practica_5.Tables_Window.Books
{
    public partial class Books : Page
    {
        BookTableAdapter book = new BookTableAdapter();
        public Books()
        {
            InitializeComponent();
            Book_Grid.ItemsSource = book.GetData();
            if (!Admin_Check.Imp_Chk)
            {
                Chn_Button.IsEnabled = false;
            }
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Book_Grid.SelectedItem == null)
            {
                MessageBox.Show(@" Вы не выбрали элемент!");
                return;
            }
            try
            {
                object id = (Book_Grid.SelectedItem as DataRowView).Row[0];
                book.DeleteQuery(Convert.ToInt32(id));
                Book_Grid.ItemsSource = book.GetData();
            }
            catch
            {
                MessageBox.Show(@" Вы выбрали элемент без штуки");
            }
        }

        private void Book_Grid_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                book.Update(Book_Grid.ItemsSource as AirLinersDataSet.BookDataTable);
            }
            catch
            {
                MessageBox.Show(@" Вы изменили что, что нельзя было изменять...");
            }
        }

        private void Add_Button_Click_1(object sender, RoutedEventArgs e)
        {
            Add.Content = new Add_book();
        }

        private void Chn_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Admin_Check.Imp_Chk)
            {
                try
                {
                List<bookModel> list = Converter.DeserializeObject<List<bookModel>>();
                foreach (var items in list)
                {
                    book.InsertQuery(items.number_of_ticket, items.date);
                }
                Book_Grid.ItemsSource = book.GetData();
                }
                catch
                {
                    MessageBox.Show(@" Вы выбрали файл не того формата или не выбрали вовсе!");
                }
            }
        }
    }
}
