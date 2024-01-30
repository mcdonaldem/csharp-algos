using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class GreedIsGood
    {

        public static int Score(int[] dice)
        {
            int score = dice
                .Select(n => n == 1 ? 100 : n == 5 ? 50 : 0)
                .Sum();

            for(int i = 1; i < 7; i++)
            {
                if(dice.Count(num => num == i) >= 3)
                {
                    score += i == 1 ? 700 : i == 5 ? 350 : i * 100;
                }
            }

            return score;
        }


        public static int Score1(int[] dice)
        {
            int score = 0;

            var valueQuantities = dice
                .GroupBy(n => n)
                .ToDictionary(n => n.Key, n => n.Count());

            foreach (var kvp in valueQuantities.Where(kvp => kvp.Value >= 3))
            {
                score += kvp.Key == 1 ? 1000 : kvp.Key * 100;
                for (int i = 0; i < 3; i++)
                {
                    if (dice[i] == kvp.Key)
                    {
                        dice[i] = 0;
                    }
                }
            }

            foreach (var n in dice)
            {
                score += n == 1 ? 100 : n == 5 ? 50 : 0;
            }
            return score;
        }
    }
}
