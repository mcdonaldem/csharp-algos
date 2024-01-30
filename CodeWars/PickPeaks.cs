using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class PickPeaks
    {
        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            var slopes = new int[arr.Length - 1];
            var output = new Dictionary<string, List<int>>() { { "pos", new List<int>() }, { "peaks", new List<int>() } };

            for (int i = 0; i < slopes.Length; i++)
            {
                slopes[i] = arr[i + 1] - arr[i];
            }

            for (int i = 0; i < slopes.Length - 1; i++)
            {
                if (slopes[i] > 0 && slopes[i + 1] <= 0 && (i + 1) != arr.Length - 1)
                {
                    output["pos"].Add(i + 1);
                    output["peaks"].Add(arr[i + 1]);
                }
            }
            return output;
        }
    }
}
