using System.Text.RegularExpressions;

namespace AdventOfCode2022.Day07.Commands.Ls.FileSystemItems
{
    internal class DirectoryInfo : FileSystemItemInfo
    {
        internal DirectoryInfo(string directoryInfo)
        {
            GroupCollection matchGroups = Regex.Match(directoryInfo, "dir ([a-z]*)").Groups;

            this.Name = matchGroups[1].Value;
        }

        internal string Name { get; }
    }
}