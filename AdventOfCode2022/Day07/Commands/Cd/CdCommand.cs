using System.Text.RegularExpressions;

namespace AdventOfCode2022.Day07.Commands.Cd
{
    internal class CdCommand : Command
    {
        internal CdCommand(string command)
        {
            if (command.EndsWith("\r\n"))
            {
                command = command[..(command.Length - 2)];
            }

            GroupCollection matchGroups = Regex.Match(
                command.Replace(@"\r\n", string.Empty), @"\$ cd (.*)").Groups;

            this.DirectoryName = matchGroups[1].Value;
        }

        internal string DirectoryName { get; }
    }
}