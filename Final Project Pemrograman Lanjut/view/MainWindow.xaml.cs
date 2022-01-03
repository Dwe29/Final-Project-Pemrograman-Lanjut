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

        private void TbSearch_OnGotFocus(object sender, RoutedEventArgs e)
        {
            TbSearch.Foreground = Brushes.Black;
            TbSearch.Text = "";
        }


        private void CowPage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            TbSearch.Visibility = Visibility.Visible;
            FrmMain.Navigate(new CowPage());
        }

        private void GoathPage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            TbSearch.Visibility = Visibility.Visible;
            FrmMain.Navigate(new GoathPage());
        }

        private void ChickenPage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            TbSearch.Visibility = Visibility.Visible;
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
            FrmMain.Navigate(new HistoryPage());
            TbSearch.Visibility = Visibility.Hidden;
        }

        private void TbSearch_OnLostFocus(object sender, RoutedEventArgs e)
        {
            TbSearch.Foreground = Brushes.Gray;
            TbSearch.Text = "Cari Produk";
        }
    }
}