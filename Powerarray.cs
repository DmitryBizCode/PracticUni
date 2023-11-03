using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUni
{
    public class Powerarray : IPower_arr
    {
        public void Power_number_array(double s, Array_change a)
        {
            try
            {
                for (int i = 0; i < a.arr1.Count; i++)
                {
                    a.arr1[i] = Math.Round(a.arr1[i] * s, 2);
                    a.arr2[i] = Math.Round(a.arr2[i] * s, 2);
                }
            }
            catch 
            {
                throw new ArgumentOutOfRangeException("Error read array");
            }
        }
    }
}
