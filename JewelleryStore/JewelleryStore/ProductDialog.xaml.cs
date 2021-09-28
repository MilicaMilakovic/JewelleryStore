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
            this.Close();
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
