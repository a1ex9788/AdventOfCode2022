using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day06
{
    public class Day06Solver : IDaySolver
    {
        private readonly IList<char> datastream;

        public Day06Solver(string input)
        {
            this.datastream = input.ToList();

            Console.Write(this.datastream.ToString());
        }

        public string SolvePart1()
        {
            return this.GetStartOfMarker(4);
        }

        public string SolvePart2()
        {
            return this.GetStartOfMarker(14);
        }

        private string GetStartOfMarker(int numberOfDistinctCharacters)
        {
            IList<char> differentCaracters = new List<char>();

            for (int i = 0; i < this.datastream.Count; i++)
            {
                char currentChar = this.datastream[i];

                while (differentCaracters.Contains(currentChar))
                {
                    differentCaracters.RemoveAt(0);
                }

                differentCaracters.Add(currentChar);

                if (differentCaracters.Count == numberOfDistinctCharacters)
                {
                    return (i + 1).ToString();
                }
            }

            throw new NotSupportedException();
        }
    }
}