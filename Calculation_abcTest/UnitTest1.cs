using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PracticeUni;

namespace Calculation_abcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Zero()
        {
            var test = new Pract3(-2,0,-1);
            double res = 0;
            Assert.AreEqual(res, test.Calculate_First());
        }

        [TestMethod]
        public void Pow_sum()
        {
            var test = new Pract3(-1, 5, -2);
            double res = 4;
            Assert.AreEqual(res, test.Calculate_First());
        }

        [TestMethod]
        public void Sum_pow()
        {
            var test = new Pract3(-2, -5, -1);
            double res = 30;
            Assert.AreEqual(res, test.Calculate_First());
        }

        [TestMethod]
        public void Sum_pow_double()
        {
            var test = new Pract3(-2.5, -5, -1);
            double res = 32.25;
            Assert.AreEqual(res, test.Calculate_First());
        }
    }
}
