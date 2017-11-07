using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Kalat
    {
        public string Laji { get; set; }
        public string Pituus { get; set; }
        public string Paino { get; set; }
        public string Paikka { get; set; }
        public string Alue { get; set; }

        public Kalat(string laji, string pituus, string paino, string paikka, string alue)
        {
            this.Laji = laji;
            this.Pituus = pituus;
            this.Paino = paino;
            this.Paikka = paikka;
            this.Alue = alue;
        }
        public override string ToString()
        {
            return "Kala: " + Laji + " " + Pituus + " cm " + Paino + " kg\nPaikka: " + Paikka + "\nAlue: " + Alue;
        }
    }
    public class Kalastaja
    {
        public List<Kalat> kalat;
        public string Nimi { get; set; }
        public string PuhNro { get; set; }
        

        public Kalastaja(string nimi, string nro)
        {
            this.Nimi = nimi;
            this.PuhNro = nro;
            kalat = new List<Kalat>();
        }

        public void TulostaTiedot()
        {
            try
            {
                Console.WriteLine("Kalastaja {0} saaliit:\n", Nimi);
                for (int i = 0; i < kalat.Count; i++)
                {
                    Console.WriteLine(kalat[i].ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void TulostaKg()
        {
            try
            {
                var järjestys = kalat.OrderByDescending(x => x.Paino).ToList();
                Console.WriteLine("Kalastaja {0} saaliit painon mukaan:\n", Nimi);
                for (int i = 0; i < järjestys.Count; i++)
                {
                    Console.WriteLine(järjestys[i].ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override string ToString()
        {
            return "Kalastaja: " + Nimi + " Puhelin " + PuhNro;
        }
    }
}
