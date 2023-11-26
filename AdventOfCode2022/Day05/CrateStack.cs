using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day05
{
    internal class CrateStack : Stack<char>, ICloneable
    {
        public object Clone()
        {
            IList<char> crates = this.ToList();

            CrateStack crateStack = new CrateStack();

            for (int i = crates.Count - 1; i >= 0; i--)
            {
                crateStack.Push(crates[i]);
            }

            return crateStack;
        }
    }
}