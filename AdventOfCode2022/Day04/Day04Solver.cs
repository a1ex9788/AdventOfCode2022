using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2022.Day04
{
    public class Day04Solver : IDaySolver
    {
        private readonly IList<(Section A, Section B)> sectionPairs;

        public Day04Solver(string input)
        {
            this.sectionPairs = new List<(Section A, Section B)>();

            foreach (string sectionPair in input.Split("\r\n"))
            {
                GroupCollection matchGroups =
                    Regex.Match(sectionPair, @"(\d+)-(\d+),(\d+)-(\d+)").Groups;

                Section parsedFirstSection = new Section(
                    matchGroups[1].Value, matchGroups[2].Value);

                Section parsedSecondSection = new Section(
                    matchGroups[3].Value, matchGroups[4].Value);

                this.sectionPairs.Add((parsedFirstSection, parsedSecondSection));
            }
        }

        public string SolvePart1()
        {
            int pairsWithFullyContainedSection = 0;

            foreach ((Section A, Section B) in this.sectionPairs)
            {
                IList<int> union = A.Numbers.Union(B.Numbers).ToList();

                if (union.Count == A.Numbers.Count || union.Count == B.Numbers.Count)
                {
                    pairsWithFullyContainedSection++;
                }
            }

            return pairsWithFullyContainedSection.ToString();
        }

        public string SolvePart2()
        {
            int pairsWithOverlaps = 0;

            foreach ((Section A, Section B) in this.sectionPairs)
            {
                if (A.Numbers.Intersect(B.Numbers).Any())
                {
                    pairsWithOverlaps++;
                }
            }

            return pairsWithOverlaps.ToString();
        }
    }
}