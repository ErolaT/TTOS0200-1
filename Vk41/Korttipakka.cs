using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.MiniASIO
{
    public class Korttipakka
    {
        private List<Kortti> kortit;

        public Korttipakka()
        {
            kortit = new List<Kortti>();
        }
        public void LisaaKortti(Kortti kortti)
        {
            kortit.Add(kortti);
        }

        
        public override string ToString()
        {
            string teksti = "";
            for (int i = 0; i < kortit.Count; i++)
            {
                teksti += (i + 1) + " kortti on " + kortit[i].ToString() + "\n";
            }
            return teksti;
        }
    }

    public class Kortti
    {
        public string Maa { get; set; }
        public int Numero { get; set; }

        public Kortti(string maa, int numero)
        {
            this.Maa = maa;
            this.Numero = numero;
        }

        public override string ToString()
        {
            return Maa + "#" + Numero;
        }
    }
}
