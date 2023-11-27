using AdventOfCode2022.Day07.Commands.Cd;
using AdventOfCode2022.Day07.Commands.Ls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2022.Day07
{
    internal class TerminalOutput
    {
        internal TerminalOutput(string terminalOutput)
        {
            this.Commands = new List<Command>();

            IEnumerable<string> lines = terminalOutput.Split("\r\n");

            StringBuilder currentCommand = new StringBuilder();
            currentCommand.AppendLine(lines.First());

            foreach (string line in lines.Skip(1))
            {
                if (line.StartsWith('$'))
                {
                    this.Commands.Add(CreateCommand(currentCommand.ToString()));

                    currentCommand = new StringBuilder();
                    currentCommand.AppendLine(line);

                    continue;
                }

                currentCommand.AppendLine(line);
            }

            this.Commands.Add(CreateCommand(currentCommand.ToString()));

            // The first command is always 'cd /'.
            this.Commands.RemoveAt(0);
        }

        internal IList<Command> Commands { get; }

        private static Command CreateCommand(string command)
        {
            if (command.StartsWith("$ cd"))
            {
                return new CdCommand(command);
            }
            else if (command.StartsWith("$ ls"))
            {
                return new LsCommand(command);
            }
            else
            {
                throw new NotSupportedException();
            }
        }
    }
}