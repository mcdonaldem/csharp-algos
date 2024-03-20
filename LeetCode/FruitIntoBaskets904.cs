using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FruitIntoBaskets904
    {
        public int TotalFruit(int[] fruits)
        {
            var max = 0;
            var varieties = new HashSet<int>();
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits.Length - i < max) break;
                var segMax = 0;
                for (int j = i; j < fruits.Length; j++)
                {
                    if (varieties.Count < 2 && !varieties.Contains(fruits[j]))
                    {
                        varieties.Add(fruits[j]);
                        segMax++;
                    }
                    else if (varieties.Contains(fruits[j]))
                    {
                        segMax++;
                    }
                    else
                    {
                        break;
                    }
                }
                max = segMax > max ? segMax : max;
                varieties.Clear();
            }
            return max;
        }
    }
}
