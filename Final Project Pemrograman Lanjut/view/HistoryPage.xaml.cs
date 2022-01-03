using System;
using System.Windows;
using System.Windows.Controls;
using Final_Project_Pemrograman_Lanjut.controller;

namespace Final_Project_Pemrograman_Lanjut.view
{
    public partial class HistoryPage : Page
    {
        private HistoryController _controller;

        public HistoryPage()
        {
            InitializeComponent();
            _controller = new HistoryController(this);
            _controller.DataHistory();
        }

        private void DgHistory_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = DgHistory.SelectedItem;
            ChangeProductWindow.nama_pembeli =
                (DgHistory.SelectedCells[0].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeProductWindow.no_telp = (DgHistory.SelectedCells[1].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeProductWindow.alamat_pembeli =
                (DgHistory.SelectedCells[2].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeProductWindow.nama_produk =
                (DgHistory.SelectedCells[3].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeProductWindow.harga_produk =
                Convert.ToInt32((DgHistory.SelectedCells[4].Column.GetCellContent(item) as TextBlock)?.Text);
        }

        private void BtnUbah_OnClick(object sender, RoutedEventArgs e)
        {
            var ubah = new ChangeProductWindow();
            ubah.ShowDialog();
        }

        private void BtnHapus_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}