using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day07.FileSystemItems
{
    internal class Directory : FileSystemItem
    {
        internal Directory(string fullPath)
            : base(fullPath)
        {
            this.ChildItems = new List<FileSystemItem>();
        }

        internal IList<FileSystemItem> ChildItems { get; }

        internal override int Size => this.ChildItems.Select(fsi => fsi.Size).Sum();

        internal void AddChild(FileSystemItem fileSystemItem)
        {
            this.ChildItems.Add(fileSystemItem);
        }

        internal void AddChilds(IEnumerable<FileSystemItem> fileSystemItems)
        {
            foreach (FileSystemItem fileSystemItem in fileSystemItems)
            {
                this.AddChild(fileSystemItem);
            }
        }
    }
}