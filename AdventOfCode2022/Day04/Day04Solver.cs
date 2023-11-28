using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day04
{
    public class Day04Solver : IDaySolver
    {
        private readonly IEnumerable<SectionPair> sectionPairs;

        public Day04Solver(string input)
        {
            this.sectionPairs = input.Split(Environment.NewLine).Select(s => new SectionPair(s));
        }

        public string SolvePart1()
        {
            int pairsWithFullyContainedSection = 0;

            foreach (SectionPair sectionPair in this.sectionPairs)
            {
                IList<int> aNumbers = sectionPair.A.Numbers;
                IList<int> bNumbers = sectionPair.B.Numbers;

                IList<int> union = aNumbers.Union(bNumbers).ToList();

                if (union.Count == aNumbers.Count || union.Count == bNumbers.Count)
                {
                    pairsWithFullyContainedSection++;
                }
            }

            return pairsWithFullyContainedSection.ToString();
        }

        public string SolvePart2()
        {
            int pairsWithOverlaps = 0;

            foreach (SectionPair sectionPair in this.sectionPairs)
            {
                IList<int> aNumbers = sectionPair.A.Numbers;
                IList<int> bNumbers = sectionPair.B.Numbers;

                if (aNumbers.Intersect(bNumbers).Any())
                {
                    pairsWithOverlaps++;
                }
            }

            return pairsWithOverlaps.ToString();
        }
    }
}