using System;
using System.Collections.Generic;

namespace AdventOfCode2022.Day12
{
    public class Day12Solver : IDaySolver
    {
        private readonly IEnumerable<string> input;

        public Day12Solver(string input)
        {
            this.input = input.Split(Environment.NewLine);

            Console.Write(this.input.ToString());
        }

        public string SolvePart1()
        {
            return string.Empty;
        }

        public string SolvePart2()
        {
            return string.Empty;
        }
    }
}