using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Balanced
    {
        public static List<string> BalancedParens(int n)
        {
            if (n == 0) return new List<string>() { "" };

            var output = new List<string>();
            for (int i = 0; i < (int)Math.Pow(2, 2 * (n - 1)); i++)
            {
                var str = ")";
                var temp = i;
                var open = 1;
                var closed = 0;

                for (int j = 1; j <= 2 * (n - 1); j++)
                {
                    if ((temp & 1) == 0 && open >= closed && open < n)
                    {
                        open++;
                        str = ")" + str;
                    }
                    else if ((temp & 1) != 0 && open > closed && closed < n)
                    {
                        closed++;
                        str = "(" + str;
                    }
                    else
                    {
                        break;
                    }
                    temp = temp >> 1;
                }

                closed++;
                str = "(" + str;

                if (str.Length == 2 * n)
                {
                    output.Add(str);
                }
            }
            return output;
        }
    }
}
