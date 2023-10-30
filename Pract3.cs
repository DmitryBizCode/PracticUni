using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeUni
{
    public class Pract3
    {
        private double A {get; set;}
        private double B { get; set;}
        private double C { get; set;}

        public Pract3(int x, int y)
        {
            A = Convert.ToDouble(x);
            B = Convert.ToDouble(y);
        }
        public Pract3(double x, double y, double z)
        {
            A = x;
            B = y;
            C = z;
        }
        public double Calculate_First() => (A > 0 || B > 0 || C > 0) ? Math.Pow((A+B+C),2) : (A == 0 || B == 0 || C == 0) ? 0 : Math.Pow(A,2) + Math.Pow(B,2) + Math.Pow(C,2);
        public int Calculate_Second()
        {
            try
            {
                if (A > B)
                    throw new ArgumentOutOfRangeException("Invalid enter data");
                if (A == B) 
                    return 0;
                else
                {
                    int sum = 0;
                    for (; A <= B; A++)
                    {
                        if (A % (-29) == 0 && A % (-2) == 0 && A % (-5) == (-2))
                            sum++;
                        if (A % 29 == 0 && A % 2 == 0 && A % 5 == 2)
                            sum++;
                    }                        
                    return sum;
                }                
            }
            catch(Exception)
            {
                throw new ArgumentOutOfRangeException("Invalid enter data");            
            }
        }
    }
}
