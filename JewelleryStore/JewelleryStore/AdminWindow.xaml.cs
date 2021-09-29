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
using System.IO;


namespace JewelleryStore
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        StoreDb db = new StoreDb();
        public static zaposleni admin;

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
            //pageLabel.Content = (string)App.Current.Resources["Products"];
            myFrame.Source = new Uri("pack://application:,,,/ProductsPage.xaml");

        }

        private void ShowStaff(object sender, RoutedEventArgs e)
        {
            //pageLabel.Content = (string) App.Current.Resources["Staff"];
            myFrame.Source = new Uri("pack://application:,,,/StaffPage.xaml");
        }

        private void ShowStatistics(object sender, RoutedEventArgs e)
        {
            myFrame.Source = new Uri("pack://application:,,,/StatisticsPage.xaml");

        }

        private void ChangeTheme(object sender, RoutedEventArgs e)
        {
            var btn = (RadioButton)sender;

            if (btn.Tag.ToString() == "Theme1")
            {
                SwitchTheme1();
            }
            else if (btn.Tag.ToString() == "Theme2")
            {
                SwitchTheme2();
            }
            else
                SwitchTheme3();
        }

        private void SwitchTheme1()
        {
            ResourceDictionary resourceDictionary1 = new ResourceDictionary();
            ResourceDictionary resourceDictionary2 = new ResourceDictionary();
            ResourceDictionary resourceDictionary3 = new ResourceDictionary();
            ResourceDictionary resourceDictionary4 = new ResourceDictionary();

            resourceDictionary1.Source = new Uri("pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml");
            resourceDictionary2.Source = new Uri("pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml");
            resourceDictionary3.Source = new Uri("pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Teal.xaml");
            resourceDictionary4.Source = new Uri("pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Teal.xaml");

            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary1);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary2);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary3);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary4);           
        }

        private void SwitchTheme2()
        {
            ResourceDictionary resourceDictionary1 = new ResourceDictionary();
            ResourceDictionary resourceDictionary2 = new ResourceDictionary();
            ResourceDictionary resourceDictionary3 = new ResourceDictionary();
            ResourceDictionary resourceDictionary4 = new ResourceDictionary();

            resourceDictionary1.Source = new Uri("pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml");
            resourceDictionary2.Source = new Uri("pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml");
            resourceDictionary3.Source = new Uri("pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Pink.xaml");
            resourceDictionary4.Source = new Uri("pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Green.xaml");

            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary1);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary2);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary3);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary4);
           
        }


        private void SwitchTheme3()
        {
            ResourceDictionary resourceDictionary1 = new ResourceDictionary();
            ResourceDictionary resourceDictionary2 = new ResourceDictionary();
            ResourceDictionary resourceDictionary3 = new ResourceDictionary();
            ResourceDictionary resourceDictionary4 = new ResourceDictionary();

            resourceDictionary1.Source = new Uri("pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml");
            resourceDictionary2.Source = new Uri("pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml");
            resourceDictionary3.Source = new Uri("pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Brown.xaml");
            resourceDictionary4.Source = new Uri("pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Cyan.xaml");

            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary1);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary2);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary3);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary4);
           
        }
    }
}

