using System;

namespace CopilotModelsBenchmark
{
    public class PrimeNumbersQwenMethods
    {
        public static int PrimeNumberQwen(int n)
        {
            // Handle edge cases
            if (n <= 0) return 0; // Invalid input
            if (n == 1) return 2; // 2 is the first prime

            int count = 1; // Start with the first prime (2)
            int candidate = 3; // Check odd numbers starting from 3

            while (true)
            {
                if (IsPrime(candidate))
                {
                    count++;
                    if (count == n)
                        return candidate;
                }
                candidate += 2; // Skip even numbers
            }
        }

        private static bool IsPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            int sqrtNum = (int)Math.Sqrt(num);
            for (int i = 3; i <= sqrtNum; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}