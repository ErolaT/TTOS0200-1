//Toni Erola
//Olio
//18.9.2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelija
{
    /*Tehtävä 5 Suunnittele UML-editorilla Opiskelija-luokka, joka sisältää
     * opiskelijalle tyypillisiä tietoja ja toimintoja. Tee uusi projekti. 
     * Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma, joka luo muutamia 
     * opiskelijoita ja tallentaa opiskelijat taulukkoon (esim. 5 opiskelijaa).
     * Tulosta taulukossa olevien opiskelijoiden tiedot käyttämällä toistorakennetta. */
    class Opiskelijacs
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string OpNro { get; set; }
        public string Suuntautuminen { get; set; }

        public Opiskelijacs(string etu, string suku, string opnro, string suunt)
        {
            this.Etunimi = etu;
            this.Sukunimi = suku;
            this.OpNro = opnro;
            this.Suuntautuminen = suunt;
        }

        public override string ToString()
        {
            return this.Etunimi + " " + this.Sukunimi + ", opiskelijanumero: " + this.OpNro + ", suuntautuminen: " + this.Suuntautuminen;
        }
    }
}
