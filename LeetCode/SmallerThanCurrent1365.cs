using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SmallerThanCurrent1365
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var numsOriginal = new int[nums.Length];
            Array.Copy(nums, numsOriginal, nums.Length);
            // Bubble sort input
            for(int i = 0 ;i < nums.Length - 1; i++)
            {
                for(int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        var temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            var output = new int[nums.Length];
            for(int i = 0; i < output.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == numsOriginal[i])
                    {
                        output[i] = j;
                        break;
                    }
                }
            }
            return output;
        }
    }
}
