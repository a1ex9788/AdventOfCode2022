﻿using AdventOfCode2022;
using AdventOfCode2022Tests.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022Tests
{
    [TestClass]
    public class DayXXTests : Tester
    {
        protected override Solver Solver => new DayXX(Resources.DayXXInput);

        protected override string Part1Output => Resources.DayXXPart1Output;
        protected override string Part2Output => Resources.DayXXPart2Output;

        [TestMethod]
        [DataRow("\r\n", -1)]
        public void SolvePart1Test(string input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, new DayXX(input).SolvePart1());
        }

        [TestMethod]
        [DataRow("\r\n", -1)]
        public void SolvePart2Test(string input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, new DayXX(input).SolvePart2());
        }
    }
}