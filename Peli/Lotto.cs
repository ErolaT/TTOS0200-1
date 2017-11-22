using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peli
{
    public class Lotto
    {
        public static string Arvonta(string tyyppi, int rivit)
        {
            string numerot = "";
            if (tyyppi == "Lotto")
            {
                numerot = Arvo(rivit, 7, 40);
            }
            else if (tyyppi == "Viking Lotto")
            {
                numerot = Arvo(rivit, 6, 48);
            }
            else if (tyyppi == "Eurojackpot")
            {
                numerot = Arvo(rivit, 5, 50);
            }
            return numerot;
        }

        public static string Arvo(int rivit, int määrä, int tyypinmaksimi)
        {
            Random rnd = new Random();
            string numerot = "";
            int apu;
            List<int> nrot;

            for (int i = 0; i < rivit; i++)
            {
                nrot = new List<int>();
                numerot += "Rivi " + (i + 1) + ": ";
                for (int j = 0; j < määrä; j++)
                {
                    apu = rnd.Next(1, tyypinmaksimi + 1);
                    if (nrot.Contains(apu))
                    {
                        j--;
                    }
                    else
                    {
                        nrot.Add(apu);
                    }
                }
                nrot.Sort();
                foreach (int nro in nrot)
                {
                    numerot += nro.ToString() + " ";
                }
                if (määrä == 5)
                {
                    nrot = new List<int>();
                    nrot.Add(rnd.Next(1, 11));
                    nrot.Add(rnd.Next(1, 11));
                    nrot.Sort();
                    numerot += nrot[0].ToString() + " ";
                    numerot += nrot[1].ToString() + " ";
                }
                numerot += "\n";
            }
            return numerot;
        }
    }
}
