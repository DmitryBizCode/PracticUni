using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUni
{
    public class Array_change
    {

        public List<double> arr1 = new List<double>();
        public List<double> arr2 = new List<double>();

        public Array_change() { }

        public void Create_array() { 
            Random rand = new Random();
            for (int i = 0; i < 10; ++i)
            {
                arr1.Add(Math.Round(rand.NextDouble() * (10 - (-10)) + (-10),2));
                arr2.Add(Math.Round(rand.NextDouble() * (10 - (-10)) + (-10),2));
            }
        }
        public void Update_array() {
            try
            {
                for (int i = 0; i < arr1.Count; ++i)
                {
                    if (arr1[i] < 0 && arr2[i] < 0)
                    {
                        arr1[i] += 0.5;
                        arr2[i] += 0.5;
                    }
                    else if (arr1[i] < 0 || arr2[i] < 0)
                    {
                        if (arr1[i] < 0)
                            arr1[i] = Math.Round(arr1[i] * arr1[i], 2);
                        else
                            arr2[i] = Math.Round(arr2[i] * arr2[i], 2);
                    }
                    else
                    {
                        arr1[i] = Math.Round((arr2[i] + arr1[i]) / 2, 2);
                        arr2[i] = arr1[i];
                    }
                }
                if (arr1.Count != arr2.Count)
                {
                    throw new ArgumentOutOfRangeException("Invalid enter data");
                }
            }
            catch {
                throw new ArgumentOutOfRangeException("Invalid enter data");
            }
            
        }
    }
}
