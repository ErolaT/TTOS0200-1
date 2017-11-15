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

namespace Autotalli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Muuttuja on käytettävissä kaikissa luokan metodeissa ja tapahtumankäsittelijöissä
        private List<Auto> autot;
        private const string polku = @"D:\K8851\Kuvat\";
        public MainWindow()
        {
            InitializeComponent();
            autot = Talli.HaeAutot();
            NaytaKuva("autotalli.png");
            //Asetetaan comboboxiin kaikki eri automerkit
            //Vaihtoehto 1
            List<string> merkit = new List<string>();
            /*merkit.Add("Audi");
            merkit.Add("Saab");
            merkit.Add("Volvo");*/
            //Vaihtoehto 2, kysytään datasta automerkit
            var result = autot.Select(m => m.Merkki.ToString());
            cmbAutot.ItemsSource = result;
        }

        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {
            //Pyydetään BL-kerrokselta autot ja näytetään ne käyttäjälle
            dgAutot.ItemsSource = autot;
        }

        private void btnHaeAudit_Click(object sender, RoutedEventArgs e)
        {
            var result = autot.Where(m => m.Merkki.Contains("Audi"));
            dgAutot.ItemsSource = result;
        }

        private void NaytaKuva(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    url = "puuttuu.png";
                }
                //Lisätään kuvatiedostojen vakiopolku
                url = polku + url;

                BitmapImage pic = new BitmapImage();

                pic.BeginInit();
                pic.UriSource = new Uri(url);
                pic.EndInit();
                imgAuto.Stretch = Stretch.Fill;
                imgAuto.Source = pic;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Huom, olemme itse populoineet DataGridin Auto-oliolla, joten kukin DataGridin jäsen/alkio on itseasiassa Auto-olio
            object obj = dgAutot.SelectedItem;
            if (obj != null)
            {
                Auto valittu = (Auto)obj;
                NaytaKuva(valittu.URL);
            }
        }

        private void cmbAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Suodatetaan DataGridin näkyviin vain valittu automerkki
            string merkki = cmbAutot.SelectedValue.ToString();

            var result = autot.Where(m => m.Merkki.Contains(merkki));
            dgAutot.ItemsSource = result;
        }
    }
}
