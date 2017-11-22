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

namespace Ostokset
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

        private void btnOsta_Click(object sender, RoutedEventArgs e)
        {
            txbKori.Text = "";
            List<string> lista = new List<string>();
            if ((bool)cbx1.IsChecked)
            {
                lista.Add(cbx1.Content.ToString());
            }
            if ((bool)cbx2.IsChecked)
            {
                lista.Add(cbx2.Content.ToString());
            }
            if ((bool)cbx3.IsChecked)
            {
               lista.Add(cbx3.Content.ToString());
            }
            if ((bool)cbx4.IsChecked)
            {
                lista.Add(cbx4.Content.ToString());
            }
            if ((bool)cbx5.IsChecked)
            {
                lista.Add(cbx5.Content.ToString());
            }
            foreach (string l in lista)
            {
                txbKori.Text += l + ", ";
            }
        }
    }
}
