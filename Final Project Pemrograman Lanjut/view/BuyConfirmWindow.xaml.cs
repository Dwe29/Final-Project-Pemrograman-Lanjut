using System;
using System.Timers;
using System.Windows;
using System.Windows.Threading;

namespace Final_Project_Pemrograman_Lanjut.view
{
    public partial class BuyConfirmWindow : Window
    {
        private DispatcherTimer _timer;

        public BuyConfirmWindow()
        {
            InitializeComponent();
        }

        private void BuyConfirmWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(3);
            _timer.Tick += timer_tick;
            _timer.Start();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            _timer.Stop();
            Close();
        }
    }
}