﻿using System;
using System.Collections.Generic;

namespace AdventOfCode2022.DayXX
{
    public class DayXXSolver : IDaySolver
    {
        private readonly IEnumerable<string> input;

        public DayXXSolver(string input)
        {
            this.input = input.Split("\r\n");

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