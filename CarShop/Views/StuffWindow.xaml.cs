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
    /// <summary>
    /// Логика взаимодействия для StuffWindow.xaml
    /// </summary>
    public partial class StuffWindow : Window
    {
        public StuffWindow()
        {
            InitializeComponent();
        }

        private void ShopButton(object sender, RoutedEventArgs e)
        {
            var shop = new MainWindow();
            shop.Show();
            Close();
        }

        private void CarsButton(object sender, RoutedEventArgs e)
        {
            var car = new CarsWindow();
            car.Show();
            Close();
        }

        private void ClientButton(object sender, RoutedEventArgs e)
        {
            var client = new ClientWindow();
            client.Show();
            Close();
        }

        private void ProfitButton(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAddClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
