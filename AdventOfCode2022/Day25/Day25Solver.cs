﻿using System;
using System.Collections.Generic;

namespace AdventOfCode2022.Day25
{
    public class Day25Solver : IDaySolver
    {
        private readonly IEnumerable<string> input;

        public Day25Solver(string input)
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