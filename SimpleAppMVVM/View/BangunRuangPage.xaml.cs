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
    /// Interaction logic for BangunRuangPage.xaml
    /// </summary>
    public partial class BangunRuangPage : Page
    {
        public BangunRuangPage()
        {
            InitializeComponent();
        }

        private void rdbBalok_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rdbTabung_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rdbPrismaSegitiga_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rdbKerucut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHitung_Click(object sender, RoutedEventArgs e)
        {
            //instance -> create object
            Controller.BangunRuangController bangunRuang = new 
                Controller.BangunRuangController(this)
            
            //output
            if(rdbBalok.IsChecked == true)
            {
                bangunRuang.VolumeBalok();
            }
            else if(rdbTabung.IsChecked == true)
            {
                //lblHasil.Content = bangunRuang.Tabung();
            }
            else if (rdbPrismaSegitiga.IsChecked == true)
            {
                //lblHasil.Content = bangunRuang.PrismaSegitiga();
            }
            else
            {
                //lblHasil.Content = bangunRuang.Kerucut();
            }
        }
    }
}
