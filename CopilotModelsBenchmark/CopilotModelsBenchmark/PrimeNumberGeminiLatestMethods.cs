namespace CopilotModelsBenchmark
{
    public class PrimeNumberGeminiLatestMethods
    {
        public static long PrimeNumberGeminiLatest(int n)
        {
            if (n <= 0)
            {
            throw new ArgumentOutOfRangeException(nameof(n), "Input must be a positive integer.");
            }

            if (n == 1)
            {
            return 2; // First prime number
            }

            int count = 1; // Count of primes found, starting with 2 already accounted for.
            long candidate = 3; // Next number to check for primality

            while (true)
            {
            if (IsPrime(candidate))
            {
                count++;
                if (count == n)
                {
                return candidate;
                }
            }
            // Move to the next odd number; even numbers greater than 2 are not prime.
            // Overflow check for candidate is implicitly handled by long's range;
            // if n is so large that candidate overflows long, n is too large for int.
            candidate += 2;
            }
        }

        private static bool IsPrime(long number)
        {
            if (number <= 1) return false; // Numbers less than or equal to 1 are not prime.
            if (number <= 3) return true;  // 2 and 3 are prime.

            // Eliminate multiples of 2 and 3 early.
            if (number % 2 == 0 || number % 3 == 0) return false;

            // Check for primality using 6k ± 1 optimization.
            // All primes greater than 3 can be expressed in the form 6k ± 1.
            // We only need to check divisibility up to sqrt(number).
            // (i * i <= number) is an optimized way to check i <= sqrt(number).
            for (long i = 5; i * i <= number; i = i + 6)
            {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
            }

            return true;
        }
    }
}