using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.MiniASIO
{
    public class Opiskelija
    {
        #region PROPERTIES
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string AsioID { get; set; }
        public string Ryhma { get; set; }
        #endregion

        #region CONSTRUCTORS
        public Opiskelija()
        {
        }
        public Opiskelija(string etu, string suku)
        {
            Etunimi = etu;
            Sukunimi = suku;
        }
        public Opiskelija(string etu, string suku, string asioid) : this(etu, suku)
        {
            AsioID = asioid;
        }
        public Opiskelija(string etu, string suku, string asioid, string ryhma) : this(etu, suku, asioid)
        {
            Ryhma = ryhma;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return string.Format("{0} {1} AsioID: {2} Ryhmä: {3}", Etunimi, Sukunimi, AsioID, Ryhma);
        }
        #endregion
    }
}
