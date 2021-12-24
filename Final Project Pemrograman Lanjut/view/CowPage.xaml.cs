using System.Collections.Generic;
using System.Windows.Controls;

namespace Final_Project_Pemrograman_Lanjut.view
{
    public partial class CowPage : Page
    {
        public CowPage()
        {
            InitializeComponent();
            var product = GetProduct();
            if (product.Count > 0)
            {
                ListViewProducts.ItemsSource = product;
            }
        }

        private static List<GoathProduct> GetProduct()
        {
            return new List<GoathProduct>
            {
                new GoathProduct("Sapi", 2000000, "/img/sp1.png"),
                new GoathProduct("Sapi", 1000000, "/img/sapi2.png"),
                new GoathProduct("Sapi", 2000000, "/img/sapi3.png"),
                new GoathProduct("Sapi", 5000000, "/img/sapi4.png"),
            };
        }
    }
}