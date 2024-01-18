using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode_2024.AlgoInputs;

namespace AdventOfCode_2024.D02
{
    internal class D02
    {
        private List<Game> games;

        public D02()
        {
            ProcessGameData();
        }

        private void ProcessGameData()
        {
            games = PuzzleInput
                .GetPuzzleInput("D02_FILE_PATH")
                .Select(g =>
                {
                    var gameData = g.Split(":");
                    return new Game()
                    {
                        Id = int.Parse(gameData[0].Split(" ")[1]),
                        CubeSets = gameData[1]
                        .Split(";")
                        .Select(s =>
                        {
                            var dice = s
                                .Split(",")
                                .Select(d => d.Trim())
                                .Select(d =>
                                {
                                    var data = d.Split(" ");
                                    var quantity = int.Parse(data[0]);
                                    return Tuple.Create(data[1], quantity);
                                })
                                .ToDictionary(t => t.Item1, t => t.Item2)
                                ;
                            var cs = new CubeSet()
                            {
                                Red = dice.ContainsKey("red") ? dice["red"] : 0,
                                Green = dice.ContainsKey("green") ? dice["green"] : 0,
                                Blue = dice.ContainsKey("blue") ? dice["blue"] : 0
                            };
                            return cs;
                        })
                        .ToList()
                    };
                })
                .ToList()
                ;
        }

        // E1
        public int SumValidGameIds()
        {
            return games
                .Where(g => g.CubeSets.All(cs => cs.Red <= 12 && cs.Green <= 13 && cs.Blue <= 14))
                .Select(g => g.Id)
                .Sum()
                ;
        }

        // E2
        public int SumCubeSetPowers()
        {
            return games
                .Select(g => g.CubeSets.Max(cs => cs.Red) * g.CubeSets.Max(cs => cs.Green) * g.CubeSets.Max(cs => cs.Blue))
                .Sum()
                ;
        }
    }
}
