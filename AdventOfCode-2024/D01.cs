using AdventOfCode_2024.AlgoInputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2024
{
    internal class D01
    {
        private List<string> puzzleInputE1;
        private List<String> puzzleInputE2;

        public D01()
        {
            puzzleInputE1 = PuzzleInput.GetPuzzleInput("D01_FILE_PATH");
            ChangeWordsToDigits();
        }

        public int SumCalibrationValuesE1()
        {
            return SumCalibrationValues(puzzleInputE1);
        }

        public int SumCalibrationValuesE2()
        {
            return SumCalibrationValues(puzzleInputE2);
        }

        private int SumCalibrationValues(List<string> input)
        {
            return input.Select(s => int.Parse(s.First(c => char.IsDigit(c)).ToString() + s.Last(c => char.IsDigit(c)).ToString())).Sum();
        }

        private void ChangeWordsToDigits()
        {
            var wordToDigit = new Dictionary<string, string>()
            {
                ["one"] = "o1e",
                ["two"] = "t2o",
                ["three"] = "t3e",
                ["four"] = "f4r",
                ["five"] = "f5e",
                ["six"] = "s6x",
                ["seven"] = "s7n",
                ["eight"] = "e8t",
                ["nine"] = "n9e"
            };

            puzzleInputE2 = puzzleInputE1
                .Select(s =>
                {
                    var sb = new StringBuilder(s);
                    if (wordToDigit.Keys.ToList().Any(k => s.Contains(k)))
                    {
                        wordToDigit.Keys.ToList().ForEach(k => sb.Replace(k, wordToDigit[k]));
                    }
                    return sb.ToString();
                })
                .ToList();
        }

    }
}
