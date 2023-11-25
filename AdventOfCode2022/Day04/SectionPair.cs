using System.Text.RegularExpressions;

namespace AdventOfCode2022.Day04
{
    internal class SectionPair
    {
        internal SectionPair(string sectionPair)
        {
            GroupCollection matchGroups =
                Regex.Match(sectionPair, @"(\d+)-(\d+),(\d+)-(\d+)").Groups;

            this.A = new Section(
                matchGroups[1].Value, matchGroups[2].Value);

            this.B = new Section(
                matchGroups[3].Value, matchGroups[4].Value);
        }

        internal Section A { get; }

        internal Section B { get; }
    }
}