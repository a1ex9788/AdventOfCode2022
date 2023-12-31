﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day01
{
    public class Day01Solver : IDaySolver
    {
        private readonly IEnumerable<long> caloriesByElfOrderedByMax;

        public Day01Solver(string input)
        {
            IList<long> caloriesByElf = new List<long>();

            string newLine = Environment.NewLine;

            foreach (string groupedCaloriesOfElf in input.Split($"{newLine}{newLine}"))
            {
                string[] caloriesOfElf = groupedCaloriesOfElf.Split(Environment.NewLine);

                caloriesByElf.Add(caloriesOfElf.Select(s => long.Parse(s)).Sum());
            }

            this.caloriesByElfOrderedByMax = caloriesByElf.OrderByDescending(l => l).ToList();
        }

        public string SolvePart1()
        {
            return this.caloriesByElfOrderedByMax.First().ToString();
        }

        public string SolvePart2()
        {
            long caloriesOfThreeMaxs = this.caloriesByElfOrderedByMax.ElementAt(0)
                + this.caloriesByElfOrderedByMax.ElementAt(1)
                + this.caloriesByElfOrderedByMax.ElementAt(2);

            return caloriesOfThreeMaxs.ToString();
        }
    }
}