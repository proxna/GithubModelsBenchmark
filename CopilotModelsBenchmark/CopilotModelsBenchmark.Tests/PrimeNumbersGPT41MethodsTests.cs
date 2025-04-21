using System;
using Xunit;

namespace CopilotModelsBenchmark.Tests
{
    public class PrimeNumbersGPT41MethodsTests
    {
        [Theory]
        [InlineData(1, 2)]    // 1st prime is 2
        [InlineData(2, 3)]    // 2nd prime is 3
        [InlineData(3, 5)]    // 3rd prime is 5
        [InlineData(4, 7)]    // 4th prime is 7
        [InlineData(5, 11)]   // 5th prime is 11
        [InlineData(6, 13)]   // 6th prime is 13
        [InlineData(10, 29)]  // 10th prime is 29
        [InlineData(20, 71)]  // 20th prime is 71
        [InlineData(25, 97)]  // 25th prime is 97
        public void PrimeNumber41_ValidInput_ReturnsCorrectPrimeNumber(int position, int expectedPrime)
        {
            // Act
            int result = PrimeNumbersGPT41Methods.PrimeNumber41(position);

            // Assert
            Assert.Equal(expectedPrime, result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-5)]
        [InlineData(-100)]
        public void PrimeNumber41_InvalidInput_ThrowsArgumentOutOfRangeException(int invalidPosition)
        {
            // Act & Assert
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
                PrimeNumbersGPT41Methods.PrimeNumber41(invalidPosition));

            Assert.Contains("n must be greater than 0", exception.Message);
        }

        [Fact]
        public void PrimeNumber41_LargeInput_ReturnsCorrectPrimeNumber()
        {
            // Arrange
            int position = 100;
            int expected = 541; // 100th prime number

            // Act
            int result = PrimeNumbersGPT41Methods.PrimeNumber41(position);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PrimeNumber41_PerformanceTest_CompletesWithinTimeLimit()
        {
            // This is a performance test to ensure the method completes within a reasonable time
            // Arrange
            int position = 1000;

            // Act & Assert - should complete within 5 seconds (using Sieve of Eratosthenes should be fast)
            var task = System.Threading.Tasks.Task.Run(() => PrimeNumbersGPT41Methods.PrimeNumber41(position));
            bool completed = task.Wait(TimeSpan.FromSeconds(5));

            Assert.True(completed, "Prime number calculation took too long");
        }

        [Fact]
        public void PrimeNumber41_VeryLargeInput_HandlesCorrectly()
        {
            // Arrange
            int position = 200;
            int expected = 1223; // 200th prime number

            // Act
            int result = PrimeNumbersGPT41Methods.PrimeNumber41(position);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}