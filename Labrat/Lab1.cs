// Toni Erola
// Olio tehtävät

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab1
    {
        /*Tehtävä 1
             * Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana
             * (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun,
             * tulee näytölle tulostaa teksti: "joku muu luku".*/
        public class Teht1
        {
            public static void KysyLuku()
            {
                Console.Write("Anna luku > ");
                int luku = int.Parse(Console.ReadLine());

                if (luku == 1)
                {
                    Console.WriteLine("Annoit luvun yksi");
                }
                else if (luku == 2)
                {
                    Console.WriteLine("Annoit luvun kaksi");
                }
                else if (luku == 3)
                {
                    Console.WriteLine("Annoit luvun kolme");
                }
                else
                {
                    Console.WriteLine("Joku muu luku");
                }
            }
        }

        /*Tehtävä 2 
             * Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan*/
        public class Teht2
        {
            public static void Koulunumero()
            {
                Console.Write("Anna pistemäärä > ");
                int numero = int.Parse(Console.ReadLine());

                if (numero >= 0 && numero < 2)
                {
                    Console.WriteLine("Koulunumero on 0");
                }
                else if (numero > 1 && numero < 4)
                {
                    Console.WriteLine("Koulunumero on 1");
                }
                else if (numero > 3 && numero < 6)
                {
                    Console.WriteLine("Koulunumero on 2");
                }
                else if (numero > 5 && numero < 8)
                {
                    Console.WriteLine("Koulunumero on 3");
                }
                else if (numero > 7 && numero < 10)
                {
                    Console.WriteLine("Koulunumero on 4");
                }
                else if (numero > 9 && numero < 13)
                {
                    Console.WriteLine("Koulunumero on 5");
                }
                else
                {
                    Console.WriteLine("Ei täsmää taulukon kanssa");
                }
            }
        }

        /*Tehtävä 3 
             * Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.*/
        public class Teht3
        {
            public static void SummaJaKa()
            {
                int summa = 0;
                int luku = 0;
                double keskiarvo = 0;

                Console.WriteLine("Anna kolme lukua ");

                for (int i = 0; i < 3; i++)
                {
                    luku = int.Parse(Console.ReadLine());
                    summa = summa + luku;
                }

                keskiarvo = (double)summa / 3;
                Console.WriteLine("Lukujen summa on " + summa);
                Console.WriteLine("Lukujen keskiarvo on " + keskiarvo);
            }
        }

        /*Tehtävä 4 
             * Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen",
             * jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori". */
        public class Teht4
        {
            public static void KysyIka()
            {
                Console.Write("Anna käyttäjän ikä > ");
                int ikä = int.Parse(Console.ReadLine());

                if (ikä < 18)
                {
                    Console.WriteLine("Alaikäinen");
                }
                else if (ikä >= 18 && ikä <= 65)
                {
                    Console.WriteLine("Aikuinen");
                }
                else
                {
                    Console.WriteLine("Seniori");
                }
            }
        }

        /*Tehtävä 5 
             * Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina.
             * Aikamääre sekuntteina kysytään käyttäjältä.*/
        public class Teht5
        {
            public static void Aikamaare()
            {
                Console.Write("Anna sekunnit > ");
                int luku = int.Parse(Console.ReadLine());

                int tunnit = luku / 3600;
                int minuutit = (luku % 3600) / 60;
                int sekunnit = (luku % 3600) % 60;

                Console.WriteLine("Antamasi sekuntimäärä on " + tunnit + " tuntia, " + minuutit + " minuuttia ja " + sekunnit + " sekuntia");
            }
        }

        /*Tehtävä 6 
             * Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.
             * Tee ohjelma, joka tulostaa ajetulla matkalla(kysytään käyttäjältä) kuluvan bensan
             * määrän sekä bensaan menevän rahan määrän. */
        public class Teht6
        {
            public static void Kulutus()
            {
                double kulutus = 7.02;
                double litrahinta = 1.595;

                Console.Write("Anna matka > ");
                double matka = double.Parse(Console.ReadLine());

                double matkakulutus = (double)kulutus * (matka / 100);
                double matkahinta = (double)matkakulutus * litrahinta;

                Console.WriteLine("Bensaa kuluu " + matkakulutus + " litraa, kustannus " + matkahinta + " euroa.");
            }
        }

        /*Tehtävä 7 
             * Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä. */
        public class Teht7
        {
            public static void TarkistaKarkaus()
            {
                Console.Write("Anna vuosi > ");
                int vuosi = int.Parse(Console.ReadLine());

                if (vuosi % 4 == 0)
                {
                    if (vuosi % 100 == 0)
                    {
                        if (vuosi % 400 == 0)
                        {
                            Console.WriteLine(vuosi + " on karkausvuosi");
                        }
                        else
                        {
                            Console.WriteLine(vuosi + " ei ole karkausvuosi");
                        }
                    }
                    else
                    {
                        Console.WriteLine(vuosi + " on karkausvuosi");
                    }
                }
                else
                {
                    Console.WriteLine(vuosi + " ei ole karkausvuosi");
                }
            }
        }

        /*Tehtävä 8 
             * Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman. */
        public class Teht8
        {
            public static void SuurinLuku()
            {
                Console.Write("Anna luku > ");
                int luku1 = int.Parse(Console.ReadLine());
                Console.Write("Anna luku > ");
                int luku2 = int.Parse(Console.ReadLine());
                Console.Write("Anna luku > ");
                int luku3 = int.Parse(Console.ReadLine());

                if (luku1 > luku2 && luku1 > luku3)
                {
                    Console.WriteLine("Suurin luku on " + luku1);
                }
                else if (luku2 > luku1 && luku2 > luku3)
                {
                    Console.WriteLine("Suurin luku on " + luku2);
                }
                else if (luku3 > luku2 && luku3 > luku1)
                {
                    Console.WriteLine("Suurin luku on " + luku3);
                }
            }
        }

        /*Tehtävä 9 
             * Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0.
             * Ohjelman tulee tulostaa syötettyjen lukujen summa.*/
        public class Teht9
        {
            public static void Lukuja()
            {
                int luku = 0;
                int summa = 0;
                while (true)
                {
                    Console.Write("Anna luku > ");
                    luku = int.Parse(Console.ReadLine());

                    if (luku == 0)
                    {
                        break;
                    }
                    summa = summa + luku;
                }
                Console.WriteLine("Lukujen summa on " + summa);
            }
        }

        /*Tehtävä 10 
             * Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100].
             * Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen. */
        public class Teht10
        {
            public static void Jarjestys()
            {
                int[] luvut = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

                for (int i = 0; i < luvut.Length; i++)
                {
                    Console.Write(luvut[i]);
                    if (luvut[i] % 2 == 0)
                    {
                        Console.Write(" HEP");
                    }
                    Console.WriteLine();
                }
            }
        }

        /*Tehtävä 11 
             * Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
             -----------
             *
             **
             ***
             ****
             ***** 
             ---------*/
        public class Teht11
        {
            public static void Kuvio()
            {
                Console.Write("Monta tähteä? > ");
                int luku = int.Parse(Console.ReadLine());

                for (int i = 0; i < luku; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

        /*Tehtävä 12 
             * Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon.
             * Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.*/
        public class Teht12
        {
            public static void LuvutTaulukkoon()
            {
                int[] luvut = new int[5];

                for (int i = 0; i < luvut.Length; i++)
                {
                    Console.Write("Anna luku > ");
                    luvut[i] = int.Parse(Console.ReadLine());
                }
                Array.Reverse(luvut);

                Console.WriteLine("Luvut ovat {0}", string.Join(", ", luvut));
            }
        }

        /*Tehtävä 13 
             * Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma, joka kysyy
             * arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten,
             * että summasta on vähennetty pois pienin ja suurin tyylipiste.*/
        public class Teht13
        {
            public static void MakihyppyArvostelu()
            {
                int[] luvut = new int[5];

                int summa = 0;

                for (int i = 0; i < luvut.Length; i++)
                {
                    Console.Write("Anna pisteet > ");
                    luvut[i] = int.Parse(Console.ReadLine());
                    summa = summa + luvut[i];
                }

                summa = summa - (luvut.Max() + luvut.Min());
                Console.WriteLine("Kokonaispisteet ovat {0}", summa);
            }
        }

        /*Tehtävä 14 
             * Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden
             * arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon).*/
        public class Teht14
        {
            public static void Numerot()
            {
                List<int> luvut = new List<int>();

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Anna arvosana > ");
                    int luku = int.Parse(Console.ReadLine());
                    luvut.Add(luku);
                }

                Console.WriteLine("Arvosanat:");

                for (int i = 0; i <= 5; i++)
                {
                    Console.Write(i + ":");
                    for (int j = 0; j < luvut.Count; j++)
                    {
                        if (luvut[j] == i)
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        /*Tehtävä 15
             * Tee ohjelma, joka tulostaa seuraavanlaisen kuvion. Kysy käyttäjältä
             * puunkorkeus käytä juurena kaksi korkeuden yksikkö.*/
        public class Teht15
        {
            public static void Kuusi()
            {
                Console.Write("Anna luku > ");
                int luku = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int puu = luku - 2;
                int apu = 1;

                for (int i = 1; i <= puu;)
                {
                    for (int j = 1; j <= (puu - 1); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int n = 1; n <= apu; n++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    apu = apu + 2;
                    puu--;
                }
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < (luku - 3); j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        /*Tehtävä 16 
             * Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa. 
             * Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. Ohjelman tulee
             * antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi. Tämän jälkeen
             * vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. Tulosta lopuksi arvausten määrä näytölle.*/
        public class Teht16
        {
            public static void Random()
            {
                Random rnd = new Random();

                int numero = rnd.Next(1, 101);
                int arvaus = 0;

                while (true)
                {
                    Console.Write("Arvaa luku > ");
                    int luku = int.Parse(Console.ReadLine());
                    arvaus++;

                    if (luku < numero)
                    {
                        Console.WriteLine("Luku on suurempi");
                    }
                    else if (luku > numero)
                    {
                        Console.WriteLine("Luku on pienempi");
                    }
                    else
                    {
                        Console.WriteLine("Hienoa, arvasit luvun " + arvaus + " kerralla.");
                        break;
                    }
                }
            }
        }

        /*Tehtävä 17 Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa 
             * olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon. 
             * Tulosta lopuksi lajitellun taulukon sisältö.*/
        public class Teht17
        {
            public static void LuvutYhteen()
            {
                int[] numerot1 = new int[5] { 10, 20, 30, 40, 50 };
                int[] numerot2 = new int[5] { 5, 15, 25, 35, 45 };
                int[] yhdistetty = numerot1.Concat(numerot2).ToArray();

                Console.WriteLine("Luvut taulukossa 1 : {0}", string.Join(", ", numerot1));
                Console.WriteLine("Luvut taulukossa 2 : {0}", string.Join(", ", numerot2));
                Array.Sort(yhdistetty);
                Console.WriteLine("Luvut yhdistettynä taulukossa : {0}", string.Join(", ", yhdistetty));
            }
        }

        /*Tehtävä 18 Tee ohjelma, joka kysyy käyttäjältä merkkijonon (lause).
             * Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono
             * palidromi. */
        public class Teht18
        {
            public static void Palindromi()
            {
                Console.Write("Kirjoita sana. Tarkistetaan onko sana palindromi > ");
                string sana = Console.ReadLine();
                string sana2 = sana.ToLower();
                string apu = "";
                int apu2 = sana.Length - 1;

                for (int i = 0; i <= (sana.Length - 1); i++)
                {
                    apu = apu + sana2[apu2];
                    apu2--;
                }

                if (sana2 == apu)
                {
                    Console.WriteLine("Merkkijono on palindromi");
                }
                else
                {
                    Console.WriteLine("Merkkijono ei ole palindromi");
                }
            }
        }

        /*Tehtävä 19 
             * Tee tekstipohjainen Hirsipuu-peli. Voit kovakoodata arvattavan sanan ja toteuta looppi, 
             * jossa käyttäjältä kysytään seuraavaa kirjainta. Muista näyttää aina kirjaimen jälkeen oikein 
             * arvatut kirjaimet sanan oikealla kohdalla (käytä esim _-alaviivaa ei arvattujen kirjainten kohdalla).
             * Voit näyttää myös jo arvatut ei käytetyt -kirjaimet. Päätä itse milloin pelaaja joutuu hirteen.*/
        public class Teht19
        {
            public static void Hirsipuu()
            {
                string[] sana = new string[] { "h", "i", "r", "s", "i", "p", "u", "u" };
                string[] sala = new string[] { "_", "_", "_", "_", "_", "_", "_", "_" };
                List<string> kaytetyt = new List<string>();
                int apu = 0;
                int yritys = 5;

                while (true)
                {
                    string tarkistus1 = string.Join("", sana);
                    string tarkistus2 = string.Join("", sala);
                    Console.WriteLine("Yrityksiä jäljellä: " + yritys);
                    Console.Write("Käytetyt kirjaimet: ");
                    foreach (string i in kaytetyt)
                    {
                        Console.Write(i + " ");
                    }

                    Console.WriteLine();
                    for (int j = 0; j < sala.Length; j++)
                    {
                        Console.Write(sala[j]);
                    }
                    Console.WriteLine();

                    if (tarkistus1 == tarkistus2)
                    {
                        Console.WriteLine("Onneksi olkoon, voitit pelin!");
                        break;
                    }
                    else if (yritys == 0)
                    {
                        Console.WriteLine("Hirtetty");
                        break;
                    }

                    Console.WriteLine();

                    Console.Write("Anna kirjain > ");
                    string kirjain = Console.ReadLine();
                    kaytetyt.Add(kirjain);

                    for (int i = 0; i < sana.Length; i++)
                    {
                        if (sana[i].Contains(kirjain))
                        {
                            sala[i] = kirjain;
                            apu++;
                        }
                    }

                    if (apu == 0)
                    {
                        Console.WriteLine("Ei löydy.");
                        yritys--;
                    }
                    else
                    {
                        Console.WriteLine("Osui ja upposi");
                        apu = 0;
                    }

                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }

        /*Tehtävä 20 
             * Toteuta jokin oma villi-ideasi ja yllätä opettaja toteutuksellasi.*/
        public class Teht20
        {
            public static void AlkeellinenCaesar()
            {
                char[] aakkoset = new char[29] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'w', 'v', 'x', 'y', 'z', 'å', 'ä', 'ö' };
                string lause = "";
                string salattu = "";
                int siirto = 0;
                char kirjain;

                Console.Write("Salattava teksti (vain 11 kirjainta)> ");
                lause = Console.ReadLine();
                string salattava = lause.ToLower();
                Console.WriteLine();

                Console.WriteLine("Salaamaton teksti > " + salattava);

                foreach (char x in salattava)
                {
                    kirjain = x;

                    if (kirjain == ' ')
                    {
                        salattu += ' ';
                        continue;
                    }
                    else
                    {
                        siirto = Array.IndexOf(aakkoset, kirjain) + 3;
                    }

                    if (siirto <= 0)
                    {
                        siirto = siirto + 29;
                    }
                    else if (siirto >= 29)
                    {
                        siirto = siirto - 29;
                    }

                    salattu += aakkoset[siirto];
                }

                Console.WriteLine("Salattu teksti > " + salattu);

                string purettava = "";
                siirto = 0;

                foreach (char x in salattu)
                {
                    kirjain = x;

                    if (kirjain == ' ')
                    {
                        purettava += ' ';
                        continue;
                    }

                    siirto = Array.IndexOf(aakkoset, kirjain) - 3;
                    if (siirto <= 0)
                    {
                        siirto = siirto + 29;
                    }
                    else if (siirto >= 29)
                    {
                        siirto = siirto - 29;
                    }

                    purettava += aakkoset[siirto];
                }

                Console.WriteLine("Purettu salaamaton teksti > " + purettava);
                Console.WriteLine();
            }
        }
    }
}
