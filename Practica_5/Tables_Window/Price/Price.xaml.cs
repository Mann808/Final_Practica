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
using Newtonsoft.Json;
using Practica_5.Model;
using System.IO;

namespace Practica_5.Tables_Window.Price
{
    public partial class Price : Page
    {
        PriceTableAdapter price = new PriceTableAdapter();
        public Price()
        {
            InitializeComponent();
            Price_Grid.ItemsSource = price.GetData();
            if (!Admin_Check.Imp_Chk)
            {
                Chn_Button.IsEnabled = false;
            }
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Price_Grid.SelectedItem == null)
            {
                MessageBox.Show(@" Вы не выбрали элемент!");
                return;
            }
            try
            {
                object id = (Price_Grid.SelectedItem as DataRowView).Row[0];
                price.DeleteQuery(Convert.ToInt32(id));
                Price_Grid.ItemsSource = price.GetData();
            }
            catch
            {
                MessageBox.Show(@" Вы выбрали элемент без штуки");
            }
        }

        private void Price_Grid_CurrentCellChanged(object sender, EventArgs e)
        {
            price.Update(Price_Grid.ItemsSource as AirLinersDataSet.PriceDataTable);
            var chk_price = price.GetData();
            for (int i = 0; i < chk_price.Count; i++)
            {
                if (Convert.ToInt32(chk_price[i][1]) < 0)
                {
                    chk_price[i][1] = 0;
                    MessageBox.Show(@" Цена не может быть меньше нуля!");
                    price.Update(chk_price);
                    Price_Grid.ItemsSource = price.GetData();
                }
            }
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            Add.Content = new Add_price();

            }
            catch
            {
                MessageBox.Show(@" Вы изменили что, что нельзя было изменять...");
            }
        }

        private void Chn_Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Admin_Check.Imp_Chk)
            {
                try
                {
                List<priceModel> list = Converter.DeserializeObject<List<priceModel>>();
                foreach (var items in list)
                {
                    price.InsertQuery(items.cost, items.date, items.details);
                }
                Price_Grid.ItemsSource = price.GetData();

                }
                catch
                {
                    MessageBox.Show(@" Вы выбрали файл не того формата или не выбрали вовсе!");
                }
            }
        }
    }
}
