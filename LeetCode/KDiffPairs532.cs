using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class KDiffPairs532
    {
        public int FindPairs(int[] nums, int k)
        {
            if (k == 0)
            {
                return nums
                    .GroupBy(n => n)
                    .Where(n => n.ToList().Count > 1)
                    .Count()
                    ;
            }
            else
            {
                var pairs = 0;
                var distinct = new HashSet<int>(nums).ToArray();
                for (int i = 0; i < distinct.Length; i++)
                {
                    for (int j = i + 1; j < distinct.Length; j++)
                    {
                        if (distinct[i] - distinct[j] == k || distinct[j] - distinct[i] == k)
                        {
                            pairs++;
                        }
                    }
                }
                return pairs;
            }
        }
    }
}
