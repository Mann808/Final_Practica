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
using System.Windows.Shapes;
using Practica_5.AirLinersDataSetTableAdapters;

namespace Practica_5
{
    static class Admin_Check
    {
        public static bool Adm_Chk { get; set; }
        public static bool Imp_Chk { get; set; }
    }
    public partial class Login : Window
    {
        UsersTableAdapter login = new UsersTableAdapter();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_in_Click(object sender, RoutedEventArgs e)
        {
            Admin_Check.Adm_Chk = false;
            Admin_Check.Imp_Chk = false;
            var allLogins = login.GetData();
            for (int i = 0; i < allLogins.Count; i++)
            {
                if ((allLogins[i][2].ToString() == txtLogin.Text) &&
                        (allLogins[i][3].ToString() == txtPassword.Password))
                {
                    if ((allLogins[i][1].ToString()) == "admin")
                    {
                        Admin_Check.Adm_Chk = true;
                    }
                    if (Admin_Check.Adm_Chk)
                    {
                        Personal_Cabinet start = new Personal_Cabinet();
                        start.Show();

                        Application.Current.MainWindow = start;

                        this.Hide();
                        return;
                    }
                    if ((allLogins[i][1].ToString()) == "import")
                    {
                        Admin_Check.Imp_Chk = true;
                    }
                    if (Admin_Check.Imp_Chk)
                    {
                        Personal_Cabinet start = new Personal_Cabinet();
                        start.Show();

                        Application.Current.MainWindow = start;

                        this.Hide();
                        return;
                    }
                    Buyer buyer = new Buyer();
                    buyer.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show(@"Такого пользователя не существет!");
        }
    }
}
