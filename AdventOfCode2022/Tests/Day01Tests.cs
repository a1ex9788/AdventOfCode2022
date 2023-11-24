using AdventOfCode2022.Day01;
using AdventOfCode2022.Tests.Base;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022Tests
{
    [TestClass]
    public class Day01Tests : DayTests<Day01>
    {
        public Day01Tests()
            : base(input => new Day01(input))
        {
        }

        [TestMethod]
        [DataRow("\r\n", -1)]
        public void SolvePart1CustomTest(string input, long expectedResult)
        {
            new Day01(input).SolvePart1().Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("\r\n", -1)]
        public void SolvePart2CustomTest(string input, long expectedResult)
        {
            new Day01(input).SolvePart2().Should().Be(expectedResult);
        }
    }
}