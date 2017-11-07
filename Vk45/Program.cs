using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestaaMuodot();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void TestaaLaskin()
        {
            try
            {
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                Console.WriteLine("Summa = " + ArrayCalcs.Sum(array));
                Console.WriteLine("Keskiarvo = " + ArrayCalcs.Average(array));
                Console.WriteLine("Pienin arvo = " + ArrayCalcs.Min(array));
                Console.WriteLine("Suurin arvo = " + ArrayCalcs.Max(array));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void TestaaKalat()
        {
            try
            {
                Kalastaja matti = new Kalastaja("Matti Meikäläinen", "0401233567");
                Kalat taimen = new Kalat("Taimen", "60", "2", "Inarijärvi", "Väylä");
                Kalat lohi = new Kalat("Kirjolohi", "46", "4", "Inarijärvi", "Pohjoispuoli");

                Console.WriteLine("Uusi henkilö lisättiin kalastusrekisteriin\n{0}", matti.ToString());

                matti.kalat.Add(taimen);

                Console.WriteLine("{0} sai kalan!\n\n{1}", matti.Nimi, taimen.ToString());

                matti.kalat.Add(lohi);

                Console.WriteLine("{0} sai kalan!\n\n{1}", matti.Nimi, lohi.ToString());
                Console.WriteLine();

                matti.TulostaTiedot();

                matti.TulostaKg();
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void TestaaMuodot()
        {
            try
            {
                Kuviot lista = new Kuviot();
                Ympyrä yks = new Ympyrä("Ympyrä 1", 1);
                Ympyrä kaks = new Ympyrä("Ympyrä 2", 2);
                Ympyrä kolme = new Ympyrä("Ympyrä 3", 3);
                Suorakulmio suora1 = new Suorakulmio("Suorakulma 1", 10, 20);
                Suorakulmio suora2 = new Suorakulmio("Suorakulma 2", 20, 30);
                Suorakulmio suora3 = new Suorakulmio("Suorakulma 3", 40, 50);
                lista.shapes.Add(yks);
                lista.shapes.Add(kaks);
                lista.shapes.Add(kolme);
                lista.shapes.Add(suora1);
                lista.shapes.Add(suora2);
                lista.shapes.Add(suora3);

                Console.WriteLine(lista.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
