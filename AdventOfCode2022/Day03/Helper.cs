using System;

namespace AdventOfCode2022.Day03
{
    internal static class Helper
    {
        internal static int GetPriority(char item)
        {
            int asciiValue = Convert.ToInt32(item);

            if (char.IsLower(item))
            {
                return asciiValue - 96;
            }

            return asciiValue - 38;
        }
    }
}