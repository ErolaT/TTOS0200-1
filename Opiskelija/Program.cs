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
    class Program
    {
        /*Tehtävä 5 Opiskelijat*/
        static void Main(string[] args)
        {
            Opiskelijacs[] opiskelijat = new Opiskelijacs[5];

            opiskelijat[0] = new Opiskelijacs("Matti", "Meikäläinen", "H1234", "Kyber");
            opiskelijat[1] = new Opiskelijacs("Jussi", "Juu", "K1245", "Kyber");
            opiskelijat[2] = new Opiskelijacs("Keijo", "Kei", "Y1234", "Verkko");
            opiskelijat[3] = new Opiskelijacs("Tiina", "Toi", "U1267", "Media");
            opiskelijat[4] = new Opiskelijacs("Tero", "Teräs", "Ä2356", "Ohjelmisto");

            for (int i = 0; i < opiskelijat.Length; i++)
            {
                Console.WriteLine(opiskelijat[i].ToString());
            }
        }
    }
}
