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
    /// Interaction logic for ProductDialog.xaml
    /// </summary>
    public partial class ProductDialog : Window
    {
        private StoreDb db = new StoreDb();
        private proizvod product;
        private BitmapImage img;
      

        public ProductDialog()
        {
            InitializeComponent();
            EditBtn.Visibility = Visibility.Collapsed;
            AddBtn.Visibility = Visibility.Visible;
        }

        public ProductDialog(proizvod product)
        {
            InitializeComponent();
            EditBtn.Visibility = Visibility.Visible;
            AddBtn.Visibility = Visibility.Collapsed;

            nameField.Text = product.Naziv;
            priceField.Text = product.Cijena.ToString();
            quantityField.Text = product.Kolicina.ToString();

            string selection = "type" + product.tipProizvoda;

            tipProizvoda.SelectedItem = tipProizvoda.Items.GetItemAt(product.tipProizvoda-1);

            image.Source = new BitmapImage( new Uri("pack://application:,,,/images/" + product.Slika));
            this.product = product;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddImage(object sender, RoutedEventArgs e)
        {
            
        }

        private void EditProductInfo(object sender, RoutedEventArgs e)
        {
            var item = db.proizvods.First(o => o.SifraProizvoda == product.SifraProizvoda);

            item.Naziv = nameField.Text;
            item.Cijena = Decimal.Parse(priceField.Text);
            item.Kolicina = Int32.Parse(quantityField.Text);

            item.tipProizvoda = tipProizvoda.SelectedIndex+1;

            db.SaveChanges();
            this.Close();
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            product = new proizvod();

            product.Naziv = nameField.Text;
            product.Cijena = Decimal.Parse(priceField.Text);
            product.Kolicina = Int32.Parse(quantityField.Text);
            product.tipProizvoda = tipProizvoda.SelectedIndex;

            this.Close();
        }
    }
}
