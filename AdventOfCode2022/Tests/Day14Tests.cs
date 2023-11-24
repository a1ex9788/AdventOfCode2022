using AdventOfCode2022;
using AdventOfCode2022.Base;
using AdventOfCode2022.Tests.Base;
using AdventOfCode2022Tests.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022Tests
{
    [TestClass]
    public class Day14Tests : DayXXTests
    {
        protected override DayXX Solver => new Day14(Resources.Day14Input);

        protected override string Part1Output => Resources.Day14Part1Output;
        protected override string Part2Output => Resources.Day14Part2Output;

        [TestMethod]
        [DataRow("\r\n", -1)]
        public void SolvePart1Test(string input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, new Day14(input).SolvePart1());
        }

        [TestMethod]
        [DataRow("\r\n", -1)]
        public void SolvePart2Test(string input, long expectedResult)
        {
            Assert.AreEqual(expectedResult, new Day14(input).SolvePart2());
        }
    }
}