using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class IsDivisibleBy6Part2
    {
        public static string[] IsDivisibleBy6(string str)
        {
            var result = ReplaceStars(str);
            return new string[0];
        }

        private static List<BigInteger> ReplaceStars(string str)
        {
            var output = new List<BigInteger>();
            if (str.Count(c => c.Equals('*')) == 0 && BigInteger.Parse(str) % 6 == 0)
            {
                output.Add(BigInteger.Parse(str));
            }
            else if (str.Count(c => c.Equals('*')) > 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    output.AddRange(ReplaceStars(str.Substring(0, str.IndexOf('*')) + i + str.Substring(str.IndexOf('*') + 1)));
                }
            }
            return output;
        }
    }
}
