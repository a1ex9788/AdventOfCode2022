using System.Collections.Generic;

namespace AdventOfCode2022.Day04
{
    internal class Section
    {
        internal Section(string a, string b)
        {
            this.A = int.Parse(a);
            this.B = int.Parse(b);

            this.Numbers = new List<int>();

            for (int i = this.A; i <= this.B; i++)
            {
                this.Numbers.Add(i);
            }
        }

        internal int A { get; }

        internal int B { get; }

        internal IList<int> Numbers { get; }
    }
}