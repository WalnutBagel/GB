using GreatBritain.SystemAppClass;
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
using static GreatBritain.ApplicationData.AppConnect;

namespace GreatBritain.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageProductList.xaml
    /// </summary>
    public partial class PageProductList : Page
    {
        public List<Product> ProductList { get; set; } = new List<Product>(); // создаем список, в который будем загружать таблицу продуктов
        public PageProductList()
        {
            InitializeComponent();
            ProductList = context.Product.ToList();
            UpdateTable(false);
            // Настройка combobox с производителями
            List<Manufacturer> manufacturers = context.Manufacturer.ToList();
            manufacturers.Insert(0, new Manufacturer() { Name = "Select All" });
            ListManufacturerBox.ItemsSource = manufacturers;
            ListManufacturerBox.DisplayMemberPath = "Name";
            ListManufacturerBox.SelectedIndex = 0;

            ListSortBox.SelectedIndex = 0;
            ListEntriesBox.SelectedIndex = 0;
        }

        public void UpdateTable(bool Filter)
        {
            if (Filter)
            {
                LVProducts.ItemsSource = ProductList;
            }
            else
            {
                LVProducts.ItemsSource = context.Product.ToList();
            }
        }

        public void MakeFilters()
        {
            var list = context.Product.Where(i => i.Title.Contains(TBTitleSearch.Text)).
                                       Where(i => i.Title.Contains(TBTitleSearch.Text)).
                                       ToList();

            if ((ListManufacturerBox != null) && (ListManufacturerBox.SelectedIndex != 0))
            {
                list = list.Where(i => i.ManufacturerID.Equals(ListManufacturerBox.SelectedIndex)).ToList();
            }

            if (ListSortBox != null)
            {
                switch (ListSortBox.SelectedIndex)
                {
                    case 1:
                        list = list.OrderBy(i => i.Cost).ToList();
                        break;
                    case 2:
                        list = list.OrderByDescending(i => i.Cost).ToList();
                        break;
                }
            }

            ProductList = list;
            UpdateTable(true);
        }

        private void TBTitleSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            MakeFilters();
        }

        private void TBDescriptionSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            MakeFilters();
        }

        private void ListManufacturerBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MakeFilters();
        }

        private void ListSortBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MakeFilters();
        }

        private void ListEntriesBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MakeFilters();
        }

        private void BtPrevPage_Click(object sender, RoutedEventArgs e)
        {
            MakeFilters();
        }

        private void BtNextPage_Click(object sender, RoutedEventArgs e)
        {
            MakeFilters();
        }

        private void BtDeleteProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtEditProduct_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.SelectedFrame.Navigate(new PageEditProduct());
        }

        private void BtAddProduct_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.SelectedFrame.Navigate(new PageEditProduct());
        }

        private void BtClear_Click(object sender, RoutedEventArgs e)
        {
            TBTitleSearch.Clear();
            TBDescriptionSearch.Clear();
            ListEntriesBox.SelectedIndex = 0;
            ListManufacturerBox.SelectedIndex = 0;
            ListSortBox.SelectedIndex = 0;
            UpdateTable(false);
        }
    }
}
