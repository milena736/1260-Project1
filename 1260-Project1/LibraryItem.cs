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
        public string title { get; set; }
        public string author { get; set; }
        public int year { get; set; }
        public string Type { get; set; }

        public bool IsAvailable { get; set; }
        public LibraryItem( int itemId, string title, string author, int year, string Type)
        {
            this.ItemId = itemId;
            this.title = title;
            this.author = author;
            this.year = year;
            this.Type = Type;
            IsAvailable = true;
            
        }
        public abstract void DisplayInfo();
       

        public void CheckOut()
        {
            if (!IsAvailable)
            {
                Console.WriteLine("Item has already been checked out.");
                return;
            }
            IsAvailable = false;
            
        }


        public void Return()
        {
            if (IsAvailable)
            { 
                Console.WriteLine("Book is available.");
                return;
            }
            IsAvailable = true;
            Console.WriteLine($"Item '{title}' ({Type}), has been returned.");
           

        }


        

        
    }

}
