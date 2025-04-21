namespace CopilotModelsBenchmark
{
    public class PrimeNumbers4oMethods
    {
        public static int PrimeNumber4o(int n)
        {
            if (n < 1) throw new ArgumentException("n must be greater than 0");

            int count = 0;
            int number = 1;

            while (count < n)
            {
                number++;
                if (IsPrime(number))
                {
                    count++;
                }
            }

            return number;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            int limit = (int)Math.Sqrt(number);
            for (int i = 5; i <= limit; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
