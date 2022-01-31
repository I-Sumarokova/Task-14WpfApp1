using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Занятие14WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Хлеб",
                Price=101,
                Priority = 1,
                ProductType=ProductTypes.Meal
            });
            products.Add(new Product()
            {
                ProductName = "Стиральная машина",
                Price = 20000,
                Priority = 2,
                ProductType = ProductTypes.HomeAppliances
            });
            products.Add(new Product()
            {
                ProductName = "Сыр",
                Price = 300,
                Priority = 1,
                ProductType = ProductTypes.Meal
            });
            products.Add(new Product()
            {
                ProductName = "Утюг",
                Price = 6000,
                Priority = 2,
                ProductType = ProductTypes.HomeAppliances
            });
            products.Add(new Product()
            {
                ProductName = "Молоко",
                Price = 122,
                Priority = 1,
                ProductType = ProductTypes.Meal
            });
            lstBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                ProductName = "Чайник",
                Price = 3000,
                Priority = 2,
                ProductType = ProductTypes.HomeAppliances
            });
        }
    }
}
