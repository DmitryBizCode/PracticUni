using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUni
{
    public class FirstTask{
        public double[,] xy = new double [1000, 2];
        public int n = 0;

        private double F1(double x)
        {
            return (Math.Tan(Math.Pow((x + 3), 2))) / (Math.Pow(Math.Abs(x), 2) * Math.Sin(3 * x));
        }

        private double F2(double x)
        {
            return (Math.Pow(x, 3) - 4 * x + 2) / (Math.Pow(x,2)+Math.Sin(7*x)-1);
        }

        private double F3(double x) 
        {
            return (Math.Tan(0.1 * Math.PI * Math.Pow(x, 2)) + x) / (Math.Pow(Math.Cos(2 * x + 3), 2));
        }

        public void Calculate(double xn, double xk, double h, double a)
        {
            double x = xn, y;
            int i = 0;
            while (x < xk) 
            {
                if (x < 0)
                    y = F1(x);
                else
                {
                    if((x >= 0) && (x >= a))
                        y = F2(x);
                    else 
                        y = F3(x);
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}

