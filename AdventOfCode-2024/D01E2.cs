using AdventOfCode_2024.AlgoInputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode_2024
{
    internal class D01E2
    {
        private List<string> puzzleInput;
        private Dictionary<string, string> wordToDigit;

        public D01E2()
        {
            puzzleInput = PuzzleInput
                .GetPuzzleInput("D01_FILE_PATH");

            wordToDigit = new Dictionary<string, string>()
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

            ChangeWordsToDigits();
        }

        private void ChangeWordsToDigits()
        {
            puzzleInput = puzzleInput
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

        public int SumCalibrationValues()
        {
            return puzzleInput.Select(s => int.Parse(s.First(c => char.IsDigit(c)).ToString() + s.Last(c => char.IsDigit(c)).ToString())).Sum();
        }
    }
}
