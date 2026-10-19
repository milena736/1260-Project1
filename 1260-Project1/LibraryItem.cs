using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _1260_Project1
{
    public abstract class LibraryItem : ILoanable, IDisplay, IComparable<LibraryItem>, IEquatable<LibraryItem>
    {
        // private static int _nextId = 1;
        //fix public/private and UC/LC


        public string itemId { get; set; }
        public string title { get; set; }

        public bool IsAvailable { get; set; }
        public LibraryItem(string itemId, string title)
        {
            this.itemId = itemId;
            this.title = title;
            IsAvailable = true;

        }


        public virtual void CheckOut()
        {
            if (!IsAvailable)
            {
                throw new InvalidOperationException($"'{itemId}' is not available for checkout.");
            }
            IsAvailable = false;

        }


        public virtual void Return()
        {
            if (IsAvailable)
            {
                throw new InvalidOperationException($"'{itemId}' is already available and cannot be returned.");
            }
            IsAvailable = true;

        }
        public abstract string DisplayInfo();
        public abstract string Type();

        public int CompareTo(LibraryItem other)
        {
            if (other == null) return 1;
            return string.Compare(this.itemId, other.itemId, StringComparison.OrdinalIgnoreCase);
        }
        public bool Equals(LibraryItem other)
        {
            if (other == null) return false;
            return string.Equals(this.itemId, other.itemId, StringComparison.OrdinalIgnoreCase);
        }
        public override bool Equals(object obj)
        {
            if (obj is LibraryItem otherItem)
            {
                return Equals(otherItem);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return itemId != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(itemId) : 0;






        }

    }
}
