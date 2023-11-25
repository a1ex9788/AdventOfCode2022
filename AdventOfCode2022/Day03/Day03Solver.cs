using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day03
{
    public class Day03Solver : IDaySolver
    {
        private readonly IList<string> rucksacks;

        public Day03Solver(string input)
        {
            this.rucksacks = input.Split("\r\n");
        }

        public string SolvePart1()
        {
            IList<(IList<char> A, IList<char> B)> parsedRucksacks =
                new List<(IList<char> A, IList<char> B)>();

            foreach (string rucksack in this.rucksacks)
            {
                int half = rucksack.Length / 2;

                parsedRucksacks.Add(
                    (rucksack[0..half].ToList(), rucksack[half..].ToList()));
            }

            int prioritiesSum = 0;

            foreach ((IList<char> a, IList<char> b) in parsedRucksacks)
            {
                char commonItem = a.Intersect(b).Single();

                prioritiesSum += Helper.GetPriority(commonItem);
            }

            return prioritiesSum.ToString();
        }

        public string SolvePart2()
        {
            int prioritiesSum = 0;

            for (int i = 0; i < this.rucksacks.Count; i += 3)
            {
                string first = this.rucksacks[i];
                string second = this.rucksacks[i + 1];
                string third = this.rucksacks[i + 2];

                char commonItem = first.Intersect(second).Intersect(third).Single();

                prioritiesSum += Helper.GetPriority(commonItem);
            }

            return prioritiesSum.ToString();
        }
    }
}