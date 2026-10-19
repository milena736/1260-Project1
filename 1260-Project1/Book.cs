using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _1260_Project1
{
    public class Book : LibraryItem
    {
        private int Pages;
        public int pages { get; private set; }

        public Book (int ItemId, string title, string author, int year,string Type, int pages) : base(ItemId, title, author, year, Type)
        {
            this.Type = "Book";
            this.Pages = pages;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Type: {Type} Title: {title}, Author: {author}, Year: {year}, Pages: {Pages}");
        }
        public override void DisplayAvailability()
        {
            if (IsAvailable)
            {
                Console.WriteLine($"'{title}' is available.");
            }
            else
            {
                Console.WriteLine($"'{title}' is not available.");
            }
        }

    }
}
