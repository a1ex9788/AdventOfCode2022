using AdventOfCode2022;
using AdventOfCode2022Tests.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022Tests
{
    [TestClass]
    public class Day21Tests : Tester
    {
        protected override Solver Solver => new Day21(Resources.Day21Input);

        protected override string Part1Output => Resources.Day21Part1Output;
        protected override string Part2Output => Resources.Day21Part2Output;

        [TestMethod]
        [DataRow("\r\n", -1)]
        public void SolvePart1Test(string input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, new Day21(input).SolvePart1());
        }

        [TestMethod]
        [DataRow("\r\n", -1)]
        public void SolvePart2Test(string input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, new Day21(input).SolvePart2());
        }
    }
}