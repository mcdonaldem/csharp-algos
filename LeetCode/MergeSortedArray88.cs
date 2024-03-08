using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MergeSortedArray88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m + n - 1; i >= 0; i--)
            {
                if (n == 0) break;
                var is1bigger = nums1[m - 1 < 0 ? 0 : m - 1] > nums2[n - 1];
                if (is1bigger)
                {
                    nums1[i] = nums1[m - 1];
                    nums1[m - 1] = 0;
                    m--;
                }
                else
                {
                    nums1[i] = nums2[n - 1];
                    n--;
                }
            }
        }
    }
}
