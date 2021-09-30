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

namespace JewelleryStore
{
    /// <summary>
    /// Interaction logic for StaffPage.xaml
    /// </summary>
    public partial class StaffPage : Page
    {
        StoreDb db = new StoreDb();

        public StaffPage()
        {
            InitializeComponent();
            ShowUsers();
        }

       
        private void ShowUsers()
        {
            users.Children.Clear();
            foreach(var u in db.zaposlenis)
            {
                if(u.isActive == true)
                {
                    users.Children.Add(new StaffControl(u) as UIElement);
                }
            }
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            ShowUsers();
        }

        private void AddUser(object sender, RoutedEventArgs e)
        {
           EditUser edit= new EditUser();
            edit.Closed += (s,ee) => Refresh(sender,e);
            edit.Show();

        }

        /*
        private void Search(object sender, KeyEventArgs e)
        {
            Console.WriteLine("search staff");
            if(e.Key == Key.Enter)
            {
                string key = SearchField.Text;
                ShowFilter(key);
            }
        }

        private void ShowFilter(string key)
        {
            users.Children.Clear();
            Console.WriteLine("show filter");
            foreach(var u in db.zaposlenis)
            {
                if(u.isActive == true && u.Ime.Contains(key))
                {
                    users.Children.Add(new StaffControl(u) as UIElement);
                }
            }
        }
        */
    }


}
