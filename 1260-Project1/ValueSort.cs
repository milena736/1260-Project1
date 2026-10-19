using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public class ValueSort : IComparer<LibraryItem>
    {
        public int Compare(LibraryItem x, LibraryItem y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Arguments cannot be null");
            }
            return x.title.CompareTo(y.title);
        }
    

    }
}
