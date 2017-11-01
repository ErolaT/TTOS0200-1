using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Teht3
    {
        public static void TestaaTeht3()
        {
            try
            {
                string koko = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\kokonaisluvut.txt";
                string reaali = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\reaaliluvut.txt";

                StreamWriter sw1 = new StreamWriter(koko);
                StreamWriter sw2 = new StreamWriter(reaali);

                Console.WriteLine("Anna kokonaisluku tai reaaliluku");
                while (true)
                {
                    string luku = Console.ReadLine();

                    if (int.TryParse(luku, out int i))
                    {
                        sw1.WriteLine(luku);
                    }
                    else if (double.TryParse(luku, out double j))
                    {
                        sw2.WriteLine(luku);
                    }
                    else
                    {
                        sw1.Close();
                        sw2.Close();
                        break;
                    }
                }
                if (File.Exists(koko))
                {
                    Console.WriteLine("Kokonaisluvut:\n{0}", (File.ReadAllText(koko)));
                }
                if (File.Exists(reaali))
                {
                    Console.WriteLine("Reaaliluvut:\n{0}", (File.ReadAllText(reaali)));
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Tiedostoa ei löydy");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
