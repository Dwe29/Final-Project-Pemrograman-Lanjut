using System.Windows;
using Final_Project_Pemrograman_Lanjut.controller;

namespace Final_Project_Pemrograman_Lanjut.view
{
    public partial class BuyProductWindow : Window
    {
        public BuyProductWindow()
        {
            InitializeComponent();
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}