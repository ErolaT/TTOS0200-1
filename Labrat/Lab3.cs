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
    /*Tehtävä 4 Ohjelmassa tulee pystyä käsittelemään työntekijöiden tietoja (Employee).
        * Työntekijöiden osalta seuraavia tietoa pitää pystyä käsittelemään: työntekijän nimi
        * (Name), työntekijän ammatti (Profession) ja palkka (Salary). Samassa ohjelmassa 
        * pitää pystyä käsittelemään myös johtajien tietoja (Boss), heillä on edellisten 
        * lisäksi myös auto (Car) ja palkkabonus (Bonus).*/
    public class Työntekijä
    {
        public string Nimi { get; set; }
        public string Ammatti { get; set; }
        public string Palkka { get; set; }
        public Työntekijä()
        {

        }

        public Työntekijä(string nimi, string ammatti, string palkka) 
        {
            this.Nimi = nimi;
            this.Ammatti = ammatti;
            this.Palkka = palkka;
        }

        public override string ToString()
        {
            return "Nimi: " + Nimi + " Ammatti: " + Ammatti + " Palkka:" + Palkka;
        }
    }
    public class Pomo : Työntekijä
    {
        public string Auto { get; set; }
        public string Bonus { get; set; }
        public Pomo()
        {

        }

        public Pomo(string nimi, string ammatti, string palkka, string auto, string bonus) : base(nimi, ammatti, palkka)
        {
            this.Auto = auto;
            this.Bonus = bonus;
        }

        public override string ToString()
        {
            return base.ToString() + " Auto: " + Auto + " Bonus: " + Bonus;
        }
    }
    /*Tehtävä 5 Toteutettavassa sovelluksessa tulisi pysyä käsittelemään 
     * erilaisia kulkuneuvoja. Kaikilla kulkuneuvoilla on löydettävissä 
     * yhteisinä ominaisuuksina: nimi, malli, vuosimalli ja väri. 
     * Erikoistapauksina pitää pystyä käsittelemään polkupyöriä ja veneitä. 
     * Polkupyörän osalta pitää pystyä erottelemaan se, että onko kyseessä 
     * vaihdepyörä vai ei sekä mahdollisen vaihteiston mallinimi. Veneiden 
     * osalta tietoina pitää ainakin olla veneen tyyppi (soutuvene, 
     * moottorivene, kajakki, ...) ja kuinka monta istuinpaikkaa veneestä 
     * löytyy. */
    public class Kulkuneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public string Vuosimalli { get; set; }
        public string Väri { get; set; }

        public Kulkuneuvo()
        {

        }
        
        public override string ToString()
        {
            return "Nimi: " + Nimi + " Malli: " + Malli + " Vuosimalli: " + Vuosimalli + " Väri: " + Väri;
        }
    }
    public class Polkupyörä : Kulkuneuvo
    {
        public bool Vaihteet { get; set; }
        public string VaihdeMalli { get; set; }

        public Polkupyörä()
        {

        }
        public override string ToString()
        {
            return base.ToString() + " Vaihteet: " + Vaihteet + " Vaihteiden malli: " + VaihdeMalli;
        }
    }
    public class Vene : Kulkuneuvo
    {
        public string Tyyppi { get; set; }
        private int paikat = 2;
        public int Paikat
        {
            get { return paikat; }
            set
            {
                this.paikat = value;
                if (paikat < 0)
                {
                    this.paikat = 2;
                }
            }
        }

        public Vene()
        {

        }

        public override string ToString()
        {
            return base.ToString() + " Paikkoja: " + paikat + " kpl Tyyppi: " + Tyyppi;
        }
    }
    /*Tehtävä 6 Kannettavassa radiossa on vain kolme säädintä: päälle/pois-kytkin,
     * äänen voimakkuuden säädin (arvot 0, 1, 2,..., 9) ja kuunneltavan kanavan 
     * taajuusvalinta (2000.0 - 26000.0). Laadi luokka kannettavan radion toteutukseksi.
     * Käytä tekemääsi luokkaa pääohjelmasta käsin, eli testaile radion toimivuutta 
     * erilaisilla voimakkuuden ja taajuuden arvoilla. Jätä asetus- ja tulostuslauseet 
     * näkyville pääohjelmaan, jotta radio-olion käyttö voidaan todentaa.*/
    public class Radio
    {
        private readonly int äänimax = 9;
        private readonly int äänimin = 0;
        public bool Virta { get; set; }
        private int ääni;
        public int Äänenvoimakkuus
        {
            get { return ääni; }
            set
            {
                this.ääni = value;
                if (ääni < äänimin)
                {
                    this.ääni = äänimin;
                }
                else if (ääni > äänimax)
                {
                    this.ääni = äänimax;
                }
            }
        }
        private string taajuus;
        public string Taajuus
        {
            get { return taajuus; }
            set
            {
                this.taajuus = value;
                double.TryParse(taajuus, out double apu);
                if (apu < 2000)
                {
                    taajuus = "2000,0";
                }
                else if (apu > 26000)
                {
                    taajuus = "26000,0";
                }
            }
        }
        public Radio()
        {

        }
        public override string ToString()
        {
            return "Virta: " + Virta + " Äänenvoimakkuus: " + ääni + " Taajuus: " + taajuus;
        }
    }
    /*Tehtävä 7 ICT-opiskelijan kirjahyllystä löytyy vaikka mitä erilaisia 
     * tavaroita: kirjoja, lehtiä, cd-levyjä, dvd-levyjä, bluray-levyjä, 
     * puhelimia, tabletteja, läppäreitä, ... jne. Pohdi UML-kaaviota käyttäen 
     * millaisia luokkarakenteita (ainakin luokkien ja ominaisuuksien osalta) 
     * esiintyy ja käytä apua perintää, jos tavaroille löytyy yhteisiä 
     * ominaisuuksia. Toteuta tämän jälkeen muutamia luokkia, joissa perintää 
     * esiintyy. Tee myös pääohjelma, jossa käytät tekemiäsi luokkia ja luot 
     * olioita.  */
    public class Kirjahylly
    {
        public string Tavara { get; set; }
        public string Nimi { get; set; }

        public Kirjahylly()
        {
        }

        public override string ToString()
        {
            return "Mikä: " + Tavara + " Nimi: " + Nimi;
        }
    }
    public class Levy : Kirjahylly
    {
        public string Albumi { get; set; }
        private int vuosi;
        public int Vuosi
        {
            get { return vuosi; }
            set
            {
                this.vuosi = value;
                if (vuosi < 0)
                {
                    this.vuosi = 0;
                }
            }
        }

        public Levy()
        {
        }

        public override string ToString()
        {
            return base.ToString() + " Albumi: " + Albumi + " Vuosi: " + vuosi;
        }
    }
    public class Kirja : Kirjahylly
    {
        public string Valmistaja { get; set; }

        public Kirja()
        {
        }

        public override string ToString()
        {
            return base.ToString() + " Valmistaja: " + Valmistaja;
        }
    }
    public class Elokuva : Kirjahylly
    {
        public string Genre { get; set; }
        private int kesto;
        public int Kesto
        {
            get { return kesto; }
            set
            {
                this.kesto = value;
                if (kesto < 0)
                {
                    this.kesto = 0;
                }
            }
        }

        public Elokuva()
        {
        }

        public override string ToString()
        {
            return base.ToString() + " Genre: " + Genre + " Kesto: " + kesto + " minuuttia";
        }
    }
    /*Tehtävä 8 Pohdi jokin reaalimaailman asia, jonka kautta voit toteuttaa
     * pienimuotoisen C#-ohjelman/toteutuksen, joka käyttää perintää. */
     public class Tili
    {
        public string TiliNro { get; set; }
        private int Saldo { get; set; }

        public Tili(string numero)
        {
            this.TiliNro = numero;
            this.Saldo = 0;
        }
        public Tili(string numero, int saldo)
        {
            this.TiliNro = numero;
            this.Saldo = saldo;
        }

        public int TulostaSaldo()
        {
            return Saldo;
        }
        public void LisääRahaa(int raha) 
        {
            if (raha > 0)
            {
                this.Saldo += raha;
            }
        }
        public void NostaRahaa(int raha)
        {
            if (!(this.Saldo < 0))
            {
                this.Saldo -= raha;
            }
            else
            {
                Console.WriteLine("Rahaa ei ole tarpeeksi");
            }
        }
        public override string ToString()
        {
            return "Tilinumero: " + TiliNro + " Tilin saldo: " + Saldo;
        }
    }
    public class LuottoTili : Tili
    {
        public int Luotto { get; set; }
        private int Velka = 0;
        private int Luottomax;

        public LuottoTili(string numero, int saldo, int luotto) : base(numero, saldo)
        {
            this.Luotto = luotto;
            this.Luottomax = luotto;
        }

        public void MaksaLuotolta(int raha)
        {
            if (!((Luottomax - raha) < 0) && !(Luotto < 0) && raha > 0)
            {
                this.Luotto -= raha;
                this.Velka += raha;
            }
        }
        public void TulostaVelka()
        {
            this.Velka = Luotto - Luottomax;
            Console.WriteLine("Velkasaldo > " + Velka);
        }
        public void MaksaVelka()
        {
            while (true)
            {
                Console.WriteLine("Velkasaldon maksu, velkaa jäljellä > " + Velka + " Paljonko haluat maksaa?");
                int apu = int.Parse(Console.ReadLine());
                if (apu == this.Velka)
                {
                    this.Velka = 0;
                    this.Luotto = this.Luottomax;
                    break;
                }
                else if (apu > this.Velka)
                {
                    Console.WriteLine("Ei voida maksaa");
                }
                else
                {
                    this.Velka = this.Velka - apu;
                    this.Luotto = this.Luotto + apu;
                    break;
                }   
            }
        }
        public override string ToString()
        {
            return base.ToString() + " Luoton määrä: " + Luotto + " Velan määrä: " + Velka;
        }
    }
}
