using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _1260_Project1
{
    public abstract class LibraryItem : ILoanable, IDisplay
    {
        // private static int _nextId = 1;
        //fix public/private and UC/LC

       
        public string itemId { get; set; }


        public bool IsAvailable { get; set; }
        public LibraryItem( string itemId)
        {
            this.itemId = itemId;
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






    }

}
