using FluentAssertions;
using System.IO;

namespace AdventOfCode2022.Tests.Utilities
{
    internal static class TestUtilities
    {
        internal static void SolvePart1CustomTest(IDaySolver daySolver, long expectedResult)
        {
            daySolver.SolvePart1().Should().Be(expectedResult);
        }

        internal static void SolvePart1Test(string solverFolder, IDaySolver daySolver)
        {
            string expectedResult = File.ReadAllText(Path.Combine(solverFolder, $"Part1Output.txt"));

            SolvePart1CustomTest(daySolver, int.Parse(expectedResult));
        }

        internal static void SolvePart2CustomTest(IDaySolver daySolver, long expectedResult)
        {
            daySolver.SolvePart2().Should().Be(expectedResult);
        }

        internal static void SolvePart2Test(string solverFolder, IDaySolver daySolver)
        {
            string expectedResult = File.ReadAllText(Path.Combine(solverFolder, $"Part2Output.txt"));

            SolvePart2CustomTest(daySolver, int.Parse(expectedResult));
        }
    }
}