//Toni Erola
//Olio
//18.9.2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaRengas();
        }

        /*Tehtävä 1 Kiuas*/
        static void TestaaKiuas()
        {
            Lab2 omaKiuas = new Lab2();
            omaKiuas.Virta = true;
            omaKiuas.Lämpötila = 120;
            omaKiuas.Kosteus = 50;

            Console.Write("Päällä? > " + omaKiuas.Virta);
            Console.Write("\nLämpötila? > " + omaKiuas.Lämpötila + " astetta");
            Console.Write("\nKosteusprosentti? > " + omaKiuas.Kosteus + " prosenttia\n\n");

            Console.WriteLine(omaKiuas.HeitäLöylyä(10));

            omaKiuas.Virta = false;
            omaKiuas.Lämpötila = 0;
            omaKiuas.Kosteus = 0;

            Console.Write("Päällä? > " + omaKiuas.Virta);
            Console.Write("\nLämpötila? > " + omaKiuas.Lämpötila + " astetta");
            Console.Write("\nKosteusprosentti? > " + omaKiuas.Kosteus + " prosenttia\n");
        }

        /*Tehtävä 2 Pesukone*/
        static void TestaaPesukone()
        {
            Pesukone pesu = new Pesukone();
            pesu.Hana = true;
            pesu.Kesto = 90;
            pesu.Linkous = true;
            pesu.Vesilämpö = 60;

            Console.Write("Virta? > " + pesu.Virta);
            Console.Write("\nHana? > " + pesu.Hana);
            Console.Write("\nKesto? > " + pesu.Kesto + " minuuttia");
            Console.Write("\nLinkous? > " + pesu.Linkous);
            Console.Write("\nVeden lämpö? > " + pesu.Vesilämpö + " astetta");

            pesu.KatkaiseVirta(true);
            Console.Write("\nVirta? > " + pesu.Virta);

            Pesukone uusiPesu = new Pesukone(true, true);

            Console.Write("\nVirta? > " + uusiPesu.Virta);
            Console.Write("\nHana? > " + uusiPesu.Hana);
            Console.Write("\nKesto? > " + uusiPesu.Kesto + " minuuttia");
            Console.Write("\nLinkous? > " + uusiPesu.Linkous);
            Console.Write("\nVeden lämpö? > " + uusiPesu.Vesilämpö + " astetta");

            uusiPesu.AnnaKesto(180);
            Console.Write("\nKesto? > " + uusiPesu.Kesto + " minuuttia");

            uusiPesu.ValitseLämpötila(-1);
            Console.Write("\nVeden lämpö? > " + uusiPesu.Vesilämpö + " astetta\n");
        }

        /*Tehtävä 3 Televisio*/
        static void TestaaTelevisio()
        {
            Televisio telekkari = new Televisio("Samsung", "UX12233");

            Console.WriteLine("Virta > " + telekkari.Virta);

            telekkari.Virta = true;
            telekkari.Kanava = 12;
            telekkari.Ääni = 10;

            Console.WriteLine("Merkki > " + telekkari.Merkki);
            Console.WriteLine("Malli > " + telekkari.Malli);
            Console.WriteLine("Virta > " + telekkari.Virta);
            Console.WriteLine("Kanava tällä hetkellä > " + telekkari.Kanava);
            Console.WriteLine("Äänenvoimakkuus > " + telekkari.Ääni);

            telekkari.VaihdaKanava(3);
            telekkari.SäädäÄäni(10);

            Console.WriteLine("Kanava tällä hetkellä > " + telekkari.Kanava);
            Console.WriteLine("Äänenvoimakkuus > " + telekkari.Ääni);

            telekkari.SäädäÄäni(-22);

            Console.WriteLine("Äänenvoimakkuus > " + telekkari.Ääni);
        }

        /*Tehtävä 4 Vechile*/
        static void TestaaVechile()
        {
            Vechile car = new Vechile("Nissoon", 225, 20);

            car.PrintData();
            Console.WriteLine();
            Console.WriteLine(car.ToString());

            car.Speed = 120;
            car.Tyres = 19;

            car.PrintData();
            Console.WriteLine();
            Console.WriteLine(car.ToString());

            Vechile car2 = new Vechile("Bemari", 20, 13);

            car2.PrintData();
            Console.WriteLine();
            Console.WriteLine(car2.ToString());
        }

        /*Tehtävä 6 Oma*/
        static void TestaaKitara()
        {
            Kitara hevikeppi = new Kitara(true, "ESP", true, true);

            hevikeppi.SoitaKitaraa();

            hevikeppi.Äänenvoimakkuus = 20;

            hevikeppi.SoitaKitaraa();

            Console.WriteLine(hevikeppi.ToString());

            hevikeppi.TulostaSetti();

            hevikeppi.Pedaali = true;

            hevikeppi.SoitaKitaraa();

            hevikeppi.TulostaSetti();

            hevikeppi.Keppi = false;

            hevikeppi.SoitaKitaraa();
        }

        /*Tehtävä 7 CD*/
        static void CDLevyHylly()
        {
            CD[] levyt = new CD[5];

            levyt[0] = new CD("Metallica", "Master Of Puppets", "Trash", 20, 55, 1986);
            levyt[1] = new CD("Pantera", "Far Beyond Driven", "Trash/Groove", 18, 57, 1994);
            levyt[2] = new CD("Megadeth", "Rust in Peace", "Trash", 24, 41, 1990);
            levyt[3] = new CD("Avenged Sevenfold", "The Stage", "Heavy Metal", 22, 74, 2016);
            levyt[4] = new CD("Iron Maiden", "The Book of Souls", "Heavy Metal", 40, 93, 2015);

            for (int i = 0; i < levyt.Length; i++)
            {
                Console.WriteLine(levyt[i].ToString());
                Console.WriteLine();
            }
        }
        /*Tehtävä 2 Hissi*/
        static void TestaaHissi()
        {
            DynamonHissi hissi = new DynamonHissi();

            int siirtymä;

            while (true)
            {
                Console.WriteLine("Hissi on kerroksessa > " + hissi.Kerros);
                Console.Write("Anna kerros (1-5) (0 lopettaa loopin) > ");
                siirtymä = int.Parse(Console.ReadLine());
                if (siirtymä == 0)
                {
                    break;
                }
                hissi.Kerros = siirtymä;
            }
        }
        /*Tehtävä 3 Vahvistin*/
        static void TestaaVahvari()
        {
            Vahvistin mesaboogie = new Vahvistin();

            int apu;

            while (true)
            {
                Console.Write("Anna äänenvoimakkuus (0-100) (666 lopettaa) > ");
                apu = int.Parse(Console.ReadLine());

                if (apu == 666)
                {
                    break;
                }

                mesaboogie.Äänenvoimakkuus = apu;
            }
        }
        static void TestaaTyöpaikka()
        {
            Työntekijä ryöukko = new Työntekijä("Risto Ryöukko", "Konekuski", "3200");

            Console.WriteLine(ryöukko.ToString());

            Pomo boss = new Pomo("Pomo Pomottaja", "CEO", "9000", "Jatke", "10000");

            Console.WriteLine(boss.ToString());

            Pomo boss2 = new Pomo();
            boss2.Nimi = "Keijo Massimies";
            boss2.Ammatti = "Pomomies";
            boss2.Palkka = "8000";
            boss2.Auto = "Volokkari";
            boss2.Bonus = "2000";

            Console.WriteLine(boss2.ToString());
        }
        static void TestaaKulkuneuvo()
        {
            Polkupyörä kona = new Polkupyörä();

            kona.Nimi = "Kona";
            kona.Malli = "Maasto";
            kona.Vuosimalli = "2010";
            kona.Väri = "Musta";
            kona.Vaihteet = true;
            kona.VaihdeMalli = "Shimano";

            Console.WriteLine("Pyörä 1\n" + kona.ToString());

            Vene jolla = new Vene();

            jolla.Nimi = "Jolla";
            jolla.Malli = "245";
            jolla.Vuosimalli = "1992";
            jolla.Väri = "Valkoinen";
            jolla.Paikat = 4;
            jolla.Tyyppi = "Soutuvene";

            Console.WriteLine("Vene 1\n" + jolla.ToString());
        }
        /*Tehtävä 6 Radio*/
        static void TestaaRadio()
        {
            Radio pioneer = new Radio();

            pioneer.Virta = true;
            pioneer.Äänenvoimakkuus = 2;
            pioneer.Taajuus = "4000,4";

            Console.WriteLine("Radion tila\n" + pioneer.ToString());

            pioneer.Taajuus = "2707,0";
            pioneer.Äänenvoimakkuus = 10;

            Console.WriteLine("Radion tila\n" + pioneer.ToString());

            pioneer.Äänenvoimakkuus = -1;
            pioneer.Taajuus = "1999,9";

            Console.WriteLine("Radion tila\n" + pioneer.ToString());
        }
        /*Tehtävä 7 Kirjahylly*/
        static void TestaaKirjahylly()
        {
            Levy pantera = new Levy();
            Kirja ruotsi = new Kirja();
            Elokuva forrest = new Elokuva();

            Console.WriteLine("Hyllyssä on: ");

            pantera.Tavara = "CD-levy";
            pantera.Nimi = "Pantera";
            pantera.Albumi = "Far Beyond Driven";
            pantera.Vuosi = 1994;

            Console.WriteLine(pantera.ToString());

            ruotsi.Tavara = "Kirja";
            ruotsi.Nimi = "Opettele Ruottia!";
            ruotsi.Valmistaja = "Otava";

            Console.WriteLine(ruotsi.ToString());

            forrest.Tavara = "Elokuva";
            forrest.Nimi = "Forrest Gump";
            forrest.Kesto = 90;
            forrest.Genre = "Draama";

            Console.WriteLine(forrest.ToString());
        }
        /*Tehtävä 8 */
        static void TestaaTili()
        {
            Tili nordea = new Tili("123456789-1234");

            nordea.LisääRahaa(1000);

            Console.WriteLine(nordea.ToString());

            nordea.NostaRahaa(200);

            Console.WriteLine(nordea.ToString());

            Console.WriteLine("Tilin saldo: " + nordea.TulostaSaldo());

            LuottoTili spankki = new LuottoTili("123456789-1234", 1000, 1000);

            Console.WriteLine(spankki.ToString());

            spankki.MaksaLuotolta(800);

            Console.WriteLine(spankki.ToString());

            spankki.MaksaVelka();

            Console.WriteLine(spankki.ToString());
        }

        /*Tehtävä 1 Rengas*/
        static void TestaaRengas()
        {
            Ajoneuvo auto = new Ajoneuvo("Toyota", "Supra");
            Lab4 nokia = new Lab4("Nokia", "Hakkapeliitta 8", 18);

            auto.LisääRenkaat(nokia);
            auto.LisääRenkaat(nokia);
            auto.LisääRenkaat(nokia);
            auto.LisääRenkaat(nokia);

            Console.WriteLine(auto.ToString());

            Ajoneuvo mpo = new Ajoneuvo("Suzuki", "GSX");
            mpo.LisääRenkaat(new Lab4("Michelin", "City Grip", 10));
            mpo.LisääRenkaat(new Lab4("Michelin", "City Grip", 10));

            Console.WriteLine(mpo.ToString());
        }
    }
}
