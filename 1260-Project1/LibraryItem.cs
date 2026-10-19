using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _1260_Project1
{
    public abstract class LibraryItem : ILoanable, IDisplay, IComparable<LibraryItem>, IEquatable<LibraryItem>
    {

        //fix public/private and UC/LC
        private string itemId;
        private string title;
        public string ItemId { get; set; }
        public string Title { get; set; }

        public bool IsAvailable { get; set; }
        public LibraryItem(string itemId, string title)
        {
            this.ItemId = itemId;
            this.Title = title;
            IsAvailable = true;

        }


        public virtual void CheckOut()
        {
            if (!IsAvailable)
            {
                throw new InvalidOperationException($"'{ItemId}' is not available for checkout.");
            }
            IsAvailable = false;

        }


        public virtual void Return()
        {
            if (IsAvailable)
            {
                throw new InvalidOperationException($"'{ItemId}' is already available and cannot be returned.");
            }
            IsAvailable = true;

        }
        public abstract string DisplayInfo();
        public abstract string Type();

        public int CompareTo(LibraryItem other)
        {
            if (other == null) return 1;
            return string.Compare(this.ItemId, other.ItemId, StringComparison.OrdinalIgnoreCase);
        }
        public bool Equals(LibraryItem other)
        {
            if (other == null) return false;
            return string.Equals(this.ItemId, other.ItemId, StringComparison.OrdinalIgnoreCase);
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
            return ItemId != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(ItemId) : 0;






        }

    }
}
