namespace CopilotModelsBenchmark
{
    public class PrimeNumbersGeminiMethods
    {
        /// <summary>
        /// Finds the nth prime number using optimized trial division.
        /// </summary>
        /// <param name="n">The position of the desired prime number (1-based index).</param>
        /// <returns>The nth prime number.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if n is less than 1.</exception>
        public static long PrimeNumberGemini(int n)
        {
            if (n <= 0)
            {
            throw new ArgumentOutOfRangeException(nameof(n), "n must be a positive integer.");
            }

            if (n == 1)
            {
            return 2; // First prime number is 2
            }

            int count = 1; // We already found the first prime (2)
            long candidate = 3; // Start checking odd numbers from 3

            while (count < n)
            {
            bool isPrime = true;
            long limit = (long)Math.Sqrt(candidate);

            // Check for divisibility only by odd numbers up to the square root
            for (long i = 3; i <= limit; i += 2)
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
                if (count == n)
                {
                return candidate;
                }
            }

            // Move to the next odd number
            candidate += 2;
            }

            // This part should theoretically not be reached if n is valid
            // but added for completeness or potential edge cases in very large n scenarios
            // where long might overflow before finding the nth prime.
            // Consider throwing an exception or returning a specific value if needed.
            // For this implementation, the loop condition ensures we return before this.
            return -1; // Should not happen for valid inputs within long range
        }
    }
}