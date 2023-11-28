namespace AdventOfCode2022.Day08
{
    internal class VisibilityCalculator
    {
        private readonly int[,] treesMap;
        private readonly int rowsNumber;
        private readonly int columnsNumber;

        internal VisibilityCalculator(int[,] treesMap, int rowsNumber, int columnsNumber)
        {
            this.treesMap = treesMap;
            this.rowsNumber = rowsNumber;
            this.columnsNumber = columnsNumber;
        }

        internal bool IsTreeVisibleFromOutside(int x, int y)
        {
            if (x == 0 || x == this.columnsNumber - 1 || y == 0 || y == this.rowsNumber - 1)
            {
                return true;
            }

            int currentHeight = this.treesMap[x, y];

            return this.VisibleFromRigth(x, y, currentHeight)
                || this.VisibleFromLeft(x, y, currentHeight)
                || this.VisibleFromUp(x, y, currentHeight)
                || this.VisibleFromDown(x, y, currentHeight);
        }

        private bool VisibleFromRigth(int x, int y, int currentHeight)
        {
            int i = x + 1, j = y;

            do
            {
                if (this.treesMap[i, j] >= currentHeight)
                {
                    return false;
                }

                i++;
            }
            while (TreesValidator.IsValid(this.columnsNumber, this.rowsNumber, i, j));

            return true;
        }

        private bool VisibleFromLeft(int x, int y, int currentHeight)
        {
            int i = x - 1, j = y;

            do
            {
                if (this.treesMap[i, j] >= currentHeight)
                {
                    return false;
                }

                i--;
            }
            while (TreesValidator.IsValid(this.columnsNumber, this.rowsNumber, i, j));

            return true;
        }

        private bool VisibleFromUp(int x, int y, int currentHeight)
        {
            int i = x, j = y + 1;

            do
            {
                if (this.treesMap[i, j] >= currentHeight)
                {
                    return false;
                }

                j++;
            }
            while (TreesValidator.IsValid(this.columnsNumber, this.rowsNumber, i, j));

            return true;
        }

        private bool VisibleFromDown(int x, int y, int currentHeight)
        {
            int i = x, j = y - 1;

            do
            {
                if (this.treesMap[i, j] >= currentHeight)
                {
                    return false;
                }

                j--;
            }
            while (TreesValidator.IsValid(this.columnsNumber, this.rowsNumber, i, j));

            return true;
        }
    }
}