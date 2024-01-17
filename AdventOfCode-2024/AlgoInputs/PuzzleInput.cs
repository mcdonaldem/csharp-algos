using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2024.AlgoInputs
{
    internal class PuzzleInput
    {
        public static List<string> GetPuzzleInput(string ev)
        {
            return File
                .ReadLines(Environment.GetEnvironmentVariable(ev))
                .ToList()
                ;
        }
    }
}
