using jsonCategory.Models;
using jsonCategory.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace jsonCategory.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        private ProductServices _productServices = new ProductServices();

        public Home()
        {
            this.InitializeComponent();
            TodaySpecial();
            
        }

        public async void TodaySpecial()
        {
            ProductList productList = await _productServices.TodaySpecial();
            if (productList != null)
            {
                ProductList.ItemsSource = productList.data;
            }
        }
        private void btn_add(object sender, RoutedEventArgs e)
        {

        }

        private void btn_tym(object sender, RoutedEventArgs e)
        {

        }

        private void GridViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Product detail = ProductList.SelectedItem as Product;
            MainPage.mainFrame.Navigate(typeof(ProductDetail), detail);
        }
    }
}
