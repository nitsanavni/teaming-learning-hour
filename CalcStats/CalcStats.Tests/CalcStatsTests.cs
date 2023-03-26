using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace CalcStats.Tests
{
    public class CalcStatsTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 1)]
        [InlineData(new int[] { 3, 2, 1 }, 1)]
        public void MinimumValueTest(int[] numbers, int expectedMinimumValue)
        {
            var calcStats = new CalcStats();

            calcStats.CalculateStats(numbers);

            Assert.Equal(expectedMinimumValue, calcStats.MinimumValue);
        }

    }
}