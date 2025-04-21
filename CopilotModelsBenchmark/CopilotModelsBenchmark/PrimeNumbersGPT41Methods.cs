namespace CopilotModelsBenchmark
{
    public class PrimeNumbersGPT41Methods
    {
        public static int PrimeNumber41(int n)
        {
            if (n < 1) throw new ArgumentOutOfRangeException(nameof(n), "n must be greater than 0.");

            if (n == 1) return 2;
            if (n == 2) return 3;

            // Estimate upper bound for nth prime using the n*log(n*log(n)) approximation
            int upper = (int)(n * (Math.Log(n) + Math.Log(Math.Log(n)))) + 10;
            bool[] isComposite = new bool[upper + 1];
            int count = 0;

            for (int i = 2; i <= upper; i++)
            {
                if (!isComposite[i])
                {
                    count++;
                    if (count == n)
                        return i;
                    for (int j = i * 2; j <= upper; j += i)
                        isComposite[j] = true;
                }
            }

            throw new Exception("Prime not found within estimated range.");
        }
    }
}
