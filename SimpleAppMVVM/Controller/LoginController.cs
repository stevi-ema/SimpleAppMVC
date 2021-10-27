using SimpleAppMVVM.Model;
using SimpleAppMVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SimpleAppMVVM.Controller
{
    class LoginController
    {
        private LoginModel model;
        private LoginWindow view;

        public LoginController(LoginWindow view)
        {
            model = new LoginModel();
            this.view = view;
        }

        public void CheckLogin()
        {
            model.CheckLogin(view.txtUsername.Text, view.txtPassword.Password);
            bool hasil = model.GetHasil();
            if (hasil)
            {
                HomeWindow home = new HomeWindow();
                home.Show();
                view.Close();
            }
            else
            {
                MessageBox.Show("Username/Password salah !");
                view.txtUsername.Text = "username";
                view.txtPassword.Password = "password";
                view.txtUsername.Focus();
            }
        }
    }
}
