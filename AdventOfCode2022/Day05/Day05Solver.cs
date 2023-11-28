using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day05
{
    public class Day05Solver : IDaySolver
    {
        private readonly Supplies supplies;
        private readonly IEnumerable<ProcedureStep> procedure;

        public Day05Solver(string input)
        {
            string newLine = Environment.NewLine;
            string[] splittedInput = input.Split($"{newLine}{newLine}");

            this.supplies = new Supplies(splittedInput[0]);

            this.procedure = splittedInput[1].Split(Environment.NewLine).Select(s => new ProcedureStep(s));
        }

        public string SolvePart1()
        {
            Supplies currentSupplies = (Supplies)this.supplies.Clone();

            foreach (ProcedureStep procedure in this.procedure)
            {
                for (int i = 0; i < procedure.CrateQuantity; i++)
                {
                    char crate = currentSupplies.CrateStacks[procedure.Origin - 1].Pop();

                    currentSupplies.CrateStacks[procedure.Destination - 1].Push(crate);
                }
            }

            return GetTopCrates(currentSupplies);
        }

        public string SolvePart2()
        {
            Supplies currentSupplies = (Supplies)this.supplies.Clone();

            foreach (ProcedureStep procedure in this.procedure)
            {
                IList<char> crates = new List<char>();

                for (int i = 0; i < procedure.CrateQuantity; i++)
                {
                    char crate = currentSupplies.CrateStacks[procedure.Origin - 1].Pop();

                    crates.Add(crate);
                }

                for (int i = crates.Count - 1; i >= 0; i--)
                {
                    currentSupplies.CrateStacks[procedure.Destination - 1].Push(crates[i]);
                }
            }

            return GetTopCrates(currentSupplies);
        }

        private static string GetTopCrates(Supplies currentSupplies)
        {
            string topCrates = string.Empty;

            foreach (CrateStack crateStack in currentSupplies.CrateStacks)
            {
                topCrates += crateStack.Pop();
            }

            return topCrates;
        }
    }
}