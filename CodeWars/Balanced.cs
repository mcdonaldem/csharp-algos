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
                var str = "";
                var temp = i;
                var upperSum = 1;
                var lowerSum = -1;

                for (int j = 1; j <= 2 * (n - 1); j++)
                {
                    if ((temp & 1) == 0)
                    {
                        if (j < n)
                        {
                            lowerSum--;
                        }
                        else
                        {
                            upperSum--;
                        }
                        str = ")" + str;
                    }
                    else
                    {
                        if (j < n)
                        {
                            lowerSum++;
                        }
                        else
                        {
                            upperSum++;
                        }
                        str = "(" + str;
                    }
                    temp = temp >> 1;
                }

                if (upperSum >= 0 && lowerSum <= 0 && upperSum + lowerSum == 0)
                {
                    output.Add("(" + str + ")");
                }
            }
            return output;
        }
    }
}
