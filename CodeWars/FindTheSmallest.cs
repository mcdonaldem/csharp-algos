using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class FindTheSmallest
    {
        public static long[] Smallest(long n)
        {
            var output = new long[3] {n, 0, 0};
            for (int i = 0; i < n.ToString().Length; i++)
            {
                for (int j = 0; j < n.ToString().Length; j++)
                {
                    var nDigits = new StringBuilder(n.ToString());
                    var digit = nDigits[i];
                    nDigits.Remove(i, 1);
                    nDigits.Insert(j, digit);
                    if(long.Parse(nDigits.ToString()) < output[0])
                    {
                        output = new long[] { long.Parse(nDigits.ToString()), i, j };
                    }
                }
            }
            return output;
        }
    }
}
