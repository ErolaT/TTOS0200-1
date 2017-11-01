using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Teht2
    {
        public static void TestaaTeht2()
        {
            string tiedosto = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\nimet.txt";
            Dictionary<string, int> nimet = new Dictionary<string, int>();
            int lukumäärä = File.ReadAllLines(tiedosto).Distinct().Count();

            try
            {
                if (File.Exists(tiedosto))
                {
                    foreach (string i in File.ReadLines(tiedosto))
                    {
                        if (nimet.ContainsKey(i))
                        {
                            nimet[i] = nimet[i] + 1;
                        }
                        else
                        {
                            nimet.Add(i, 1);
                        }
                    }

                    Console.WriteLine("Löytyi {0} riviä ja {1} eri nimeä", (File.ReadAllLines(tiedosto).Count()), lukumäärä);
                    foreach (var i in nimet)
                    {
                        Console.WriteLine("Nimi {0} esiintyy {1} kertaa", i.Key, i.Value);
                    }

                    Console.WriteLine("Järjestyksessä:");
                    var orderi = nimet.OrderBy(i => i.Key);
                    foreach (var i in orderi)
                    {
                        Console.WriteLine("Nimi {0} esiintyy {1} kertaa", i.Key, i.Value);
                    }
                }                
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
