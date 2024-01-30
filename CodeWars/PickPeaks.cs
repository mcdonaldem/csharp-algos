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
            var output = new Dictionary<string, List<int>>() { { "pos", new List<int>() }, { "peaks", new List<int>() } };

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] - arr[i - 1] > 0 && arr[i + 1] - arr[i] < 0)
                {
                    output["pos"].Add(i);
                    output["peaks"].Add(arr[i]);
                }
                else if (arr[i] - arr[i - 1] > 0 && arr[i + 1] - arr[i] == 0)
                {
                    var plateauEnds = false;
                    for (int j = i + 1; j < arr.Length - 1; j++)
                    {
                        if (arr[j] - arr[j - 1] == 0 && arr[j + 1] - arr[j] != 0)
                        {
                            if(arr[j + 1] - arr[j] < 0)
                            {
                                plateauEnds = true;
                            }
                            break;
                        }
                    }
                    if (plateauEnds)
                    {
                        output["pos"].Add(i);
                        output["peaks"].Add(arr[i]);
                    }
                }
            }
            return output;
        }
    }
}
