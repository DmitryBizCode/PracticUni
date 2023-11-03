using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeUni;
using System;

namespace Calculation_abcTest
{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void ThrowMethod()
        {
            var a = new Array_change();
            a.arr1.Add(1);
            a.arr1.Add(1);
            a.arr1.Add(1);
            a.arr2.Add(1); 
            a.arr2.Add(1);        

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => a.Update_array());
        }

        [TestMethod]
        public void ThrowMethodArr2()
        {
            var a = new Array_change();
            a.arr1.Add(1);
            a.arr1.Add(1);
            a.arr2.Add(1);
            a.arr2.Add(1);
            a.arr2.Add(1);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => a.Update_array());
        }

        [TestMethod]
        public void Positive_number()
        {
            var a = new Array_change();
            a.arr1.Add(1);
            a.arr1.Add(2);
            a.arr2.Add(3);
            a.arr2.Add(4);
            a.Update_array();
            Assert.AreEqual(2, a.arr1[0]);
            Assert.AreEqual(2, a.arr2[0]);
            Assert.AreEqual(3, a.arr1[1]);
            Assert.AreEqual(3, a.arr2[1]);
           
        }

        [TestMethod]
        public void One_negative_number()
        {
            var a = new Array_change();
            a.arr1.Add(1);
            a.arr1.Add(-2);
            a.arr2.Add(-3);
            a.arr2.Add(1);
            a.Update_array();
            Assert.AreEqual(1, a.arr1[0]);
            Assert.AreEqual(9, a.arr2[0]);
            Assert.AreEqual(4, a.arr1[1]);
            Assert.AreEqual(1, a.arr2[1]);
        }

        [TestMethod]
        public void All_negative_number()
        {
            var a = new Array_change();
            a.arr1.Add(-1);
            a.arr1.Add(-2);
            a.arr2.Add(-3);
            a.arr2.Add(-4);
            a.Update_array();
            Assert.AreEqual(-0.5, a.arr1[0]);
            Assert.AreEqual(-2.5, a.arr2[0]);
            Assert.AreEqual(-1.5, a.arr1[1]);
            Assert.AreEqual(-3.5, a.arr2[1]);
        }

        [TestMethod]
        public void Power_Class_Throw_method()
        {
            var a = new Array_change();
            var pow = new Powerarray();
            a.arr1.Add(1);
            a.arr1.Add(2);
            a.arr2.Add(3);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => pow.Power_number_array(2, a));
        }

        [TestMethod]
        public void Power_Class_pow_correct()
        {
            var a = new Array_change();
            var pow = new Powerarray();
            a.arr1.Add(1);
            a.arr1.Add(2);
            a.arr2.Add(3);
            a.arr2.Add(4);
            pow.Power_number_array(2, a);
            Assert.AreEqual(2, a.arr1[0]);
            Assert.AreEqual(6, a.arr2[0]);
            Assert.AreEqual(4, a.arr1[1]);
            Assert.AreEqual(8, a.arr2[1]);
        }
    }
}
