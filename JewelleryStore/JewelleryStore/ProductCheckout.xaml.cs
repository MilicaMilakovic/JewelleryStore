﻿using System;
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
    /// Interaction logic for ProductCheckout.xaml
    /// </summary>
    public partial class ProductCheckout : UserControl
    {
        racun_stavka item;
        proizvod product;

        StoreDb db = new StoreDb();

        public ProductCheckout()
        {
            InitializeComponent();
        }

        public ProductCheckout(racun_stavka item)
        {
            InitializeComponent();

            this.item = item;
            product = db.proizvods.First(o => o.SifraProizvoda == item.SifraProizvoda);
            productPhoto.Source = new BitmapImage(new Uri("pack://application:,,,/images/" + product.Slika));
            productName.Text = product.Naziv;
            quantityLabel.Content = item.Kolicina;
            price.Content = "BAM "+ (item.Kolicina * product.Cijena).ToString();

        }

        private void removeOne(object sender, RoutedEventArgs e)
        {
            if (item.Kolicina > 0)
            {
                item.Kolicina -= 1;
                quantityLabel.Content = item.Kolicina;
                price.Content ="BAM "+ (item.Kolicina * product.Cijena).ToString();
            }
        }

        private void addOne(object sender, RoutedEventArgs e)
        {
            item.Kolicina += 1;
            quantityLabel.Content = item.Kolicina;
            price.Content = "BAM " + (item.Kolicina * product.Cijena).ToString();
        }
    }
}
