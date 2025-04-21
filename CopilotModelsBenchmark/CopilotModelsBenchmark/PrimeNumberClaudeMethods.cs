namespace CopilotModelsBenchmark
{
    public class PrimeNumberClaudeMethods
    {
        /// <summary>
        /// Returns the nth prime number using an optimized approach.
        /// </summary>
        /// <param name="n">The position of the prime number to find (1-based index)</param>
        /// <returns>The nth prime number</returns>
        public static int PrimeNumberClaude(int n)
        {
            if (n <= 0) throw new ArgumentException("Input must be a positive integer,", nameof(n));
            if (n == 1) return 2;
            if (n == 2) return 3;

            int count = 2;
            int candidate = 3;

            // Skip even numbers since they're not prime (except 2)
            while (count < n)
            {
                candidate += 2;

                // Check if candidate is prime
                bool isPrime = true;
                int sqrt = (int)Math.Sqrt(candidate);

                // We only need to check divisibility up to the square root
                for (int i = 3; i <= sqrt; i += 2)
                {
                    if (candidate % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    count++;
                }
            }

            return candidate;
        }
    }
}
