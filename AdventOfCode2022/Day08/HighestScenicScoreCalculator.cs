using System;

namespace AdventOfCode2022.Day08
{
    internal class HighestScenicScoreCalculator
    {
        private readonly int[,] treesMap;
        private readonly int rowsNumber;
        private readonly int columnsNumber;

        internal HighestScenicScoreCalculator(int[,] treesMap, int rowsNumber, int columnsNumber)
        {
            this.treesMap = treesMap;
            this.rowsNumber = rowsNumber;
            this.columnsNumber = columnsNumber;
        }

        internal int Calculate(int x, int y)
        {
            int highestScenicScore = 1;

            highestScenicScore *= this.CalculateViewedTreesAtRight(x, y);
            highestScenicScore *= this.CalculateViewedTreesAtLeft(x, y);
            highestScenicScore *= this.CalculateViewedTreesAtUp(x, y);
            highestScenicScore *= this.CalculateViewedTreesAtDown(x, y);

            return highestScenicScore;
        }

        private int CalculateViewedTreesAtRight(int x, int y)
        {
            (int, int) GetNextTree((int i, int j) tree)
            {
                return (tree.i + 1, tree.j);
            }

            return this.CalculateViewedTrees(x, y, GetNextTree);
        }

        private int CalculateViewedTreesAtLeft(int x, int y)
        {
            (int, int) GetNextTree((int i, int j) tree)
            {
                return (tree.i - 1, tree.j);
            }

            return this.CalculateViewedTrees(x, y, GetNextTree);
        }

        private int CalculateViewedTreesAtUp(int x, int y)
        {
            (int, int) GetNextTree((int i, int j) tree)
            {
                return (tree.i, tree.j + 1);
            }

            return this.CalculateViewedTrees(x, y, GetNextTree);
        }

        private int CalculateViewedTreesAtDown(int x, int y)
        {
            (int, int) GetNextTree((int i, int j) tree)
            {
                return (tree.i, tree.j - 1);
            }

            return this.CalculateViewedTrees(x, y, GetNextTree);
        }

        private int CalculateViewedTrees(
            int x, int y, Func<(int, int), (int, int)> getNextTreeFunction)
        {
            (int i, int j) = getNextTreeFunction.Invoke((x, y));

            if (!TreesValidator.IsValid(this.columnsNumber, this.rowsNumber, i, j))
            {
                return 0;
            }

            int initialHeight = this.treesMap[x, y];

            int viewedTrees = 0;

            do
            {
                int currentHeight = this.treesMap[i, j];

                viewedTrees++;

                if (currentHeight >= initialHeight)
                {
                    break;
                }

                (i, j) = getNextTreeFunction.Invoke((i, j));
            }
            while (TreesValidator.IsValid(this.columnsNumber, this.rowsNumber, i, j));

            return viewedTrees;
        }
    }
}