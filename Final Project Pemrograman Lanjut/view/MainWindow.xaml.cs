using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Final_Project_Pemrograman_Lanjut.model;

namespace Final_Project_Pemrograman_Lanjut.view
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            TbSearch.Visibility = Visibility.Visible;
            // var check = new ModelTemplate();
            // check.CheckConn();
        }

        private void CowPage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            TbSearchProduk();
            FrmMain.Navigate(new CowPage());
        }

        private void GoathPage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            TbSearchProduk();
            FrmMain.Navigate(new GoathPage());
        }

        private void ChickenPage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            TbSearchProduk();
            FrmMain.Navigate(new ChickenPage());
        }

        private void Logout_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var loginWindow = new LoginWindow();
            loginWindow.Show();
            Close();
        }

        private void ImgHistory_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            FrmMain.Navigate(new DataPembeliPage());
        }

        private void DataPembeli_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            TbSearch.Text = "Cari Pembeli";
            FrmMain.Navigate(new DataPembeliPage());
        }

        private void HomePage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void DataProduk_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            FrmMain.Navigate(new DataProdukPage());
        }

        private void TbSearchProduk()
        {
            TbSearch.Text = "Cari Produk";
        }

        private void TbSearch_OnGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TbSearch.Text = "";
        }
    }
}