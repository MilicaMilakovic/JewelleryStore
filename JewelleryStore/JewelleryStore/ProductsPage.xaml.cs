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
    /// Interaction logic for ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        StoreDb db = new StoreDb();

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
                products.Children.Add(btn);
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
                if (p.Naziv.Contains(key))
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
                    products.Children.Add(btn);
                }

            }

        }
    }
}
