using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class NumberGoodPairs1512
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var ns = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!ns.ContainsKey(nums[i]))
                {
                    ns.Add(nums[i], 1);
                }
                else
                {
                    var value = (int)ns[nums[i]];
                    ns[nums[i]] = ++value;
                }
            }
            var goodPairs = 0;
            foreach (DictionaryEntry de in ns)
            {
                goodPairs += ((int)de.Value * ((int)de.Value - 1) / 2);
            }
            return goodPairs;
        }
    }
}
