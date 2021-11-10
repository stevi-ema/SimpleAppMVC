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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleAppMVVM.View
{
    /// <summary>
    /// Interaction logic for KalkulatorPage.xaml
    /// </summary>
    public partial class KalkulatorPage : Page
    {
        //declare object global
        Controller.KalkulatorController kalkulator;

        public KalkulatorPage()
        {
            InitializeComponent();
            //instance -> create object
            kalkulator = new Controller.KalkulatorController(this);
        }

        private void btnTambah_Click(object sender, RoutedEventArgs e)
        {
            kalkulator.Penjumlahan();
        }

        private void btnKurang_Click(object sender, RoutedEventArgs e)
        {
            kalkulator.Pengurangan();
        }

        private void btnKali_Click(object sender, RoutedEventArgs e)
        {
            kalkulator.Perkalian();
        }

        private void btnBagi_Click(object sender, RoutedEventArgs e)
        {
            kalkulator.Pembagian();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtNilai1.Text = "";
            txtNilai2.Text = "";
            lblHasil.Content = 0;
            txtNilai1.Focus();
        }
    }
}
