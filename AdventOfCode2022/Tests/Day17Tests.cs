using AdventOfCode2022;
using AdventOfCode2022Tests.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022Tests
{
    [TestClass]
    public class Day17Tests : Tester
    {
        protected override Solver Solver => new Day17(Resources.Day17Input);

        protected override string Part1Output => Resources.Day17Part1Output;
        protected override string Part2Output => Resources.Day17Part2Output;

        [TestMethod]
        [DataRow("\r\n", -1)]
        public void SolvePart1Test(string input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, new Day17(input).SolvePart1());
        }

        [TestMethod]
        [DataRow("\r\n", -1)]
        public void SolvePart2Test(string input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, new Day17(input).SolvePart2());
        }
    }
}