using System;
using Xunit;

namespace CopilotModelsBenchmark.Tests
{
    public class PrimeNumbersGeminiMethodsTests
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
        public void PrimeNumberGemini_ValidInput_ReturnsCorrectPrimeNumber(int position, long expectedPrime)
        {
            // Act
            long result = PrimeNumbersGeminiMethods.PrimeNumberGemini(position);

            // Assert
            Assert.Equal(expectedPrime, result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-5)]
        [InlineData(-100)]
        public void PrimeNumberGemini_InvalidInput_ThrowsArgumentOutOfRangeException(int invalidPosition)
        {
            // Act & Assert
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
                PrimeNumbersGeminiMethods.PrimeNumberGemini(invalidPosition));

            Assert.Contains("n must be a positive integer", exception.Message);
        }

        [Fact]
        public void PrimeNumberGemini_LargeInput_ReturnsCorrectPrimeNumber()
        {
            // Arrange
            int position = 100;
            long expected = 541; // 100th prime number

            // Act
            long result = PrimeNumbersGeminiMethods.PrimeNumberGemini(position);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PrimeNumberGemini_PerformanceTest_CompletesWithinTimeLimit()
        {
            // This is a simple performance test to ensure the method completes within a reasonable time
            // Arrange
            int position = 1000;

            // Act & Assert - should complete within 5 seconds
            var task = System.Threading.Tasks.Task.Run(() => PrimeNumbersGeminiMethods.PrimeNumberGemini(position));
            bool completed = task.Wait(TimeSpan.FromSeconds(5));

            Assert.True(completed, "Prime number calculation took too long");
        }

        [Fact]
        public void PrimeNumberGemini_VeryLargeInput_HandlesCorrectly()
        {
            // Arrange
            int position = 200;
            long expected = 1223; // 200th prime number

            // Act
            long result = PrimeNumbersGeminiMethods.PrimeNumberGemini(position);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}