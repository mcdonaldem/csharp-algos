using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class SumByFactors
    {
        public static string sumOfDivided(int[] lst)
        {
            var primes = new Dictionary<int, int>();
            for (int i = 0; i < lst.Length; i++)
            {
                var iPrimes = GetPrimeFactors(Math.Abs(lst[i]));
                foreach (var p in iPrimes)
                {
                    if (!primes.TryAdd(p, lst[i]))
                    {
                        primes[p] += lst[i];
                    }
                }
            }
            return String.Join("", primes.OrderBy(kvp => kvp.Key).Select(kvp => $"({kvp.Key} {kvp.Value})"));
        }

        private static HashSet<int> GetPrimeFactors(int n)
        {
            var originalN = n;
            var primes = new HashSet<int>();
            // Check for 2
            while (n % 2 == 0)
            {
                primes.Add(2);
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(originalN); i += 2)
            {
                while (n % i == 0)
                {
                    primes.Add(i);
                    n /= i;
                }
                if(n < i)
                {
                    break;
                }
            }
            if (n > 1)
            {
                primes.Add(n);
            }
            return primes;
        }
    }
}
