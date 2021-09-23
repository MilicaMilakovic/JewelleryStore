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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
            StoreDb db = new StoreDb();
            products.Children.Clear();
            foreach (proizvod p in db.proizvods)
            {
               
                StackPanel stackPanel = new StackPanel();
                stackPanel.Orientation = Orientation.Vertical;
                stackPanel.Height = 200;
                stackPanel.Width = 155;
                stackPanel.Background = Brushes.Transparent;
                stackPanel.Margin = new Thickness(8);

                Image image = new Image();
                
                image.Source = new BitmapImage(new Uri("pack://application:,,,/images/" + p.Slika));
                image.Height = 150;
                image.Width = 150;
                image.Stretch = Stretch.UniformToFill;
                image.Margin = new Thickness(3);

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

                products.Children.Add(stackPanel);

            }
        }
    }
}
