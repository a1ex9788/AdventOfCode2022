namespace AdventOfCode2022.Day07.FileSystemItems
{
    internal abstract class FileSystemItem
    {
        protected FileSystemItem(string fullPath)
        {
            this.FullPath = fullPath;
        }

        internal string FullPath { get; }

        internal abstract int Size { get; }
    }
}