using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class BurrowsWheelerTransformation
    {
        public static Tuple<string, int> Encode(string s)
        {
            return null;
        }

        public static string Decode(string s, int i)
        {
            var output = "";
            var firstColumn = s.Order().ToArray();
            var indexVisited = new bool[firstColumn.Length];
            for (int j = 0; j < s.Length; j++)
            {
                output = s[i] + output;
                indexVisited[i] = true;
                i = firstColumn
                    .Select((c, k) => new { Char = c, Index = k })
                    .Last(a => a.Char.Equals(s[i]) && !indexVisited[a.Index])
                    .Index;
            }
            return output;
        }
    }
}
