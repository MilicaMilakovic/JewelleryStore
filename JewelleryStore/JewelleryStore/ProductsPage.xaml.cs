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
using System.IO;


namespace JewelleryStore
{
    /// <summary>
    /// Interaction logic for ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        StoreDb db = new StoreDb();
        proizvod selectedItem;
        

        public ProductsPage()
        {
            InitializeComponent();
            ShowAll();
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

                    image.Source = new BitmapImage(new Uri(projectPath + "/images/" + p.Slika));
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
        }

        private void Search(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                string key = SearchField.Text;
                ShowFilter(key);
            }
        }

        private void ShowFilter(string key)
        {
            products.Children.Clear();
            foreach (proizvod p in db.proizvods)
            {
                if (p.isActive == true && p.Naziv.Contains(key))
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
                    btn.Name = "btn" + p.SifraProizvoda.ToString();
                    btn.Click += new RoutedEventHandler(selectItem);
                    products.Children.Add(btn);
                }

            }

        }
        private void selectItem(object sender, RoutedEventArgs e)
        {
            string btn = (sender as Button).Name.ToString();
            int id = Int32.Parse(btn.Remove(0, 3));

            var product = db.proizvods.First(o => o.SifraProizvoda == id);

            if(selectedItem!= null)
            {

                foreach (var b in products.Children.OfType<Button>())
                {
                    if (b.Name == "btn" + selectedItem.SifraProizvoda)
                    {
                        b.Background = Brushes.Transparent;
                        break;
                    }
                }
                selectedItem = null;
                deleteBtn.IsEnabled = false;
                editBtn.IsEnabled = false;
            }

            if (product.Equals(selectedItem))
            {
                (sender as Button).Background = Brushes.Transparent;
                selectedItem = null;
                deleteBtn.IsEnabled = false;
                editBtn.IsEnabled = false;
            }
            else
            {
                var bc = new BrushConverter();
                (sender as Button).Background = (Brush)bc.ConvertFrom("#D6ECE6");
                selectedItem = product;
            }

            if (selectedItem != null) {
                deleteBtn.IsEnabled = true;
                editBtn.IsEnabled = true;
            }
            else
            {
                deleteBtn.IsEnabled = false;
                editBtn.IsEnabled = false;
            }

            Console.WriteLine(product.Naziv);
        }

        private void DeleteProduct(object sender, RoutedEventArgs e)
        {
            selectedItem.isActive = false;
            db.SaveChanges();
            ShowAll();
            deleteBtn.IsEnabled = false;
            editBtn.IsEnabled = false;
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            new ProductDialog().Show();
        }

        private void EditButton(object sender, RoutedEventArgs e)
        {
            new ProductDialog(selectedItem).Show();
        }
    }        
}
