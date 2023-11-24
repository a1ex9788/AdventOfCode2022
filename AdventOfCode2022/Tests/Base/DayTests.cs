using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace AdventOfCode2022.Tests.Base
{
    [TestClass]
    public abstract class DayTests<T>
        where T : IDay
    {
        private readonly string solverFolder;
        private readonly IDay solver;

        public DayTests(Func<string, IDay> getSolverFunc)
        {
            this.solverFolder = Path.Combine("..", "..", "..", "..", typeof(T).Name);

            string input = File.ReadAllText(Path.Combine(this.solverFolder, "Input.txt"));

            this.solver = getSolverFunc.Invoke(input);
        }

        [TestMethod]
        public void SolvePart1Test()
        {
            string output = File.ReadAllText(Path.Combine(this.solverFolder, "OutputPart1.txt"));

            this.solver.SolvePart1().Should().Be(Convert.ToInt64(output));
        }

        [TestMethod]
        public void SolvePart2Test()
        {
            string output = File.ReadAllText(Path.Combine(this.solverFolder, "OutputPart2.txt"));

            this.solver.SolvePart2().Should().Be(Convert.ToInt64(output));
        }
    }
}