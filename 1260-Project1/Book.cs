using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _1260_Project1
{
    public class Book : Media, IDisplay
    {
        private int Pages;
        public int pages { get; private set; }

        public Book (int ItemId, string title, string author, int year, int pages) : base(ItemId, title, author, year)
        {
            
            this.Pages = pages;
        }

        string IDisplay.DisplayInfo()
        {
            return string.Format($"Type: {Type()} Title: {title}, Author: {author}, Year: {year}, Pages: {Pages}");
        }
        public override string Type()
        {
            return "Book";
        }
        

    }
}
