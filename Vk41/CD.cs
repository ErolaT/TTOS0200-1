using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.MiniASIO
{
    public class CD
    {
        public string Artisti { get; set; }
        public string Albumi { get; set; }
        private List<Kappale> kappaleet;

        public CD(string artisti, string albumi)
        {
            kappaleet = new List<Kappale>();
            this.Artisti = artisti;
            this.Albumi = albumi;
        }

        public void LisaaKappale(Kappale kappale)
        {
            kappaleet.Add(kappale);
        }
        public override string ToString()
        {
            string teksti = "CD data:\nArtisti: " + Artisti + "\nAlbumi: " + Albumi;
            for (int i = 0; i < kappaleet.Count; i++)
            { 
                teksti += kappaleet[i].ToString();
            }
            return teksti;
        }
    }
    public class Kappale
    {
        public string Nimi { get; set; }
        public string Kesto { get; set; }

        public Kappale(string nimi, string kesto)
        {
            this.Nimi = nimi;
            this.Kesto = kesto;
        }

        public override string ToString()
        {
            return "\n   -" + Nimi + ", " + Kesto;
        }
    }
}
