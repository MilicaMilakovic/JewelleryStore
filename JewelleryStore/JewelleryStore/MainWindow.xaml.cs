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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StoreDb db = new StoreDb();
        private List<proizvod> selectedItems = new List<proizvod>();

        public MainWindow()
        {
            InitializeComponent();
            ShowAll();
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ShowAll()
        {
           // StoreDb db = new StoreDb();
            products.Children.Clear();
            foreach (proizvod p in db.proizvods)
            {
                Button btn = new Button();
                btn.Style = (Style)Resources["ButtonStyle"];

                StackPanel stackPanel = new StackPanel();               
                stackPanel.Style = (Style)Resources["StackPanelStyle"];

                Image image = new Image();
                
                image.Source = new BitmapImage(new Uri("pack://application:,,,/images/" + p.Slika));              
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
            refreshSelection();
        }

        private void ShowFilter(int typeId)
        {

           // StoreDb db = new StoreDb();
            products.Children.Clear();
            foreach (proizvod p in db.proizvods)
            {
                if (p.tipProizvoda == typeId)
                {
                    Button btn = new Button();
                    btn.Style = (Style)Resources["ButtonStyle"];

                    StackPanel stackPanel = new StackPanel();                  
                    stackPanel.Style = (Style)Resources["StackPanelStyle"];

                    Image image = new Image();

                    image.Source = new BitmapImage(new Uri("pack://application:,,,/images/" + p.Slika));   
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
            Console.WriteLine(product.Naziv);
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
    }
}
