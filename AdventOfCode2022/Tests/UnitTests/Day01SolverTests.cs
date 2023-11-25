using AdventOfCode2022.Day01;
using AdventOfCode2022.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AdventOfCode2022.Tests.UnitTests
{
    [TestClass]
    public class Day01SolverTests
    {
        private static string? SolverFolder;
        private static IDaySolver? DaySolver;

        [ClassInitialize]
        public static void Initialize(TestContext _)
        {
            string subfolder = typeof(Day01Solver).Name.Replace("Solver", string.Empty);
            SolverFolder = Path.Combine("..", "..", "..", "..", subfolder);

            string input = File.ReadAllText(Path.Combine(SolverFolder, "Input.txt"));

            DaySolver = new Day01Solver(input);
        }

        [TestMethod]
        [DataRow("1000\r\n2000\r\n3000\r\n\r\n4000\r\n\r\n5000\r\n6000\r\n\r\n7000\r\n8000\r\n9000\r\n\r\n10000", 24000)]
        public void SolvePart1CustomTest(string input, long expectedResult)
        {
            TestUtilities.SolvePart1CustomTest(new Day01Solver(input), expectedResult);
        }

        [TestMethod]
        public void SolvePart1Test()
        {
            TestUtilities.SolvePart1Test(SolverFolder!, DaySolver!);
        }

        [TestMethod]
        [DataRow("1000\r\n2000\r\n3000\r\n\r\n4000\r\n\r\n5000\r\n6000\r\n\r\n7000\r\n8000\r\n9000\r\n\r\n10000", 45000)]
        public void SolvePart2CustomTest(string input, long expectedResult)
        {
            TestUtilities.SolvePart2CustomTest(new Day01Solver(input), expectedResult);
        }

        [TestMethod]
        public void SolvePart2Test()
        {
            TestUtilities.SolvePart2Test(SolverFolder!, DaySolver!);
        }
    }
}