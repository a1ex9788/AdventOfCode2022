using System.Text.RegularExpressions;

namespace AdventOfCode2022.Day07.Commands.Ls.FileSystemItems
{
    internal class FileInfo : FileSystemItemInfo
    {
        internal FileInfo(string fileInfo)
        {
            GroupCollection matchGroups = Regex.Match(fileInfo, @"(\d*) ([a-z]*.[a-z]*)").Groups;

            this.Name = matchGroups[2].Value;
            this.Size = int.Parse(matchGroups[1].Value);
        }

        internal string Name { get; }

        internal int Size { get; }
    }
}