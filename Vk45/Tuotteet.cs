using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Tuotteet
    {
        public string Nimi { get; set; }
        public double Hinta { get; set; }

        public Tuotteet(string nimi, double hinta)
        {
            this.Nimi = nimi;
            this.Hinta = hinta;
        }
        public override string ToString()
        {
            return "Tuote: " + Nimi + " " + Hinta + "€";
        }
    }
    public class Testaa
    {
        public static void TestaaTuote()
        {
            try
            {
                List<Tuotteet> tuotteet = new List<Tuotteet>();

                tuotteet.Add(new Tuotteet("Maitua", 1.4));
                tuotteet.Add(new Tuotteet("Olutta", 2.2));
                tuotteet.Add(new Tuotteet("Makkaraa", 3.2));
                tuotteet.Add(new Tuotteet("Koskenkorvaa", 4.2));

                Console.WriteLine("Tuotteet");
                for (int i = 0; i < tuotteet.Count; i++)
                {
                    Console.WriteLine(tuotteet[i].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
