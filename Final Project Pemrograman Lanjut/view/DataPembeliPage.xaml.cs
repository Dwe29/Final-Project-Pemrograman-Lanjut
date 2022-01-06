using System;
using System.Windows;
using System.Windows.Controls;
using Final_Project_Pemrograman_Lanjut.controller;

namespace Final_Project_Pemrograman_Lanjut.view
{
    public partial class DataPembeliPage : Page
    {
        private DataPembeliController _controller;

        public DataPembeliPage()
        {
            InitializeComponent();
            _controller = new DataPembeliController(this);
            _controller.DataHistory();
        }

        private void DgHistory_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = DgPembelian.SelectedItem;
            ChangeProductWindow.nama_pembeli =
                (DgPembelian.SelectedCells[0].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeProductWindow.no_telp = (DgPembelian.SelectedCells[1].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeProductWindow.alamat_pembeli =
                (DgPembelian.SelectedCells[2].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeProductWindow.nama_produk =
                (DgPembelian.SelectedCells[3].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeProductWindow.harga_produk =
                Convert.ToInt32((DgPembelian.SelectedCells[4].Column.GetCellContent(item) as TextBlock)?.Text);
        }

        private void BtnUbah_OnClick(object sender, RoutedEventArgs e)
        {
            var ubah = new ChangeProductWindow();
            ubah.ShowDialog();
        }

        private void BtnHapus_OnClick(object sender, RoutedEventArgs e)
        {
        }

        private void BtnTambah_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}