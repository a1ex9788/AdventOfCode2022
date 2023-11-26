using System.Text.RegularExpressions;

namespace AdventOfCode2022.Day05
{
    internal class ProcedureStep
    {
        internal ProcedureStep(string procedureStep)
        {
            GroupCollection matchGroups = Regex.Match(
                procedureStep, @"move (\d+) from (\d+) to (\d+)").Groups;

            this.CrateQuantity = int.Parse(matchGroups[1].Value);
            this.Origin = int.Parse(matchGroups[2].Value);
            this.Destination = int.Parse(matchGroups[3].Value);
        }

        internal int CrateQuantity { get; }

        internal int Origin { get; }

        internal int Destination { get; }
    }
}