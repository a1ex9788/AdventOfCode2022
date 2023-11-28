using AdventOfCode2022.Day07;
using AdventOfCode2022.Day07.Commands.Cd;
using AdventOfCode2022.Day07.Commands.Ls;
using AdventOfCode2022.Day07.Commands.Ls.FileSystemItems;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AdventOfCode2022.Tests.UnitTests.Day07
{
    [TestClass]
    public class TerminalOutputTests
    {
        [TestMethod]
        [DataRow("/", "")]
        [DataRow("directory", "")]
        [DataRow("..", "")]
        [DataRow("directory\r\n", "directory")]
        public void CdCommandTest(string directory, string? expectedDirectory)
        {
            if (string.IsNullOrEmpty(expectedDirectory))
            {
                expectedDirectory = directory;
            }

            CdCommand cdCommand = new CdCommand($"$ cd {directory}");

            cdCommand.DirectoryName.Should().Be(expectedDirectory);
        }

        [TestMethod]
        public void LsCommandTest()
        {
            LsCommand lsCommand = new LsCommand(
                $"$ ls{Environment.NewLine}" +
                $"123 file{Environment.NewLine}" +
                $"1234 file.txt{Environment.NewLine}" +
                $"dir directory{Environment.NewLine}");

            FileInfo fileInfo1 = (FileInfo)lsCommand.FileSystemItemInfos[0];
            fileInfo1.Name.Should().Be("file");
            fileInfo1.Size.Should().Be(123);

            FileInfo fileInfo2 = (FileInfo)lsCommand.FileSystemItemInfos[1];
            fileInfo2.Name.Should().Be("file.txt");
            fileInfo2.Size.Should().Be(1234);

            DirectoryInfo directoryInfo = (DirectoryInfo)lsCommand.FileSystemItemInfos[2];
            directoryInfo.Name.Should().Be("directory");
        }

        [TestMethod]
        public void TerminalOutputTest()
        {
            TerminalOutput terminalOutput = new TerminalOutput(
                $"$ cd /{Environment.NewLine}" +
                $"$ ls{Environment.NewLine}" +
                $"123 file{Environment.NewLine}" +
                $"1234 file.txt{Environment.NewLine}" +
                $"dir directory{Environment.NewLine}" +
                $"$ cd directory{Environment.NewLine}" +
                $"$ cd ..");

            // First 'cd /' is not returned.
            terminalOutput.Commands.Should().HaveCount(3);

            LsCommand lsCommand = (LsCommand)terminalOutput.Commands[0];
            IList<FileSystemItemInfo> fileSystemItemInfos = lsCommand.FileSystemItemInfos;

            FileInfo fileInfo1 = (FileInfo)fileSystemItemInfos[0];
            fileInfo1.Name.Should().Be("file");
            fileInfo1.Size.Should().Be(123);

            FileInfo fileInfo2 = (FileInfo)fileSystemItemInfos[1];
            fileInfo2.Name.Should().Be("file.txt");
            fileInfo2.Size.Should().Be(1234);

            DirectoryInfo directoryInfo = (DirectoryInfo)lsCommand.FileSystemItemInfos[2];
            directoryInfo.Name.Should().Be("directory");

            CdCommand cdCommand2 = (CdCommand)terminalOutput.Commands[1];
            cdCommand2.DirectoryName.Should().Be("directory");

            CdCommand cdCommand3 = (CdCommand)terminalOutput.Commands[2];
            cdCommand3.DirectoryName.Should().Be("..");
        }
    }
}