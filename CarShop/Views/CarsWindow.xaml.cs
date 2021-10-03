using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CarShop.Views
{
    public partial class CarsWindow : Window
    {
        public CarsWindow()
        {
            InitializeComponent();
        }

        private void ShopButton(object sender, RoutedEventArgs e)
        {
            var shop = new MainWindow();
            shop.Show();
            Close();
        }

        private void ClientsButton(object sender, RoutedEventArgs e)
        {
            var client = new ClientWindow();
            client.Show();
            Close();
        }

        private void StuffsButton(object sender, RoutedEventArgs e)
        {

        }

        private void ProfitButton(object sender, RoutedEventArgs e)
        {

        }

        private void AddCarButton(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDeleteClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
