using BenchmarkDotNet.Attributes;

namespace CopilotModelsBenchmark
{
    [MinColumn, MaxColumn]
    public class BenchmarkManager
    {
        [Benchmark]
        public void PrimeNumber4o()
        {
            int sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum += PrimeNumbers4oMethods.PrimeNumber4o(i);
            }
        }

        [Benchmark]
        public void PrimeNumberClaude()
        {
            int sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum += PrimeNumberClaudeMethods.PrimeNumberClaude(i);
            }
        }

        [Benchmark]
        public void PrimeNumber41()
        {
            int sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum += PrimeNumbersGPT41Methods.PrimeNumber41(i);
            }
        }

        [Benchmark]
        public void PrimeNumberGemini()
        {
            long sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum += PrimeNumbersGeminiMethods.PrimeNumberGemini(i);
            }
        }
    }
}
