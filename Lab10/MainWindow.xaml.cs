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

namespace Lab10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void truck_Click(object sender, RoutedEventArgs e)
        {
            int i = int.Parse(txbTruck.Text) + 1;

            txbTruck.Text = i.ToString();
        }

        private void car_Click(object sender, RoutedEventArgs e)
        {
            int i = int.Parse(txbCar.Text) + 1;

            txbCar.Text = i.ToString();
        }
    }
}
