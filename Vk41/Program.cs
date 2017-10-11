using JAMK.IT.MiniASIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.MiniAsio
{
    class TestaaMiniASIO
    {
        static void Testaa()
        {
            //Luodaan List-tyyppinen lista opiskelijoista
            List<Opiskelija> opiskelijat = new List<Opiskelija>();

            //Testin vuoksi erilaisia tapoja lisätä olioita listaan
            Opiskelija matti = new Opiskelija("Matti", "Meikäläinen");
            opiskelijat.Add(matti);

            opiskelijat.Add(new Opiskelija("Keijo", "Kalamies", "B1234"));

            //Myös näin mahdollista
            opiskelijat.Add(new Opiskelija { Etunimi = "Jussi", Sukunimi = "Mussi", AsioID = "K4321" });
            opiskelijat.Add(new Opiskelija { Etunimi = "Teppo", Sukunimi = "Testi", AsioID = "L1264", Ryhma = "TTV16S1" });

            Opiskelija kalle = new Opiskelija();
            kalle.Sukunimi = "Kalastaja";
            kalle.Etunimi = "Kalle";
            kalle.AsioID = "A0021";
            opiskelijat.Add(kalle);

            //Yhden opiskelijan tietojen näyttäminen
            Console.WriteLine("Anna numero väliltä 1-5");
            int i = int.Parse(Console.ReadLine());

            if (i - 1 < opiskelijat.Count)
            {
                Console.WriteLine("MiniASIOn {0} Opiskelija on {1}", i, opiskelijat[i - 1].ToString());
            }
            else
                Console.WriteLine("MiniASIOssa on vain {0} opiskelijaa", opiskelijat.Count);

            //Kaikkien opiskelijoiden tiedot
            Console.WriteLine("MiniASIOn kaikki opiskelijat");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }

            //Kaikkien opiskelijoiden tiedot aakkosjärjestyksessä sukunimen mukaan
            //Sort oliot Sukunimi-ominaisuuden mukaiseen järjestykseen
            opiskelijat.Sort((x, y) => x.Sukunimi.CompareTo(y.Sukunimi));
            Console.WriteLine("MiniASIOn kaikki opiskelijat");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }

            //Uuden opiskelija lisääminen, huom. Tehdään tarkistus ettei AsioID ole jo olemassa
            Console.WriteLine("Anna uuden opiskelijan AsioID");
            string asioid = Console.ReadLine();

            //Tutkitaan onko listassa 
            bool lippu = false;
            foreach (var o in opiskelijat)
            {
                if (asioid == o.AsioID)
                {
                    lippu = true;
                    break;
                }
            }
            if (lippu)
            {
                Console.WriteLine("AsioID {0} on jo käytössä", asioid);
            }
            else
            {
                Console.WriteLine("Anna uuden opiskelijan etunimi");
                string etunimi = Console.ReadLine();
                Console.WriteLine("Anna sukunimi");
                string sukunimi = Console.ReadLine();
                Console.WriteLine("Anna ryhmä");
                string ryhma = Console.ReadLine();

                //Luodaan uusi Opiskelija olio
                Opiskelija uusi = new Opiskelija(etunimi, sukunimi, asioid, ryhma);

            }
        }
        static void Main(string[] args)
        {
            Testaa();
        }
    }
}
