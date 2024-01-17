using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2024
{
    internal class Day01
    {
        private List<String> puzzleInput;

        public Day01()
        {
            GetPuzzleInput();
        }

        private void GetPuzzleInput()
        {
            puzzleInput = File
                .ReadLines(Environment.GetEnvironmentVariable("D01_P1_FILE_PATH"))
                .ToList()
                ;
        }

        public int SumCalibrationValues()
        {
            return puzzleInput.Select(s => int.Parse(s.First(c => char.IsDigit(c)).ToString() + s.Last(c => char.IsDigit(c)).ToString())).Sum();
        }

    }
}
