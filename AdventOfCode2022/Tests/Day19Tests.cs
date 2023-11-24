using AdventOfCode2022;
using AdventOfCode2022.Base;
using AdventOfCode2022.Tests.Base;
using AdventOfCode2022Tests.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022Tests
{
    [TestClass]
    public class Day19Tests : DayXXTests
    {
        protected override DayXX Solver => new Day19(Resources.Day19Input);

        protected override string Part1Output => Resources.Day19Part1Output;
        protected override string Part2Output => Resources.Day19Part2Output;

        [TestMethod]
        [DataRow("\r\n", -1)]
        public void SolvePart1Test(string input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, new Day19(input).SolvePart1());
        }

        [TestMethod]
        [DataRow("\r\n", -1)]
        public void SolvePart2Test(string input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, new Day19(input).SolvePart2());
        }
    }
}