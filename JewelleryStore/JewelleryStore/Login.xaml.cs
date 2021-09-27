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

namespace JewelleryStore
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LogIn(object sender, RoutedEventArgs e)
        {
            string u = username.Text;
            string p = password.Password.ToString();

            StoreDb db = new StoreDb();

            if (db.zaposlenis.Any(o => o.KorisnickoIme == u && o.Lozinka == p))
            {
                Console.WriteLine("Uspjesna prijava!");
                MainWindow.staff = db.zaposlenis.First(o => o.KorisnickoIme == u && o.Lozinka == p);
                new MainWindow().Show();
                this.Close();
            }
            else
                Console.WriteLine("Neuspjesna prijava!");
            
        }

        private void AdminLogin(object sender, RoutedEventArgs e)
        {
            string u = username.Text;
            string p = password.Password.ToString();

            StoreDb db = new StoreDb();

            if (db.zaposlenis.Any(o => o.KorisnickoIme == u && o.Lozinka == p && o.isAdmin == true))
            {
                Console.WriteLine("Uspjesna prijava!");
                new AdminWindow().Show();
                this.Close();
            }
            else
                Console.WriteLine("Neuspjesna prijava...");
        }

        private void ToSerbian(object sender, RoutedEventArgs e)
        {
            ResourceDictionary resourceDictionary = new ResourceDictionary();
            resourceDictionary.Source = new Uri("pack://application:,,,/Resources/StringResources.Srb.xaml");
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }

        private void ToEnglish(object sender, RoutedEventArgs e)
        {            
            ResourceDictionary resourceDictionary = new ResourceDictionary();
            resourceDictionary.Source = new Uri("pack://application:,,,/Resources/StringResources.En.xaml");
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }
    }
}
