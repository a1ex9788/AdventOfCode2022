namespace AdventOfCode2022.Day08
{
    internal static class TreesValidator
    {
        internal static bool IsValid(int columnsNumber, int rowsNumber, int x, int y)
        {
            return 0 <= x && x < columnsNumber && 0 <= y && y < rowsNumber;
        }
    }
}