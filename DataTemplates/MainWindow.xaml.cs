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

namespace DataTemplates
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();

            products = new List<Product>();
            products.Add(new Product()
            {
                ProductName = "Бананы",
                ProductPrice = 38,
                ProductImage = "Data/Banana.jpg",
                ProductCategory = ProductCategories.Еда,
            });
            products.Add(new Product()
            {
                ProductName = "Молоко",
                ProductPrice = 70,
                ProductImage = "Data/Milk.png",
                ProductCategory = ProductCategories.Еда,
            });
            products.Add(new Product()
            {
                ProductName = "Пылесос",
                ProductPrice = 3000,
                ProductImage = "Data/Vacuum Cleaner.jpg",
                ProductCategory = ProductCategories.Бытовая_техника,
            });
            listBox.ItemsSource = products;
        }        
    }
}
