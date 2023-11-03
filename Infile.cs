using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUni
{
    public class Infile : IWritefile
    {
        public Infile() { }
        public void Writeinit(string str, Array_change a)
        {
            using(StreamWriter sw = new StreamWriter(str, false, System.Text.Encoding.Default)) {

                foreach (var item in a.arr1)                
                    sw.WriteLine(item.ToString());

                foreach (var item in a.arr2)                
                    sw.WriteLine(item.ToString());
                
                sw.Close();
            }
        }

    }
}
