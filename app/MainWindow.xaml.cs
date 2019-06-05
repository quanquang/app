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

namespace app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Frame.Content = new thuc_don();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new thuc_don();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Content = new don_hang();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Frame.Content = new thong_ke();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Frame.Content = new tai_khoan();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Frame.Content = new khuyen_mai();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Frame.Content = new nhan_vien();
        }
    }
}
