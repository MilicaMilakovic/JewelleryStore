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
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        StoreDb db = new StoreDb();
        

        public AdminWindow()
        {
            InitializeComponent();
            myFrame.Source = new Uri("pack://application:,,,/ProductsPage.xaml");
        }

        private void ToSerbian(object sender, RoutedEventArgs e)
        {
            ResourceDictionary resourceDictionary = new ResourceDictionary();
            resourceDictionary.Source = new Uri("pack://application:,,,/Resources/StringResources.Srb.xaml");
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);

        }

        private void ToEnglish(object sender, RoutedEventArgs e)
        {
            // trenutno je na sprskom, mijenjam na engleski
            ResourceDictionary resourceDictionary = new ResourceDictionary();
            resourceDictionary.Source = new Uri("pack://application:,,,/Resources/StringResources.En.xaml");
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
                       
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ShowProducts(object sender, RoutedEventArgs e)
        {
            pageLabel.Content = (string)App.Current.Resources["Products"];
            myFrame.Source = new Uri("pack://application:,,,/ProductsPage.xaml");

        }

        private void ShowStaff(object sender, RoutedEventArgs e)
        {
            pageLabel.Content = (string) App.Current.Resources["Staff"];
            myFrame.Source = new Uri("pack://application:,,,/StaffPage.xaml");
        }
    }
}
