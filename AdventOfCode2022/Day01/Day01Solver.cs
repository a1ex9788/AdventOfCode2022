using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day01
{
    public class Day01Solver : IDaySolver
    {
        private readonly IList<long> caloriesByElfOrderedByMax;

        public Day01Solver(string input)
        {
            IList<long> caloriesByElf = new List<long>();

            foreach (string groupedCaloriesOfElf in input.Split("\r\n\r\n"))
            {
                string[] caloriesOfElf = groupedCaloriesOfElf.Split("\r\n");

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
            long caloriesOfThreeMaxs = this.caloriesByElfOrderedByMax[0]
                + this.caloriesByElfOrderedByMax[1] + this.caloriesByElfOrderedByMax[2];

            return caloriesOfThreeMaxs.ToString();
        }
    }
}