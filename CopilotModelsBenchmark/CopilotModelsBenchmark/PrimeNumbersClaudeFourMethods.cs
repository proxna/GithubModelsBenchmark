using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopilotModelsBenchmark
{
    internal class PrimeNumbersClaudeFourMethods
    {
        public static long PrimeNumberClaudeFour(int n)
        {
            if (n <= 0) throw new ArgumentException("n must be positive");
            if (n == 1) return 2;
            if (n == 2) return 3;

            var primes = new List<long> { 2, 3 };
            long candidate = 5;

            while (primes.Count < n)
            {
                bool isPrime = true;
                long sqrtCandidate = (long)Math.Sqrt(candidate);

                for (int i = 1; i < primes.Count && primes[i] <= sqrtCandidate; i++)
                {
                    if (candidate % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(candidate);
                }

                candidate += 2; // Skip even numbers
            }

            return primes[n - 1];
        }
    }
}
