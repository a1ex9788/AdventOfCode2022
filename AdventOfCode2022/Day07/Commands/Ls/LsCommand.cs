using AdventOfCode2022.Day07.Commands.Ls.FileSystemItems;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day07.Commands.Ls
{
    internal class LsCommand : Command
    {
        internal LsCommand(string command)
        {
            this.FileSystemItemInfos = new List<FileSystemItemInfo>();

            if (command.EndsWith("\r\n"))
            {
                command = command[..(command.Length - 2)];
            }

            IEnumerable<string> output = command.Split("\r\n");

            // Skips the first line since it is the own command 'ls'.
            output = output.Skip(1);

            foreach (string line in output)
            {
                this.FileSystemItemInfos.Add(line.StartsWith("dir")
                    ? new DirectoryInfo(line)
                    : new FileInfo(line));
            }
        }

        internal IList<FileSystemItemInfo> FileSystemItemInfos { get; }
    }
}