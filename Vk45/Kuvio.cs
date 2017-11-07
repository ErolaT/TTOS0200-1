using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public abstract class Kuvio
    {
        public string Nimi { get; set; }
        public Kuvio()
        {

        }
        public Kuvio(string nimi)
        {
            Nimi = nimi;
        }
        public abstract double Pintaala();
        public abstract double Ympärysmitta();
    }
    public class Ympyrä : Kuvio
    {
        public double Säde { get; set; }

        public Ympyrä(string nimi, double säde) : base(nimi)
        {
            Säde = säde;
        }
        public override double Pintaala()
        {
            double tulos = Math.PI * (Math.Pow(Säde, 2));
            tulos = Math.Round(tulos, 2);
            return tulos;
        }
        public override double Ympärysmitta()
        {
            double tulos = 2 * Math.PI * Säde;
            tulos = Math.Round(tulos, 2);
            return tulos;
        }
        public override string ToString()
        {
            string s = string.Format("{0} Säde: {1} Pinta-ala: {2} Ympärysmitta {3}\n", Nimi, Säde, Pintaala(), Ympärysmitta());
            return s;
        }
    }
    public class Suorakulmio : Kuvio
    {
        public double Leveys { get; set; }
        public double Korkeus { get; set; }

        public Suorakulmio(string nimi, double leveys, double korkeus) : base(nimi)
        {
            Leveys = leveys;
            Korkeus = korkeus;
        }
        public override double Pintaala()
        {
            double tulos = Leveys * Korkeus;
            return tulos;
        }
        public override double Ympärysmitta()
        {
            double tulos = (Leveys * 2) + (Korkeus * 2);
            return tulos;
        }
        public override string ToString()
        {
            string s = string.Format("{0} Leveys: {1} Korkeus: {2} Pinta-ala: {3} Ympärysmitta {4}\n", Nimi, Leveys, Korkeus, Pintaala(), Ympärysmitta());
            return s;
        }
    }
    public class Kuviot
    {
        public List<Kuvio> shapes;

        public Kuviot()
        {
            shapes = new List<Kuvio>();
        }

        public override string ToString()
        {
            string lista = "";
            foreach (Kuvio s in shapes)
            {
                lista += s.ToString();
            }
            return lista;
        }
    }
}
