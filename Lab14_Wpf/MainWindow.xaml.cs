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
using System.Collections.ObjectModel;

namespace Lab14_Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
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
                ProductName = "Xiaomi 11 Ultra",
                ProductPrice = 105000,
                ProductImage = "Data/xiaomi phone.png",
                ProductType = ProductTypes.Electronics
            });
            products.Add(new Product()
            {
                ProductName = "HUAWEI Matebook 13 2020",
                ProductPrice = 69000,
                ProductImage = "Data/huawei laptop.png",
                ProductType = ProductTypes.Electronics
            });
            products.Add(new Product()
            {
                ProductName = "Coffee Latte",
                ProductPrice = 250,
                ProductImage = "Data/coffee.png",
                ProductType = ProductTypes.Beverages
            });
            products.Add(new Product()
            {
                ProductName = "Strawberry smoothie",
                ProductPrice = 300,
                ProductImage = "Data/smoothie.png",
                ProductType = ProductTypes.Beverages
            });

            lstBox.ItemsSource = products;
        }

    }
}
