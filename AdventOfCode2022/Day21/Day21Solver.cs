﻿using System;
using System.Collections.Generic;

namespace AdventOfCode2022.Day21
{
    public class Day21Solver : IDaySolver
    {
        private readonly IEnumerable<string> input;

        public Day21Solver(string input)
        {
            this.input = input.Split("\r\n");

            Console.Write(this.input.ToString());
        }

        public long SolvePart1()
        {
            return 0;
        }

        public long SolvePart2()
        {
            return 0;
        }
    }
}