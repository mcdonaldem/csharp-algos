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
            var rows = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                var first = s.Substring(s.Length - i,i);
                var second = s.Substring(0, s.Length - i);
                rows.Add(first + second);
            }
            rows = rows
                .OrderBy(r => r, StringComparer.Ordinal)
                .ToList()
                ;
            return Tuple.Create(new String(rows.Select(r => r.LastOrDefault()).ToArray()), rows.Count() == 0 ? 0 : rows.IndexOf(s));
        }

        public static string Decode(string s, int i)
        {
            var rows = new string[s.Length];
            for (int j = 0; j < s.Length; j++)
            {
                for (int k = 0; k < s.Length; k++)
                {
                    rows[k] = s[k] + rows[k];
                }
                rows = rows.OrderBy(r => r, StringComparer.Ordinal).ToArray();
            }
            return rows[i];
        }
    }
}
