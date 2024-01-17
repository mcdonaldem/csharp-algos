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
        private Dictionary<string, int> wordToDigit;
        private Dictionary<int, string> digitToWord;

        public D01E2()
        {
            puzzleInput = PuzzleInput
                .GetPuzzleInput("D01_FILE_PATH");

            wordToDigit = new Dictionary<string, int>()
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5,
                ["six"] = 6,
                ["seven"] = 7,
                ["eight"] = 8,
                ["nine"] = 9
            };

            digitToWord = new Dictionary<int, string>()
            {
                [1] = "one",
                [2] = "two",
                [3] = "three",
                [4] = "four",
                [5] = "five",
                [6] = "six",
                [7] = "seven",
                [8] = "eight",
                [9] = "nine"
            };

            ChangeWordsToDigits();
        }

        private void ChangeWordsToDigits()
        {
            puzzleInput = puzzleInput
                .Select(s =>
                {
                    if (s.Any(c => char.IsLetter(c)) && wordToDigit.Keys.ToList().Any(k => s.Contains(k)))
                    {
                        var sb = new StringBuilder(s);
                        for (var i = 0; i < sb.Length; i++)
                        {
                            if(wordToDigit.Keys.ToList().All(k => !sb.ToString().Contains(k)))
                            {
                                break;
                            }
                            if (char.IsLetter(sb[i]))
                            {
                                for (var j = 1; j <= sb.Length - i; j++)
                                {
                                    var sub = sb.ToString(i, j);
                                    if (wordToDigit.ContainsKey(sub))
                                    {
                                        sb.Remove(i, sub.Length);
                                        sb.Insert(i, wordToDigit[sub]);
                                        break;
                                    }
                                }
                            }
                        }
                        return sb.ToString();
                    }
                    return s;
                })
                .ToList();
        }

        public int SumCalibrationValues()
        {
            var values = puzzleInput.Select(s => int.Parse(s.First(c => char.IsDigit(c)).ToString() + s.Last(c => char.IsDigit(c)).ToString()))
                .ToList();
            return puzzleInput.Select(s => int.Parse(s.First(c => char.IsDigit(c)).ToString() + s.Last(c => char.IsDigit(c)).ToString())).Sum();
        }
    }
}
