namespace AdventOfCode2022.Day07.FileSystemItems
{
    internal class File : FileSystemItem
    {
        private readonly int size;

        internal File(string fullPath, int size)
            : base(fullPath)
        {
            this.size = size;
        }

        internal override int Size => this.size;
    }
}