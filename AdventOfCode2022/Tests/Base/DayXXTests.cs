using AdventOfCode2022.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdventOfCode2022.Tests.Base
{
    [TestClass]
    public abstract class DayXXTests
    {
        protected abstract DayXX Solver { get; }

        protected abstract string Part1Output { get; }
        protected abstract string Part2Output { get; }

        [TestMethod]
        public void DefaultSolvePart1Test()
        {
            Assert.AreEqual(Convert.ToInt64(Part1Output), Solver.SolvePart1());
        }

        [TestMethod]
        public void DefaultSolvePart2Test()
        {
            Assert.AreEqual(Convert.ToInt64(Part2Output), Solver.SolvePart2());
        }
    }
}