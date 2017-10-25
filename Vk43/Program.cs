using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaTeht1();
        }
        static void TestaaTeht1()
        {
            //KÄYTTÄKÄÄ AINA TRY-CATCHIA
            try
            {
                string nimi;
                string filupath = @"D:\K8851\Testit";
                //string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filu = filupath + @"\testi.txt";
                //Kirjoitetaan käyttäjän antamat rivit tiedostoon
                //Luodaan StreamWriter tyyppinen olio johon kirjoitetaan

                StreamWriter sw = new StreamWriter(filu);

                do
                {
                    Console.Write("Anna nimi (Enter lopettaa):");
                    nimi = Console.ReadLine();

                    if (nimi.Length > 0)
                    {
                        sw.WriteLine(nimi);
                    }
                } while (nimi.Length != 0);
                sw.Close();
                //Avataan tiedosto uudestaan ja luetaan sen sisältö ja näytetään konsolissa
                //Suositellaan:
                if (File.Exists(filu))
                {
                    string teksti = File.ReadAllText(filu);
                    Console.WriteLine(teksti);
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