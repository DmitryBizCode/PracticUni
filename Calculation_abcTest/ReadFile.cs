using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeUni;
using System;
using System.Collections.Generic;
using System.IO;

namespace Calculation_abcTest
{
    [TestClass]
    public class ReadFile
    {
        [TestMethod]
        public void Readfromit_InvalidDataInFile_ThrowsAccessViolationException()
        {
            // Arrange
            Outfile outfile = new Outfile();
            Array_change a = new Array_change();
            string filename = "invalid_data.txt";

            File.WriteAllText(filename, "1.23\n4.56\n7.89\nfgb");

            // Act and Assert
            Assert.ThrowsException<FormatException>(() => outfile.Readfromit(filename, a));
        }
        
        [TestMethod]
        public void Throw_metod()
        {
            Outfile outfile = new Outfile();
            Array_change a = new Array_change();
            string filename = "odd_total_lines.txt";
            File.WriteAllText(filename, "1.23\n4.56\n7.89\n");

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => outfile.Readfromit(filename, a));
        }
        [TestMethod]
        public void Correct_out_file()
        {
            Outfile outfile = new Outfile();
            Array_change a = new Array_change();
            string filename = "1.txt";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
            {
                file.WriteLine("1,23");
                file.WriteLine("4,56");
                file.WriteLine("1");
                file.WriteLine("7,89");
            }
            outfile.Readfromit(filename, a);

            CollectionAssert.AreEqual(new List<double> { 1.23, 4.56 }, a.arr1);
        }       
    }
}
