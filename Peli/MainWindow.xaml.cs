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

namespace Peli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> pelit = new List<string>();
            pelit.Add("Lotto");
            pelit.Add("Viking Lotto");
            pelit.Add("Eurojackpot");

            cbxPeli.ItemsSource = pelit;
        }

        private void btnArvo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cbxPeli.SelectedItem != null)
                {
                    txbTulos.Text = Lotto.Arvonta(cbxPeli.SelectedItem.ToString(), int.Parse(txbRivit.Text));
                }
                else
                {
                    txbTulos.Text = "Valitse peli ensin";
                }
            }
            catch (Exception ex)
            {

                txbTulos.Text = ex.Message;
            }
        }

        private void btnTyhjennä_Click(object sender, RoutedEventArgs e)
        {
            txbTulos.Text = "";
        }
    }
}
