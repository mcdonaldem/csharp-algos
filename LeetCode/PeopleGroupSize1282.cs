using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PeopleGroupSize1282
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var ids = Enumerable
                .Range(0, groupSizes.Length)
                .ToList()
                ;
            for (int i = 0; i < groupSizes.Length - 1; i++)
            {
                for (int j = 0; j < groupSizes.Length - 1 - i; j++)
                {
                    if (groupSizes[j] > groupSizes[j + 1])
                    {
                        var temp = groupSizes[j];
                        groupSizes[j] = groupSizes[j + 1];
                        groupSizes[j + 1] = temp;

                        var tempId = ids[j];
                        ids[j] = ids[j + 1];
                        ids[j + 1] = tempId;
                    }
                }
            }
            var output = new List<IList<int>>();
            for (int i = 0; i < groupSizes.Length; i += groupSizes[i])
            {
                output.Add(ids.GetRange(i, groupSizes[i]));
            }
            return output;
        }
    }
}
