using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class ArrayCalcs
    {
        public static double Sum(double[] a)
        {
            double tulos = a.Sum();
            tulos = Math.Round(tulos, 2);
            return tulos;
        }
        public static double Average(double[] a)
        {
            double tulos = a.Average();
            tulos = Math.Round(tulos, 2);
            return tulos;
        }
        public static double Min(double[] a)
        {
            return a.Min();
        }
        public static double Max(double[] a)
        {
            return a.Max();
        }
    }
}
