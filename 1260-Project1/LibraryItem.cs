using System;
using System.Collections.Generic;
using System.Text;

namespace _1260_Project1
{
    public abstract class LibraryItem 
    {
        // private static int _nextId = 1;
        //fix public/private and UC/LC

        private int itemId;
        public int ItemId { get; set; }

        public bool IsAvailable { get; set; }
        public LibraryItem( int itemId)
        {
            this.ItemId = itemId;
            IsAvailable = true;
            
        }

        public abstract void DisplayInfo();
        public abstract void DisplayAvailability();

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
        





    }

}
