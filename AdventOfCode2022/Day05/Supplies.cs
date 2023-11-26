using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day05
{
    internal class Supplies : ICloneable
    {
        internal Supplies(string supplies)
        {
            this.CrateStacks = new List<CrateStack>();

            IList<string> stacksAndNumbers = supplies.Split("\r\n").ToList();

            string numbers = stacksAndNumbers.Last();
            int numbersCount = Convert.ToInt32(numbers.SkipLast(1).Last().ToString());

            IList<string> groupedStacks = stacksAndNumbers.SkipLast(1).ToList();

            for (int i = 1; i <= numbersCount; i++)
            {
                CrateStack stack = new CrateStack();

                for (int j = groupedStacks.Count - 1; j >= 0; j--)
                {
                    char crate = groupedStacks[j][i * 4 - 3];

                    if (!char.IsLetter(crate))
                    {
                        break;
                    }

                    stack.Push(crate);
                }

                this.CrateStacks.Add(stack);
            }
        }

        private Supplies(IList<CrateStack> crateStacks)
        {
            this.CrateStacks = crateStacks;
        }

        internal IList<CrateStack> CrateStacks { get; }

        public object Clone()
        {
            IList<CrateStack> crateStacks = new List<CrateStack>();

            foreach (CrateStack crateStack in this.CrateStacks)
            {
                crateStacks.Add((CrateStack)crateStack.Clone());
            }

            return new Supplies(crateStacks);
        }
    }
}