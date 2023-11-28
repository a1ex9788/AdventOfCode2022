using AdventOfCode2022.Day08;
using AdventOfCode2022.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022.Tests.UnitTests.Day08
{
    [TestClass]
    public class Day08SolverTests
    {
        private static string? SolverFolder;
        private static string? TestsFolder;
        private static IDaySolver? DaySolver;

        [ClassInitialize]
        public static void Initialize(TestContext _)
        {
            (SolverFolder, TestsFolder) = TestUtilities.GetFolders<Day08Solver>();

            string input = TestUtilities.GetInput(SolverFolder);

            DaySolver = new Day08Solver(input);
        }

        [TestMethod]
        [DataRow("Example1", "21")]
        public void SolvePart1CustomTest(string exampleInputName, string expectedResult)
        {
            TestUtilities.SolvePart1CustomTest(
                input => new Day08Solver(input), TestsFolder!, exampleInputName, expectedResult);
        }

        [TestMethod]
        public void SolvePart1Test()
        {
            TestUtilities.SolvePart1Test(SolverFolder!, DaySolver!);
        }

        [TestMethod]
        [DataRow("Example1", "8")]
        public void SolvePart2CustomTest(string exampleInputName, string expectedResult)
        {
            TestUtilities.SolvePart2CustomTest(
                input => new Day08Solver(input), TestsFolder!, exampleInputName, expectedResult);
        }

        [TestMethod]
        public void SolvePart2Test()
        {
            TestUtilities.SolvePart2Test(SolverFolder!, DaySolver!);
        }
    }
}