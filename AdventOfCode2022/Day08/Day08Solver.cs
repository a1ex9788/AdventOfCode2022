using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day08
{
    public class Day08Solver : IDaySolver
    {
        private readonly int[,] treesMap;
        private readonly int rowsNumber;
        private readonly int columnsNumber;

        public Day08Solver(string input)
        {
            IList<string> rows = input.Split(Environment.NewLine).Reverse().ToList();

            this.rowsNumber = rows.Count;
            this.columnsNumber = rows[0].Length;

            this.treesMap = new int[this.columnsNumber, this.rowsNumber];

            for (int i = 0; i < this.rowsNumber; i++)
            {
                for (int j = 0; j < this.columnsNumber; j++)
                {
                    this.treesMap[j, i] = int.Parse(rows[i][j].ToString());
                }
            }
        }

        public string SolvePart1()
        {
            int visibleTreesNumber = 0;

            VisibilityCalculator visibilityCalculator = new VisibilityCalculator(
                this.treesMap, this.rowsNumber, this.columnsNumber);

            for (int i = 0; i < this.rowsNumber; i++)
            {
                for (int j = 0; j < this.columnsNumber; j++)
                {
                    if (visibilityCalculator.IsTreeVisibleFromOutside(j, i))
                    {
                        visibleTreesNumber++;
                    }
                }
            }

            return visibleTreesNumber.ToString();
        }

        public string SolvePart2()
        {
            int highestScenicScore = 0;

            HighestScenicScoreCalculator highestScenicScoreCalculator =
                new HighestScenicScoreCalculator(
                    this.treesMap, this.rowsNumber, this.columnsNumber);

            for (int i = 0; i < this.rowsNumber; i++)
            {
                for (int j = 0; j < this.columnsNumber; j++)
                {
                    int currentHighestScenicScore = highestScenicScoreCalculator.Calculate(j, i);

                    if (currentHighestScenicScore > highestScenicScore)
                    {
                        highestScenicScore = currentHighestScenicScore;
                    }
                }
            }

            return highestScenicScore.ToString();
        }
    }
}