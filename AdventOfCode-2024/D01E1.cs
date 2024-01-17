using AdventOfCode_2024.AlgoInputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2024
{
    internal class D01E1
    {
        private List<string> puzzleInput;

        public D01E1()
        {
            puzzleInput = PuzzleInput.GetPuzzleInput("D01_FILE_PATH");
        }

        public int SumCalibrationValues()
        {
            return puzzleInput.Select(s => int.Parse(s.First(c => char.IsDigit(c)).ToString() + s.Last(c => char.IsDigit(c)).ToString())).Sum();
        }

    }
}
