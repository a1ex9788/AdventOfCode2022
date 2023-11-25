using FluentAssertions;
using System;
using System.IO;

namespace AdventOfCode2022.Tests.Utilities
{
    internal static class TestUtilities
    {
        internal static (string SolverFolder, string TestsFolder) GetFolders<T>()
            where T : IDaySolver
        {
            string logicFolder = Path.Combine("..", "..", "..", "..");
            string subfolder = typeof(T).Name.Replace("Solver", string.Empty);
            string solverFolder = Path.Combine(logicFolder, subfolder);
            string testsFolder = Path.Combine(logicFolder, "Tests", "UnitTests", subfolder);

            return (solverFolder, testsFolder);
        }

        internal static string GetInput(string solverFolder)
        {
            return File.ReadAllText(Path.Combine(solverFolder, "Input.txt")); ;
        }

        internal static void SolvePart1CustomTest(
            Func<string, IDaySolver> getDaySolverFunc,
            string testFolder,
            string exampleInputName,
            long expectedResult)
        {
            string input = File.ReadAllText(Path.Combine(testFolder, $"{exampleInputName}Input.txt")); ;

            getDaySolverFunc.Invoke(input).SolvePart1().Should().Be(expectedResult);
        }

        internal static void SolvePart1Test(string solverFolder, IDaySolver daySolver)
        {
            string expectedResult = File.ReadAllText(Path.Combine(solverFolder, "Part1Output.txt"));

            daySolver.SolvePart1().Should().Be(int.Parse(expectedResult));
        }

        internal static void SolvePart2CustomTest(
            Func<string, IDaySolver> getDaySolverFunc,
            string testFolder,
            string exampleInputName,
            long expectedResult)
        {
            string input = File.ReadAllText(Path.Combine(testFolder, $"{exampleInputName}Input.txt")); ;

            getDaySolverFunc.Invoke(input).SolvePart2().Should().Be(expectedResult);
        }

        internal static void SolvePart2Test(string solverFolder, IDaySolver daySolver)
        {
            string expectedResult = File.ReadAllText(Path.Combine(solverFolder, "Part2Output.txt"));

            daySolver.SolvePart2().Should().Be(int.Parse(expectedResult));
        }
    }
}