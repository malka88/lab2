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

namespace _1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int x, y;

        private void A_TextChanged(object sender, TextChangedEventArgs e)
        {
            x = int.Parse(A.Text);
        }

        private void B_TextChanged(object sender, TextChangedEventArgs e)
        {
            y = int.Parse(B.Text);
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            label.Content = x + y;
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            label.Content = x - y;
        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            label.Content = x * y;
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            label.Content = x / y;
        }

    }
}
