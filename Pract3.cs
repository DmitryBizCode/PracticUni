using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeUni
{
    internal class Pract3
    {
        public double Calculate_First(double x, double y, double z) => (x > 0 || y > 0 || z > 0) ? Math.Pow((x+y+z),2) : Math.Pow(x,2) + Math.Pow(y,2) + Math.Pow(z,2);
        public int Calculate_Second(int x, int y)
        {
            int sum = 0;
            for (; x <= y; x++) 
                if (x % 29 == 0 && x % 2 == 0 && x % 5 == 2)
                    sum++;            
            return sum;
        }
    }
}
