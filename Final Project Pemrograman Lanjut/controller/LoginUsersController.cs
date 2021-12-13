using System.Windows;
using Final_Project_Pemrograman_Lanjut.model;
using Final_Project_Pemrograman_Lanjut.view;

namespace Final_Project_Pemrograman_Lanjut.controller
{
    public class UsersController
    {
        private UsersModel _usersModel;
        private LoginWindow _loginWindow;

        public UsersController(LoginWindow loginWindow)
        {
            _usersModel = new UsersModel();
            _loginWindow = loginWindow;
        }
        

        public void Login()
        {
            _usersModel.nama = _loginWindow.txtUsername.Text;
            _usersModel.password = _loginWindow.txtPassword.Password;
            var result = _usersModel.CheckLogin();

            if (result)
            {
                var main = new MainWindow();
                main.Show();
                _loginWindow.Close();
            }
            else
            {
                MessageBox.Show("Your username/password is wrong");
                _loginWindow.txtUsername.Text = "";
                _loginWindow.txtPassword.Password = "";
                _loginWindow.txtUsername.Focus();
            }
        }
        
        
    }
}