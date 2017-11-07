using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double tulos = 25.60;

            double tulos2 = ArrayCalcs.Sum(array);

            Assert.AreEqual(tulos, tulos2);
        }

        [TestMethod()]
        public void AverageTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double tulos = 3.66;

            double tulos2 = ArrayCalcs.Average(array);

            Assert.AreEqual(tulos, tulos2);
        }

        [TestMethod()]
        public void MinTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double tulos = -4.50;

            double tulos2 = ArrayCalcs.Min(array);

            Assert.AreEqual(tulos, tulos2);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double tulos = 12.00;

            double tulos2 = ArrayCalcs.Max(array);

            Assert.AreEqual(tulos, tulos2);
        }
    }
}