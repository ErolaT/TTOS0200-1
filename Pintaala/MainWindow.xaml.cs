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

namespace Pintaala
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int l;
                int h;
                int w;
                txbVirhe.Text = "";
                if (int.TryParse(txtLeveys.Text, out l) && int.TryParse(txtKorkeus.Text, out h))
                {
                    if (txtKarmi.Text == "")
                    {
                        w = 45;
                    }
                    else
                    {
                        w = int.Parse(txtKarmi.Text);
                    }
                    if (l >= 300 && l <= 3000 && h >= 300 && h <= 3000)
                    {
                        Laske(l, h, w);
                    }
                    else
                    {
                        txbVirhe.Text = "Korkeus tai leveys on liian suuri.";
                        txbPA.Text = "";
                        txbLPA.Text = "";
                        txbKP.Text = "";
                    }
                }
                else
                {
                    txbPA.Text = "Jotain meni väärin";
                }

            }
            catch (Exception ex)
            {

                txbVirhe.Text = ex.Message;
            }
        }
        public void Laske(int l, int h, int w)
        {
            try
            {
                int pa = (l * h) / 10;
                int lpa = ((l - (w * 2)) * (h - (w * 2))) / 10;
                int kpiiri = ((l * 2) + (h * 2)) / 10;
                txbPA.Text = pa.ToString() + " cm^2";
                txbLPA.Text = lpa.ToString() + " cm^2";
                txbKP.Text = kpiiri.ToString() + " cm";
                ikkuna.Width = l / 10;
                ikkuna.Height = h / 10;
                ikkuna.StrokeThickness = w / 10;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
