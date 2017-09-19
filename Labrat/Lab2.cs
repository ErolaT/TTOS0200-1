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

 /*Tehtävä 1 Tehtävänäsi on ohjelmoida kiukaan toiminta. Kiuas pitää pystyä laittamaan päälle ja pois,
         * sekä sen lämpötilaa että sen antamaa kosteutta pitää pystyä säätämään (arvoja ei ole rajattu). */
    public class Lab2
    {
        public bool Virta { get; set; }

        private int prosentti;
        public int Kosteus
        {
            get { return prosentti; }
            set {
                prosentti = value;
                if (prosentti < 0 || prosentti > 100)
                {
                    prosentti = 0;
                }
            }
        }
        public int Lämpötila { get; set; }
        
        public string HeitäLöylyä(int kertaa)
        {
            string sihinä = "";
            for (int i = 0; i < kertaa; i++)
            {
                sihinä += "TSSSSH\n";
            }
            return sihinä;
        }
    }

    /*Tehtävä 2
     * Tehtävänäsi on ohjelmoida pesukoneen toiminta. Samoin kuin edellinen tehtävä:
     * mitä ominaisuuksia ja toimintoja tekisit Pesukone-luokkaan?*/
    public class Pesukone
    {
        public bool Virta { get; set; }
        public bool Hana { get; set; }
        public int Kesto { get; set; }
        public bool Linkous { get; set; }
        public int Vesilämpö { get; set; }

        public Pesukone()
        {
            this.Virta = true;
        }

        public Pesukone(bool hana, bool linkous)
        {
            this.Hana = hana;
            this.Linkous = linkous;
        }
        public Pesukone(bool virta, bool hana, bool linkous)
        {
            this.Virta = virta;
            this.Hana = hana;
            this.Linkous = linkous;
        }

        public void AnnaKesto(int kesto)
        {
            if (kesto < 0)
            {
                this.Kesto = 30;
            }
            else
            {
                this.Kesto = kesto;
            }
        }
        public void KatkaiseVirta(bool virta)
        {
            if (virta == true)
            {
                this.Virta = false;
            }
        }
        public void ValitseLämpötila(int lämpö)
        {
            if (lämpö < 0)
            {
                this.Vesilämpö = 40;
            }
            else
            {
                this.Vesilämpö = lämpö;
            }
        }
    }

    /*Tehtävä 3
     * Tehtävänäsi on ohjelmoida television toiminta. Samoin kuin edellinen tehtävä:
     * mitä ominaisuuksia ja toimintoja tekisit Televisio-luokkaan? */
     public class Televisio
    {
        public bool Virta { get; set; }
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public int Ääni { get; set; }
        public int Kanava { get; set; }

        public Televisio(string merkki, string malli)
        {
            Merkki = merkki;
            Malli = malli;
        }

        public int VaihdaKanava(int uusi)
        {
            Kanava = uusi;
            return Kanava;
        }

        public int SäädäÄäni(int voimakkuus)
        {
            Ääni += voimakkuus;

            if (Ääni < 0)
            {
                Ääni = 0;
            }

            return Ääni;
        }
    }

    /*Tehtävä 4 
     * Luo Vehicle-luokka*/
     public class Vechile
    {
        public string Name { get; set; }
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                {
                    speed = 0;
                }
                else
                {
                    speed = value;
                }
            }
        }
        public int Tyres { get; set; }

        public Vechile(string name, int speed, int tyres)
        {
            this.Name = name;
            this.Speed = speed;
            this.Tyres = tyres;
        }

        public void PrintData()
        {
            Console.WriteLine("Nimi > " + this.Name);
            Console.WriteLine("Nopeus > " + this.Speed);
            Console.WriteLine("Renkaat > " + this.Tyres);
        }

        public override string ToString()
        {
            return "Nimi: " + this.Name + ", nopeus: " + this.Speed + "km/h ja renkaat: " + this.Tyres + "\n";
        }
    }

    /*Tehtävä 6 
     * Valitse jokin reaalimaailman asia ja suunnittele siitä luokkarakenne 
     * UML-editorilla. Tee uusi projekti. Ohjelmoi suunnittelema luokkasi 
     * sekä käytä tekemääsi luokkaa edellisten tehtävien mukaisesti. */
     public class Kitara
    {
        public bool Keppi { get; set; }
        public string Nimi { get; set; }
        public bool Vahvistin { get; set; }
        private int Ääni;
        public int Äänenvoimakkuus
        {
            get { return this.Ääni; }
            set
            {
                this.Ääni = value;
                if (this.Ääni < 0)
                {
                    this.Ääni = 0;
                }
            }
        }
        public bool Pedaali { get; set; }
        public bool Piuha { get; set; }

        public Kitara(bool keppi, string nimi, bool vahvistin, bool piuha)
        {
            this.Keppi = keppi;
            this.Nimi = nimi;
            this.Vahvistin = vahvistin;
            this.Piuha = piuha;
        }

        public void SoitaKitaraa()
        {
            if (this.Keppi == true && this.Vahvistin == true && this.Piuha == true && this.Ääni > 0)
            {
                if (this.Pedaali == true)
                {
                    Console.WriteLine("WAH WAH WAH WAH WAH WAH WAH WAH!!!!");
                }
                else
                {
                    Console.WriteLine("RÄNK RÄNK RÄNK TILUTILU!!!!");
                }
            }
            else if (this.Keppi == true) 
            {
                Console.WriteLine("Tilu tilu");
            }
            else
            {
                Console.WriteLine("Nyt on jossaki vika");
            }
        }

        public void TulostaSetti()
        {
            Console.WriteLine("Kitara > {0}", this.Keppi);
            Console.WriteLine("Vahvistin > {0}", this.Vahvistin);
            Console.WriteLine("Piuha > {0}", this.Piuha);
            Console.WriteLine("Pedaali > {0}", this.Pedaali);
        }

        public override string ToString()
        {
            return  "Kitaran merkki on " + this.Nimi;
        }
    }

    /*Tehtävä 7 Suunnittele UML-editorilla CD-luokka, joka sisältää 
     * ominaisuuksina tyypillisiä CD-levyyn kuuluvia tietoja.*/
     public class CD
    {
        public string Artisti { get; set; }
        public string Albumi { get; set; }
        public string Genre { get; set; }
        private double hinta;
        public double Hinta
        {
            get { return hinta; }
            set
            {
                this.hinta = value;
                if (this.hinta < 0)
                {
                    this.hinta = 0;
                }
            }
        }
        private int kesto;
        public int Kesto
        {
            get { return this.kesto; }
            set
            {
                this.kesto = value;
                if (this.kesto < 0)
                {
                    this.kesto = 0;
                }
            }
        }
        public int Julkaistu { get; set; }

        public CD(string artisti, string albumi, string genre, double hinta, int kesto, int julkaistu)
        {
            this.Artisti = artisti;
            this.Albumi = albumi;
            this.Genre = genre;
            this.Hinta = hinta;
            this.Kesto = kesto;
            this.Julkaistu = julkaistu;
        }

        public override string ToString()
        {
            return "Artisti > " + this.Artisti + "\nAlbumi > " + this.Albumi + "\nGenre > " + this.Genre + "\nAlbumin kesto > " + this.Kesto + " minuuttia" + "\nAlbumin hinta > " + this.Hinta + " euroa" + "\nJulkaistu > " + this.Julkaistu;
        }
    }
}
