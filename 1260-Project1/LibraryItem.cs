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
        public List<Loan> record { get; }
        public static int newseq { get; set; }
        //add return date

        public bool IsAvailable { get; set; }
        public LibraryItem( int ItemId, string title, string author, int year, string Type)
        {
            this.ItemId = itemId;
            this.title = title;
            this.author = author;
            this.year = year;
            this.Type = Type;
            IsAvailable = true;
            record = new List<Loan>();
            newseq = newseq + 1;
        }
        public abstract void DisplayInfo();
        public int LoanCount()
        {
            return record.Count;
        }

        public void CheckOut(int ItemId)
        {
            if (!IsAvailable)
            {
                Console.WriteLine("Item has already been checked out.");
                return;
            }
            IsAvailable = false;
            record.Add(new Loan(newseq ++, "Check out", +1));
        }


        public void Return(int ItemId)
        {
            if (IsAvailable)
            { 
                Console.WriteLine("Book is available.");
                return;
            }
            IsAvailable = true;
            Console.WriteLine($"Item '{title}' ({Type}), has been returned.");
            record.Add(new Loan(newseq++, "Return", +1));
        }


        

        
    }

}
