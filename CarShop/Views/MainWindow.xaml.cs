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

namespace CarShop.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CarsButton(object sender, RoutedEventArgs e)
        {
            var car = new CarsWindow();
            car.Show();
            Close();
        }

        private void ClientsButton(object sender, RoutedEventArgs e)
        {

        }

        private void StuffsButton(object sender, RoutedEventArgs e)
        {

        }

        private void ProfitButton(object sender, RoutedEventArgs e)
        {

        }

        private void ConfirmName(object sender, RoutedEventArgs e)
        {

        }
    }
}
