using System.Windows;
using System.Windows.Input;
using Final_Project_Pemrograman_Lanjut.controller;

namespace Final_Project_Pemrograman_Lanjut.view
{
    public partial class LoginWindow : Window
    {
        private readonly UsersController _usersController;

        public LoginWindow()
        {
            InitializeComponent();
            _usersController = new UsersController(this);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            _usersController.Login();
        }

        private void LblDaftarWindows_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var daftarWindow = new RegisterWindow();
            daftarWindow.Show();
            this.Close();
        }
    }
}