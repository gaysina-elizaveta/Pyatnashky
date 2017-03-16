using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyathashki_2_3
{
    class Reader
    {
        static public int[] read(string path)
        {
            var stringgets = File.ReadAllText(path).Split(',');
            var gets = new int[stringgets.Length];
            for (int i = 0; i < gets.Length; i++)
            {
                gets[i] = Convert.ToInt32(stringgets[i]);
            }
            return gets;
        }

    }
}
