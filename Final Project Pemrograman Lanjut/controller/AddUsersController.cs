using System.Windows;
using Final_Project_Pemrograman_Lanjut.model;
using Final_Project_Pemrograman_Lanjut.view;

namespace Final_Project_Pemrograman_Lanjut.controller
{
    public class AddUsersController
    {
        private RegisterWindow _registerWindow;
        private UsersModel _usersModel;

        public AddUsersController(RegisterWindow registerWindow)
        {
            _registerWindow = registerWindow;
            _usersModel = new UsersModel();
        }

        public void Register()
        {
            _usersModel.nama = _registerWindow.txtUsername.Text;
            _usersModel.password = _registerWindow.txtPassword.Password;
            var result = _usersModel.AddUsers();
            if (result)
            {
                MessageBox.Show("pembuatan akun berhasil silahkan Login");
                var loginWindow = new LoginWindow();
                loginWindow.Show();
                _registerWindow.Close();
            }
            else
            {
                MessageBox.Show("Registrasi Gagal!!!");
            }
        }
    }
}