using AdventOfCode2022.Day07.Commands.Cd;
using AdventOfCode2022.Day07.Commands.Ls;
using AdventOfCode2022.Day07.Commands.Ls.FileSystemItems;
using AdventOfCode2022.Day07.FileSystemItems;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day07
{
    public class Day07Solver : IDaySolver
    {
        private readonly TerminalOutput terminalOutput;
        private readonly IList<int> directorySizes;

        public Day07Solver(string input)
        {
            this.terminalOutput = new TerminalOutput(input);

            Directory root = new Directory("/");
            Directory currentDirectory = root;

            IList<Directory> directories = new List<Directory> { root };

            foreach (Command command in this.terminalOutput.Commands)
            {
                currentDirectory = ProcessCommand(currentDirectory, directories, command);
            }

            this.directorySizes = directories.Select(d => d.Size).ToList();
        }

        public string SolvePart1()
        {
            return this.directorySizes.Where(i => i < 100000).Sum().ToString();
        }

        public string SolvePart2()
        {
            int totalDiskSpace = 70000000;
            int neededUnusedSpace = 30000000;

            int currentUsedSpace = this.directorySizes.First();
            int currentUnusedSpace = totalDiskSpace - currentUsedSpace;
            int spaceToFreeUp = neededUnusedSpace - currentUnusedSpace;

            return this.directorySizes
                .OrderBy(i => i).Where(i => i > spaceToFreeUp).First().ToString();
        }

        private static Directory ProcessCommand(
            Directory currentDirectory, IList<Directory> directories, Command command)
        {
            Type commandType = command.GetType();

            if (commandType == typeof(CdCommand))
            {
                CdCommand cdCommand = (CdCommand)command;

                string directoryFullPath = CombinePath(
                    currentDirectory.FullPath, cdCommand.DirectoryName);

                return directories.Single(d => d.FullPath == directoryFullPath);
            }

            if (commandType == typeof(LsCommand))
            {
                LsCommand lsCommand = (LsCommand)command;

                foreach (FileSystemItemInfo fileSystemItemInfo in lsCommand.FileSystemItemInfos)
                {
                    Type fileSystemItemInfoType = fileSystemItemInfo.GetType();

                    if (fileSystemItemInfoType == typeof(DirectoryInfo))
                    {
                        DirectoryInfo directoryInfo = (DirectoryInfo)fileSystemItemInfo;

                        string fullPath = CombinePath(
                            currentDirectory.FullPath, directoryInfo.Name);

                        Directory directory = new Directory(fullPath);
                        currentDirectory.AddChild(directory);
                        directories.Add(directory);

                        continue;
                    }

                    if (fileSystemItemInfoType == typeof(FileInfo))
                    {
                        FileInfo fileInfo = (FileInfo)fileSystemItemInfo;

                        string fullPath = CombinePath(
                            currentDirectory.FullPath, fileInfo.Name);

                        currentDirectory.AddChild(new File(fullPath, fileInfo.Size));

                        continue;
                    }

                    throw new NotSupportedException();
                }

                return currentDirectory;
            }

            throw new NotSupportedException();
        }

        private static string CombinePath(string path, string item)
        {
            if (path == "/")
            {
                return $"/{item}";
            }

            string combinedPath = $"{path}/{item}";

            if (combinedPath.EndsWith("/.."))
            {
                combinedPath = combinedPath.Replace("/..", string.Empty);

                combinedPath = new string(
                    combinedPath.Reverse().SkipWhile(c => c != '/').Skip(1).Reverse().ToArray());

                if (combinedPath == string.Empty)
                {
                    combinedPath = "/";
                }
            }

            return combinedPath;
        }
    }
}