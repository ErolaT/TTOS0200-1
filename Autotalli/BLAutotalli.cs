using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotalli
{
    public class Talli
    {
        public static List<Auto> HaeAutot()
        {
            List<Auto> autot = new List<Auto>();
            //GUIn testaamista varten keksitään muutama auto
            Auto a = new Auto();

            a.Merkki = "Volvo";
            a.Malli = "V70";
            a.VM = 2007;
            a.KM = 100000;
            a.Hinta = 19900;
            a.URL = "VolvoV70.png";
            autot.Add(a);

            Auto b = new Auto() { Merkki = "Audi", Malli="A4", VM = 2017, KM = 1000, Hinta = 39900, URL = "AudiA4.png" };
            autot.Add(b);
            Auto r = new Auto() { Merkki = "Renault", Malli = "Zoe", VM = 1800, KM = 1400, Hinta = 12344, URL = "Renault.PNG" };
            autot.Add(r);
            Auto c = new Auto() { Merkki = "Saab", Malli = "99", VM = 2000, KM = 100000, Hinta = 900 };
            autot.Add(c);

            return autot;
        }

        internal class App
        {
            internal void Run()
            {
                throw new NotImplementedException();
            }

            internal void InitializeComponent()
            {
                throw new NotImplementedException();
            }
        }
    }
    public class Auto
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public int VM { get; set; }
        public int KM { get; set; }
        public float Hinta { get; set; }
        public string URL { get; set; }
    }
}
