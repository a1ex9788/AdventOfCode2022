using AdventOfCode2022.Day20;
using AdventOfCode2022.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022.Tests.UnitTests.Day20
{
    [TestClass]
    public class Day20SolverTests
    {
        private static string? SolverFolder;
        private static string? TestsFolder;
        private static IDaySolver? DaySolver;

        [ClassInitialize]
        public static void Initialize(TestContext _)
        {
            (SolverFolder, TestsFolder) = TestUtilities.GetFolders<Day20Solver>();

            string input = TestUtilities.GetInput(SolverFolder);

            DaySolver = new Day20Solver(input);
        }

        [TestMethod]
        [DataRow("Example1", -1)]
        public void SolvePart1CustomTest(string exampleInputName, long expectedResult)
        {
            TestUtilities.SolvePart1CustomTest(
                input => new Day20Solver(input), TestsFolder!, exampleInputName, expectedResult);
        }

        [TestMethod]
        public void SolvePart1Test()
        {
            TestUtilities.SolvePart1Test(SolverFolder!, DaySolver!);
        }

        [TestMethod]
        [DataRow("Example1", -1)]
        public void SolvePart2CustomTest(string exampleInputName, long expectedResult)
        {
            TestUtilities.SolvePart2CustomTest(
                input => new Day20Solver(input), TestsFolder!, exampleInputName, expectedResult);
        }

        [TestMethod]
        public void SolvePart2Test()
        {
            TestUtilities.SolvePart2Test(SolverFolder!, DaySolver!);
        }
    }
}