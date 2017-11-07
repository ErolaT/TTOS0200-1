using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Noppa
    {
        public static void TestaaNoppa()
        {
            try
            {
                Random rnd = new Random();
                int[] luvut = new int[6];
                int summa = 0;
                int luku;

                Console.WriteLine("Montako kertaa heitetään noppaa?");
                int heitto = int.Parse(Console.ReadLine());

                for (int i = 0; i < heitto; i++)
                {
                    luku = rnd.Next(1, 7);
                    luvut[luku - 1] += 1;
                    summa += luku;
                }

                Console.WriteLine("Heitettiin {0} kertaa\n > Keskiarvo {1}", heitto, ((float)summa / heitto));

                for (int i = 0; i < luvut.Length; i++)
                {
                    Console.WriteLine(" > Luku {0} heitettiin {1} kertaa", (i + 1), luvut[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
