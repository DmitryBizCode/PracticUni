using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUni
{
    internal class Show_arr_solid
    {
        public string Show_arr(List<double> a)
        {
            string str = "";
            for (int i = 0;i < a.Count; i++)            
                str+= a[i].ToString()+"; ";            
            if (str.Length > 2)
                str = str.Remove(str.Length - 2);
            return str;
        }
    }
}
