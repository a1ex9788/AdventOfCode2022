﻿using AdventOfCode2022.Day19;
using AdventOfCode2022.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AdventOfCode2022.Tests.UnitTests
{
    [TestClass]
    public class Day19SolverTests
    {
        private static string? SolverFolder;
        private static IDaySolver? DaySolver;

        [ClassInitialize]
        public static void Initialize(TestContext _)
        {
            string subfolder = typeof(Day19Solver).Name.Replace("Solver", string.Empty);
            SolverFolder = Path.Combine("..", "..", "..", "..", subfolder);

            string input = File.ReadAllText(Path.Combine(SolverFolder, "Input.txt"));

            DaySolver = new Day19Solver(input);
        }

        [TestMethod]
        [DataRow("Input", -1)]
        public void SolvePart1CustomTest(string input, long expectedResult)
        {
            TestUtilities.SolvePart1CustomTest(new Day19Solver(input), expectedResult);
        }

        [TestMethod]
        public void SolvePart1Test()
        {
            TestUtilities.SolvePart1Test(SolverFolder!, DaySolver!);
        }

        [TestMethod]
        [DataRow("Input", -1)]
        public void SolvePart2CustomTest(string input, long expectedResult)
        {
            TestUtilities.SolvePart2CustomTest(new Day19Solver(input), expectedResult);
        }

        [TestMethod]
        public void SolvePart2Test()
        {
            TestUtilities.SolvePart2Test(SolverFolder!, DaySolver!);
        }
    }
}