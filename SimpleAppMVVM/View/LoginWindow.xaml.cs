using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SimpleAppMVVM.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// Copyright : Stevi Ema Wijayanti
    /// </summary>
    public partial class LoginWindow : Window
    {
        
        public LoginWindow()
        {
            InitializeComponent();
            lblCopyright.Content = "Copyright Stevi Ema Wijayanti";
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.NoResize;
            txtUsername.Focus();
        }


        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPassword.Password = "";
        }

        // Copyright : Stevi Ema Wijayanti
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //instance
            Controller.LoginController login = new Controller.LoginController(this);
            //response
            login.ValidasiLogin();
            if (login.pesan != "")
            {
                MessageBox.Show(login.pesan);
            }
        }

        private void txtUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            txtUsername.SelectionStart = 0;
            txtUsername.SelectionLength = txtUsername.Text.Length;
        }
    }
}
// Copyright : Stevi Ema Wijayanti
