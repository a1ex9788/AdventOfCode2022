using AdventOfCode2022;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdventOfCode2022Tests
{
    [TestClass]
    public abstract class Tester
    {
        protected abstract Solver Solver { get; }

        protected abstract string Part1Output { get; }
        protected abstract string Part2Output { get; }

        [TestMethod]
        public void DefaultSolvePart1Test()
        {
            Assert.AreEqual(Convert.ToInt64(this.Part1Output), this.Solver.SolvePart1());
        }

        [TestMethod]
        public void DefaultSolvePart2Test()
        {
            Assert.AreEqual(Convert.ToInt64(this.Part2Output), this.Solver.SolvePart2());
        }
    }
}