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
using System.Threading;
using System.Collections.ObjectModel;
using System.IO;


namespace JewelleryStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StoreDb db = new StoreDb();       
        private List<proizvod> selectedItems = new List<proizvod>();
        zaposleni staff;
        racun racun1;
        public static int id;

        public MainWindow()
        {
            InitializeComponent();

            staff = db.zaposlenis.First(o => o.idZaposlenog == id);

            if (staff.Tema == "Theme1") SwitchTheme1();
            else if (staff.Tema == "Theme2") SwitchTheme2();
            else SwitchTheme3();

            user.Content = staff.Ime;          
            ShowAll();
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ShowAll()
        {
            products.Children.Clear();
            foreach (proizvod p in db.proizvods)
            {
                if (p.isActive == true)
                {
                    Button btn = new Button();
                    btn.Style = (Style)Resources["ButtonStyle"];

                    StackPanel stackPanel = new StackPanel();
                    stackPanel.Style = (Style)Resources["StackPanelStyle"];

                    Image image = new Image();

                    var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

                    image.Source = new BitmapImage(new Uri(projectPath+"/images/" + p.Slika));
                    image.Style = (Style)Resources["ImageStyle"];

                    Label name = new Label();
                    name.HorizontalAlignment = HorizontalAlignment.Center;
                    name.Content = p.Naziv;
                    name.FontWeight = FontWeights.DemiBold;
                    name.FontSize = 11;


                    Label price = new Label();
                    price.HorizontalAlignment = HorizontalAlignment.Center;
                    price.Content = "BAM " + p.Cijena;
                    price.FontSize = 11;

                    stackPanel.Children.Add(image);
                    stackPanel.Children.Add(name);
                    stackPanel.Children.Add(price);

                    btn.Content = stackPanel;
                    btn.Name = "btn" + p.SifraProizvoda.ToString();
                    btn.Click += new RoutedEventHandler(selectItem);
                    products.Children.Add(btn);
                }

            }
            refreshSelection();
        }

        private void ShowFilter(int typeId)
        {
            products.Children.Clear();
            foreach (proizvod p in db.proizvods)
            {
                if (p.isActive == true && p.tipProizvoda == typeId)
                {
                    Button btn = new Button();
                    btn.Style = (Style)Resources["ButtonStyle"];

                    StackPanel stackPanel = new StackPanel();                  
                    stackPanel.Style = (Style)Resources["StackPanelStyle"];

                    Image image = new Image();
                    var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

                    image.Source = new BitmapImage(new Uri(projectPath + "/images/" + p.Slika));
                    image.Style = Resources["ImageStyle"] as Style;

                    Label name = new Label();
                    name.HorizontalAlignment = HorizontalAlignment.Center;
                    name.Content = p.Naziv;
                    name.FontWeight = FontWeights.DemiBold;
                    name.FontSize = 11;


                    Label price = new Label();
                    price.HorizontalAlignment = HorizontalAlignment.Center;
                    price.Content = "BAM " + p.Cijena;
                    price.FontSize = 11;

                   
                    stackPanel.Children.Add(image);
                    stackPanel.Children.Add(name);
                    stackPanel.Children.Add(price);

                    btn.Content = stackPanel;
                    btn.Name = "btn"+p.SifraProizvoda.ToString();
                    btn.Click += new RoutedEventHandler(selectItem);
                    products.Children.Add(btn);
                }
            }
            refreshSelection();
        }

        
        private void ShowNecklaces(object sender, RoutedEventArgs e)
        {
            ShowFilter(1);
        }

        private void ShowRings(object sender, RoutedEventArgs e)
        {
            ShowFilter(2);
        }

        private void ShowAll(object sender, RoutedEventArgs e)
        {
            ShowAll();
        }

        private void ShowEarrings(object sender, RoutedEventArgs e)
        {
            ShowFilter(3);
        }

        private void ShowWristwear(object sender, RoutedEventArgs e)
        {
            ShowFilter(4);
        }

        private void selectItem(object sender, RoutedEventArgs e)
        {
            string btn = (sender as Button).Name.ToString();
            int id =Int32.Parse(btn.Remove(0, 3));

            var product = db.proizvods.First(o => o.SifraProizvoda == id);

            if (selectedItems.Contains(product))
            {
                (sender as Button).Background = Brushes.Transparent;
                selectedItems.Remove(product);
            }
            else
            {
                var bc = new BrushConverter();
                (sender as Button).Background = (Brush)bc.ConvertFrom("#D6ECE6");
                selectedItems.Add(product);
            }

            if (selectedItems.Count > 0) nextBtn.IsEnabled = true;
            else nextBtn.IsEnabled = false;
            //Console.WriteLine(product.Naziv);
        }


        private void refreshSelection()
        {
            var bc = new BrushConverter();
            if(selectedItems.Count > 0)
            {
                foreach (proizvod p in selectedItems)
                {
                    foreach (var e in products.Children.OfType<Button>())
                    {
                        if (e.Name == "btn" + p.SifraProizvoda)
                        {
                            e.Background = (Brush)bc.ConvertFrom("#D6ECE6");
                        }
                    }
                }
            }          
        }

        private void NextPage(object sender, RoutedEventArgs e)
        {
            navbar.Visibility = Visibility.Collapsed;
            scrollBarViewer.Visibility = Visibility.Collapsed;

            checkoutSV.Visibility = Visibility.Visible;
            backBtn.Visibility = Visibility.Visible;

            racun1 = new racun();
            db.racuns.Add(racun1);


            checkout.Children.Clear();
            foreach(var p in selectedItems)
            {
                racun_stavka stavka = new racun_stavka()
                {
                    idRacuna = racun1.idRacuna,
                    SifraProizvoda = p.SifraProizvoda,
                    racun = racun1,
                    proizvod = p,
                    Kolicina = 1,
                    Cijena = p.Cijena                   
                };

                racun1.racun_stavka.Add(stavka);                
                checkout.Children.Add(new ProductCheckout(racun1, stavka) as UIElement);                        

            }

            totalLabel.Visibility = Visibility.Visible;
            priceLabel.Visibility = Visibility.Visible;
            nextBtn.Visibility = Visibility.Collapsed;
            finishBtn.Visibility = Visibility.Visible;
            //
            backBtn.Visibility = Visibility.Collapsed;
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            checkoutSV.Visibility = Visibility.Collapsed;
            scrollBarViewer.Visibility = Visibility.Visible;
            backBtn.Visibility = Visibility.Collapsed;
            nextBtn.Visibility = Visibility.Visible;
            navbar.Visibility = Visibility.Visible;
            totalLabel.Visibility = Visibility.Collapsed;
            finishBtn.Visibility = Visibility.Collapsed;
            finishBtn.IsEnabled = true;
            priceLabel.Visibility = Visibility.Collapsed;
            priceLabel.Content = ": ";

            selectedItems.Clear();
            nextBtn.IsEnabled = false;

            ShowAll();
          
        }

        private void Finish(object sender, RoutedEventArgs e)
        {
            //if (checkout.Children.Count == 0)
            //{
            //    backBtn.Visibility = Visibility.Visible;
            //    selectedItems.Clear();
            //    racun1.racun_stavka.Clear();
            //    db.racuns.Remove(racun1);
            //    db.SaveChanges();
            //    return;
            //}

            backBtn.Visibility = Visibility.Visible;
            finishBtn.IsEnabled = false;
            decimal total = 0;
            foreach (var stavka in racun1.racun_stavka)
            {
                //Console.WriteLine(stavka.proizvod.Naziv + " " +stavka.Kolicina + " " + stavka.Cijena + " " +stavka.racun.idRacuna );
                total += stavka.Cijena;
            }

            racun1.CijenaUkupno = total;
            racun1.DatumIzdavanja = DateTime.Now;
            racun1.ZAPOSLENI_idZaposlenog = id;

            db.SaveChanges();
            priceLabel.Content = ": BAM " + total;

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

            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            mainImage.Source = new BitmapImage(new Uri(projectPath + "/images/mainImage.jpg"));

            staff.Tema = "Theme1";
            db.SaveChanges();
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

            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            mainImage.Source = new BitmapImage(new Uri(projectPath + "/images/mainPhoto3.jpg"));

            staff.Tema = "Theme2";
            db.SaveChanges();
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

            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            mainImage.Source = new BitmapImage(new Uri(projectPath + "/images/mainPhoto.jpg"));

            staff.Tema = "Theme3";
            db.SaveChanges();
        }
    }
}
