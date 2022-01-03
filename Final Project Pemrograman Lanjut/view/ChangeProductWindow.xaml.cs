using System.Windows;

namespace Final_Project_Pemrograman_Lanjut.view
{
    public partial class ChangeProductWindow : Window
    {
        public static string nama_pembeli;
        public static string no_telp;
        public static string alamat_pembeli;
        public static string nama_produk;
        public static int harga_produk;

        public ChangeProductWindow()
        {
            InitializeComponent();

            TbNameCustomer.Text = nama_pembeli;
            TbNomor.Text = no_telp;
            TbAlamat.Text = alamat_pembeli;
            TbNameProduct.Text = nama_produk;
            TbHarga.Text = harga_produk.ToString();
        }

        private void Btncancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnChange_OnClick(object sender, RoutedEventArgs e)
        {
        }
    }
}