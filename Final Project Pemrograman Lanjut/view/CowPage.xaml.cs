using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using Final_Project_Pemrograman_Lanjut.controller;
using Final_Project_Pemrograman_Lanjut.model;

namespace Final_Project_Pemrograman_Lanjut.view
{
    public partial class CowPage : Page
    {
        private controller.ProdukControllerCow _produkControllerCow;
        
        public CowPage()
        {
            _produkControllerCow = new ProdukControllerCow(this);
            
            InitializeComponent();
            var product = GetProduct();
            if (product.Count > 0)
            {
                ListViewProducts.ItemsSource = product;
            }
        }
        

        private List<DataProduct> GetProduct()
        {
            return _produkControllerCow.ShowProductCow();
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var buy = new BuyProductWindow();
            buy.ShowDialog();
        }
    }
}