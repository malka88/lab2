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

namespace _4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer Timer;

        public MainWindow()
        {
            InitializeComponent();
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Tick += new EventHandler(dispatcherTimer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void startb_Click(object sender, RoutedEventArgs e)
        {
            Timer.Start();
        }

        private void stopb_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
        }

        private void clearb_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            sl.Content = "";
            ml.Content = "";
            hl.Content = "";
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (sch.IsChecked == true)
            {
                sl.Content = DateTime.Now.Second;
            }
            else
            {
                sl.Content = "";
            }

            if (mch.IsChecked == true)
            {
                ml.Content = DateTime.Now.Minute;
            }
            else
            {
                ml.Content = "";
            }

            if (hch.IsChecked == true)
            {
                hl.Content = DateTime.Now.Hour;
            }
            else
            {
                hl.Content = "";
            }
        }


        private void hch_Checked(object sender, RoutedEventArgs e)
        {


        }

        private void mch_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void sch_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
