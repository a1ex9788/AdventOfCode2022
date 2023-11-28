using AdventOfCode2022.Day08;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022.Tests.UnitTests.Day08
{
    [TestClass]
    public class HighestScenicScoreCalculatorTests
    {
        private static readonly int[,] treesMap =
            {
                { 3, 3, 6, 2, 3 },
                { 5, 3, 5, 5, 0 },
                { 3, 5, 3, 5, 3 },
                { 9, 4, 3, 1, 7 },
                { 0, 9, 2, 2, 3 },
            };

        [TestMethod]
        public void Example1Test()
        {
            HighestScenicScoreCalculator highestScenicScoreCalculator =
                new HighestScenicScoreCalculator(treesMap, 5, 5);

            int highestScenicScore = highestScenicScoreCalculator.Calculate(2, 3);

            highestScenicScore.Should().Be(4);
        }

        [TestMethod]
        public void Example2Test()
        {
            HighestScenicScoreCalculator highestScenicScoreCalculator =
                new HighestScenicScoreCalculator(treesMap, 5, 5);

            int highestScenicScore = highestScenicScoreCalculator.Calculate(2, 1);

            highestScenicScore.Should().Be(8);
        }
    }
}