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
    /// Interaction logic for HomeWindow.xaml
    /// Copyright : Stevi Ema Wijayanti
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
            lblCopyright.Content = "Copyright Stevi Ema Wijayanti";
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.NoResize;
        }

        private void lblHome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.HomePage());
        }

        private void lblVolumeBangun_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.BangunRuangPage());
        }

        private void lblKalkulator_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new KalkulatorPage());
        }

        /// Copyright : Stevi Ema Wijayanti

        private void lblKonversiSuhu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new KonversiSuhuPage());
        }

        private void lblPayment_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.PembayaranSppPage());

        }

        private void lblPenggajian_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.PenggajianPage());

        }

        private void lblReservasiHotel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.ReservasiHotelPage());
        }

        /// Copyright : Stevi Ema Wijayanti

        private void lblLogOut_MouseDown(object sender, MouseButtonEventArgs e)
        {
            LoginWindow lObj = new LoginWindow();
            lObj.Show();
            this.Close();
        }
    }
}
/// Copyright : Stevi Ema Wijayanti