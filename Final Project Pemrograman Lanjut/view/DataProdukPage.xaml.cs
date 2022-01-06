using System.Windows;
using System.Windows.Controls;
using Final_Project_Pemrograman_Lanjut.controller;

namespace Final_Project_Pemrograman_Lanjut.view
{
    public partial class DataProdukPage : Page
    {
        private DataProdukController _controller;

        public DataProdukPage()
        {
            InitializeComponent();
            _controller = new DataProdukController(this);
            _controller.ShowDataProduk();
        }

        private void BtnTambah_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}