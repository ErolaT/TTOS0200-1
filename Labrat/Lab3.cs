//Toni Erola
//Olio tehtävät

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    public class Lab3
    {
        /*Tehtävä 1 
         * Tee luokka, jolla on seuraavat staattiset metodit:
         * bool OnkoLuku(string syote) ja bool OnkoPvm(string syote) 
         * Metodi OnkoLuku tutkii annetun merkkijonon ja palauttaa true 
         * jos syöte on muunnettavissa luvuksi (kokonaisluku tai desimaaliluku 
         * erottimena pilkku, pistettä ei hyväksytä). Metodi OnkoPvm tutkii 
         * annetun merkkijonon ja palauttaa true jos syöte on suomalaisessa 
         * päivämäärämuodossa siis joko muotoa "pp.kk.vv" tai "pp.kk.vvvv", eli metodi
         * esimerkiksi tunnistaa seuraavat merkkijonot päivämääriksi "1.2.13",
         * "1.10.2017", "12.12.2017", "24.12.17"*/
        public static bool OnkoLuku(string syote)
        {
            bool tulos = false;
            if (double.TryParse(syote, out double apu))
            {
                tulos = true;
                if (syote.Last().ToString().Contains(',') || syote.First().ToString().Contains(','))
                {
                    tulos = false;
                }

            }
            return tulos;
        }
        public static bool OnkoPvm(string syote)
        {
            bool tulos = false;
            string[] formats = { "dd.MM.yy", "dd.MM.yyyy" };
            DateTime paivays;
            if (DateTime.TryParseExact(syote, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out paivays) == true)
            {
                tulos = true;
            }
            return tulos;
        }
    }
    public class TestiPeti
    {
        public static void Testi()
        {
            string s = ",2";
            string a = "+2";
            string b = "2,,";
            string c = "2.0";
            string r = ".2";
            string w = "-2,3";

            Console.WriteLine("Onko {0} luku > {1}", s, Lab3.OnkoLuku(s));
            Console.WriteLine("Onko {0} luku > {1}", a, Lab3.OnkoLuku(a));
            Console.WriteLine("Onko {0} luku > {1}", b, Lab3.OnkoLuku(b));
            Console.WriteLine("Onko {0} luku > {1}", c, Lab3.OnkoLuku(c));
            Console.WriteLine("Onko {0} luku > {1}", r, Lab3.OnkoLuku(r));
            Console.WriteLine("Onko {0} luku > {1}", w, Lab3.OnkoLuku(w));

            Console.WriteLine();

            string pvm1 = "12.12.2001";
            string pvm2 = "28.02.2001";
            string pvm3 = "28/02/2001";
            string pvm4 = "24,12,23";
            string pvm5 = "24.04.17";

            Console.WriteLine("Onko {0} oikeanlainen pvm > {1}", pvm1, Lab3.OnkoPvm(pvm1));
            Console.WriteLine("Onko {0} oikeanlainen pvm > {1}", pvm2, Lab3.OnkoPvm(pvm2));
            Console.WriteLine("Onko {0} oikeanlainen pvm > {1}", pvm3, Lab3.OnkoPvm(pvm3));
            Console.WriteLine("Onko {0} oikeanlainen pvm > {1}", pvm4, Lab3.OnkoPvm(pvm4));
            Console.WriteLine("Onko {0} oikeanlainen pvm > {1}", pvm5, Lab3.OnkoPvm(pvm5));

        }
    }
    /*Tehtävä 2 
     * Tehtävänäsi on ohjelmoida Dynamon hissin kerroksen ohjaukseen 
     * liittyvä säädin. Toteutetun ohjelman tulee pystyä kysymään käyttäjältä 
     * haluttu kerros ja siirtämään hissi haluttuun kerrokseen (tässä 
     * tapauksessa ohjelma kertoo käyttäjälle missä kerroksessa hissi on).
     * Muista, että Dynamon hissi voi olla vain kerroksissa 1-5. 
     * Käytä Hissi-luokassa get- ja set-aksessoreita suojamaan olion tila. */
    public class DynamonHissi
    {
        private int kerros = 1;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Ei pääse niin matalalle");
                }
                else if (value > 5)
                {
                    Console.WriteLine("Ei pääse niin korkealle");
                }
                else
                {
                    this.kerros = value;
                }
            }
        }
    }
    /*Tehtävä 3 
     * Tehtävänäsi on ohjelmoida yksinkertaisen vahvistimen toiminta, 
     * jolla voidaan kontrolloida äänenvoimakkuutta välillä 0-100. 
     * Toteuta Vahvistin-luokka ja tee pääohjelma, jolla luot olion 
     * Vahvistin-luokasta. Säädä ja kokeile vahvistinta eri äänenvoimakkuuksilla.
     * Käytä Vahvistin-luokassa get- ja set-aksessoreita. get-aksessori 
     * palauttaa äänenvoimakkuuden ja set-aksessori rajaa äänenvoimakkuuden 
     * arvoa. */
     public class Vahvistin
    {
        private int ääni = 0;
        public int Äänenvoimakkuus
        {
            get
            {
                return ääni;
            }
            set
            {
                if (value < 0)
                {
                    this.ääni = 0;
                    Console.WriteLine("Äänenvoimakkuus liian matala. Asetettiin > " + this.ääni);
                }
                else if (value > 100)
                {
                    this.ääni = 100;
                    Console.WriteLine("Äänenvoimakkuus liian korkea. Asetettiin > " + this.ääni);
                }
                else
                {
                    this.ääni = value;
                    Console.WriteLine("Vahvistimen äänenvoimakkuus asetettu > " + this.ääni);
                }
            }
        }
    }
}
