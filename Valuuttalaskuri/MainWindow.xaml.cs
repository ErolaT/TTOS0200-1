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

namespace Valuuttalaskuri
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


        private void txtLuku_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double euro;
                double dol;
                if (cmbOstan.Text == usd.Content.ToString())
                {
                    txbValuuttatiedot1.Text = usd.Content + " myyntikurssi 0.8997";
                    txbValuutta.Text = eur.Content.ToString();
                    if (double.TryParse(txtLuku.Text, out dol))
                    {
                        euro = dol * 0.8997;
                        txbMaksan.Text = euro.ToString("0.00");
                        txbValuuttatiedot2.Text = dol.ToString() + " euroa on vastaa " + (dol / 0.8997).ToString("0.00") + " USD";
                    }
                    else
                    {
                        txbMaksan.Text = "Syötä numeroja";
                    }
                }
                else
                {
                    txbValuuttatiedot1.Text = eur.Content + " myyntikurssi 1.1115";
                    txbValuutta.Text = usd.Content.ToString();
                    if (double.TryParse(txtLuku.Text, out euro))
                    {
                        dol = euro * 1.1115;
                        txbMaksan.Text = dol.ToString("0.00");
                        txbValuuttatiedot2.Text = euro.ToString() + " USD vastaa " + (euro / 1.1115).ToString("0.00") + " euroa";
                    }
                    else
                    {
                        txbMaksan.Text = "Syötä numeroja";
                    }
                }
            }
            catch (Exception ex)
            {
                txbMaksan.Text = ex.Message;
            }
        }
    }
}
