using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    /*Tehtävä 1 
     * Tee Rengas-luokka, jolla on seuraavat ominaisuudet:
     * merkki, tyyppi ja rengaskoko.*/
    public class Lab4
    {
        public string Merkki { get; set; }
        public string Tyyppi { get; set; }
        private int rengas;
        public int Rengaskoko
        {
            get { return rengas; }
            set
            {
                if (value > 0)
                {
                    rengas = value;
                }
                else
                {
                    rengas = 17;
                }
            }
        }

        public Lab4(string merkki, string tyyppi, int koko)
        {
            Merkki = merkki;
            Tyyppi = tyyppi;
            Rengaskoko = koko;
        }

        public override string ToString()
        {
            return "Merkki > " + Merkki + " Tyyppi > " + Tyyppi + " Rengaskoko > " + Rengaskoko;
        }
    }

    public class Ajoneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        private List<Lab4> renkaat;

        public Ajoneuvo(string nimi, string malli)
        {
            Nimi = nimi;
            Malli = malli;
            renkaat = new List<Lab4>();
        }

        public void LisääRenkaat(Lab4 rengas)
        {
            renkaat.Add(rengas);
        }

        public override string ToString()
        {
            string tuloste = "Nimi > " + Nimi + " Malli > " + Malli + "\nRenkaat:\n";

            foreach (Lab4 i in renkaat)
            {
                tuloste += i.ToString() + "\n";
            }

            return tuloste;
        }
    }
}
