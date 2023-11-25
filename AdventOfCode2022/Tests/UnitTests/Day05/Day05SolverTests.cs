using AdventOfCode2022.Day05;
using AdventOfCode2022.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022.Tests.UnitTests.Day05
{
    [TestClass]
    public class Day05SolverTests
    {
        private static string? SolverFolder;
        private static string? TestsFolder;
        private static IDaySolver? DaySolver;

        [ClassInitialize]
        public static void Initialize(TestContext _)
        {
            (SolverFolder, TestsFolder) = TestUtilities.GetFolders<Day05Solver>();

            string input = TestUtilities.GetInput(SolverFolder);

            DaySolver = new Day05Solver(input);
        }

        [TestMethod]
        [DataRow("Example1", -1)]
        public void SolvePart1CustomTest(string exampleInputName, long expectedResult)
        {
            TestUtilities.SolvePart1CustomTest(
                input => new Day05Solver(input), TestsFolder!, exampleInputName, expectedResult);
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
                input => new Day05Solver(input), TestsFolder!, exampleInputName, expectedResult);
        }

        [TestMethod]
        public void SolvePart2Test()
        {
            TestUtilities.SolvePart2Test(SolverFolder!, DaySolver!);
        }
    }
}