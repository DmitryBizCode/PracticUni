using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUni
{
    internal class Outfile
    {
        public void Readfromit(string filename, Array_change a)
        {
            // Вказуємо культуру з комою як десятковим роздільником
            CultureInfo culture = new CultureInfo("fr-FR");

            using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default))
            {
                string line = "";
                int count = 0;
                int totalLines = File.ReadLines(filename).Count();
                if (totalLines % 2 == 1)
                    throw new ArgumentOutOfRangeException("Invalid enter data");
                
                try
                {
                    for (; (line = sr.ReadLine()) != null;)
                    {
                        if (count < totalLines / 2)
                            a.arr1.Add(Math.Round(double.Parse(line, culture), 2));
                        else
                            a.arr2.Add(Math.Round(double.Parse(line, culture), 2));
                        count++;
                    }
                }
                catch
                {
                    throw new AccessViolationException("Error in file");
                }
            }
        }
    }
}
