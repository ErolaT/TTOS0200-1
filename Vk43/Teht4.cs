using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    [Serializable]
    public class Teht4
    {
        public string Ohjelma { get; set; }
        public string Kanava { get; set; }
        public string Aika { get; set; }
        public string Info { get; set; }

        public Teht4(string ohjelma, string kanava, string aika, string info)
        {
            this.Ohjelma = ohjelma;
            this.Kanava = kanava;
            this.Aika = aika;
            this.Info = info;
        }
    }
    public class Testi
    {
        public static void TestaaTeht4()
        {
            try
            {
                List<Teht4> ohjelmat = new List<Teht4>();

                ohjelmat.Add(new Teht4("Mestareiden mestari", "MTV3", "21-22", "Eläköityneet lusmut koittaa urheilla"));
                ohjelmat.Add(new Teht4("Docventures", "TV2", "20-22", "Tänään aiheena lusmut ihmiset"));
                ohjelmat.Add(new Teht4("Simpsonit", "Sub", "20.30-21", "Bart polttaa kirkon"));

                Stream kirjoita = new FileStream("TvOhjelmat.bin", FileMode.Create, FileAccess.Write, FileShare.None);

                IFormatter formatter = new BinaryFormatter();

                formatter.Serialize(kirjoita, ohjelmat);

                kirjoita.Close();

                Stream avaa = new FileStream("TvOhjelmat.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

                List<Teht4> lue = (List<Teht4>)formatter.Deserialize(avaa);

                avaa.Close();

                foreach (Teht4 i in lue)
                {
                    Console.WriteLine("Ohjelman nimi > {0}\n\tKanava > {1}\n\t\tKello > {2}\n\t\t\tInfo >\n\t\t\t{3}", i.Ohjelma, i.Kanava, i.Aika, i.Info);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
