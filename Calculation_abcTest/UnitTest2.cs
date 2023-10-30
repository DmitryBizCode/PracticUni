using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeUni;
using System;

namespace Calculation_abcTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Zero_metod()
        {
            var test = new Pract3(5, 5);
            int res = 0;
            Assert.AreEqual(res, test.Calculate_Second());
        }
        [TestMethod]
        public void Minus_to_plus()
        {
            var test = new Pract3(-232, 232);
            int res = 2;
            Assert.AreEqual(res, test.Calculate_Second());
        }
        [TestMethod]
        public void Zero_to_big_num()
        {
            var test = new Pract3(0, 1000);
            int res = 3;
            Assert.AreEqual(res, test.Calculate_Second());
        }
        [TestMethod]
        public void Double_test()
        {
            var test = new Pract3(Convert.ToInt32(231.9), 1000);
            int res = 3;
            Assert.AreEqual(res, test.Calculate_Second());
        }
        [TestMethod]
        public void Throw_metod()
        {
            var test = new Pract3(200, 0);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => test.Calculate_Second());
        }
    }
}
