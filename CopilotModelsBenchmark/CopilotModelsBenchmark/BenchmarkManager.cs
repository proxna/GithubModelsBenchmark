using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopilotModelsBenchmark
{
    [MinColumn, MaxColumn]
    public class BenchmarkManager
    {
        [Benchmark]
        public void PrimeNumber4o()
        {
            for (int i = 1; i <= 1000; i++)
            {
                PrimeNumbers4oMethods.PrimeNumber4o(i);
            }
        }

        [Benchmark]
        public void PrimeNumberClaude()
        {
            for (int i = 1; i <= 1000; i++)
            {
                PrimeNumberClaudeMethods.PrimeNumberClaude(i);
            }
        }

        [Benchmark]
        public void PrimeNumber41()
        {
            for (int i = 1; i <= 1000; i++)
            {
                PrimeNumbersGPT41Methods.PrimeNumber41(i);
            }
        }

        [Benchmark]
        public void PrimeNumberGemini()
        {
            for (int i = 1; i <= 1000; i++)
            {
                PrimeNumbersGeminiMethods.PrimeNumberGemini(i);
            }
        }
    }
}
