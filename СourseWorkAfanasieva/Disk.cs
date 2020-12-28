using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseWorkAfanasieva
{
    class Disk
    {
        public string name;
        public int totalFreeSpace;
        public int totalSize;

        public Disk(string name, long totalFreeSpace, long totalSize)
        {
            this.name = name;
            this.totalFreeSpace = totalSpaceCount(totalFreeSpace);
            this.totalSize = totalSpaceCount(totalSize);

        }

        public int totalSpaceCount(long totalFreeSpace)
        {
            return (int)(totalFreeSpace / 1024 / 1024 / 1024);
        }
    }
}
