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
            var rows = s.Select((c, i) => s.Substring(s.Length - i, i) + s.Substring(0, s.Length - i))
                .OrderBy(r => r, StringComparer.Ordinal)
                .ToList()
                ;
            return String.IsNullOrEmpty(s) ? 
                Tuple.Create(s,0) : 
                Tuple.Create(new String(rows.Select(r => r.LastOrDefault()).ToArray()), rows.IndexOf(s));
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
                rows = rows
                    .OrderBy(r => r, StringComparer.Ordinal)
                    .ToArray()
                    ;
            }
            return String.IsNullOrEmpty(s) ? s : rows[i];
        }
    }
}
