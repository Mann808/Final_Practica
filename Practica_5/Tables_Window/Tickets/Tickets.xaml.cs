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

namespace Practica_5.Tables_Window.Tickets
{
    public partial class Tickets : Page
    {
        ticketTableAdapter ticket = new ticketTableAdapter();
        public Tickets()
        {
            InitializeComponent();
            Ticket_Grid.ItemsSource = ticket.GetData();
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Ticket_Grid.SelectedItem == null)
            {
                MessageBox.Show(@" Вы не выбрали элемент!");
                return;
            }
            try
            {
                object id = (Ticket_Grid.SelectedItem as DataRowView).Row[0];
                ticket.DeleteQuery(Convert.ToInt32(id));
                Ticket_Grid.ItemsSource = ticket.GetData();
            }
            catch
            {
                MessageBox.Show(@" Вы выбрали элемент без штуки");
            }
        }

        private void Ticket_Grid_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
            ticket.Update(Ticket_Grid.ItemsSource as AirLinersDataSet.ticketDataTable);

            }
            catch
            {
                MessageBox.Show(@" Вы изменили что, что нельзя было изменять...");
            }
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            Add.Content = new Add_ticket();
        }
    }
}
